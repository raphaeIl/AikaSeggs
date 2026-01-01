using AikaSeggs.Common.Utils;
using AikaSeggs.PrivateClient;
using MessagePack;
using Newtonsoft.Json;
using Serilog;
using System;
using System.Collections.Generic;
using System.IO;

namespace AikaSeggs.Common.Services
{
    public static class ResourceService
    {
        public static string TablesDir = Path.Join(Config.ResourceDir, "Tables");
        private static string Md5ManifestPath = Path.Join(Config.ResourceDir, "md5_manifest.json");

        /// <summary>
        /// Load the cached MD5 manifest from disk
        /// </summary>
        /// <returns>Dictionary of cached MD5 hashes, or null if not found</returns>
        public static Dictionary<string, string>? LoadCachedMd5Manifest()
        {
            try
            {
                if (File.Exists(Md5ManifestPath))
                {
                    var json = File.ReadAllText(Md5ManifestPath);
                    return JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
                }
            }
            catch (Exception e)
            {
                Log.Warning(e, "Failed to load cached MD5 manifest");
            }
            return null;
        }

        /// <summary>
        /// Save the MD5 manifest to disk for future comparison
        /// </summary>
        /// <param name="md5Data">MD5 manifest to save</param>
        private static void SaveMd5Manifest(Dictionary<string, string> md5Data)
        {
            try
            {
                Directory.CreateDirectory(Config.ResourceDir);
                var json = JsonConvert.SerializeObject(md5Data, Formatting.Indented);
                File.WriteAllText(Md5ManifestPath, json);
                Log.Debug("Saved MD5 manifest to {Path}", Md5ManifestPath);
            }
            catch (Exception e)
            {
                Log.Warning(e, "Failed to save MD5 manifest");
            }
        }

        /// <summary>
        /// Download MD5 hash manifest for all master data tables
        /// </summary>
        /// <returns>Dictionary mapping endpoint names to MD5 hashes</returns>
        public static Dictionary<string, string>? GetMd5Data()
        {
            Log.Information("Fetching MD5 manifest...");

            var content = DeepOneClient.Instance.GetString("version/getMd5Data");
            if (content == null)
            {
                Log.Error("Failed to retrieve MD5 manifest");
                return null;
            }

            try
            {
                // MD5 endpoint returns JSON dictionary
                var md5Data = JsonConvert.DeserializeObject<Dictionary<string, string>>(content);
                Log.Information("Retrieved manifest for {Count} endpoints", md5Data?.Count ?? 0);
                return md5Data;
            }
            catch (Exception e)
            {
                Log.Error(e, "Failed to deserialize MD5 manifest");
                return null;
            }
        }

        /// <summary>
        /// Download a single master data table
        /// </summary>
        /// <param name="endpointName">Name from MD5 data (e.g., "getMasterBoostData")</param>
        /// <param name="md5Hash">MD5 hash to use as version parameter</param>
        /// <returns>True if successful</returns>
        public static bool DownloadMasterData(string endpointName, string md5Hash)
        {
            // Get the API path from TableEndpoints mapping
            if (!TableEndpoints.Endpoints.TryGetValue(endpointName, out var apiPath))
            {
                return false;
            }

            var tableName = Util.EndpointNameToTableName(endpointName);
            Log.Information("Downloading {TableName}...", tableName);

            var content = DeepOneClient.Instance.GetBytes($"{apiPath}?v={md5Hash}");
            if (content == null)
            {
                Log.Error("Failed to download {TableName}", tableName);
                return false;
            }

            try
            {
                // Decode msgpack binary response
                var data = MessagePackSerializer.Deserialize<object>(content);

                // Create output directory
                Directory.CreateDirectory(TablesDir);

                // Save to file with table name (without "get" prefix)
                var filename = $"{tableName}.json";
                var filepath = Path.Combine(TablesDir, filename);

                var json = JsonConvert.SerializeObject(data, Formatting.Indented);
                File.WriteAllText(filepath, json);

                return true;
            }
            catch (Exception e)
            {
                Log.Error(e, "Failed to process {TableName}", tableName);
                return false;
            }
        }

        /// <summary>
        /// Check which tables have updates available without downloading
        /// </summary>
        /// <returns>List of endpoint names that have updates</returns>
        public static List<string> CheckForUpdates()
        {
            var updates = new List<string>();

            try
            {
                var newMd5Data = GetMd5Data();
                if (newMd5Data == null)
                {
                    Log.Warning("Failed to retrieve MD5 manifest for update check");
                    return updates;
                }

                var cachedMd5Data = LoadCachedMd5Manifest();
                if (cachedMd5Data == null)
                {
                    Log.Information("No cached manifest found, all tables are new");
                    return new List<string>(newMd5Data.Keys);
                }

                foreach (var (endpointName, newMd5Hash) in newMd5Data)
                {
                    if (!TableEndpoints.Endpoints.ContainsKey(endpointName))
                        continue;

                    if (!cachedMd5Data.TryGetValue(endpointName, out var cachedMd5) || cachedMd5 != newMd5Hash)
                    {
                        updates.Add(endpointName);
                    }
                }

                Log.Information("Found {Count} table(s) with updates", updates.Count);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Failed to check for updates");
            }

            return updates;
        }

        /// <summary>
        /// Download all master data tables, only updating tables with changed MD5
        /// </summary>
        /// <param name="forceDownload">If true, download all tables regardless of MD5 changes</param>
        /// <returns>True if successful</returns>
        public static bool DownloadAllMasterData(bool forceDownload = false)
        {
            Log.Information("Starting master data download...");

            try
            {
                // Get current MD5 manifest from server
                var newMd5Data = GetMd5Data();

                if (newMd5Data == null)
                {
                    Log.Warning("Failed to retrieve MD5 manifest");
                    return false;
                }

                // Load cached MD5 manifest
                var cachedMd5Data = LoadCachedMd5Manifest();

                int total = newMd5Data.Count;
                int successful = 0;
                int failed = 0;
                int skipped = 0;
                int unchanged = 0;

                // Download each table
                foreach (var (endpointName, newMd5Hash) in newMd5Data)
                {
                    // Check if endpoint is mapped
                    if (!TableEndpoints.Endpoints.ContainsKey(endpointName))
                    {
                        skipped++;
                        Log.Information("Skipped (unmapped): {EndpointName}", endpointName);
                        continue;
                    }

                    // Check if MD5 has changed
                    bool needsDownload = forceDownload;
                    if (!forceDownload && cachedMd5Data != null && cachedMd5Data.TryGetValue(endpointName, out var cachedMd5))
                    {
                        if (cachedMd5 == newMd5Hash)
                        {
                            unchanged++;
                            var tableName = Util.EndpointNameToTableName(endpointName);
                            Log.Debug("Unchanged: {TableName} (MD5: {MD5})", tableName, newMd5Hash);
                            continue;
                        }
                        else
                        {
                            var tableName = Util.EndpointNameToTableName(endpointName);
                            Log.Information("Update detected: {TableName} (Old: {OldMD5} -> New: {NewMD5})", 
                                tableName, cachedMd5.Substring(0, 8), newMd5Hash.Substring(0, 8));
                            needsDownload = true;
                        }
                    }
                    else
                    {
                        // New table or no cache
                        needsDownload = true;
                    }

                    // Download if needed
                    if (needsDownload)
                    {
                        var success = DownloadMasterData(endpointName, newMd5Hash);

                        if (success)
                        {
                            successful++;
                        }
                        else
                        {
                            failed++;
                        }
                    }
                }

                // Save the new MD5 manifest for next time
                SaveMd5Manifest(newMd5Data);

                Log.Information("Download complete! Total: {Total} | Downloaded: {Successful} | Unchanged: {Unchanged} | Failed: {Failed} | Skipped: {Skipped}",
                    total, successful, unchanged, failed, skipped);
                Log.Information("Files saved to: {TablesDir}", TablesDir);

                return successful > 0 || unchanged > 0;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Failed during master data download");
                return false;
            }
        }
    }
}


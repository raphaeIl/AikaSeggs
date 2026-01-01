using AikaSeggs.Common.Utils;
using MessagePack;
using Newtonsoft.Json;
using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;

namespace AikaSeggs.Common.Services
{
    public static class ResourceService
    {
        private static readonly HttpClient httpClient;

        public static string TablesDir = Path.Join(Config.ResourceDir, "Tables");

        static ResourceService()
        {
            // Create HttpClientHandler with SSL validation disabled (like Python's verify=False)
            var handler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true
            };

            httpClient = new HttpClient(handler);

            // Add default headers
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");
            httpClient.DefaultRequestHeaders.Add("Accept", "*/*");
        }

        /// <summary>
        /// Download MD5 hash manifest for all master data tables
        /// </summary>
        /// <returns>Dictionary mapping endpoint names to MD5 hashes</returns>
        public static Dictionary<string, string>? GetMd5Data()
        {
            var url = $"{Config.BaseUrl}/version/getMd5Data";
            Log.Information("Fetching MD5 manifest from {Url}...", url);

            try
            {
                var response = httpClient.GetAsync(url).Result;
                response.EnsureSuccessStatusCode();

                var content = response.Content.ReadAsStringAsync().Result;

                // MD5 endpoint returns JSON dictionary
                var md5Data = JsonConvert.DeserializeObject<Dictionary<string, string>>(content);

                Log.Information("Retrieved manifest for {Count} endpoints", md5Data?.Count ?? 0);
                return md5Data;
            }
            catch (Exception e)
            {
                Log.Error(e, "Failed to retrieve MD5 manifest");
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
            var url = $"{Config.BaseUrl}/{apiPath}?v={md5Hash}";
            Log.Information("Downloading {TableName}...", tableName);

            try
            {
                var response = httpClient.GetAsync(url).Result;
                response.EnsureSuccessStatusCode();

                var content = response.Content.ReadAsByteArrayAsync().Result;

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
                Log.Error(e, "Failed to download {TableName}", tableName);
                return false;
            }
        }

        /// <summary>
        /// Download all master data tables
        /// </summary>
        /// <returns>True if successful</returns>
        public static bool DownloadAllMasterData()
        {
            Log.Information("Starting master data download...");

            try
            {
                // Get MD5 manifest
                var md5Data = GetMd5Data();

                if (md5Data == null)
                {
                    Log.Warning("Failed to retrieve MD5 manifest");
                    return false;
                }

                int total = md5Data.Count;
                int successful = 0;
                int failed = 0;
                int skipped = 0;

                // Download each table
                foreach (var (endpointName, md5Hash) in md5Data)
                {
                    var success = DownloadMasterData(endpointName, md5Hash);

                    if (success)
                    {
                        successful++;
                    }
                    else
                    {
                        if (!TableEndpoints.Endpoints.ContainsKey(endpointName))
                        {
                            skipped++;
                            Log.Information("Skipped: {EndpointName}", endpointName);
                        }
                        else
                        {
                            failed++;
                        }
                    }
                }

                Log.Information("Download complete! Total: {Total} | Successful: {Successful} | Failed: {Failed} | Skipped: {Skipped}",
                    total, successful, failed, skipped);
                Log.Information("Files saved to: {TablesDir}", TablesDir);

                return successful > 0;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Failed during master data download");
                return false;
            }
        }
    }
}


using AikaSeggs.Common.Core;
using AikaSeggs.Common.Tables;
using AikaSeggs.Common.Utils;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace AikaSeggs.Common.Services
{
    /// <summary>
    /// Service for loading and caching master data tables.
    /// All operations MUST be thread-safe.
    /// </summary>
    public class TableService
    {
        private readonly ILogger logger;
        private readonly Dictionary<Type, ITable> caches = new();
        private readonly object cacheLock = new();

        public static string TablesDir = Path.Join(Config.ResourceDir, "Tables");

        // JsonSerializerSettings to preserve exact casing for round-trip serialization
        private static readonly JsonSerializerSettings settings = new()
        {
            ContractResolver = new CamelCasePropertyNamesContractResolver(),
            NullValueHandling = NullValueHandling.Include,
            Formatting = Formatting.None
        };

        public TableService(ILogger? logger = null)
        {
            this.logger = logger ?? Log.Logger;
        }

        /// <summary>
        /// Get a table by type. Table must have a corresponding JSON file.
        /// </summary>
        /// <typeparam name="T">Table type (e.g., MasterBoostData)</typeparam>
        /// <param name="bypassCache">If true, reload from file even if cached</param>
        /// <returns>Loaded table instance</returns>
        /// <exception cref="FileNotFoundException">If table file doesn't exist</exception>
        public T GetTable<T>(bool bypassCache = false) where T : class, ITable, new()
        {
            var type = typeof(T);
            var tableName = type.Name;

            lock (cacheLock)
            {
                if (!bypassCache && caches.TryGetValue(type, out var cache))
                {
                    return (T)cache;
                }

                var tableFilePath = Path.Combine(TablesDir, $"{tableName}.json");

                if (!File.Exists(tableFilePath))
                {
                    throw new FileNotFoundException($"Table file not found: {tableFilePath}");
                }

                try
                {
                    var json = File.ReadAllText(tableFilePath);
                    var table = JsonConvert.DeserializeObject<T>(json, settings);

                    if (table == null)
                    {
                        throw new InvalidOperationException($"Failed to deserialize table: {tableName}");
                    }

                    caches[type] = table;
                    logger.Debug("{Table} loaded and cached", tableName);

                    return table;
                }
                catch (JsonException ex)
                {
                    logger.Error(ex, "Failed to deserialize table: {Table}", tableName);
                    throw;
                }
            }
        }

        /// <summary>
        /// Get a table by Protocol enum value.
        /// Maps Protocol -> endpoint path -> table name -> table type.
        /// </summary>
        /// <param name="protocol">Protocol enum value (e.g., Protocol.Boost_GetMasterData)</param>
        /// <param name="bypassCache">If true, reload from file even if cached</param>
        /// <returns>Loaded table instance, or null if not found</returns>
        public ITable? GetTableByProtocol(Protocol protocol, bool bypassCache = false)
        {
            // Find endpoint path from protocol
            var endpointPath = GetEndpointPathFromProtocol(protocol);
            if (string.IsNullOrEmpty(endpointPath))
            {
                logger.Warning("No endpoint path found for protocol: {Protocol}", protocol);
                return null;
            }

            // Find endpoint name from path (reverse lookup in TableEndpoints)
            var endpointName = TableEndpoints.Endpoints.FirstOrDefault(x => x.Value == endpointPath).Key;
            if (string.IsNullOrEmpty(endpointName))
            {
                logger.Warning("No endpoint name found for path: {Path}", endpointPath);
                return null;
            }

            // Convert endpoint name to table name
            var tableName = Util.EndpointNameToTableName(endpointName);

            // Find table type by name
            var tableType = FindTableTypeByName(tableName);
            if (tableType == null)
            {
                logger.Warning("No table type found for table name: {TableName}", tableName);
                return null;
            }

            // Use reflection to call GetTable<T> with the found type
            var method = typeof(TableService).GetMethod(nameof(GetTable), new[] { typeof(bool) });
            var genericMethod = method!.MakeGenericMethod(tableType);
            
            try
            {
                return (ITable?)genericMethod.Invoke(this, new object[] { bypassCache });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Failed to load table by protocol: {Protocol}", protocol);
                return null;
            }
        }

        /// <summary>
        /// Get raw JSON string for a table without deserialization.
        /// Useful for protocol handlers that need to return data as-is.
        /// </summary>
        /// <param name="tableName">Table name (e.g., "MasterBoostData")</param>
        /// <returns>Raw JSON string, or null if file not found</returns>
        public string? GetTableJson(string tableName)
        {
            var tableFilePath = Path.Combine(TablesDir, $"{tableName}.json");

            if (!File.Exists(tableFilePath))
            {
                logger.Warning("Table file not found: {TableName}", tableName);
                return null;
            }

            try
            {
                return File.ReadAllText(tableFilePath);
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Failed to read table JSON: {TableName}", tableName);
                return null;
            }
        }

        /// <summary>
        /// Get raw JSON string for a table by Protocol enum value.
        /// </summary>
        /// <param name="protocol">Protocol enum value</param>
        /// <returns>Raw JSON string, or null if not found</returns>
        public string? GetTableJsonByProtocol(Protocol protocol)
        {
            // Step 1: Protocol enum -> endpoint path
            // Boost_GetMasterData -> boost/getMasterData
            var endpointPath = GetEndpointPathFromProtocol(protocol);
            if (string.IsNullOrEmpty(endpointPath))
            {
                logger.Warning("No endpoint path found for protocol: {Protocol}", protocol);
                return null;
            }

            // Step 2: Endpoint path -> endpoint name (reverse lookup)
            // boost/getMasterData -> getMasterBoostData
            var endpointName = TableEndpoints.Endpoints.FirstOrDefault(x => x.Value == endpointPath).Key;
            if (string.IsNullOrEmpty(endpointName))
            {
                logger.Warning("No endpoint name found for path: {Path}", endpointPath);
                return null;
            }

            // Step 3: Endpoint name -> table name (remove "get" prefix)
            // getMasterBoostData -> MasterBoostData
            var tableName = Util.EndpointNameToTableName(endpointName);
            
            logger.Debug("Protocol {Protocol} -> Path: {Path} -> Endpoint: {Endpoint} -> Table: {Table}", 
                protocol, endpointPath, endpointName, tableName);

            return GetTableJson(tableName);
        }

        /// <summary>
        /// Get endpoint path from Protocol enum value.
        /// Protocol.Boost_GetMasterData -> "boost/getMasterData"
        /// </summary>
        private string? GetEndpointPathFromProtocol(Protocol protocol)
        {
            // Convert Protocol enum to endpoint path format
            // Protocol.Boost_GetMasterData -> "boost/getMasterData"
            var protocolStr = protocol.ToString();
            
            // Find underscore position
            var underscoreIndex = protocolStr.IndexOf('_');
            if (underscoreIndex == -1)
            {
                return null;
            }

            // Split: "Boost" and "GetMasterData" or "LoginBonus" and "GetMasterData"
            var prefix = protocolStr.Substring(0, underscoreIndex);
            var suffix = protocolStr.Substring(underscoreIndex + 1);

            // Only lowercase the first letter of each part
            // "Boost" -> "boost", "LoginBonus" -> "loginBonus"
            // "GetMasterData" -> "getMasterData"
            var lowerPrefix = char.ToLowerInvariant(prefix[0]) + prefix.Substring(1);
            var lowerSuffix = char.ToLowerInvariant(suffix[0]) + suffix.Substring(1);

            // Format: "boost/getMasterData" or "loginBonus/getMasterData"
            var path = $"{lowerPrefix}/{lowerSuffix}";

            // Check if this path exists in TableEndpoints
            if (TableEndpoints.Endpoints.ContainsValue(path))
            {
                return path;
            }

            return null;
        }

        /// <summary>
        /// Find table type by name using reflection.
        /// Searches in AikaSeggs.Common namespace for classes implementing ITable.
        /// </summary>
        private Type? FindTableTypeByName(string tableName)
        {
            // Search in the assembly where ITable is defined
            var assembly = typeof(ITable).Assembly;
            var tableTypes = assembly.GetTypes()
                .Where(t => t.IsClass && 
                           !t.IsAbstract && 
                           typeof(ITable).IsAssignableFrom(t) &&
                           t.Name == tableName)
                .FirstOrDefault();

            return tableTypes;
        }

        /// <summary>
        /// Clear all cached tables. Useful for testing or forced reloads.
        /// </summary>
        public void ClearCache()
        {
            lock (cacheLock)
            {
                caches.Clear();
                logger.Debug("Table cache cleared");
            }
        }

        /// <summary>
        /// Get count of cached tables.
        /// </summary>
        public int GetCacheCount()
        {
            lock (cacheLock)
            {
                return caches.Count;
            }
        }
    }

    /// <summary>
    /// Extension methods for dependency injection registration.
    /// </summary>
    public static class TableServiceExtensions
    {
        public static void AddTableService(this IServiceCollection services)
        {
            services.AddSingleton<TableService>();
        }
    }
}


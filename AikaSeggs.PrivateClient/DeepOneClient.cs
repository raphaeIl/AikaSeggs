using AikaSeggs.PrivateClient.Utils;
using Serilog;
using System;
using System.Net.Http;

namespace AikaSeggs.PrivateClient
{
    /// <summary>
    /// Singleton HTTP client for communicating with DeepOne API
    /// </summary>
    public class DeepOneClient : Singleton<DeepOneClient>
    {
        private readonly HttpClient httpClient;

        public DeepOneClient()
        {
            // Create HttpClientHandler with SSL validation disabled
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
        /// Make a GET request to the DeepOne API
        /// </summary>
        /// <param name="endpoint">API endpoint (e.g., "version/getMd5Data")</param>
        /// <returns>Response content as string, or null on failure</returns>
        public string? GetString(string endpoint)
        {
            try
            {
                var url = $"{Config.BaseUrl}/{endpoint}";
                var response = httpClient.GetAsync(url).Result;
                response.EnsureSuccessStatusCode();
                return response.Content.ReadAsStringAsync().Result;
            }
            catch (Exception e)
            {
                Log.Error(e, "Failed to GET {Endpoint}", endpoint);
                return null;
            }
        }

        /// <summary>
        /// Make a GET request to the DeepOne API and return binary response
        /// </summary>
        /// <param name="endpoint">API endpoint (e.g., "boost/getMasterData?v=hash")</param>
        /// <returns>Response content as byte array, or null on failure</returns>
        public byte[]? GetBytes(string endpoint)
        {
            try
            {
                var url = $"{Config.BaseUrl}/{endpoint}";
                var response = httpClient.GetAsync(url).Result;
                response.EnsureSuccessStatusCode();
                return response.Content.ReadAsByteArrayAsync().Result;
            }
            catch (Exception e)
            {
                Log.Error(e, "Failed to GET {Endpoint}", endpoint);
                return null;
            }
        }

        /// <summary>
        /// Make a GET request to a full URL (not using base URL)
        /// </summary>
        /// <param name="url">Full URL</param>
        /// <returns>Response content as string, or null on failure</returns>
        public string? GetStringFromUrl(string url)
        {
            try
            {
                var response = httpClient.GetAsync(url).Result;
                response.EnsureSuccessStatusCode();
                return response.Content.ReadAsStringAsync().Result;
            }
            catch (Exception e)
            {
                Log.Error(e, "Failed to GET {Url}", url);
                return null;
            }
        }

        /// <summary>
        /// Make a GET request to a full URL and return binary response
        /// </summary>
        /// <param name="url">Full URL</param>
        /// <returns>Response content as byte array, or null on failure</returns>
        public byte[]? GetBytesFromUrl(string url)
        {
            try
            {
                var response = httpClient.GetAsync(url).Result;
                response.EnsureSuccessStatusCode();
                return response.Content.ReadAsByteArrayAsync().Result;
            }
            catch (Exception e)
            {
                Log.Error(e, "Failed to GET {Url}", url);
                return null;
            }
        }
    }
}


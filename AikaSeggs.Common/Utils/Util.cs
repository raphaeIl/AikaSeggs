using AikaSeggs.Common.Core;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AikaSeggs.Common.Utils
{
    public static class Util
    {
        public static void PrintDictionary<TKey, TValue>(Dictionary<TKey, TValue> dictionary)
        {
            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }

        public static string ConvertToPascalCase(string path)
        {
            return string.Concat(path
                .Split('/')
                .Select(word => CultureInfo.InvariantCulture.TextInfo.ToTitleCase(word)));
        }

        public static Protocol GetProtocolFromRoute(string path)
        {
            // Convert "auth/getDmmAccessToken" to "Auth_GetDmmAccessToken"
            string protocolName = string.Join("_", path
                .Split('/')
                .Select(word => string.IsNullOrEmpty(word) ? word : char.ToUpper(word[0]) + word.Substring(1)));
 
            Console.WriteLine(protocolName);
            if (Enum.TryParse<Protocol>(protocolName, out Protocol protocol))
            {
                return protocol;
            } 
            
            else
            {
                return Protocol.Unknown;
            }
        }
    }
}

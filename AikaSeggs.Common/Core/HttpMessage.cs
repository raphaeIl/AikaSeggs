using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AikaSeggs.Common.Core
{
    public class HttpMessage
    {
        public string Content { get; private set; } // Serialized Packet (JSON)

        public bool DoMsgPack { get; set; }

        public Dictionary<string, string>? Headers { get; init; }

        private HttpMessage(string packet, bool doMsgPack = false, Dictionary<string, string>? customHeaders = null)
        {
            Content = packet;
            DoMsgPack = doMsgPack;

            // init with default headers
            Headers = new Dictionary<string, string>();

            // Set standard headers
            Headers["Date"] = DateTimeOffset.UtcNow.ToString("r"); // RFC1123 format
            Headers["Content-Type"] = "application/json; charset=utf-8";
            Headers["Server"] = "nginx";
            Headers["X-DNS-Prefetch-Control"] = "off";
            Headers["X-Frame-Options"] = "SAMEORIGIN";
            Headers["Strict-Transport-Security"] = "max-age=15552000; includeSubDomains";
            Headers["X-Download-Options"] = "noopen";
            Headers["X-Content-Type-Options"] = "nosniff";
            Headers["X-XSS-Protection"] = "1; mode=block";
            Headers["Access-Control-Allow-Origin"] = "*";
            Headers["Access-Control-Allow-Headers"] = "Origin, X-Requested-With, Content-Type, Accept, Authorization, X-Deep-One-App-Version";
            Headers["Access-Control-Allow-Methods"] = "POST, GET, OPTIONS";
            Headers["Access-Control-Allow-Credentials"] = "true";

            if (customHeaders != null)
            {
                foreach (var header in customHeaders) // supports overriding
                {
                    Headers[header.Key] = header.Value;
                }
            }
        }

        public static HttpMessage Create(IMessage packet, bool doMsgPack = false, Dictionary<string, string>? customHeaders = null)
        {
            return new HttpMessage(JsonConvert.SerializeObject(packet), doMsgPack, customHeaders);
        }

        public static HttpMessage Create(string jsonPacket, bool doMsgPack = false, Dictionary<string, string>? customHeaders = null)
        {
            return new HttpMessage(jsonPacket, doMsgPack, customHeaders);
        }

    }
}

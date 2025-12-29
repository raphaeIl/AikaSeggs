using AikaSeggs.Common;
using AikaSeggs.Common.Core;
using AikaSeggs.Common.Utils;
using AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using MessagePack;
using Serilog;
using System.IO.Compression;
using System.Reflection;
using System.Text;
using System.Text.Json;

namespace AikaSeggs.GameServer.Controllers.Api
{
    [Route("deep-one/api/{*path}")] // catch-all segment to capture any route after /deep-one/api/
    public class GatewayController : ControllerBase
    {
        private readonly IProtocolHandlerFactory protocolHandlerFactory;
        private readonly ILogger<GatewayController> logger;

        public GatewayController(IProtocolHandlerFactory _protocolHandlerFactory, ILogger<GatewayController> _logger)
        {
            protocolHandlerFactory = _protocolHandlerFactory;
            logger = _logger;
        }

        [HttpGet, HttpPost]
        public IResult PostRequest(string path)
        {
            Log.Information("Gateway Post Request from: {path}", path);
            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,  // Skip nulls
                DefaultValueHandling = DefaultValueHandling.Ignore,  // Skip defaults
                Formatting = Formatting.None  // No pretty print
            };
            Protocol protocol = Util.GetProtocolFromRoute(path);

            if (protocol == Protocol.Unknown)
            {
                Log.Error("Could not find protocol for path: {path}", path);
            }

            string reqBody;

            using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
            {
                reqBody = reader.ReadToEnd();
            }

            Log.Information("reqBody: " + reqBody);

            //Type packetClassType = Assembly.GetAssembly(typeof(AccountAuthorize))!.GetTypes().Where(x => x.Name == protocol.ToString()).SingleOrDefault();

            //IMessage reqPacket = (IMessage)JsonSerializer.Deserialize(reqBody, packetClassType);

            //HttpMessage reqMessage = HttpMessage.Create(reqBody);

            // resp
            HttpMessage respMessage = protocolHandlerFactory.Invoke(protocol);

            if (respMessage is null)
            {
                Log.Error("Protocol {protocol} is unimplemented and left unhandled", protocol);

                return Results.Empty;
            }

            // Set headers
            foreach (var header in respMessage.Headers)
            {
                HttpContext.Response.Headers[header.Key] = header.Value;
            }

            // Handle MessagePack responses
            if (respMessage.DoMsgPack)
            {
                // Convert JSON string directly to MessagePack bytes
                byte[] respBytes = MessagePackSerializer.ConvertFromJson(respMessage.Content);

                HttpContext.Response.ContentType = "application/octet-stream";
                HttpContext.Response.ContentLength = respBytes.Length;
                HttpContext.Response.Body.Write(respBytes, 0, respBytes.Length);

                return Results.Empty;
            }

            // Default JSON response
            return Results.Content(respMessage.Content, "application/json; charset=utf-8");
        }
    }
}
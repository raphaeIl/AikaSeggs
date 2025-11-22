using AikaSeggs.Common.Core;
using AikaSeggs.Common.Utils;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using System.IO.Compression;
using System.Reflection;
using System.Text;
using System.Text.Json;
using AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers;

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

            HttpMessage reqMessage = HttpMessage.Create(reqBody);

            // resp
            HttpMessage respMessage = protocolHandlerFactory.Invoke(protocol, reqMessage);

            if (respMessage is null)
            {
                Log.Error("Protocol {protocol} is unimplemented and left unhandled", protocol);

                return Results.Empty;
            }

            // Set standard headers
            Response.Headers.Append("Access-Control-Allow-Credentials", "true");
            Response.Headers.Append("X-DNS-Prefetch-Control", "off");
            Response.Headers.Append("X-Frame-Options", "SAMEORIGIN");
            Response.Headers.Append("Strict-Transport-Security", "max-age=15552000; includeSubDomains");
            Response.Headers.Append("X-Download-Options", "noopen");
            Response.Headers.Append("X-Content-Type-Options", "nosniff");
            Response.Headers.Append("X-XSS-Protection", "1; mode=block");
            Response.Headers.Append("Access-Control-Allow-Origin", "*");
            Response.Headers.Append("Access-Control-Allow-Headers", "Origin, X-Requested-With, Content-Type, Accept, Authorization, X-Deep-One-App-Version");
            Response.Headers.Append("Access-Control-Allow-Methods", "POST, GET, OPTIONS");

            return Results.Content(respMessage.Packet, "application/json; charset=utf-8");
            //byte[] respBytes = respMessage.Packet.ToByteArray();

            //HttpContext.Response.ContentType = "application/protobuf";

            //foreach (var header in respMessage.Headers)
            //{
            //    HttpContext.Response.Headers[header.Key] = header.Value;
            //}
                
            //if (respMessage.DoGzip)
            //{
            //    HttpContext.Response.Headers["Content-Encoding"] = "gzip";
            //    using var gzip = new GZipStream(HttpContext.Response.Body, CompressionLevel.Fastest, leaveOpen: true);
            //    gzip.Write(respBytes, 0, respBytes.Length);
            //} else
            //{
            //    HttpContext.Response.ContentLength = respBytes.Length;
            //    HttpContext.Response.Body.Write(respBytes, 0, respBytes.Length);
            //}
        }
    }
}
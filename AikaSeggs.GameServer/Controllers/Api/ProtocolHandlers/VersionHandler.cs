using AikaSeggs.Common;
using AikaSeggs.Common.Core;
using AikaSeggs.Common.Services;
using AikaSeggs.PcapParser;
using Newtonsoft.Json;

namespace AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers
{
    public class VersionHandler : ProtocolHandlerBase
    {
        public VersionHandler(IProtocolHandlerFactory protocolHandlerFactory) : base(protocolHandlerFactory) { }

        [ProtocolHandler(Protocol.Version_GetMd5Data)]
        public HttpMessage VersionGetMd5Data()
        {
            var md5Data = ResourceService.LoadCachedMd5Manifest();
            if (md5Data == null)
            {
                throw new InvalidDataException("Failed to load cached MD5 manifest");
            }

            var json = JsonConvert.SerializeObject(md5Data);
            return HttpMessage.Create(json, false);
        }
    }
}


using AikaSeggs.Common;
using AikaSeggs.Common.Core;
using AikaSeggs.PcapParser;

namespace AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers
{
    public class VersionHandler : ProtocolHandlerBase
    {
        public VersionHandler(IProtocolHandlerFactory protocolHandlerFactory) : base(protocolHandlerFactory) { }

        [ProtocolHandler(Protocol.Version_GetMd5Data)]
        public HttpMessage VersionGetMd5Data()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Version_GetMd5Data);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }
    }
}


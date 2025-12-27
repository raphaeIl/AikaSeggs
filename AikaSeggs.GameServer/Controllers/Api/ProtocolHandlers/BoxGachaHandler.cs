using AikaSeggs.Common;
using AikaSeggs.Common.Core;
using AikaSeggs.PcapParser;

namespace AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers
{
    public class BoxGachaHandler : ProtocolHandlerBase
    {
        public BoxGachaHandler(IProtocolHandlerFactory protocolHandlerFactory) : base(protocolHandlerFactory) { }

        [ProtocolHandler(Protocol.BoxGacha_GetBoxDetail)]
        public HttpMessage BoxGachaGetBoxDetail()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.BoxGacha_GetBoxDetail);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }
    }
}


using AikaSeggs.Common;
using AikaSeggs.Common.Core;
using AikaSeggs.PcapParser;

namespace AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers
{
    public class PresentHandler : ProtocolHandlerBase
    {
        public PresentHandler(IProtocolHandlerFactory protocolHandlerFactory) : base(protocolHandlerFactory) { }

        [ProtocolHandler(Protocol.Present_GetList)]
        public HttpMessage PresentGetList()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Present_GetList);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.Present_Receive)]
        public HttpMessage PresentReceive()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Present_Receive);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }
    }
}


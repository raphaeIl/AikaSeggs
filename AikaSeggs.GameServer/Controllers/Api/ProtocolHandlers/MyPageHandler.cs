using AikaSeggs.Common;
using AikaSeggs.Common.Core;
using AikaSeggs.PcapParser;

namespace AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers
{
    public class MyPageHandler : ProtocolHandlerBase
    {
        public MyPageHandler(IProtocolHandlerFactory protocolHandlerFactory) : base(protocolHandlerFactory) { }

        [ProtocolHandler(Protocol.MyPage_Refresh)]
        public HttpMessage MyPageRefresh()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.MyPage_Refresh);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }
    }
}


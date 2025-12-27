using AikaSeggs.Common;
using AikaSeggs.Common.Core;
using AikaSeggs.PcapParser;

namespace AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers
{
    public class GachaHandler : ProtocolHandlerBase
    {
        public GachaHandler(IProtocolHandlerFactory protocolHandlerFactory) : base(protocolHandlerFactory) { }

        [ProtocolHandler(Protocol.Gacha_GetUserData)]
        public HttpMessage GachaGetUserData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Gacha_GetUserData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.Gacha_GetDetail)]
        public HttpMessage GachaGetDetail()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Gacha_GetDetail);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.Gacha_GetList)]
        public HttpMessage GachaGetList()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Gacha_GetList);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.Gacha_Play)]
        public HttpMessage GachaPlay()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Gacha_Play);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }
    }
}


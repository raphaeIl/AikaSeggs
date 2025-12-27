using AikaSeggs.Common;
using AikaSeggs.Common.Core;
using AikaSeggs.PcapParser;

namespace AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers
{
    public class ShopHandler : ProtocolHandlerBase
    {
        public ShopHandler(IProtocolHandlerFactory protocolHandlerFactory) : base(protocolHandlerFactory) { }

        [ProtocolHandler(Protocol.Shop_GetUserData)]
        public HttpMessage ShopGetUserData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Shop_GetUserData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.Shop_Exchange)]
        public HttpMessage ShopExchange()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Shop_Exchange);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.Shop_GetOrderPack)]
        public HttpMessage ShopGetOrderPack()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Shop_GetOrderPack);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.Shop_Purchase)]
        public HttpMessage ShopPurchase()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Shop_Purchase);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }
    }
}


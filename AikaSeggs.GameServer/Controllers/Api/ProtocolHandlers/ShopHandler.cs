using AikaSeggs.Common;
using AikaSeggs.Common.Core;
using AikaSeggs.Common.Services;
using AikaSeggs.PcapParser;

namespace AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers
{
    public class ShopHandler : ProtocolHandlerBase
    {
        private readonly TableService tableService;

        public ShopHandler(IProtocolHandlerFactory protocolHandlerFactory, TableService tableService) 
            : base(protocolHandlerFactory)
        {
            this.tableService = tableService;
        }

        [ProtocolHandler(Protocol.Shop_GetMasterData)]
        public HttpMessage ShopGetMasterData()
        {
            var tableJson = tableService.GetTableJsonByProtocol(Protocol.Shop_GetMasterData);
            return HttpMessage.Create(tableJson, doMsgPack: true);
        }

        [ProtocolHandler(Protocol.Shop_GetMasterExchangePointDetailData)]
        public HttpMessage ShopGetMasterExchangePointDetailData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Shop_GetMasterExchangePointDetailData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.Shop_GetMasterExchangeItemDetailData)]
        public HttpMessage ShopGetMasterExchangeItemDetailData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Shop_GetMasterExchangeItemDetailData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.Shop_GetMasterExchangeItemDetailData2)]
        public HttpMessage ShopGetMasterExchangeItemDetailData2()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Shop_GetMasterExchangeItemDetailData2);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.Shop_GetUserData)]
        public HttpMessage ShopGetUserData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Shop_GetUserData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.Shop_Exchange)]
        public HttpMessage ShopExchange()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Shop_Exchange);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.Shop_GetOrderPack)]
        public HttpMessage ShopGetOrderPack()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Shop_GetOrderPack);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.Shop_Purchase)]
        public HttpMessage ShopPurchase()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Shop_Purchase);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }
    }
}


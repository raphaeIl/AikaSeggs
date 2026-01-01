using AikaSeggs.Common;
using AikaSeggs.Common.Core;
using AikaSeggs.Common.Services;
using AikaSeggs.PcapParser;

namespace AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers
{
    public class ItemHandler : ProtocolHandlerBase
    {
        private readonly TableService tableService;

        public ItemHandler(IProtocolHandlerFactory protocolHandlerFactory, TableService tableService) 
            : base(protocolHandlerFactory)
        {
            this.tableService = tableService;
        }

        [ProtocolHandler(Protocol.Item_GetMasterData)]
        public HttpMessage ItemGetMasterData()
        {
            var tableJson = tableService.GetTableJsonByProtocol(Protocol.Item_GetMasterData);
            return HttpMessage.Create(tableJson, doMsgPack: true);
        }

        [ProtocolHandler(Protocol.Item_GetMasterItemSetData)]
        public HttpMessage ItemGetMasterItemSetData()
        {
            var tableJson = tableService.GetTableJsonByProtocol(Protocol.Item_GetMasterItemSetData);
            return HttpMessage.Create(tableJson, doMsgPack: true);
        }

        [ProtocolHandler(Protocol.Item_GetMasterItemSetData2)]
        public HttpMessage ItemGetMasterItemSetData2()
        {
            var tableJson = tableService.GetTableJsonByProtocol(Protocol.Item_GetMasterItemSetData2);
            return HttpMessage.Create(tableJson, doMsgPack: true);
        }

        [ProtocolHandler(Protocol.Item_GetUserData)]
        public HttpMessage ItemGetUserData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Item_GetUserData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.Item_Use)]
        public HttpMessage ItemUse()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Item_Use);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }
    }
}


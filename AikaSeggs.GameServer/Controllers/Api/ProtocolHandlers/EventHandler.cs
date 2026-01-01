using AikaSeggs.Common;
using AikaSeggs.Common.Core;
using AikaSeggs.Common.Services;
using AikaSeggs.PcapParser;

namespace AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers
{
    public class EventHandler : ProtocolHandlerBase
    {
        private readonly TableService tableService;

        public EventHandler(IProtocolHandlerFactory protocolHandlerFactory, TableService tableService) 
            : base(protocolHandlerFactory)
        {
            this.tableService = tableService;
        }

        [ProtocolHandler(Protocol.Event_GetMasterData)]
        public HttpMessage EventGetMasterData()
        {
            var tableJson = tableService.GetTableJsonByProtocol(Protocol.Event_GetMasterData);
            return HttpMessage.Create(tableJson, doMsgPack: true);
        }

        [ProtocolHandler(Protocol.Event_GetUserData)]
        public HttpMessage EventGetUserData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Event_GetUserData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.Event_SkipBattle)]
        public HttpMessage EventSkipBattle()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Event_SkipBattle);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }
    }
}


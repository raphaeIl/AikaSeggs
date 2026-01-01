using AikaSeggs.Common;
using AikaSeggs.Common.Core;
using AikaSeggs.Common.Services;
using AikaSeggs.PcapParser;

namespace AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers
{
    public class TowerHandler : ProtocolHandlerBase
    {
        private readonly TableService tableService;

        public TowerHandler(IProtocolHandlerFactory protocolHandlerFactory, TableService tableService) 
            : base(protocolHandlerFactory)
        {
            this.tableService = tableService;
        }

        [ProtocolHandler(Protocol.Tower_GetMasterData)]
        public HttpMessage TowerGetMasterData()
        {
            var tableJson = tableService.GetTableJsonByProtocol(Protocol.Tower_GetMasterData);
            return HttpMessage.Create(tableJson, doMsgPack: true);
        }

        [ProtocolHandler(Protocol.Tower_GetUserData)]
        public HttpMessage TowerGetUserData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Tower_GetUserData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.Tower_GetAreaData)]
        public HttpMessage TowerGetAreaData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Tower_GetAreaData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.Tower_Select)]
        public HttpMessage TowerSelect()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Tower_Select);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }
    }
}


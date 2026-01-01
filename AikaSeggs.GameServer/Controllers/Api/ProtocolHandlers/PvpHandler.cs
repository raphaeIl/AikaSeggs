using AikaSeggs.Common;
using AikaSeggs.Common.Core;
using AikaSeggs.Common.Services;
using AikaSeggs.PcapParser;

namespace AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers
{
    public class PvpHandler : ProtocolHandlerBase
    {
        private readonly TableService tableService;

        public PvpHandler(IProtocolHandlerFactory protocolHandlerFactory, TableService tableService) 
            : base(protocolHandlerFactory)
        {
            this.tableService = tableService;
        }

        [ProtocolHandler(Protocol.Pvp_GetMasterData)]
        public HttpMessage PvpGetMasterData()
        {
            var tableJson = tableService.GetTableJsonByProtocol(Protocol.Pvp_GetMasterData);
            return HttpMessage.Create(tableJson, doMsgPack: true);
        }

        [ProtocolHandler(Protocol.Pvp_GetUserData)]
        public HttpMessage PvpGetUserData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Pvp_GetUserData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.Pvp_GetBattlePlayers)]
        public HttpMessage PvpGetBattlePlayers()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Pvp_GetBattlePlayers);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }
    }
}


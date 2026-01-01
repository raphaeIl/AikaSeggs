using AikaSeggs.Common;
using AikaSeggs.Common.Core;
using AikaSeggs.Common.Services;
using AikaSeggs.PcapParser;

namespace AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers
{
    public class CabinMissionHandler : ProtocolHandlerBase
    {
        private readonly TableService tableService;

        public CabinMissionHandler(IProtocolHandlerFactory protocolHandlerFactory, TableService tableService) 
            : base(protocolHandlerFactory)
        {
            this.tableService = tableService;
        }

        [ProtocolHandler(Protocol.CabinMission_GetMasterData)]
        public HttpMessage CabinMissionGetMasterData()
        {
            var tableJson = tableService.GetTableJsonByProtocol(Protocol.CabinMission_GetMasterData);
            return HttpMessage.Create(tableJson!, doMsgPack: true);
        }

        [ProtocolHandler(Protocol.CabinMission_GetUserData)]
        public HttpMessage CabinMissionGetUserData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.CabinMission_GetUserData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }
    }
}


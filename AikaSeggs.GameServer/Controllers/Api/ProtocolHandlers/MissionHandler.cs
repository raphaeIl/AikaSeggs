using AikaSeggs.Common;
using AikaSeggs.Common.Core;
using AikaSeggs.Common.Services;
using AikaSeggs.PcapParser;

namespace AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers
{
    public class MissionHandler : ProtocolHandlerBase
    {
        private readonly TableService tableService;

        public MissionHandler(IProtocolHandlerFactory protocolHandlerFactory, TableService tableService) 
            : base(protocolHandlerFactory)
        {
            this.tableService = tableService;
        }

        [ProtocolHandler(Protocol.Mission_GetMasterData)]
        public HttpMessage MissionGetMasterData()
        {
            var tableJson = tableService.GetTableJsonByProtocol(Protocol.Mission_GetMasterData);
            return HttpMessage.Create(tableJson, doMsgPack: true);
        }

        [ProtocolHandler(Protocol.Mission_GetMasterMissionDetailData)]
        public HttpMessage MissionGetMasterMissionDetailData()
        {
            var tableJson = tableService.GetTableJsonByProtocol(Protocol.Mission_GetMasterMissionDetailData);
            return HttpMessage.Create(tableJson, doMsgPack: true);
        }

        [ProtocolHandler(Protocol.Mission_GetMasterMissionDetailData2)]
        public HttpMessage MissionGetMasterMissionDetailData2()
        {
            var tableJson = tableService.GetTableJsonByProtocol(Protocol.Mission_GetMasterMissionDetailData2);
            return HttpMessage.Create(tableJson, doMsgPack: true);
        }

        [ProtocolHandler(Protocol.Mission_GetMasterMissionDetailData3)]
        public HttpMessage MissionGetMasterMissionDetailData3()
        {
            var tableJson = tableService.GetTableJsonByProtocol(Protocol.Mission_GetMasterMissionDetailData3);
            return HttpMessage.Create(tableJson, doMsgPack: true);
        }

        [ProtocolHandler(Protocol.Mission_GetMasterMissionDetailData4)]
        public HttpMessage MissionGetMasterMissionDetailData4()
        {
            var tableJson = tableService.GetTableJsonByProtocol(Protocol.Mission_GetMasterMissionDetailData4);
            return HttpMessage.Create(tableJson, doMsgPack: true);
        }

        [ProtocolHandler(Protocol.Mission_GetUserData)]
        public HttpMessage MissionGetUserData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Mission_GetUserData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.Mission_UpdateMissionProgressOnLogin)]
        public HttpMessage MissionUpdateMissionProgressOnLogin()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Mission_UpdateMissionProgressOnLogin);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.Mission_Receive)]
        public HttpMessage MissionReceive()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Mission_Receive);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }
    }
}


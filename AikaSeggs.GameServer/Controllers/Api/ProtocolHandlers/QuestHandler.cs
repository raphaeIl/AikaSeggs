using AikaSeggs.Common;
using AikaSeggs.Common.Core;
using AikaSeggs.Common.Services;
using AikaSeggs.PcapParser;

namespace AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers
{
    public class QuestHandler : ProtocolHandlerBase
    {
        private readonly TableService tableService;

        public QuestHandler(IProtocolHandlerFactory protocolHandlerFactory, TableService tableService) 
            : base(protocolHandlerFactory)
        {
            this.tableService = tableService;
        }

        [ProtocolHandler(Protocol.Quest_GetMasterData)]
        public HttpMessage QuestGetMasterData()
        {
            var tableJson = tableService.GetTableJsonByProtocol(Protocol.Quest_GetMasterData);
            return HttpMessage.Create(tableJson, doMsgPack: true);
        }

        [ProtocolHandler(Protocol.Quest_GetMasterDropData)]
        public HttpMessage QuestGetMasterDropData()
        {
            var tableJson = tableService.GetTableJsonByProtocol(Protocol.Quest_GetMasterDropData);
            return HttpMessage.Create(tableJson, doMsgPack: true);
        }

        [ProtocolHandler(Protocol.Quest_GetMasterDropData2)]
        public HttpMessage QuestGetMasterDropData2()
        {
            var tableJson = tableService.GetTableJsonByProtocol(Protocol.Quest_GetMasterDropData2);
            return HttpMessage.Create(tableJson, doMsgPack: true);
        }

        [ProtocolHandler(Protocol.Quest_GetMasterDropData3)]
        public HttpMessage QuestGetMasterDropData3()
        {
            var tableJson = tableService.GetTableJsonByProtocol(Protocol.Quest_GetMasterDropData3);
            return HttpMessage.Create(tableJson, doMsgPack: true);
        }

        [ProtocolHandler(Protocol.Quest_GetMasterDropData4)]
        public HttpMessage QuestGetMasterDropData4()
        {
            var tableJson = tableService.GetTableJsonByProtocol(Protocol.Quest_GetMasterDropData4);
            return HttpMessage.Create(tableJson, doMsgPack: true);
        }

        [ProtocolHandler(Protocol.Quest_GetMasterDropData5)]
        public HttpMessage QuestGetMasterDropData5()
        {
            var tableJson = tableService.GetTableJsonByProtocol(Protocol.Quest_GetMasterDropData5);
            return HttpMessage.Create(tableJson, doMsgPack: true);
        }

        [ProtocolHandler(Protocol.Quest_GetMasterDropData6)]
        public HttpMessage QuestGetMasterDropData6()
        {
            var tableJson = tableService.GetTableJsonByProtocol(Protocol.Quest_GetMasterDropData6);
            return HttpMessage.Create(tableJson, doMsgPack: true);
        }

        [ProtocolHandler(Protocol.Quest_GetMasterEventPointData)]
        public HttpMessage QuestGetMasterEventPointData()
        {
            var tableJson = tableService.GetTableJsonByProtocol(Protocol.Quest_GetMasterEventPointData);
            return HttpMessage.Create(tableJson, doMsgPack: true);
        }

        [ProtocolHandler(Protocol.Quest_GetMasterStageData)]
        public HttpMessage QuestGetMasterStageData()
        {
            var tableJson = tableService.GetTableJsonByProtocol(Protocol.Quest_GetMasterStageData);
            return HttpMessage.Create(tableJson, doMsgPack: true);
        }

        [ProtocolHandler(Protocol.Quest_GetMasterStageData2)]
        public HttpMessage QuestGetMasterStageData2()
        {
            var tableJson = tableService.GetTableJsonByProtocol(Protocol.Quest_GetMasterStageData2);
            return HttpMessage.Create(tableJson, doMsgPack: true);
        }

        [ProtocolHandler(Protocol.Quest_GetMasterStageData3)]
        public HttpMessage QuestGetMasterStageData3()
        {
            var tableJson = tableService.GetTableJsonByProtocol(Protocol.Quest_GetMasterStageData3);
            return HttpMessage.Create(tableJson, doMsgPack: true);
        }

        [ProtocolHandler(Protocol.Quest_GetUserData)]
        public HttpMessage QuestGetUserData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Quest_GetUserData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.Quest_GetStageData)]
        public HttpMessage QuestGetStageData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Quest_GetStageData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.Quest_SkipBattle)]
        public HttpMessage QuestSkipBattle()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Quest_SkipBattle);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.Quest_UnlockQuest)]
        public HttpMessage QuestUnlockQuest()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Quest_UnlockQuest);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }
    }
}


using AikaSeggs.Common;
using AikaSeggs.Common.Core;
using AikaSeggs.PcapParser;

namespace AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers
{
    public class QuestHandler : ProtocolHandlerBase
    {
        public QuestHandler(IProtocolHandlerFactory protocolHandlerFactory) : base(protocolHandlerFactory) { }

        [ProtocolHandler(Protocol.Quest_GetMasterData)]
        public HttpMessage QuestGetMasterData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Quest_GetMasterData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.Quest_GetMasterDropData)]
        public HttpMessage QuestGetMasterDropData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Quest_GetMasterDropData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.Quest_GetMasterDropData2)]
        public HttpMessage QuestGetMasterDropData2()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Quest_GetMasterDropData2);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.Quest_GetMasterDropData3)]
        public HttpMessage QuestGetMasterDropData3()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Quest_GetMasterDropData3);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.Quest_GetMasterDropData4)]
        public HttpMessage QuestGetMasterDropData4()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Quest_GetMasterDropData4);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.Quest_GetMasterDropData5)]
        public HttpMessage QuestGetMasterDropData5()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Quest_GetMasterDropData5);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.Quest_GetMasterDropData6)]
        public HttpMessage QuestGetMasterDropData6()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Quest_GetMasterDropData6);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.Quest_GetMasterEventPointData)]
        public HttpMessage QuestGetMasterEventPointData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Quest_GetMasterEventPointData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.Quest_GetMasterStageData)]
        public HttpMessage QuestGetMasterStageData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Quest_GetMasterStageData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.Quest_GetMasterStageData2)]
        public HttpMessage QuestGetMasterStageData2()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Quest_GetMasterStageData2);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.Quest_GetMasterStageData3)]
        public HttpMessage QuestGetMasterStageData3()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Quest_GetMasterStageData3);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
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


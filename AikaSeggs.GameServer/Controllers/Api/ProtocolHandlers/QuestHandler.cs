using AikaSeggs.Common;
using AikaSeggs.Common.Core;
using AikaSeggs.PcapParser;

namespace AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers
{
    public class QuestHandler : ProtocolHandlerBase
    {
        public QuestHandler(IProtocolHandlerFactory protocolHandlerFactory) : base(protocolHandlerFactory) { }

        [ProtocolHandler(Protocol.Quest_GetUserData)]
        public HttpMessage QuestGetUserData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Quest_GetUserData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.Quest_GetStageData)]
        public HttpMessage QuestGetStageData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Quest_GetStageData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.Quest_SkipBattle)]
        public HttpMessage QuestSkipBattle()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Quest_SkipBattle);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.Quest_UnlockQuest)]
        public HttpMessage QuestUnlockQuest()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Quest_UnlockQuest);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }
    }
}


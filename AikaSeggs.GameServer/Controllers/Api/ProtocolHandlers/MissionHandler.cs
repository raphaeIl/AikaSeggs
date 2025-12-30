using AikaSeggs.Common;
using AikaSeggs.Common.Core;
using AikaSeggs.PcapParser;

namespace AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers
{
    public class MissionHandler : ProtocolHandlerBase
    {
        public MissionHandler(IProtocolHandlerFactory protocolHandlerFactory) : base(protocolHandlerFactory) { }

        [ProtocolHandler(Protocol.Mission_GetMasterData)]
        public HttpMessage MissionGetMasterData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Mission_GetMasterData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.Mission_GetMasterMissionDetailData)]
        public HttpMessage MissionGetMasterMissionDetailData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Mission_GetMasterMissionDetailData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.Mission_GetMasterMissionDetailData2)]
        public HttpMessage MissionGetMasterMissionDetailData2()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Mission_GetMasterMissionDetailData2);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.Mission_GetMasterMissionDetailData3)]
        public HttpMessage MissionGetMasterMissionDetailData3()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Mission_GetMasterMissionDetailData3);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.Mission_GetMasterMissionDetailData4)]
        public HttpMessage MissionGetMasterMissionDetailData4()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Mission_GetMasterMissionDetailData4);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
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


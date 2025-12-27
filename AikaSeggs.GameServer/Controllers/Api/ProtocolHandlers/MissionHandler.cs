using AikaSeggs.Common;
using AikaSeggs.Common.Core;
using AikaSeggs.PcapParser;

namespace AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers
{
    public class MissionHandler : ProtocolHandlerBase
    {
        public MissionHandler(IProtocolHandlerFactory protocolHandlerFactory) : base(protocolHandlerFactory) { }

        [ProtocolHandler(Protocol.Mission_GetUserData)]
        public HttpMessage MissionGetUserData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Mission_GetUserData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.Mission_UpdateMissionProgressOnLogin)]
        public HttpMessage MissionUpdateMissionProgressOnLogin()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Mission_UpdateMissionProgressOnLogin);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.Mission_Receive)]
        public HttpMessage MissionReceive()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Mission_Receive);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }
    }
}


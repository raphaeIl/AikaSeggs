using AikaSeggs.Common;
using AikaSeggs.Common.Core;
using AikaSeggs.PcapParser;

namespace AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers
{
    public class TowerHandler : ProtocolHandlerBase
    {
        public TowerHandler(IProtocolHandlerFactory protocolHandlerFactory) : base(protocolHandlerFactory) { }

        [ProtocolHandler(Protocol.Tower_GetMasterData)]
        public HttpMessage TowerGetMasterData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Tower_GetMasterData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
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


using AikaSeggs.Common;
using AikaSeggs.Common.Core;
using AikaSeggs.PcapParser;

namespace AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers
{
    public class PvpHandler : ProtocolHandlerBase
    {
        public PvpHandler(IProtocolHandlerFactory protocolHandlerFactory) : base(protocolHandlerFactory) { }

        [ProtocolHandler(Protocol.Pvp_GetUserData)]
        public HttpMessage PvpGetUserData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Pvp_GetUserData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.Pvp_GetBattlePlayers)]
        public HttpMessage PvpGetBattlePlayers()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Pvp_GetBattlePlayers);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }
    }
}


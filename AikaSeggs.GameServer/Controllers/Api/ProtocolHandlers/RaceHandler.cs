using AikaSeggs.Common;
using AikaSeggs.Common.Core;
using AikaSeggs.PcapParser;

namespace AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers
{
    public class RaceHandler : ProtocolHandlerBase
    {
        public RaceHandler(IProtocolHandlerFactory protocolHandlerFactory) : base(protocolHandlerFactory) { }

        [ProtocolHandler(Protocol.Race_GetUserData)]
        public HttpMessage RaceGetUserData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Race_GetUserData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.Race_EndRace)]
        public HttpMessage RaceEndRace()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Race_EndRace);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.Race_FortifyCharacter)]
        public HttpMessage RaceFortifyCharacter()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Race_FortifyCharacter);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.Race_StartRace)]
        public HttpMessage RaceStartRace()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Race_StartRace);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.Race_UpdateSeason)]
        public HttpMessage RaceUpdateSeason()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Race_UpdateSeason);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }
    }
}


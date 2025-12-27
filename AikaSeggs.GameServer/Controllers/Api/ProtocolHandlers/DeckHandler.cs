using AikaSeggs.Common;
using AikaSeggs.Common.Core;
using AikaSeggs.PcapParser;

namespace AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers
{
    public class DeckHandler : ProtocolHandlerBase
    {
        public DeckHandler(IProtocolHandlerFactory protocolHandlerFactory) : base(protocolHandlerFactory) { }

        [ProtocolHandler(Protocol.Deck_GetUserData)]
        public HttpMessage DeckGetUserData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Deck_GetUserData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.Deck_Update)]
        public HttpMessage DeckUpdate()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Deck_Update);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }
    }
}


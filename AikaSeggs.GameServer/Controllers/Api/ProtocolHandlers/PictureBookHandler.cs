using AikaSeggs.Common;
using AikaSeggs.Common.Core;
using AikaSeggs.PcapParser;

namespace AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers
{
    public class PictureBookHandler : ProtocolHandlerBase
    {
        public PictureBookHandler(IProtocolHandlerFactory protocolHandlerFactory) : base(protocolHandlerFactory) { }

        [ProtocolHandler(Protocol.PictureBook_GetUserData)]
        public HttpMessage PictureBookGetUserData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.PictureBook_GetUserData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.PictureBook_Gift)]
        public HttpMessage PictureBookGift()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.PictureBook_Gift);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }
    }
}


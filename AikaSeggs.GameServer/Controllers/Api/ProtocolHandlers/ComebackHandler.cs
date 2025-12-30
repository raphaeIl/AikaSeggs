using AikaSeggs.Common;
using AikaSeggs.Common.Core;
using AikaSeggs.PcapParser;

namespace AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers
{
    public class ComebackHandler : ProtocolHandlerBase
    {
        public ComebackHandler(IProtocolHandlerFactory protocolHandlerFactory) : base(protocolHandlerFactory) { }

        [ProtocolHandler(Protocol.Comeback_GetMasterData)]
        public HttpMessage ComebackGetMasterData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Comeback_GetMasterData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }
    }
}



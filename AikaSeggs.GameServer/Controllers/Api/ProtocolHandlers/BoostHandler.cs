using AikaSeggs.Common;
using AikaSeggs.Common.Core;
using AikaSeggs.PcapParser;

namespace AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers
{
    public class BoostHandler : ProtocolHandlerBase
    {
        public BoostHandler(IProtocolHandlerFactory protocolHandlerFactory) : base(protocolHandlerFactory) { }

        [ProtocolHandler(Protocol.Boost_GetMasterData)]
        public HttpMessage BoostGetMasterData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Boost_GetMasterData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.Boost_GetBoostUnitsList)]
        public HttpMessage BoostGetBoostUnitsList()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Boost_GetBoostUnitsList);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }
    }
}


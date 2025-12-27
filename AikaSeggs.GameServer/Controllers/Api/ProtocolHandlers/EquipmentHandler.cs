using AikaSeggs.Common;
using AikaSeggs.Common.Core;
using AikaSeggs.PcapParser;

namespace AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers
{
    public class EquipmentHandler : ProtocolHandlerBase
    {
        public EquipmentHandler(IProtocolHandlerFactory protocolHandlerFactory) : base(protocolHandlerFactory) { }

        [ProtocolHandler(Protocol.Equipment_GetUserData)]
        public HttpMessage EquipmentGetUserData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Equipment_GetUserData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }
    }
}


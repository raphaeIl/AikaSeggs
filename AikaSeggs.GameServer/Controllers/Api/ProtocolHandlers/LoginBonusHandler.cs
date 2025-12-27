using AikaSeggs.Common;
using AikaSeggs.Common.Core;
using AikaSeggs.PcapParser;

namespace AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers
{
    public class LoginBonusHandler : ProtocolHandlerBase
    {
        public LoginBonusHandler(IProtocolHandlerFactory protocolHandlerFactory) : base(protocolHandlerFactory) { }

        [ProtocolHandler(Protocol.LoginBonus_GetLoginBonus)]
        public HttpMessage LoginBonusGetLoginBonus()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.LoginBonus_GetLoginBonus);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }
    }
}


using AikaSeggs.Common;
using AikaSeggs.Common.Core;
using AikaSeggs.PcapParser;

namespace AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers
{
    public class LoginPackHandler : ProtocolHandlerBase
    {
        public LoginPackHandler(IProtocolHandlerFactory protocolHandlerFactory) : base(protocolHandlerFactory) { }

        [ProtocolHandler(Protocol.LoginPack_GetLoginPack)]
        public HttpMessage LoginPackGetLoginPack()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.LoginPack_GetLoginPack);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.LoginPack_GetUserData)]
        public HttpMessage LoginPackGetUserData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.LoginPack_GetUserData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }
    }
}


using AikaSeggs.Common;
using AikaSeggs.Common.Core;
using AikaSeggs.Common.Packets;
using AikaSeggs.PcapParser;

namespace AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers
{
    public class AuthHandler : ProtocolHandlerBase
    {
        public AuthHandler(IProtocolHandlerFactory protocolHandlerFactory) : base(protocolHandlerFactory) { }

        [ProtocolHandler(Protocol.Auth_GetDmmAccessToken)]
        public AuthGetDmmAccessTokenResponse AuthGetDmmAccessToken()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Auth_GetDmmAccessToken);

            return new AuthGetDmmAccessTokenResponse()
            {
                
            };
        }
    }
}


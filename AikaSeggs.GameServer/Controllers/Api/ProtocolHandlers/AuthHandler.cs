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
                dmmId = "52475226",
                userId = "1vHS7sj9nC1Gz7fuk8CbZE",
                token = "3OH36sQ5RNAKRwoj0Kdqwy",
                secret = "qXoCtXC2FDvfqnjKoSwCx8UxNrD8W7nHCpkgQ8l3GVoZBOzKEqTImr1ETAGnFBqolgsbK2Uyylitxb08r5yXpb",
                expires = 1764267603
            };
        }
    }
}


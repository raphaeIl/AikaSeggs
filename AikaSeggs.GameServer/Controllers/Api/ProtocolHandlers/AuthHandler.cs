using AikaSeggs.Common;
using AikaSeggs.Common.Core;
using AikaSeggs.Common.Packets;
using AikaSeggs.Database;
using AikaSeggs.PcapParser;

namespace AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers
{
    public class AuthHandler : ProtocolHandlerBase
    {
        public AuthHandler(IProtocolHandlerFactory protocolHandlerFactory, AikaSeggsContext dbContext) : base(protocolHandlerFactory) 
        {
        }

        [ProtocolHandler(Protocol.Auth_GetDmmAccessToken)]
        public AuthGetDmmAccessTokenResponse AuthGetDmmAccessToken()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Auth_GetDmmAccessToken);

            return new AuthGetDmmAccessTokenResponse()
            {
                DmmId = "52475226",
                UserId = "1vHS7sj9nC1Gz7fuk8CbZE",
                Token = "3OH36sQ5RNAKRwoj0Kdqwy",
                Secret = "qXoCtXC2FDvfqnjKoSwCx8UxNrD8W7nHCpkgQ8l3GVoZBOzKEqTImr1ETAGnFBqolgsbK2Uyylitxb08r5yXpb",
                Expires = 1764267603
            };
        }
    }
}


using AikaSeggs.Common;
using AikaSeggs.Common.Core;
using AikaSeggs.Common.Packets;
using AikaSeggs.PcapParser;
using Newtonsoft.Json;

namespace AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers
{
    public class LoginBonusHandler : ProtocolHandlerBase
    {
        public LoginBonusHandler(IProtocolHandlerFactory protocolHandlerFactory) : base(protocolHandlerFactory) { }

        [ProtocolHandler(Protocol.LoginBonus_GetMasterData)]
        public HttpMessage LoginBonusGetMasterData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.LoginBonus_GetMasterData);
            
            LoginBonusGetMasterDataResponse? respPacket = JsonConvert.DeserializeObject<LoginBonusGetMasterDataResponse>(pcap.Packet.ToString());

            foreach (var reward in respPacket.LoginBonusReward)
            {
                reward.Amount = 999_999_999;
                reward.Amount2 = 999_888_777;
            }

            // Serialize with camelCase settings
            string json = JsonConvert.SerializeObject(respPacket);
            HttpMessage resp = HttpMessage.Create(json, doMsgPack: true);
            return resp;
        }

        [ProtocolHandler(Protocol.LoginBonus_GetLoginBonus)]
        public HttpMessage LoginBonusGetLoginBonus()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.LoginBonus_GetLoginBonus);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }
    }
}


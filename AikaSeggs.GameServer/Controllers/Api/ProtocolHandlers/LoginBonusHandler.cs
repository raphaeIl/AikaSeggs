using AikaSeggs.Common;
using AikaSeggs.Common.Core;
using AikaSeggs.Common.Packets;
using AikaSeggs.Common.Services;
using AikaSeggs.PcapParser;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers
{
    public class LoginBonusHandler : ProtocolHandlerBase
    {
        private readonly TableService tableService;

        public LoginBonusHandler(IProtocolHandlerFactory protocolHandlerFactory, TableService tableService) 
            : base(protocolHandlerFactory)
        {
            this.tableService = tableService;
        }

        [ProtocolHandler(Protocol.LoginBonus_GetMasterData)]
        public HttpMessage LoginBonusGetMasterData()
        {
            // Get table JSON from TableService
            MasterLoginBonusData masterLoginBonusTable = tableService.GetTable<MasterLoginBonusData>();


            //// temp Modify data for fun, TODO: Add saving for modified data to actual table locally
            foreach (var reward in masterLoginBonusTable.LoginBonusReward)
            {
                reward.Amount = 999_999_999;
                reward.Amount2 = 999_888_777;
            }

            //// Serialize with camelCase settings
            //string json = JsonConvert.SerializeObject(respPacket, settings);
            HttpMessage resp = HttpMessage.Create(new LoginBonusGetMasterDataResponse()
            {
                LoginBonusMain = masterLoginBonusTable.LoginBonusMain,
                LoginBonusReward = masterLoginBonusTable.LoginBonusReward
            }, doMsgPack: true);

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


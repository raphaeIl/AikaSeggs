using AikaSeggs.Common;
using AikaSeggs.Common.Core;
using AikaSeggs.Common.Packets;
using AikaSeggs.Common.Services;
using AikaSeggs.PcapParser;
using System;
using System.Linq;
using Newtonsoft.Json;
using AikaSeggs.Database;
using AikaSeggs.Database.Models;

namespace AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers
{
    public class CharacterHandler : ProtocolHandlerBase
    {
        private readonly TableService tableService;

        private readonly AikaSeggsContext context;

        public CharacterHandler(IProtocolHandlerFactory protocolHandlerFactory, TableService tableService, AikaSeggsContext context) 
            : base(protocolHandlerFactory)
        {
            this.tableService = tableService;
            this.context = context;

            this.AddAllCharacters();
        }

        [ProtocolHandler(Protocol.Character_GetUserData)]
        public HttpMessage CharacterGetUserData()
        {
            CharacterGetUserDataResponse resp = new CharacterGetUserDataResponse()
            {
                Characters = []
            };

            foreach (CharacterDB character in context.Characters)
            {
                resp.Characters.Add(new Common.Database.CharacterModel()
                {
                    CharacterCd = character.CharacterCd,
                    CharacterId = character.CharacterId,
                    Exp = 0,
                    Level = 999888777,
                    SkillLevel = 9191919,
                    AbilityLevel1 = 78787,
                    AbilityLevel2 = 78787,
                    AbilityLevel3 = 78787,
                    ExceedLimit = 0,
                    ExceedLimitExp = 0,
                    IsProtect = 0,
                    RegisterDate = character.RegisterDate,
                    EquipmentWeaponCds = [],
                    EquipmentProtectorCds = [],
                    AwakeIds = [],
                    BattleCount = 1,
                });
            }

            //var settings = new JsonSerializerSettings
            //{
            //    NullValueHandling = NullValueHandling.Ignore
            //};
            //string json = JsonConvert.SerializeObject(resp, settings);
            //return HttpMessage.Create(json, doMsgPack: true);
            return HttpMessage.Create(resp, doMsgPack: true);
        }

        private void AddAllCharacters()
        {
            // Check if characters already exist
            if (context.Characters.Any())
            {
                return; // Characters already added
            }

            // Get the first account's UserCd, or create a default account if none exists
            var account = context.Accounts.FirstOrDefault();
            if (account == null)
            {
                // Create a default account
                account = new AccountDB
                {
                    UserId = Guid.NewGuid().ToString("N"),
                    UserCd = Guid.NewGuid().ToString("N"),
                    UserName = "DefaultUser",
                    Level = 1,
                    Exp = 0,
                    FreeGem = 0,
                    PaidGem = 0,
                    RegisterDate = DateTime.Now.ToString("yyyyMMddHHmmss")
                };
                context.Accounts.Add(account);
                context.SaveChanges();
            }

            foreach (Common.Database.ExCharacterMainModel characterMain in tableService.GetTable<MasterCharacterMainData>().CharacterMain)
            {
                // Skip characters that are linkerIds in CharacterLink
                if (characterMain.CharacterType == (int)Character_CHARACTER_TYPE.W_UNIT)
                {
                    continue;
                }

                context.Characters.Add(new Database.Models.CharacterDB()
                {
                    CharacterCd = Guid.NewGuid().ToString("N"),
                    CharacterId = characterMain.CharacterId,
                    RegisterDate = DateTime.Now.ToString("yyyyMMddHHmmss"),
                    UserCd = account.UserCd
                });
            }

            context.SaveChanges();
        }

        [ProtocolHandler(Protocol.Character_GetMasterData)]
        public HttpMessage CharacterGetMasterData()
        {
            var tableJson = tableService.GetTableJsonByProtocol(Protocol.Character_GetMasterData);
            return HttpMessage.Create(tableJson, doMsgPack: true);
        }

        [ProtocolHandler(Protocol.Character_GetMasterCharacterMainData)]
        public HttpMessage CharacterGetMasterCharacterMainData()
        {
            var tableJson = tableService.GetTableJsonByProtocol(Protocol.Character_GetMasterCharacterMainData);
            return HttpMessage.Create(tableJson, doMsgPack: true);
        }

        [ProtocolHandler(Protocol.Character_GetMasterTextData)]
        public HttpMessage CharacterGetMasterTextData()
        {
            var tableJson = tableService.GetTableJsonByProtocol(Protocol.Character_GetMasterTextData);
            return HttpMessage.Create(tableJson, doMsgPack: true);
        }

        [ProtocolHandler(Protocol.Character_GetMasterTextData2)]
        public HttpMessage CharacterGetMasterTextData2()
        {
            var tableJson = tableService.GetTableJsonByProtocol(Protocol.Character_GetMasterTextData2);
            return HttpMessage.Create(tableJson, doMsgPack: true);
        }

        [ProtocolHandler(Protocol.Character_GetMasterTextData3)]
        public HttpMessage CharacterGetMasterTextData3()
        {
            var tableJson = tableService.GetTableJsonByProtocol(Protocol.Character_GetMasterTextData3);
            return HttpMessage.Create(tableJson, doMsgPack: true);
        }

        [ProtocolHandler(Protocol.Character_GetMasterTextData4)]
        public HttpMessage CharacterGetMasterTextData4()
        {
            var tableJson = tableService.GetTableJsonByProtocol(Protocol.Character_GetMasterTextData4);
            return HttpMessage.Create(tableJson, doMsgPack: true);
        }

        [ProtocolHandler(Protocol.Character_GetMasterTextData5)]
        public HttpMessage CharacterGetMasterTextData5()
        {
            var tableJson = tableService.GetTableJsonByProtocol(Protocol.Character_GetMasterTextData5);
            return HttpMessage.Create(tableJson, doMsgPack: true);
        }

        [ProtocolHandler(Protocol.Character_GetMasterSkillData)]
        public HttpMessage CharacterGetMasterSkillData()
        {
            var tableJson = tableService.GetTableJsonByProtocol(Protocol.Character_GetMasterSkillData);
            return HttpMessage.Create(tableJson, doMsgPack: true);
        }

        [ProtocolHandler(Protocol.Character_GetMasterSkillEffectData)]
        public HttpMessage CharacterGetMasterSkillEffectData()
        {
            var tableJson = tableService.GetTableJsonByProtocol(Protocol.Character_GetMasterSkillEffectData);
            return HttpMessage.Create(tableJson, doMsgPack: true);
        }

        [ProtocolHandler(Protocol.Character_GetMasterSkillEffectData2)]
        public HttpMessage CharacterGetMasterSkillEffectData2()
        {
            var tableJson = tableService.GetTableJsonByProtocol(Protocol.Character_GetMasterSkillEffectData2);
            return HttpMessage.Create(tableJson, doMsgPack: true);
        }

        [ProtocolHandler(Protocol.Character_GetMasterAbilityData)]
        public HttpMessage CharacterGetMasterAbilityData()
        {
            var tableJson = tableService.GetTableJsonByProtocol(Protocol.Character_GetMasterAbilityData);
            return HttpMessage.Create(tableJson, doMsgPack: true);
        }

        [ProtocolHandler(Protocol.Character_GetMasterAbilityEffectData)]
        public HttpMessage CharacterGetMasterAbilityEffectData()
        {
            var tableJson = tableService.GetTableJsonByProtocol(Protocol.Character_GetMasterAbilityEffectData);
            return HttpMessage.Create(tableJson, doMsgPack: true);
        }

        [ProtocolHandler(Protocol.Character_GetMasterAbilityEffectData2)]
        public HttpMessage CharacterGetMasterAbilityEffectData2()
        {
            var tableJson = tableService.GetTableJsonByProtocol(Protocol.Character_GetMasterAbilityEffectData2);
            return HttpMessage.Create(tableJson, doMsgPack: true);
        }

        [ProtocolHandler(Protocol.Character_GetMasterAbilityEffectData3)]
        public HttpMessage CharacterGetMasterAbilityEffectData3()
        {
            var tableJson = tableService.GetTableJsonByProtocol(Protocol.Character_GetMasterAbilityEffectData3);
            return HttpMessage.Create(tableJson, doMsgPack: true);
        }

        [ProtocolHandler(Protocol.Character_GetMasterAbilityEffectData4)]
        public HttpMessage CharacterGetMasterAbilityEffectData4()
        {
            var tableJson = tableService.GetTableJsonByProtocol(Protocol.Character_GetMasterAbilityEffectData4);
            return HttpMessage.Create(tableJson, doMsgPack: true);
        }

        [ProtocolHandler(Protocol.Character_GetMasterAbilityEffectData5)]
        public HttpMessage CharacterGetMasterAbilityEffectData5()
        {
            var tableJson = tableService.GetTableJsonByProtocol(Protocol.Character_GetMasterAbilityEffectData5);
            return HttpMessage.Create(tableJson, doMsgPack: true);
        }

        [ProtocolHandler(Protocol.Character_GetMasterAbilityEffectData6)]
        public HttpMessage CharacterGetMasterAbilityEffectData6()
        {
            var tableJson = tableService.GetTableJsonByProtocol(Protocol.Character_GetMasterAbilityEffectData6);
            return HttpMessage.Create(tableJson, doMsgPack: true);
        }

        [ProtocolHandler(Protocol.Character_GetMasterAwakeData)]
        public HttpMessage CharacterGetMasterAwakeData()
        {
            var tableJson = tableService.GetTableJsonByProtocol(Protocol.Character_GetMasterAwakeData);
            return HttpMessage.Create(tableJson, doMsgPack: true);
        }

        [ProtocolHandler(Protocol.Character_GetMasterEvolutionData)]
        public HttpMessage CharacterGetMasterEvolutionData()
        {
            var tableJson = tableService.GetTableJsonByProtocol(Protocol.Character_GetMasterEvolutionData);
            return HttpMessage.Create(tableJson, doMsgPack: true);
        }
    }
}


using AikaSeggs.Common;
using AikaSeggs.Common.Core;
using AikaSeggs.Common.Services;
using AikaSeggs.PcapParser;

namespace AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers
{
    public class CharacterHandler : ProtocolHandlerBase
    {
        private readonly TableService tableService;

        public CharacterHandler(IProtocolHandlerFactory protocolHandlerFactory, TableService tableService) 
            : base(protocolHandlerFactory)
        {
            this.tableService = tableService;
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

        [ProtocolHandler(Protocol.Character_GetUserData)]
        public HttpMessage CharacterGetUserData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Character_GetUserData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }
    }
}


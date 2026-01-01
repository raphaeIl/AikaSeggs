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
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Character_GetMasterCharacterMainData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.Character_GetMasterTextData)]
        public HttpMessage CharacterGetMasterTextData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Character_GetMasterTextData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.Character_GetMasterTextData2)]
        public HttpMessage CharacterGetMasterTextData2()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Character_GetMasterTextData2);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.Character_GetMasterTextData3)]
        public HttpMessage CharacterGetMasterTextData3()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Character_GetMasterTextData3);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.Character_GetMasterTextData4)]
        public HttpMessage CharacterGetMasterTextData4()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Character_GetMasterTextData4);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.Character_GetMasterTextData5)]
        public HttpMessage CharacterGetMasterTextData5()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Character_GetMasterTextData5);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.Character_GetMasterSkillData)]
        public HttpMessage CharacterGetMasterSkillData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Character_GetMasterSkillData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.Character_GetMasterSkillEffectData)]
        public HttpMessage CharacterGetMasterSkillEffectData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Character_GetMasterSkillEffectData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.Character_GetMasterSkillEffectData2)]
        public HttpMessage CharacterGetMasterSkillEffectData2()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Character_GetMasterSkillEffectData2);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.Character_GetMasterAbilityData)]
        public HttpMessage CharacterGetMasterAbilityData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Character_GetMasterAbilityData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.Character_GetMasterAbilityEffectData)]
        public HttpMessage CharacterGetMasterAbilityEffectData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Character_GetMasterAbilityEffectData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.Character_GetMasterAbilityEffectData2)]
        public HttpMessage CharacterGetMasterAbilityEffectData2()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Character_GetMasterAbilityEffectData2);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.Character_GetMasterAbilityEffectData3)]
        public HttpMessage CharacterGetMasterAbilityEffectData3()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Character_GetMasterAbilityEffectData3);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.Character_GetMasterAbilityEffectData4)]
        public HttpMessage CharacterGetMasterAbilityEffectData4()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Character_GetMasterAbilityEffectData4);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.Character_GetMasterAbilityEffectData5)]
        public HttpMessage CharacterGetMasterAbilityEffectData5()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Character_GetMasterAbilityEffectData5);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.Character_GetMasterAbilityEffectData6)]
        public HttpMessage CharacterGetMasterAbilityEffectData6()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Character_GetMasterAbilityEffectData6);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.Character_GetMasterAwakeData)]
        public HttpMessage CharacterGetMasterAwakeData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Character_GetMasterAwakeData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.Character_GetMasterEvolutionData)]
        public HttpMessage CharacterGetMasterEvolutionData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Character_GetMasterEvolutionData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
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


using AikaSeggs.Common;
using AikaSeggs.Common.Core;
using AikaSeggs.Common.Packets;
using AikaSeggs.Database;
using AikaSeggs.Database.Models;
using AikaSeggs.PcapParser;

namespace AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers
{
    public class WarehouseHandler : ProtocolHandlerBase
    {
        private readonly AikaSeggsContext context;

        public WarehouseHandler(IProtocolHandlerFactory protocolHandlerFactory, AikaSeggsContext context) : base(protocolHandlerFactory) 
        {
            this.context = context;
        }

        [ProtocolHandler(Protocol.Warehouse_GetCharacterCount)]
        public WarehouseGetCharacterCountResponse WarehouseGetCharacterCount()
        {
            return new WarehouseGetCharacterCountResponse()
            {
                MaxCount = context.Characters.Count()
            };
        }

        [ProtocolHandler(Protocol.Warehouse_GetCharacterList)]
        public WarehouseGetCharacterListResponse WarehouseGetCharacterList()
        {
            var resp = new WarehouseGetCharacterListResponse()
            {
                AddWarehouseCharacters = []
            };

            foreach (CharacterDB character in context.Characters)
            {
                resp.AddWarehouseCharacters.Add(new Common.Database.WarehouseCharacterModel()
                {
                    CharacterCd = character.CharacterCd,
                    UserCd = character.UserCd,
                    CharacterId = character.CharacterId,
                    ExceedLimit = 0,
                    Count = character.Count,
                    UpdateDate = DateTime.Now.ToString("yyyyMMddHHmmss"),
                    Rarity = character.Rarity,
                });
            }

            return resp;
        }

        [ProtocolHandler(Protocol.Warehouse_BringWarehouse)]
        public WarehouseBringWarehouseResponse WarehouseBringWarehouse()
        {
            WarehouseBringWarehouseResponse resp = new WarehouseBringWarehouseResponse
            {
                AddWarehouseCharacters = [],
                AddWarehouseMaterials = [],
                Characters = [],
                UpdateWarehouseCharacters = [],
                UpdateWarehouseMaterials = []
            };

            foreach (CharacterDB character in context.Characters)
            {
                resp.Characters.Add(new Common.Database.CharacterModel()
                {
                    CharacterCd = character.CharacterCd,
                    CharacterId = character.CharacterId,
                    Rarity = character.Rarity,
                    Exp = character.Exp,
                    Level = character.Level,
                    SkillLevel = character.SkillLevel,
                    AbilityLevel1 = character.AbilityLevel1,
                    AbilityLevel2 = character.AbilityLevel2,
                    AbilityLevel3 = character.AbilityLevel3,
                    ExceedLimit = character.ExceedLimit,
                    ExceedLimitExp = character.ExceedLimitExp,
                    IsProtect = character.IsProtect,
                    RegisterDate = character.RegisterDate,
                    EquipmentWeaponCds = [],
                    EquipmentProtectorCds = [],
                    AwakeIds = [],
                    BattleCount = character.BattleCount,
                });
            }

            return resp;
        }

        [ProtocolHandler(Protocol.Warehouse_GetEquipmentCount)]
        public HttpMessage WarehouseGetEquipmentCount()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Warehouse_GetEquipmentCount);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.Warehouse_GetEquipmentList)]
        public HttpMessage WarehouseGetEquipmentList()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Warehouse_GetEquipmentList);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.Warehouse_GetMaterialCount)]
        public HttpMessage WarehouseGetMaterialCount()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Warehouse_GetMaterialCount);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.Warehouse_GetMaterialList)]
        public HttpMessage WarehouseGetMaterialList()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Warehouse_GetMaterialList);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

    }
}


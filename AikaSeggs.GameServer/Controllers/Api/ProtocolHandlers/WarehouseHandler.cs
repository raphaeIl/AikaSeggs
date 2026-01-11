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
                    Count = 1,
                    UpdateDate = DateTime.Now.ToString("yyyyMMddHHmmss")
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
                    Exp = 0,
                    Level = 999888777,
                    SkillLevel = 9191919,
                    AbilityLevel1 = 78787,
                    AbilityLevel2 = 78787,
                    AbilityLevel3 = 78787,
                    ExceedLimit = 1000,
                    ExceedLimitExp = 0,
                    IsProtect = 0,
                    RegisterDate = character.RegisterDate,
                    EquipmentWeaponCds = [],
                    EquipmentProtectorCds = [],
                    AwakeIds = [],
                    BattleCount = 1,
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


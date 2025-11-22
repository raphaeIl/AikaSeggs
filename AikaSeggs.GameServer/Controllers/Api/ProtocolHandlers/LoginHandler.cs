using AikaSeggs.Common.Core;
using AikaSeggs.PcapParser;

namespace AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers
{
    public class LoginHandler : ProtocolHandlerBase
    {
        public LoginHandler(IProtocolHandlerFactory protocolHandlerFactory) : base(protocolHandlerFactory) { }

        [ProtocolHandler(Protocol.Auth_GetDmmAccessToken)]
        public HttpMessage AuthGetDmmAccessToken()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Auth_GetDmmAccessToken);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.CabinMission_GetUserData)]
        public HttpMessage CabinMissionGetUserData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.CabinMission_GetUserData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.CharacterLink_GetUserData)]
        public HttpMessage CharacterLinkGetUserData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.CharacterLink_GetUserData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.Character_GetUserData)]
        public HttpMessage CharacterGetUserData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Character_GetUserData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.Deck_GetUserData)]
        public HttpMessage DeckGetUserData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Deck_GetUserData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.Equipment_GetUserData)]
        public HttpMessage EquipmentGetUserData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Equipment_GetUserData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.Event_GetUserData)]
        public HttpMessage EventGetUserData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Event_GetUserData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.Gacha_GetUserData)]
        public HttpMessage GachaGetUserData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Gacha_GetUserData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.Item_GetUserData)]
        public HttpMessage ItemGetUserData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Item_GetUserData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.LinearMission_GetUserData)]
        public HttpMessage LinearMissionGetUserData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.LinearMission_GetUserData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.LoginBonus_GetLoginBonus)]
        public HttpMessage LoginBonusGetLoginBonus()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.LoginBonus_GetLoginBonus);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.LoginPack_GetLoginPack)]
        public HttpMessage LoginPackGetLoginPack()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.LoginPack_GetLoginPack);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.LoginPack_GetUserData)]
        public HttpMessage LoginPackGetUserData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.LoginPack_GetUserData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.Lottery_GetUserData)]
        public HttpMessage LotteryGetUserData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Lottery_GetUserData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.Memorial_GetUserData)]
        public HttpMessage MemorialGetUserData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Memorial_GetUserData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.Minigame_GetUserData)]
        public HttpMessage MinigameGetUserData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Minigame_GetUserData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.Mission_GetUserData)]
        public HttpMessage MissionGetUserData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Mission_GetUserData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.Mission_UpdateMissionProgressOnLogin)]
        public HttpMessage MissionUpdateMissionProgressOnLogin()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Mission_UpdateMissionProgressOnLogin);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.MyPage_Refresh)]
        public HttpMessage MyPageRefresh()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.MyPage_Refresh);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.Notice_GetUserData)]
        public HttpMessage NoticeGetUserData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Notice_GetUserData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.PictureBook_GetUserData)]
        public HttpMessage PictureBookGetUserData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.PictureBook_GetUserData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.Pvp_GetUserData)]
        public HttpMessage PvpGetUserData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Pvp_GetUserData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.Quest_GetUserData)]
        public HttpMessage QuestGetUserData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Quest_GetUserData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.Race_GetUserData)]
        public HttpMessage RaceGetUserData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Race_GetUserData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.Room_GetUserData)]
        public HttpMessage RoomGetUserData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Room_GetUserData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.Shop_GetUserData)]
        public HttpMessage ShopGetUserData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Shop_GetUserData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.SolidEquipment_GetUserData)]
        public HttpMessage SolidEquipmentGetUserData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.SolidEquipment_GetUserData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.Sound_GetUserData)]
        public HttpMessage SoundGetUserData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Sound_GetUserData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.Story_GetUserData)]
        public HttpMessage StoryGetUserData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Story_GetUserData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.Tower_GetUserData)]
        public HttpMessage TowerGetUserData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Tower_GetUserData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.User_GetUserData)]
        public HttpMessage UserGetUserData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.User_GetUserData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.User_Login)]
        public HttpMessage UserLogin()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.User_Login);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.Version_GetMd5Data)]
        public HttpMessage VersionGetMd5Data()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Version_GetMd5Data);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.Warehouse_GetCharacterCount)]
        public HttpMessage WarehouseGetCharacterCount()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Warehouse_GetCharacterCount);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.Warehouse_GetCharacterList)]
        public HttpMessage WarehouseGetCharacterList()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Warehouse_GetCharacterList);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.Warehouse_GetEquipmentCount)]
        public HttpMessage WarehouseGetEquipmentCount()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Warehouse_GetEquipmentCount);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.Warehouse_GetEquipmentList)]
        public HttpMessage WarehouseGetEquipmentList()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Warehouse_GetEquipmentList);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.Warehouse_GetMaterialCount)]
        public HttpMessage WarehouseGetMaterialCount()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Warehouse_GetMaterialCount);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.Warehouse_GetMaterialList)]
        public HttpMessage WarehouseGetMaterialList()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Warehouse_GetMaterialList);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

    }
}

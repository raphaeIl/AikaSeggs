using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AikaSeggs.Common.Core
{
    public enum Protocol
    {
        Unknown,
        Auth_GetDmmAccessToken,
        CabinMission_GetUserData,
        CharacterLink_GetUserData,
        Character_GetUserData,
        Deck_GetUserData,
        Equipment_GetUserData,
        Event_GetUserData,
        Gacha_GetUserData,
        Item_GetUserData,
        LinearMission_GetUserData,
        LoginBonus_GetLoginBonus,
        LoginPack_GetLoginPack,
        LoginPack_GetUserData,
        Lottery_GetUserData,
        Memorial_GetUserData,
        Minigame_GetUserData,
        Mission_GetUserData,
        Mission_UpdateMissionProgressOnLogin,
        MyPage_Refresh,
        Notice_GetUserData,
        PictureBook_GetUserData,
        Pvp_GetUserData,
        Quest_GetUserData,
        Race_GetUserData,
        Room_GetUserData,
        Shop_GetUserData,
        SolidEquipment_GetUserData,
        Sound_GetUserData,
        Story_GetUserData,
        Tower_GetUserData,
        User_GetUserData,
        User_Login,
        Version_GetMd5Data,
        Warehouse_GetCharacterCount,
        Warehouse_GetCharacterList,
        Warehouse_GetEquipmentCount,
        Warehouse_GetEquipmentList,
        Warehouse_GetMaterialCount,
        Warehouse_GetMaterialList
    }
}

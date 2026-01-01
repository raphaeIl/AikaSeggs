using AikaSeggs.Common.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace AikaSeggs.Common
{
	public static class TableEndpoints
	{
		public static readonly Dictionary<string, string> Endpoints = new()
		{
			{ "getMasterBoostData", "boost/getMasterData" },
			{ "getMasterCabinMissionData", "cabinMission/getMasterData" },
			{ "getMasterCampaignData", "campaign/getMasterData" },
			{ "getMasterCharacterAbilityData", "character/getMasterAbilityData" },
			{ "getMasterCharacterAbilityEffectData", "character/getMasterAbilityEffectData" },
			{ "getMasterCharacterAbilityEffectData2", "character/getMasterAbilityEffectData2" },
			{ "getMasterCharacterAbilityEffectData3", "character/getMasterAbilityEffectData3" },
			{ "getMasterCharacterAbilityEffectData4", "character/getMasterAbilityEffectData4" },
			{ "getMasterCharacterAbilityEffectData5", "character/getMasterAbilityEffectData5" },
			{ "getMasterCharacterAbilityEffectData6", "character/getMasterAbilityEffectData6" },
			{ "getMasterCharacterAwakeData", "character/getMasterAwakeData" },
			{ "getMasterCharacterData", "character/getMasterData" },
			{ "getMasterCharacterEvolutionData", "character/getMasterEvolutionData" },
			{ "getMasterCharacterLinkData", "characterLink/getMasterData" },
			{ "getMasterCharacterMainData", "character/getMasterCharacterMainData" },
			{ "getMasterCharacterSkillData", "character/getMasterSkillData" },
			{ "getMasterCharacterSkillEffectData", "character/getMasterSkillEffectData" },
			{ "getMasterCharacterSkillEffectData2", "character/getMasterSkillEffectData2" },
			{ "getMasterCharacterTextData", "character/getMasterTextData" },
			{ "getMasterCharacterTextData2", "character/getMasterTextData2" },
			{ "getMasterCharacterTextData3", "character/getMasterTextData3" },
			{ "getMasterCharacterTextData4", "character/getMasterTextData4" },
			{ "getMasterCharacterTextData5", "character/getMasterTextData5" },
			{ "getMasterComebackData", "comeback/getMasterData" },
			{ "getMasterEquipmentData", "equipment/getMasterData" },
			{ "getMasterEquipmentEffectData", "equipment/getMasterEquipmentEffectData" },
			{ "getMasterEquipmentEffectData2", "equipment/getMasterEquipmentEffectData2" },
			{ "getMasterEventData", "event/getMasterData" },
			{ "getMasterExchangeItemDetailData", "shop/getMasterExchangeItemDetailData" },
			{ "getMasterExchangeItemDetailData2", "shop/getMasterExchangeItemDetailData2" },
			{ "getMasterExchangePointDetailData", "shop/getMasterExchangePointDetailData" },
			{ "getMasterItemData", "item/getMasterData" },
			{ "getMasterItemSetData", "item/getMasterItemSetData" },
			{ "getMasterItemSetData2", "item/getMasterItemSetData2" },
			{ "getMasterLinearMissionData", "linearMission/getMasterData" },
			{ "getMasterLoginBonusData", "loginBonus/getMasterData" },
			{ "getMasterLoginPackData", "loginPack/getMasterData" },
			{ "getMasterMemorialData", "memorial/getMasterData" },
			{ "getMasterMinigameData", "minigame/getMasterData" },
			{ "getMasterMissionData", "mission/getMasterData" },
			{ "getMasterMissionDetailData", "mission/getMasterMissionDetailData" },
			{ "getMasterMissionDetailData2", "mission/getMasterMissionDetailData2" },
			{ "getMasterMissionDetailData3", "mission/getMasterMissionDetailData3" },
			{ "getMasterMissionDetailData4", "mission/getMasterMissionDetailData4" },
			{ "getMasterMyPageNewsData", "user/getMasterMyPageNewsData" },
			{ "getMasterMyPageNewsData2", "user/getMasterMyPageNewsData2" },
			{ "getMasterPresentData", "present/getMasterData" },
			{ "getMasterPvPData", "pvp/getMasterData" },
			{ "getMasterQuestData", "quest/getMasterData" },
			{ "getMasterQuestDropData", "quest/getMasterDropData" },
			{ "getMasterQuestDropData2", "quest/getMasterDropData2" },
			{ "getMasterQuestDropData3", "quest/getMasterDropData3" },
			{ "getMasterQuestDropData4", "quest/getMasterDropData4" },
			{ "getMasterQuestDropData5", "quest/getMasterDropData5" },
			{ "getMasterQuestDropData6", "quest/getMasterDropData6" },
			{ "getMasterQuestEventPointData", "quest/getMasterEventPointData" },
			{ "getMasterQuestStageData", "quest/getMasterStageData" },
			{ "getMasterQuestStageData2", "quest/getMasterStageData2" },
			{ "getMasterQuestStageData3", "quest/getMasterStageData3" },
			{ "getMasterRaceData", "race/getMasterData" },
			{ "getMasterRaidData", "raid/getMasterData" },
			{ "getMasterRoomData", "room/getMasterData" },
			{ "getMasterShopData", "shop/getMasterData" },
			{ "getMasterSoundData", "sound/getMasterData" },
			{ "getMasterStoryData", "story/getMasterData" },
			{ "getMasterTowerData", "tower/getMasterData" },
			{ "getMasterTutorialData", "tutorial/getMasterData" },
			{ "getMasterUserData", "user/getMasterData" },
			{ "payment/getMasterData", "payment/getMasterData" }
		};
	}

}

using AikaSeggs.Common.Core;
using AikaSeggs.Common.Database;
using AikaSeggs.Common.Packets;
using AikaSeggs.Common.Tables;
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

	public class MasterBoostData : ITable
	{
		public ICollection<BoostGroupModel> BoostGroup { get; set; }
		public ICollection<BoostUnitGroupDynamicModel> BoostUnitGroup { get; set; }
	}

	public class MasterCabinMissionData : ITable
	{
		public ICollection<CabinMissionDetailModel> CabinMissionDetail { get; set; }
		public ICollection<CabinMissionMainModel> CabinMissionMain { get; set; }
		public ICollection<CabinMissionRewardModel> CabinMissionReward { get; set; }
	}

	public class MasterCampaignData : ITable
	{
		public ICollection<CampaignModel> Campaign { get; set; }
	}

	public class MasterCharacterAbilityData : ITable
	{
		public ICollection<CharacterAbilityConditionModel> CharacterAbilityCondition { get; set; }
		public ICollection<ExCharacterAbilityGroupModel> CharacterAbilityGroup { get; set; }
		public ICollection<ExCharacterAbilityMainModel> CharacterAbilityMain { get; set; }
		public ICollection<CharacterAbilityUpModel> CharacterAbilityUp { get; set; }
	}

	public class MasterCharacterAbilityEffectData : ITable
	{
		public ICollection<ExCharacterAbilityEffectModel> CharacterAbilityEffect { get; set; }
	}

	public class MasterCharacterAbilityEffectData2 : ITable
	{
		public ICollection<ExCharacterAbilityEffectModel> CharacterAbilityEffect2 { get; set; }
	}

	public class MasterCharacterAbilityEffectData3 : ITable
	{
		public ICollection<ExCharacterAbilityEffectModel> CharacterAbilityEffect3 { get; set; }
	}

	public class MasterCharacterAbilityEffectData4 : ITable
	{
		public ICollection<ExCharacterAbilityEffectModel> CharacterAbilityEffect4 { get; set; }
	}

	public class MasterCharacterAbilityEffectData5 : ITable
	{
		public ICollection<ExCharacterAbilityEffectModel> CharacterAbilityEffect5 { get; set; }
	}

	public class MasterCharacterAbilityEffectData6 : ITable
	{
		public ICollection<ExCharacterAbilityEffectModel> CharacterAbilityEffect6 { get; set; }
	}

	public class MasterCharacterAwakeData : ITable
	{
		public ICollection<ExCharacterAwakeConditionModel> CharacterAwakeCondition { get; set; }
		public ICollection<ExCharacterAwakeEffectModel> CharacterAwakeEffect { get; set; }
		public ICollection<ExCharacterAwakeGroupModel> CharacterAwakeGroup { get; set; }
		public ICollection<ExCharacterAwakeMainModel> CharacterAwakeMain { get; set; }
		public ICollection<ExCharacterAwakeMaterialModel> CharacterAwakeMaterial { get; set; }
	}

	public class MasterCharacterData : ITable
	{
		public ICollection<CharacterContentsModel> CharacterContents { get; set; }
		public ICollection<CharacterExceedLimitModel> CharacterExceedLimit { get; set; }
		public ICollection<CharacterFavoriteModel> CharacterFavorite { get; set; }
		public ICollection<ExCharacterGroupModel> CharacterGroup { get; set; }
		public ICollection<CharacterGroupSeasonModel> CharacterGroupSeason { get; set; }
		public ICollection<CharacterLevelModel> CharacterLevel { get; set; }
		public ICollection<CharacterMaterialModel> CharacterMaterial { get; set; }
		public ICollection<CharacterNormalAttackModel> CharacterNormalAttack { get; set; }
		public ICollection<CharacterSellBonusModel> CharacterSellBonus { get; set; }
		public ICollection<ExceedLimitAlternateItemModel> ExceedLimitAlternateItem { get; set; }
	}

	public class MasterCharacterEvolutionData : ITable
	{
		public ICollection<ExCharacterEvolutionEffectModel> CharacterEvolutionEffect { get; set; }
		public ICollection<ExCharacterEvolutionMainModel> CharacterEvolutionMain { get; set; }
		public ICollection<ExCharacterEvolutionMaterialModel> CharacterEvolutionMaterial { get; set; }
	}

	public class MasterCharacterLinkData : ITable
	{
		public ICollection<CharacterLinkModel> CharacterLink { get; set; }
	}

	public class MasterCharacterMainData : ITable
	{
		public ICollection<CharacterAlterModel> CharacterAlter { get; set; }
		public ICollection<ExCharacterMainModel> CharacterMain { get; set; }
		public ICollection<CharacterStandPositionModel> CharacterStandPosition { get; set; }
	}

	public class MasterCharacterSkillData : ITable
	{
		public ICollection<ExCharacterSkillMainModel> CharacterSkillMain { get; set; }
		public ICollection<CharacterSkillUpModel> CharacterSkillUp { get; set; }
		public ICollection<CharacterSkillUpRateModel> CharacterSkillUpRate { get; set; }
	}

	public class MasterCharacterSkillEffectData : ITable
	{
		public ICollection<CharacterSkillEffectModel> CharacterSkillEffect { get; set; }
	}

	public class MasterCharacterSkillEffectData2 : ITable
	{
		public ICollection<CharacterSkillEffectModel> CharacterSkillEffect2 { get; set; }
	}

	public class MasterCharacterTextData : ITable
	{
		public ICollection<CharacterTextModel> CharacterText { get; set; }
	}

	public class MasterCharacterTextData2 : ITable
	{
		public ICollection<CharacterTextModel> CharacterText2 { get; set; }
	}

	public class MasterCharacterTextData3 : ITable
	{
		public ICollection<CharacterTextModel> CharacterText3 { get; set; }
	}

	public class MasterCharacterTextData4 : ITable
	{
		public ICollection<CharacterTextModel> CharacterText4 { get; set; }
	}

	public class MasterCharacterTextData5 : ITable
	{
		public ICollection<CharacterTextModel> CharacterText5 { get; set; }
	}

	public class MasterComebackData : ITable
	{
		public ICollection<ComebackGachaModel> ComebackGacha { get; set; }
		public ICollection<ComebackGroupModel> ComebackGroup { get; set; }
		public ICollection<ComebackLoginBonusModel> ComebackLoginBonus { get; set; }
		public ICollection<ComebackMainModel> ComebackMain { get; set; }
		public ICollection<ComebackNewsModel> ComebackNews { get; set; }
		public ICollection<ComebackPopupModel> ComebackPopup { get; set; }
		public ICollection<ComebackShopModel> ComebackShop { get; set; }
	}

	public class MasterEquipmentData : ITable
	{
		public ICollection<EquipmentAbilityConditionModel> EquipmentAbilityCondition { get; set; }
		public ICollection<EquipmentExceedLimitModel> EquipmentExceedLimit { get; set; }
		public ICollection<EquipmentExceedLimitItemModel> EquipmentExceedLimitItem { get; set; }
		public ICollection<EquipmentLevelModel> EquipmentLevel { get; set; }
		public ICollection<ExEquipmentMainModel> EquipmentMain { get; set; }
		public ICollection<EquipmentMaterialModel> EquipmentMaterial { get; set; }
		public ICollection<EquipmentTimeModel> EquipmentTime { get; set; }
	}

	public class MasterEquipmentEffectData : ITable
	{
		public ICollection<EquipmentEffectModel> EquipmentEffect { get; set; }
	}

	public class MasterEquipmentEffectData2 : ITable
	{
		public ICollection<EquipmentEffectModel> EquipmentEffect2 { get; set; }
	}

	public class MasterEventData : ITable
	{
		public ICollection<EventBoostCharacterModel> EventBoostCharacter { get; set; }
		public ICollection<EventBoostEffectModel> EventBoostEffect { get; set; }
		public ICollection<EventCharacterModel> EventCharacter { get; set; }
		public ICollection<EventDamageRewardModel> EventDamageReward { get; set; }
		public ICollection<ExEventFriendshipModel> EventFriendship { get; set; }
		public ICollection<ExEventFriendshipCharacterModel> EventFriendshipCharacter { get; set; }
		public ICollection<EventFriendshipRewardModel> EventFriendshipReward { get; set; }
		public ICollection<EventHelpModel> EventHelp { get; set; }
		public ICollection<EventItemModel> EventItem { get; set; }
		public ICollection<ExEventMainModel> EventMain { get; set; }
		public ICollection<ExEventMemorialModel> EventMemorial { get; set; }
		public ICollection<EventPointRewardModel> EventPointReward { get; set; }
		public ICollection<EventRewardRarityModel> EventRewardRarity { get; set; }
		public ICollection<EventSeasonModel> EventSeason { get; set; }
		public ICollection<EventStoryLinkModel> EventStoryLink { get; set; }
	}

	public class MasterExchangeItemDetailData : ITable
	{
		public ICollection<ExExchangeItemDetailModel> ExchangeItemDetail { get; set; }
	}

	public class MasterExchangeItemDetailData2 : ITable
	{
		public ICollection<ExExchangeItemDetailModel> ExchangeItemDetail2 { get; set; }
	}

	public class MasterExchangePointDetailData : ITable
	{
		public ICollection<ExExchangePointDetailModel> ExchangePointDetail { get; set; }
	}

	public class MasterItemData : ITable
	{
		public ICollection<ItemApRecoveryGemModel> ItemApRecoveryGem { get; set; }
		public ICollection<ItemCategoryModel> ItemCategory { get; set; }
		public ICollection<ExItemMainModel> ItemMain { get; set; }
		public ICollection<ItemQuestLockModel> ItemQuestLock { get; set; }
		public ICollection<ItemRecipeModel> ItemRecipe { get; set; }
		public ICollection<ItemSelectModel> ItemSelect { get; set; }
		public ICollection<ItemSellBonusModel> ItemSellBonus { get; set; }
		public ICollection<ItemStoryReleaseModel> ItemStoryRelease { get; set; }
		public ICollection<ItemVoteModel> ItemVote { get; set; }
	}

	public class MasterItemSetData : ITable
	{
		public ICollection<ItemSetModel> ItemSet { get; set; }
	}

	public class MasterItemSetData2 : ITable
	{
		public ICollection<ItemSetModel> ItemSet2 { get; set; }
	}

	public class MasterLinearMissionData : ITable
	{
		public ICollection<ExLinearMissionDetailModel> LinearMissionDetail { get; set; }
		public ICollection<ExLinearMissionMainModel> LinearMissionMain { get; set; }
		public ICollection<ExLinearMissionRewardModel> LinearMissionReward { get; set; }
	}

	public class MasterLoginBonusData : ITable
	{
		public ICollection<LoginBonusModel> LoginBonusMain { get; set; }
		public ICollection<LoginRewardModel> LoginBonusReward { get; set; }
	}

	public class MasterLoginPackData : ITable
	{
		public ICollection<LoginPackMainModel> LoginPackMain { get; set; }
		public ICollection<LoginPackRewardModel> LoginPackReward { get; set; }
	}

	public class MasterMemorialData : ITable
	{
		public ICollection<MemorialAbilityConditionModel> MemorialAbilityCondition { get; set; }
		public ICollection<MemorialAbilityEffectModel> MemorialAbilityEffect { get; set; }
		public ICollection<ExMemorialAbilityGroupModel> MemorialAbilityGroup { get; set; }
		public ICollection<ExMemorialAbilityMainModel> MemorialAbilityMain { get; set; }
		public ICollection<MemorialCollaboModel> MemorialCollabo { get; set; }
		public ICollection<MemorialConvertModel> MemorialConvert { get; set; }
		public ICollection<MemorialExceedLimitModel> MemorialExceedLimit { get; set; }
		public ICollection<MemorialExchangeDetailModel> MemorialExchangeDetail { get; set; }
		public ICollection<MemorialLevelModel> MemorialLevel { get; set; }
		public ICollection<ExMemorialMainModel> MemorialMain { get; set; }
		public ICollection<MemorialShopDetailModel> MemorialShopDetail { get; set; }
		public ICollection<MemorialStatusModel> MemorialStatus { get; set; }
		public ICollection<MemorialTextModel> MemorialText { get; set; }
	}

	public class MasterMinigameData : ITable
	{
		public ICollection<MinigameCharacterMainModel> MinigameCharacterMain { get; set; }
		public ICollection<MinigameCharacterTextModel> MinigameCharacterText { get; set; }
	}

	public class MasterMissionData : ITable
	{
		public ICollection<ExMissionMainModel> MissionMain { get; set; }
		public ICollection<MissionRewardModel> MissionReward { get; set; }
		public ICollection<ExUniqueMissionModel> UniqueMission { get; set; }
	}

	public class MasterMissionDetailData : ITable
	{
		public ICollection<MissionDetailModel> MissionDetail { get; set; }
	}

	public class MasterMissionDetailData2 : ITable
	{
		public ICollection<MissionDetailModel> MissionDetail2 { get; set; }
	}

	public class MasterMissionDetailData3 : ITable
	{
		public ICollection<MissionDetailModel> MissionDetail3 { get; set; }
	}

	public class MasterMissionDetailData4 : ITable
	{
		public ICollection<MissionDetailModel> MissionDetail4 { get; set; }
	}

	public class MasterMyPageNewsData : ITable
	{
		public ICollection<ExMyPageNewsModel> MyPageNews { get; set; }
	}

	public class MasterMyPageNewsData2 : ITable
	{
		public ICollection<ExMyPageNewsModel> MyPageNews2 { get; set; }
	}

	public class MasterPresentData : ITable
	{
		public ICollection<PresentMessageModel> PresentMessage { get; set; }
	}

	public class MasterPvPData : ITable
	{
		public ICollection<PvPClassModel> PvPClass { get; set; }
		public ICollection<PvPClassRewardModel> PvPClassReward { get; set; }
		public ICollection<PvPMainModel> PvPMain { get; set; }
	}

	public class MasterQuestData : ITable
	{
		public ICollection<BossEventPointModel> BossEventPoint { get; set; }
		public ICollection<BossGaugeColorModel> BossGaugeColor { get; set; }
		public ICollection<BossRageAnimationModel> BossRageAnimation { get; set; }
		public ICollection<BossStageModel> BossStage { get; set; }
		public ICollection<QuestAchieveModel> QuestAchieve { get; set; }
		public ICollection<ExQuestAreaModel> QuestArea { get; set; }
		public ICollection<QuestIconModel> QuestIcon { get; set; }
		public ICollection<QuestIconChangeModel> QuestIconChange { get; set; }
		public ICollection<QuestRestrictionGroupModel> QuestRestrictionGroup { get; set; }
		public ICollection<QuestRestrictionMainModel> QuestRestrictionMain { get; set; }
		public ICollection<ExQuestScenarioModel> QuestScenario { get; set; }
		public ICollection<ExQuestStageConditionModel> QuestStageCondition { get; set; }
		public ICollection<QuestStageSeasonDynamicModel> QuestStageSeason { get; set; }
		public ICollection<ExQuestWorldModel> QuestWorld { get; set; }
	}

	public class MasterQuestDropData : ITable
	{
		public ICollection<QuestDropModel> QuestDrop { get; set; }
	}

	public class MasterQuestDropData2 : ITable
	{
		public ICollection<QuestDropModel> QuestDrop2 { get; set; }
	}

	public class MasterQuestDropData3 : ITable
	{
		public ICollection<QuestDropModel> QuestDrop3 { get; set; }
	}

	public class MasterQuestDropData4 : ITable
	{
		public ICollection<QuestDropModel> QuestDrop4 { get; set; }
	}

	public class MasterQuestDropData5 : ITable
	{
		public ICollection<QuestDropModel> QuestDrop5 { get; set; }
	}

	public class MasterQuestDropData6 : ITable
	{
		public ICollection<QuestDropModel> QuestDrop6 { get; set; }
	}

	public class MasterQuestEventPointData : ITable
	{
		public ICollection<QuestEventPointModel> QuestEventPoint { get; set; }
	}

	public class MasterQuestStageData : ITable
	{
		public ICollection<ExQuestStageModel> QuestStage { get; set; }
	}

	public class MasterQuestStageData2 : ITable
	{
		public ICollection<ExQuestStageModel> QuestStage2 { get; set; }
	}

	public class MasterQuestStageData3 : ITable
	{
		public ICollection<ExQuestStageModel> QuestStage3 { get; set; }
	}

	public class MasterRaceData : ITable
	{
		public ICollection<ExRaceAbilityEffectModel> RaceAbilityEffect { get; set; }
		public ICollection<ExRaceAbilityEffectGroupModel> RaceAbilityEffectGroup { get; set; }
		public ICollection<ExRaceAbilityGroupModel> RaceAbilityGroup { get; set; }
		public ICollection<ExRaceAbilityMainModel> RaceAbilityMain { get; set; }
		public ICollection<ExRaceAreaModel> RaceArea { get; set; }
		public ICollection<RaceCharacterFreeModel> RaceCharacterFree { get; set; }
		public ICollection<ExRaceCharacterMainModel> RaceCharacterMain { get; set; }
		public ICollection<ExRaceCommentaryTextModel> RaceCommentaryText { get; set; }
		public ICollection<RaceEffectTargetModel> RaceEffectTarget { get; set; }
		public ICollection<RaceEffectTimingModel> RaceEffectTiming { get; set; }
		public ICollection<RaceEffectTypeModel> RaceEffectType { get; set; }
		public ICollection<RaceEffectValueTypeModel> RaceEffectValueType { get; set; }
		public ICollection<RaceFortifyModel> RaceFortify { get; set; }
		public ICollection<ExRaceMainModel> RaceMain { get; set; }
		public ICollection<ExRaceObstacleModel> RaceObstacle { get; set; }
		public ICollection<ExRaceRewardModel> RaceReward { get; set; }
		public ICollection<ExRaceStageModel> RaceStage { get; set; }
		public ICollection<RaceStatusModel> RaceStatus { get; set; }
		public ICollection<ExRaceTextModel> RaceText { get; set; }
		public ICollection<RaceTopTextModel> RaceTopText { get; set; }
	}

	public class MasterRaidData : ITable
	{
		public ICollection<RaidBattleModel> RaidBattle { get; set; }
		public ICollection<RaidBattleTypeModel> RaidBattleType { get; set; }
		public ICollection<RaidRewardModel> RaidReward { get; set; }
		public ICollection<RaidRewardGroupModel> RaidRewardGroup { get; set; }
	}

	public class MasterRoomData : ITable
	{
		public ICollection<FurnitureCategoryModel> FurnitureCategory { get; set; }
		public ICollection<FurnitureCollectModel> FurnitureCollect { get; set; }
		public ICollection<FurnitureCostModel> FurnitureCost { get; set; }
		public ICollection<ExFurnitureMainModel> FurnitureMain { get; set; }
		public ICollection<FurnitureTypeModel> FurnitureType { get; set; }
		public ICollection<RoomCharacterFrameModel> RoomCharacterFrame { get; set; }
		public ICollection<RoomMainModel> RoomMain { get; set; }
		public ICollection<SpecialRoomActionModel> SpecialRoomAction { get; set; }
		public ICollection<SpecialRoomBaseSpineModel> SpecialRoomBaseSpine { get; set; }
		public ICollection<SpecialRoomConditionalModel> SpecialRoomCondition { get; set; }
		public ICollection<SpecialRoomMainModel> SpecialRoomMain { get; set; }
		public ICollection<SpecialRoomTapPointModel> SpecialRoomTapPoint { get; set; }
		public ICollection<SpecialRoomTextModel> SpecialRoomText { get; set; }
	}

	public class MasterShopData : ITable
	{
		public ICollection<ExchangeGroupModel> ExchangeGroup { get; set; }
		public ICollection<ExExchangeMainModel> ExchangeMain { get; set; }
		public ICollection<dynamic> GachaCharacterCondition { get; set; }
		public ICollection<ExShopDetailModel> ShopDetail { get; set; }
		public ICollection<ShopDetailConditionModel> ShopDetailCondition { get; set; }
		public ICollection<ShopEventItemConditionModel> ShopEventItemCondition { get; set; }
		public ICollection<ShopListGroupModel> ShopListGroup { get; set; }
		public ICollection<ShopMainModel> ShopMain { get; set; }
		public ICollection<ShopOrderPackModel> ShopOrderPack { get; set; }
	}

	public class MasterSoundData : ITable
	{
		public ICollection<ExSoundMainModel> SoundMain { get; set; }
	}

	public class MasterStoryData : ITable
	{
		public ICollection<FreeStoryModel> FreeStory { get; set; }
		public ICollection<ExStoryCabinModel> StoryCabin { get; set; }
		public ICollection<ExStoryCategoryModel> StoryCategory { get; set; }
		public ICollection<ExStoryEventModel> StoryEvent { get; set; }
		public ICollection<ExStoryGachaModel> StoryGacha { get; set; }
		public ICollection<ExStoryGroupModel> StoryGroup { get; set; }
		public ICollection<ExStoryMemorialModel> StoryMemorial { get; set; }
		public ICollection<ExStoryMemorialEventOtherModel> StoryMemorialEventOther { get; set; }
		public ICollection<ExStoryOtherModel> StoryOther { get; set; }
		public ICollection<ExStoryPictureBookModel> StoryPictureBook { get; set; }
		public ICollection<ExStoryQuestModel> StoryQuest { get; set; }
		public ICollection<ExStoryRoomModel> StoryRoom { get; set; }
		public ICollection<ExStoryTutorialModel> StoryTutorial { get; set; }
		public ICollection<ExStoryVoiceModel> StoryVoice { get; set; }
	}

	public class MasterTowerData : ITable
	{
		public ICollection<TowerMainModel> TowerMain { get; set; }
		public ICollection<TowerRewardModel> TowerReward { get; set; }
		public ICollection<TowerRewardGroupModel> TowerRewardGroup { get; set; }
	}

	public class MasterTutorialData : ITable
	{
		public ICollection<TutorialEventModel> TutorialEvent { get; set; }
		public ICollection<TutorialMainStepModel> TutorialMainStep { get; set; }
		public ICollection<TutorialSkipModel> TutorialSkip { get; set; }
		public ICollection<TutorialSubStepModel> TutorialSubStep { get; set; }
	}

	public class MasterUserData : ITable
	{
		public ICollection<LoadingCharacterModel> LoadingCharacter { get; set; }
		public ICollection<LoadingIllustModel> LoadingIllust { get; set; }
		public ICollection<LoadingMainModel> LoadingMain { get; set; }
		public ICollection<LoadingTipsModel> LoadingTips { get; set; }
		public ICollection<MyPageBannerModel> MyPageBanner { get; set; }
		public ICollection<MyPageEventModel> MyPageEvent { get; set; }
		public ICollection<MyPageMainModel> MyPageMain { get; set; }
		public ICollection<ExMyPagePopupModel> MyPagePopup { get; set; }
		public ICollection<UserBuffHelpModel> UserBuffHelp { get; set; }
		public ICollection<UserHelpModel> UserHelp { get; set; }
		public ICollection<UserHowToPlayModel> UserHowToPlay { get; set; }
		public ICollection<UserMainModel> UserMain { get; set; }
		public ICollection<UserProgressModel> UserProgress { get; set; }
	}

	public class MasterPaymentData : ITable
	{
		public ICollection<DmmModel> Dmm { get; set; }
	}

}

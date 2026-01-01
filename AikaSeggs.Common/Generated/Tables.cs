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
		public List<BoostGroupModel> BoostGroup { get; set; }
		public List<BoostUnitGroupDynamicModel> BoostUnitGroup { get; set; }
	}

	public class MasterCabinMissionData : ITable
	{
		public List<CabinMissionDetailModel> CabinMissionDetail { get; set; }
		public List<CabinMissionMainModel> CabinMissionMain { get; set; }
		public List<CabinMissionRewardModel> CabinMissionReward { get; set; }
	}

	public class MasterCampaignData : ITable
	{
		public List<CampaignModel> Campaign { get; set; }
	}

	public class MasterCharacterAbilityData : ITable
	{
		public List<CharacterAbilityConditionModel> CharacterAbilityCondition { get; set; }
		public List<ExCharacterAbilityGroupModel> CharacterAbilityGroup { get; set; }
		public List<ExCharacterAbilityMainModel> CharacterAbilityMain { get; set; }
		public List<CharacterAbilityUpModel> CharacterAbilityUp { get; set; }
	}

	public class MasterCharacterAbilityEffectData : ITable
	{
		public List<ExCharacterAbilityEffectModel> CharacterAbilityEffect { get; set; }
	}

	public class MasterCharacterAbilityEffectData2 : ITable
	{
		public List<ExCharacterAbilityEffectModel> CharacterAbilityEffect2 { get; set; }
	}

	public class MasterCharacterAbilityEffectData3 : ITable
	{
		public List<ExCharacterAbilityEffectModel> CharacterAbilityEffect3 { get; set; }
	}

	public class MasterCharacterAbilityEffectData4 : ITable
	{
		public List<ExCharacterAbilityEffectModel> CharacterAbilityEffect4 { get; set; }
	}

	public class MasterCharacterAbilityEffectData5 : ITable
	{
		public List<ExCharacterAbilityEffectModel> CharacterAbilityEffect5 { get; set; }
	}

	public class MasterCharacterAbilityEffectData6 : ITable
	{
		public List<ExCharacterAbilityEffectModel> CharacterAbilityEffect6 { get; set; }
	}

	public class MasterCharacterAwakeData : ITable
	{
		public List<ExCharacterAwakeConditionModel> CharacterAwakeCondition { get; set; }
		public List<ExCharacterAwakeEffectModel> CharacterAwakeEffect { get; set; }
		public List<ExCharacterAwakeGroupModel> CharacterAwakeGroup { get; set; }
		public List<ExCharacterAwakeMainModel> CharacterAwakeMain { get; set; }
		public List<ExCharacterAwakeMaterialModel> CharacterAwakeMaterial { get; set; }
	}

	public class MasterCharacterData : ITable
	{
		public List<CharacterContentsModel> CharacterContents { get; set; }
		public List<CharacterExceedLimitModel> CharacterExceedLimit { get; set; }
		public List<CharacterFavoriteModel> CharacterFavorite { get; set; }
		public List<ExCharacterGroupModel> CharacterGroup { get; set; }
		public List<CharacterGroupSeasonModel> CharacterGroupSeason { get; set; }
		public List<CharacterLevelModel> CharacterLevel { get; set; }
		public List<CharacterMaterialModel> CharacterMaterial { get; set; }
		public List<CharacterNormalAttackModel> CharacterNormalAttack { get; set; }
		public List<CharacterSellBonusModel> CharacterSellBonus { get; set; }
		public List<ExceedLimitAlternateItemModel> ExceedLimitAlternateItem { get; set; }
	}

	public class MasterCharacterEvolutionData : ITable
	{
		public List<ExCharacterEvolutionEffectModel> CharacterEvolutionEffect { get; set; }
		public List<ExCharacterEvolutionMainModel> CharacterEvolutionMain { get; set; }
		public List<ExCharacterEvolutionMaterialModel> CharacterEvolutionMaterial { get; set; }
	}

	public class MasterCharacterLinkData : ITable
	{
		public List<CharacterLinkModel> CharacterLink { get; set; }
	}

	public class MasterCharacterMainData : ITable
	{
		public List<CharacterAlterModel> CharacterAlter { get; set; }
		public List<ExCharacterMainModel> CharacterMain { get; set; }
		public List<CharacterStandPositionModel> CharacterStandPosition { get; set; }
	}

	public class MasterCharacterSkillData : ITable
	{
		public List<ExCharacterSkillMainModel> CharacterSkillMain { get; set; }
		public List<CharacterSkillUpModel> CharacterSkillUp { get; set; }
		public List<CharacterSkillUpRateModel> CharacterSkillUpRate { get; set; }
	}

	public class MasterCharacterSkillEffectData : ITable
	{
		public List<CharacterSkillEffectModel> CharacterSkillEffect { get; set; }
	}

	public class MasterCharacterSkillEffectData2 : ITable
	{
		public List<CharacterSkillEffectModel> CharacterSkillEffect2 { get; set; }
	}

	public class MasterCharacterTextData : ITable
	{
		public List<CharacterTextModel> CharacterText { get; set; }
	}

	public class MasterCharacterTextData2 : ITable
	{
		public List<CharacterTextModel> CharacterText2 { get; set; }
	}

	public class MasterCharacterTextData3 : ITable
	{
		public List<CharacterTextModel> CharacterText3 { get; set; }
	}

	public class MasterCharacterTextData4 : ITable
	{
		public List<CharacterTextModel> CharacterText4 { get; set; }
	}

	public class MasterCharacterTextData5 : ITable
	{
		public List<CharacterTextModel> CharacterText5 { get; set; }
	}

	public class MasterComebackData : ITable
	{
		public List<ComebackGachaModel> ComebackGacha { get; set; }
		public List<ComebackGroupModel> ComebackGroup { get; set; }
		public List<ComebackLoginBonusModel> ComebackLoginBonus { get; set; }
		public List<ComebackMainModel> ComebackMain { get; set; }
		public List<ComebackNewsModel> ComebackNews { get; set; }
		public List<ComebackPopupModel> ComebackPopup { get; set; }
		public List<ComebackShopModel> ComebackShop { get; set; }
	}

	public class MasterEquipmentData : ITable
	{
		public List<EquipmentAbilityConditionModel> EquipmentAbilityCondition { get; set; }
		public List<EquipmentExceedLimitModel> EquipmentExceedLimit { get; set; }
		public List<EquipmentExceedLimitItemModel> EquipmentExceedLimitItem { get; set; }
		public List<EquipmentLevelModel> EquipmentLevel { get; set; }
		public List<ExEquipmentMainModel> EquipmentMain { get; set; }
		public List<EquipmentMaterialModel> EquipmentMaterial { get; set; }
		public List<EquipmentTimeModel> EquipmentTime { get; set; }
	}

	public class MasterEquipmentEffectData : ITable
	{
		public List<EquipmentEffectModel> EquipmentEffect { get; set; }
	}

	public class MasterEquipmentEffectData2 : ITable
	{
		public List<EquipmentEffectModel> EquipmentEffect2 { get; set; }
	}

	public class MasterEventData : ITable
	{
		public List<EventBoostCharacterModel> EventBoostCharacter { get; set; }
		public List<EventBoostEffectModel> EventBoostEffect { get; set; }
		public List<EventCharacterModel> EventCharacter { get; set; }
		public List<EventDamageRewardModel> EventDamageReward { get; set; }
		public List<ExEventFriendshipModel> EventFriendship { get; set; }
		public List<ExEventFriendshipCharacterModel> EventFriendshipCharacter { get; set; }
		public List<EventFriendshipRewardModel> EventFriendshipReward { get; set; }
		public List<EventHelpModel> EventHelp { get; set; }
		public List<EventItemModel> EventItem { get; set; }
		public List<ExEventMainModel> EventMain { get; set; }
		public List<ExEventMemorialModel> EventMemorial { get; set; }
		public List<EventPointRewardModel> EventPointReward { get; set; }
		public List<EventRewardRarityModel> EventRewardRarity { get; set; }
		public List<EventSeasonModel> EventSeason { get; set; }
		public List<EventStoryLinkModel> EventStoryLink { get; set; }
	}

	public class MasterExchangeItemDetailData : ITable
	{
		public List<ExExchangeItemDetailModel> ExchangeItemDetail { get; set; }
	}

	public class MasterExchangeItemDetailData2 : ITable
	{
		public List<ExExchangeItemDetailModel> ExchangeItemDetail2 { get; set; }
	}

	public class MasterExchangePointDetailData : ITable
	{
		public List<ExExchangePointDetailModel> ExchangePointDetail { get; set; }
	}

	public class MasterItemData : ITable
	{
		public List<ItemApRecoveryGemModel> ItemApRecoveryGem { get; set; }
		public List<ItemCategoryModel> ItemCategory { get; set; }
		public List<ExItemMainModel> ItemMain { get; set; }
		public List<ItemQuestLockModel> ItemQuestLock { get; set; }
		public List<ItemRecipeModel> ItemRecipe { get; set; }
		public List<ItemSelectModel> ItemSelect { get; set; }
		public List<ItemSellBonusModel> ItemSellBonus { get; set; }
		public List<ItemStoryReleaseModel> ItemStoryRelease { get; set; }
		public List<ItemVoteModel> ItemVote { get; set; }
	}

	public class MasterItemSetData : ITable
	{
		public List<ItemSetModel> ItemSet { get; set; }
	}

	public class MasterItemSetData2 : ITable
	{
		public List<ItemSetModel> ItemSet2 { get; set; }
	}

	public class MasterLinearMissionData : ITable
	{
		public List<ExLinearMissionDetailModel> LinearMissionDetail { get; set; }
		public List<ExLinearMissionMainModel> LinearMissionMain { get; set; }
		public List<ExLinearMissionRewardModel> LinearMissionReward { get; set; }
	}

	public class MasterLoginBonusData : ITable
	{
		public List<LoginBonusModel> LoginBonusMain { get; set; }
		public List<LoginRewardModel> LoginBonusReward { get; set; }
	}

	public class MasterLoginPackData : ITable
	{
		public List<LoginPackMainModel> LoginPackMain { get; set; }
		public List<LoginPackRewardModel> LoginPackReward { get; set; }
	}

	public class MasterMemorialData : ITable
	{
		public List<MemorialAbilityConditionModel> MemorialAbilityCondition { get; set; }
		public List<MemorialAbilityEffectModel> MemorialAbilityEffect { get; set; }
		public List<ExMemorialAbilityGroupModel> MemorialAbilityGroup { get; set; }
		public List<ExMemorialAbilityMainModel> MemorialAbilityMain { get; set; }
		public List<MemorialCollaboModel> MemorialCollabo { get; set; }
		public List<MemorialConvertModel> MemorialConvert { get; set; }
		public List<MemorialExceedLimitModel> MemorialExceedLimit { get; set; }
		public List<MemorialExchangeDetailModel> MemorialExchangeDetail { get; set; }
		public List<MemorialLevelModel> MemorialLevel { get; set; }
		public List<ExMemorialMainModel> MemorialMain { get; set; }
		public List<MemorialShopDetailModel> MemorialShopDetail { get; set; }
		public List<MemorialStatusModel> MemorialStatus { get; set; }
		public List<MemorialTextModel> MemorialText { get; set; }
	}

	public class MasterMinigameData : ITable
	{
		public List<MinigameCharacterMainModel> MinigameCharacterMain { get; set; }
		public List<MinigameCharacterTextModel> MinigameCharacterText { get; set; }
	}

	public class MasterMissionData : ITable
	{
		public List<ExMissionMainModel> MissionMain { get; set; }
		public List<MissionRewardModel> MissionReward { get; set; }
		public List<ExUniqueMissionModel> UniqueMission { get; set; }
	}

	public class MasterMissionDetailData : ITable
	{
		public List<MissionDetailModel> MissionDetail { get; set; }
	}

	public class MasterMissionDetailData2 : ITable
	{
		public List<MissionDetailModel> MissionDetail2 { get; set; }
	}

	public class MasterMissionDetailData3 : ITable
	{
		public List<MissionDetailModel> MissionDetail3 { get; set; }
	}

	public class MasterMissionDetailData4 : ITable
	{
		public List<MissionDetailModel> MissionDetail4 { get; set; }
	}

	public class MasterMyPageNewsData : ITable
	{
		public List<ExMyPageNewsModel> MyPageNews { get; set; }
	}

	public class MasterMyPageNewsData2 : ITable
	{
		public List<ExMyPageNewsModel> MyPageNews2 { get; set; }
	}

	public class MasterPresentData : ITable
	{
		public List<PresentMessageModel> PresentMessage { get; set; }
	}

	public class MasterPvPData : ITable
	{
		public List<PvPClassModel> PvPClass { get; set; }
		public List<PvPClassRewardModel> PvPClassReward { get; set; }
		public List<PvPMainModel> PvPMain { get; set; }
	}

	public class MasterQuestData : ITable
	{
		public List<BossEventPointModel> BossEventPoint { get; set; }
		public List<BossGaugeColorModel> BossGaugeColor { get; set; }
		public List<BossRageAnimationModel> BossRageAnimation { get; set; }
		public List<BossStageModel> BossStage { get; set; }
		public List<QuestAchieveModel> QuestAchieve { get; set; }
		public List<ExQuestAreaModel> QuestArea { get; set; }
		public List<QuestIconModel> QuestIcon { get; set; }
		public List<QuestIconChangeModel> QuestIconChange { get; set; }
		public List<QuestRestrictionGroupModel> QuestRestrictionGroup { get; set; }
		public List<QuestRestrictionMainModel> QuestRestrictionMain { get; set; }
		public List<ExQuestScenarioModel> QuestScenario { get; set; }
		public List<ExQuestStageConditionModel> QuestStageCondition { get; set; }
		public List<QuestStageSeasonDynamicModel> QuestStageSeason { get; set; }
		public List<ExQuestWorldModel> QuestWorld { get; set; }
	}

	public class MasterQuestDropData : ITable
	{
		public List<QuestDropModel> QuestDrop { get; set; }
	}

	public class MasterQuestDropData2 : ITable
	{
		public List<QuestDropModel> QuestDrop2 { get; set; }
	}

	public class MasterQuestDropData3 : ITable
	{
		public List<QuestDropModel> QuestDrop3 { get; set; }
	}

	public class MasterQuestDropData4 : ITable
	{
		public List<QuestDropModel> QuestDrop4 { get; set; }
	}

	public class MasterQuestDropData5 : ITable
	{
		public List<QuestDropModel> QuestDrop5 { get; set; }
	}

	public class MasterQuestDropData6 : ITable
	{
		public List<QuestDropModel> QuestDrop6 { get; set; }
	}

	public class MasterQuestEventPointData : ITable
	{
		public List<QuestEventPointModel> QuestEventPoint { get; set; }
	}

	public class MasterQuestStageData : ITable
	{
		public List<ExQuestStageModel> QuestStage { get; set; }
	}

	public class MasterQuestStageData2 : ITable
	{
		public List<ExQuestStageModel> QuestStage2 { get; set; }
	}

	public class MasterQuestStageData3 : ITable
	{
		public List<ExQuestStageModel> QuestStage3 { get; set; }
	}

	public class MasterRaceData : ITable
	{
		public List<ExRaceAbilityEffectModel> RaceAbilityEffect { get; set; }
		public List<ExRaceAbilityEffectGroupModel> RaceAbilityEffectGroup { get; set; }
		public List<ExRaceAbilityGroupModel> RaceAbilityGroup { get; set; }
		public List<ExRaceAbilityMainModel> RaceAbilityMain { get; set; }
		public List<ExRaceAreaModel> RaceArea { get; set; }
		public List<RaceCharacterFreeModel> RaceCharacterFree { get; set; }
		public List<ExRaceCharacterMainModel> RaceCharacterMain { get; set; }
		public List<ExRaceCommentaryTextModel> RaceCommentaryText { get; set; }
		public List<RaceEffectTargetModel> RaceEffectTarget { get; set; }
		public List<RaceEffectTimingModel> RaceEffectTiming { get; set; }
		public List<RaceEffectTypeModel> RaceEffectType { get; set; }
		public List<RaceEffectValueTypeModel> RaceEffectValueType { get; set; }
		public List<RaceFortifyModel> RaceFortify { get; set; }
		public List<ExRaceMainModel> RaceMain { get; set; }
		public List<ExRaceObstacleModel> RaceObstacle { get; set; }
		public List<ExRaceRewardModel> RaceReward { get; set; }
		public List<ExRaceStageModel> RaceStage { get; set; }
		public List<RaceStatusModel> RaceStatus { get; set; }
		public List<ExRaceTextModel> RaceText { get; set; }
		public List<RaceTopTextModel> RaceTopText { get; set; }
	}

	public class MasterRaidData : ITable
	{
		public List<RaidBattleModel> RaidBattle { get; set; }
		public List<RaidBattleTypeModel> RaidBattleType { get; set; }
		public List<RaidRewardModel> RaidReward { get; set; }
		public List<RaidRewardGroupModel> RaidRewardGroup { get; set; }
	}

	public class MasterRoomData : ITable
	{
		public List<FurnitureCategoryModel> FurnitureCategory { get; set; }
		public List<FurnitureCollectModel> FurnitureCollect { get; set; }
		public List<FurnitureCostModel> FurnitureCost { get; set; }
		public List<ExFurnitureMainModel> FurnitureMain { get; set; }
		public List<FurnitureTypeModel> FurnitureType { get; set; }
		public List<RoomCharacterFrameModel> RoomCharacterFrame { get; set; }
		public List<RoomMainModel> RoomMain { get; set; }
		public List<SpecialRoomActionModel> SpecialRoomAction { get; set; }
		public List<SpecialRoomBaseSpineModel> SpecialRoomBaseSpine { get; set; }
		public List<SpecialRoomConditionalModel> SpecialRoomCondition { get; set; }
		public List<SpecialRoomMainModel> SpecialRoomMain { get; set; }
		public List<SpecialRoomTapPointModel> SpecialRoomTapPoint { get; set; }
		public List<SpecialRoomTextModel> SpecialRoomText { get; set; }
	}

	public class MasterShopData : ITable
	{
		public List<ExchangeGroupModel> ExchangeGroup { get; set; }
		public List<ExExchangeMainModel> ExchangeMain { get; set; }
		public List<dynamic> GachaCharacterCondition { get; set; }
		public List<ExShopDetailModel> ShopDetail { get; set; }
		public List<ShopDetailConditionModel> ShopDetailCondition { get; set; }
		public List<ShopEventItemConditionModel> ShopEventItemCondition { get; set; }
		public List<ShopListGroupModel> ShopListGroup { get; set; }
		public List<ShopMainModel> ShopMain { get; set; }
		public List<ShopOrderPackModel> ShopOrderPack { get; set; }
	}

	public class MasterSoundData : ITable
	{
		public List<ExSoundMainModel> SoundMain { get; set; }
	}

	public class MasterStoryData : ITable
	{
		public List<FreeStoryModel> FreeStory { get; set; }
		public List<ExStoryCabinModel> StoryCabin { get; set; }
		public List<ExStoryCategoryModel> StoryCategory { get; set; }
		public List<ExStoryEventModel> StoryEvent { get; set; }
		public List<ExStoryGachaModel> StoryGacha { get; set; }
		public List<ExStoryGroupModel> StoryGroup { get; set; }
		public List<ExStoryMemorialModel> StoryMemorial { get; set; }
		public List<ExStoryMemorialEventOtherModel> StoryMemorialEventOther { get; set; }
		public List<ExStoryOtherModel> StoryOther { get; set; }
		public List<ExStoryPictureBookModel> StoryPictureBook { get; set; }
		public List<ExStoryQuestModel> StoryQuest { get; set; }
		public List<ExStoryRoomModel> StoryRoom { get; set; }
		public List<ExStoryTutorialModel> StoryTutorial { get; set; }
		public List<ExStoryVoiceModel> StoryVoice { get; set; }
	}

	public class MasterTowerData : ITable
	{
		public List<TowerMainModel> TowerMain { get; set; }
		public List<TowerRewardModel> TowerReward { get; set; }
		public List<TowerRewardGroupModel> TowerRewardGroup { get; set; }
	}

	public class MasterTutorialData : ITable
	{
		public List<TutorialEventModel> TutorialEvent { get; set; }
		public List<TutorialMainStepModel> TutorialMainStep { get; set; }
		public List<TutorialSkipModel> TutorialSkip { get; set; }
		public List<TutorialSubStepModel> TutorialSubStep { get; set; }
	}

	public class MasterUserData : ITable
	{
		public List<LoadingCharacterModel> LoadingCharacter { get; set; }
		public List<LoadingIllustModel> LoadingIllust { get; set; }
		public List<LoadingMainModel> LoadingMain { get; set; }
		public List<LoadingTipsModel> LoadingTips { get; set; }
		public List<MyPageBannerModel> MyPageBanner { get; set; }
		public List<MyPageEventModel> MyPageEvent { get; set; }
		public List<MyPageMainModel> MyPageMain { get; set; }
		public List<ExMyPagePopupModel> MyPagePopup { get; set; }
		public List<UserBuffHelpModel> UserBuffHelp { get; set; }
		public List<UserHelpModel> UserHelp { get; set; }
		public List<UserHowToPlayModel> UserHowToPlay { get; set; }
		public List<UserMainModel> UserMain { get; set; }
		public List<UserProgressModel> UserProgress { get; set; }
	}

	public class MasterPaymentData : ITable
	{
		public List<DmmModel> Dmm { get; set; }
	}

}

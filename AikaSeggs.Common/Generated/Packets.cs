using AikaSeggs.Common.Core;
using AikaSeggs.Common.Database;
using AikaSeggs.Common.Packets;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace AikaSeggs.Common.Packets
{
	public class AuthGetDmmAccessTokenResponse : BasePacket
	{
		public string dmmId { get; set; }
		public int expires { get; set; }
		public string secret { get; set; }
		public string token { get; set; }
		public string userId { get; set; }
	}

	public class BoostGetMasterDataResponse : BasePacket
	{
		public List<BoostGroupModel> BoostGroup { get; set; }
		public List<BoostUnitGroupDynamicModel> BoostUnitGroup { get; set; }
	}

	public class BoxGachaGetBoxDetailResponse : BasePacket
	{
		public Dictionary<string, Dictionary<string, AllLineupsDynamicModel>> allLineups { get; set; }
		public List<BoxLineupsDynamicModel> boxLineups { get; set; }
		public List<ButtonsDynamicModel> buttons { get; set; }
		public int conditionFrom { get; set; }
		public int conditionTo { get; set; }
		public int conditionType { get; set; }
		public CharacterTextModel description { get; set; }
		public string fromDate { get; set; }
		public int gachaId { get; set; }
		public bool isReset { get; set; }
		public int resetCount { get; set; }
		public int step { get; set; }
		public string toDate { get; set; }
		public UserBasicInfoModel user { get; set; }
		public string weekType { get; set; }
	}

	public class CabinMissionGetMasterDataResponse : BasePacket
	{
		public List<CabinMissionDetailModel> CabinMissionDetail { get; set; }
		public List<CabinMissionMainModel> CabinMissionMain { get; set; }
		public List<CabinMissionRewardModel> CabinMissionReward { get; set; }
	}

	public class CabinMissionGetUserDataResponse : BasePacket
	{
		public List<CabinMissionModel> cabinMissions { get; set; }
	}

	public class CabinMissionReceiveResponse : BasePacket
	{
		public List<CabinMissionModel> cabinMissions { get; set; }
		public List<StoryModel> stories { get; set; }
	}

	public class CampaignGetMasterDataResponse : BasePacket
	{
		public List<CampaignModel> Campaign { get; set; }
	}

	public class CharacterAwakeResponse : BasePacket
	{
		public List<EquipmentModel> addEquipments { get; set; }
		public List<CharacterModel> characters { get; set; }
		public List<ItemModel> items { get; set; }
	}

	public class CharacterBulkFortifySkillWarehouseResponse : BasePacket
	{
		public List<CharacterModel> characters { get; set; }
		public List<LinearMissionModel> finishedLinearMissions { get; set; }
		public List<string> finishedMissionCds { get; set; }
		public List<ItemModel> items { get; set; }
		public List<LinearMissionModel> linearMissions { get; set; }
		public List<MissionModel> missions { get; set; }
		public int tryCount { get; set; }
		public List<WarehouseMaterialModel> updateWarehouseMaterials { get; set; }
	}

	public class CharacterChangePartnerResponse : BasePacket
	{
		public UserBasicInfoModel user { get; set; }
	}

	public class CharacterChangeProtectResponse : BasePacket
	{
		public List<CharacterModel> updateCharacters { get; set; }
	}

	public class CharacterEquipResponse : BasePacket
	{
		public List<CharacterModel> characters { get; set; }
	}

	public class CharacterExceedLimitByItemResponse : BasePacket
	{
		public List<UserStoryModel> addStories { get; set; }
		public List<CharacterModel> characters { get; set; }
		public List<string> finishedMissionCds { get; set; }
		public List<ItemModel> items { get; set; }
		public List<MissionModel> missions { get; set; }
		public List<PictureBookDetailModel> pictureBookDetail { get; set; }
		public List<StoryModel> stories { get; set; }
	}

	public class CharacterFortifyAbilityResponse : BasePacket
	{
		public List<CharacterModel> characters { get; set; }
		public List<LinearMissionModel> finishedLinearMissions { get; set; }
		public List<string> finishedMissionCds { get; set; }
		public List<ItemModel> items { get; set; }
		public List<LinearMissionModel> linearMissions { get; set; }
		public List<MissionModel> missions { get; set; }
	}

	public class CharacterFortifySkillWarehouseResponse : BasePacket
	{
		public List<CharacterModel> characters { get; set; }
		public List<LinearMissionModel> finishedLinearMissions { get; set; }
		public List<string> finishedMissionCds { get; set; }
		public List<ItemModel> items { get; set; }
		public List<LinearMissionModel> linearMissions { get; set; }
		public List<MissionModel> missions { get; set; }
		public List<WarehouseCharacterModel> updateWarehouseCharacters { get; set; }
		public List<WarehouseMaterialModel> updateWarehouseMaterials { get; set; }
	}

	public class CharacterFortifyWarehouseResponse : BasePacket
	{
		public List<CharacterModel> characters { get; set; }
		public List<string> finishedMissionCds { get; set; }
		public bool isGreatSuccess { get; set; }
		public List<ItemModel> items { get; set; }
		public List<MissionModel> missions { get; set; }
		public List<WarehouseCharacterModel> updateWarehouseCharacters { get; set; }
		public List<WarehouseMaterialModel> updateWarehouseMaterials { get; set; }
	}

	public class CharacterGetMasterAbilityDataResponse : BasePacket
	{
		public List<CharacterAbilityConditionModel> CharacterAbilityCondition { get; set; }
		public List<ExCharacterAbilityGroupModel> CharacterAbilityGroup { get; set; }
		public List<ExCharacterAbilityMainModel> CharacterAbilityMain { get; set; }
		public List<CharacterAbilityUpModel> CharacterAbilityUp { get; set; }
	}

	public class CharacterGetMasterAbilityEffectData2Response : BasePacket
	{
		public List<ExCharacterAbilityEffectModel> CharacterAbilityEffect2 { get; set; }
	}

	public class CharacterGetMasterAbilityEffectData3Response : BasePacket
	{
		public List<ExCharacterAbilityEffectModel> CharacterAbilityEffect3 { get; set; }
	}

	public class CharacterGetMasterAbilityEffectData4Response : BasePacket
	{
		public List<ExCharacterAbilityEffectModel> CharacterAbilityEffect4 { get; set; }
	}

	public class CharacterGetMasterAbilityEffectData5Response : BasePacket
	{
		public List<ExCharacterAbilityEffectModel> CharacterAbilityEffect5 { get; set; }
	}

	public class CharacterGetMasterAbilityEffectData6Response : BasePacket
	{
		public List<ExCharacterAbilityEffectModel> CharacterAbilityEffect6 { get; set; }
	}

	public class CharacterGetMasterAbilityEffectDataResponse : BasePacket
	{
		public List<ExCharacterAbilityEffectModel> CharacterAbilityEffect { get; set; }
	}

	public class CharacterGetMasterAwakeDataResponse : BasePacket
	{
		public List<ExCharacterAwakeConditionModel> CharacterAwakeCondition { get; set; }
		public List<ExCharacterAwakeEffectModel> CharacterAwakeEffect { get; set; }
		public List<ExCharacterAwakeGroupModel> CharacterAwakeGroup { get; set; }
		public List<ExCharacterAwakeMainModel> CharacterAwakeMain { get; set; }
		public List<ExCharacterAwakeMaterialModel> CharacterAwakeMaterial { get; set; }
	}

	public class CharacterGetMasterCharacterMainDataResponse : BasePacket
	{
		public List<CharacterAlterModel> CharacterAlter { get; set; }
		public List<ExCharacterMainModel> CharacterMain { get; set; }
		public List<CharacterStandPositionModel> CharacterStandPosition { get; set; }
	}

	public class CharacterGetMasterDataResponse : BasePacket
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

	public class CharacterGetMasterEvolutionDataResponse : BasePacket
	{
		public List<ExCharacterEvolutionEffectModel> CharacterEvolutionEffect { get; set; }
		public List<ExCharacterEvolutionMainModel> CharacterEvolutionMain { get; set; }
		public List<ExCharacterEvolutionMaterialModel> CharacterEvolutionMaterial { get; set; }
	}

	public class CharacterGetMasterSkillDataResponse : BasePacket
	{
		public List<ExCharacterSkillMainModel> CharacterSkillMain { get; set; }
		public List<CharacterSkillUpModel> CharacterSkillUp { get; set; }
		public List<CharacterSkillUpRateModel> CharacterSkillUpRate { get; set; }
	}

	public class CharacterGetMasterSkillEffectData2Response : BasePacket
	{
		public List<CharacterSkillEffectModel> CharacterSkillEffect2 { get; set; }
	}

	public class CharacterGetMasterSkillEffectDataResponse : BasePacket
	{
		public List<CharacterSkillEffectModel> CharacterSkillEffect { get; set; }
	}

	public class CharacterGetMasterTextData2Response : BasePacket
	{
		public List<CharacterTextModel> CharacterText2 { get; set; }
	}

	public class CharacterGetMasterTextData3Response : BasePacket
	{
		public List<CharacterTextModel> CharacterText3 { get; set; }
	}

	public class CharacterGetMasterTextData4Response : BasePacket
	{
		public List<CharacterTextModel> CharacterText4 { get; set; }
	}

	public class CharacterGetMasterTextData5Response : BasePacket
	{
		public List<CharacterTextModel> CharacterText5 { get; set; }
	}

	public class CharacterGetMasterTextDataResponse : BasePacket
	{
		public List<CharacterTextModel> CharacterText { get; set; }
	}

	public class CharacterGetUserDataResponse : BasePacket
	{
		public List<CharacterModel> characters { get; set; }
	}

	public class CharacterLinkGetMasterDataResponse : BasePacket
	{
		public List<CharacterLinkModel> CharacterLink { get; set; }
	}

	public class CharacterLinkGetUserDataResponse : BasePacket
	{
		public List<CharacterLinkUnitModel> characterLinks { get; set; }
	}

	public class CharacterSellResponse : BasePacket
	{
		public List<CharacterModel> characters { get; set; }
		public List<ItemModel> items { get; set; }
	}

	public class CharacterSellWarehouseResponse : BasePacket
	{
		public List<ItemModel> items { get; set; }
		public List<WarehouseCharacterModel> updateWarehouseCharacters { get; set; }
		public List<WarehouseMaterialModel> updateWarehouseMaterials { get; set; }
	}

	public class ComebackGetMasterDataResponse : BasePacket
	{
		public List<ComebackGachaModel> ComebackGacha { get; set; }
		public List<ComebackGroupModel> ComebackGroup { get; set; }
		public List<ComebackLoginBonusModel> ComebackLoginBonus { get; set; }
		public List<ComebackMainModel> ComebackMain { get; set; }
		public List<ComebackNewsModel> ComebackNews { get; set; }
		public List<ComebackPopupModel> ComebackPopup { get; set; }
		public List<ComebackShopModel> ComebackShop { get; set; }
	}

	public class DeckGetUserDataResponse : BasePacket
	{
		public List<DeckModel> decks { get; set; }
		public List<MemorialDeckModel> memorialDecks { get; set; }
	}

	public class DeckUpdateResponse : BasePacket
	{
		public List<DeckModel> decks { get; set; }
		public List<MemorialDeckModel> memorialDecks { get; set; }
	}

	public class EquipmentBulkFullFortifyResponse : BasePacket
	{
		public List<SolidEquipmentModel> addSolidEquipments { get; set; }
		public List<EquipmentModel> equipments { get; set; }
		public List<LinearMissionModel> finishedLinearMissions { get; set; }
		public List<string> finishedMissionCds { get; set; }
		public List<ItemModel> items { get; set; }
		public List<LinearMissionModel> linearMissions { get; set; }
		public List<MissionModel> missions { get; set; }
		public List<CharacterModel> updateCharacters { get; set; }
		public List<SolidEquipmentModel> updateSolidEquipments { get; set; }
		public List<WarehouseEquipmentModel> updateWarehouseEquipments { get; set; }
		public List<WarehouseMaterialModel> updateWarehouseMaterials { get; set; }
	}

	public class EquipmentExceedLimitWarehouseResponse : BasePacket
	{
		public List<EquipmentModel> equipments { get; set; }
		public List<LinearMissionModel> finishedLinearMissions { get; set; }
		public List<string> finishedMissionCds { get; set; }
		public List<ItemModel> items { get; set; }
		public List<LinearMissionModel> linearMissions { get; set; }
		public List<MissionModel> missions { get; set; }
		public List<WarehouseEquipmentModel> updateWarehouseEquipments { get; set; }
		public List<WarehouseMaterialModel> updateWarehouseMaterials { get; set; }
	}

	public class EquipmentFortifyWarehouseResponse : BasePacket
	{
		public List<EquipmentModel> equipments { get; set; }
		public List<string> finishedMissionCds { get; set; }
		public bool isGreatSuccess { get; set; }
		public List<ItemModel> items { get; set; }
		public List<MissionModel> missions { get; set; }
		public List<WarehouseEquipmentModel> updateWarehouseEquipments { get; set; }
		public List<WarehouseMaterialModel> updateWarehouseMaterials { get; set; }
	}

	public class EquipmentGetMasterDataResponse : BasePacket
	{
		public List<EquipmentAbilityConditionModel> EquipmentAbilityCondition { get; set; }
		public List<EquipmentExceedLimitModel> EquipmentExceedLimit { get; set; }
		public List<EquipmentExceedLimitItemModel> EquipmentExceedLimitItem { get; set; }
		public List<EquipmentLevelModel> EquipmentLevel { get; set; }
		public List<ExEquipmentMainModel> EquipmentMain { get; set; }
		public List<EquipmentMaterialModel> EquipmentMaterial { get; set; }
		public List<EquipmentTimeModel> EquipmentTime { get; set; }
	}

	public class EquipmentGetMasterEquipmentEffectData2Response : BasePacket
	{
		public List<EquipmentEffectModel> EquipmentEffect2 { get; set; }
	}

	public class EquipmentGetMasterEquipmentEffectDataResponse : BasePacket
	{
		public List<EquipmentEffectModel> EquipmentEffect { get; set; }
	}

	public class EquipmentGetUserDataResponse : BasePacket
	{
		public List<CharacterModel> addCharacters { get; set; }
		public List<DeckModel> decks { get; set; }
		public List<EquipmentModel> equipments { get; set; }
		public List<CharacterModel> updateCharacters { get; set; }
	}

	public class EquipmentSellWarehouseResponse : BasePacket
	{
		public List<ItemModel> items { get; set; }
		public List<WarehouseEquipmentModel> updateWarehouseEquipments { get; set; }
		public List<WarehouseMaterialModel> updateWarehouseMaterials { get; set; }
	}

	public class EventEndBattleResponse : BasePacket
	{
		public List<dynamic> achieveRewards { get; set; }
		public List<int> addCharacterExps { get; set; }
		public List<UserEventFriendshipItemModel> addEventFriendshipItems { get; set; }
		public List<UserEventItemModel> addEventPointItems { get; set; }
		public List<int> addGolds { get; set; }
		public int addUserExp { get; set; }
		public List<int> addUserExps { get; set; }
		public int addUserLevel { get; set; }
		public List<WarehouseCharacterModel> addWarehouseCharacters { get; set; }
		public List<WarehouseEquipmentModel> addWarehouseEquipments { get; set; }
		public List<WarehouseMaterialModel> addWarehouseMaterials { get; set; }
		public List<UserBoostModel> boosts { get; set; }
		public List<CharacterModel> characters { get; set; }
		public int convertGolds { get; set; }
		public List<List<dynamic>> dropItems { get; set; }
		public List<EquipmentModel> equipments { get; set; }
		public List<UserEventFriendshipItemModel> eventFriendshipItems { get; set; }
		public List<UserEventItemModel> eventItems { get; set; }
		public List<LinearMissionModel> finishedLinearMissions { get; set; }
		public List<string> finishedMissionCds { get; set; }
		public List<ItemModel> items { get; set; }
		public List<LinearMissionModel> linearMissions { get; set; }
		public List<MissionModel> missions { get; set; }
		public List<PictureBookDetailModel> pictureBookDetail { get; set; }
		public List<QuestModel> quests { get; set; }
		public List<StoryModel> stories { get; set; }
		public List<WarehouseCharacterModel> updateWarehouseCharacters { get; set; }
		public List<WarehouseEquipmentModel> updateWarehouseEquipments { get; set; }
		public List<WarehouseMaterialModel> updateWarehouseMaterials { get; set; }
		public UserBasicInfoModel user { get; set; }
	}

	public class EventGetMasterDataResponse : BasePacket
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

	public class EventGetUserDataResponse : BasePacket
	{
		public List<UserEventFriendshipItemModel> eventFriendshipItems { get; set; }
		public List<UserEventItemModel> eventItems { get; set; }
	}

	public class EventSkipBattleResponse : BasePacket
	{
		public List<int> addCharacterExps { get; set; }
		public List<UserEventFriendshipItemModel> addEventFriendshipItems { get; set; }
		public List<List<dynamic>> addEventPointItems { get; set; }
		public List<int> addGolds { get; set; }
		public int addUserExp { get; set; }
		public List<int> addUserExps { get; set; }
		public int addUserLevel { get; set; }
		public List<WarehouseCharacterModel> addWarehouseCharacters { get; set; }
		public List<WarehouseEquipmentModel> addWarehouseEquipments { get; set; }
		public List<WarehouseMaterialModel> addWarehouseMaterials { get; set; }
		public List<UserBoostModel> boosts { get; set; }
		public List<CharacterModel> characters { get; set; }
		public int convertGolds { get; set; }
		public List<List<dynamic>> dropItems { get; set; }
		public List<EquipmentModel> equipments { get; set; }
		public List<UserEventFriendshipItemModel> eventFriendshipItems { get; set; }
		public List<UserEventItemModel> eventItems { get; set; }
		public List<LinearMissionModel> finishedLinearMissions { get; set; }
		public List<string> finishedMissionCds { get; set; }
		public List<ItemModel> items { get; set; }
		public List<LinearMissionModel> linearMissions { get; set; }
		public List<MissionModel> missions { get; set; }
		public List<PictureBookDetailModel> pictureBookDetail { get; set; }
		public List<QuestModel> quests { get; set; }
		public List<StoryModel> stories { get; set; }
		public List<WarehouseCharacterModel> updateWarehouseCharacters { get; set; }
		public List<WarehouseEquipmentModel> updateWarehouseEquipments { get; set; }
		public List<WarehouseMaterialModel> updateWarehouseMaterials { get; set; }
		public UserBasicInfoModel user { get; set; }
	}

	public class EventStartBattleResponse : BasePacket
	{
		public List<string> finishedMissionCds { get; set; }
		public SessionDynamicModel session { get; set; }
		public string stage { get; set; }
		public List<StoryModel> stories { get; set; }
		public UserBasicInfoModel user { get; set; }
	}

	public class GachaGetDetailResponse : BasePacket
	{
		public string caution { get; set; }
		public CharacterTextModel description { get; set; }
		public int gachaId { get; set; }
		public List<OddsDynamicModel> odds { get; set; }
		public List<List<dynamic>> presents { get; set; }
		public SelectPickInfoDynamicModel selectPickInfo { get; set; }
	}

	public class GachaGetListResponse : BasePacket
	{
		public List<UserGachaModel> gacha { get; set; }
	}

	public class GachaGetStepUpGroupResponse : BasePacket
	{
		public List<List<dynamic>> odds { get; set; }
	}

	public class GachaGetUserDataResponse : BasePacket
	{
		public List<UserGachaModel> gacha { get; set; }
	}

	public class GachaPlayResponse : BasePacket
	{
		public List<CharacterModel> addCharacters { get; set; }
		public List<EquipmentModel> addEquipments { get; set; }
		public List<MemorialModel> addMemorials { get; set; }
		public List<AddPresentsDynamicModel> addPresents { get; set; }
		public List<UserBoostModel> boosts { get; set; }
		public ButtonDynamicModel button { get; set; }
		public List<CharacterSellBonusModel> cards { get; set; }
		public List<CharacterLinkUnitModel> characterLinks { get; set; }
		public List<string> finishedMissionCds { get; set; }
		public UserGemModel gem { get; set; }
		public List<UserCharacterModel> getCharacters { get; set; }
		public List<EquipmentModel> getEquipments { get; set; }
		public bool isCanReplay { get; set; }
		public List<ItemModel> items { get; set; }
		public List<MissionModel> missions { get; set; }
		public List<PictureBookDetailModel> pictureBookDetail { get; set; }
		public List<CharacterSellBonusModel> preConvert { get; set; }
		public int remainReplayCount { get; set; }
		public UserBasicInfoModel user { get; set; }
	}

	public class ItemGetMasterDataResponse : BasePacket
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

	public class ItemGetMasterItemSetData2Response : BasePacket
	{
		public List<ItemSetModel> ItemSet2 { get; set; }
	}

	public class ItemGetMasterItemSetDataResponse : BasePacket
	{
		public List<ItemSetModel> ItemSet { get; set; }
	}

	public class ItemGetUserDataResponse : BasePacket
	{
		public List<ItemModel> items { get; set; }
	}

	public class ItemSellResponse : BasePacket
	{
		public List<ItemModel> items { get; set; }
	}

	public class ItemUseRecoveryItemResponse : BasePacket
	{
		public List<ItemModel> items { get; set; }
		public UserBasicInfoModel user { get; set; }
	}

	public class ItemUseResponse : BasePacket
	{
		public List<UserBoostModel> boosts { get; set; }
		public List<CharacterModel> characters { get; set; }
		public List<EquipmentModel> equipments { get; set; }
		public List<ItemModel> items { get; set; }
		public List<QuestModel> quests { get; set; }
		public List<dynamic> rewards { get; set; }
		public List<StoryModel> stories { get; set; }
		public UserBasicInfoModel user { get; set; }
	}

	public class LinearMissionGetMasterDataResponse : BasePacket
	{
		public List<ExLinearMissionDetailModel> LinearMissionDetail { get; set; }
		public List<ExLinearMissionMainModel> LinearMissionMain { get; set; }
		public List<ExLinearMissionRewardModel> LinearMissionReward { get; set; }
	}

	public class LinearMissionGetUserDataResponse : BasePacket
	{
		public List<LinearMissionModel> linearMissions { get; set; }
	}

	public class LoginBonusGetLoginBonusResponse : BasePacket
	{
		public List<LoginBonusModel> loginBonus { get; set; }
		public int result { get; set; }
	}

	public class LoginBonusGetMasterDataResponse : BasePacket
	{
		public List<LoginBonusModel> LoginBonusMain { get; set; }
		public List<LoginRewardModel> LoginBonusReward { get; set; }
	}

	public class LoginPackGetLoginPackResponse : BasePacket
	{
		public int result { get; set; }
	}

	public class LoginPackGetMasterDataResponse : BasePacket
	{
		public List<LoginPackMainModel> LoginPackMain { get; set; }
		public List<LoginPackRewardModel> LoginPackReward { get; set; }
	}

	public class LoginPackGetUserDataResponse : BasePacket
	{
		public List<UserLoginPackModel> loginPacks { get; set; }
	}

	public class LotteryGetUserDataResponse : BasePacket
	{
		public List<LotteryModel> lotteries { get; set; }
	}

	public class MemorialExceedLimitResponse : BasePacket
	{
		public List<string> finishedMissionCds { get; set; }
		public List<ItemModel> items { get; set; }
		public List<MemorialModel> memorials { get; set; }
		public List<MissionModel> missions { get; set; }
	}

	public class MemorialFortifyResponse : BasePacket
	{
		public List<string> finishedMissionCds { get; set; }
		public List<ItemModel> items { get; set; }
		public List<MemorialModel> memorials { get; set; }
		public List<MissionModel> missions { get; set; }
	}

	public class MemorialGetMasterDataResponse : BasePacket
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

	public class MemorialGetUserDataResponse : BasePacket
	{
		public List<MemorialModel> memorials { get; set; }
	}

	public class MemorialReleaseStoryResponse : BasePacket
	{
		public List<StoryModel> stories { get; set; }
	}

	public class MinigameGetListResponse : BasePacket
	{
		public List<MinigameMainModel> minigameData { get; set; }
	}

	public class MinigameGetMasterDataResponse : BasePacket
	{
		public List<MinigameCharacterMainModel> MinigameCharacterMain { get; set; }
		public List<MinigameCharacterTextModel> MinigameCharacterText { get; set; }
	}

	public class MinigameGetUserDataResponse : BasePacket
	{
		public UserMinigameModel minigame { get; set; }
	}

	public class MinigamePlayResponse : BasePacket
	{
		public UserMinigameModel minigame { get; set; }
		public int rivalLane { get; set; }
		public int winLane { get; set; }
	}

	public class MissionGetMasterDataResponse : BasePacket
	{
		public List<ExMissionMainModel> MissionMain { get; set; }
		public List<MissionRewardModel> MissionReward { get; set; }
		public List<ExUniqueMissionModel> UniqueMission { get; set; }
	}

	public class MissionGetMasterMissionDetailData2Response : BasePacket
	{
		public List<MissionDetailModel> MissionDetail2 { get; set; }
	}

	public class MissionGetMasterMissionDetailData3Response : BasePacket
	{
		public List<MissionDetailModel> MissionDetail3 { get; set; }
	}

	public class MissionGetMasterMissionDetailData4Response : BasePacket
	{
		public List<MissionDetailModel> MissionDetail4 { get; set; }
	}

	public class MissionGetMasterMissionDetailDataResponse : BasePacket
	{
		public List<MissionDetailModel> MissionDetail { get; set; }
	}

	public class MissionGetUserDataResponse : BasePacket
	{
		public List<MissionModel> missions { get; set; }
	}

	public class MissionReceiveResponse : BasePacket
	{
		public List<CharacterModel> addCharacters { get; set; }
		public List<EquipmentModel> addEquipments { get; set; }
		public List<dynamic> addLotteries { get; set; }
		public List<WarehouseCharacterModel> addWarehouseCharacters { get; set; }
		public List<WarehouseEquipmentModel> addWarehouseEquipments { get; set; }
		public List<WarehouseMaterialModel> addWarehouseMaterials { get; set; }
		public List<UserEventItemModel> eventItems { get; set; }
		public List<string> finishedMissionCds { get; set; }
		public List<FurnitureModel> furniture { get; set; }
		public UserGemModel gem { get; set; }
		public List<ItemModel> items { get; set; }
		public List<MissionModel> missions { get; set; }
		public List<dynamic> nonReceiveReasons { get; set; }
		public List<PictureBookDetailModel> pictureBookDetail { get; set; }
		public List<WarehouseCharacterModel> updateWarehouseCharacters { get; set; }
		public List<WarehouseEquipmentModel> updateWarehouseEquipments { get; set; }
		public List<WarehouseMaterialModel> updateWarehouseMaterials { get; set; }
		public UserBasicInfoModel user { get; set; }
	}

	public class MissionUpdateMissionProgressOnLoginResponse : BasePacket
	{
		public List<string> finishedMissionCds { get; set; }
		public List<MissionModel> missions { get; set; }
	}

	public class MyPageRefreshResponse : BasePacket
	{
		public List<UserNoticeModel> addNotices { get; set; }
		public string checkingPaymentResult { get; set; }
		public List<string> finishedMissionCds { get; set; }
		public bool isUpdateDate { get; set; }
		public List<MissionModel> missions { get; set; }
		public int presentCount { get; set; }
	}

	public class NoticeGetUserDataResponse : BasePacket
	{
		public List<UserNoticeModel> notices { get; set; }
	}

	public class PaymentGetMasterDataResponse : BasePacket
	{
		public List<DmmModel> Dmm { get; set; }
	}

	public class PictureBookGetUserDataResponse : BasePacket
	{
		public List<PictureBookBaseModel> pictureBookBase { get; set; }
		public List<PictureBookDetailModel> pictureBookDetail { get; set; }
	}

	public class PictureBookGiftResponse : BasePacket
	{
		public List<UserStoryModel> addStories { get; set; }
		public List<string> finishedMissionCds { get; set; }
		public List<ItemModel> items { get; set; }
		public List<MissionModel> missions { get; set; }
		public List<PictureBookDetailModel> pictureBookDetail { get; set; }
		public List<StoryModel> stories { get; set; }
	}

	public class PresentGetListResponse : BasePacket
	{
		public int maxCount { get; set; }
		public int presentCount { get; set; }
		public List<AddPresentsDynamicModel2> presents { get; set; }
	}

	public class PresentGetMasterDataResponse : BasePacket
	{
		public List<PresentMessageModel> PresentMessage { get; set; }
	}

	public class PresentReceiveResponse : BasePacket
	{
		public List<CharacterModel> addCharacters { get; set; }
		public List<EquipmentModel> addEquipments { get; set; }
		public List<dynamic> addLotteries { get; set; }
		public List<MemorialModel> addMemorials { get; set; }
		public List<WarehouseCharacterModel> addWarehouseCharacters { get; set; }
		public List<WarehouseEquipmentModel> addWarehouseEquipments { get; set; }
		public List<WarehouseMaterialModel> addWarehouseMaterials { get; set; }
		public List<CharacterLinkUnitModel> characterLinks { get; set; }
		public List<UserEventItemModel> eventItems { get; set; }
		public List<string> finishedMissionCds { get; set; }
		public List<FurnitureModel> furniture { get; set; }
		public UserGemModel gem { get; set; }
		public List<ItemModel> items { get; set; }
		public MemorialConvertInfoDynamicModel memorialConvertInfo { get; set; }
		public List<MissionModel> missions { get; set; }
		public List<dynamic> nonReceivePresents { get; set; }
		public List<dynamic> nonReceiveReasons { get; set; }
		public List<PictureBookDetailModel> pictureBookDetail { get; set; }
		public List<AddPresentsDynamicModel2> receivePresents { get; set; }
		public List<ItemSelectModel> receiveWarehouseCharacters { get; set; }
		public List<WarehouseEquipmentModel> receiveWarehouseEquipments { get; set; }
		public List<ItemSelectModel> receiveWarehouseMaterials { get; set; }
		public List<WarehouseCharacterModel> updateWarehouseCharacters { get; set; }
		public List<WarehouseEquipmentModel> updateWarehouseEquipments { get; set; }
		public List<WarehouseMaterialModel> updateWarehouseMaterials { get; set; }
		public UserBasicInfoModel user { get; set; }
	}

	public class PvpEndBattleResponse : BasePacket
	{
		public int addPoint { get; set; }
		public List<AddPresentsDynamicModel> addPresents { get; set; }
		public List<CharacterModel> characters { get; set; }
		public List<string> finishedMissionCds { get; set; }
		public List<ItemModel> items { get; set; }
		public List<MissionModel> missions { get; set; }
		public PvPModel pvp { get; set; }
	}

	public class PvpGetBattlePlayersResponse : BasePacket
	{
		public List<BattlePlayersDynamicModel> battlePlayers { get; set; }
		public bool isNewSeason { get; set; }
		public PvPModel pvp { get; set; }
	}

	public class PvpGetMasterDataResponse : BasePacket
	{
		public List<PvPClassModel> PvPClass { get; set; }
		public List<PvPClassRewardModel> PvPClassReward { get; set; }
		public List<PvPMainModel> PvPMain { get; set; }
	}

	public class PvpGetUserDataResponse : BasePacket
	{
		public PvPModel pvp { get; set; }
	}

	public class PvpStartBattleResponse : BasePacket
	{
		public string playerId { get; set; }
		public PvPModel pvp { get; set; }
		public string sessionId { get; set; }
	}

	public class PvpUpdateBattlePlayersResponse : BasePacket
	{
		public List<BattlePlayersDynamicModel> battlePlayers { get; set; }
		public bool isNewSeason { get; set; }
		public PvPModel pvp { get; set; }
	}

	public class QuestEndBattleResponse : BasePacket
	{
		public List<dynamic> achieveRewards { get; set; }
		public List<int> addCharacterExps { get; set; }
		public List<int> addGolds { get; set; }
		public int addUserExp { get; set; }
		public List<int> addUserExps { get; set; }
		public int addUserLevel { get; set; }
		public List<WarehouseCharacterModel> addWarehouseCharacters { get; set; }
		public List<WarehouseEquipmentModel> addWarehouseEquipments { get; set; }
		public List<WarehouseMaterialModel> addWarehouseMaterials { get; set; }
		public List<UserBoostModel> boosts { get; set; }
		public List<CharacterModel> characters { get; set; }
		public int convertGolds { get; set; }
		public List<List<dynamic>> dropItems { get; set; }
		public List<EquipmentModel> equipments { get; set; }
		public List<LinearMissionModel> finishedLinearMissions { get; set; }
		public List<string> finishedMissionCds { get; set; }
		public List<ItemModel> items { get; set; }
		public List<LinearMissionModel> linearMissions { get; set; }
		public List<MissionModel> missions { get; set; }
		public List<PictureBookDetailModel> pictureBookDetail { get; set; }
		public List<QuestModel> quests { get; set; }
		public List<StoryModel> stories { get; set; }
		public List<WarehouseCharacterModel> updateWarehouseCharacters { get; set; }
		public List<WarehouseEquipmentModel> updateWarehouseEquipments { get; set; }
		public List<WarehouseMaterialModel> updateWarehouseMaterials { get; set; }
		public UserBasicInfoModel user { get; set; }
	}

	public class QuestGetMasterDataResponse : BasePacket
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

	public class QuestGetMasterDropData2Response : BasePacket
	{
		public List<QuestDropModel> QuestDrop2 { get; set; }
	}

	public class QuestGetMasterDropData3Response : BasePacket
	{
		public List<QuestDropModel> QuestDrop3 { get; set; }
	}

	public class QuestGetMasterDropData4Response : BasePacket
	{
		public List<QuestDropModel> QuestDrop4 { get; set; }
	}

	public class QuestGetMasterDropData5Response : BasePacket
	{
		public List<QuestDropModel> QuestDrop5 { get; set; }
	}

	public class QuestGetMasterDropData6Response : BasePacket
	{
		public List<QuestDropModel> QuestDrop6 { get; set; }
	}

	public class QuestGetMasterDropDataResponse : BasePacket
	{
		public List<QuestDropModel> QuestDrop { get; set; }
	}

	public class QuestGetMasterEventPointDataResponse : BasePacket
	{
		public List<QuestEventPointModel> QuestEventPoint { get; set; }
	}

	public class QuestGetMasterStageData2Response : BasePacket
	{
		public List<ExQuestStageModel> QuestStage2 { get; set; }
	}

	public class QuestGetMasterStageData3Response : BasePacket
	{
		public List<ExQuestStageModel> QuestStage3 { get; set; }
	}

	public class QuestGetMasterStageDataResponse : BasePacket
	{
		public List<ExQuestStageModel> QuestStage { get; set; }
	}

	public class QuestGetStageDataResponse : BasePacket
	{
		public List<StageEnemiesDynamicModel> stageEnemies { get; set; }
		public int wave { get; set; }
	}

	public class QuestGetUserDataResponse : BasePacket
	{
		public List<QuestModel> quests { get; set; }
	}

	public class QuestSkipBattleResponse : BasePacket
	{
		public List<int> addCharacterExps { get; set; }
		public List<int> addGolds { get; set; }
		public int addUserExp { get; set; }
		public List<int> addUserExps { get; set; }
		public int addUserLevel { get; set; }
		public List<WarehouseCharacterModel> addWarehouseCharacters { get; set; }
		public List<WarehouseEquipmentModel> addWarehouseEquipments { get; set; }
		public List<WarehouseMaterialModel> addWarehouseMaterials { get; set; }
		public List<UserBoostModel> boosts { get; set; }
		public List<CharacterModel> characters { get; set; }
		public int convertGolds { get; set; }
		public List<List<dynamic>> dropItems { get; set; }
		public List<EquipmentModel> equipments { get; set; }
		public List<LinearMissionModel> finishedLinearMissions { get; set; }
		public List<string> finishedMissionCds { get; set; }
		public List<ItemModel> items { get; set; }
		public List<LinearMissionModel> linearMissions { get; set; }
		public List<MissionModel> missions { get; set; }
		public List<PictureBookDetailModel> pictureBookDetail { get; set; }
		public List<QuestModel> quests { get; set; }
		public List<StoryModel> stories { get; set; }
		public List<WarehouseCharacterModel> updateWarehouseCharacters { get; set; }
		public List<WarehouseEquipmentModel> updateWarehouseEquipments { get; set; }
		public List<WarehouseMaterialModel> updateWarehouseMaterials { get; set; }
		public UserBasicInfoModel user { get; set; }
	}

	public class QuestStartBattleResponse : BasePacket
	{
		public SessionDynamicModel session { get; set; }
		public string stage { get; set; }
		public List<StoryModel> stories { get; set; }
		public UserBasicInfoModel user { get; set; }
	}

	public class QuestUnlockQuestResponse : BasePacket
	{
		public List<UserBoostModel> boosts { get; set; }
		public List<string> finishedMissionCds { get; set; }
		public List<ItemModel> items { get; set; }
		public List<MissionModel> missions { get; set; }
		public UserBasicInfoModel user { get; set; }
	}

	public class QuestionnaireGetQuestionnaireListResponse : BasePacket
	{
		public List<dynamic> questionnaire { get; set; }
	}

	public class RaceEndRaceResponse : BasePacket
	{
		public List<AddPresentsDynamicModel2> addPresents { get; set; }
		public RaceSessionModel raceSession { get; set; }
		public List<RaceCharacterModel> updateRaceCharacters { get; set; }
	}

	public class RaceFortifyCharacterResponse : BasePacket
	{
		public List<ItemModel> items { get; set; }
		public List<RaceCharacterModel> updateRaceCharacters { get; set; }
	}

	public class RaceGetMasterDataResponse : BasePacket
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

	public class RaceGetUserDataResponse : BasePacket
	{
		public List<RaceCharacterModel> raceCharacters { get; set; }
		public RaceSessionModel raceSession { get; set; }
	}

	public class RaceStartRaceResponse : BasePacket
	{
		public RaceSessionModel raceSession { get; set; }
		public List<RaceCharacterModel> updateRaceCharacters { get; set; }
	}

	public class RaceUpdateSeasonResponse : BasePacket
	{
		public List<RaceCharacterModel> addRaceCharacters { get; set; }
		public RaceSessionModel raceSession { get; set; }
		public List<RaceCharacterModel> updateRaceCharacters { get; set; }
	}

	public class RaidGetMasterDataResponse : BasePacket
	{
		public List<RaidBattleModel> RaidBattle { get; set; }
		public List<RaidBattleTypeModel> RaidBattleType { get; set; }
		public List<RaidRewardModel> RaidReward { get; set; }
		public List<RaidRewardGroupModel> RaidRewardGroup { get; set; }
	}

	public class RoomBuyFurnitureResponse : BasePacket
	{
		public List<string> finishedMissionCds { get; set; }
		public List<FurnitureModel> furniture { get; set; }
		public List<ItemModel> items { get; set; }
		public List<MissionModel> missions { get; set; }
	}

	public class RoomCollectAllResponse : BasePacket
	{
		public List<string> finishedMissionCds { get; set; }
		public List<FurnitureRewardsDynamicModel> furnitureRewards { get; set; }
		public List<ItemModel> items { get; set; }
		public List<MissionModel> missions { get; set; }
		public List<dynamic> nonCollectRewards { get; set; }
		public RoomModel room { get; set; }
		public UserBasicInfoModel user { get; set; }
	}

	public class RoomGetMasterDataResponse : BasePacket
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

	public class RoomGetUserDataResponse : BasePacket
	{
		public List<FurnitureModel> furniture { get; set; }
		public RoomModel room { get; set; }
		public List<UserRoomLayoutModel> roomLayouts { get; set; }
	}

	public class RoomResetAllFurnitureResponse : BasePacket
	{
		public RoomModel room { get; set; }
	}

	public class RoomSaveSelectCharacterResponse : BasePacket
	{
		public List<PictureBookBaseModel> pictureBookBase { get; set; }
	}

	public class RoomSetFurnitureResponse : BasePacket
	{
		public RoomModel room { get; set; }
	}

	public class ShopExchangeResponse : BasePacket
	{
		public List<InitItemModel> addRewards { get; set; }
		public List<UserBoostModel> boosts { get; set; }
		public List<UserExchangeHistoryModel> exchangeHistories { get; set; }
		public UserGemModel gem { get; set; }
		public bool isReceivedBonus { get; set; }
		public List<ItemModel> items { get; set; }
		public UserBasicInfoModel user { get; set; }
	}

	public class ShopGetMasterDataResponse : BasePacket
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

	public class ShopGetMasterExchangeItemDetailData2Response : BasePacket
	{
		public List<ExExchangeItemDetailModel> ExchangeItemDetail2 { get; set; }
	}

	public class ShopGetMasterExchangeItemDetailDataResponse : BasePacket
	{
		public List<ExExchangeItemDetailModel> ExchangeItemDetail { get; set; }
	}

	public class ShopGetMasterExchangePointDetailDataResponse : BasePacket
	{
		public List<ExExchangePointDetailModel> ExchangePointDetail { get; set; }
	}

	public class ShopGetOrderPackResponse : BasePacket
	{
		public List<OrderPackModel> orderPacks { get; set; }
	}

	public class ShopGetUserDataResponse : BasePacket
	{
		public List<UserExchangeHistoryModel> exchangeHistories { get; set; }
		public List<UserPurchaseHistoryModel> purchaseHistories { get; set; }
	}

	public class ShopPurchaseResponse : BasePacket
	{
		public List<RaceCharacterModel> addRaceCharacters { get; set; }
		public List<SoundModel> addSounds { get; set; }
		public List<string> finishedMissionCds { get; set; }
		public UserGemModel gem { get; set; }
		public List<UserLoginPackModel> loginPacks { get; set; }
		public List<MissionModel> missions { get; set; }
		public List<OrderPackModel> orderPacks { get; set; }
		public List<UserPurchaseHistoryModel> purchaseHistories { get; set; }
		public UserBasicInfoModel user { get; set; }
	}

	public class SolidEquipmentGetUserDataResponse : BasePacket
	{
		public List<SolidEquipmentModel> solidEquipments { get; set; }
	}

	public class SoundGetMasterDataResponse : BasePacket
	{
		public List<ExSoundMainModel> SoundMain { get; set; }
	}

	public class SoundGetUserDataResponse : BasePacket
	{
		public List<SoundModel> sounds { get; set; }
	}

	public class StoryAddStoryResponse : BasePacket
	{
		public List<StoryModel> stories { get; set; }
	}

	public class StoryGetMasterDataResponse : BasePacket
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

	public class StoryGetResourceResponse : BasePacket
	{
		public int adult { get; set; }
		public List<ResourceDynamicModel> resource { get; set; }
		public List<int> storyIds { get; set; }
	}

	public class StoryGetUserDataResponse : BasePacket
	{
		public List<StoryModel> stories { get; set; }
	}

	public class StoryReadStoryResponse : BasePacket
	{
		public int addFreeGems { get; set; }
		public UserGemModel gem { get; set; }
		public List<StoryModel> stories { get; set; }
	}

	public class TowerEndBattleResponse : BasePacket
	{
		public List<dynamic> achieveRewards { get; set; }
		public List<int> addCharacterExps { get; set; }
		public List<int> addGolds { get; set; }
		public int addUserExp { get; set; }
		public List<int> addUserExps { get; set; }
		public int addUserLevel { get; set; }
		public List<WarehouseCharacterModel> addWarehouseCharacters { get; set; }
		public List<WarehouseEquipmentModel> addWarehouseEquipments { get; set; }
		public List<WarehouseMaterialModel> addWarehouseMaterials { get; set; }
		public List<UserBoostModel> boosts { get; set; }
		public List<CharacterModel> characters { get; set; }
		public int convertGolds { get; set; }
		public List<List<dynamic>> dropItems { get; set; }
		public List<EquipmentModel> equipments { get; set; }
		public List<LinearMissionModel> finishedLinearMissions { get; set; }
		public List<string> finishedMissionCds { get; set; }
		public bool isTowerClear { get; set; }
		public List<ItemModel> items { get; set; }
		public List<LinearMissionModel> linearMissions { get; set; }
		public List<MissionModel> missions { get; set; }
		public List<PictureBookDetailModel> pictureBookDetail { get; set; }
		public List<QuestModel> quests { get; set; }
		public List<StoryModel> stories { get; set; }
		public List<TowerCharacterStatusDynamicModel> towerCharacterStatus { get; set; }
		public TowerSessionModel towerSession { get; set; }
		public List<WarehouseCharacterModel> updateWarehouseCharacters { get; set; }
		public List<WarehouseEquipmentModel> updateWarehouseEquipments { get; set; }
		public List<WarehouseMaterialModel> updateWarehouseMaterials { get; set; }
		public UserBasicInfoModel user { get; set; }
	}

	public class TowerGetAreaDataResponse : BasePacket
	{
		public string area { get; set; }
		public List<TowerCharacterStatusDynamicModel> towerCharacterStatus { get; set; }
	}

	public class TowerGetMasterDataResponse : BasePacket
	{
		public List<TowerMainModel> TowerMain { get; set; }
		public List<TowerRewardModel> TowerReward { get; set; }
		public List<TowerRewardGroupModel> TowerRewardGroup { get; set; }
	}

	public class TowerGetUserDataResponse : BasePacket
	{
		public TowerSessionModel towerSession { get; set; }
	}

	public class TowerSelectResponse : BasePacket
	{
		public List<string> finishedMissionCds { get; set; }
		public List<MissionModel> missions { get; set; }
		public TowerSessionModel towerSession { get; set; }
		public UserBasicInfoModel user { get; set; }
	}

	public class TowerStartBattleResponse : BasePacket
	{
		public string stage { get; set; }
		public TowerSessionModel towerSession { get; set; }
	}

	public class TutorialGetMasterDataResponse : BasePacket
	{
		public List<TutorialEventModel> TutorialEvent { get; set; }
		public List<TutorialMainStepModel> TutorialMainStep { get; set; }
		public List<TutorialSkipModel> TutorialSkip { get; set; }
		public List<TutorialSubStepModel> TutorialSubStep { get; set; }
	}

	public class UserGetMasterDataResponse : BasePacket
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

	public class UserGetMasterMyPageNewsData2Response : BasePacket
	{
		public List<ExMyPageNewsModel> MyPageNews2 { get; set; }
	}

	public class UserGetMasterMyPageNewsDataResponse : BasePacket
	{
		public List<ExMyPageNewsModel> MyPageNews { get; set; }
	}

	public class UserGetUserDataResponse : BasePacket
	{
		public UserGemModel gem { get; set; }
		public UserBasicInfoModel user { get; set; }
	}

	public class UserGetUserProfileDataResponse : BasePacket
	{
		public int questCount { get; set; }
	}

	public class UserLoginResponse : BasePacket
	{
		public List<UserBoostModel> boosts { get; set; }
		public List<UserComebackModel> comebacks { get; set; }
		public List<string> finishedMissionCds { get; set; }
		public UserGemModel gem { get; set; }
		public bool isUserWarning { get; set; }
		public UserPrefModel pref { get; set; }
		public string resourceKey { get; set; }
		public RoomModel room { get; set; }
		public List<StoryModel> stories { get; set; }
		public UserBasicInfoModel user { get; set; }
		public string version { get; set; }
	}

	public class UserUpdateUserPrefsResponse : BasePacket
	{
		public UserPrefModel pref { get; set; }
	}

	public class VersionGetMd5DataResponse : BasePacket
	{
		public string getMasterBoostData { get; set; }
		public string getMasterCabinMissionData { get; set; }
		public string getMasterCampaignData { get; set; }
		public string getMasterCharacterAbilityData { get; set; }
		public string getMasterCharacterAbilityEffectData { get; set; }
		public string getMasterCharacterAbilityEffectData2 { get; set; }
		public string getMasterCharacterAbilityEffectData3 { get; set; }
		public string getMasterCharacterAbilityEffectData4 { get; set; }
		public string getMasterCharacterAbilityEffectData5 { get; set; }
		public string getMasterCharacterAbilityEffectData6 { get; set; }
		public string getMasterCharacterAwakeData { get; set; }
		public string getMasterCharacterData { get; set; }
		public string getMasterCharacterEvolutionData { get; set; }
		public string getMasterCharacterLinkData { get; set; }
		public string getMasterCharacterMainData { get; set; }
		public string getMasterCharacterSkillData { get; set; }
		public string getMasterCharacterSkillEffectData { get; set; }
		public string getMasterCharacterSkillEffectData2 { get; set; }
		public string getMasterCharacterTextData { get; set; }
		public string getMasterCharacterTextData2 { get; set; }
		public string getMasterCharacterTextData3 { get; set; }
		public string getMasterCharacterTextData4 { get; set; }
		public string getMasterCharacterTextData5 { get; set; }
		public string getMasterComebackData { get; set; }
		public string getMasterEquipmentData { get; set; }
		public string getMasterEquipmentEffectData { get; set; }
		public string getMasterEquipmentEffectData2 { get; set; }
		public string getMasterEventData { get; set; }
		public string getMasterExchangeItemDetailData { get; set; }
		public string getMasterExchangeItemDetailData2 { get; set; }
		public string getMasterExchangePointDetailData { get; set; }
		public string getMasterItemData { get; set; }
		public string getMasterItemSetData { get; set; }
		public string getMasterItemSetData2 { get; set; }
		public string getMasterLinearMissionData { get; set; }
		public string getMasterLoginBonusData { get; set; }
		public string getMasterLoginPackData { get; set; }
		public string getMasterMemorialData { get; set; }
		public string getMasterMinigameData { get; set; }
		public string getMasterMissionData { get; set; }
		public string getMasterMissionDetailData { get; set; }
		public string getMasterMissionDetailData2 { get; set; }
		public string getMasterMissionDetailData3 { get; set; }
		public string getMasterMissionDetailData4 { get; set; }
		public string getMasterMyPageNewsData { get; set; }
		public string getMasterMyPageNewsData2 { get; set; }
		public string getMasterPresentData { get; set; }
		public string getMasterPvPData { get; set; }
		public string getMasterQuestData { get; set; }
		public string getMasterQuestDropData { get; set; }
		public string getMasterQuestDropData2 { get; set; }
		public string getMasterQuestDropData3 { get; set; }
		public string getMasterQuestDropData4 { get; set; }
		public string getMasterQuestDropData5 { get; set; }
		public string getMasterQuestDropData6 { get; set; }
		public string getMasterQuestEventPointData { get; set; }
		public string getMasterQuestStageData { get; set; }
		public string getMasterQuestStageData2 { get; set; }
		public string getMasterQuestStageData3 { get; set; }
		public string getMasterRaceData { get; set; }
		public string getMasterRaidData { get; set; }
		public string getMasterRoomData { get; set; }
		public string getMasterShopData { get; set; }
		public string getMasterSoundData { get; set; }
		public string getMasterStoryData { get; set; }
		public string getMasterTowerData { get; set; }
		public string getMasterTutorialData { get; set; }
		public string getMasterUserData { get; set; }
		[JsonProperty("payment/getMasterData")]
		public string payment_getMasterData { get; set; }
	}

	public class WarehouseBringWarehouseResponse : BasePacket
	{
		public List<WarehouseCharacterModel> addWarehouseCharacters { get; set; }
		public List<WarehouseMaterialModel> addWarehouseMaterials { get; set; }
		public List<CharacterModel> characters { get; set; }
		public List<WarehouseCharacterModel> updateWarehouseCharacters { get; set; }
		public List<WarehouseMaterialModel> updateWarehouseMaterials { get; set; }
	}

	public class WarehouseGetCharacterCountResponse : BasePacket
	{
		public int maxCount { get; set; }
		public int splitCount { get; set; }
	}

	public class WarehouseGetCharacterListResponse : BasePacket
	{
		public List<WarehouseCharacterModel> addWarehouseCharacters { get; set; }
	}

	public class WarehouseGetEquipmentCountResponse : BasePacket
	{
		public int maxCount { get; set; }
		public int splitCount { get; set; }
	}

	public class WarehouseGetEquipmentListResponse : BasePacket
	{
		public List<WarehouseEquipmentModel> addWarehouseEquipments { get; set; }
	}

	public class WarehouseGetMaterialCountResponse : BasePacket
	{
		public int maxCount { get; set; }
		public int splitCount { get; set; }
	}

	public class WarehouseGetMaterialListResponse : BasePacket
	{
		public List<WarehouseMaterialModel> addWarehouseMaterials { get; set; }
	}

	public class WarehouseTakeWarehouseResponse : BasePacket
	{
		public List<CharacterModel> addCharacters { get; set; }
		public List<EquipmentModel> addEquipments { get; set; }
		public List<CharacterLinkUnitModel> characterLinks { get; set; }
		public List<WarehouseCharacterModel> updateWarehouseCharacters { get; set; }
		public List<WarehouseEquipmentModel> updateWarehouseEquipments { get; set; }
		public List<WarehouseMaterialModel> updateWarehouseMaterials { get; set; }
	}

}

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
		[JsonProperty("dmmId")]
		public string DmmId { get; set; }
		[JsonProperty("expires")]
		public int Expires { get; set; }
		[JsonProperty("secret")]
		public string Secret { get; set; }
		[JsonProperty("token")]
		public string Token { get; set; }
		[JsonProperty("userId")]
		public string UserId { get; set; }
	}

	public class BoostGetMasterDataResponse : BasePacket
	{
		public List<BoostGroupModel> BoostGroup { get; set; }
		public List<BoostUnitGroupDynamicModel> BoostUnitGroup { get; set; }
	}

	public class BoxGachaGetBoxDetailResponse : BasePacket
	{
		[JsonProperty("allLineups")]
		public Dictionary<string, Dictionary<string, AllLineupsDynamicModel>> AllLineups { get; set; }
		[JsonProperty("boxLineups")]
		public List<BoxLineupsDynamicModel> BoxLineups { get; set; }
		[JsonProperty("buttons")]
		public List<ButtonsDynamicModel> Buttons { get; set; }
		[JsonProperty("conditionFrom")]
		public int ConditionFrom { get; set; }
		[JsonProperty("conditionTo")]
		public int ConditionTo { get; set; }
		[JsonProperty("conditionType")]
		public int ConditionType { get; set; }
		[JsonProperty("description")]
		public CharacterTextModel Description { get; set; }
		[JsonProperty("fromDate")]
		public string FromDate { get; set; }
		[JsonProperty("gachaId")]
		public int GachaId { get; set; }
		[JsonProperty("isReset")]
		public bool IsReset { get; set; }
		[JsonProperty("resetCount")]
		public int ResetCount { get; set; }
		[JsonProperty("step")]
		public int Step { get; set; }
		[JsonProperty("toDate")]
		public string ToDate { get; set; }
		[JsonProperty("user")]
		public UserBasicInfoModel User { get; set; }
		[JsonProperty("weekType")]
		public string WeekType { get; set; }
	}

	public class CabinMissionGetMasterDataResponse : BasePacket
	{
		public List<CabinMissionDetailModel> CabinMissionDetail { get; set; }
		public List<CabinMissionMainModel> CabinMissionMain { get; set; }
		public List<CabinMissionRewardModel> CabinMissionReward { get; set; }
	}

	public class CabinMissionGetUserDataResponse : BasePacket
	{
		[JsonProperty("cabinMissions")]
		public List<CabinMissionModel> CabinMissions { get; set; }
	}

	public class CabinMissionReceiveResponse : BasePacket
	{
		[JsonProperty("cabinMissions")]
		public List<CabinMissionModel> CabinMissions { get; set; }
		[JsonProperty("stories")]
		public List<StoryModel> Stories { get; set; }
	}

	public class CampaignGetMasterDataResponse : BasePacket
	{
		public List<CampaignModel> Campaign { get; set; }
	}

	public class CharacterAwakeResponse : BasePacket
	{
		[JsonProperty("addEquipments")]
		public List<EquipmentModel> AddEquipments { get; set; }
		[JsonProperty("characters")]
		public List<CharacterModel> Characters { get; set; }
		[JsonProperty("items")]
		public List<ItemModel> Items { get; set; }
	}

	public class CharacterBulkFortifySkillWarehouseResponse : BasePacket
	{
		[JsonProperty("characters")]
		public List<CharacterModel> Characters { get; set; }
		[JsonProperty("finishedLinearMissions")]
		public List<LinearMissionModel> FinishedLinearMissions { get; set; }
		[JsonProperty("finishedMissionCds")]
		public List<string> FinishedMissionCds { get; set; }
		[JsonProperty("items")]
		public List<ItemModel> Items { get; set; }
		[JsonProperty("linearMissions")]
		public List<LinearMissionModel> LinearMissions { get; set; }
		[JsonProperty("missions")]
		public List<MissionModel> Missions { get; set; }
		[JsonProperty("tryCount")]
		public int TryCount { get; set; }
		[JsonProperty("updateWarehouseMaterials")]
		public List<WarehouseMaterialModel> UpdateWarehouseMaterials { get; set; }
	}

	public class CharacterChangePartnerResponse : BasePacket
	{
		[JsonProperty("user")]
		public UserBasicInfoModel User { get; set; }
	}

	public class CharacterChangeProtectResponse : BasePacket
	{
		[JsonProperty("updateCharacters")]
		public List<CharacterModel> UpdateCharacters { get; set; }
	}

	public class CharacterEquipResponse : BasePacket
	{
		[JsonProperty("characters")]
		public List<CharacterModel> Characters { get; set; }
	}

	public class CharacterExceedLimitByItemResponse : BasePacket
	{
		[JsonProperty("addStories")]
		public List<UserStoryModel> AddStories { get; set; }
		[JsonProperty("characters")]
		public List<CharacterModel> Characters { get; set; }
		[JsonProperty("finishedMissionCds")]
		public List<string> FinishedMissionCds { get; set; }
		[JsonProperty("items")]
		public List<ItemModel> Items { get; set; }
		[JsonProperty("missions")]
		public List<MissionModel> Missions { get; set; }
		[JsonProperty("pictureBookDetail")]
		public List<PictureBookDetailModel> PictureBookDetail { get; set; }
		[JsonProperty("stories")]
		public List<StoryModel> Stories { get; set; }
	}

	public class CharacterFortifyAbilityResponse : BasePacket
	{
		[JsonProperty("characters")]
		public List<CharacterModel> Characters { get; set; }
		[JsonProperty("finishedLinearMissions")]
		public List<LinearMissionModel> FinishedLinearMissions { get; set; }
		[JsonProperty("finishedMissionCds")]
		public List<string> FinishedMissionCds { get; set; }
		[JsonProperty("items")]
		public List<ItemModel> Items { get; set; }
		[JsonProperty("linearMissions")]
		public List<LinearMissionModel> LinearMissions { get; set; }
		[JsonProperty("missions")]
		public List<MissionModel> Missions { get; set; }
	}

	public class CharacterFortifySkillWarehouseResponse : BasePacket
	{
		[JsonProperty("characters")]
		public List<CharacterModel> Characters { get; set; }
		[JsonProperty("finishedLinearMissions")]
		public List<LinearMissionModel> FinishedLinearMissions { get; set; }
		[JsonProperty("finishedMissionCds")]
		public List<string> FinishedMissionCds { get; set; }
		[JsonProperty("items")]
		public List<ItemModel> Items { get; set; }
		[JsonProperty("linearMissions")]
		public List<LinearMissionModel> LinearMissions { get; set; }
		[JsonProperty("missions")]
		public List<MissionModel> Missions { get; set; }
		[JsonProperty("updateWarehouseCharacters")]
		public List<WarehouseCharacterModel> UpdateWarehouseCharacters { get; set; }
		[JsonProperty("updateWarehouseMaterials")]
		public List<WarehouseMaterialModel> UpdateWarehouseMaterials { get; set; }
	}

	public class CharacterFortifyWarehouseResponse : BasePacket
	{
		[JsonProperty("characters")]
		public List<CharacterModel> Characters { get; set; }
		[JsonProperty("finishedMissionCds")]
		public List<string> FinishedMissionCds { get; set; }
		[JsonProperty("isGreatSuccess")]
		public bool IsGreatSuccess { get; set; }
		[JsonProperty("items")]
		public List<ItemModel> Items { get; set; }
		[JsonProperty("missions")]
		public List<MissionModel> Missions { get; set; }
		[JsonProperty("updateWarehouseCharacters")]
		public List<WarehouseCharacterModel> UpdateWarehouseCharacters { get; set; }
		[JsonProperty("updateWarehouseMaterials")]
		public List<WarehouseMaterialModel> UpdateWarehouseMaterials { get; set; }
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
		[JsonProperty("characters")]
		public List<CharacterModel> Characters { get; set; }
	}

	public class CharacterLinkGetMasterDataResponse : BasePacket
	{
		public List<CharacterLinkModel> CharacterLink { get; set; }
	}

	public class CharacterLinkGetUserDataResponse : BasePacket
	{
		[JsonProperty("characterLinks")]
		public List<CharacterLinkUnitModel> CharacterLinks { get; set; }
	}

	public class CharacterSellResponse : BasePacket
	{
		[JsonProperty("characters")]
		public List<CharacterModel> Characters { get; set; }
		[JsonProperty("items")]
		public List<ItemModel> Items { get; set; }
	}

	public class CharacterSellWarehouseResponse : BasePacket
	{
		[JsonProperty("items")]
		public List<ItemModel> Items { get; set; }
		[JsonProperty("updateWarehouseCharacters")]
		public List<WarehouseCharacterModel> UpdateWarehouseCharacters { get; set; }
		[JsonProperty("updateWarehouseMaterials")]
		public List<WarehouseMaterialModel> UpdateWarehouseMaterials { get; set; }
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
		[JsonProperty("decks")]
		public List<DeckModel> Decks { get; set; }
		[JsonProperty("memorialDecks")]
		public List<MemorialDeckModel> MemorialDecks { get; set; }
	}

	public class DeckUpdateResponse : BasePacket
	{
		[JsonProperty("decks")]
		public List<DeckModel> Decks { get; set; }
		[JsonProperty("memorialDecks")]
		public List<MemorialDeckModel> MemorialDecks { get; set; }
	}

	public class EquipmentBulkFullFortifyResponse : BasePacket
	{
		[JsonProperty("addSolidEquipments")]
		public List<SolidEquipmentModel> AddSolidEquipments { get; set; }
		[JsonProperty("equipments")]
		public List<EquipmentModel> Equipments { get; set; }
		[JsonProperty("finishedLinearMissions")]
		public List<LinearMissionModel> FinishedLinearMissions { get; set; }
		[JsonProperty("finishedMissionCds")]
		public List<string> FinishedMissionCds { get; set; }
		[JsonProperty("items")]
		public List<ItemModel> Items { get; set; }
		[JsonProperty("linearMissions")]
		public List<LinearMissionModel> LinearMissions { get; set; }
		[JsonProperty("missions")]
		public List<MissionModel> Missions { get; set; }
		[JsonProperty("updateCharacters")]
		public List<CharacterModel> UpdateCharacters { get; set; }
		[JsonProperty("updateSolidEquipments")]
		public List<SolidEquipmentModel> UpdateSolidEquipments { get; set; }
		[JsonProperty("updateWarehouseEquipments")]
		public List<WarehouseEquipmentModel> UpdateWarehouseEquipments { get; set; }
		[JsonProperty("updateWarehouseMaterials")]
		public List<WarehouseMaterialModel> UpdateWarehouseMaterials { get; set; }
	}

	public class EquipmentExceedLimitWarehouseResponse : BasePacket
	{
		[JsonProperty("equipments")]
		public List<EquipmentModel> Equipments { get; set; }
		[JsonProperty("finishedLinearMissions")]
		public List<LinearMissionModel> FinishedLinearMissions { get; set; }
		[JsonProperty("finishedMissionCds")]
		public List<string> FinishedMissionCds { get; set; }
		[JsonProperty("items")]
		public List<ItemModel> Items { get; set; }
		[JsonProperty("linearMissions")]
		public List<LinearMissionModel> LinearMissions { get; set; }
		[JsonProperty("missions")]
		public List<MissionModel> Missions { get; set; }
		[JsonProperty("updateWarehouseEquipments")]
		public List<WarehouseEquipmentModel> UpdateWarehouseEquipments { get; set; }
		[JsonProperty("updateWarehouseMaterials")]
		public List<WarehouseMaterialModel> UpdateWarehouseMaterials { get; set; }
	}

	public class EquipmentFortifyWarehouseResponse : BasePacket
	{
		[JsonProperty("equipments")]
		public List<EquipmentModel> Equipments { get; set; }
		[JsonProperty("finishedMissionCds")]
		public List<string> FinishedMissionCds { get; set; }
		[JsonProperty("isGreatSuccess")]
		public bool IsGreatSuccess { get; set; }
		[JsonProperty("items")]
		public List<ItemModel> Items { get; set; }
		[JsonProperty("missions")]
		public List<MissionModel> Missions { get; set; }
		[JsonProperty("updateWarehouseEquipments")]
		public List<WarehouseEquipmentModel> UpdateWarehouseEquipments { get; set; }
		[JsonProperty("updateWarehouseMaterials")]
		public List<WarehouseMaterialModel> UpdateWarehouseMaterials { get; set; }
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
		[JsonProperty("addCharacters")]
		public List<CharacterModel> AddCharacters { get; set; }
		[JsonProperty("decks")]
		public List<DeckModel> Decks { get; set; }
		[JsonProperty("equipments")]
		public List<EquipmentModel> Equipments { get; set; }
		[JsonProperty("updateCharacters")]
		public List<CharacterModel> UpdateCharacters { get; set; }
	}

	public class EquipmentSellWarehouseResponse : BasePacket
	{
		[JsonProperty("items")]
		public List<ItemModel> Items { get; set; }
		[JsonProperty("updateWarehouseEquipments")]
		public List<WarehouseEquipmentModel> UpdateWarehouseEquipments { get; set; }
		[JsonProperty("updateWarehouseMaterials")]
		public List<WarehouseMaterialModel> UpdateWarehouseMaterials { get; set; }
	}

	public class EventEndBattleResponse : BasePacket
	{
		[JsonProperty("achieveRewards")]
		public List<InitItemModel> AchieveRewards { get; set; }
		[JsonProperty("addCharacterExps")]
		public List<int> AddCharacterExps { get; set; }
		[JsonProperty("addEventFriendshipItems")]
		public List<UserEventFriendshipItemModel> AddEventFriendshipItems { get; set; }
		[JsonProperty("addEventPointItems")]
		public List<UserEventItemModel> AddEventPointItems { get; set; }
		[JsonProperty("addGolds")]
		public List<int> AddGolds { get; set; }
		[JsonProperty("addUserExp")]
		public int AddUserExp { get; set; }
		[JsonProperty("addUserExps")]
		public List<int> AddUserExps { get; set; }
		[JsonProperty("addUserLevel")]
		public int AddUserLevel { get; set; }
		[JsonProperty("addWarehouseCharacters")]
		public List<WarehouseCharacterModel> AddWarehouseCharacters { get; set; }
		[JsonProperty("addWarehouseEquipments")]
		public List<WarehouseEquipmentModel> AddWarehouseEquipments { get; set; }
		[JsonProperty("addWarehouseMaterials")]
		public List<WarehouseMaterialModel> AddWarehouseMaterials { get; set; }
		[JsonProperty("boosts")]
		public List<UserBoostModel> Boosts { get; set; }
		[JsonProperty("characters")]
		public List<CharacterModel> Characters { get; set; }
		[JsonProperty("convertGolds")]
		public int ConvertGolds { get; set; }
		[JsonProperty("dropItems")]
		public List<List<dynamic>> DropItems { get; set; }
		[JsonProperty("equipments")]
		public List<EquipmentModel> Equipments { get; set; }
		[JsonProperty("eventFriendshipItems")]
		public List<UserEventFriendshipItemModel> EventFriendshipItems { get; set; }
		[JsonProperty("eventItems")]
		public List<UserEventItemModel> EventItems { get; set; }
		[JsonProperty("finishedLinearMissions")]
		public List<LinearMissionModel> FinishedLinearMissions { get; set; }
		[JsonProperty("finishedMissionCds")]
		public List<string> FinishedMissionCds { get; set; }
		[JsonProperty("gem")]
		public UserGemModel Gem { get; set; }
		[JsonProperty("items")]
		public List<ItemModel> Items { get; set; }
		[JsonProperty("linearMissions")]
		public List<LinearMissionModel> LinearMissions { get; set; }
		[JsonProperty("missions")]
		public List<MissionModel> Missions { get; set; }
		[JsonProperty("pictureBookDetail")]
		public List<PictureBookDetailModel> PictureBookDetail { get; set; }
		[JsonProperty("quests")]
		public List<QuestModel> Quests { get; set; }
		[JsonProperty("stories")]
		public List<StoryModel> Stories { get; set; }
		[JsonProperty("updateWarehouseCharacters")]
		public List<WarehouseCharacterModel> UpdateWarehouseCharacters { get; set; }
		[JsonProperty("updateWarehouseEquipments")]
		public List<WarehouseEquipmentModel> UpdateWarehouseEquipments { get; set; }
		[JsonProperty("updateWarehouseMaterials")]
		public List<WarehouseMaterialModel> UpdateWarehouseMaterials { get; set; }
		[JsonProperty("user")]
		public UserBasicInfoModel User { get; set; }
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
		[JsonProperty("eventFriendshipItems")]
		public List<UserEventFriendshipItemModel> EventFriendshipItems { get; set; }
		[JsonProperty("eventItems")]
		public List<UserEventItemModel> EventItems { get; set; }
	}

	public class EventSkipBattleResponse : BasePacket
	{
		[JsonProperty("addCharacterExps")]
		public List<int> AddCharacterExps { get; set; }
		[JsonProperty("addEventFriendshipItems")]
		public List<UserEventFriendshipItemModel> AddEventFriendshipItems { get; set; }
		[JsonProperty("addEventPointItems")]
		public List<List<dynamic>> AddEventPointItems { get; set; }
		[JsonProperty("addGolds")]
		public List<int> AddGolds { get; set; }
		[JsonProperty("addUserExp")]
		public int AddUserExp { get; set; }
		[JsonProperty("addUserExps")]
		public List<int> AddUserExps { get; set; }
		[JsonProperty("addUserLevel")]
		public int AddUserLevel { get; set; }
		[JsonProperty("addWarehouseCharacters")]
		public List<WarehouseCharacterModel> AddWarehouseCharacters { get; set; }
		[JsonProperty("addWarehouseEquipments")]
		public List<WarehouseEquipmentModel> AddWarehouseEquipments { get; set; }
		[JsonProperty("addWarehouseMaterials")]
		public List<WarehouseMaterialModel> AddWarehouseMaterials { get; set; }
		[JsonProperty("boosts")]
		public List<UserBoostModel> Boosts { get; set; }
		[JsonProperty("characters")]
		public List<CharacterModel> Characters { get; set; }
		[JsonProperty("convertGolds")]
		public int ConvertGolds { get; set; }
		[JsonProperty("dropItems")]
		public List<List<dynamic>> DropItems { get; set; }
		[JsonProperty("equipments")]
		public List<EquipmentModel> Equipments { get; set; }
		[JsonProperty("eventFriendshipItems")]
		public List<UserEventFriendshipItemModel> EventFriendshipItems { get; set; }
		[JsonProperty("eventItems")]
		public List<UserEventItemModel> EventItems { get; set; }
		[JsonProperty("finishedLinearMissions")]
		public List<LinearMissionModel> FinishedLinearMissions { get; set; }
		[JsonProperty("finishedMissionCds")]
		public List<string> FinishedMissionCds { get; set; }
		[JsonProperty("items")]
		public List<ItemModel> Items { get; set; }
		[JsonProperty("linearMissions")]
		public List<LinearMissionModel> LinearMissions { get; set; }
		[JsonProperty("missions")]
		public List<MissionModel> Missions { get; set; }
		[JsonProperty("pictureBookDetail")]
		public List<PictureBookDetailModel> PictureBookDetail { get; set; }
		[JsonProperty("quests")]
		public List<QuestModel> Quests { get; set; }
		[JsonProperty("stories")]
		public List<StoryModel> Stories { get; set; }
		[JsonProperty("updateWarehouseCharacters")]
		public List<WarehouseCharacterModel> UpdateWarehouseCharacters { get; set; }
		[JsonProperty("updateWarehouseEquipments")]
		public List<WarehouseEquipmentModel> UpdateWarehouseEquipments { get; set; }
		[JsonProperty("updateWarehouseMaterials")]
		public List<WarehouseMaterialModel> UpdateWarehouseMaterials { get; set; }
		[JsonProperty("user")]
		public UserBasicInfoModel User { get; set; }
	}

	public class EventStartBattleResponse : BasePacket
	{
		[JsonProperty("finishedMissionCds")]
		public List<string> FinishedMissionCds { get; set; }
		[JsonProperty("session")]
		public SessionDynamicModel Session { get; set; }
		[JsonProperty("stage")]
		public string Stage { get; set; }
		[JsonProperty("stories")]
		public List<StoryModel> Stories { get; set; }
		[JsonProperty("user")]
		public UserBasicInfoModel User { get; set; }
	}

	public class GachaGetDetailResponse : BasePacket
	{
		[JsonProperty("caution")]
		public string Caution { get; set; }
		[JsonProperty("description")]
		public CharacterTextModel Description { get; set; }
		[JsonProperty("gachaId")]
		public int GachaId { get; set; }
		[JsonProperty("odds")]
		public List<OddsDynamicModel> Odds { get; set; }
		[JsonProperty("presents")]
		public List<List<dynamic>> Presents { get; set; }
		[JsonProperty("selectPickInfo")]
		public SelectPickInfoDynamicModel SelectPickInfo { get; set; }
	}

	public class GachaGetListResponse : BasePacket
	{
		[JsonProperty("gacha")]
		public List<UserGachaModel> Gacha { get; set; }
	}

	public class GachaGetStepUpGroupResponse : BasePacket
	{
		[JsonProperty("odds")]
		public List<List<dynamic>> Odds { get; set; }
	}

	public class GachaGetUserDataResponse : BasePacket
	{
		[JsonProperty("gacha")]
		public List<UserGachaModel> Gacha { get; set; }
	}

	public class GachaPlayResponse : BasePacket
	{
		[JsonProperty("addCharacters")]
		public List<CharacterModel> AddCharacters { get; set; }
		[JsonProperty("addEquipments")]
		public List<EquipmentModel> AddEquipments { get; set; }
		[JsonProperty("addMemorials")]
		public List<MemorialModel> AddMemorials { get; set; }
		[JsonProperty("addPresents")]
		public List<AddPresentsDynamicModel> AddPresents { get; set; }
		[JsonProperty("boosts")]
		public List<UserBoostModel> Boosts { get; set; }
		[JsonProperty("button")]
		public ButtonDynamicModel Button { get; set; }
		[JsonProperty("cards")]
		public List<CharacterSellBonusModel> Cards { get; set; }
		[JsonProperty("characterLinks")]
		public List<CharacterLinkUnitModel> CharacterLinks { get; set; }
		[JsonProperty("finishedMissionCds")]
		public List<string> FinishedMissionCds { get; set; }
		[JsonProperty("gem")]
		public UserGemModel Gem { get; set; }
		[JsonProperty("getCharacters")]
		public List<UserCharacterModel> GetCharacters { get; set; }
		[JsonProperty("getEquipments")]
		public List<EquipmentModel> GetEquipments { get; set; }
		[JsonProperty("isCanReplay")]
		public bool IsCanReplay { get; set; }
		[JsonProperty("items")]
		public List<ItemModel> Items { get; set; }
		[JsonProperty("missions")]
		public List<MissionModel> Missions { get; set; }
		[JsonProperty("pictureBookDetail")]
		public List<PictureBookDetailModel> PictureBookDetail { get; set; }
		[JsonProperty("preConvert")]
		public List<CharacterSellBonusModel> PreConvert { get; set; }
		[JsonProperty("remainReplayCount")]
		public int RemainReplayCount { get; set; }
		[JsonProperty("user")]
		public UserBasicInfoModel User { get; set; }
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
		[JsonProperty("items")]
		public List<ItemModel> Items { get; set; }
	}

	public class ItemSellResponse : BasePacket
	{
		[JsonProperty("items")]
		public List<ItemModel> Items { get; set; }
	}

	public class ItemUseRecoveryItemResponse : BasePacket
	{
		[JsonProperty("items")]
		public List<ItemModel> Items { get; set; }
		[JsonProperty("user")]
		public UserBasicInfoModel User { get; set; }
	}

	public class ItemUseResponse : BasePacket
	{
		[JsonProperty("boosts")]
		public List<UserBoostModel> Boosts { get; set; }
		[JsonProperty("characters")]
		public List<CharacterModel> Characters { get; set; }
		[JsonProperty("equipments")]
		public List<EquipmentModel> Equipments { get; set; }
		[JsonProperty("items")]
		public List<ItemModel> Items { get; set; }
		[JsonProperty("quests")]
		public List<QuestModel> Quests { get; set; }
		[JsonProperty("rewards")]
		public List<dynamic> Rewards { get; set; }
		[JsonProperty("stories")]
		public List<StoryModel> Stories { get; set; }
		[JsonProperty("user")]
		public UserBasicInfoModel User { get; set; }
	}

	public class LinearMissionGetMasterDataResponse : BasePacket
	{
		public List<ExLinearMissionDetailModel> LinearMissionDetail { get; set; }
		public List<ExLinearMissionMainModel> LinearMissionMain { get; set; }
		public List<ExLinearMissionRewardModel> LinearMissionReward { get; set; }
	}

	public class LinearMissionGetUserDataResponse : BasePacket
	{
		[JsonProperty("linearMissions")]
		public List<LinearMissionModel> LinearMissions { get; set; }
	}

	public class LoginBonusGetLoginBonusResponse : BasePacket
	{
		[JsonProperty("loginBonus")]
		public List<LoginBonusModel> LoginBonus { get; set; }
		[JsonProperty("result")]
		public int Result { get; set; }
	}

	public class LoginBonusGetMasterDataResponse : BasePacket
	{
		public List<LoginBonusModel> LoginBonusMain { get; set; }
		public List<LoginRewardModel> LoginBonusReward { get; set; }
	}

	public class LoginPackGetLoginPackResponse : BasePacket
	{
		[JsonProperty("result")]
		public int Result { get; set; }
	}

	public class LoginPackGetMasterDataResponse : BasePacket
	{
		public List<LoginPackMainModel> LoginPackMain { get; set; }
		public List<LoginPackRewardModel> LoginPackReward { get; set; }
	}

	public class LoginPackGetUserDataResponse : BasePacket
	{
		[JsonProperty("loginPacks")]
		public List<UserLoginPackModel> LoginPacks { get; set; }
	}

	public class LotteryGetUserDataResponse : BasePacket
	{
		[JsonProperty("lotteries")]
		public List<LotteryModel> Lotteries { get; set; }
	}

	public class MemorialExceedLimitResponse : BasePacket
	{
		[JsonProperty("finishedMissionCds")]
		public List<string> FinishedMissionCds { get; set; }
		[JsonProperty("items")]
		public List<ItemModel> Items { get; set; }
		[JsonProperty("memorials")]
		public List<MemorialModel> Memorials { get; set; }
		[JsonProperty("missions")]
		public List<MissionModel> Missions { get; set; }
	}

	public class MemorialFortifyResponse : BasePacket
	{
		[JsonProperty("finishedMissionCds")]
		public List<string> FinishedMissionCds { get; set; }
		[JsonProperty("items")]
		public List<ItemModel> Items { get; set; }
		[JsonProperty("memorials")]
		public List<MemorialModel> Memorials { get; set; }
		[JsonProperty("missions")]
		public List<MissionModel> Missions { get; set; }
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
		[JsonProperty("memorials")]
		public List<MemorialModel> Memorials { get; set; }
	}

	public class MemorialReleaseStoryResponse : BasePacket
	{
		[JsonProperty("stories")]
		public List<StoryModel> Stories { get; set; }
	}

	public class MinigameGetListResponse : BasePacket
	{
		[JsonProperty("minigameData")]
		public List<MinigameMainModel> MinigameData { get; set; }
	}

	public class MinigameGetMasterDataResponse : BasePacket
	{
		public List<MinigameCharacterMainModel> MinigameCharacterMain { get; set; }
		public List<MinigameCharacterTextModel> MinigameCharacterText { get; set; }
	}

	public class MinigameGetUserDataResponse : BasePacket
	{
		[JsonProperty("minigame")]
		public UserMinigameModel Minigame { get; set; }
	}

	public class MinigamePlayResponse : BasePacket
	{
		[JsonProperty("minigame")]
		public UserMinigameModel Minigame { get; set; }
		[JsonProperty("rivalLane")]
		public int RivalLane { get; set; }
		[JsonProperty("winLane")]
		public int WinLane { get; set; }
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
		[JsonProperty("missions")]
		public List<MissionModel> Missions { get; set; }
	}

	public class MissionReceiveResponse : BasePacket
	{
		[JsonProperty("addCharacters")]
		public List<CharacterModel> AddCharacters { get; set; }
		[JsonProperty("addEquipments")]
		public List<EquipmentModel> AddEquipments { get; set; }
		[JsonProperty("addLotteries")]
		public List<dynamic> AddLotteries { get; set; }
		[JsonProperty("addWarehouseCharacters")]
		public List<WarehouseCharacterModel> AddWarehouseCharacters { get; set; }
		[JsonProperty("addWarehouseEquipments")]
		public List<WarehouseEquipmentModel> AddWarehouseEquipments { get; set; }
		[JsonProperty("addWarehouseMaterials")]
		public List<WarehouseMaterialModel> AddWarehouseMaterials { get; set; }
		[JsonProperty("eventItems")]
		public List<UserEventItemModel> EventItems { get; set; }
		[JsonProperty("finishedMissionCds")]
		public List<string> FinishedMissionCds { get; set; }
		[JsonProperty("furniture")]
		public List<FurnitureModel> Furniture { get; set; }
		[JsonProperty("gem")]
		public UserGemModel Gem { get; set; }
		[JsonProperty("items")]
		public List<ItemModel> Items { get; set; }
		[JsonProperty("missions")]
		public List<MissionModel> Missions { get; set; }
		[JsonProperty("nonReceiveReasons")]
		public List<dynamic> NonReceiveReasons { get; set; }
		[JsonProperty("pictureBookDetail")]
		public List<PictureBookDetailModel> PictureBookDetail { get; set; }
		[JsonProperty("updateWarehouseCharacters")]
		public List<WarehouseCharacterModel> UpdateWarehouseCharacters { get; set; }
		[JsonProperty("updateWarehouseEquipments")]
		public List<WarehouseEquipmentModel> UpdateWarehouseEquipments { get; set; }
		[JsonProperty("updateWarehouseMaterials")]
		public List<WarehouseMaterialModel> UpdateWarehouseMaterials { get; set; }
		[JsonProperty("user")]
		public UserBasicInfoModel User { get; set; }
	}

	public class MissionUpdateMissionProgressOnLoginResponse : BasePacket
	{
		[JsonProperty("finishedMissionCds")]
		public List<string> FinishedMissionCds { get; set; }
		[JsonProperty("missions")]
		public List<MissionModel> Missions { get; set; }
	}

	public class MyPageRefreshResponse : BasePacket
	{
		[JsonProperty("addNotices")]
		public List<UserNoticeModel> AddNotices { get; set; }
		[JsonProperty("checkingPaymentResult")]
		public string CheckingPaymentResult { get; set; }
		[JsonProperty("finishedMissionCds")]
		public List<string> FinishedMissionCds { get; set; }
		[JsonProperty("isUpdateDate")]
		public bool IsUpdateDate { get; set; }
		[JsonProperty("missions")]
		public List<MissionModel> Missions { get; set; }
		[JsonProperty("presentCount")]
		public int PresentCount { get; set; }
	}

	public class NoticeGetUserDataResponse : BasePacket
	{
		[JsonProperty("notices")]
		public List<UserNoticeModel> Notices { get; set; }
	}

	public class PaymentGetMasterDataResponse : BasePacket
	{
		public List<DmmModel> Dmm { get; set; }
	}

	public class PictureBookGetUserDataResponse : BasePacket
	{
		[JsonProperty("pictureBookBase")]
		public List<PictureBookBaseModel> PictureBookBase { get; set; }
		[JsonProperty("pictureBookDetail")]
		public List<PictureBookDetailModel> PictureBookDetail { get; set; }
	}

	public class PictureBookGiftResponse : BasePacket
	{
		[JsonProperty("addStories")]
		public List<UserStoryModel> AddStories { get; set; }
		[JsonProperty("finishedMissionCds")]
		public List<string> FinishedMissionCds { get; set; }
		[JsonProperty("items")]
		public List<ItemModel> Items { get; set; }
		[JsonProperty("missions")]
		public List<MissionModel> Missions { get; set; }
		[JsonProperty("pictureBookDetail")]
		public List<PictureBookDetailModel> PictureBookDetail { get; set; }
		[JsonProperty("stories")]
		public List<StoryModel> Stories { get; set; }
	}

	public class PresentGetListResponse : BasePacket
	{
		[JsonProperty("maxCount")]
		public int MaxCount { get; set; }
		[JsonProperty("presentCount")]
		public int PresentCount { get; set; }
		[JsonProperty("presents")]
		public List<PresentsDynamicModel> Presents { get; set; }
	}

	public class PresentGetMasterDataResponse : BasePacket
	{
		public List<PresentMessageModel> PresentMessage { get; set; }
	}

	public class PresentReceiveResponse : BasePacket
	{
		[JsonProperty("addCharacters")]
		public List<CharacterModel> AddCharacters { get; set; }
		[JsonProperty("addEquipments")]
		public List<EquipmentModel> AddEquipments { get; set; }
		[JsonProperty("addLotteries")]
		public List<dynamic> AddLotteries { get; set; }
		[JsonProperty("addMemorials")]
		public List<MemorialModel> AddMemorials { get; set; }
		[JsonProperty("addWarehouseCharacters")]
		public List<WarehouseCharacterModel> AddWarehouseCharacters { get; set; }
		[JsonProperty("addWarehouseEquipments")]
		public List<WarehouseEquipmentModel> AddWarehouseEquipments { get; set; }
		[JsonProperty("addWarehouseMaterials")]
		public List<WarehouseMaterialModel> AddWarehouseMaterials { get; set; }
		[JsonProperty("characterLinks")]
		public List<CharacterLinkUnitModel> CharacterLinks { get; set; }
		[JsonProperty("eventItems")]
		public List<UserEventItemModel> EventItems { get; set; }
		[JsonProperty("finishedMissionCds")]
		public List<string> FinishedMissionCds { get; set; }
		[JsonProperty("furniture")]
		public List<FurnitureModel> Furniture { get; set; }
		[JsonProperty("gem")]
		public UserGemModel Gem { get; set; }
		[JsonProperty("items")]
		public List<ItemModel> Items { get; set; }
		[JsonProperty("memorialConvertInfo")]
		public MemorialConvertInfoDynamicModel MemorialConvertInfo { get; set; }
		[JsonProperty("missions")]
		public List<MissionModel> Missions { get; set; }
		[JsonProperty("nonReceivePresents")]
		public List<dynamic> NonReceivePresents { get; set; }
		[JsonProperty("nonReceiveReasons")]
		public List<dynamic> NonReceiveReasons { get; set; }
		[JsonProperty("pictureBookDetail")]
		public List<PictureBookDetailModel> PictureBookDetail { get; set; }
		[JsonProperty("receivePresents")]
		public List<ReceivePresentsDynamicModel> ReceivePresents { get; set; }
		[JsonProperty("receiveWarehouseCharacters")]
		public List<ItemSelectModel> ReceiveWarehouseCharacters { get; set; }
		[JsonProperty("receiveWarehouseEquipments")]
		public List<WarehouseEquipmentModel> ReceiveWarehouseEquipments { get; set; }
		[JsonProperty("receiveWarehouseMaterials")]
		public List<ItemSelectModel> ReceiveWarehouseMaterials { get; set; }
		[JsonProperty("updateWarehouseCharacters")]
		public List<WarehouseCharacterModel> UpdateWarehouseCharacters { get; set; }
		[JsonProperty("updateWarehouseEquipments")]
		public List<WarehouseEquipmentModel> UpdateWarehouseEquipments { get; set; }
		[JsonProperty("updateWarehouseMaterials")]
		public List<WarehouseMaterialModel> UpdateWarehouseMaterials { get; set; }
		[JsonProperty("user")]
		public UserBasicInfoModel User { get; set; }
	}

	public class PvpEndBattleResponse : BasePacket
	{
		[JsonProperty("addPoint")]
		public int AddPoint { get; set; }
		[JsonProperty("addPresents")]
		public List<AddPresentsDynamicModel3> AddPresents { get; set; }
		[JsonProperty("characters")]
		public List<CharacterModel> Characters { get; set; }
		[JsonProperty("finishedMissionCds")]
		public List<string> FinishedMissionCds { get; set; }
		[JsonProperty("items")]
		public List<ItemModel> Items { get; set; }
		[JsonProperty("missions")]
		public List<MissionModel> Missions { get; set; }
		[JsonProperty("pvp")]
		public PvPModel Pvp { get; set; }
	}

	public class PvpGetBattlePlayersResponse : BasePacket
	{
		[JsonProperty("battlePlayers")]
		public List<BattlePlayersDynamicModel> BattlePlayers { get; set; }
		[JsonProperty("isNewSeason")]
		public bool IsNewSeason { get; set; }
		[JsonProperty("pvp")]
		public PvPModel Pvp { get; set; }
	}

	public class PvpGetMasterDataResponse : BasePacket
	{
		public List<PvPClassModel> PvPClass { get; set; }
		public List<PvPClassRewardModel> PvPClassReward { get; set; }
		public List<PvPMainModel> PvPMain { get; set; }
	}

	public class PvpGetUserDataResponse : BasePacket
	{
		[JsonProperty("pvp")]
		public PvPModel Pvp { get; set; }
	}

	public class PvpStartBattleResponse : BasePacket
	{
		[JsonProperty("playerId")]
		public string PlayerId { get; set; }
		[JsonProperty("pvp")]
		public PvPModel Pvp { get; set; }
		[JsonProperty("sessionId")]
		public string SessionId { get; set; }
	}

	public class PvpUpdateBattlePlayersResponse : BasePacket
	{
		[JsonProperty("battlePlayers")]
		public List<BattlePlayersDynamicModel2> BattlePlayers { get; set; }
		[JsonProperty("isNewSeason")]
		public bool IsNewSeason { get; set; }
		[JsonProperty("pvp")]
		public PvPModel Pvp { get; set; }
	}

	public class QuestEndBattleResponse : BasePacket
	{
		[JsonProperty("achieveRewards")]
		public List<InitItemModel> AchieveRewards { get; set; }
		[JsonProperty("addCharacterExps")]
		public List<int> AddCharacterExps { get; set; }
		[JsonProperty("addGolds")]
		public List<int> AddGolds { get; set; }
		[JsonProperty("addUserExp")]
		public int AddUserExp { get; set; }
		[JsonProperty("addUserExps")]
		public List<int> AddUserExps { get; set; }
		[JsonProperty("addUserLevel")]
		public int AddUserLevel { get; set; }
		[JsonProperty("addWarehouseCharacters")]
		public List<WarehouseCharacterModel> AddWarehouseCharacters { get; set; }
		[JsonProperty("addWarehouseEquipments")]
		public List<WarehouseEquipmentModel> AddWarehouseEquipments { get; set; }
		[JsonProperty("addWarehouseMaterials")]
		public List<WarehouseMaterialModel> AddWarehouseMaterials { get; set; }
		[JsonProperty("boosts")]
		public List<UserBoostModel> Boosts { get; set; }
		[JsonProperty("characters")]
		public List<CharacterModel> Characters { get; set; }
		[JsonProperty("convertGolds")]
		public int ConvertGolds { get; set; }
		[JsonProperty("dropItems")]
		public List<List<dynamic>> DropItems { get; set; }
		[JsonProperty("equipments")]
		public List<EquipmentModel> Equipments { get; set; }
		[JsonProperty("finishedLinearMissions")]
		public List<LinearMissionModel> FinishedLinearMissions { get; set; }
		[JsonProperty("finishedMissionCds")]
		public List<string> FinishedMissionCds { get; set; }
		[JsonProperty("items")]
		public List<ItemModel> Items { get; set; }
		[JsonProperty("linearMissions")]
		public List<LinearMissionModel> LinearMissions { get; set; }
		[JsonProperty("missions")]
		public List<MissionModel> Missions { get; set; }
		[JsonProperty("pictureBookDetail")]
		public List<PictureBookDetailModel> PictureBookDetail { get; set; }
		[JsonProperty("quests")]
		public List<QuestModel> Quests { get; set; }
		[JsonProperty("stories")]
		public List<StoryModel> Stories { get; set; }
		[JsonProperty("updateWarehouseCharacters")]
		public List<WarehouseCharacterModel> UpdateWarehouseCharacters { get; set; }
		[JsonProperty("updateWarehouseEquipments")]
		public List<WarehouseEquipmentModel> UpdateWarehouseEquipments { get; set; }
		[JsonProperty("updateWarehouseMaterials")]
		public List<WarehouseMaterialModel> UpdateWarehouseMaterials { get; set; }
		[JsonProperty("user")]
		public UserBasicInfoModel User { get; set; }
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
		[JsonProperty("stageEnemies")]
		public List<StageEnemiesDynamicModel> StageEnemies { get; set; }
		[JsonProperty("wave")]
		public int Wave { get; set; }
	}

	public class QuestGetUserDataResponse : BasePacket
	{
		[JsonProperty("quests")]
		public List<QuestModel> Quests { get; set; }
	}

	public class QuestSkipBattleResponse : BasePacket
	{
		[JsonProperty("addCharacterExps")]
		public List<int> AddCharacterExps { get; set; }
		[JsonProperty("addGolds")]
		public List<int> AddGolds { get; set; }
		[JsonProperty("addUserExp")]
		public int AddUserExp { get; set; }
		[JsonProperty("addUserExps")]
		public List<int> AddUserExps { get; set; }
		[JsonProperty("addUserLevel")]
		public int AddUserLevel { get; set; }
		[JsonProperty("addWarehouseCharacters")]
		public List<WarehouseCharacterModel> AddWarehouseCharacters { get; set; }
		[JsonProperty("addWarehouseEquipments")]
		public List<WarehouseEquipmentModel> AddWarehouseEquipments { get; set; }
		[JsonProperty("addWarehouseMaterials")]
		public List<WarehouseMaterialModel> AddWarehouseMaterials { get; set; }
		[JsonProperty("boosts")]
		public List<UserBoostModel> Boosts { get; set; }
		[JsonProperty("characters")]
		public List<CharacterModel> Characters { get; set; }
		[JsonProperty("convertGolds")]
		public int ConvertGolds { get; set; }
		[JsonProperty("dropItems")]
		public List<List<dynamic>> DropItems { get; set; }
		[JsonProperty("equipments")]
		public List<EquipmentModel> Equipments { get; set; }
		[JsonProperty("finishedLinearMissions")]
		public List<LinearMissionModel> FinishedLinearMissions { get; set; }
		[JsonProperty("finishedMissionCds")]
		public List<string> FinishedMissionCds { get; set; }
		[JsonProperty("items")]
		public List<ItemModel> Items { get; set; }
		[JsonProperty("linearMissions")]
		public List<LinearMissionModel> LinearMissions { get; set; }
		[JsonProperty("missions")]
		public List<MissionModel> Missions { get; set; }
		[JsonProperty("pictureBookDetail")]
		public List<PictureBookDetailModel> PictureBookDetail { get; set; }
		[JsonProperty("quests")]
		public List<QuestModel> Quests { get; set; }
		[JsonProperty("stories")]
		public List<StoryModel> Stories { get; set; }
		[JsonProperty("updateWarehouseCharacters")]
		public List<WarehouseCharacterModel> UpdateWarehouseCharacters { get; set; }
		[JsonProperty("updateWarehouseEquipments")]
		public List<WarehouseEquipmentModel> UpdateWarehouseEquipments { get; set; }
		[JsonProperty("updateWarehouseMaterials")]
		public List<WarehouseMaterialModel> UpdateWarehouseMaterials { get; set; }
		[JsonProperty("user")]
		public UserBasicInfoModel User { get; set; }
	}

	public class QuestStartBattleResponse : BasePacket
	{
		[JsonProperty("session")]
		public SessionDynamicModel2 Session { get; set; }
		[JsonProperty("stage")]
		public string Stage { get; set; }
		[JsonProperty("stories")]
		public List<StoryModel> Stories { get; set; }
		[JsonProperty("user")]
		public UserBasicInfoModel User { get; set; }
	}

	public class QuestUnlockQuestResponse : BasePacket
	{
		[JsonProperty("boosts")]
		public List<UserBoostModel> Boosts { get; set; }
		[JsonProperty("finishedMissionCds")]
		public List<string> FinishedMissionCds { get; set; }
		[JsonProperty("items")]
		public List<ItemModel> Items { get; set; }
		[JsonProperty("missions")]
		public List<MissionModel> Missions { get; set; }
		[JsonProperty("user")]
		public UserBasicInfoModel User { get; set; }
	}

	public class QuestionnaireGetQuestionnaireListResponse : BasePacket
	{
		[JsonProperty("questionnaire")]
		public List<dynamic> Questionnaire { get; set; }
	}

	public class RaceEndRaceResponse : BasePacket
	{
		[JsonProperty("addPresents")]
		public List<AddPresentsDynamicModel2> AddPresents { get; set; }
		[JsonProperty("raceSession")]
		public RaceSessionModel RaceSession { get; set; }
		[JsonProperty("updateRaceCharacters")]
		public List<RaceCharacterModel> UpdateRaceCharacters { get; set; }
	}

	public class RaceFortifyCharacterResponse : BasePacket
	{
		[JsonProperty("items")]
		public List<ItemModel> Items { get; set; }
		[JsonProperty("updateRaceCharacters")]
		public List<RaceCharacterModel> UpdateRaceCharacters { get; set; }
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
		[JsonProperty("raceCharacters")]
		public List<RaceCharacterModel> RaceCharacters { get; set; }
		[JsonProperty("raceSession")]
		public RaceSessionModel RaceSession { get; set; }
	}

	public class RaceStartRaceResponse : BasePacket
	{
		[JsonProperty("raceSession")]
		public RaceSessionModel RaceSession { get; set; }
		[JsonProperty("updateRaceCharacters")]
		public List<RaceCharacterModel> UpdateRaceCharacters { get; set; }
	}

	public class RaceUpdateSeasonResponse : BasePacket
	{
		[JsonProperty("addRaceCharacters")]
		public List<RaceCharacterModel> AddRaceCharacters { get; set; }
		[JsonProperty("raceSession")]
		public RaceSessionModel RaceSession { get; set; }
		[JsonProperty("updateRaceCharacters")]
		public List<RaceCharacterModel> UpdateRaceCharacters { get; set; }
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
		[JsonProperty("finishedMissionCds")]
		public List<string> FinishedMissionCds { get; set; }
		[JsonProperty("furniture")]
		public List<FurnitureModel> Furniture { get; set; }
		[JsonProperty("items")]
		public List<ItemModel> Items { get; set; }
		[JsonProperty("missions")]
		public List<MissionModel> Missions { get; set; }
	}

	public class RoomCollectAllResponse : BasePacket
	{
		[JsonProperty("finishedMissionCds")]
		public List<string> FinishedMissionCds { get; set; }
		[JsonProperty("furnitureRewards")]
		public List<FurnitureRewardsDynamicModel> FurnitureRewards { get; set; }
		[JsonProperty("items")]
		public List<ItemModel> Items { get; set; }
		[JsonProperty("missions")]
		public List<MissionModel> Missions { get; set; }
		[JsonProperty("nonCollectRewards")]
		public List<dynamic> NonCollectRewards { get; set; }
		[JsonProperty("room")]
		public RoomModel Room { get; set; }
		[JsonProperty("user")]
		public UserBasicInfoModel User { get; set; }
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
		[JsonProperty("furniture")]
		public List<FurnitureModel> Furniture { get; set; }
		[JsonProperty("room")]
		public RoomModel Room { get; set; }
		[JsonProperty("roomLayouts")]
		public List<UserRoomLayoutModel> RoomLayouts { get; set; }
	}

	public class RoomResetAllFurnitureResponse : BasePacket
	{
		[JsonProperty("room")]
		public RoomModel Room { get; set; }
	}

	public class RoomSaveSelectCharacterResponse : BasePacket
	{
		[JsonProperty("pictureBookBase")]
		public List<PictureBookBaseModel> PictureBookBase { get; set; }
	}

	public class RoomSetFurnitureResponse : BasePacket
	{
		[JsonProperty("room")]
		public RoomModel Room { get; set; }
	}

	public class ShopExchangeResponse : BasePacket
	{
		[JsonProperty("addRewards")]
		public List<InitItemModel> AddRewards { get; set; }
		[JsonProperty("boosts")]
		public List<UserBoostModel> Boosts { get; set; }
		[JsonProperty("exchangeHistories")]
		public List<UserExchangeHistoryModel> ExchangeHistories { get; set; }
		[JsonProperty("gem")]
		public UserGemModel Gem { get; set; }
		[JsonProperty("isReceivedBonus")]
		public bool IsReceivedBonus { get; set; }
		[JsonProperty("items")]
		public List<ItemModel> Items { get; set; }
		[JsonProperty("user")]
		public UserBasicInfoModel User { get; set; }
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
		[JsonProperty("orderPacks")]
		public List<OrderPackModel> OrderPacks { get; set; }
	}

	public class ShopGetUserDataResponse : BasePacket
	{
		[JsonProperty("exchangeHistories")]
		public List<UserExchangeHistoryModel> ExchangeHistories { get; set; }
		[JsonProperty("purchaseHistories")]
		public List<UserPurchaseHistoryModel> PurchaseHistories { get; set; }
	}

	public class ShopPurchaseResponse : BasePacket
	{
		[JsonProperty("addRaceCharacters")]
		public List<RaceCharacterModel> AddRaceCharacters { get; set; }
		[JsonProperty("addSounds")]
		public List<SoundModel> AddSounds { get; set; }
		[JsonProperty("finishedMissionCds")]
		public List<string> FinishedMissionCds { get; set; }
		[JsonProperty("gem")]
		public UserGemModel Gem { get; set; }
		[JsonProperty("loginPacks")]
		public List<UserLoginPackModel> LoginPacks { get; set; }
		[JsonProperty("missions")]
		public List<MissionModel> Missions { get; set; }
		[JsonProperty("orderPacks")]
		public List<OrderPackModel> OrderPacks { get; set; }
		[JsonProperty("purchaseHistories")]
		public List<UserPurchaseHistoryModel> PurchaseHistories { get; set; }
		[JsonProperty("user")]
		public UserBasicInfoModel User { get; set; }
	}

	public class SolidEquipmentGetUserDataResponse : BasePacket
	{
		[JsonProperty("solidEquipments")]
		public List<SolidEquipmentModel> SolidEquipments { get; set; }
	}

	public class SoundGetMasterDataResponse : BasePacket
	{
		public List<ExSoundMainModel> SoundMain { get; set; }
	}

	public class SoundGetUserDataResponse : BasePacket
	{
		[JsonProperty("sounds")]
		public List<SoundModel> Sounds { get; set; }
	}

	public class StoryAddStoryResponse : BasePacket
	{
		[JsonProperty("stories")]
		public List<StoryModel> Stories { get; set; }
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
		[JsonProperty("adult")]
		public int Adult { get; set; }
		[JsonProperty("resource")]
		public List<ResourceDynamicModel> Resource { get; set; }
		[JsonProperty("storyIds")]
		public List<int> StoryIds { get; set; }
	}

	public class StoryGetUserDataResponse : BasePacket
	{
		[JsonProperty("stories")]
		public List<StoryModel> Stories { get; set; }
	}

	public class StoryReadStoryResponse : BasePacket
	{
		[JsonProperty("addFreeGems")]
		public int AddFreeGems { get; set; }
		[JsonProperty("gem")]
		public UserGemModel Gem { get; set; }
		[JsonProperty("stories")]
		public List<StoryModel> Stories { get; set; }
	}

	public class TowerEndBattleResponse : BasePacket
	{
		[JsonProperty("achieveRewards")]
		public List<InitItemModel> AchieveRewards { get; set; }
		[JsonProperty("addCharacterExps")]
		public List<int> AddCharacterExps { get; set; }
		[JsonProperty("addGolds")]
		public List<int> AddGolds { get; set; }
		[JsonProperty("addUserExp")]
		public int AddUserExp { get; set; }
		[JsonProperty("addUserExps")]
		public List<int> AddUserExps { get; set; }
		[JsonProperty("addUserLevel")]
		public int AddUserLevel { get; set; }
		[JsonProperty("addWarehouseCharacters")]
		public List<WarehouseCharacterModel> AddWarehouseCharacters { get; set; }
		[JsonProperty("addWarehouseEquipments")]
		public List<WarehouseEquipmentModel> AddWarehouseEquipments { get; set; }
		[JsonProperty("addWarehouseMaterials")]
		public List<WarehouseMaterialModel> AddWarehouseMaterials { get; set; }
		[JsonProperty("boosts")]
		public List<UserBoostModel> Boosts { get; set; }
		[JsonProperty("characters")]
		public List<CharacterModel> Characters { get; set; }
		[JsonProperty("convertGolds")]
		public int ConvertGolds { get; set; }
		[JsonProperty("dropItems")]
		public List<List<dynamic>> DropItems { get; set; }
		[JsonProperty("equipments")]
		public List<EquipmentModel> Equipments { get; set; }
		[JsonProperty("finishedLinearMissions")]
		public List<LinearMissionModel> FinishedLinearMissions { get; set; }
		[JsonProperty("finishedMissionCds")]
		public List<string> FinishedMissionCds { get; set; }
		[JsonProperty("isTowerClear")]
		public bool IsTowerClear { get; set; }
		[JsonProperty("items")]
		public List<ItemModel> Items { get; set; }
		[JsonProperty("linearMissions")]
		public List<LinearMissionModel> LinearMissions { get; set; }
		[JsonProperty("missions")]
		public List<MissionModel> Missions { get; set; }
		[JsonProperty("pictureBookDetail")]
		public List<PictureBookDetailModel> PictureBookDetail { get; set; }
		[JsonProperty("quests")]
		public List<QuestModel> Quests { get; set; }
		[JsonProperty("stories")]
		public List<StoryModel> Stories { get; set; }
		[JsonProperty("towerCharacterStatus")]
		public List<TowerCharacterStatusDynamicModel2> TowerCharacterStatus { get; set; }
		[JsonProperty("towerSession")]
		public TowerSessionModel TowerSession { get; set; }
		[JsonProperty("updateWarehouseCharacters")]
		public List<WarehouseCharacterModel> UpdateWarehouseCharacters { get; set; }
		[JsonProperty("updateWarehouseEquipments")]
		public List<WarehouseEquipmentModel> UpdateWarehouseEquipments { get; set; }
		[JsonProperty("updateWarehouseMaterials")]
		public List<WarehouseMaterialModel> UpdateWarehouseMaterials { get; set; }
		[JsonProperty("user")]
		public UserBasicInfoModel User { get; set; }
	}

	public class TowerGetAreaDataResponse : BasePacket
	{
		[JsonProperty("area")]
		public string Area { get; set; }
		[JsonProperty("towerCharacterStatus")]
		public List<TowerCharacterStatusDynamicModel> TowerCharacterStatus { get; set; }
	}

	public class TowerGetMasterDataResponse : BasePacket
	{
		public List<TowerMainModel> TowerMain { get; set; }
		public List<TowerRewardModel> TowerReward { get; set; }
		public List<TowerRewardGroupModel> TowerRewardGroup { get; set; }
	}

	public class TowerGetUserDataResponse : BasePacket
	{
		[JsonProperty("towerSession")]
		public TowerSessionModel TowerSession { get; set; }
	}

	public class TowerSelectResponse : BasePacket
	{
		[JsonProperty("finishedMissionCds")]
		public List<string> FinishedMissionCds { get; set; }
		[JsonProperty("missions")]
		public List<MissionModel> Missions { get; set; }
		[JsonProperty("towerSession")]
		public TowerSessionModel TowerSession { get; set; }
		[JsonProperty("user")]
		public UserBasicInfoModel User { get; set; }
	}

	public class TowerStartBattleResponse : BasePacket
	{
		[JsonProperty("stage")]
		public string Stage { get; set; }
		[JsonProperty("towerSession")]
		public TowerSessionModel TowerSession { get; set; }
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
		[JsonProperty("gem")]
		public UserGemModel Gem { get; set; }
		[JsonProperty("user")]
		public UserBasicInfoModel User { get; set; }
	}

	public class UserGetUserProfileDataResponse : BasePacket
	{
		[JsonProperty("questCount")]
		public int QuestCount { get; set; }
	}

	public class UserLoginResponse : BasePacket
	{
		[JsonProperty("boosts")]
		public List<UserBoostModel> Boosts { get; set; }
		[JsonProperty("comebacks")]
		public List<UserComebackModel> Comebacks { get; set; }
		[JsonProperty("finishedMissionCds")]
		public List<string> FinishedMissionCds { get; set; }
		[JsonProperty("gem")]
		public UserGemModel Gem { get; set; }
		[JsonProperty("isUserWarning")]
		public bool IsUserWarning { get; set; }
		[JsonProperty("pref")]
		public UserPrefModel Pref { get; set; }
		[JsonProperty("resourceKey")]
		public string ResourceKey { get; set; }
		[JsonProperty("room")]
		public RoomModel Room { get; set; }
		[JsonProperty("stories")]
		public List<StoryModel> Stories { get; set; }
		[JsonProperty("user")]
		public UserBasicInfoModel User { get; set; }
		[JsonProperty("version")]
		public string Version { get; set; }
	}

	public class UserUpdateUserPrefsResponse : BasePacket
	{
		[JsonProperty("pref")]
		public UserPrefModel Pref { get; set; }
	}

	public class VersionGetMd5DataResponse : BasePacket
	{
		[JsonProperty("getMasterBoostData")]
		public string GetMasterBoostData { get; set; }
		[JsonProperty("getMasterCabinMissionData")]
		public string GetMasterCabinMissionData { get; set; }
		[JsonProperty("getMasterCampaignData")]
		public string GetMasterCampaignData { get; set; }
		[JsonProperty("getMasterCharacterAbilityData")]
		public string GetMasterCharacterAbilityData { get; set; }
		[JsonProperty("getMasterCharacterAbilityEffectData")]
		public string GetMasterCharacterAbilityEffectData { get; set; }
		[JsonProperty("getMasterCharacterAbilityEffectData2")]
		public string GetMasterCharacterAbilityEffectData2 { get; set; }
		[JsonProperty("getMasterCharacterAbilityEffectData3")]
		public string GetMasterCharacterAbilityEffectData3 { get; set; }
		[JsonProperty("getMasterCharacterAbilityEffectData4")]
		public string GetMasterCharacterAbilityEffectData4 { get; set; }
		[JsonProperty("getMasterCharacterAbilityEffectData5")]
		public string GetMasterCharacterAbilityEffectData5 { get; set; }
		[JsonProperty("getMasterCharacterAbilityEffectData6")]
		public string GetMasterCharacterAbilityEffectData6 { get; set; }
		[JsonProperty("getMasterCharacterAwakeData")]
		public string GetMasterCharacterAwakeData { get; set; }
		[JsonProperty("getMasterCharacterData")]
		public string GetMasterCharacterData { get; set; }
		[JsonProperty("getMasterCharacterEvolutionData")]
		public string GetMasterCharacterEvolutionData { get; set; }
		[JsonProperty("getMasterCharacterLinkData")]
		public string GetMasterCharacterLinkData { get; set; }
		[JsonProperty("getMasterCharacterMainData")]
		public string GetMasterCharacterMainData { get; set; }
		[JsonProperty("getMasterCharacterSkillData")]
		public string GetMasterCharacterSkillData { get; set; }
		[JsonProperty("getMasterCharacterSkillEffectData")]
		public string GetMasterCharacterSkillEffectData { get; set; }
		[JsonProperty("getMasterCharacterSkillEffectData2")]
		public string GetMasterCharacterSkillEffectData2 { get; set; }
		[JsonProperty("getMasterCharacterTextData")]
		public string GetMasterCharacterTextData { get; set; }
		[JsonProperty("getMasterCharacterTextData2")]
		public string GetMasterCharacterTextData2 { get; set; }
		[JsonProperty("getMasterCharacterTextData3")]
		public string GetMasterCharacterTextData3 { get; set; }
		[JsonProperty("getMasterCharacterTextData4")]
		public string GetMasterCharacterTextData4 { get; set; }
		[JsonProperty("getMasterCharacterTextData5")]
		public string GetMasterCharacterTextData5 { get; set; }
		[JsonProperty("getMasterComebackData")]
		public string GetMasterComebackData { get; set; }
		[JsonProperty("getMasterEquipmentData")]
		public string GetMasterEquipmentData { get; set; }
		[JsonProperty("getMasterEquipmentEffectData")]
		public string GetMasterEquipmentEffectData { get; set; }
		[JsonProperty("getMasterEquipmentEffectData2")]
		public string GetMasterEquipmentEffectData2 { get; set; }
		[JsonProperty("getMasterEventData")]
		public string GetMasterEventData { get; set; }
		[JsonProperty("getMasterExchangeItemDetailData")]
		public string GetMasterExchangeItemDetailData { get; set; }
		[JsonProperty("getMasterExchangeItemDetailData2")]
		public string GetMasterExchangeItemDetailData2 { get; set; }
		[JsonProperty("getMasterExchangePointDetailData")]
		public string GetMasterExchangePointDetailData { get; set; }
		[JsonProperty("getMasterItemData")]
		public string GetMasterItemData { get; set; }
		[JsonProperty("getMasterItemSetData")]
		public string GetMasterItemSetData { get; set; }
		[JsonProperty("getMasterItemSetData2")]
		public string GetMasterItemSetData2 { get; set; }
		[JsonProperty("getMasterLinearMissionData")]
		public string GetMasterLinearMissionData { get; set; }
		[JsonProperty("getMasterLoginBonusData")]
		public string GetMasterLoginBonusData { get; set; }
		[JsonProperty("getMasterLoginPackData")]
		public string GetMasterLoginPackData { get; set; }
		[JsonProperty("getMasterMemorialData")]
		public string GetMasterMemorialData { get; set; }
		[JsonProperty("getMasterMinigameData")]
		public string GetMasterMinigameData { get; set; }
		[JsonProperty("getMasterMissionData")]
		public string GetMasterMissionData { get; set; }
		[JsonProperty("getMasterMissionDetailData")]
		public string GetMasterMissionDetailData { get; set; }
		[JsonProperty("getMasterMissionDetailData2")]
		public string GetMasterMissionDetailData2 { get; set; }
		[JsonProperty("getMasterMissionDetailData3")]
		public string GetMasterMissionDetailData3 { get; set; }
		[JsonProperty("getMasterMissionDetailData4")]
		public string GetMasterMissionDetailData4 { get; set; }
		[JsonProperty("getMasterMyPageNewsData")]
		public string GetMasterMyPageNewsData { get; set; }
		[JsonProperty("getMasterMyPageNewsData2")]
		public string GetMasterMyPageNewsData2 { get; set; }
		[JsonProperty("getMasterPresentData")]
		public string GetMasterPresentData { get; set; }
		[JsonProperty("getMasterPvPData")]
		public string GetMasterPvPData { get; set; }
		[JsonProperty("getMasterQuestData")]
		public string GetMasterQuestData { get; set; }
		[JsonProperty("getMasterQuestDropData")]
		public string GetMasterQuestDropData { get; set; }
		[JsonProperty("getMasterQuestDropData2")]
		public string GetMasterQuestDropData2 { get; set; }
		[JsonProperty("getMasterQuestDropData3")]
		public string GetMasterQuestDropData3 { get; set; }
		[JsonProperty("getMasterQuestDropData4")]
		public string GetMasterQuestDropData4 { get; set; }
		[JsonProperty("getMasterQuestDropData5")]
		public string GetMasterQuestDropData5 { get; set; }
		[JsonProperty("getMasterQuestDropData6")]
		public string GetMasterQuestDropData6 { get; set; }
		[JsonProperty("getMasterQuestEventPointData")]
		public string GetMasterQuestEventPointData { get; set; }
		[JsonProperty("getMasterQuestStageData")]
		public string GetMasterQuestStageData { get; set; }
		[JsonProperty("getMasterQuestStageData2")]
		public string GetMasterQuestStageData2 { get; set; }
		[JsonProperty("getMasterQuestStageData3")]
		public string GetMasterQuestStageData3 { get; set; }
		[JsonProperty("getMasterRaceData")]
		public string GetMasterRaceData { get; set; }
		[JsonProperty("getMasterRaidData")]
		public string GetMasterRaidData { get; set; }
		[JsonProperty("getMasterRoomData")]
		public string GetMasterRoomData { get; set; }
		[JsonProperty("getMasterShopData")]
		public string GetMasterShopData { get; set; }
		[JsonProperty("getMasterSoundData")]
		public string GetMasterSoundData { get; set; }
		[JsonProperty("getMasterStoryData")]
		public string GetMasterStoryData { get; set; }
		[JsonProperty("getMasterTowerData")]
		public string GetMasterTowerData { get; set; }
		[JsonProperty("getMasterTutorialData")]
		public string GetMasterTutorialData { get; set; }
		[JsonProperty("getMasterUserData")]
		public string GetMasterUserData { get; set; }
		[JsonProperty("payment/getMasterData")]
		public string Payment_getMasterData { get; set; }
	}

	public class WarehouseBringWarehouseResponse : BasePacket
	{
		[JsonProperty("addWarehouseCharacters")]
		public List<WarehouseCharacterModel> AddWarehouseCharacters { get; set; }
		[JsonProperty("addWarehouseMaterials")]
		public List<WarehouseMaterialModel> AddWarehouseMaterials { get; set; }
		[JsonProperty("characters")]
		public List<CharacterModel> Characters { get; set; }
		[JsonProperty("updateWarehouseCharacters")]
		public List<WarehouseCharacterModel> UpdateWarehouseCharacters { get; set; }
		[JsonProperty("updateWarehouseMaterials")]
		public List<WarehouseMaterialModel> UpdateWarehouseMaterials { get; set; }
	}

	public class WarehouseGetCharacterCountResponse : BasePacket
	{
		[JsonProperty("maxCount")]
		public int MaxCount { get; set; }
		[JsonProperty("splitCount")]
		public int SplitCount { get; set; }
	}

	public class WarehouseGetCharacterListResponse : BasePacket
	{
		[JsonProperty("addWarehouseCharacters")]
		public List<WarehouseCharacterModel> AddWarehouseCharacters { get; set; }
	}

	public class WarehouseGetEquipmentCountResponse : BasePacket
	{
		[JsonProperty("maxCount")]
		public int MaxCount { get; set; }
		[JsonProperty("splitCount")]
		public int SplitCount { get; set; }
	}

	public class WarehouseGetEquipmentListResponse : BasePacket
	{
		[JsonProperty("addWarehouseEquipments")]
		public List<WarehouseEquipmentModel> AddWarehouseEquipments { get; set; }
	}

	public class WarehouseGetMaterialCountResponse : BasePacket
	{
		[JsonProperty("maxCount")]
		public int MaxCount { get; set; }
		[JsonProperty("splitCount")]
		public int SplitCount { get; set; }
	}

	public class WarehouseGetMaterialListResponse : BasePacket
	{
		[JsonProperty("addWarehouseMaterials")]
		public List<WarehouseMaterialModel> AddWarehouseMaterials { get; set; }
	}

	public class WarehouseTakeWarehouseResponse : BasePacket
	{
		[JsonProperty("addCharacters")]
		public List<CharacterModel> AddCharacters { get; set; }
		[JsonProperty("addEquipments")]
		public List<EquipmentModel> AddEquipments { get; set; }
		[JsonProperty("characterLinks")]
		public List<CharacterLinkUnitModel> CharacterLinks { get; set; }
		[JsonProperty("updateWarehouseCharacters")]
		public List<WarehouseCharacterModel> UpdateWarehouseCharacters { get; set; }
		[JsonProperty("updateWarehouseEquipments")]
		public List<WarehouseEquipmentModel> UpdateWarehouseEquipments { get; set; }
		[JsonProperty("updateWarehouseMaterials")]
		public List<WarehouseMaterialModel> UpdateWarehouseMaterials { get; set; }
	}

}

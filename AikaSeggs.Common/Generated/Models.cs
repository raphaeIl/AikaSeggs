using AikaSeggs.Common.Core;
using AikaSeggs.Common.Packets;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace AikaSeggs.Common.Packets
{
	public class AddPresentsDynamicModel
	{
		[JsonProperty("category")]
		public int Category { get; set; }
		[JsonProperty("count")]
		public int Count { get; set; }
		[JsonProperty("eventId")]
		public int EventId { get; set; }
		[JsonProperty("id")]
		public string Id { get; set; }
		[JsonProperty("isPaid")]
		public int IsPaid { get; set; }
		[JsonProperty("isReceived")]
		public int IsReceived { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
		[JsonProperty("masterId")]
		public int MasterId { get; set; }
		[JsonProperty("messageId")]
		public int MessageId { get; set; }
		[JsonProperty("parameters")]
		public List<string> Parameters { get; set; }
		[JsonProperty("presentDate")]
		public string PresentDate { get; set; }
		[JsonProperty("presenter")]
		public int Presenter { get; set; }
		[JsonProperty("receiveEndDate")]
		public string ReceiveEndDate { get; set; }
		[JsonProperty("receiveStartDate")]
		public string ReceiveStartDate { get; set; }
		[JsonProperty("userCd")]
		public string UserCd { get; set; }
		public string _id { get; set; }
	}

	public class AddPresentsDynamicModel2
	{
		[JsonProperty("count")]
		public int Count { get; set; }
		[JsonProperty("exceedLimit")]
		public int ExceedLimit { get; set; }
		[JsonProperty("isPaid")]
		public int IsPaid { get; set; }
		[JsonProperty("isReceived")]
		public int IsReceived { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
		[JsonProperty("masterId")]
		public int MasterId { get; set; }
		[JsonProperty("messageId")]
		public int MessageId { get; set; }
		[JsonProperty("parameters")]
		public List<string> Parameters { get; set; }
		[JsonProperty("presentCd")]
		public string PresentCd { get; set; }
		[JsonProperty("presentDate")]
		public string PresentDate { get; set; }
		[JsonProperty("presenter")]
		public int Presenter { get; set; }
		[JsonProperty("receiveEndDate")]
		public string ReceiveEndDate { get; set; }
		[JsonProperty("receiveStartDate")]
		public string ReceiveStartDate { get; set; }
	}

	public class AddPresentsDynamicModel3
	{
		[JsonProperty("category")]
		public int Category { get; set; }
		[JsonProperty("count")]
		public int Count { get; set; }
		[JsonProperty("eventId")]
		public int EventId { get; set; }
		[JsonProperty("id")]
		public string Id { get; set; }
		[JsonProperty("isPaid")]
		public int IsPaid { get; set; }
		[JsonProperty("isReceived")]
		public int IsReceived { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
		[JsonProperty("masterId")]
		public int MasterId { get; set; }
		[JsonProperty("messageId")]
		public int MessageId { get; set; }
		[JsonProperty("parameters")]
		public List<string> Parameters { get; set; }
		[JsonProperty("presentDate")]
		public string PresentDate { get; set; }
		[JsonProperty("presenter")]
		public int Presenter { get; set; }
		[JsonProperty("receiveEndDate")]
		public string ReceiveEndDate { get; set; }
		[JsonProperty("receiveStartDate")]
		public string ReceiveStartDate { get; set; }
		[JsonProperty("userCd")]
		public string UserCd { get; set; }
		public string _id { get; set; }
	}

	public class AllLineupsDynamicModel
	{
		[JsonProperty("count")]
		public int Count { get; set; }
		[JsonProperty("gachaId")]
		public int GachaId { get; set; }
		[JsonProperty("isReset")]
		public int IsReset { get; set; }
		[JsonProperty("itemId")]
		public int ItemId { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
		[JsonProperty("lineupId")]
		public int LineupId { get; set; }
		[JsonProperty("rarity")]
		public int Rarity { get; set; }
		[JsonProperty("step")]
		public int Step { get; set; }
		[JsonProperty("totalCount")]
		public int TotalCount { get; set; }
	}

	public class BattlePlayersDynamicModel
	{
		[JsonProperty("level")]
		public int Level { get; set; }
		[JsonProperty("partnerId")]
		public int PartnerId { get; set; }
		[JsonProperty("point")]
		public int Point { get; set; }
		[JsonProperty("pvpClass")]
		public int PvpClass { get; set; }
		[JsonProperty("targetCharacters")]
		public List<TargetCharactersDynamicModel> TargetCharacters { get; set; }
		[JsonProperty("targetDecks")]
		public List<TargetDecksDynamicModel> TargetDecks { get; set; }
		[JsonProperty("targetEquipments")]
		public List<dynamic> TargetEquipments { get; set; }
		[JsonProperty("targetMemorialDecks")]
		public List<TargetMemorialDecksDynamicModel> TargetMemorialDecks { get; set; }
		[JsonProperty("targetMemorials")]
		public List<TargetMemorialsDynamicModel> TargetMemorials { get; set; }
		[JsonProperty("targetPictureBookDetail")]
		public List<TargetPictureBookDetailDynamicModel> TargetPictureBookDetail { get; set; }
		[JsonProperty("targetSolidEquipments")]
		public List<dynamic> TargetSolidEquipments { get; set; }
		[JsonProperty("userCd")]
		public string UserCd { get; set; }
		[JsonProperty("userName")]
		public string UserName { get; set; }
	}

	public class BattlePlayersDynamicModel2
	{
		[JsonProperty("level")]
		public int Level { get; set; }
		[JsonProperty("partnerId")]
		public int PartnerId { get; set; }
		[JsonProperty("point")]
		public int Point { get; set; }
		[JsonProperty("pvpClass")]
		public int PvpClass { get; set; }
		[JsonProperty("targetCharacters")]
		public List<TargetCharactersDynamicModel2> TargetCharacters { get; set; }
		[JsonProperty("targetDecks")]
		public List<TargetDecksDynamicModel2> TargetDecks { get; set; }
		[JsonProperty("targetEquipments")]
		public List<dynamic> TargetEquipments { get; set; }
		[JsonProperty("targetMemorialDecks")]
		public List<dynamic> TargetMemorialDecks { get; set; }
		[JsonProperty("targetMemorials")]
		public List<dynamic> TargetMemorials { get; set; }
		[JsonProperty("targetPictureBookDetail")]
		public List<TargetPictureBookDetailDynamicModel2> TargetPictureBookDetail { get; set; }
		[JsonProperty("targetSolidEquipments")]
		public List<dynamic> TargetSolidEquipments { get; set; }
		[JsonProperty("userCd")]
		public string UserCd { get; set; }
		[JsonProperty("userName")]
		public string UserName { get; set; }
	}

	public class BoostUnitGroupDynamicModel
	{
		[JsonProperty("addValue")]
		public int AddValue { get; set; }
		[JsonProperty("boostLabel")]
		public int BoostLabel { get; set; }
		[JsonProperty("boostUnitGroupId")]
		public int BoostUnitGroupId { get; set; }
		[JsonProperty("characterId")]
		public int CharacterId { get; set; }
		[JsonProperty("valueType")]
		public int ValueType { get; set; }
	}

	public class BoxLineupsDynamicModel
	{
		[JsonProperty("gachaId")]
		public int GachaId { get; set; }
		[JsonProperty("lineupId")]
		public int LineupId { get; set; }
		[JsonProperty("userCd")]
		public string UserCd { get; set; }
		public string _id { get; set; }
	}

	public class ButtonDynamicModel
	{
		[JsonProperty("advanceRate")]
		public int AdvanceRate { get; set; }
		[JsonProperty("buttonId")]
		public int ButtonId { get; set; }
		[JsonProperty("buttonType")]
		public int ButtonType { get; set; }
		[JsonProperty("coinPresent")]
		public List<dynamic> CoinPresent { get; set; }
		[JsonProperty("costCount")]
		public int CostCount { get; set; }
		[JsonProperty("costId")]
		public int CostId { get; set; }
		[JsonProperty("costType")]
		public int CostType { get; set; }
		[JsonProperty("discountType")]
		public int DiscountType { get; set; }
		[JsonProperty("drawCount")]
		public int DrawCount { get; set; }
		[JsonProperty("gachaGroupId")]
		public int GachaGroupId { get; set; }
		[JsonProperty("gachaId")]
		public int GachaId { get; set; }
		[JsonProperty("isPlayGacha")]
		public bool IsPlayGacha { get; set; }
		[JsonProperty("skuId")]
		public int SkuId { get; set; }
		[JsonProperty("step")]
		public int Step { get; set; }
	}

	public class ButtonsDynamicModel
	{
		[JsonProperty("advanceRate")]
		public int AdvanceRate { get; set; }
		[JsonProperty("buttonId")]
		public string ButtonId { get; set; }
		[JsonProperty("buttonType")]
		public int ButtonType { get; set; }
		[JsonProperty("costCount")]
		public int CostCount { get; set; }
		[JsonProperty("costId")]
		public int CostId { get; set; }
		[JsonProperty("costType")]
		public int CostType { get; set; }
		[JsonProperty("discountType")]
		public int DiscountType { get; set; }
		[JsonProperty("drawCount")]
		public int DrawCount { get; set; }
		[JsonProperty("gachaId")]
		public int GachaId { get; set; }
		[JsonProperty("isPlayGacha")]
		public bool IsPlayGacha { get; set; }
		[JsonProperty("skuId")]
		public int SkuId { get; set; }
		[JsonProperty("step")]
		public int Step { get; set; }
	}

	public class FurnitureRewardsDynamicModel
	{
		[JsonProperty("collectCount")]
		public int CollectCount { get; set; }
		[JsonProperty("furnitureCd")]
		public string FurnitureCd { get; set; }
		[JsonProperty("furnitureId")]
		public int FurnitureId { get; set; }
		[JsonProperty("reward")]
		public RewardDynamicModel Reward { get; set; }
	}

	public class ItemsDynamicModel
	{
		[JsonProperty("count")]
		public int Count { get; set; }
		[JsonProperty("iconType")]
		public int IconType { get; set; }
		[JsonProperty("isPossession")]
		public int IsPossession { get; set; }
		[JsonProperty("itemId")]
		public int ItemId { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
		[JsonProperty("rate")]
		public double Rate { get; set; }
	}

	public class LineupDynamicModel
	{
		[JsonProperty("items")]
		public List<ItemsDynamicModel> Items { get; set; }
		[JsonProperty("rarity")]
		public string Rarity { get; set; }
	}

	public class MemorialConvertInfoDynamicModel
	{
		[JsonProperty("afterItems")]
		public List<dynamic> AfterItems { get; set; }
		[JsonProperty("beforeMemorials")]
		public List<dynamic> BeforeMemorials { get; set; }
	}

	public class OddsDynamicModel
	{
		[JsonProperty("drawCount")]
		public int DrawCount { get; set; }
		[JsonProperty("lineup")]
		public List<LineupDynamicModel> Lineup { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("rarity1")]
		public int Rarity1 { get; set; }
		[JsonProperty("rarity2")]
		public int Rarity2 { get; set; }
		[JsonProperty("rarity3")]
		public int Rarity3 { get; set; }
		[JsonProperty("rarity4")]
		public int Rarity4 { get; set; }
	}

	public class PresentsDynamicModel
	{
		[JsonProperty("count")]
		public int Count { get; set; }
		[JsonProperty("exceedLimit")]
		public int ExceedLimit { get; set; }
		[JsonProperty("isPaid")]
		public int IsPaid { get; set; }
		[JsonProperty("isReceived")]
		public int IsReceived { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
		[JsonProperty("masterId")]
		public int MasterId { get; set; }
		[JsonProperty("messageId")]
		public int MessageId { get; set; }
		[JsonProperty("parameters")]
		public List<string> Parameters { get; set; }
		[JsonProperty("presentCd")]
		public string PresentCd { get; set; }
		[JsonProperty("presentDate")]
		public string PresentDate { get; set; }
		[JsonProperty("presenter")]
		public int Presenter { get; set; }
		[JsonProperty("receiveEndDate")]
		public string ReceiveEndDate { get; set; }
		[JsonProperty("receiveStartDate")]
		public string ReceiveStartDate { get; set; }
	}

	public class QuestStageSeasonDynamicModel
	{
		[JsonProperty("fromDate")]
		public string FromDate { get; set; }
		[JsonProperty("stageId")]
		public int StageId { get; set; }
		[JsonProperty("toDate")]
		public string ToDate { get; set; }
	}

	public class ReceivePresentsDynamicModel
	{
		[JsonProperty("count")]
		public int Count { get; set; }
		[JsonProperty("exceedLimit")]
		public int ExceedLimit { get; set; }
		[JsonProperty("isPaid")]
		public int IsPaid { get; set; }
		[JsonProperty("isReceived")]
		public int IsReceived { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
		[JsonProperty("masterId")]
		public int MasterId { get; set; }
		[JsonProperty("messageId")]
		public int MessageId { get; set; }
		[JsonProperty("parameters")]
		public List<string> Parameters { get; set; }
		[JsonProperty("presentCd")]
		public string PresentCd { get; set; }
		[JsonProperty("presentDate")]
		public string PresentDate { get; set; }
		[JsonProperty("presenter")]
		public int Presenter { get; set; }
		[JsonProperty("receiveEndDate")]
		public string ReceiveEndDate { get; set; }
		[JsonProperty("receiveStartDate")]
		public string ReceiveStartDate { get; set; }
	}

	public class ResourceDynamicModel
	{
		[JsonProperty("fileName")]
		public string FileName { get; set; }
		[JsonProperty("md5")]
		public string Md5 { get; set; }
		[JsonProperty("path")]
		public string Path { get; set; }
	}

	public class RewardDynamicModel
	{
		[JsonProperty("count")]
		public int Count { get; set; }
		[JsonProperty("itemId")]
		public int ItemId { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
	}

	public class SelectPickInfoDynamicModel
	{
		[JsonProperty("selectGrpupInfoArray")]
		public List<dynamic> SelectGrpupInfoArray { get; set; }
		[JsonProperty("targetInfo")]
		public List<dynamic> TargetInfo { get; set; }
		[JsonProperty("userLineup")]
		public List<dynamic> UserLineup { get; set; }
	}

	public class SessionDynamicModel
	{
		[JsonProperty("deckId")]
		public int DeckId { get; set; }
		[JsonProperty("deckType")]
		public int DeckType { get; set; }
		[JsonProperty("saveData")]
		public dynamic SaveData { get; set; }
		[JsonProperty("sessionId")]
		public string SessionId { get; set; }
		[JsonProperty("stageId")]
		public int StageId { get; set; }
	}

	public class SessionDynamicModel2
	{
		[JsonProperty("deckId")]
		public int DeckId { get; set; }
		[JsonProperty("deckType")]
		public int DeckType { get; set; }
		[JsonProperty("saveData")]
		public dynamic SaveData { get; set; }
		[JsonProperty("sessionId")]
		public string SessionId { get; set; }
		[JsonProperty("stageId")]
		public int StageId { get; set; }
	}

	public class StageEnemiesDynamicModel
	{
		[JsonProperty("attribute")]
		public int Attribute { get; set; }
		[JsonProperty("isAddWaveEnemy")]
		public bool IsAddWaveEnemy { get; set; }
		[JsonProperty("level")]
		public int Level { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("order")]
		public int Order { get; set; }
		[JsonProperty("path")]
		public string Path { get; set; }
		[JsonProperty("subAttribute")]
		public int SubAttribute { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
	}

	public class TargetCharactersDynamicModel
	{
		[JsonProperty("abilityLevel1")]
		public int AbilityLevel1 { get; set; }
		[JsonProperty("abilityLevel2")]
		public int AbilityLevel2 { get; set; }
		[JsonProperty("abilityLevel3")]
		public int AbilityLevel3 { get; set; }
		[JsonProperty("awakeIds")]
		public List<dynamic> AwakeIds { get; set; }
		[JsonProperty("battleCount")]
		public int BattleCount { get; set; }
		[JsonProperty("characterCd")]
		public string CharacterCd { get; set; }
		[JsonProperty("characterId")]
		public int CharacterId { get; set; }
		[JsonProperty("equipmentProtectorCds")]
		public List<dynamic> EquipmentProtectorCds { get; set; }
		[JsonProperty("equipmentWeaponCds")]
		public List<string> EquipmentWeaponCds { get; set; }
		[JsonProperty("exceedLimit")]
		public int ExceedLimit { get; set; }
		[JsonProperty("exceedLimitExp")]
		public int ExceedLimitExp { get; set; }
		[JsonProperty("exp")]
		public int Exp { get; set; }
		[JsonProperty("isProtect")]
		public int IsProtect { get; set; }
		[JsonProperty("level")]
		public int Level { get; set; }
		[JsonProperty("registerDate")]
		public string RegisterDate { get; set; }
		[JsonProperty("skillLevel")]
		public int SkillLevel { get; set; }
	}

	public class TargetCharactersDynamicModel2
	{
		[JsonProperty("abilityLevel1")]
		public int AbilityLevel1 { get; set; }
		[JsonProperty("abilityLevel2")]
		public int AbilityLevel2 { get; set; }
		[JsonProperty("abilityLevel3")]
		public int AbilityLevel3 { get; set; }
		[JsonProperty("awakeIds")]
		public List<dynamic> AwakeIds { get; set; }
		[JsonProperty("battleCount")]
		public int BattleCount { get; set; }
		[JsonProperty("characterCd")]
		public string CharacterCd { get; set; }
		[JsonProperty("characterId")]
		public int CharacterId { get; set; }
		[JsonProperty("equipmentProtectorCds")]
		public List<dynamic> EquipmentProtectorCds { get; set; }
		[JsonProperty("equipmentWeaponCds")]
		public List<dynamic> EquipmentWeaponCds { get; set; }
		[JsonProperty("exceedLimit")]
		public int ExceedLimit { get; set; }
		[JsonProperty("exceedLimitExp")]
		public int ExceedLimitExp { get; set; }
		[JsonProperty("exp")]
		public int Exp { get; set; }
		[JsonProperty("isProtect")]
		public int IsProtect { get; set; }
		[JsonProperty("level")]
		public int Level { get; set; }
		[JsonProperty("registerDate")]
		public string RegisterDate { get; set; }
		[JsonProperty("skillLevel")]
		public int SkillLevel { get; set; }
	}

	public class TargetDecksDynamicModel
	{
		[JsonProperty("characterCd")]
		public string CharacterCd { get; set; }
		[JsonProperty("deckId")]
		public int DeckId { get; set; }
		[JsonProperty("deckType")]
		public int DeckType { get; set; }
		[JsonProperty("position")]
		public int Position { get; set; }
		[JsonProperty("roleType")]
		public int RoleType { get; set; }
	}

	public class TargetDecksDynamicModel2
	{
		[JsonProperty("characterCd")]
		public string CharacterCd { get; set; }
		[JsonProperty("deckId")]
		public int DeckId { get; set; }
		[JsonProperty("deckType")]
		public int DeckType { get; set; }
		[JsonProperty("position")]
		public int Position { get; set; }
		[JsonProperty("roleType")]
		public int RoleType { get; set; }
	}

	public class TargetMemorialDecksDynamicModel
	{
		[JsonProperty("deckId")]
		public int DeckId { get; set; }
		[JsonProperty("deckType")]
		public int DeckType { get; set; }
		[JsonProperty("memorialId")]
		public int MemorialId { get; set; }
		[JsonProperty("position")]
		public int Position { get; set; }
	}

	public class TargetMemorialsDynamicModel
	{
		[JsonProperty("exceedLimit")]
		public int ExceedLimit { get; set; }
		[JsonProperty("level")]
		public int Level { get; set; }
		[JsonProperty("memorialId")]
		public int MemorialId { get; set; }
		[JsonProperty("registerDate")]
		public string RegisterDate { get; set; }
	}

	public class TargetPictureBookDetailDynamicModel
	{
		[JsonProperty("characterId")]
		public int CharacterId { get; set; }
		[JsonProperty("exceedLimit")]
		public int ExceedLimit { get; set; }
		[JsonProperty("friendship")]
		public int Friendship { get; set; }
	}

	public class TargetPictureBookDetailDynamicModel2
	{
		[JsonProperty("characterId")]
		public int CharacterId { get; set; }
		[JsonProperty("exceedLimit")]
		public int ExceedLimit { get; set; }
		[JsonProperty("friendship")]
		public int Friendship { get; set; }
	}

	public class TowerCharacterStatusDynamicModel
	{
		[JsonProperty("characterCd")]
		public string CharacterCd { get; set; }
		[JsonProperty("hp")]
		public int Hp { get; set; }
		[JsonProperty("skillGauge")]
		public int SkillGauge { get; set; }
	}

	public class TowerCharacterStatusDynamicModel2
	{
		[JsonProperty("characterCd")]
		public string CharacterCd { get; set; }
		[JsonProperty("hp")]
		public int Hp { get; set; }
		[JsonProperty("skillGauge")]
		public int SkillGauge { get; set; }
	}

}

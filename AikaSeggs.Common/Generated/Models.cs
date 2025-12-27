using AikaSeggs.Common.Core;
using AikaSeggs.Common.Packets;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace AikaSeggs.Common.Packets
{
	public class ItemsDynamicModel
	{
		public int itemType { get; set; }
		public int itemId { get; set; }
		public int count { get; set; }
		public double rate { get; set; }
		public int iconType { get; set; }
		public int isPossession { get; set; }
	}

	public class LineupDynamicModel
	{
		public string rarity { get; set; }
		public List<ItemsDynamicModel> items { get; set; }
	}

	public class OddsDynamicModel
	{
		public string name { get; set; }
		public int drawCount { get; set; }
		public int rarity1 { get; set; }
		public int rarity2 { get; set; }
		public int rarity3 { get; set; }
		public int rarity4 { get; set; }
		public List<LineupDynamicModel> lineup { get; set; }
	}

	public class SelectPickInfoDynamicModel
	{
		public List<dynamic> userLineup { get; set; }
		public List<dynamic> targetInfo { get; set; }
		public List<dynamic> selectGrpupInfoArray { get; set; }
	}

	public class AddPresentsDynamicModel
	{
		public string _id { get; set; }
		public string id { get; set; }
		public string userCd { get; set; }
		public int category { get; set; }
		public int itemType { get; set; }
		public int masterId { get; set; }
		public int count { get; set; }
		public int presenter { get; set; }
		public string presentDate { get; set; }
		public string receiveStartDate { get; set; }
		public string receiveEndDate { get; set; }
		public int isReceived { get; set; }
		public int messageId { get; set; }
		public List<string> parameters { get; set; }
		public int isPaid { get; set; }
		public int eventId { get; set; }
	}

	public class CoinPresentDynamicModel
	{
		public int presentGroupId { get; set; }
		public int index { get; set; }
		public int itemType { get; set; }
		public int itemId { get; set; }
		public int itemCount { get; set; }
		public int rate { get; set; }
		public int rateFrom { get; set; }
		public int rateTo { get; set; }
	}

	public class ButtonDynamicModel
	{
		public int gachaId { get; set; }
		public int buttonId { get; set; }
		public int buttonType { get; set; }
		public bool isPlayGacha { get; set; }
		public int step { get; set; }
		public int drawCount { get; set; }
		public int costType { get; set; }
		public int costId { get; set; }
		public int costCount { get; set; }
		public int discountType { get; set; }
		public int advanceRate { get; set; }
		public int skuId { get; set; }
		public int gachaGroupId { get; set; }
		public List<CoinPresentDynamicModel> coinPresent { get; set; }
	}

	public class StageEnemiesDynamicModel
	{
		public string path { get; set; }
		public string name { get; set; }
		public string text { get; set; }
		public int attribute { get; set; }
		public int subAttribute { get; set; }
		public int order { get; set; }
		public int level { get; set; }
		public bool isAddWaveEnemy { get; set; }
	}

	public class RewardDynamicModel
	{
		public int itemId { get; set; }
		public int itemType { get; set; }
		public int count { get; set; }
	}

	public class FurnitureRewardsDynamicModel
	{
		public int furnitureId { get; set; }
		public string furnitureCd { get; set; }
		public RewardDynamicModel reward { get; set; }
		public int collectCount { get; set; }
	}

	public class ResourceDynamicModel
	{
		public string fileName { get; set; }
		public string path { get; set; }
		public string md5 { get; set; }
	}

	public class TowerCharacterStatusDynamicModel
	{
		public string characterCd { get; set; }
		public int hp { get; set; }
		public int skillGauge { get; set; }
	}

	public class TargetDecksDynamicModel
	{
		public int deckId { get; set; }
		public int deckType { get; set; }
		public int roleType { get; set; }
		public int position { get; set; }
		public string characterCd { get; set; }
	}

	public class TargetCharactersDynamicModel
	{
		public string characterCd { get; set; }
		public int characterId { get; set; }
		public int exp { get; set; }
		public int level { get; set; }
		public int skillLevel { get; set; }
		public int abilityLevel1 { get; set; }
		public int abilityLevel2 { get; set; }
		public int abilityLevel3 { get; set; }
		public int exceedLimit { get; set; }
		public int exceedLimitExp { get; set; }
		public int isProtect { get; set; }
		public string registerDate { get; set; }
		public List<string> equipmentWeaponCds { get; set; }
		public List<dynamic> equipmentProtectorCds { get; set; }
		public List<dynamic> awakeIds { get; set; }
		public int battleCount { get; set; }
	}

	public class TargetMemorialDecksDynamicModel
	{
		public int deckType { get; set; }
		public int deckId { get; set; }
		public int position { get; set; }
		public int memorialId { get; set; }
	}

	public class TargetMemorialsDynamicModel
	{
		public int memorialId { get; set; }
		public int level { get; set; }
		public int exceedLimit { get; set; }
		public string registerDate { get; set; }
	}

	public class TargetPictureBookDetailDynamicModel
	{
		public int characterId { get; set; }
		public int friendship { get; set; }
		public int exceedLimit { get; set; }
	}

	public class BattlePlayersDynamicModel
	{
		public string userCd { get; set; }
		public string userName { get; set; }
		public int level { get; set; }
		public int pvpClass { get; set; }
		public int partnerId { get; set; }
		public int point { get; set; }
		public List<TargetDecksDynamicModel> targetDecks { get; set; }
		public List<TargetCharactersDynamicModel> targetCharacters { get; set; }
		public List<dynamic> targetEquipments { get; set; }
		public List<dynamic> targetSolidEquipments { get; set; }
		public List<TargetMemorialDecksDynamicModel> targetMemorialDecks { get; set; }
		public List<TargetMemorialsDynamicModel> targetMemorials { get; set; }
		public List<TargetPictureBookDetailDynamicModel> targetPictureBookDetail { get; set; }
	}

	public class BoxLineupsDynamicModel
	{
		public string _id { get; set; }
		public string userCd { get; set; }
		public int gachaId { get; set; }
		public int lineupId { get; set; }
	}

	public class AllLineupsDynamicModel
	{
		public int gachaId { get; set; }
		public int step { get; set; }
		public int lineupId { get; set; }
		public int rarity { get; set; }
		public int itemType { get; set; }
		public int itemId { get; set; }
		public int count { get; set; }
		public int totalCount { get; set; }
		public int isReset { get; set; }
	}

	public class ButtonsDynamicModel
	{
		public int gachaId { get; set; }
		public string buttonId { get; set; }
		public int buttonType { get; set; }
		public bool isPlayGacha { get; set; }
		public int step { get; set; }
		public int drawCount { get; set; }
		public int costType { get; set; }
		public int costId { get; set; }
		public int costCount { get; set; }
		public int discountType { get; set; }
		public int advanceRate { get; set; }
		public int skuId { get; set; }
	}

	public class AddPresentsDynamicModel2
	{
		public string presentCd { get; set; }
		public int itemType { get; set; }
		public int masterId { get; set; }
		public int count { get; set; }
		public int presenter { get; set; }
		public string presentDate { get; set; }
		public string receiveStartDate { get; set; }
		public string receiveEndDate { get; set; }
		public int isReceived { get; set; }
		public int messageId { get; set; }
		public List<string> parameters { get; set; }
		public int isPaid { get; set; }
		public int exceedLimit { get; set; }
	}

	public class MemorialConvertInfoDynamicModel
	{
		public List<dynamic> beforeMemorials { get; set; }
		public List<dynamic> afterItems { get; set; }
	}

	public class BoostUnitGroupDynamicModel
	{
		public int boostUnitGroupId { get; set; }
		public int characterId { get; set; }
		public int valueType { get; set; }
		public int addValue { get; set; }
		public int boostLabel { get; set; }
	}

	public class SessionDynamicModel
	{
		public string sessionId { get; set; }
		public int stageId { get; set; }
		public int deckId { get; set; }
		public int deckType { get; set; }
		public dynamic saveData { get; set; }
	}

	public class QuestStageSeasonDynamicModel
	{
		public int stageId { get; set; }
		public string fromDate { get; set; }
		public string toDate { get; set; }
	}

}

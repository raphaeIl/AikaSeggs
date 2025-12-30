using AikaSeggs.Common.Core;
using AikaSeggs.Common.Database;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace AikaSeggs.Common.Database
{
	public class BattleMonsterModel
	{
		[JsonProperty("enemyId")]
		public int EnemyId { get; set; }
		[JsonProperty("level")]
		public int Level { get; set; }
		[JsonProperty("index")]
		public int Index { get; set; }
		[JsonProperty("skillId")]
		public int SkillId { get; set; }
		[JsonProperty("abilityData")]
		public dynamic AbilityData { get; set; }
		[JsonProperty("skillData")]
		public dynamic SkillData { get; set; }
		[JsonProperty("attribute")]
		public int Attribute { get; set; }
		[JsonProperty("subAttribute")]
		public int SubAttribute { get; set; }
		[JsonProperty("baseMaxHp")]
		public int BaseMaxHp { get; set; }
		[JsonProperty("baseAtk")]
		public int BaseAtk { get; set; }
		[JsonProperty("baseDef")]
		public int BaseDef { get; set; }
		[JsonProperty("spineDirectoryPath")]
		public string SpineDirectoryPath { get; set; }
		[JsonProperty("spineName")]
		public string SpineName { get; set; }
		[JsonProperty("iconName")]
		public string IconName { get; set; }
		[JsonProperty("enemyAIList")]
		public List<dynamic> EnemyAIList { get; set; }
		[JsonProperty("normalAttackData")]
		public dynamic NormalAttackData { get; set; }
		[JsonProperty("resistData")]
		public dynamic ResistData { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("spineScale")]
		public double SpineScale { get; set; }
		[JsonProperty("isBoss")]
		public bool IsBoss { get; set; }
		[JsonProperty("rageDataList")]
		public List<dynamic> RageDataList { get; set; }
		[JsonProperty("isBeatBoss")]
		public bool IsBeatBoss { get; set; }
		[JsonProperty("subAttributeAtk")]
		public int SubAttributeAtk { get; set; }
		[JsonProperty("id")]
		public int Id { get; set; }
		[JsonProperty("baseMaxHpExceptEquipEffect")]
		public dynamic BaseMaxHpExceptEquipEffect { get; set; }
		[JsonProperty("baseAtkExceptEquipEffect")]
		public dynamic BaseAtkExceptEquipEffect { get; set; }
		[JsonProperty("baseDefExceptEquipEffect")]
		public dynamic BaseDefExceptEquipEffect { get; set; }
		public dynamic _MainObjectNode { get; set; }
		public dynamic _DamageShowNode { get; set; }
		public dynamic _EffectShowNode { get; set; }
		public dynamic _BuffShowNode { get; set; }
		[JsonProperty("charaterModel")]
		public dynamic CharaterModel { get; set; }
		[JsonProperty("unisonType")]
		public int UnisonType { get; set; }
		[JsonProperty("normalAttackId")]
		public int NormalAttackId { get; set; }
		[JsonProperty("effectShowType")]
		public int EffectShowType { get; set; }
		[JsonProperty("effectShowValue")]
		public double EffectShowValue { get; set; }
		[JsonProperty("aniName")]
		public string AniName { get; set; }
		[JsonProperty("hitEffectName")]
		public string HitEffectName { get; set; }
		[JsonProperty("hitEffectAniName")]
		public string HitEffectAniName { get; set; }
	}

	public class BattleSessionModel
	{
		[JsonProperty("sessionId")]
		public string SessionId { get; set; }
		[JsonProperty("deckId")]
		public int DeckId { get; set; }
		[JsonProperty("stageId")]
		public int StageId { get; set; }
		[JsonProperty("saveData")]
		public dynamic SaveData { get; set; }
	}

	public class BoostGroupModel
	{
		[JsonProperty("worldId")]
		public int WorldId { get; set; }
		[JsonProperty("boostGroupId")]
		public int BoostGroupId { get; set; }
		[JsonProperty("boostType")]
		public int BoostType { get; set; }
		[JsonProperty("targetId")]
		public int TargetId { get; set; }
	}

	public class BoostModel
	{
		[JsonProperty("boostType")]
		public int BoostType { get; set; }
		[JsonProperty("itemId")]
		public int ItemId { get; set; }
		[JsonProperty("parameter")]
		public dynamic Parameter { get; set; }
		[JsonProperty("endDate")]
		public string EndDate { get; set; }
		[JsonProperty("startDate")]
		public string StartDate { get; set; }
		[JsonProperty("itemMainMaster")]
		public ItemMainModel ItemMainMaster { get; set; }
	}

	public class BossEventPointModel
	{
		[JsonProperty("eventId")]
		public int EventId { get; set; }
		[JsonProperty("stageId")]
		public int StageId { get; set; }
		[JsonProperty("bossId")]
		public int BossId { get; set; }
		[JsonProperty("countMax")]
		public int CountMax { get; set; }
	}

	public class BossGaugeColorModel
	{
		[JsonProperty("gaugeColorId")]
		public int GaugeColorId { get; set; }
		[JsonProperty("red")]
		public int Red { get; set; }
		[JsonProperty("green")]
		public int Green { get; set; }
		[JsonProperty("blue")]
		public int Blue { get; set; }
		[JsonProperty("alpha")]
		public int Alpha { get; set; }
	}

	public class BossRageAnimationModel
	{
		[JsonProperty("rageAnimId")]
		public int RageAnimId { get; set; }
		[JsonProperty("actionAnimSuffix")]
		public string ActionAnimSuffix { get; set; }
		[JsonProperty("rageAnim")]
		public string RageAnim { get; set; }
	}

	public class BossStageModel
	{
		[JsonProperty("stageId")]
		public int StageId { get; set; }
		[JsonProperty("turn")]
		public int Turn { get; set; }
	}

	public class CabinMissionDetailModel
	{
		[JsonProperty("missionGroupId")]
		public int MissionGroupId { get; set; }
		[JsonProperty("missionId")]
		public int MissionId { get; set; }
		[JsonProperty("conditionType")]
		public int ConditionType { get; set; }
		[JsonProperty("conditionValue")]
		public int ConditionValue { get; set; }
	}

	public class CabinMissionMainModel
	{
		[JsonProperty("missionGroupId")]
		public int MissionGroupId { get; set; }
		[JsonProperty("memorialId1")]
		public int MemorialId1 { get; set; }
		[JsonProperty("memorialId2")]
		public int MemorialId2 { get; set; }
		[JsonProperty("memorialId3")]
		public int MemorialId3 { get; set; }
		[JsonProperty("memorialId4")]
		public int MemorialId4 { get; set; }
		[JsonProperty("visibleDate")]
		public string VisibleDate { get; set; }
	}

	public class CabinMissionModel
	{
		[JsonProperty("missionGroupId")]
		public int MissionGroupId { get; set; }
		[JsonProperty("missionId")]
		public int MissionId { get; set; }
		[JsonProperty("receiveCount")]
		public int ReceiveCount { get; set; }
	}

	public class CabinMissionRewardModel
	{
		[JsonProperty("missionId")]
		public int MissionId { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
		[JsonProperty("itemId")]
		public int ItemId { get; set; }
		[JsonProperty("count")]
		public int Count { get; set; }
	}

	public class CampaignModel
	{
		[JsonProperty("campaignType")]
		public int CampaignType { get; set; }
		[JsonProperty("campaignValue")]
		public int CampaignValue { get; set; }
		[JsonProperty("fromDate")]
		public string FromDate { get; set; }
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
		[JsonProperty("targetIds")]
		public string TargetIds { get; set; }
		[JsonProperty("targetType")]
		public int TargetType { get; set; }
		[JsonProperty("toDate")]
		public string ToDate { get; set; }
		[JsonProperty("weekTypes")]
		public string WeekTypes { get; set; }
	}

	public class CharacterAbilityConditionModel
	{
		[JsonProperty("abilityId")]
		public int AbilityId { get; set; }
		[JsonProperty("conditionGroup")]
		public int ConditionGroup { get; set; }
		[JsonProperty("conditionType")]
		public int ConditionType { get; set; }
		[JsonProperty("conditionValue")]
		public int ConditionValue { get; set; }
	}

	public class CharacterAbilityEffectModel
	{
		[JsonProperty("abilityId")]
		public int AbilityId { get; set; }
		[JsonProperty("index")]
		public int Index { get; set; }
		[JsonProperty("occurrenceRate")]
		public int OccurrenceRate { get; set; }
		[JsonProperty("effectConditionType")]
		public int EffectConditionType { get; set; }
		[JsonProperty("level")]
		public int Level { get; set; }
		[JsonProperty("successRate")]
		public int SuccessRate { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
		[JsonProperty("shortText")]
		public string ShortText { get; set; }
		[JsonProperty("effectLimit")]
		public int EffectLimit { get; set; }
		[JsonProperty("effectConditionValue")]
		public string EffectConditionValue { get; set; }
		[JsonProperty("targetType")]
		public int TargetType { get; set; }
		[JsonProperty("effectValue")]
		public int EffectValue { get; set; }
		[JsonProperty("actionType")]
		public int ActionType { get; set; }
		[JsonProperty("endValue")]
		public string EndValue { get; set; }
		[JsonProperty("effectType")]
		public int EffectType { get; set; }
		[JsonProperty("endType")]
		public int EndType { get; set; }
		[JsonProperty("targetValue")]
		public string TargetValue { get; set; }
	}

	public class CharacterAbilityGroupModel
	{
		[JsonProperty("abilityId")]
		public int AbilityId { get; set; }
		[JsonProperty("index")]
		public int Index { get; set; }
		[JsonProperty("abilityGroupId")]
		public int AbilityGroupId { get; set; }
	}

	public class CharacterAbilityMainModel
	{
		[JsonProperty("abilityId")]
		public int AbilityId { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("invokeLimitCount")]
		public int InvokeLimitCount { get; set; }
		[JsonProperty("addAbilityId")]
		public int AddAbilityId { get; set; }
		[JsonProperty("abilityFortifyType")]
		public int AbilityFortifyType { get; set; }
		[JsonProperty("triggerType")]
		public int TriggerType { get; set; }
		[JsonProperty("triggerValue")]
		public string TriggerValue { get; set; }
	}

	public class CharacterAbilityUpModel
	{
		[JsonProperty("abilityFortifyType")]
		public int AbilityFortifyType { get; set; }
		[JsonProperty("level")]
		public int Level { get; set; }
		[JsonProperty("materialId1")]
		public int MaterialId1 { get; set; }
		[JsonProperty("materialCount1")]
		public int MaterialCount1 { get; set; }
		[JsonProperty("materialId2")]
		public int MaterialId2 { get; set; }
		[JsonProperty("materialCount2")]
		public int MaterialCount2 { get; set; }
		[JsonProperty("materialId3")]
		public int MaterialId3 { get; set; }
		[JsonProperty("materialCount3")]
		public int MaterialCount3 { get; set; }
		[JsonProperty("materialId4")]
		public int MaterialId4 { get; set; }
		[JsonProperty("materialCount4")]
		public int MaterialCount4 { get; set; }
		[JsonProperty("materialId5")]
		public int MaterialId5 { get; set; }
		[JsonProperty("materialCount5")]
		public int MaterialCount5 { get; set; }
		[JsonProperty("price")]
		public int Price { get; set; }
	}

	public class CharacterAlterModel
	{
		[JsonProperty("characterId")]
		public int CharacterId { get; set; }
	}

	public class CharacterAwakeConditionModel
	{
		[JsonProperty("conditionValue")]
		public int ConditionValue { get; set; }
		[JsonProperty("index")]
		public int Index { get; set; }
		[JsonProperty("conditionType")]
		public int ConditionType { get; set; }
		[JsonProperty("awakeId")]
		public int AwakeId { get; set; }
	}

	public class CharacterAwakeEffectModel
	{
		[JsonProperty("index")]
		public int Index { get; set; }
		[JsonProperty("awakeId")]
		public int AwakeId { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
		[JsonProperty("value")]
		public int Value { get; set; }
		[JsonProperty("awakeType")]
		public int AwakeType { get; set; }
		[JsonProperty("effectColumn")]
		public string EffectColumn { get; set; }
		[JsonProperty("effectIndex")]
		public int EffectIndex { get; set; }
		[JsonProperty("targetIndex")]
		public int TargetIndex { get; set; }
	}

	public class CharacterAwakeGroupModel
	{
		[JsonProperty("awakeGroupId")]
		public int AwakeGroupId { get; set; }
		[JsonProperty("equipmentId")]
		public int EquipmentId { get; set; }
		[JsonProperty("characterId")]
		public int CharacterId { get; set; }
	}

	public class CharacterAwakeMainModel
	{
		[JsonProperty("index")]
		public int Index { get; set; }
		[JsonProperty("price")]
		public int Price { get; set; }
		[JsonProperty("iconType")]
		public int IconType { get; set; }
		[JsonProperty("awakeId")]
		public int AwakeId { get; set; }
		[JsonProperty("awakeGroupId")]
		public int AwakeGroupId { get; set; }
	}

	public class CharacterAwakeMaterialModel
	{
		[JsonProperty("count")]
		public int Count { get; set; }
		[JsonProperty("index")]
		public int Index { get; set; }
		[JsonProperty("awakeId")]
		public int AwakeId { get; set; }
		[JsonProperty("materialId")]
		public int MaterialId { get; set; }
		[JsonProperty("materialType")]
		public int MaterialType { get; set; }
	}

	public class CharacterContentsModel
	{
		[JsonProperty("conditionType1")]
		public int ConditionType1 { get; set; }
		[JsonProperty("conditionType2")]
		public int ConditionType2 { get; set; }
		[JsonProperty("conditionValue1")]
		public int ConditionValue1 { get; set; }
		[JsonProperty("conditionValue2")]
		public int ConditionValue2 { get; set; }
		[JsonProperty("contentType")]
		public int ContentType { get; set; }
		[JsonProperty("contentsGroupId")]
		public int ContentsGroupId { get; set; }
		[JsonProperty("contentsId")]
		public int ContentsId { get; set; }
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
		[JsonProperty("storyId")]
		public int StoryId { get; set; }
		[JsonProperty("textId")]
		public int TextId { get; set; }
	}

	public class CharacterEvolutionEffectModel
	{
		[JsonProperty("effectId")]
		public int EffectId { get; set; }
		[JsonProperty("hpRate")]
		public int HpRate { get; set; }
		[JsonProperty("atkRate")]
		public int AtkRate { get; set; }
		[JsonProperty("defRate")]
		public int DefRate { get; set; }
		[JsonProperty("skillId")]
		public int SkillId { get; set; }
		[JsonProperty("abilityGroupId")]
		public int AbilityGroupId { get; set; }
	}

	public class CharacterEvolutionMainModel
	{
		[JsonProperty("characterId")]
		public int CharacterId { get; set; }
		[JsonProperty("rarity")]
		public int Rarity { get; set; }
		[JsonProperty("materialId")]
		public int MaterialId { get; set; }
		[JsonProperty("effectId")]
		public int EffectId { get; set; }
		[JsonProperty("skillFortifyType")]
		public int SkillFortifyType { get; set; }
	}

	public class CharacterEvolutionMaterialModel
	{
		[JsonProperty("materialId")]
		public int MaterialId { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
		[JsonProperty("itemId")]
		public int ItemId { get; set; }
		[JsonProperty("count")]
		public int Count { get; set; }
	}

	public class CharacterExceedLimitModel
	{
		[JsonProperty("exceedLimitType")]
		public int ExceedLimitType { get; set; }
		[JsonProperty("exceedLimit")]
		public int ExceedLimit { get; set; }
		[JsonProperty("materialId")]
		public int MaterialId { get; set; }
		[JsonProperty("materialCount")]
		public int MaterialCount { get; set; }
		[JsonProperty("totalExceedLimitExp")]
		public int TotalExceedLimitExp { get; set; }
		[JsonProperty("needExceedLimitExp")]
		public int NeedExceedLimitExp { get; set; }
		[JsonProperty("equipmentWeaponCount")]
		public int EquipmentWeaponCount { get; set; }
		[JsonProperty("equipmentProtectorCount")]
		public int EquipmentProtectorCount { get; set; }
		[JsonProperty("abilityCount")]
		public int AbilityCount { get; set; }
		[JsonProperty("exceedLimitPrice")]
		public int ExceedLimitPrice { get; set; }
	}

	public class CharacterFavoriteModel
	{
		[JsonProperty("addType")]
		public int AddType { get; set; }
		[JsonProperty("characterId")]
		public int CharacterId { get; set; }
		[JsonProperty("favoriteItemId")]
		public int FavoriteItemId { get; set; }
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
		[JsonProperty("value")]
		public int Value { get; set; }
	}

	public class CharacterGroupModel
	{
		[JsonProperty("characterGroupId")]
		public int CharacterGroupId { get; set; }
		[JsonProperty("order")]
		public int Order { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("shortName")]
		public string ShortName { get; set; }
		[JsonProperty("roomName")]
		public string RoomName { get; set; }
		[JsonProperty("readingName")]
		public string ReadingName { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
		[JsonProperty("union")]
		public int Union { get; set; }
		[JsonProperty("contentsGroupId")]
		public int ContentsGroupId { get; set; }
		[JsonProperty("fromDate")]
		public string FromDate { get; set; }
		[JsonProperty("standHeadPositionX")]
		public int StandHeadPositionX { get; set; }
		[JsonProperty("standHeadPositionY")]
		public int StandHeadPositionY { get; set; }
	}

	public class CharacterGroupSeasonModel
	{
		[JsonProperty("characterGroupId")]
		public int CharacterGroupId { get; set; }
		[JsonProperty("targetType")]
		public int TargetType { get; set; }
		[JsonProperty("value")]
		public int Value { get; set; }
		[JsonProperty("fromDate")]
		public string FromDate { get; set; }
		[JsonProperty("toDate")]
		public string ToDate { get; set; }
	}

	public class CharacterLevelModel
	{
		[JsonProperty("level")]
		public int Level { get; set; }
		[JsonProperty("expType")]
		public int ExpType { get; set; }
		[JsonProperty("salePrice")]
		public int SalePrice { get; set; }
		[JsonProperty("fortifyPrice")]
		public int FortifyPrice { get; set; }
		[JsonProperty("totalExp")]
		public int TotalExp { get; set; }
		[JsonProperty("nextLevelExp")]
		public int NextLevelExp { get; set; }
	}

	public class CharacterLinkModel
	{
		[JsonProperty("characterId")]
		public int CharacterId { get; set; }
		[JsonProperty("linkerId")]
		public int LinkerId { get; set; }
		[JsonProperty("priority")]
		public int Priority { get; set; }
	}

	public class CharacterLinkUnitModel
	{
		[JsonProperty("abilityEffectModelArray")]
		public List<dynamic> AbilityEffectModelArray { get; set; }
		[JsonProperty("abilityGroupId")]
		public int AbilityGroupId { get; set; }
		[JsonProperty("abilityLevel1")]
		public int AbilityLevel1 { get; set; }
		[JsonProperty("abilityLevel2")]
		public int AbilityLevel2 { get; set; }
		[JsonProperty("abilityLevel3")]
		public int AbilityLevel3 { get; set; }
		[JsonProperty("addAtk")]
		public int AddAtk { get; set; }
		[JsonProperty("addDef")]
		public int AddDef { get; set; }
		[JsonProperty("addExceedLimitExp")]
		public int AddExceedLimitExp { get; set; }
		[JsonProperty("addExp")]
		public int AddExp { get; set; }
		[JsonProperty("addHp")]
		public int AddHp { get; set; }
		[JsonProperty("addRarity")]
		public int AddRarity { get; set; }
		[JsonProperty("addSkillUpRate")]
		public int AddSkillUpRate { get; set; }
		[JsonProperty("atk")]
		public int Atk { get; set; }
		[JsonProperty("atkRate")]
		public int AtkRate { get; set; }
		[JsonProperty("attribute")]
		public int Attribute { get; set; }
		[JsonProperty("awakeGroupMaster")]
		public dynamic AwakeGroupMaster { get; set; }
		[JsonProperty("awakeIds")]
		public List<dynamic> AwakeIds { get; set; }
		[JsonProperty("baseRarity")]
		public int BaseRarity { get; set; }
		[JsonProperty("baseSkillFortifyType")]
		public int BaseSkillFortifyType { get; set; }
		[JsonProperty("battleCount")]
		public int BattleCount { get; set; }
		[JsonProperty("characterCd")]
		public string CharacterCd { get; set; }
		[JsonProperty("characterEquipmentInfoArray")]
		public List<dynamic> CharacterEquipmentInfoArray { get; set; }
		[JsonProperty("characterEvolutionMainMaster")]
		public CharacterEvolutionMainModel CharacterEvolutionMainMaster { get; set; }
		[JsonProperty("characterExceedLimitMaster")]
		public CharacterExceedLimitModel CharacterExceedLimitMaster { get; set; }
		[JsonProperty("characterExceedLimitMasterArray")]
		public List<CharacterExceedLimitModel> CharacterExceedLimitMasterArray { get; set; }
		[JsonProperty("characterExceedLimitMasterMap")]
		public Dictionary<string, CharacterExceedLimitModel> CharacterExceedLimitMasterMap { get; set; }
		[JsonProperty("characterExp")]
		public int CharacterExp { get; set; }
		[JsonProperty("characterGroupId")]
		public int CharacterGroupId { get; set; }
		[JsonProperty("characterId")]
		public int CharacterId { get; set; }
		[JsonProperty("characterLinkUnitArray")]
		public List<CharacterLinkUnitModel> CharacterLinkUnitArray { get; set; }
		[JsonProperty("characterMainMaster")]
		public CharacterMainModel CharacterMainMaster { get; set; }
		[JsonProperty("characterMaterialMaster")]
		public CharacterMaterialModel CharacterMaterialMaster { get; set; }
		[JsonProperty("characterNormalAttackMaster")]
		public CharacterNormalAttackModel CharacterNormalAttackMaster { get; set; }
		[JsonProperty("characterSkillInfo")]
		public dynamic CharacterSkillInfo { get; set; }
		[JsonProperty("characterType")]
		public int CharacterType { get; set; }
		[JsonProperty("contentsGroupId")]
		public int ContentsGroupId { get; set; }
		[JsonProperty("costumeId")]
		public int CostumeId { get; set; }
		[JsonProperty("def")]
		public int Def { get; set; }
		[JsonProperty("defRate")]
		public int DefRate { get; set; }
		[JsonProperty("enabledAwakeEffectMasterArray")]
		public List<dynamic> EnabledAwakeEffectMasterArray { get; set; }
		[JsonProperty("enabledAwakeMainMasterArray")]
		public List<dynamic> EnabledAwakeMainMasterArray { get; set; }
		[JsonProperty("equipmentProtectorCds")]
		public List<dynamic> EquipmentProtectorCds { get; set; }
		[JsonProperty("equipmentWeaponCds")]
		public List<string> EquipmentWeaponCds { get; set; }
		[JsonProperty("eventBoost")]
		public dynamic EventBoost { get; set; }
		[JsonProperty("exceedLimit")]
		public int ExceedLimit { get; set; }
		[JsonProperty("exceedLimitAlternateId")]
		public int ExceedLimitAlternateId { get; set; }
		[JsonProperty("exceedLimitExp")]
		public int ExceedLimitExp { get; set; }
		[JsonProperty("exceedLimitMaterialCount")]
		public int ExceedLimitMaterialCount { get; set; }
		[JsonProperty("exceedLimitMaterialId")]
		public int ExceedLimitMaterialId { get; set; }
		[JsonProperty("exceedLimitPrice")]
		public int ExceedLimitPrice { get; set; }
		[JsonProperty("exceedLimitType")]
		public int ExceedLimitType { get; set; }
		[JsonProperty("expRateForNextLevel")]
		public int ExpRateForNextLevel { get; set; }
		[JsonProperty("forceOriginalGroupId")]
		public int ForceOriginalGroupId { get; set; }
		[JsonProperty("fortifyPrice")]
		public int FortifyPrice { get; set; }
		[JsonProperty("hasSubAttribute")]
		public int HasSubAttribute { get; set; }
		[JsonProperty("hp")]
		public int Hp { get; set; }
		[JsonProperty("hpRate")]
		public int HpRate { get; set; }
		[JsonProperty("isFortifyMaterial")]
		public bool IsFortifyMaterial { get; set; }
		[JsonProperty("isLevelMax")]
		public bool IsLevelMax { get; set; }
		[JsonProperty("isProtect")]
		public int IsProtect { get; set; }
		[JsonProperty("isSellMaterial")]
		public bool IsSellMaterial { get; set; }
		[JsonProperty("isSkillMaterial")]
		public bool IsSkillMaterial { get; set; }
		[JsonProperty("level")]
		public int Level { get; set; }
		[JsonProperty("linkerCd")]
		public string LinkerCd { get; set; }
		[JsonProperty("linkerId")]
		public int LinkerId { get; set; }
		[JsonProperty("materialType")]
		public int MaterialType { get; set; }
		[JsonProperty("maxFortifyAtk")]
		public int MaxFortifyAtk { get; set; }
		[JsonProperty("maxFortifyDef")]
		public int MaxFortifyDef { get; set; }
		[JsonProperty("maxFortifyHp")]
		public int MaxFortifyHp { get; set; }
		[JsonProperty("maxLevel")]
		public int MaxLevel { get; set; }
		[JsonProperty("maxSkillLevel")]
		public int MaxSkillLevel { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("needExpForNextExceedLimit")]
		public int NeedExpForNextExceedLimit { get; set; }
		[JsonProperty("needExpForNextLevel")]
		public int NeedExpForNextLevel { get; set; }
		[JsonProperty("order")]
		public int Order { get; set; }
		[JsonProperty("parentCharacterModel")]
		public dynamic ParentCharacterModel { get; set; }
		[JsonProperty("parentId")]
		public int ParentId { get; set; }
		[JsonProperty("pictureBookDetailModel")]
		public PictureBookDetailModel PictureBookDetailModel { get; set; }
		[JsonProperty("priority")]
		public int Priority { get; set; }
		[JsonProperty("rarity")]
		public int Rarity { get; set; }
		[JsonProperty("shortName")]
		public string ShortName { get; set; }
		[JsonProperty("skillEffectMasterMap")]
		public Dictionary<string, dynamic> SkillEffectMasterMap { get; set; }
		[JsonProperty("skillEffectModelArray")]
		public List<dynamic> SkillEffectModelArray { get; set; }
		[JsonProperty("skillFortifyType")]
		public int SkillFortifyType { get; set; }
		[JsonProperty("skillId")]
		public int SkillId { get; set; }
		[JsonProperty("skillLevel")]
		public int SkillLevel { get; set; }
		[JsonProperty("skillMainMaster")]
		public dynamic SkillMainMaster { get; set; }
		[JsonProperty("skillName")]
		public string SkillName { get; set; }
		[JsonProperty("skillShortText")]
		public string SkillShortText { get; set; }
		[JsonProperty("skillText")]
		public string SkillText { get; set; }
		[JsonProperty("skinName")]
		public string SkinName { get; set; }
		[JsonProperty("spineDirectoryPath")]
		public string SpineDirectoryPath { get; set; }
		[JsonProperty("spineName")]
		public string SpineName { get; set; }
		[JsonProperty("subAttribute")]
		public int SubAttribute { get; set; }
		[JsonProperty("subAttributePower")]
		public int SubAttributePower { get; set; }
		[JsonProperty("totalAtkExceptEquipEffect")]
		public dynamic TotalAtkExceptEquipEffect { get; set; }
		[JsonProperty("totalBasePower")]
		public int TotalBasePower { get; set; }
		[JsonProperty("totalDefExceptEquipEffect")]
		public dynamic TotalDefExceptEquipEffect { get; set; }
		[JsonProperty("totalHpExceptEquipEffect")]
		public dynamic TotalHpExceptEquipEffect { get; set; }
		[JsonProperty("totalStatus")]
		public dynamic TotalStatus { get; set; }
		[JsonProperty("userAbilityGroupModel")]
		public dynamic UserAbilityGroupModel { get; set; }
		[JsonProperty("userSkillEffectModelArray")]
		public List<dynamic> UserSkillEffectModelArray { get; set; }
		[JsonProperty("userSkillMainModel")]
		public dynamic UserSkillMainModel { get; set; }
	}

	public class CharacterMainModel
	{
		[JsonProperty("characterGroupId")]
		public int CharacterGroupId { get; set; }
		[JsonProperty("characterId")]
		public int CharacterId { get; set; }
		[JsonProperty("characterType")]
		public int CharacterType { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("shortName")]
		public string ShortName { get; set; }
		[JsonProperty("skinName")]
		public string SkinName { get; set; }
		[JsonProperty("readingName")]
		public string ReadingName { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
		[JsonProperty("shortText")]
		public string ShortText { get; set; }
		[JsonProperty("voiceActorName")]
		public string VoiceActorName { get; set; }
		[JsonProperty("illustratorName")]
		public string IllustratorName { get; set; }
		[JsonProperty("contentsGroupId")]
		public int ContentsGroupId { get; set; }
		[JsonProperty("costumeId")]
		public int CostumeId { get; set; }
		[JsonProperty("rarity")]
		public int Rarity { get; set; }
		[JsonProperty("attribute")]
		public int Attribute { get; set; }
		[JsonProperty("subAttribute")]
		public int SubAttribute { get; set; }
		[JsonProperty("subAttributePower")]
		public int SubAttributePower { get; set; }
		[JsonProperty("skillId")]
		public int SkillId { get; set; }
		[JsonProperty("abilityGroupId")]
		public int AbilityGroupId { get; set; }
		[JsonProperty("supportAbilityGroupId")]
		public int SupportAbilityGroupId { get; set; }
		[JsonProperty("normalAttackId")]
		public int NormalAttackId { get; set; }
		[JsonProperty("spineDirectoryPath")]
		public string SpineDirectoryPath { get; set; }
		[JsonProperty("spineName")]
		public string SpineName { get; set; }
		[JsonProperty("atlasName")]
		public string AtlasName { get; set; }
		[JsonProperty("myPageBgFileName")]
		public string MyPageBgFileName { get; set; }
		[JsonProperty("expType")]
		public int ExpType { get; set; }
		[JsonProperty("materialType")]
		public int MaterialType { get; set; }
		[JsonProperty("exceedLimitType")]
		public int ExceedLimitType { get; set; }
		[JsonProperty("maxLevel0")]
		public int MaxLevel0 { get; set; }
		[JsonProperty("maxLevel1")]
		public int MaxLevel1 { get; set; }
		[JsonProperty("maxLevel2")]
		public int MaxLevel2 { get; set; }
		[JsonProperty("maxLevel3")]
		public int MaxLevel3 { get; set; }
		[JsonProperty("maxLevel4")]
		public int MaxLevel4 { get; set; }
		[JsonProperty("minHp")]
		public int MinHp { get; set; }
		[JsonProperty("maxHp0")]
		public int MaxHp0 { get; set; }
		[JsonProperty("maxHp1")]
		public int MaxHp1 { get; set; }
		[JsonProperty("maxHp2")]
		public int MaxHp2 { get; set; }
		[JsonProperty("maxHp3")]
		public int MaxHp3 { get; set; }
		[JsonProperty("maxHp4")]
		public int MaxHp4 { get; set; }
		[JsonProperty("maxAddHp")]
		public int MaxAddHp { get; set; }
		[JsonProperty("maxFortifyHp")]
		public int MaxFortifyHp { get; set; }
		[JsonProperty("minAtk")]
		public int MinAtk { get; set; }
		[JsonProperty("maxAtk0")]
		public int MaxAtk0 { get; set; }
		[JsonProperty("maxAtk1")]
		public int MaxAtk1 { get; set; }
		[JsonProperty("maxAtk2")]
		public int MaxAtk2 { get; set; }
		[JsonProperty("maxAtk3")]
		public int MaxAtk3 { get; set; }
		[JsonProperty("maxAtk4")]
		public int MaxAtk4 { get; set; }
		[JsonProperty("maxAddAtk")]
		public int MaxAddAtk { get; set; }
		[JsonProperty("maxFortifyAtk")]
		public int MaxFortifyAtk { get; set; }
		[JsonProperty("minDef")]
		public int MinDef { get; set; }
		[JsonProperty("maxDef0")]
		public int MaxDef0 { get; set; }
		[JsonProperty("maxDef1")]
		public int MaxDef1 { get; set; }
		[JsonProperty("maxDef2")]
		public int MaxDef2 { get; set; }
		[JsonProperty("maxDef3")]
		public int MaxDef3 { get; set; }
		[JsonProperty("maxDef4")]
		public int MaxDef4 { get; set; }
		[JsonProperty("maxAddDef")]
		public int MaxAddDef { get; set; }
		[JsonProperty("maxFortifyDef")]
		public int MaxFortifyDef { get; set; }
		[JsonProperty("minLuck")]
		public int MinLuck { get; set; }
		[JsonProperty("maxLuck0")]
		public int MaxLuck0 { get; set; }
		[JsonProperty("maxLuck1")]
		public int MaxLuck1 { get; set; }
		[JsonProperty("maxLuck2")]
		public int MaxLuck2 { get; set; }
		[JsonProperty("maxLuck3")]
		public int MaxLuck3 { get; set; }
		[JsonProperty("maxLuck4")]
		public int MaxLuck4 { get; set; }
		[JsonProperty("maxAddLuck")]
		public int MaxAddLuck { get; set; }
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
		[JsonProperty("visibleDate")]
		public string VisibleDate { get; set; }
	}

	public class CharacterMaterialModel
	{
		[JsonProperty("materialType")]
		public int MaterialType { get; set; }
		[JsonProperty("addExp")]
		public int AddExp { get; set; }
		[JsonProperty("addHp")]
		public int AddHp { get; set; }
		[JsonProperty("addAtk")]
		public int AddAtk { get; set; }
		[JsonProperty("addDef")]
		public int AddDef { get; set; }
		[JsonProperty("addExceedLimitExp")]
		public int AddExceedLimitExp { get; set; }
		[JsonProperty("addSkillUpRate")]
		public int AddSkillUpRate { get; set; }
	}

	public class CharacterModel
	{
		[JsonProperty("abilityEffectModelArray")]
		public List<dynamic> AbilityEffectModelArray { get; set; }
		[JsonProperty("abilityGroupId")]
		public int AbilityGroupId { get; set; }
		[JsonProperty("abilityLevel1")]
		public int AbilityLevel1 { get; set; }
		[JsonProperty("abilityLevel2")]
		public int AbilityLevel2 { get; set; }
		[JsonProperty("abilityLevel3")]
		public int AbilityLevel3 { get; set; }
		[JsonProperty("addAtk")]
		public int AddAtk { get; set; }
		[JsonProperty("addDef")]
		public int AddDef { get; set; }
		[JsonProperty("addExceedLimitExp")]
		public int AddExceedLimitExp { get; set; }
		[JsonProperty("addExp")]
		public int AddExp { get; set; }
		[JsonProperty("addHp")]
		public int AddHp { get; set; }
		[JsonProperty("addRarity")]
		public int AddRarity { get; set; }
		[JsonProperty("addSkillUpRate")]
		public int AddSkillUpRate { get; set; }
		[JsonProperty("atk")]
		public int Atk { get; set; }
		[JsonProperty("atkRate")]
		public int AtkRate { get; set; }
		[JsonProperty("attribute")]
		public int Attribute { get; set; }
		[JsonProperty("availableEquipmentModelList")]
		public List<dynamic> AvailableEquipmentModelList { get; set; }
		[JsonProperty("availableEquipmentProtectorModelList")]
		public List<dynamic> AvailableEquipmentProtectorModelList { get; set; }
		[JsonProperty("availableEquipmentWeaponModelList")]
		public List<dynamic> AvailableEquipmentWeaponModelList { get; set; }
		[JsonProperty("awakeGroupMaster")]
		public dynamic AwakeGroupMaster { get; set; }
		[JsonProperty("awakeIds")]
		public List<dynamic> AwakeIds { get; set; }
		[JsonProperty("awakeMainMasterArray")]
		public List<dynamic> AwakeMainMasterArray { get; set; }
		[JsonProperty("baseRarity")]
		public int BaseRarity { get; set; }
		[JsonProperty("baseSkillFortifyType")]
		public int BaseSkillFortifyType { get; set; }
		[JsonProperty("battleCount")]
		public int BattleCount { get; set; }
		[JsonProperty("characterCd")]
		public string CharacterCd { get; set; }
		[JsonProperty("characterEquipmentInfoArray")]
		public List<dynamic> CharacterEquipmentInfoArray { get; set; }
		[JsonProperty("characterEvolutionMainMaster")]
		public CharacterEvolutionMainModel CharacterEvolutionMainMaster { get; set; }
		[JsonProperty("characterExceedLimitMaster")]
		public CharacterExceedLimitModel CharacterExceedLimitMaster { get; set; }
		[JsonProperty("characterExceedLimitMasterArray")]
		public List<CharacterExceedLimitModel> CharacterExceedLimitMasterArray { get; set; }
		[JsonProperty("characterExceedLimitMasterMap")]
		public Dictionary<string, CharacterExceedLimitModel> CharacterExceedLimitMasterMap { get; set; }
		[JsonProperty("characterExp")]
		public int CharacterExp { get; set; }
		[JsonProperty("characterGroupId")]
		public int CharacterGroupId { get; set; }
		[JsonProperty("characterId")]
		public int CharacterId { get; set; }
		[JsonProperty("characterLevelMaster")]
		public int CharacterLevelMaster { get; set; }
		[JsonProperty("characterLinkByPriority")]
		public int CharacterLinkByPriority { get; set; }
		[JsonProperty("characterLinkUnitArray")]
		public List<CharacterLinkUnitModel> CharacterLinkUnitArray { get; set; }
		[JsonProperty("characterMaterialMaster")]
		public CharacterMaterialModel CharacterMaterialMaster { get; set; }
		[JsonProperty("characterNormalAttackMaster")]
		public CharacterNormalAttackModel CharacterNormalAttackMaster { get; set; }
		[JsonProperty("characterSkillInfo")]
		public dynamic CharacterSkillInfo { get; set; }
		[JsonProperty("characterType")]
		public int CharacterType { get; set; }
		[JsonProperty("contentsGroupId")]
		public int ContentsGroupId { get; set; }
		[JsonProperty("costumeId")]
		public int CostumeId { get; set; }
		[JsonProperty("def")]
		public int Def { get; set; }
		[JsonProperty("defRate")]
		public int DefRate { get; set; }
		[JsonProperty("enabledAwakeEffectMasterArray")]
		public List<dynamic> EnabledAwakeEffectMasterArray { get; set; }
		[JsonProperty("enabledAwakeMainMasterArray")]
		public List<dynamic> EnabledAwakeMainMasterArray { get; set; }
		[JsonProperty("equipmentProtectorCds")]
		public List<dynamic> EquipmentProtectorCds { get; set; }
		[JsonProperty("equipmentWeaponCds")]
		public List<string> EquipmentWeaponCds { get; set; }
		[JsonProperty("eventBoost")]
		public dynamic EventBoost { get; set; }
		[JsonProperty("exceedLimit")]
		public int ExceedLimit { get; set; }
		[JsonProperty("exceedLimitAlternateId")]
		public int ExceedLimitAlternateId { get; set; }
		[JsonProperty("exceedLimitExp")]
		public int ExceedLimitExp { get; set; }
		[JsonProperty("exceedLimitMaterialCount")]
		public int ExceedLimitMaterialCount { get; set; }
		[JsonProperty("exceedLimitMaterialId")]
		public int ExceedLimitMaterialId { get; set; }
		[JsonProperty("exceedLimitMaxCount")]
		public int ExceedLimitMaxCount { get; set; }
		[JsonProperty("exceedLimitPrice")]
		public int ExceedLimitPrice { get; set; }
		[JsonProperty("exceedLimitType")]
		public int ExceedLimitType { get; set; }
		[JsonProperty("exp")]
		public int Exp { get; set; }
		[JsonProperty("expRateForNextLevel")]
		public int ExpRateForNextLevel { get; set; }
		[JsonProperty("forceOriginalCharacterId")]
		public int ForceOriginalCharacterId { get; set; }
		[JsonProperty("forceOriginalCharacterMainMaster")]
		public dynamic ForceOriginalCharacterMainMaster { get; set; }
		[JsonProperty("forceOriginalGroupId")]
		public int ForceOriginalGroupId { get; set; }
		[JsonProperty("fortifyPrice")]
		public int FortifyPrice { get; set; }
		[JsonProperty("hasSubAttribute")]
		public int HasSubAttribute { get; set; }
		[JsonProperty("hp")]
		public int Hp { get; set; }
		[JsonProperty("hpRate")]
		public int HpRate { get; set; }
		[JsonProperty("isAvailableEvolution")]
		public bool IsAvailableEvolution { get; set; }
		[JsonProperty("isCompleteAwake")]
		public bool IsCompleteAwake { get; set; }
		[JsonProperty("isCompleteEvolutionCondition")]
		public bool IsCompleteEvolutionCondition { get; set; }
		[JsonProperty("isCompleteEvolutionMaterial")]
		public bool IsCompleteEvolutionMaterial { get; set; }
		[JsonProperty("isDeckUnit")]
		public bool IsDeckUnit { get; set; }
		[JsonProperty("isFortifyMaterial")]
		public bool IsFortifyMaterial { get; set; }
		[JsonProperty("isLevelMax")]
		public bool IsLevelMax { get; set; }
		[JsonProperty("isMaxExceedLimit")]
		public int IsMaxExceedLimit { get; set; }
		[JsonProperty("isProtect")]
		public int IsProtect { get; set; }
		[JsonProperty("isSellMaterial")]
		public bool IsSellMaterial { get; set; }
		[JsonProperty("isSkillMaterial")]
		public bool IsSkillMaterial { get; set; }
		[JsonProperty("level")]
		public int Level { get; set; }
		[JsonProperty("materialType")]
		public int MaterialType { get; set; }
		[JsonProperty("maxFortifyAtk")]
		public int MaxFortifyAtk { get; set; }
		[JsonProperty("maxFortifyDef")]
		public int MaxFortifyDef { get; set; }
		[JsonProperty("maxFortifyHp")]
		public int MaxFortifyHp { get; set; }
		[JsonProperty("maxLevel")]
		public int MaxLevel { get; set; }
		[JsonProperty("maxSkillLevel")]
		public int MaxSkillLevel { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("needExpForNextExceedLimit")]
		public int NeedExpForNextExceedLimit { get; set; }
		[JsonProperty("needExpForNextLevel")]
		public int NeedExpForNextLevel { get; set; }
		[JsonProperty("nextCharacterEvolutionMainMaster")]
		public dynamic NextCharacterEvolutionMainMaster { get; set; }
		[JsonProperty("order")]
		public int Order { get; set; }
		[JsonProperty("pictureBookDetailModel")]
		public PictureBookDetailModel PictureBookDetailModel { get; set; }
		[JsonProperty("rarity")]
		public int Rarity { get; set; }
		[JsonProperty("registerDate")]
		public string RegisterDate { get; set; }
		[JsonProperty("salePrice")]
		public int SalePrice { get; set; }
		[JsonProperty("shortName")]
		public string ShortName { get; set; }
		[JsonProperty("skillEffectMasterMap")]
		public Dictionary<string, dynamic> SkillEffectMasterMap { get; set; }
		[JsonProperty("skillEffectModelArray")]
		public List<dynamic> SkillEffectModelArray { get; set; }
		[JsonProperty("skillFortifyType")]
		public int SkillFortifyType { get; set; }
		[JsonProperty("skillId")]
		public int SkillId { get; set; }
		[JsonProperty("skillLevel")]
		public int SkillLevel { get; set; }
		[JsonProperty("skillMainMaster")]
		public dynamic SkillMainMaster { get; set; }
		[JsonProperty("skillName")]
		public string SkillName { get; set; }
		[JsonProperty("skillShortText")]
		public string SkillShortText { get; set; }
		[JsonProperty("skillText")]
		public string SkillText { get; set; }
		[JsonProperty("skinName")]
		public string SkinName { get; set; }
		[JsonProperty("spineDirectoryPath")]
		public string SpineDirectoryPath { get; set; }
		[JsonProperty("spineName")]
		public string SpineName { get; set; }
		[JsonProperty("subAttribute")]
		public int SubAttribute { get; set; }
		[JsonProperty("subAttributePower")]
		public int SubAttributePower { get; set; }
		[JsonProperty("totalAtkExceptEquipEffect")]
		public dynamic TotalAtkExceptEquipEffect { get; set; }
		[JsonProperty("totalBasePower")]
		public int TotalBasePower { get; set; }
		[JsonProperty("totalDefExceptEquipEffect")]
		public dynamic TotalDefExceptEquipEffect { get; set; }
		[JsonProperty("totalHpExceptEquipEffect")]
		public dynamic TotalHpExceptEquipEffect { get; set; }
		[JsonProperty("totalStatus")]
		public dynamic TotalStatus { get; set; }
		[JsonProperty("userAbilityGroupModel")]
		public dynamic UserAbilityGroupModel { get; set; }
		[JsonProperty("userSkillEffectModelArray")]
		public List<dynamic> UserSkillEffectModelArray { get; set; }
		[JsonProperty("userSkillMainModel")]
		public dynamic UserSkillMainModel { get; set; }
	}

	public class CharacterNormalAttackModel
	{
		[JsonProperty("aniName")]
		public string AniName { get; set; }
		[JsonProperty("effectShowType")]
		public int EffectShowType { get; set; }
		[JsonProperty("effectShowValue")]
		public double EffectShowValue { get; set; }
		[JsonProperty("hitEffectAniName")]
		public string HitEffectAniName { get; set; }
		[JsonProperty("hitEffectName")]
		public string HitEffectName { get; set; }
		[JsonProperty("normalAttackId")]
		public int NormalAttackId { get; set; }
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
		[JsonProperty("spineDirectoryPath")]
		public string SpineDirectoryPath { get; set; }
	}

	public class CharacterSellBonusModel
	{
		[JsonProperty("rarity")]
		public int Rarity { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
		[JsonProperty("itemId")]
		public int ItemId { get; set; }
		[JsonProperty("count")]
		public int Count { get; set; }
	}

	public class CharacterSkillEffectModel
	{
		[JsonProperty("a")]
		public int A { get; set; }
		[JsonProperty("actionType")]
		public int ActionType { get; set; }
		[JsonProperty("b")]
		public int B { get; set; }
		[JsonProperty("c")]
		public int C { get; set; }
		[JsonProperty("d")]
		public string D { get; set; }
		[JsonProperty("e")]
		public string E { get; set; }
		[JsonProperty("effectConditionType")]
		public int EffectConditionType { get; set; }
		[JsonProperty("effectConditionValue")]
		public string EffectConditionValue { get; set; }
		[JsonProperty("effectLimit")]
		public int EffectLimit { get; set; }
		[JsonProperty("effectType")]
		public int EffectType { get; set; }
		[JsonProperty("effectValue")]
		public int EffectValue { get; set; }
		[JsonProperty("endType")]
		public int EndType { get; set; }
		[JsonProperty("endValue")]
		public string EndValue { get; set; }
		[JsonProperty("f")]
		public int F { get; set; }
		[JsonProperty("g")]
		public int G { get; set; }
		[JsonProperty("h")]
		public int H { get; set; }
		[JsonProperty("i")]
		public int I { get; set; }
		[JsonProperty("index")]
		public int Index { get; set; }
		[JsonProperty("j")]
		public int J { get; set; }
		[JsonProperty("k")]
		public string K { get; set; }
		[JsonProperty("l")]
		public int L { get; set; }
		[JsonProperty("level")]
		public int Level { get; set; }
		[JsonProperty("m")]
		public int M { get; set; }
		[JsonProperty("n")]
		public int N { get; set; }
		[JsonProperty("o")]
		public string O { get; set; }
		[JsonProperty("occurrenceRate")]
		public int OccurrenceRate { get; set; }
		[JsonProperty("p")]
		public int P { get; set; }
		[JsonProperty("q")]
		public string Q { get; set; }
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
		[JsonProperty("shortText")]
		public string ShortText { get; set; }
		[JsonProperty("skillId")]
		public int SkillId { get; set; }
		[JsonProperty("successRate")]
		public int SuccessRate { get; set; }
		[JsonProperty("targetType")]
		public int TargetType { get; set; }
		[JsonProperty("targetValue")]
		public string TargetValue { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
	}

	public class CharacterSkillMainModel
	{
		[JsonProperty("skillId")]
		public int SkillId { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("effectShowType")]
		public int EffectShowType { get; set; }
		[JsonProperty("spineDirectoryPath")]
		public string SpineDirectoryPath { get; set; }
		[JsonProperty("spineName")]
		public string SpineName { get; set; }
		[JsonProperty("aniName")]
		public string AniName { get; set; }
		[JsonProperty("hitEffectName")]
		public string HitEffectName { get; set; }
		[JsonProperty("hitEffectAniName")]
		public string HitEffectAniName { get; set; }
		[JsonProperty("bgmVolumeAmount")]
		public double BgmVolumeAmount { get; set; }
		[JsonProperty("skillFortifyType")]
		public int SkillFortifyType { get; set; }
	}

	public class CharacterSkillUpModel
	{
		[JsonProperty("skillFortifyType")]
		public int SkillFortifyType { get; set; }
		[JsonProperty("level")]
		public int Level { get; set; }
		[JsonProperty("addSkillUpRate1")]
		public int AddSkillUpRate1 { get; set; }
		[JsonProperty("addSkillUpRate2")]
		public int AddSkillUpRate2 { get; set; }
		[JsonProperty("addSkillUpRate3")]
		public int AddSkillUpRate3 { get; set; }
		[JsonProperty("addSkillUpRate4")]
		public int AddSkillUpRate4 { get; set; }
		[JsonProperty("price")]
		public int Price { get; set; }
	}

	public class CharacterSkillUpRateModel
	{
		[JsonProperty("luckTotal")]
		public int LuckTotal { get; set; }
		[JsonProperty("skillLevel")]
		public int SkillLevel { get; set; }
		[JsonProperty("rate")]
		public int Rate { get; set; }
	}

	public class CharacterStandPositionModel
	{
		[JsonProperty("characterId")]
		public int CharacterId { get; set; }
		[JsonProperty("standHeadPositionX")]
		public int StandHeadPositionX { get; set; }
		[JsonProperty("standHeadPositionY")]
		public int StandHeadPositionY { get; set; }
		[JsonProperty("atlasHeadPositionX")]
		public int AtlasHeadPositionX { get; set; }
		[JsonProperty("atlasHeadPositionY")]
		public int AtlasHeadPositionY { get; set; }
		[JsonProperty("spinePositionX")]
		public int SpinePositionX { get; set; }
		[JsonProperty("spinePositionY")]
		public int SpinePositionY { get; set; }
	}

	public class CharacterTextModel
	{
		[JsonProperty("characterId")]
		public int CharacterId { get; set; }
		[JsonProperty("groupType")]
		public int GroupType { get; set; }
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
		[JsonProperty("sceneType")]
		public int SceneType { get; set; }
		[JsonProperty("skinName")]
		public string SkinName { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
		[JsonProperty("textId")]
		public int TextId { get; set; }
		[JsonProperty("title")]
		public string Title { get; set; }
		[JsonProperty("voiceFile")]
		public string VoiceFile { get; set; }
	}

	public class ComebackGachaModel
	{
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
		[JsonProperty("gachaId")]
		public int GachaId { get; set; }
		[JsonProperty("campaignId")]
		public int CampaignId { get; set; }
	}

	public class ComebackGroupModel
	{
		[JsonProperty("campaignGroupId")]
		public int CampaignGroupId { get; set; }
		[JsonProperty("fromDate")]
		public string FromDate { get; set; }
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
		[JsonProperty("toDate")]
		public string ToDate { get; set; }
	}

	public class ComebackLoginBonusModel
	{
		[JsonProperty("campaignId")]
		public int CampaignId { get; set; }
		[JsonProperty("loginBonusId")]
		public int LoginBonusId { get; set; }
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
	}

	public class ComebackMainModel
	{
		[JsonProperty("campaignGroupId")]
		public int CampaignGroupId { get; set; }
		[JsonProperty("campaignId")]
		public int CampaignId { get; set; }
		[JsonProperty("fromBlank")]
		public int FromBlank { get; set; }
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
		[JsonProperty("toBlank")]
		public int ToBlank { get; set; }
	}

	public class ComebackModel
	{
		[JsonProperty("campaignId")]
		public int CampaignId { get; set; }
		[JsonProperty("igniteDate")]
		public string IgniteDate { get; set; }
	}

	public class ComebackNewsModel
	{
		[JsonProperty("campaignId")]
		public int CampaignId { get; set; }
		[JsonProperty("newsId")]
		public int NewsId { get; set; }
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
	}

	public class ComebackPopupModel
	{
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
		[JsonProperty("popupId")]
		public int PopupId { get; set; }
		[JsonProperty("campaignId")]
		public int CampaignId { get; set; }
	}

	public class ComebackShopModel
	{
		[JsonProperty("campaignId")]
		public int CampaignId { get; set; }
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
		[JsonProperty("shopId")]
		public int ShopId { get; set; }
	}

	public class DeckModel
	{
		[JsonProperty("characterModel")]
		public CharacterModel CharacterModel { get; set; }
		[JsonProperty("characterCd")]
		public string CharacterCd { get; set; }
		[JsonProperty("deckId")]
		public int DeckId { get; set; }
		[JsonProperty("position")]
		public int Position { get; set; }
		[JsonProperty("deckType")]
		public int DeckType { get; set; }
		[JsonProperty("roleType")]
		public int RoleType { get; set; }
	}

	public class DmmModel
	{
		[JsonProperty("skuId")]
		public int SkuId { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("iconName")]
		public string IconName { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
		[JsonProperty("price")]
		public int Price { get; set; }
		[JsonProperty("purchaseType")]
		public int PurchaseType { get; set; }
	}

	public class EnemyAbilityConditionModel
	{
		[JsonProperty("abilityId")]
		public int AbilityId { get; set; }
		[JsonProperty("conditionGroup")]
		public int ConditionGroup { get; set; }
		[JsonProperty("conditionType")]
		public int ConditionType { get; set; }
		[JsonProperty("conditionValue")]
		public int ConditionValue { get; set; }
	}

	public class EquipmentAbilityConditionModel
	{
		[JsonProperty("equipmentId")]
		public int EquipmentId { get; set; }
		[JsonProperty("conditionGroup")]
		public int ConditionGroup { get; set; }
		[JsonProperty("conditionType")]
		public int ConditionType { get; set; }
		[JsonProperty("conditionValue")]
		public int ConditionValue { get; set; }
	}

	public class EquipmentEffectModel
	{
		[JsonProperty("actionType")]
		public int ActionType { get; set; }
		[JsonProperty("boostType")]
		public int BoostType { get; set; }
		[JsonProperty("effectConditionType")]
		public int EffectConditionType { get; set; }
		[JsonProperty("effectConditionValue")]
		public string EffectConditionValue { get; set; }
		[JsonProperty("effectLimit")]
		public int EffectLimit { get; set; }
		[JsonProperty("effectType")]
		public int EffectType { get; set; }
		[JsonProperty("effectValue")]
		public int EffectValue { get; set; }
		[JsonProperty("endType")]
		public int EndType { get; set; }
		[JsonProperty("endValue")]
		public string EndValue { get; set; }
		[JsonProperty("equipmentId")]
		public int EquipmentId { get; set; }
		[JsonProperty("index")]
		public int Index { get; set; }
		[JsonProperty("level")]
		public int Level { get; set; }
		[JsonProperty("occurrenceRate")]
		public int OccurrenceRate { get; set; }
		[JsonProperty("rarity")]
		public int Rarity { get; set; }
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
		[JsonProperty("successRate")]
		public int SuccessRate { get; set; }
		[JsonProperty("targetType")]
		public int TargetType { get; set; }
		[JsonProperty("targetValue")]
		public string TargetValue { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
	}

	public class EquipmentExceedLimitItemModel
	{
		[JsonProperty("exceedLimitItemType")]
		public int ExceedLimitItemType { get; set; }
		[JsonProperty("rarity")]
		public int Rarity { get; set; }
		[JsonProperty("materialId")]
		public int MaterialId { get; set; }
		[JsonProperty("count")]
		public int Count { get; set; }
		[JsonProperty("exceedLimitPrice")]
		public int ExceedLimitPrice { get; set; }
	}

	public class EquipmentExceedLimitModel
	{
		[JsonProperty("exceedLimitType")]
		public int ExceedLimitType { get; set; }
		[JsonProperty("rarity")]
		public int Rarity { get; set; }
		[JsonProperty("materialRarity")]
		public int MaterialRarity { get; set; }
		[JsonProperty("exceedLimitPrice")]
		public int ExceedLimitPrice { get; set; }
	}

	public class EquipmentLevelModel
	{
		[JsonProperty("expType")]
		public int ExpType { get; set; }
		[JsonProperty("level")]
		public int Level { get; set; }
		[JsonProperty("totalExp")]
		public int TotalExp { get; set; }
		[JsonProperty("nextLevelExp")]
		public int NextLevelExp { get; set; }
		[JsonProperty("fortifyPrice")]
		public int FortifyPrice { get; set; }
		[JsonProperty("salePrice")]
		public int SalePrice { get; set; }
	}

	public class EquipmentMainModel
	{
		[JsonProperty("maxDef2")]
		public int MaxDef2 { get; set; }
		[JsonProperty("maxDef3")]
		public int MaxDef3 { get; set; }
		[JsonProperty("exceedLimitType")]
		public int ExceedLimitType { get; set; }
		[JsonProperty("maxAtk4")]
		public int MaxAtk4 { get; set; }
		[JsonProperty("maxAtk3")]
		public int MaxAtk3 { get; set; }
		[JsonProperty("maxAtk2")]
		public int MaxAtk2 { get; set; }
		[JsonProperty("maxAtk1")]
		public int MaxAtk1 { get; set; }
		[JsonProperty("materialType")]
		public int MaterialType { get; set; }
		[JsonProperty("minDef2")]
		public int MinDef2 { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
		[JsonProperty("equipmentId")]
		public int EquipmentId { get; set; }
		[JsonProperty("equipmentGroupId")]
		public int EquipmentGroupId { get; set; }
		[JsonProperty("maxDef1")]
		public int MaxDef1 { get; set; }
		[JsonProperty("minAtk1")]
		public int MinAtk1 { get; set; }
		[JsonProperty("maxLevel4")]
		public int MaxLevel4 { get; set; }
		[JsonProperty("maxHp2")]
		public int MaxHp2 { get; set; }
		[JsonProperty("maxHp3")]
		public int MaxHp3 { get; set; }
		[JsonProperty("maxLevel1")]
		public int MaxLevel1 { get; set; }
		[JsonProperty("minAtk4")]
		public int MinAtk4 { get; set; }
		[JsonProperty("maxLevel3")]
		public int MaxLevel3 { get; set; }
		[JsonProperty("maxLevel2")]
		public int MaxLevel2 { get; set; }
		[JsonProperty("uniqueId")]
		public string UniqueId { get; set; }
		[JsonProperty("attribute")]
		public int Attribute { get; set; }
		[JsonProperty("minDef4")]
		public int MinDef4 { get; set; }
		[JsonProperty("maxHp1")]
		public int MaxHp1 { get; set; }
		[JsonProperty("minAtk3")]
		public int MinAtk3 { get; set; }
		[JsonProperty("uniqueType")]
		public int UniqueType { get; set; }
		[JsonProperty("minAtk2")]
		public int MinAtk2 { get; set; }
		[JsonProperty("triggerType")]
		public int TriggerType { get; set; }
		[JsonProperty("maxHp4")]
		public int MaxHp4 { get; set; }
		[JsonProperty("minDef1")]
		public int MinDef1 { get; set; }
		[JsonProperty("minHp2")]
		public int MinHp2 { get; set; }
		[JsonProperty("minHp3")]
		public int MinHp3 { get; set; }
		[JsonProperty("minHp1")]
		public int MinHp1 { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("minHp4")]
		public int MinHp4 { get; set; }
		[JsonProperty("minDef3")]
		public int MinDef3 { get; set; }
		[JsonProperty("equipmentType")]
		public int EquipmentType { get; set; }
		[JsonProperty("rarity")]
		public int Rarity { get; set; }
		[JsonProperty("exceedLimitItemType")]
		public int ExceedLimitItemType { get; set; }
		[JsonProperty("maxDef4")]
		public int MaxDef4 { get; set; }
		[JsonProperty("triggerValue")]
		public string TriggerValue { get; set; }
		[JsonProperty("resourceId")]
		public int ResourceId { get; set; }
		[JsonProperty("postName")]
		public string PostName { get; set; }
		[JsonProperty("invokeLimitCount")]
		public int InvokeLimitCount { get; set; }
	}

	public class EquipmentMaterialModel
	{
		[JsonProperty("materialType")]
		public int MaterialType { get; set; }
		[JsonProperty("addExp")]
		public int AddExp { get; set; }
	}

	public class EquipmentModel
	{
		[JsonProperty("addExp")]
		public int AddExp { get; set; }
		[JsonProperty("attribute")]
		public int Attribute { get; set; }
		[JsonProperty("baseRarity")]
		public int BaseRarity { get; set; }
		[JsonProperty("effectTextForBoost")]
		public string EffectTextForBoost { get; set; }
		[JsonProperty("effectTextForNormal")]
		public string EffectTextForNormal { get; set; }
		[JsonProperty("equipmentCd")]
		public string EquipmentCd { get; set; }
		[JsonProperty("equipmentEffectInfoMap")]
		public Dictionary<string, dynamic> EquipmentEffectInfoMap { get; set; }
		[JsonProperty("equipmentEffectMaster")]
		public EquipmentEffectModel EquipmentEffectMaster { get; set; }
		[JsonProperty("equipmentExceedLimitItemMaster")]
		public EquipmentExceedLimitItemModel EquipmentExceedLimitItemMaster { get; set; }
		[JsonProperty("equipmentGroupId")]
		public int EquipmentGroupId { get; set; }
		[JsonProperty("equipmentId")]
		public int EquipmentId { get; set; }
		[JsonProperty("equipmentLevelMaster")]
		public int EquipmentLevelMaster { get; set; }
		[JsonProperty("equipmentMainMaster")]
		public EquipmentMainModel EquipmentMainMaster { get; set; }
		[JsonProperty("equipmentMaterialMaster")]
		public EquipmentMaterialModel EquipmentMaterialMaster { get; set; }
		[JsonProperty("equipmentType")]
		public int EquipmentType { get; set; }
		[JsonProperty("exceedLimit")]
		public int ExceedLimit { get; set; }
		[JsonProperty("exceedLimitItemType")]
		public int ExceedLimitItemType { get; set; }
		[JsonProperty("exceedLimitType")]
		public int ExceedLimitType { get; set; }
		[JsonProperty("exp")]
		public int Exp { get; set; }
		[JsonProperty("fortifyLevel")]
		public int FortifyLevel { get; set; }
		[JsonProperty("fortifyMaxLevel")]
		public int FortifyMaxLevel { get; set; }
		[JsonProperty("fortifyPrice")]
		public int FortifyPrice { get; set; }
		[JsonProperty("isCharacterEquipment")]
		public bool IsCharacterEquipment { get; set; }
		[JsonProperty("isLevelMax")]
		public bool IsLevelMax { get; set; }
		[JsonProperty("isMaxRarity")]
		public int IsMaxRarity { get; set; }
		[JsonProperty("isProtect")]
		public int IsProtect { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
		[JsonProperty("level")]
		public int Level { get; set; }
		[JsonProperty("materialType")]
		public int MaterialType { get; set; }
		[JsonProperty("maxAtk")]
		public int MaxAtk { get; set; }
		[JsonProperty("maxDef")]
		public int MaxDef { get; set; }
		[JsonProperty("maxHp")]
		public int MaxHp { get; set; }
		[JsonProperty("maxLevel")]
		public int MaxLevel { get; set; }
		[JsonProperty("minAtk")]
		public int MinAtk { get; set; }
		[JsonProperty("minDef")]
		public int MinDef { get; set; }
		[JsonProperty("minHp")]
		public int MinHp { get; set; }
		[JsonProperty("modelType")]
		public int ModelType { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("needMaterials")]
		public dynamic NeedMaterials { get; set; }
		[JsonProperty("rarity")]
		public int Rarity { get; set; }
		[JsonProperty("registerDate")]
		public string RegisterDate { get; set; }
		[JsonProperty("salePrice")]
		public int SalePrice { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
		[JsonProperty("uniqueType")]
		public int UniqueType { get; set; }
	}

	public class EquipmentTimeModel
	{
		[JsonProperty("equipmentGroupId")]
		public int EquipmentGroupId { get; set; }
		[JsonProperty("fromDate")]
		public string FromDate { get; set; }
		[JsonProperty("toDate")]
		public string ToDate { get; set; }
	}

	public class ErrorModel
	{
		[JsonProperty("errorCode")]
		public dynamic ErrorCode { get; set; }
		[JsonProperty("message")]
		public string Message { get; set; }
		[JsonProperty("handlingType")]
		public int HandlingType { get; set; }
	}

	public class EventBoostCharacterModel
	{
		[JsonProperty("eventId")]
		public int EventId { get; set; }
		[JsonProperty("effectGroupId")]
		public int EffectGroupId { get; set; }
		[JsonProperty("characterId")]
		public int CharacterId { get; set; }
		[JsonProperty("subEffectGroupId")]
		public int SubEffectGroupId { get; set; }
	}

	public class EventBoostEffectModel
	{
		[JsonProperty("groupId")]
		public int GroupId { get; set; }
		[JsonProperty("effectType")]
		public int EffectType { get; set; }
		[JsonProperty("addType")]
		public int AddType { get; set; }
		[JsonProperty("conditionType")]
		public int ConditionType { get; set; }
		[JsonProperty("conditionId")]
		public string ConditionId { get; set; }
		[JsonProperty("value1")]
		public dynamic Value1 { get; set; }
		[JsonProperty("value2")]
		public dynamic Value2 { get; set; }
		[JsonProperty("value3")]
		public dynamic Value3 { get; set; }
		[JsonProperty("value4")]
		public dynamic Value4 { get; set; }
	}

	public class EventCharacterModel
	{
		[JsonProperty("characterId")]
		public int CharacterId { get; set; }
		[JsonProperty("eventId")]
		public int EventId { get; set; }
		[JsonProperty("order")]
		public int Order { get; set; }
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
	}

	public class EventDamageRewardModel
	{
		[JsonProperty("count")]
		public int Count { get; set; }
		[JsonProperty("eventId")]
		public int EventId { get; set; }
		[JsonProperty("eventItemId")]
		public int EventItemId { get; set; }
		[JsonProperty("itemId")]
		public int ItemId { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
		[JsonProperty("point")]
		public int Point { get; set; }
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
	}

	public class EventFriendshipCharacterModel
	{
		[JsonProperty("friendshipGroupId")]
		public int FriendshipGroupId { get; set; }
		[JsonProperty("characterGroupId")]
		public int CharacterGroupId { get; set; }
		[JsonProperty("characterId")]
		public int CharacterId { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
		[JsonProperty("itemId")]
		public int ItemId { get; set; }
	}

	public class EventFriendshipModel
	{
		[JsonProperty("eventId")]
		public int EventId { get; set; }
		[JsonProperty("friendshipGroupId")]
		public int FriendshipGroupId { get; set; }
	}

	public class EventFriendshipRewardModel
	{
		[JsonProperty("characterGroupId")]
		public int CharacterGroupId { get; set; }
		[JsonProperty("count")]
		public int Count { get; set; }
		[JsonProperty("friendshipGroupId")]
		public int FriendshipGroupId { get; set; }
		[JsonProperty("itemId")]
		public int ItemId { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
		[JsonProperty("point")]
		public int Point { get; set; }
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
	}

	public class EventHelpModel
	{
		[JsonProperty("descriptionText")]
		public string DescriptionText { get; set; }
		[JsonProperty("eventId")]
		public int EventId { get; set; }
		[JsonProperty("fileName")]
		public string FileName { get; set; }
		[JsonProperty("order")]
		public int Order { get; set; }
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
	}

	public class EventItemModel
	{
		[JsonProperty("eventId")]
		public int EventId { get; set; }
		[JsonProperty("itemId")]
		public int ItemId { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
	}

	public class EventMainModel
	{
		[JsonProperty("eventId")]
		public int EventId { get; set; }
		[JsonProperty("eventType")]
		public int EventType { get; set; }
		[JsonProperty("worldId")]
		public int WorldId { get; set; }
		[JsonProperty("index")]
		public int Index { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("fromDate")]
		public string FromDate { get; set; }
		[JsonProperty("toDate")]
		public string ToDate { get; set; }
		[JsonProperty("maxUnlockCount")]
		public int MaxUnlockCount { get; set; }
		[JsonProperty("conditionType")]
		public int ConditionType { get; set; }
		[JsonProperty("conditionFrom")]
		public int ConditionFrom { get; set; }
		[JsonProperty("conditionTo")]
		public int ConditionTo { get; set; }
		[JsonProperty("gachaId")]
		public int GachaId { get; set; }
		[JsonProperty("isNotice")]
		public int IsNotice { get; set; }
		[JsonProperty("anotherEventId")]
		public int AnotherEventId { get; set; }
	}

	public class EventMemorialModel
	{
		[JsonProperty("memorialId")]
		public int MemorialId { get; set; }
		[JsonProperty("eventId")]
		public int EventId { get; set; }
		[JsonProperty("isRandom")]
		public int IsRandom { get; set; }
		[JsonProperty("otherDate")]
		public string OtherDate { get; set; }
	}

	public class EventPointRewardModel
	{
		[JsonProperty("count")]
		public int Count { get; set; }
		[JsonProperty("eventId")]
		public int EventId { get; set; }
		[JsonProperty("itemId")]
		public int ItemId { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
		[JsonProperty("point")]
		public int Point { get; set; }
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
	}

	public class EventRewardRarityModel
	{
		[JsonProperty("targetId")]
		public int TargetId { get; set; }
		[JsonProperty("rewardType")]
		public int RewardType { get; set; }
		[JsonProperty("conditionValue")]
		public int ConditionValue { get; set; }
		[JsonProperty("itemId")]
		public int ItemId { get; set; }
		[JsonProperty("exceedLimit")]
		public int ExceedLimit { get; set; }
	}

	public class EventSeasonModel
	{
		[JsonProperty("eventId")]
		public int EventId { get; set; }
		[JsonProperty("targetType")]
		public int TargetType { get; set; }
		[JsonProperty("value")]
		public int Value { get; set; }
		[JsonProperty("fromDate")]
		public string FromDate { get; set; }
		[JsonProperty("toDate")]
		public string ToDate { get; set; }
	}

	public class EventStoryLinkModel
	{
		[JsonProperty("eventId")]
		public int EventId { get; set; }
		[JsonProperty("transitionEventId")]
		public int TransitionEventId { get; set; }
		[JsonProperty("inductionText")]
		public string InductionText { get; set; }
	}

	public class ExCharacterAbilityEffectModel
	{
		[JsonProperty("a")]
		public int A { get; set; }
		[JsonProperty("abilityId")]
		public int AbilityId { get; set; }
		[JsonProperty("abilityMainMaster")]
		public dynamic AbilityMainMaster { get; set; }
		[JsonProperty("actionType")]
		public int ActionType { get; set; }
		[JsonProperty("b")]
		public int B { get; set; }
		[JsonProperty("c")]
		public int C { get; set; }
		[JsonProperty("d")]
		public string D { get; set; }
		[JsonProperty("e")]
		public string E { get; set; }
		[JsonProperty("effectConditionType")]
		public int EffectConditionType { get; set; }
		[JsonProperty("effectConditionValue")]
		public string EffectConditionValue { get; set; }
		[JsonProperty("effectLimit")]
		public int EffectLimit { get; set; }
		[JsonProperty("effectType")]
		public int EffectType { get; set; }
		[JsonProperty("effectValue")]
		public int EffectValue { get; set; }
		[JsonProperty("endType")]
		public int EndType { get; set; }
		[JsonProperty("endValue")]
		public string EndValue { get; set; }
		[JsonProperty("f")]
		public int F { get; set; }
		[JsonProperty("g")]
		public int G { get; set; }
		[JsonProperty("h")]
		public int H { get; set; }
		[JsonProperty("i")]
		public int I { get; set; }
		[JsonProperty("index")]
		public int Index { get; set; }
		[JsonProperty("j")]
		public int J { get; set; }
		[JsonProperty("k")]
		public string K { get; set; }
		[JsonProperty("l")]
		public int L { get; set; }
		[JsonProperty("level")]
		public int Level { get; set; }
		[JsonProperty("m")]
		public int M { get; set; }
		[JsonProperty("n")]
		public int N { get; set; }
		[JsonProperty("o")]
		public string O { get; set; }
		[JsonProperty("occurrenceRate")]
		public int OccurrenceRate { get; set; }
		[JsonProperty("p")]
		public int P { get; set; }
		[JsonProperty("q")]
		public string Q { get; set; }
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
		[JsonProperty("shortText")]
		public string ShortText { get; set; }
		[JsonProperty("successRate")]
		public int SuccessRate { get; set; }
		[JsonProperty("targetType")]
		public int TargetType { get; set; }
		[JsonProperty("targetValue")]
		public string TargetValue { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
	}

	public class ExCharacterAbilityGroupModel
	{
		[JsonProperty("abilityGroupId")]
		public int AbilityGroupId { get; set; }
		[JsonProperty("abilityId")]
		public int AbilityId { get; set; }
		[JsonProperty("abilityMainMaster")]
		public dynamic AbilityMainMaster { get; set; }
		[JsonProperty("index")]
		public int Index { get; set; }
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
	}

	public class ExCharacterAbilityMainModel
	{
		[JsonProperty("abilityConditionMasterArray")]
		public List<dynamic> AbilityConditionMasterArray { get; set; }
		[JsonProperty("abilityEffectMasterArray")]
		public List<dynamic> AbilityEffectMasterArray { get; set; }
		[JsonProperty("abilityEffectMasterMap")]
		public Dictionary<string, dynamic> AbilityEffectMasterMap { get; set; }
		[JsonProperty("abilityFortifyType")]
		public int AbilityFortifyType { get; set; }
		[JsonProperty("abilityId")]
		public int AbilityId { get; set; }
		[JsonProperty("abilityUpMasterArray")]
		public List<dynamic> AbilityUpMasterArray { get; set; }
		[JsonProperty("addAbilityId")]
		public int AddAbilityId { get; set; }
		[JsonProperty("addAbilityIdArray")]
		public List<dynamic> AddAbilityIdArray { get; set; }
		[JsonProperty("addAbilityMainMasterArray")]
		public List<dynamic> AddAbilityMainMasterArray { get; set; }
		[JsonProperty("conditionMasterMap")]
		public Dictionary<string, dynamic> ConditionMasterMap { get; set; }
		[JsonProperty("invokeLimitCount")]
		public int InvokeLimitCount { get; set; }
		[JsonProperty("maxAbilityLevel")]
		public int MaxAbilityLevel { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
		[JsonProperty("singleAbilityEffectMasterArray")]
		public List<dynamic> SingleAbilityEffectMasterArray { get; set; }
		[JsonProperty("singleAbilityEffectMasterMap")]
		public Dictionary<string, dynamic> SingleAbilityEffectMasterMap { get; set; }
		[JsonProperty("triggerType")]
		public int TriggerType { get; set; }
		[JsonProperty("triggerValue")]
		public string TriggerValue { get; set; }
	}

	public class ExCharacterAwakeConditionModel
	{
		[JsonProperty("awakeId")]
		public int AwakeId { get; set; }
		[JsonProperty("conditionText")]
		public string ConditionText { get; set; }
		[JsonProperty("conditionType")]
		public int ConditionType { get; set; }
		[JsonProperty("conditionValue")]
		public int ConditionValue { get; set; }
		[JsonProperty("index")]
		public int Index { get; set; }
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
	}

	public class ExCharacterAwakeEffectModel
	{
		[JsonProperty("awakeId")]
		public int AwakeId { get; set; }
		[JsonProperty("awakeType")]
		public int AwakeType { get; set; }
		[JsonProperty("effectColumn")]
		public string EffectColumn { get; set; }
		[JsonProperty("effectIndex")]
		public int EffectIndex { get; set; }
		[JsonProperty("effectText")]
		public string EffectText { get; set; }
		[JsonProperty("index")]
		public int Index { get; set; }
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
		[JsonProperty("targetIndex")]
		public int TargetIndex { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
		[JsonProperty("value")]
		public int Value { get; set; }
	}

	public class ExCharacterAwakeGroupModel
	{
		[JsonProperty("awakeEquipmentMaster")]
		public dynamic AwakeEquipmentMaster { get; set; }
		[JsonProperty("awakeGroupId")]
		public int AwakeGroupId { get; set; }
		[JsonProperty("awakeMainMasterArray")]
		public List<dynamic> AwakeMainMasterArray { get; set; }
		[JsonProperty("characterId")]
		public int CharacterId { get; set; }
		[JsonProperty("equipmentId")]
		public int EquipmentId { get; set; }
		[JsonProperty("maxAddBattleParameter")]
		public dynamic MaxAddBattleParameter { get; set; }
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
	}

	public class ExCharacterAwakeMainModel
	{
		[JsonProperty("awakeConditionMasterArray")]
		public List<dynamic> AwakeConditionMasterArray { get; set; }
		[JsonProperty("awakeConditionText")]
		public string AwakeConditionText { get; set; }
		[JsonProperty("awakeCostItemMaster")]
		public dynamic AwakeCostItemMaster { get; set; }
		[JsonProperty("awakeCostItemName")]
		public string AwakeCostItemName { get; set; }
		[JsonProperty("awakeEffectMasterArray")]
		public List<dynamic> AwakeEffectMasterArray { get; set; }
		[JsonProperty("awakeEffectText")]
		public string AwakeEffectText { get; set; }
		[JsonProperty("awakeGroupId")]
		public int AwakeGroupId { get; set; }
		[JsonProperty("awakeId")]
		public int AwakeId { get; set; }
		[JsonProperty("awakeMaterialMasterArray")]
		public List<dynamic> AwakeMaterialMasterArray { get; set; }
		[JsonProperty("iconType")]
		public int IconType { get; set; }
		[JsonProperty("index")]
		public int Index { get; set; }
		[JsonProperty("price")]
		public int Price { get; set; }
		[JsonProperty("primaryAwakeEffectMaster")]
		public dynamic PrimaryAwakeEffectMaster { get; set; }
		[JsonProperty("primaryAwakeType")]
		public int PrimaryAwakeType { get; set; }
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
	}

	public class ExCharacterAwakeMaterialModel
	{
		[JsonProperty("awakeId")]
		public int AwakeId { get; set; }
		[JsonProperty("count")]
		public int Count { get; set; }
		[JsonProperty("index")]
		public int Index { get; set; }
		[JsonProperty("itemMainMaster")]
		public ItemMainModel ItemMainMaster { get; set; }
		[JsonProperty("materialId")]
		public int MaterialId { get; set; }
		[JsonProperty("materialType")]
		public int MaterialType { get; set; }
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
	}

	public class ExCharacterEvolutionEffectModel
	{
		[JsonProperty("effectId")]
		public int EffectId { get; set; }
		[JsonProperty("hpRate")]
		public int HpRate { get; set; }
		[JsonProperty("atkRate")]
		public int AtkRate { get; set; }
		[JsonProperty("defRate")]
		public int DefRate { get; set; }
		[JsonProperty("skillId")]
		public int SkillId { get; set; }
		[JsonProperty("abilityGroupId")]
		public int AbilityGroupId { get; set; }
	}

	public class ExCharacterEvolutionMainModel
	{
		[JsonProperty("characterId")]
		public int CharacterId { get; set; }
		[JsonProperty("rarity")]
		public int Rarity { get; set; }
		[JsonProperty("materialId")]
		public int MaterialId { get; set; }
		[JsonProperty("effectId")]
		public int EffectId { get; set; }
		[JsonProperty("skillFortifyType")]
		public int SkillFortifyType { get; set; }
		[JsonProperty("materialMasterArray")]
		public List<dynamic> MaterialMasterArray { get; set; }
		[JsonProperty("effectMaster")]
		public dynamic EffectMaster { get; set; }
	}

	public class ExCharacterEvolutionMaterialModel
	{
		[JsonProperty("materialId")]
		public int MaterialId { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
		[JsonProperty("itemId")]
		public int ItemId { get; set; }
		[JsonProperty("count")]
		public int Count { get; set; }
		[JsonProperty("itemMainMaster")]
		public ItemMainModel ItemMainMaster { get; set; }
	}

	public class ExCharacterGroupModel
	{
		[JsonProperty("characterGroupId")]
		public int CharacterGroupId { get; set; }
		[JsonProperty("contentsGroupId")]
		public int ContentsGroupId { get; set; }
		[JsonProperty("fromDate")]
		public string FromDate { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("order")]
		public int Order { get; set; }
		[JsonProperty("readingName")]
		public string ReadingName { get; set; }
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
		[JsonProperty("roomName")]
		public string RoomName { get; set; }
		[JsonProperty("shortName")]
		public string ShortName { get; set; }
		[JsonProperty("standHeadPositionX")]
		public int StandHeadPositionX { get; set; }
		[JsonProperty("standHeadPositionY")]
		public int StandHeadPositionY { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
		[JsonProperty("union")]
		public int Union { get; set; }
	}

	public class ExCharacterMainModel
	{
		[JsonProperty("characterGroupId")]
		public int CharacterGroupId { get; set; }
		[JsonProperty("characterId")]
		public int CharacterId { get; set; }
		[JsonProperty("forceOriginalCharacterId")]
		public int ForceOriginalCharacterId { get; set; }
		[JsonProperty("characterType")]
		public int CharacterType { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("shortName")]
		public string ShortName { get; set; }
		[JsonProperty("skinName")]
		public string SkinName { get; set; }
		[JsonProperty("readingName")]
		public string ReadingName { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
		[JsonProperty("shortText")]
		public string ShortText { get; set; }
		[JsonProperty("voiceActorName")]
		public string VoiceActorName { get; set; }
		[JsonProperty("illustratorName")]
		public string IllustratorName { get; set; }
		[JsonProperty("contentsGroupId")]
		public int ContentsGroupId { get; set; }
		[JsonProperty("costumeId")]
		public int CostumeId { get; set; }
		[JsonProperty("rarity")]
		public int Rarity { get; set; }
		[JsonProperty("secondaryRarity")]
		public int SecondaryRarity { get; set; }
		[JsonProperty("attribute")]
		public int Attribute { get; set; }
		[JsonProperty("subAttribute")]
		public int SubAttribute { get; set; }
		[JsonProperty("subAttributePower")]
		public int SubAttributePower { get; set; }
		[JsonProperty("skillId")]
		public int SkillId { get; set; }
		[JsonProperty("abilityGroupId")]
		public int AbilityGroupId { get; set; }
		[JsonProperty("supportAbilityGroupId")]
		public int SupportAbilityGroupId { get; set; }
		[JsonProperty("normalAttackId")]
		public int NormalAttackId { get; set; }
		[JsonProperty("spineDirectoryPath")]
		public string SpineDirectoryPath { get; set; }
		[JsonProperty("spineName")]
		public string SpineName { get; set; }
		[JsonProperty("atlasName")]
		public string AtlasName { get; set; }
		[JsonProperty("myPageBgFileName")]
		public string MyPageBgFileName { get; set; }
		[JsonProperty("expType")]
		public int ExpType { get; set; }
		[JsonProperty("materialType")]
		public int MaterialType { get; set; }
		[JsonProperty("exceedLimitType")]
		public int ExceedLimitType { get; set; }
		[JsonProperty("maxLevel0")]
		public int MaxLevel0 { get; set; }
		[JsonProperty("maxLevel1")]
		public int MaxLevel1 { get; set; }
		[JsonProperty("maxLevel2")]
		public int MaxLevel2 { get; set; }
		[JsonProperty("maxLevel3")]
		public int MaxLevel3 { get; set; }
		[JsonProperty("maxLevel4")]
		public int MaxLevel4 { get; set; }
		[JsonProperty("minHp")]
		public int MinHp { get; set; }
		[JsonProperty("maxHp0")]
		public int MaxHp0 { get; set; }
		[JsonProperty("maxHp1")]
		public int MaxHp1 { get; set; }
		[JsonProperty("maxHp2")]
		public int MaxHp2 { get; set; }
		[JsonProperty("maxHp3")]
		public int MaxHp3 { get; set; }
		[JsonProperty("maxHp4")]
		public int MaxHp4 { get; set; }
		[JsonProperty("maxAddHp")]
		public int MaxAddHp { get; set; }
		[JsonProperty("maxFortifyHp")]
		public int MaxFortifyHp { get; set; }
		[JsonProperty("minAtk")]
		public int MinAtk { get; set; }
		[JsonProperty("maxAtk0")]
		public int MaxAtk0 { get; set; }
		[JsonProperty("maxAtk1")]
		public int MaxAtk1 { get; set; }
		[JsonProperty("maxAtk2")]
		public int MaxAtk2 { get; set; }
		[JsonProperty("maxAtk3")]
		public int MaxAtk3 { get; set; }
		[JsonProperty("maxAtk4")]
		public int MaxAtk4 { get; set; }
		[JsonProperty("maxAddAtk")]
		public int MaxAddAtk { get; set; }
		[JsonProperty("maxFortifyAtk")]
		public int MaxFortifyAtk { get; set; }
		[JsonProperty("minDef")]
		public int MinDef { get; set; }
		[JsonProperty("maxDef0")]
		public int MaxDef0 { get; set; }
		[JsonProperty("maxDef1")]
		public int MaxDef1 { get; set; }
		[JsonProperty("maxDef2")]
		public int MaxDef2 { get; set; }
		[JsonProperty("maxDef3")]
		public int MaxDef3 { get; set; }
		[JsonProperty("maxDef4")]
		public int MaxDef4 { get; set; }
		[JsonProperty("maxAddDef")]
		public int MaxAddDef { get; set; }
		[JsonProperty("maxFortifyDef")]
		public int MaxFortifyDef { get; set; }
		[JsonProperty("minLuck")]
		public int MinLuck { get; set; }
		[JsonProperty("maxLuck0")]
		public int MaxLuck0 { get; set; }
		[JsonProperty("maxLuck1")]
		public int MaxLuck1 { get; set; }
		[JsonProperty("maxLuck2")]
		public int MaxLuck2 { get; set; }
		[JsonProperty("maxLuck3")]
		public int MaxLuck3 { get; set; }
		[JsonProperty("maxLuck4")]
		public int MaxLuck4 { get; set; }
		[JsonProperty("maxAddLuck")]
		public int MaxAddLuck { get; set; }
		[JsonProperty("standPositionModel")]
		public int StandPositionModel { get; set; }
		[JsonProperty("spinePositionX")]
		public int SpinePositionX { get; set; }
		[JsonProperty("spinePositionY")]
		public int SpinePositionY { get; set; }
		[JsonProperty("standHeadPositionX")]
		public int StandHeadPositionX { get; set; }
		[JsonProperty("standHeadPositionY")]
		public int StandHeadPositionY { get; set; }
		[JsonProperty("atlasHeadPositionX")]
		public int AtlasHeadPositionX { get; set; }
		[JsonProperty("atlasHeadPositionY")]
		public int AtlasHeadPositionY { get; set; }
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
		[JsonProperty("visibleDate")]
		public string VisibleDate { get; set; }
		[JsonProperty("characterGroupMaster")]
		public CharacterGroupModel CharacterGroupMaster { get; set; }
		[JsonProperty("characterTextMasterArray")]
		public string CharacterTextMasterArray { get; set; }
		[JsonProperty("characterContentsMasterArray")]
		public List<CharacterContentsModel> CharacterContentsMasterArray { get; set; }
		[JsonProperty("characterFavoriteMasterArray")]
		public List<CharacterFavoriteModel> CharacterFavoriteMasterArray { get; set; }
		[JsonProperty("characterCostumeMaster")]
		public dynamic CharacterCostumeMaster { get; set; }
		[JsonProperty("characterLevelMasterArray")]
		public int CharacterLevelMasterArray { get; set; }
		[JsonProperty("characterMaterialMaster")]
		public CharacterMaterialModel CharacterMaterialMaster { get; set; }
		[JsonProperty("characterExceedLimitMasterArray")]
		public List<CharacterExceedLimitModel> CharacterExceedLimitMasterArray { get; set; }
		[JsonProperty("characterExceedLimitMasterMap")]
		public Dictionary<string, CharacterExceedLimitModel> CharacterExceedLimitMasterMap { get; set; }
		[JsonProperty("characterSkillMainMaster")]
		public CharacterSkillMainModel CharacterSkillMainMaster { get; set; }
		[JsonProperty("characterAbilityGroupMasterArray")]
		public List<CharacterAbilityGroupModel> CharacterAbilityGroupMasterArray { get; set; }
		[JsonProperty("characterNormalAttackMaster")]
		public CharacterNormalAttackModel CharacterNormalAttackMaster { get; set; }
		[JsonProperty("characterAwakeGroupMaster")]
		public CharacterAwakeGroupModel CharacterAwakeGroupMaster { get; set; }
		[JsonProperty("characterEvolutionMainMasterArray")]
		public List<CharacterEvolutionMainModel> CharacterEvolutionMainMasterArray { get; set; }
		[JsonProperty("maxCharacterEvolutionMainMaster")]
		public dynamic MaxCharacterEvolutionMainMaster { get; set; }
		[JsonProperty("maxRarity")]
		public int MaxRarity { get; set; }
		[JsonProperty("maxSkillId")]
		public int MaxSkillId { get; set; }
		[JsonProperty("maxAbilityGroupId")]
		public int MaxAbilityGroupId { get; set; }
		[JsonProperty("maxCharacterSkillMainMaster")]
		public dynamic MaxCharacterSkillMainMaster { get; set; }
		[JsonProperty("maxCharacterAbilityGroupMasterArray")]
		public List<dynamic> MaxCharacterAbilityGroupMasterArray { get; set; }
		[JsonProperty("maxAwakeEffectMasterArray")]
		public List<dynamic> MaxAwakeEffectMasterArray { get; set; }
		[JsonProperty("maxUserSkillMain")]
		public dynamic MaxUserSkillMain { get; set; }
		[JsonProperty("maxIncludeAwakeUserSkillMain")]
		public dynamic MaxIncludeAwakeUserSkillMain { get; set; }
		[JsonProperty("maxUserAbilityMainArray")]
		public List<dynamic> MaxUserAbilityMainArray { get; set; }
		[JsonProperty("maxIncludeAwakeUserAbilityMainArray")]
		public List<dynamic> MaxIncludeAwakeUserAbilityMainArray { get; set; }
		[JsonProperty("alterMaster")]
		public dynamic AlterMaster { get; set; }
		[JsonProperty("userDataArray")]
		public List<dynamic> UserDataArray { get; set; }
		[JsonProperty("currentMaxRarity")]
		public int CurrentMaxRarity { get; set; }
	}

	public class ExCharacterSkillMainModel
	{
		[JsonProperty("aniName")]
		public string AniName { get; set; }
		[JsonProperty("bgmVolumeAmount")]
		public double BgmVolumeAmount { get; set; }
		[JsonProperty("effectShowType")]
		public int EffectShowType { get; set; }
		[JsonProperty("hitEffectAniName")]
		public string HitEffectAniName { get; set; }
		[JsonProperty("hitEffectName")]
		public string HitEffectName { get; set; }
		[JsonProperty("maxSkillLevel")]
		public int MaxSkillLevel { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
		[JsonProperty("skillEffectMasterArray")]
		public List<dynamic> SkillEffectMasterArray { get; set; }
		[JsonProperty("skillEffectMasterMap")]
		public Dictionary<string, dynamic> SkillEffectMasterMap { get; set; }
		[JsonProperty("skillFortifyType")]
		public int SkillFortifyType { get; set; }
		[JsonProperty("skillId")]
		public int SkillId { get; set; }
		[JsonProperty("skillUpMasterArray")]
		public List<dynamic> SkillUpMasterArray { get; set; }
		[JsonProperty("spineDirectoryPath")]
		public string SpineDirectoryPath { get; set; }
		[JsonProperty("spineName")]
		public string SpineName { get; set; }
	}

	public class ExEquipmentMainModel
	{
		[JsonProperty("abilityConditionMaster")]
		public dynamic AbilityConditionMaster { get; set; }
		[JsonProperty("attribute")]
		public int Attribute { get; set; }
		[JsonProperty("equipmentEffectInfoMap")]
		public Dictionary<string, dynamic> EquipmentEffectInfoMap { get; set; }
		[JsonProperty("equipmentEffectMasterArray")]
		public List<EquipmentEffectModel> EquipmentEffectMasterArray { get; set; }
		[JsonProperty("equipmentEffectMasterMap")]
		public Dictionary<string, EquipmentEffectModel> EquipmentEffectMasterMap { get; set; }
		[JsonProperty("equipmentGroupId")]
		public int EquipmentGroupId { get; set; }
		[JsonProperty("equipmentId")]
		public int EquipmentId { get; set; }
		[JsonProperty("equipmentTimeMaster")]
		public EquipmentTimeModel EquipmentTimeMaster { get; set; }
		[JsonProperty("equipmentType")]
		public int EquipmentType { get; set; }
		[JsonProperty("exceedLimitItemType")]
		public int ExceedLimitItemType { get; set; }
		[JsonProperty("exceedLimitType")]
		public int ExceedLimitType { get; set; }
		[JsonProperty("invokeLimitCount")]
		public int InvokeLimitCount { get; set; }
		[JsonProperty("isRangeOfDate")]
		public bool IsRangeOfDate { get; set; }
		[JsonProperty("materialType")]
		public int MaterialType { get; set; }
		[JsonProperty("maxAtk1")]
		public int MaxAtk1 { get; set; }
		[JsonProperty("maxAtk2")]
		public int MaxAtk2 { get; set; }
		[JsonProperty("maxAtk3")]
		public int MaxAtk3 { get; set; }
		[JsonProperty("maxAtk4")]
		public int MaxAtk4 { get; set; }
		[JsonProperty("maxDef1")]
		public int MaxDef1 { get; set; }
		[JsonProperty("maxDef2")]
		public int MaxDef2 { get; set; }
		[JsonProperty("maxDef3")]
		public int MaxDef3 { get; set; }
		[JsonProperty("maxDef4")]
		public int MaxDef4 { get; set; }
		[JsonProperty("maxHp1")]
		public int MaxHp1 { get; set; }
		[JsonProperty("maxHp2")]
		public int MaxHp2 { get; set; }
		[JsonProperty("maxHp3")]
		public int MaxHp3 { get; set; }
		[JsonProperty("maxHp4")]
		public int MaxHp4 { get; set; }
		[JsonProperty("maxLevel1")]
		public int MaxLevel1 { get; set; }
		[JsonProperty("maxLevel2")]
		public int MaxLevel2 { get; set; }
		[JsonProperty("maxLevel3")]
		public int MaxLevel3 { get; set; }
		[JsonProperty("maxLevel4")]
		public int MaxLevel4 { get; set; }
		[JsonProperty("minAtk1")]
		public int MinAtk1 { get; set; }
		[JsonProperty("minAtk2")]
		public int MinAtk2 { get; set; }
		[JsonProperty("minAtk3")]
		public int MinAtk3 { get; set; }
		[JsonProperty("minAtk4")]
		public int MinAtk4 { get; set; }
		[JsonProperty("minDef1")]
		public int MinDef1 { get; set; }
		[JsonProperty("minDef2")]
		public int MinDef2 { get; set; }
		[JsonProperty("minDef3")]
		public int MinDef3 { get; set; }
		[JsonProperty("minDef4")]
		public int MinDef4 { get; set; }
		[JsonProperty("minHp1")]
		public int MinHp1 { get; set; }
		[JsonProperty("minHp2")]
		public int MinHp2 { get; set; }
		[JsonProperty("minHp3")]
		public int MinHp3 { get; set; }
		[JsonProperty("minHp4")]
		public int MinHp4 { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("postName")]
		public string PostName { get; set; }
		[JsonProperty("rarity")]
		public int Rarity { get; set; }
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
		[JsonProperty("resourceId")]
		public int ResourceId { get; set; }
		[JsonProperty("skillId")]
		public int SkillId { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
		[JsonProperty("triggerType")]
		public int TriggerType { get; set; }
		[JsonProperty("triggerValue")]
		public string TriggerValue { get; set; }
		[JsonProperty("uniqueId")]
		public string UniqueId { get; set; }
		[JsonProperty("uniqueType")]
		public int UniqueType { get; set; }
	}

	public class ExEventFriendshipCharacterModel
	{
		[JsonProperty("characterGroupId")]
		public int CharacterGroupId { get; set; }
		[JsonProperty("characterId")]
		public int CharacterId { get; set; }
		[JsonProperty("friendshipGroupId")]
		public int FriendshipGroupId { get; set; }
		[JsonProperty("itemId")]
		public int ItemId { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
		[JsonProperty("maxFriendshipCount")]
		public int MaxFriendshipCount { get; set; }
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
		[JsonProperty("rewardMasterArray")]
		public List<dynamic> RewardMasterArray { get; set; }
	}

	public class ExEventFriendshipModel
	{
		[JsonProperty("eventId")]
		public int EventId { get; set; }
		[JsonProperty("friendshipGroupId")]
		public int FriendshipGroupId { get; set; }
		[JsonProperty("characterMasterArray")]
		public List<CharacterModel> CharacterMasterArray { get; set; }
	}

	public class ExEventMainModel
	{
		[JsonProperty("anotherEventId")]
		public int AnotherEventId { get; set; }
		[JsonProperty("conditionFrom")]
		public int ConditionFrom { get; set; }
		[JsonProperty("conditionTo")]
		public int ConditionTo { get; set; }
		[JsonProperty("conditionType")]
		public int ConditionType { get; set; }
		[JsonProperty("currentToDate")]
		public string CurrentToDate { get; set; }
		[JsonProperty("eventId")]
		public int EventId { get; set; }
		[JsonProperty("eventType")]
		public int EventType { get; set; }
		[JsonProperty("fromDate")]
		public string FromDate { get; set; }
		[JsonProperty("gachaId")]
		public int GachaId { get; set; }
		[JsonProperty("index")]
		public int Index { get; set; }
		[JsonProperty("isNotice")]
		public int IsNotice { get; set; }
		[JsonProperty("maxUnlockCount")]
		public int MaxUnlockCount { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("questToDate")]
		public string QuestToDate { get; set; }
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
		[JsonProperty("toDate")]
		public string ToDate { get; set; }
		[JsonProperty("worldId")]
		public int WorldId { get; set; }
		[JsonProperty("worldMaster")]
		public dynamic WorldMaster { get; set; }
	}

	public class ExEventMemorialModel
	{
		[JsonProperty("memorialId")]
		public int MemorialId { get; set; }
		[JsonProperty("eventId")]
		public int EventId { get; set; }
		[JsonProperty("isRandom")]
		public int IsRandom { get; set; }
		[JsonProperty("otherDate")]
		public string OtherDate { get; set; }
		[JsonProperty("eventMainMaster")]
		public EventMainModel EventMainMaster { get; set; }
	}

	public class ExExchangeItemDetailModel
	{
		[JsonProperty("costCount1")]
		public int CostCount1 { get; set; }
		[JsonProperty("costCount2")]
		public int CostCount2 { get; set; }
		[JsonProperty("costCount3")]
		public int CostCount3 { get; set; }
		[JsonProperty("costCount4")]
		public int CostCount4 { get; set; }
		[JsonProperty("costCount5")]
		public int CostCount5 { get; set; }
		[JsonProperty("costId1")]
		public int CostId1 { get; set; }
		[JsonProperty("costId2")]
		public int CostId2 { get; set; }
		[JsonProperty("costId3")]
		public int CostId3 { get; set; }
		[JsonProperty("costId4")]
		public int CostId4 { get; set; }
		[JsonProperty("costId5")]
		public int CostId5 { get; set; }
		[JsonProperty("costType1")]
		public int CostType1 { get; set; }
		[JsonProperty("costType2")]
		public int CostType2 { get; set; }
		[JsonProperty("costType3")]
		public int CostType3 { get; set; }
		[JsonProperty("costType4")]
		public int CostType4 { get; set; }
		[JsonProperty("costType5")]
		public int CostType5 { get; set; }
		[JsonProperty("count")]
		public int Count { get; set; }
		[JsonProperty("exchangeId")]
		public int ExchangeId { get; set; }
		[JsonProperty("exchangeMainMaster")]
		public ExchangeMainModel ExchangeMainMaster { get; set; }
		[JsonProperty("fromDate")]
		public string FromDate { get; set; }
		[JsonProperty("isLimited")]
		public int IsLimited { get; set; }
		[JsonProperty("itemId")]
		public int ItemId { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
		[JsonProperty("listId")]
		public int ListId { get; set; }
		[JsonProperty("maxCount")]
		public int MaxCount { get; set; }
		[JsonProperty("maxCountType")]
		public int MaxCountType { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("order")]
		public int Order { get; set; }
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
		[JsonProperty("toDate")]
		public string ToDate { get; set; }
	}

	public class ExExchangeMainModel
	{
		[JsonProperty("costId")]
		public int CostId { get; set; }
		[JsonProperty("costType")]
		public int CostType { get; set; }
		[JsonProperty("eventId")]
		public int EventId { get; set; }
		[JsonProperty("exchangeGroupId")]
		public int ExchangeGroupId { get; set; }
		[JsonProperty("exchangeId")]
		public int ExchangeId { get; set; }
		[JsonProperty("exchangeType")]
		public int ExchangeType { get; set; }
		[JsonProperty("fromDate")]
		public string FromDate { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("order")]
		public int Order { get; set; }
		[JsonProperty("pvPExchangeId")]
		public int PvPExchangeId { get; set; }
		[JsonProperty("pvPMainMaster")]
		public PvPMainModel PvPMainMaster { get; set; }
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
		[JsonProperty("tabIconResourceId")]
		public string TabIconResourceId { get; set; }
		[JsonProperty("toDate")]
		public string ToDate { get; set; }
	}

	public class ExExchangePointDetailModel
	{
		[JsonProperty("costCount")]
		public int CostCount { get; set; }
		[JsonProperty("costId")]
		public int CostId { get; set; }
		[JsonProperty("costType")]
		public int CostType { get; set; }
		[JsonProperty("count")]
		public int Count { get; set; }
		[JsonProperty("exchangeId")]
		public int ExchangeId { get; set; }
		[JsonProperty("exchangeMainMaster")]
		public ExchangeMainModel ExchangeMainMaster { get; set; }
		[JsonProperty("fromDate")]
		public string FromDate { get; set; }
		[JsonProperty("isLimited")]
		public int IsLimited { get; set; }
		[JsonProperty("isToDateDisplayFlg")]
		public int IsToDateDisplayFlg { get; set; }
		[JsonProperty("itemId")]
		public int ItemId { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
		[JsonProperty("listId")]
		public int ListId { get; set; }
		[JsonProperty("maxCount")]
		public int MaxCount { get; set; }
		[JsonProperty("maxCountType")]
		public int MaxCountType { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("order")]
		public int Order { get; set; }
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
		[JsonProperty("toDate")]
		public string ToDate { get; set; }
	}

	public class ExFurnitureMainModel
	{
		[JsonProperty("anchorX")]
		public double AnchorX { get; set; }
		[JsonProperty("anchorY")]
		public int AnchorY { get; set; }
		[JsonProperty("animationPositionX")]
		public int AnimationPositionX { get; set; }
		[JsonProperty("animationPositionY")]
		public int AnimationPositionY { get; set; }
		[JsonProperty("characterAnimation")]
		public string CharacterAnimation { get; set; }
		[JsonProperty("description")]
		public string Description { get; set; }
		[JsonProperty("eventId")]
		public int EventId { get; set; }
		[JsonProperty("fromDate")]
		public string FromDate { get; set; }
		[JsonProperty("furnitureAnimation")]
		public string FurnitureAnimation { get; set; }
		[JsonProperty("furnitureCategory")]
		public int FurnitureCategory { get; set; }
		[JsonProperty("furnitureCostMaster")]
		public FurnitureCostModel FurnitureCostMaster { get; set; }
		[JsonProperty("furnitureId")]
		public int FurnitureId { get; set; }
		[JsonProperty("furnitureType")]
		public int FurnitureType { get; set; }
		[JsonProperty("isFurnitureShopLineup")]
		public bool IsFurnitureShopLineup { get; set; }
		[JsonProperty("mapCategory")]
		public int MapCategory { get; set; }
		[JsonProperty("maxCount")]
		public int MaxCount { get; set; }
		[JsonProperty("maxLimitCount")]
		public int MaxLimitCount { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
		[JsonProperty("sizeX")]
		public int SizeX { get; set; }
		[JsonProperty("sizeY")]
		public int SizeY { get; set; }
		[JsonProperty("sizeZ")]
		public int SizeZ { get; set; }
		[JsonProperty("spineName")]
		public string SpineName { get; set; }
		[JsonProperty("toDate")]
		public string ToDate { get; set; }
	}

	public class ExItemMainModel
	{
		[JsonProperty("attribute")]
		public int Attribute { get; set; }
		[JsonProperty("bonusSellItemMainMaster")]
		public dynamic BonusSellItemMainMaster { get; set; }
		[JsonProperty("countSuffix")]
		public string CountSuffix { get; set; }
		[JsonProperty("defaultSellItemMainMaster")]
		public dynamic DefaultSellItemMainMaster { get; set; }
		[JsonProperty("effectTime")]
		public int EffectTime { get; set; }
		[JsonProperty("effectValue")]
		public int EffectValue { get; set; }
		[JsonProperty("existsSaleItem")]
		public dynamic ExistsSaleItem { get; set; }
		[JsonProperty("fromDate")]
		public string FromDate { get; set; }
		[JsonProperty("isExpired")]
		public bool IsExpired { get; set; }
		[JsonProperty("itemCategory")]
		public List<ItemCategoryModel> ItemCategory { get; set; }
		[JsonProperty("itemId")]
		public int ItemId { get; set; }
		[JsonProperty("itemSellBonusMaster")]
		public ItemSellBonusModel ItemSellBonusMaster { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("primarySellItemMainMaster")]
		public dynamic PrimarySellItemMainMaster { get; set; }
		[JsonProperty("primarySellPrice")]
		public int PrimarySellPrice { get; set; }
		[JsonProperty("rarity")]
		public int Rarity { get; set; }
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
		[JsonProperty("resourceId")]
		public int ResourceId { get; set; }
		[JsonProperty("salePrice")]
		public int SalePrice { get; set; }
		[JsonProperty("shortName")]
		public string ShortName { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
		[JsonProperty("toDate")]
		public string ToDate { get; set; }
	}

	public class ExLinearMissionDetailModel
	{
		[JsonProperty("missionGroupId")]
		public int MissionGroupId { get; set; }
		[JsonProperty("step")]
		public int Step { get; set; }
		[JsonProperty("rewardPoint")]
		public int RewardPoint { get; set; }
		[JsonProperty("missionType")]
		public int MissionType { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
		[JsonProperty("conditionCount")]
		public int ConditionCount { get; set; }
		[JsonProperty("conditionRarity")]
		public string ConditionRarity { get; set; }
		[JsonProperty("conditionAttribute")]
		public string ConditionAttribute { get; set; }
		[JsonProperty("conditionId")]
		public string ConditionId { get; set; }
	}

	public class ExLinearMissionMainModel
	{
		[JsonProperty("missionGroupId")]
		public int MissionGroupId { get; set; }
		[JsonProperty("cycleType")]
		public int CycleType { get; set; }
		[JsonProperty("rewardPointLimit")]
		public int RewardPointLimit { get; set; }
		[JsonProperty("fromDate")]
		public string FromDate { get; set; }
		[JsonProperty("toDate")]
		public string ToDate { get; set; }
		[JsonProperty("cycleText")]
		public string CycleText { get; set; }
		[JsonProperty("linearMissionDetailMasterArray")]
		public List<LinearMissionDetailModel> LinearMissionDetailMasterArray { get; set; }
		[JsonProperty("linearMissionDetailMasterMap")]
		public Dictionary<string, LinearMissionDetailModel> LinearMissionDetailMasterMap { get; set; }
		[JsonProperty("linearMissionRewardMasterArray")]
		public List<LinearMissionRewardModel> LinearMissionRewardMasterArray { get; set; }
		[JsonProperty("linearMissionRewardMasterMap")]
		public Dictionary<string, LinearMissionRewardModel> LinearMissionRewardMasterMap { get; set; }
	}

	public class ExLinearMissionRewardModel
	{
		[JsonProperty("missionGroupId")]
		public int MissionGroupId { get; set; }
		[JsonProperty("rewardPoint")]
		public int RewardPoint { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
		[JsonProperty("itemId")]
		public int ItemId { get; set; }
		[JsonProperty("count")]
		public int Count { get; set; }
		[JsonProperty("itemMainMaster")]
		public ItemMainModel ItemMainMaster { get; set; }
		[JsonProperty("itemName")]
		public string ItemName { get; set; }
	}

	public class ExMemorialAbilityGroupModel
	{
		[JsonProperty("abilityGroupId")]
		public int AbilityGroupId { get; set; }
		[JsonProperty("index")]
		public int Index { get; set; }
		[JsonProperty("abilityId")]
		public int AbilityId { get; set; }
		[JsonProperty("abilityMainMaster")]
		public dynamic AbilityMainMaster { get; set; }
	}

	public class ExMemorialAbilityMainModel
	{
		[JsonProperty("abilityId")]
		public int AbilityId { get; set; }
		[JsonProperty("addAbilityId")]
		public int AddAbilityId { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("triggerType")]
		public int TriggerType { get; set; }
		[JsonProperty("triggerValue")]
		public string TriggerValue { get; set; }
		[JsonProperty("invokeLimitCount")]
		public int InvokeLimitCount { get; set; }
		[JsonProperty("conditionMasterMap")]
		public Dictionary<string, dynamic> ConditionMasterMap { get; set; }
		[JsonProperty("abilityConditionMasterArray")]
		public List<dynamic> AbilityConditionMasterArray { get; set; }
		[JsonProperty("abilityEffectMasterMap")]
		public Dictionary<string, dynamic> AbilityEffectMasterMap { get; set; }
		[JsonProperty("abilityEffectMasterArray")]
		public List<dynamic> AbilityEffectMasterArray { get; set; }
		[JsonProperty("addAbilityMainMasterArray")]
		public List<dynamic> AddAbilityMainMasterArray { get; set; }
	}

	public class ExMemorialMainModel
	{
		[JsonProperty("baseRarity")]
		public int BaseRarity { get; set; }
		[JsonProperty("boostGroup1")]
		public int BoostGroup1 { get; set; }
		[JsonProperty("boostGroup2")]
		public int BoostGroup2 { get; set; }
		[JsonProperty("description")]
		public string Description { get; set; }
		[JsonProperty("exceedLimitType")]
		public int ExceedLimitType { get; set; }
		[JsonProperty("illustrator")]
		public string Illustrator { get; set; }
		[JsonProperty("illustratorName")]
		public string IllustratorName { get; set; }
		[JsonProperty("isCollaboration")]
		public bool IsCollaboration { get; set; }
		[JsonProperty("levelType")]
		public int LevelType { get; set; }
		[JsonProperty("maxLevel")]
		public int MaxLevel { get; set; }
		[JsonProperty("maxRarity")]
		public int MaxRarity { get; set; }
		[JsonProperty("memorialAbilityGroupMasterArray")]
		public List<MemorialAbilityGroupModel> MemorialAbilityGroupMasterArray { get; set; }
		[JsonProperty("memorialExceedLimitMasterArray")]
		public List<MemorialExceedLimitModel> MemorialExceedLimitMasterArray { get; set; }
		[JsonProperty("memorialFilterType")]
		public int MemorialFilterType { get; set; }
		[JsonProperty("memorialId")]
		public int MemorialId { get; set; }
		[JsonProperty("memorialLevelMasterArray")]
		public int MemorialLevelMasterArray { get; set; }
		[JsonProperty("memorialLevelMasterMap")]
		public int MemorialLevelMasterMap { get; set; }
		[JsonProperty("memorialStatusMasterMap")]
		public Dictionary<string, MemorialStatusModel> MemorialStatusMasterMap { get; set; }
		[JsonProperty("memorialTextMasterArray")]
		public string MemorialTextMasterArray { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("statusId")]
		public int StatusId { get; set; }
		[JsonProperty("unisonType")]
		public int UnisonType { get; set; }
		[JsonProperty("voiceActorNames")]
		public string VoiceActorNames { get; set; }
		[JsonProperty("voiceActors")]
		public string VoiceActors { get; set; }
	}

	public class ExMissionMainModel
	{
		[JsonProperty("category")]
		public int Category { get; set; }
		[JsonProperty("eventId")]
		public int EventId { get; set; }
		[JsonProperty("eventMainMaster")]
		public EventMainModel EventMainMaster { get; set; }
		[JsonProperty("fromDate")]
		public string FromDate { get; set; }
		[JsonProperty("index")]
		public int Index { get; set; }
		[JsonProperty("isCommonMission")]
		public bool IsCommonMission { get; set; }
		[JsonProperty("isProgressingMission")]
		public bool IsProgressingMission { get; set; }
		[JsonProperty("isRangeOfDate")]
		public bool IsRangeOfDate { get; set; }
		[JsonProperty("missionDetailMaster")]
		public MissionDetailModel MissionDetailMaster { get; set; }
		[JsonProperty("missionGroupId")]
		public int MissionGroupId { get; set; }
		[JsonProperty("missionName")]
		public string MissionName { get; set; }
		[JsonProperty("missionTabName")]
		public string MissionTabName { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
		[JsonProperty("toDate")]
		public string ToDate { get; set; }
	}

	public class ExMyPageNewsModel
	{
		[JsonProperty("newsId")]
		public int NewsId { get; set; }
		[JsonProperty("adultType")]
		public int AdultType { get; set; }
		[JsonProperty("order")]
		public int Order { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("bandId")]
		public int BandId { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
		[JsonProperty("dateFrom")]
		public string DateFrom { get; set; }
		[JsonProperty("dateTo")]
		public string DateTo { get; set; }
		[JsonProperty("conditionType")]
		public int ConditionType { get; set; }
		[JsonProperty("conditionFrom")]
		public int ConditionFrom { get; set; }
		[JsonProperty("conditionTo")]
		public int ConditionTo { get; set; }
		[JsonProperty("comebackCampaignIds")]
		public dynamic ComebackCampaignIds { get; set; }
	}

	public class ExMyPagePopupModel
	{
		[JsonProperty("popupId")]
		public int PopupId { get; set; }
		[JsonProperty("repeatType")]
		public int RepeatType { get; set; }
		[JsonProperty("dateFrom")]
		public string DateFrom { get; set; }
		[JsonProperty("dateTo")]
		public string DateTo { get; set; }
		[JsonProperty("order")]
		public int Order { get; set; }
		[JsonProperty("title")]
		public string Title { get; set; }
		[JsonProperty("fileName")]
		public string FileName { get; set; }
		[JsonProperty("description")]
		public string Description { get; set; }
		[JsonProperty("transitionId")]
		public int TransitionId { get; set; }
		[JsonProperty("transitionParam1")]
		public int TransitionParam1 { get; set; }
		[JsonProperty("transitionParam2")]
		public int TransitionParam2 { get; set; }
		[JsonProperty("transitionParam3")]
		public int TransitionParam3 { get; set; }
		[JsonProperty("comebackCampaignIds")]
		public dynamic ComebackCampaignIds { get; set; }
	}

	public class ExQuestAreaModel
	{
		[JsonProperty("areaId")]
		public int AreaId { get; set; }
		[JsonProperty("availableStoryMasterArray")]
		public List<dynamic> AvailableStoryMasterArray { get; set; }
		[JsonProperty("battleDisplayCount")]
		public int BattleDisplayCount { get; set; }
		[JsonProperty("battlePlayCount")]
		public int BattlePlayCount { get; set; }
		[JsonProperty("campaignCount")]
		public int CampaignCount { get; set; }
		[JsonProperty("canPlayQuest")]
		public bool CanPlayQuest { get; set; }
		[JsonProperty("category")]
		public int Category { get; set; }
		[JsonProperty("difficult")]
		public int Difficult { get; set; }
		[JsonProperty("endTime")]
		public string EndTime { get; set; }
		[JsonProperty("fromDate")]
		public string FromDate { get; set; }
		[JsonProperty("imageName")]
		public string ImageName { get; set; }
		[JsonProperty("index")]
		public int Index { get; set; }
		[JsonProperty("maxBattleCount")]
		public int MaxBattleCount { get; set; }
		[JsonProperty("maxBattleCountWithBoost")]
		public int MaxBattleCountWithBoost { get; set; }
		[JsonProperty("maxBattlePlayCount")]
		public int MaxBattlePlayCount { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
		[JsonProperty("rewardItemCount")]
		public int RewardItemCount { get; set; }
		[JsonProperty("rewardItemId")]
		public int RewardItemId { get; set; }
		[JsonProperty("rewardItemType")]
		public int RewardItemType { get; set; }
		[JsonProperty("stageMasterArray")]
		public List<dynamic> StageMasterArray { get; set; }
		[JsonProperty("stageMasterMap")]
		public Dictionary<string, dynamic> StageMasterMap { get; set; }
		[JsonProperty("startTime")]
		public string StartTime { get; set; }
		[JsonProperty("storyMasterArray")]
		public List<StoryModel> StoryMasterArray { get; set; }
		[JsonProperty("targetStoryMasterArray")]
		public List<dynamic> TargetStoryMasterArray { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
		[JsonProperty("toDate")]
		public string ToDate { get; set; }
		[JsonProperty("weekTypes")]
		public string WeekTypes { get; set; }
		[JsonProperty("worldId")]
		public int WorldId { get; set; }
		[JsonProperty("worldMaster")]
		public dynamic WorldMaster { get; set; }
	}

	public class ExQuestScenarioModel
	{
		[JsonProperty("worldId")]
		public int WorldId { get; set; }
		[JsonProperty("scenarioNum")]
		public int ScenarioNum { get; set; }
	}

	public class ExQuestStageConditionModel
	{
		[JsonProperty("stageId")]
		public int StageId { get; set; }
		[JsonProperty("conditionType")]
		public int ConditionType { get; set; }
		[JsonProperty("conditionId")]
		public string ConditionId { get; set; }
		[JsonProperty("conditionValue")]
		public int ConditionValue { get; set; }
	}

	public class ExQuestStageModel
	{
		[JsonProperty("achieveId1")]
		public int AchieveId1 { get; set; }
		[JsonProperty("achieveId2")]
		public int AchieveId2 { get; set; }
		[JsonProperty("achieveId3")]
		public int AchieveId3 { get; set; }
		[JsonProperty("areaId")]
		public int AreaId { get; set; }
		[JsonProperty("areaMaster")]
		public dynamic AreaMaster { get; set; }
		[JsonProperty("background")]
		public string Background { get; set; }
		[JsonProperty("bossWaveBgm")]
		public string BossWaveBgm { get; set; }
		[JsonProperty("characterExpFrom")]
		public int CharacterExpFrom { get; set; }
		[JsonProperty("characterExpTo")]
		public int CharacterExpTo { get; set; }
		[JsonProperty("defaultSkillGaugeRate")]
		public int DefaultSkillGaugeRate { get; set; }
		[JsonProperty("difficult")]
		public int Difficult { get; set; }
		[JsonProperty("fromDate")]
		public string FromDate { get; set; }
		[JsonProperty("goldFrom")]
		public int GoldFrom { get; set; }
		[JsonProperty("goldTo")]
		public int GoldTo { get; set; }
		[JsonProperty("isClear")]
		public bool IsClear { get; set; }
		[JsonProperty("isExistStartStory")]
		public bool IsExistStartStory { get; set; }
		[JsonProperty("maxBattleCount")]
		public int MaxBattleCount { get; set; }
		[JsonProperty("maxClearCount")]
		public int MaxClearCount { get; set; }
		[JsonProperty("maxSkipCount")]
		public int MaxSkipCount { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("normalWaveBgm")]
		public string NormalWaveBgm { get; set; }
		[JsonProperty("recommendPower")]
		public int RecommendPower { get; set; }
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
		[JsonProperty("releaseStageId")]
		public int ReleaseStageId { get; set; }
		[JsonProperty("rewardItemCount")]
		public int RewardItemCount { get; set; }
		[JsonProperty("rewardItemId")]
		public int RewardItemId { get; set; }
		[JsonProperty("rewardItemType")]
		public int RewardItemType { get; set; }
		[JsonProperty("skipItemId")]
		public int SkipItemId { get; set; }
		[JsonProperty("skipItemMaster")]
		public dynamic SkipItemMaster { get; set; }
		[JsonProperty("skipItemType")]
		public int SkipItemType { get; set; }
		[JsonProperty("stageId")]
		public int StageId { get; set; }
		[JsonProperty("stamina")]
		public int Stamina { get; set; }
		[JsonProperty("startUserStory")]
		public dynamic StartUserStory { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
		[JsonProperty("toDate")]
		public string ToDate { get; set; }
		[JsonProperty("userData")]
		public dynamic UserData { get; set; }
		[JsonProperty("userExpFrom")]
		public int UserExpFrom { get; set; }
		[JsonProperty("userExpTo")]
		public int UserExpTo { get; set; }
		[JsonProperty("worldId")]
		public int WorldId { get; set; }
	}

	public class ExQuestWorldModel
	{
		[JsonProperty("areaMasterArray")]
		public List<dynamic> AreaMasterArray { get; set; }
		[JsonProperty("areaMasterMap")]
		public Dictionary<string, dynamic> AreaMasterMap { get; set; }
		[JsonProperty("battleDisplayCount")]
		public int BattleDisplayCount { get; set; }
		[JsonProperty("battlePlayCount")]
		public int BattlePlayCount { get; set; }
		[JsonProperty("canPlayQuest")]
		public bool CanPlayQuest { get; set; }
		[JsonProperty("category")]
		public int Category { get; set; }
		[JsonProperty("fromDate")]
		public string FromDate { get; set; }
		[JsonProperty("imageName")]
		public string ImageName { get; set; }
		[JsonProperty("isRangeOfDate")]
		public bool IsRangeOfDate { get; set; }
		[JsonProperty("maxBattleCount")]
		public int MaxBattleCount { get; set; }
		[JsonProperty("maxBattleCountWithBoost")]
		public int MaxBattleCountWithBoost { get; set; }
		[JsonProperty("maxBattlePlayCount")]
		public int MaxBattlePlayCount { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
		[JsonProperty("rewardItemCount")]
		public int RewardItemCount { get; set; }
		[JsonProperty("rewardItemId")]
		public int RewardItemId { get; set; }
		[JsonProperty("rewardItemType")]
		public int RewardItemType { get; set; }
		[JsonProperty("toDate")]
		public string ToDate { get; set; }
		[JsonProperty("worldId")]
		public int WorldId { get; set; }
	}

	public class ExRaceAbilityEffectGroupModel
	{
		[JsonProperty("effectGroupId")]
		public int EffectGroupId { get; set; }
		[JsonProperty("order")]
		public int Order { get; set; }
		[JsonProperty("effectId")]
		public int EffectId { get; set; }
		[JsonProperty("effectMaster")]
		public dynamic EffectMaster { get; set; }
	}

	public class ExRaceAbilityEffectModel
	{
		[JsonProperty("effectId")]
		public int EffectId { get; set; }
		[JsonProperty("effectTiming")]
		public int EffectTiming { get; set; }
		[JsonProperty("rate")]
		public int Rate { get; set; }
		[JsonProperty("targetType")]
		public int TargetType { get; set; }
		[JsonProperty("effectType")]
		public int EffectType { get; set; }
		[JsonProperty("effectValue")]
		public int EffectValue { get; set; }
		[JsonProperty("effectValueType")]
		public int EffectValueType { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
		[JsonProperty("effectTimingMaster")]
		public dynamic EffectTimingMaster { get; set; }
		[JsonProperty("effectTargetMaster")]
		public dynamic EffectTargetMaster { get; set; }
		[JsonProperty("effectTypeMaster")]
		public dynamic EffectTypeMaster { get; set; }
		[JsonProperty("effectValueTypeMaster")]
		public dynamic EffectValueTypeMaster { get; set; }
		[JsonProperty("displayRateText")]
		public string DisplayRateText { get; set; }
		[JsonProperty("displayEffectValueText")]
		public string DisplayEffectValueText { get; set; }
		[JsonProperty("displayText")]
		public string DisplayText { get; set; }
		[JsonProperty("effectValueWithType")]
		public int EffectValueWithType { get; set; }
		[JsonProperty("simpleEffectText")]
		public string SimpleEffectText { get; set; }
	}

	public class ExRaceAbilityGroupModel
	{
		[JsonProperty("abilityGroupId")]
		public int AbilityGroupId { get; set; }
		[JsonProperty("category")]
		public int Category { get; set; }
		[JsonProperty("order")]
		public int Order { get; set; }
		[JsonProperty("abilityId")]
		public int AbilityId { get; set; }
		[JsonProperty("abilityMainMaster")]
		public dynamic AbilityMainMaster { get; set; }
	}

	public class ExRaceAbilityMainModel
	{
		[JsonProperty("abilityId")]
		public int AbilityId { get; set; }
		[JsonProperty("effectGroupId")]
		public int EffectGroupId { get; set; }
		[JsonProperty("conditionType")]
		public int ConditionType { get; set; }
		[JsonProperty("conditionValue")]
		public int ConditionValue { get; set; }
		[JsonProperty("effectGroupMasterArray")]
		public List<dynamic> EffectGroupMasterArray { get; set; }
		[JsonProperty("effectGroupMasterMap")]
		public Dictionary<string, dynamic> EffectGroupMasterMap { get; set; }
		[JsonProperty("abilityText")]
		public string AbilityText { get; set; }
	}

	public class ExRaceAreaModel
	{
		[JsonProperty("season")]
		public int Season { get; set; }
		[JsonProperty("areaId")]
		public int AreaId { get; set; }
		[JsonProperty("weekTypes")]
		public string WeekTypes { get; set; }
		[JsonProperty("stageGroupId")]
		public int StageGroupId { get; set; }
		[JsonProperty("description")]
		public string Description { get; set; }
		[JsonProperty("raceStageMasterArray")]
		public List<RaceStageModel> RaceStageMasterArray { get; set; }
		[JsonProperty("raceStageMasterMap")]
		public Dictionary<string, RaceStageModel> RaceStageMasterMap { get; set; }
	}

	public class ExRaceCharacterMainModel
	{
		[JsonProperty("abilityEffectMasterMap")]
		public Dictionary<string, dynamic> AbilityEffectMasterMap { get; set; }
		[JsonProperty("abilityGroupId")]
		public int AbilityGroupId { get; set; }
		[JsonProperty("abilityGroupMasterArray")]
		public List<dynamic> AbilityGroupMasterArray { get; set; }
		[JsonProperty("abilityGroupMasterMap")]
		public Dictionary<string, dynamic> AbilityGroupMasterMap { get; set; }
		[JsonProperty("boostType")]
		public int BoostType { get; set; }
		[JsonProperty("characterId")]
		public int CharacterId { get; set; }
		[JsonProperty("characterMainMaster")]
		public CharacterMainModel CharacterMainMaster { get; set; }
		[JsonProperty("costItemId")]
		public int CostItemId { get; set; }
		[JsonProperty("costItemMainMaster")]
		public dynamic CostItemMainMaster { get; set; }
		[JsonProperty("costItemName")]
		public string CostItemName { get; set; }
		[JsonProperty("costItemType")]
		public int CostItemType { get; set; }
		[JsonProperty("fortifyType")]
		public int FortifyType { get; set; }
		[JsonProperty("isBaseCharacter")]
		public bool IsBaseCharacter { get; set; }
		[JsonProperty("isFreeReceivable")]
		public bool IsFreeReceivable { get; set; }
		[JsonProperty("maxPlayCount")]
		public int MaxPlayCount { get; set; }
		[JsonProperty("maxRaceFortifyMaster")]
		public dynamic MaxRaceFortifyMaster { get; set; }
		[JsonProperty("maxRaceStatusMaster")]
		public dynamic MaxRaceStatusMaster { get; set; }
		[JsonProperty("maxStatusId")]
		public int MaxStatusId { get; set; }
		[JsonProperty("minRaceStatusMaster")]
		public dynamic MinRaceStatusMaster { get; set; }
		[JsonProperty("minStatusId")]
		public int MinStatusId { get; set; }
		[JsonProperty("raceCharacterFreeMaster")]
		public RaceCharacterFreeModel RaceCharacterFreeMaster { get; set; }
		[JsonProperty("racingNumber")]
		public int RacingNumber { get; set; }
		[JsonProperty("recoveryCount")]
		public int RecoveryCount { get; set; }
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
		[JsonProperty("shopDetailMaster")]
		public ShopDetailModel ShopDetailMaster { get; set; }
		[JsonProperty("textGroupId")]
		public int TextGroupId { get; set; }
		[JsonProperty("textMasterArray")]
		public string TextMasterArray { get; set; }
		[JsonProperty("textMasterMap")]
		public string TextMasterMap { get; set; }
		[JsonProperty("topTextMasterArray")]
		public string TopTextMasterArray { get; set; }
		[JsonProperty("userData")]
		public dynamic UserData { get; set; }
	}

	public class ExRaceCommentaryTextModel
	{
		[JsonProperty("situationId")]
		public int SituationId { get; set; }
		[JsonProperty("trapId")]
		public int TrapId { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
		[JsonProperty("displayText")]
		public string DisplayText { get; set; }
	}

	public class ExRaceMainModel
	{
		[JsonProperty("season")]
		public int Season { get; set; }
		[JsonProperty("maxPlayCount")]
		public int MaxPlayCount { get; set; }
		[JsonProperty("recoveryTime")]
		public string RecoveryTime { get; set; }
		[JsonProperty("recoveryCount")]
		public int RecoveryCount { get; set; }
		[JsonProperty("carryOverRate")]
		public int CarryOverRate { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("bgFileName")]
		public string BgFileName { get; set; }
		[JsonProperty("fromDate")]
		public string FromDate { get; set; }
		[JsonProperty("toDate")]
		public string ToDate { get; set; }
		[JsonProperty("raceAreaMasterArray")]
		public List<RaceAreaModel> RaceAreaMasterArray { get; set; }
		[JsonProperty("raceAreaMasterMap")]
		public Dictionary<string, RaceAreaModel> RaceAreaMasterMap { get; set; }
		[JsonProperty("playableAreaMaster")]
		public dynamic PlayableAreaMaster { get; set; }
		[JsonProperty("staminaRecoveryTimeArray")]
		public List<dynamic> StaminaRecoveryTimeArray { get; set; }
		[JsonProperty("isRangeOfDate")]
		public bool IsRangeOfDate { get; set; }
	}

	public class ExRaceObstacleModel
	{
		[JsonProperty("examValue")]
		public int ExamValue { get; set; }
		[JsonProperty("obstacle1")]
		public int Obstacle1 { get; set; }
		[JsonProperty("obstacle2")]
		public int Obstacle2 { get; set; }
		[JsonProperty("obstacle3")]
		public int Obstacle3 { get; set; }
		[JsonProperty("obstacle4")]
		public int Obstacle4 { get; set; }
		[JsonProperty("obstacleCount")]
		public int ObstacleCount { get; set; }
		[JsonProperty("obstacleCount1")]
		public int ObstacleCount1 { get; set; }
		[JsonProperty("obstacleCount2")]
		public int ObstacleCount2 { get; set; }
		[JsonProperty("obstacleCount3")]
		public int ObstacleCount3 { get; set; }
		[JsonProperty("obstacleCount4")]
		public int ObstacleCount4 { get; set; }
		[JsonProperty("obstacleExamValue1")]
		public dynamic ObstacleExamValue1 { get; set; }
		[JsonProperty("obstacleExamValue2")]
		public dynamic ObstacleExamValue2 { get; set; }
		[JsonProperty("obstacleExamValue3")]
		public dynamic ObstacleExamValue3 { get; set; }
		[JsonProperty("obstacleExamValue4")]
		public dynamic ObstacleExamValue4 { get; set; }
		[JsonProperty("obstacleId")]
		public int ObstacleId { get; set; }
		[JsonProperty("obstacleMaxWeight")]
		public dynamic ObstacleMaxWeight { get; set; }
		[JsonProperty("obstacleWeight1")]
		public dynamic ObstacleWeight1 { get; set; }
		[JsonProperty("obstacleWeight2")]
		public dynamic ObstacleWeight2 { get; set; }
		[JsonProperty("obstacleWeight3")]
		public dynamic ObstacleWeight3 { get; set; }
		[JsonProperty("obstacleWeight4")]
		public dynamic ObstacleWeight4 { get; set; }
	}

	public class ExRaceRewardModel
	{
		[JsonProperty("rewardId")]
		public int RewardId { get; set; }
		[JsonProperty("order")]
		public int Order { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
		[JsonProperty("itemId")]
		public int ItemId { get; set; }
		[JsonProperty("count")]
		public int Count { get; set; }
		[JsonProperty("itemMainMaster")]
		public ItemMainModel ItemMainMaster { get; set; }
	}

	public class ExRaceStageModel
	{
		[JsonProperty("stageGroupId")]
		public int StageGroupId { get; set; }
		[JsonProperty("rank")]
		public int Rank { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("memberCount")]
		public int MemberCount { get; set; }
		[JsonProperty("obstacleId")]
		public int ObstacleId { get; set; }
		[JsonProperty("abilityGroupId")]
		public int AbilityGroupId { get; set; }
		[JsonProperty("firstRewardId")]
		public int FirstRewardId { get; set; }
		[JsonProperty("winRewardId")]
		public int WinRewardId { get; set; }
		[JsonProperty("loseRewardId")]
		public int LoseRewardId { get; set; }
		[JsonProperty("obstacleMaster")]
		public dynamic ObstacleMaster { get; set; }
		[JsonProperty("abilityGroupMasterArray")]
		public List<dynamic> AbilityGroupMasterArray { get; set; }
		[JsonProperty("abilityGroupMasterMap")]
		public Dictionary<string, dynamic> AbilityGroupMasterMap { get; set; }
		[JsonProperty("abilityEffectMasterMap")]
		public Dictionary<string, dynamic> AbilityEffectMasterMap { get; set; }
		[JsonProperty("firstRewardMasterArray")]
		public List<dynamic> FirstRewardMasterArray { get; set; }
		[JsonProperty("winRewardMasterArray")]
		public List<dynamic> WinRewardMasterArray { get; set; }
		[JsonProperty("loseRewardMasterArray")]
		public List<dynamic> LoseRewardMasterArray { get; set; }
	}

	public class ExRaceTextModel
	{
		[JsonProperty("textGroupId")]
		public int TextGroupId { get; set; }
		[JsonProperty("textType")]
		public int TextType { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
		[JsonProperty("displayText")]
		public string DisplayText { get; set; }
	}

	public class ExShopDetailModel
	{
		[JsonProperty("comebackCampaignIds")]
		public dynamic ComebackCampaignIds { get; set; }
		[JsonProperty("costCount")]
		public int CostCount { get; set; }
		[JsonProperty("costId")]
		public int CostId { get; set; }
		[JsonProperty("costType")]
		public int CostType { get; set; }
		[JsonProperty("count")]
		public int Count { get; set; }
		[JsonProperty("firstBonus")]
		public int FirstBonus { get; set; }
		[JsonProperty("fromDate")]
		public string FromDate { get; set; }
		[JsonProperty("iconName")]
		public string IconName { get; set; }
		[JsonProperty("isRangeOfDate")]
		public bool IsRangeOfDate { get; set; }
		[JsonProperty("itemId")]
		public int ItemId { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
		[JsonProperty("labelType")]
		public int LabelType { get; set; }
		[JsonProperty("listGroupId")]
		public int ListGroupId { get; set; }
		[JsonProperty("listId")]
		public int ListId { get; set; }
		[JsonProperty("maxCount")]
		public int MaxCount { get; set; }
		[JsonProperty("missionId")]
		public int MissionId { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("normalBonus")]
		public int NormalBonus { get; set; }
		[JsonProperty("order")]
		public int Order { get; set; }
		[JsonProperty("preListId")]
		public int PreListId { get; set; }
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
		[JsonProperty("replenishmentDays")]
		public int ReplenishmentDays { get; set; }
		[JsonProperty("resetType")]
		public int ResetType { get; set; }
		[JsonProperty("shopId")]
		public int ShopId { get; set; }
		[JsonProperty("shopMainMaster")]
		public ShopMainModel ShopMainMaster { get; set; }
		[JsonProperty("shopOrderPackMasterArray")]
		public List<ShopOrderPackModel> ShopOrderPackMasterArray { get; set; }
		[JsonProperty("skuId")]
		public int SkuId { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
		[JsonProperty("toDate")]
		public string ToDate { get; set; }
		[JsonProperty("weekTypes")]
		public string WeekTypes { get; set; }
	}

	public class ExSoundMainModel
	{
		[JsonProperty("costItemCount")]
		public int CostItemCount { get; set; }
		[JsonProperty("costItemId")]
		public int CostItemId { get; set; }
		[JsonProperty("costItemMainMaster")]
		public dynamic CostItemMainMaster { get; set; }
		[JsonProperty("costItemName")]
		public string CostItemName { get; set; }
		[JsonProperty("costItemType")]
		public int CostItemType { get; set; }
		[JsonProperty("fileName")]
		public string FileName { get; set; }
		[JsonProperty("isAvailable")]
		public bool IsAvailable { get; set; }
		[JsonProperty("isPlayable")]
		public bool IsPlayable { get; set; }
		[JsonProperty("isSettingToHomeBGM")]
		public bool IsSettingToHomeBGM { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
		[JsonProperty("shopDetailMaster")]
		public ShopDetailModel ShopDetailMaster { get; set; }
		[JsonProperty("soundId")]
		public int SoundId { get; set; }
		[JsonProperty("title")]
		public string Title { get; set; }
		[JsonProperty("type")]
		public int Type { get; set; }
		[JsonProperty("userSoundModel")]
		public UserSoundModel UserSoundModel { get; set; }
	}

	public class ExStoryCabinModel
	{
		[JsonProperty("storyGroupId")]
		public int StoryGroupId { get; set; }
		[JsonProperty("storyId")]
		public int StoryId { get; set; }
		[JsonProperty("resourceId")]
		public int ResourceId { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
	}

	public class ExStoryCategoryModel
	{
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("storyCategory")]
		public int StoryCategory { get; set; }
		[JsonProperty("storyGroupMasterArray")]
		public List<StoryGroupModel> StoryGroupMasterArray { get; set; }
		[JsonProperty("storyGroupMasterMap")]
		public Dictionary<string, StoryGroupModel> StoryGroupMasterMap { get; set; }
	}

	public class ExStoryEventModel
	{
		[JsonProperty("eventId")]
		public int EventId { get; set; }
		[JsonProperty("eventMainMaster")]
		public EventMainModel EventMainMaster { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("playType")]
		public int PlayType { get; set; }
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
		[JsonProperty("releaseStoryId")]
		public int ReleaseStoryId { get; set; }
		[JsonProperty("resourceId")]
		public int ResourceId { get; set; }
		[JsonProperty("stableEventId")]
		public int StableEventId { get; set; }
		[JsonProperty("stageId")]
		public int StageId { get; set; }
		[JsonProperty("stageMaster")]
		public dynamic StageMaster { get; set; }
		[JsonProperty("storyGroupId")]
		public int StoryGroupId { get; set; }
		[JsonProperty("storyId")]
		public int StoryId { get; set; }
	}

	public class ExStoryGachaModel
	{
		[JsonProperty("storyGroupId")]
		public int StoryGroupId { get; set; }
		[JsonProperty("storyId")]
		public int StoryId { get; set; }
		[JsonProperty("resourceId")]
		public int ResourceId { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("characterId")]
		public int CharacterId { get; set; }
	}

	public class ExStoryGroupModel
	{
		[JsonProperty("availableStoryDetailMasterArray")]
		public List<dynamic> AvailableStoryDetailMasterArray { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
		[JsonProperty("storyCategory")]
		public int StoryCategory { get; set; }
		[JsonProperty("storyDetailMasterArray")]
		public List<dynamic> StoryDetailMasterArray { get; set; }
		[JsonProperty("storyGroupId")]
		public int StoryGroupId { get; set; }
		[JsonProperty("targetStoryDetailMasterArray")]
		public List<dynamic> TargetStoryDetailMasterArray { get; set; }
	}

	public class ExStoryMemorialEventOtherModel
	{
		[JsonProperty("storyGroupId")]
		public int StoryGroupId { get; set; }
		[JsonProperty("storyId")]
		public int StoryId { get; set; }
		[JsonProperty("resourceId")]
		public int ResourceId { get; set; }
		[JsonProperty("eventId")]
		public int EventId { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("visibleDate")]
		public string VisibleDate { get; set; }
		[JsonProperty("eventMainMaster")]
		public EventMainModel EventMainMaster { get; set; }
	}

	public class ExStoryMemorialModel
	{
		[JsonProperty("storyGroupId")]
		public int StoryGroupId { get; set; }
		[JsonProperty("memorialId")]
		public int MemorialId { get; set; }
		[JsonProperty("storyId")]
		public int StoryId { get; set; }
		[JsonProperty("resourceId")]
		public int ResourceId { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
	}

	public class ExStoryOtherModel
	{
		[JsonProperty("eventId")]
		public int EventId { get; set; }
		[JsonProperty("eventMainMaster")]
		public EventMainModel EventMainMaster { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("playType")]
		public int PlayType { get; set; }
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
		[JsonProperty("resourceId")]
		public int ResourceId { get; set; }
		[JsonProperty("stageId")]
		public int StageId { get; set; }
		[JsonProperty("storyGroupId")]
		public int StoryGroupId { get; set; }
		[JsonProperty("storyId")]
		public int StoryId { get; set; }
	}

	public class ExStoryPictureBookModel
	{
		[JsonProperty("lightResourceId")]
		public int LightResourceId { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
		[JsonProperty("resourceId")]
		public int ResourceId { get; set; }
		[JsonProperty("rewardCount")]
		public int RewardCount { get; set; }
		[JsonProperty("rewardId")]
		public int RewardId { get; set; }
		[JsonProperty("rewardType")]
		public int RewardType { get; set; }
		[JsonProperty("storyGroupId")]
		public int StoryGroupId { get; set; }
		[JsonProperty("storyId")]
		public int StoryId { get; set; }
		[JsonProperty("visibleDate")]
		public string VisibleDate { get; set; }
	}

	public class ExStoryQuestModel
	{
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("playType")]
		public int PlayType { get; set; }
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
		[JsonProperty("resourceId")]
		public int ResourceId { get; set; }
		[JsonProperty("stageId")]
		public int StageId { get; set; }
		[JsonProperty("stageMaster")]
		public dynamic StageMaster { get; set; }
		[JsonProperty("storyGroupId")]
		public int StoryGroupId { get; set; }
		[JsonProperty("storyId")]
		public int StoryId { get; set; }
	}

	public class ExStoryRoomModel
	{
		[JsonProperty("condition1")]
		public int Condition1 { get; set; }
		[JsonProperty("condition2")]
		public int Condition2 { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
		[JsonProperty("resourceId")]
		public int ResourceId { get; set; }
		[JsonProperty("rewardCount")]
		public int RewardCount { get; set; }
		[JsonProperty("rewardId")]
		public int RewardId { get; set; }
		[JsonProperty("rewardType")]
		public int RewardType { get; set; }
		[JsonProperty("storyGroupId")]
		public int StoryGroupId { get; set; }
		[JsonProperty("storyId")]
		public int StoryId { get; set; }
		[JsonProperty("visibleDate")]
		public string VisibleDate { get; set; }
	}

	public class ExStoryTutorialModel
	{
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("resourceId")]
		public int ResourceId { get; set; }
		[JsonProperty("storyGroupId")]
		public int StoryGroupId { get; set; }
		[JsonProperty("storyId")]
		public int StoryId { get; set; }
	}

	public class ExStoryVoiceModel
	{
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
		[JsonProperty("resourceId")]
		public int ResourceId { get; set; }
		[JsonProperty("storyGroupId")]
		public int StoryGroupId { get; set; }
		[JsonProperty("storyId")]
		public int StoryId { get; set; }
	}

	public class ExUniqueMissionModel
	{
		[JsonProperty("missionGroupId")]
		public int MissionGroupId { get; set; }
	}

	public class ExceedLimitAlternateItemModel
	{
		[JsonProperty("characterId")]
		public int CharacterId { get; set; }
		[JsonProperty("alternateItemId")]
		public int AlternateItemId { get; set; }
		[JsonProperty("itemId")]
		public int ItemId { get; set; }
	}

	public class ExchangeGroupModel
	{
		[JsonProperty("exchangeGroupId")]
		public int ExchangeGroupId { get; set; }
		[JsonProperty("exchangeGroupName")]
		public string ExchangeGroupName { get; set; }
		[JsonProperty("tabIconResourceId")]
		public string TabIconResourceId { get; set; }
		[JsonProperty("order")]
		public int Order { get; set; }
	}

	public class ExchangeItemDetailModel
	{
		[JsonProperty("exchangeId")]
		public int ExchangeId { get; set; }
		[JsonProperty("listId")]
		public int ListId { get; set; }
		[JsonProperty("order")]
		public int Order { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
		[JsonProperty("maxCount")]
		public int MaxCount { get; set; }
		[JsonProperty("maxCountType")]
		public int MaxCountType { get; set; }
		[JsonProperty("isLimited")]
		public int IsLimited { get; set; }
		[JsonProperty("fromDate")]
		public string FromDate { get; set; }
		[JsonProperty("toDate")]
		public string ToDate { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
		[JsonProperty("itemId")]
		public int ItemId { get; set; }
		[JsonProperty("count")]
		public int Count { get; set; }
		[JsonProperty("costType1")]
		public int CostType1 { get; set; }
		[JsonProperty("costId1")]
		public int CostId1 { get; set; }
		[JsonProperty("costCount1")]
		public int CostCount1 { get; set; }
		[JsonProperty("costType2")]
		public int CostType2 { get; set; }
		[JsonProperty("costId2")]
		public int CostId2 { get; set; }
		[JsonProperty("costCount2")]
		public int CostCount2 { get; set; }
		[JsonProperty("costType3")]
		public int CostType3 { get; set; }
		[JsonProperty("costId3")]
		public int CostId3 { get; set; }
		[JsonProperty("costCount3")]
		public int CostCount3 { get; set; }
		[JsonProperty("costType4")]
		public int CostType4 { get; set; }
		[JsonProperty("costId4")]
		public int CostId4 { get; set; }
		[JsonProperty("costCount4")]
		public int CostCount4 { get; set; }
		[JsonProperty("costType5")]
		public int CostType5 { get; set; }
		[JsonProperty("costId5")]
		public int CostId5 { get; set; }
		[JsonProperty("costCount5")]
		public int CostCount5 { get; set; }
	}

	public class ExchangeMainModel
	{
		[JsonProperty("exchangeId")]
		public int ExchangeId { get; set; }
		[JsonProperty("exchangeGroupId")]
		public int ExchangeGroupId { get; set; }
		[JsonProperty("order")]
		public int Order { get; set; }
		[JsonProperty("exchangeType")]
		public int ExchangeType { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("fromDate")]
		public string FromDate { get; set; }
		[JsonProperty("toDate")]
		public string ToDate { get; set; }
		[JsonProperty("costType")]
		public int CostType { get; set; }
		[JsonProperty("costId")]
		public int CostId { get; set; }
		[JsonProperty("tabIconResourceId")]
		public string TabIconResourceId { get; set; }
		[JsonProperty("eventId")]
		public int EventId { get; set; }
	}

	public class ExchangePointDetailModel
	{
		[JsonProperty("exchangeId")]
		public int ExchangeId { get; set; }
		[JsonProperty("listId")]
		public int ListId { get; set; }
		[JsonProperty("order")]
		public int Order { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
		[JsonProperty("costCount")]
		public int CostCount { get; set; }
		[JsonProperty("maxCount")]
		public int MaxCount { get; set; }
		[JsonProperty("maxCountType")]
		public int MaxCountType { get; set; }
		[JsonProperty("isLimited")]
		public int IsLimited { get; set; }
		[JsonProperty("fromDate")]
		public string FromDate { get; set; }
		[JsonProperty("toDate")]
		public string ToDate { get; set; }
		[JsonProperty("isToDateDisplayFlg")]
		public int IsToDateDisplayFlg { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
		[JsonProperty("itemId")]
		public int ItemId { get; set; }
		[JsonProperty("count")]
		public int Count { get; set; }
	}

	public class FreeStoryModel
	{
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
		[JsonProperty("storyId")]
		public int StoryId { get; set; }
	}

	public class FurnitureCategoryModel
	{
		[JsonProperty("furnitureCategory")]
		public int FurnitureCategory { get; set; }
		[JsonProperty("maxCount")]
		public int MaxCount { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
	}

	public class FurnitureCollectModel
	{
		[JsonProperty("itemId")]
		public int ItemId { get; set; }
		[JsonProperty("count")]
		public int Count { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
		[JsonProperty("collectTime")]
		public int CollectTime { get; set; }
		[JsonProperty("furnitureId")]
		public int FurnitureId { get; set; }
		[JsonProperty("maxStackCount")]
		public int MaxStackCount { get; set; }
	}

	public class FurnitureCostModel
	{
		[JsonProperty("costCount")]
		public int CostCount { get; set; }
		[JsonProperty("costId")]
		public int CostId { get; set; }
		[JsonProperty("furnitureId")]
		public int FurnitureId { get; set; }
		[JsonProperty("costType")]
		public int CostType { get; set; }
	}

	public class FurnitureMainModel
	{
		[JsonProperty("eventId")]
		public int EventId { get; set; }
		[JsonProperty("mapCategory")]
		public int MapCategory { get; set; }
		[JsonProperty("furnitureAnimation")]
		public string FurnitureAnimation { get; set; }
		[JsonProperty("anchorX")]
		public double AnchorX { get; set; }
		[JsonProperty("description")]
		public string Description { get; set; }
		[JsonProperty("characterAnimation")]
		public string CharacterAnimation { get; set; }
		[JsonProperty("toDate")]
		public string ToDate { get; set; }
		[JsonProperty("maxLimitCount")]
		public int MaxLimitCount { get; set; }
		[JsonProperty("furnitureType")]
		public int FurnitureType { get; set; }
		[JsonProperty("sizeX")]
		public int SizeX { get; set; }
		[JsonProperty("sizeY")]
		public int SizeY { get; set; }
		[JsonProperty("furnitureId")]
		public int FurnitureId { get; set; }
		[JsonProperty("furnitureCategory")]
		public int FurnitureCategory { get; set; }
		[JsonProperty("animationPositionY")]
		public int AnimationPositionY { get; set; }
		[JsonProperty("animationPositionX")]
		public int AnimationPositionX { get; set; }
		[JsonProperty("fromDate")]
		public string FromDate { get; set; }
		[JsonProperty("sizeZ")]
		public int SizeZ { get; set; }
		[JsonProperty("maxCount")]
		public int MaxCount { get; set; }
		[JsonProperty("spineName")]
		public string SpineName { get; set; }
		[JsonProperty("anchorY")]
		public int AnchorY { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
	}

	public class FurnitureModel
	{
		[JsonProperty("furnitureMainMaster")]
		public FurnitureMainModel FurnitureMainMaster { get; set; }
		[JsonProperty("furnitureCostMaster")]
		public FurnitureCostModel FurnitureCostMaster { get; set; }
		[JsonProperty("furnitureCategoryMaster")]
		public FurnitureCategoryModel FurnitureCategoryMaster { get; set; }
		[JsonProperty("furnitureTypeMaster")]
		public FurnitureTypeModel FurnitureTypeMaster { get; set; }
		[JsonProperty("furnitureCollectMaster")]
		public FurnitureCollectModel FurnitureCollectMaster { get; set; }
		[JsonProperty("furnitureName")]
		public string FurnitureName { get; set; }
		[JsonProperty("furnitureDescription")]
		public string FurnitureDescription { get; set; }
		[JsonProperty("furnitureId")]
		public int FurnitureId { get; set; }
		[JsonProperty("furnitureCd")]
		public string FurnitureCd { get; set; }
		[JsonProperty("isBuyFurniture")]
		public int IsBuyFurniture { get; set; }
		[JsonProperty("level")]
		public int Level { get; set; }
		[JsonProperty("furnitureCategory")]
		public int FurnitureCategory { get; set; }
		[JsonProperty("furnitureType")]
		public int FurnitureType { get; set; }
		[JsonProperty("mapCategory")]
		public int MapCategory { get; set; }
		[JsonProperty("animationPosition")]
		public int AnimationPosition { get; set; }
		[JsonProperty("maxCount")]
		public int MaxCount { get; set; }
		[JsonProperty("furnitureSize")]
		public dynamic FurnitureSize { get; set; }
		[JsonProperty("furnitureAnchor")]
		public double FurnitureAnchor { get; set; }
		[JsonProperty("furnitureCategoryName")]
		public string FurnitureCategoryName { get; set; }
		[JsonProperty("furnitureTypeName")]
		public string FurnitureTypeName { get; set; }
		[JsonProperty("furnitureAnimationName")]
		public string FurnitureAnimationName { get; set; }
		[JsonProperty("characterAnimationName")]
		public string CharacterAnimationName { get; set; }
		[JsonProperty("collectTime")]
		public int CollectTime { get; set; }
		[JsonProperty("collectCountPerStack")]
		public int CollectCountPerStack { get; set; }
		[JsonProperty("maxStackCount")]
		public int MaxStackCount { get; set; }
	}

	public class FurnitureStoryModel
	{
		[JsonProperty("characterId")]
		public int CharacterId { get; set; }
		[JsonProperty("title")]
		public string Title { get; set; }
		[JsonProperty("furnitureId")]
		public int FurnitureId { get; set; }
		[JsonProperty("storyId")]
		public int StoryId { get; set; }
	}

	public class FurnitureTypeModel
	{
		[JsonProperty("furnitureType")]
		public int FurnitureType { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
	}

	public class GachaCautionModel
	{
		[JsonProperty("text")]
		public string Text { get; set; }
		[JsonProperty("cautionId")]
		public int CautionId { get; set; }
	}

	public class GachaContentsModel
	{
		[JsonProperty("category")]
		public int Category { get; set; }
		[JsonProperty("characterId")]
		public int CharacterId { get; set; }
		[JsonProperty("detailIds")]
		public string DetailIds { get; set; }
		[JsonProperty("detailPosX")]
		public int DetailPosX { get; set; }
		[JsonProperty("detailPosY")]
		public int DetailPosY { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
		[JsonProperty("order")]
		public int Order { get; set; }
		[JsonProperty("bannerFile")]
		public string BannerFile { get; set; }
		[JsonProperty("contentsId")]
		public int ContentsId { get; set; }
		[JsonProperty("description_type")]
		public int Description_type { get; set; }
	}

	public class GachaDiscountModel
	{
		[JsonProperty("discountCondition")]
		public int DiscountCondition { get; set; }
		[JsonProperty("discountTpe")]
		public int DiscountTpe { get; set; }
		[JsonProperty("buttonId")]
		public string ButtonId { get; set; }
		[JsonProperty("step")]
		public int Step { get; set; }
		[JsonProperty("discountCost")]
		public int DiscountCost { get; set; }
		[JsonProperty("gachaId")]
		public int GachaId { get; set; }
	}

	public class GachaFixGroupModel
	{
		[JsonProperty("fixLineupId")]
		public int FixLineupId { get; set; }
		[JsonProperty("fixRarity")]
		public int FixRarity { get; set; }
		[JsonProperty("fixCount")]
		public int FixCount { get; set; }
		[JsonProperty("fixType")]
		public int FixType { get; set; }
		[JsonProperty("fixGroupId")]
		public int FixGroupId { get; set; }
	}

	public class GachaLineupModel
	{
		[JsonProperty("rate")]
		public int Rate { get; set; }
		[JsonProperty("iconType")]
		public int IconType { get; set; }
		[JsonProperty("characterId")]
		public int CharacterId { get; set; }
		[JsonProperty("lineupId")]
		public int LineupId { get; set; }
	}

	public class GachaMainModel
	{
		[JsonProperty("toDate")]
		public string ToDate { get; set; }
		[JsonProperty("buttonCount")]
		public int ButtonCount { get; set; }
		[JsonProperty("buttonList")]
		public List<dynamic> ButtonList { get; set; }
		[JsonProperty("bannerCount")]
		public int BannerCount { get; set; }
		[JsonProperty("bannerList")]
		public List<dynamic> BannerList { get; set; }
		[JsonProperty("weekType")]
		public string WeekType { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
		[JsonProperty("conditionFrom")]
		public int ConditionFrom { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
		[JsonProperty("conditionTo")]
		public int ConditionTo { get; set; }
		[JsonProperty("conditionType")]
		public int ConditionType { get; set; }
		[JsonProperty("contentsId")]
		public int ContentsId { get; set; }
		[JsonProperty("lineupButtonId")]
		public int LineupButtonId { get; set; }
		[JsonProperty("fromDate")]
		public string FromDate { get; set; }
		[JsonProperty("gachaType")]
		public int GachaType { get; set; }
		[JsonProperty("gachaId")]
		public int GachaId { get; set; }
		[JsonProperty("cautionId")]
		public int CautionId { get; set; }
		[JsonProperty("limitCount")]
		public int LimitCount { get; set; }
		[JsonProperty("order")]
		public int Order { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
	}

	public class GachaOddsModel
	{
		[JsonProperty("oddsId")]
		public int OddsId { get; set; }
		[JsonProperty("rare4")]
		public dynamic Rare4 { get; set; }
		[JsonProperty("rare1")]
		public dynamic Rare1 { get; set; }
		[JsonProperty("rare3")]
		public dynamic Rare3 { get; set; }
		[JsonProperty("rare2")]
		public dynamic Rare2 { get; set; }
		[JsonProperty("total")]
		public dynamic Total { get; set; }
	}

	public class GachaPresentGroupModel
	{
		[JsonProperty("itemId")]
		public int ItemId { get; set; }
		[JsonProperty("rate")]
		public int Rate { get; set; }
		[JsonProperty("presentGroupId")]
		public int PresentGroupId { get; set; }
		[JsonProperty("itemCount")]
		public int ItemCount { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
	}

	public class GachaStepModel
	{
		[JsonProperty("itemId")]
		public int ItemId { get; set; }
		[JsonProperty("count")]
		public int Count { get; set; }
		[JsonProperty("oddsId")]
		public int OddsId { get; set; }
		[JsonProperty("buttonId")]
		public string ButtonId { get; set; }
		[JsonProperty("fixGroupId")]
		public int FixGroupId { get; set; }
		[JsonProperty("step")]
		public int Step { get; set; }
		[JsonProperty("cost")]
		public dynamic Cost { get; set; }
		[JsonProperty("lineupId")]
		public int LineupId { get; set; }
		[JsonProperty("gachaId")]
		public int GachaId { get; set; }
		[JsonProperty("presentGroupId")]
		public int PresentGroupId { get; set; }
	}

	public class InitCharacterModel
	{
		[JsonProperty("characterId")]
		public int CharacterId { get; set; }
		[JsonProperty("exceedLimit")]
		public int ExceedLimit { get; set; }
		[JsonProperty("level")]
		public int Level { get; set; }
	}

	public class InitEquipmentModel
	{
		[JsonProperty("equipmentId")]
		public int EquipmentId { get; set; }
		[JsonProperty("level")]
		public int Level { get; set; }
	}

	public class InitItemModel
	{
		[JsonProperty("itemId")]
		public int ItemId { get; set; }
		[JsonProperty("count")]
		public int Count { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
	}

	public class ItemApRecoveryGemModel
	{
		[JsonProperty("effectValue")]
		public int EffectValue { get; set; }
		[JsonProperty("costCount")]
		public int CostCount { get; set; }
	}

	public class ItemCategoryModel
	{
		[JsonProperty("maxCount")]
		public int MaxCount { get; set; }
		[JsonProperty("itemCategory")]
		public List<ItemCategoryModel> ItemCategory { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
	}

	public class ItemMainModel
	{
		[JsonProperty("itemId")]
		public int ItemId { get; set; }
		[JsonProperty("resourceId")]
		public int ResourceId { get; set; }
		[JsonProperty("itemCategory")]
		public List<ItemCategoryModel> ItemCategory { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
		[JsonProperty("countSuffix")]
		public string CountSuffix { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
		[JsonProperty("salePrice")]
		public int SalePrice { get; set; }
		[JsonProperty("effectValue")]
		public int EffectValue { get; set; }
		[JsonProperty("effectTime")]
		public int EffectTime { get; set; }
		[JsonProperty("rarity")]
		public int Rarity { get; set; }
		[JsonProperty("attribute")]
		public int Attribute { get; set; }
		[JsonProperty("fromDate")]
		public string FromDate { get; set; }
		[JsonProperty("toDate")]
		public string ToDate { get; set; }
	}

	public class ItemModel
	{
		[JsonProperty("itemMainMaster")]
		public ItemMainModel ItemMainMaster { get; set; }
		[JsonProperty("itemRecipeMaster")]
		public ItemRecipeModel ItemRecipeMaster { get; set; }
		[JsonProperty("itemSetMaster")]
		public ItemSetModel ItemSetMaster { get; set; }
		[JsonProperty("itemSelectMaster")]
		public ItemSelectModel ItemSelectMaster { get; set; }
		[JsonProperty("itemSellBonusMaster")]
		public ItemSellBonusModel ItemSellBonusMaster { get; set; }
		[JsonProperty("sellBonusItemMainMaster")]
		public dynamic SellBonusItemMainMaster { get; set; }
		[JsonProperty("itemId")]
		public int ItemId { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("count")]
		public int Count { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
		[JsonProperty("itemCategory")]
		public List<ItemCategoryModel> ItemCategory { get; set; }
		[JsonProperty("setItemId")]
		public int SetItemId { get; set; }
		[JsonProperty("effectValue")]
		public int EffectValue { get; set; }
		[JsonProperty("setId")]
		public int SetId { get; set; }
		[JsonProperty("selectItemId")]
		public int SelectItemId { get; set; }
		[JsonProperty("salePrice")]
		public int SalePrice { get; set; }
		[JsonProperty("rarity")]
		public int Rarity { get; set; }
		[JsonProperty("fromDate")]
		public string FromDate { get; set; }
		[JsonProperty("toDate")]
		public string ToDate { get; set; }
	}

	public class ItemQuestLockModel
	{
		[JsonProperty("itemId")]
		public int ItemId { get; set; }
		[JsonProperty("questIds")]
		public string QuestIds { get; set; }
		[JsonProperty("releaseType")]
		public int ReleaseType { get; set; }
		[JsonProperty("questType")]
		public int QuestType { get; set; }
	}

	public class ItemRecipeModel
	{
		[JsonProperty("needCount")]
		public int NeedCount { get; set; }
		[JsonProperty("itemId")]
		public int ItemId { get; set; }
		[JsonProperty("recipeItemId")]
		public int RecipeItemId { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
	}

	public class ItemSelectModel
	{
		[JsonProperty("itemId")]
		public int ItemId { get; set; }
		[JsonProperty("count")]
		public int Count { get; set; }
		[JsonProperty("selectItemId")]
		public int SelectItemId { get; set; }
		[JsonProperty("setId")]
		public int SetId { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
		[JsonProperty("exceedLimit")]
		public int ExceedLimit { get; set; }
	}

	public class ItemSellBonusModel
	{
		[JsonProperty("itemId")]
		public int ItemId { get; set; }
		[JsonProperty("count")]
		public int Count { get; set; }
		[JsonProperty("bonusItemId")]
		public int BonusItemId { get; set; }
		[JsonProperty("bonusItemType")]
		public int BonusItemType { get; set; }
	}

	public class ItemSetModel
	{
		[JsonProperty("count")]
		public int Count { get; set; }
		[JsonProperty("exceedLimit")]
		public int ExceedLimit { get; set; }
		[JsonProperty("itemId")]
		public int ItemId { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
		[JsonProperty("level")]
		public int Level { get; set; }
		[JsonProperty("rate")]
		public int Rate { get; set; }
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
		[JsonProperty("setId")]
		public int SetId { get; set; }
		[JsonProperty("setItemId")]
		public int SetItemId { get; set; }
	}

	public class ItemStoryReleaseModel
	{
		[JsonProperty("itemId")]
		public int ItemId { get; set; }
		[JsonProperty("count")]
		public int Count { get; set; }
		[JsonProperty("isLimited")]
		public int IsLimited { get; set; }
		[JsonProperty("storyId")]
		public int StoryId { get; set; }
	}

	public class ItemVoteModel
	{
		[JsonProperty("voteId")]
		public int VoteId { get; set; }
		[JsonProperty("voteType")]
		public int VoteType { get; set; }
	}

	public class LinearMissionDetailModel
	{
		[JsonProperty("missionType")]
		public int MissionType { get; set; }
		[JsonProperty("missionGroupId")]
		public int MissionGroupId { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("conditionAttribute")]
		public string ConditionAttribute { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
		[JsonProperty("conditionId")]
		public string ConditionId { get; set; }
		[JsonProperty("conditionCount")]
		public int ConditionCount { get; set; }
		[JsonProperty("rewardPoint")]
		public int RewardPoint { get; set; }
		[JsonProperty("conditionRarity")]
		public string ConditionRarity { get; set; }
		[JsonProperty("step")]
		public int Step { get; set; }
	}

	public class LinearMissionMainModel
	{
		[JsonProperty("toDate")]
		public string ToDate { get; set; }
		[JsonProperty("missionGroupId")]
		public int MissionGroupId { get; set; }
		[JsonProperty("cycleType")]
		public int CycleType { get; set; }
		[JsonProperty("fromDate")]
		public string FromDate { get; set; }
		[JsonProperty("rewardPointLimit")]
		public int RewardPointLimit { get; set; }
	}

	public class LinearMissionModel
	{
		[JsonProperty("missionGroupId")]
		public int MissionGroupId { get; set; }
		[JsonProperty("step")]
		public int Step { get; set; }
		[JsonProperty("clearCount")]
		public int ClearCount { get; set; }
		[JsonProperty("rewardPoint")]
		public int RewardPoint { get; set; }
		[JsonProperty("startDate")]
		public string StartDate { get; set; }
		[JsonProperty("resetDate")]
		public string ResetDate { get; set; }
		[JsonProperty("linearMissionMainMaster")]
		public LinearMissionMainModel LinearMissionMainMaster { get; set; }
		[JsonProperty("currentStepMissionDetailMaster")]
		public dynamic CurrentStepMissionDetailMaster { get; set; }
	}

	public class LinearMissionRewardModel
	{
		[JsonProperty("itemId")]
		public int ItemId { get; set; }
		[JsonProperty("count")]
		public int Count { get; set; }
		[JsonProperty("missionGroupId")]
		public int MissionGroupId { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
		[JsonProperty("rewardPoint")]
		public int RewardPoint { get; set; }
	}

	public class LoadingCharacterModel
	{
		[JsonProperty("characterId")]
		public int CharacterId { get; set; }
		[JsonProperty("serif")]
		public string Serif { get; set; }
		[JsonProperty("description")]
		public string Description { get; set; }
		[JsonProperty("mainPosX")]
		public int MainPosX { get; set; }
		[JsonProperty("mainPosY")]
		public int MainPosY { get; set; }
		[JsonProperty("backPosX")]
		public int BackPosX { get; set; }
		[JsonProperty("backPosY")]
		public int BackPosY { get; set; }
	}

	public class LoadingIllustModel
	{
		[JsonProperty("illustId")]
		public int IllustId { get; set; }
		[JsonProperty("visibleDate")]
		public string VisibleDate { get; set; }
	}

	public class LoadingMainModel
	{
		[JsonProperty("loadingType")]
		public int LoadingType { get; set; }
		[JsonProperty("count")]
		public int Count { get; set; }
	}

	public class LoadingTipsModel
	{
		[JsonProperty("title")]
		public string Title { get; set; }
		[JsonProperty("description")]
		public string Description { get; set; }
	}

	public class LoginBonusModel
	{
		[JsonProperty("character1X")]
		public int Character1X { get; set; }
		[JsonProperty("character1Y")]
		public int Character1Y { get; set; }
		[JsonProperty("character2X")]
		public int Character2X { get; set; }
		[JsonProperty("character2Y")]
		public int Character2Y { get; set; }
		[JsonProperty("characterId1")]
		public int CharacterId1 { get; set; }
		[JsonProperty("characterId2")]
		public int CharacterId2 { get; set; }
		[JsonProperty("fromDate")]
		public string FromDate { get; set; }
		[JsonProperty("isLoop")]
		public int IsLoop { get; set; }
		[JsonProperty("layoutName")]
		public string LayoutName { get; set; }
		[JsonProperty("loginBonusId")]
		public int LoginBonusId { get; set; }
		[JsonProperty("loginBonusType")]
		public int LoginBonusType { get; set; }
		[JsonProperty("loginCount")]
		public int LoginCount { get; set; }
		[JsonProperty("maxColumn")]
		public int MaxColumn { get; set; }
		[JsonProperty("messageEndParameter")]
		public string MessageEndParameter { get; set; }
		[JsonProperty("messageParameter1")]
		public string MessageParameter1 { get; set; }
		[JsonProperty("messageParameter2")]
		public string MessageParameter2 { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("order")]
		public int Order { get; set; }
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
		[JsonProperty("resourceType")]
		public int ResourceType { get; set; }
		[JsonProperty("toDate")]
		public string ToDate { get; set; }
	}

	public class LoginPackMainModel
	{
		[JsonProperty("loginPackId")]
		public int LoginPackId { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("loginBonusDays")]
		public int LoginBonusDays { get; set; }
		[JsonProperty("loginPackReceiveType")]
		public int LoginPackReceiveType { get; set; }
	}

	public class LoginPackRewardModel
	{
		[JsonProperty("loginPackId")]
		public int LoginPackId { get; set; }
		[JsonProperty("loginCount")]
		public int LoginCount { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
		[JsonProperty("itemId")]
		public int ItemId { get; set; }
		[JsonProperty("itemCount")]
		public int ItemCount { get; set; }
	}

	public class LoginRewardModel
	{
		[JsonProperty("loginBonusId")]
		public int LoginBonusId { get; set; }
		[JsonProperty("loginCount")]
		public int LoginCount { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
		[JsonProperty("itemId")]
		public int ItemId { get; set; }
		[JsonProperty("amount")]
		public int Amount { get; set; }
		[JsonProperty("itemType2")]
		public int ItemType2 { get; set; }
		[JsonProperty("itemId2")]
		public int ItemId2 { get; set; }
		[JsonProperty("amount2")]
		public int Amount2 { get; set; }
	}

	public class LotteryModel
	{
		[JsonProperty("itemId")]
		public int ItemId { get; set; }
		[JsonProperty("lotteryCd")]
		public string LotteryCd { get; set; }
		[JsonProperty("itemMainMaster")]
		public ItemMainModel ItemMainMaster { get; set; }
		[JsonProperty("itemName")]
		public string ItemName { get; set; }
	}

	public class MemorialAbilityConditionModel
	{
		[JsonProperty("abilityId")]
		public int AbilityId { get; set; }
		[JsonProperty("conditionGroup")]
		public int ConditionGroup { get; set; }
		[JsonProperty("conditionType")]
		public int ConditionType { get; set; }
		[JsonProperty("conditionValue")]
		public int ConditionValue { get; set; }
	}

	public class MemorialAbilityEffectModel
	{
		[JsonProperty("abilityId")]
		public int AbilityId { get; set; }
		[JsonProperty("actionType")]
		public int ActionType { get; set; }
		[JsonProperty("boostType")]
		public int BoostType { get; set; }
		[JsonProperty("effectConditionType")]
		public int EffectConditionType { get; set; }
		[JsonProperty("effectConditionValue")]
		public string EffectConditionValue { get; set; }
		[JsonProperty("effectLimit")]
		public int EffectLimit { get; set; }
		[JsonProperty("effectType")]
		public int EffectType { get; set; }
		[JsonProperty("effectValue")]
		public int EffectValue { get; set; }
		[JsonProperty("endType")]
		public int EndType { get; set; }
		[JsonProperty("endValue")]
		public string EndValue { get; set; }
		[JsonProperty("index")]
		public int Index { get; set; }
		[JsonProperty("occurrenceRate")]
		public int OccurrenceRate { get; set; }
		[JsonProperty("rarity")]
		public int Rarity { get; set; }
		[JsonProperty("successRate")]
		public int SuccessRate { get; set; }
		[JsonProperty("targetType")]
		public int TargetType { get; set; }
		[JsonProperty("targetValue")]
		public string TargetValue { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
	}

	public class MemorialAbilityGroupModel
	{
		[JsonProperty("abilityGroupId")]
		public int AbilityGroupId { get; set; }
		[JsonProperty("index")]
		public int Index { get; set; }
		[JsonProperty("abilityId")]
		public int AbilityId { get; set; }
	}

	public class MemorialAbilityMainModel
	{
		[JsonProperty("abilityId")]
		public int AbilityId { get; set; }
		[JsonProperty("addAbilityId")]
		public int AddAbilityId { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("triggerType")]
		public int TriggerType { get; set; }
		[JsonProperty("triggerValue")]
		public string TriggerValue { get; set; }
		[JsonProperty("invokeLimitCount")]
		public int InvokeLimitCount { get; set; }
	}

	public class MemorialCollaboModel
	{
		[JsonProperty("memorialId")]
		public int MemorialId { get; set; }
	}

	public class MemorialConvertModel
	{
		[JsonProperty("unisonType")]
		public int UnisonType { get; set; }
		[JsonProperty("rarity")]
		public int Rarity { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
		[JsonProperty("itemId")]
		public int ItemId { get; set; }
		[JsonProperty("count")]
		public int Count { get; set; }
	}

	public class MemorialDeckModel
	{
		[JsonProperty("deckId")]
		public int DeckId { get; set; }
		[JsonProperty("deckType")]
		public int DeckType { get; set; }
		[JsonProperty("position")]
		public int Position { get; set; }
		[JsonProperty("memorialId")]
		public int MemorialId { get; set; }
		[JsonProperty("roleType")]
		public int RoleType { get; set; }
	}

	public class MemorialExceedLimitModel
	{
		[JsonProperty("exceedLimitType")]
		public int ExceedLimitType { get; set; }
		[JsonProperty("rarity")]
		public int Rarity { get; set; }
		[JsonProperty("materialType")]
		public int MaterialType { get; set; }
		[JsonProperty("materialId")]
		public int MaterialId { get; set; }
		[JsonProperty("count")]
		public int Count { get; set; }
	}

	public class MemorialExchangeDetailModel
	{
		[JsonProperty("exchangeId")]
		public int ExchangeId { get; set; }
		[JsonProperty("listId")]
		public int ListId { get; set; }
		[JsonProperty("exceedLimit")]
		public int ExceedLimit { get; set; }
	}

	public class MemorialLevelModel
	{
		[JsonProperty("levelType")]
		public int LevelType { get; set; }
		[JsonProperty("level")]
		public int Level { get; set; }
		[JsonProperty("materialType")]
		public int MaterialType { get; set; }
		[JsonProperty("materialId")]
		public int MaterialId { get; set; }
		[JsonProperty("count")]
		public int Count { get; set; }
	}

	public class MemorialMainModel
	{
		[JsonProperty("memorialId")]
		public int MemorialId { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("unisonType")]
		public int UnisonType { get; set; }
		[JsonProperty("boostGroup1")]
		public int BoostGroup1 { get; set; }
		[JsonProperty("boostGroup2")]
		public int BoostGroup2 { get; set; }
		[JsonProperty("statusId")]
		public int StatusId { get; set; }
		[JsonProperty("levelType")]
		public int LevelType { get; set; }
		[JsonProperty("exceedLimitType")]
		public int ExceedLimitType { get; set; }
		[JsonProperty("voiceActors")]
		public string VoiceActors { get; set; }
		[JsonProperty("illustrator")]
		public string Illustrator { get; set; }
		[JsonProperty("description")]
		public string Description { get; set; }
	}

	public class MemorialModel
	{
		[JsonProperty("abilityEffectModelArray")]
		public List<dynamic> AbilityEffectModelArray { get; set; }
		[JsonProperty("abilityShortText")]
		public string AbilityShortText { get; set; }
		[JsonProperty("abilityText")]
		public string AbilityText { get; set; }
		[JsonProperty("atk")]
		public int Atk { get; set; }
		[JsonProperty("baseRarity")]
		public int BaseRarity { get; set; }
		[JsonProperty("def")]
		public int Def { get; set; }
		[JsonProperty("exceedLimit")]
		public int ExceedLimit { get; set; }
		[JsonProperty("exceedLimitType")]
		public int ExceedLimitType { get; set; }
		[JsonProperty("hp")]
		public int Hp { get; set; }
		[JsonProperty("isLevelMax")]
		public bool IsLevelMax { get; set; }
		[JsonProperty("isMaxRarity")]
		public int IsMaxRarity { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
		[JsonProperty("level")]
		public int Level { get; set; }
		[JsonProperty("levelType")]
		public int LevelType { get; set; }
		[JsonProperty("maxAtk")]
		public int MaxAtk { get; set; }
		[JsonProperty("maxDef")]
		public int MaxDef { get; set; }
		[JsonProperty("maxHp")]
		public int MaxHp { get; set; }
		[JsonProperty("maxLevel")]
		public int MaxLevel { get; set; }
		[JsonProperty("maxLevelByMaxRarity")]
		public int MaxLevelByMaxRarity { get; set; }
		[JsonProperty("maxRarity")]
		public int MaxRarity { get; set; }
		[JsonProperty("memorialExceedLimitModelArray")]
		public List<MemorialExceedLimitModel> MemorialExceedLimitModelArray { get; set; }
		[JsonProperty("memorialFilterType")]
		public int MemorialFilterType { get; set; }
		[JsonProperty("memorialId")]
		public int MemorialId { get; set; }
		[JsonProperty("memorialMainMaster")]
		public MemorialMainModel MemorialMainMaster { get; set; }
		[JsonProperty("minAtk")]
		public int MinAtk { get; set; }
		[JsonProperty("minDef")]
		public int MinDef { get; set; }
		[JsonProperty("minHp")]
		public int MinHp { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("needMaterials")]
		public dynamic NeedMaterials { get; set; }
		[JsonProperty("rarity")]
		public int Rarity { get; set; }
		[JsonProperty("registerDate")]
		public string RegisterDate { get; set; }
		[JsonProperty("statusId")]
		public int StatusId { get; set; }
		[JsonProperty("unisonType")]
		public int UnisonType { get; set; }
	}

	public class MemorialShopDetailModel
	{
		[JsonProperty("shopId")]
		public int ShopId { get; set; }
		[JsonProperty("listId")]
		public int ListId { get; set; }
		[JsonProperty("exceedLimit")]
		public int ExceedLimit { get; set; }
	}

	public class MemorialStatusModel
	{
		[JsonProperty("statusId")]
		public int StatusId { get; set; }
		[JsonProperty("maxLevel")]
		public int MaxLevel { get; set; }
		[JsonProperty("rarity")]
		public int Rarity { get; set; }
		[JsonProperty("minHp")]
		public int MinHp { get; set; }
		[JsonProperty("maxHp")]
		public int MaxHp { get; set; }
		[JsonProperty("minAtk")]
		public int MinAtk { get; set; }
		[JsonProperty("maxAtk")]
		public int MaxAtk { get; set; }
		[JsonProperty("minDef")]
		public int MinDef { get; set; }
		[JsonProperty("maxDef")]
		public int MaxDef { get; set; }
	}

	public class MemorialTextModel
	{
		[JsonProperty("memorialId")]
		public int MemorialId { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
		[JsonProperty("voiceFile")]
		public string VoiceFile { get; set; }
	}

	public class MinigameCharacterMainModel
	{
		[JsonProperty("characterId")]
		public int CharacterId { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
	}

	public class MinigameCharacterTextModel
	{
		[JsonProperty("textId")]
		public int TextId { get; set; }
		[JsonProperty("characterId")]
		public int CharacterId { get; set; }
		[JsonProperty("rivalCharacterId")]
		public int RivalCharacterId { get; set; }
		[JsonProperty("index")]
		public int Index { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
	}

	public class MinigameMainModel
	{
		[JsonProperty("loseAmount")]
		public dynamic LoseAmount { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
		[JsonProperty("itemId")]
		public int ItemId { get; set; }
		[JsonProperty("recoveryTime")]
		public string RecoveryTime { get; set; }
		[JsonProperty("winAmount")]
		public dynamic WinAmount { get; set; }
	}

	public class MissionDetailModel
	{
		[JsonProperty("conditionAttribute")]
		public string ConditionAttribute { get; set; }
		[JsonProperty("conditionCount")]
		public int ConditionCount { get; set; }
		[JsonProperty("conditionId")]
		public string ConditionId { get; set; }
		[JsonProperty("conditionRarity")]
		public string ConditionRarity { get; set; }
		[JsonProperty("conditionTimeFrom")]
		public string ConditionTimeFrom { get; set; }
		[JsonProperty("conditionTimeTo")]
		public string ConditionTimeTo { get; set; }
		[JsonProperty("missionGroupId")]
		public int MissionGroupId { get; set; }
		[JsonProperty("missionId")]
		public int MissionId { get; set; }
		[JsonProperty("missionType")]
		public int MissionType { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
		[JsonProperty("releaseMissionId")]
		public int ReleaseMissionId { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
		[JsonProperty("updateType")]
		public int UpdateType { get; set; }
		[JsonProperty("updateTypeParam")]
		public string UpdateTypeParam { get; set; }
	}

	public class MissionMainModel
	{
		[JsonProperty("category")]
		public int Category { get; set; }
		[JsonProperty("index")]
		public int Index { get; set; }
		[JsonProperty("missionGroupId")]
		public int MissionGroupId { get; set; }
		[JsonProperty("toDate")]
		public string ToDate { get; set; }
		[JsonProperty("fromDate")]
		public string FromDate { get; set; }
		[JsonProperty("eventId")]
		public int EventId { get; set; }
		[JsonProperty("missionName")]
		public string MissionName { get; set; }
	}

	public class MissionModel
	{
		[JsonProperty("missionMainMater")]
		public dynamic MissionMainMater { get; set; }
		[JsonProperty("missionDetailMaster")]
		public MissionDetailModel MissionDetailMaster { get; set; }
		[JsonProperty("missionRewardMater")]
		public dynamic MissionRewardMater { get; set; }
		[JsonProperty("isSelectMissionReward")]
		public bool IsSelectMissionReward { get; set; }
		[JsonProperty("releaseMissionModel")]
		public dynamic ReleaseMissionModel { get; set; }
		[JsonProperty("eventMainMater")]
		public dynamic EventMainMater { get; set; }
		[JsonProperty("clearCount")]
		public int ClearCount { get; set; }
		[JsonProperty("category")]
		public int Category { get; set; }
		[JsonProperty("index")]
		public int Index { get; set; }
		[JsonProperty("fromDate")]
		public string FromDate { get; set; }
		[JsonProperty("toDate")]
		public string ToDate { get; set; }
		[JsonProperty("missionId")]
		public int MissionId { get; set; }
		[JsonProperty("missionGroupId")]
		public int MissionGroupId { get; set; }
		[JsonProperty("missionCd")]
		public string MissionCd { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
		[JsonProperty("count")]
		public int Count { get; set; }
		[JsonProperty("itemId")]
		public int ItemId { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
		[JsonProperty("receiveCount")]
		public int ReceiveCount { get; set; }
		[JsonProperty("missionType")]
		public int MissionType { get; set; }
		[JsonProperty("releaseMissionId")]
		public int ReleaseMissionId { get; set; }
		[JsonProperty("conditionCount")]
		public int ConditionCount { get; set; }
		[JsonProperty("conditionId")]
		public string ConditionId { get; set; }
		[JsonProperty("isReceivable")]
		public bool IsReceivable { get; set; }
		[JsonProperty("isCompleted")]
		public bool IsCompleted { get; set; }
		[JsonProperty("isReceived")]
		public bool IsReceived { get; set; }
		[JsonProperty("isReleased")]
		public bool IsReleased { get; set; }
	}

	public class MissionRewardModel
	{
		[JsonProperty("count")]
		public int Count { get; set; }
		[JsonProperty("itemId")]
		public int ItemId { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
		[JsonProperty("missionId")]
		public int MissionId { get; set; }
		[JsonProperty("order")]
		public int Order { get; set; }
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
		[JsonProperty("rewardGroup")]
		public int RewardGroup { get; set; }
	}

	public class MyPageBannerModel
	{
		[JsonProperty("transitionParam1")]
		public int TransitionParam1 { get; set; }
		[JsonProperty("transitionParam2")]
		public int TransitionParam2 { get; set; }
		[JsonProperty("transitionParam3")]
		public int TransitionParam3 { get; set; }
		[JsonProperty("dateTo")]
		public string DateTo { get; set; }
		[JsonProperty("dateFrom")]
		public string DateFrom { get; set; }
		[JsonProperty("fileName")]
		public string FileName { get; set; }
		[JsonProperty("transitionId")]
		public int TransitionId { get; set; }
		[JsonProperty("bannerId")]
		public int BannerId { get; set; }
		[JsonProperty("order")]
		public int Order { get; set; }
	}

	public class MyPageEventModel
	{
		[JsonProperty("dateTo")]
		public string DateTo { get; set; }
		[JsonProperty("dateFrom")]
		public string DateFrom { get; set; }
		[JsonProperty("bgm")]
		public string Bgm { get; set; }
		[JsonProperty("background")]
		public string Background { get; set; }
	}

	public class MyPageMainModel
	{
		[JsonProperty("stageIdTo")]
		public int StageIdTo { get; set; }
		[JsonProperty("background")]
		public string Background { get; set; }
		[JsonProperty("stageIdFrom")]
		public int StageIdFrom { get; set; }
		[JsonProperty("bgm")]
		public string Bgm { get; set; }
	}

	public class MyPageNewsModel
	{
		[JsonProperty("newsId")]
		public int NewsId { get; set; }
		[JsonProperty("adultType")]
		public int AdultType { get; set; }
		[JsonProperty("order")]
		public int Order { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("bandId")]
		public int BandId { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
		[JsonProperty("dateFrom")]
		public string DateFrom { get; set; }
		[JsonProperty("dateTo")]
		public string DateTo { get; set; }
		[JsonProperty("conditionType")]
		public int ConditionType { get; set; }
		[JsonProperty("conditionFrom")]
		public int ConditionFrom { get; set; }
		[JsonProperty("conditionTo")]
		public int ConditionTo { get; set; }
	}

	public class MyPagePopupModel
	{
		[JsonProperty("popupId")]
		public int PopupId { get; set; }
		[JsonProperty("repeatType")]
		public int RepeatType { get; set; }
		[JsonProperty("dateFrom")]
		public string DateFrom { get; set; }
		[JsonProperty("dateTo")]
		public string DateTo { get; set; }
		[JsonProperty("order")]
		public int Order { get; set; }
		[JsonProperty("title")]
		public string Title { get; set; }
		[JsonProperty("fileName")]
		public string FileName { get; set; }
		[JsonProperty("description")]
		public string Description { get; set; }
		[JsonProperty("transitionId")]
		public int TransitionId { get; set; }
		[JsonProperty("transitionParam1")]
		public int TransitionParam1 { get; set; }
		[JsonProperty("transitionParam2")]
		public int TransitionParam2 { get; set; }
		[JsonProperty("transitionParam3")]
		public int TransitionParam3 { get; set; }
	}

	public class OrderPackModel
	{
		[JsonProperty("shopId")]
		public int ShopId { get; set; }
		[JsonProperty("listId")]
		public int ListId { get; set; }
		[JsonProperty("boxNo")]
		public int BoxNo { get; set; }
		[JsonProperty("selectIndex")]
		public int SelectIndex { get; set; }
		[JsonProperty("selectDate")]
		public string SelectDate { get; set; }
		[JsonProperty("decideDate")]
		public string DecideDate { get; set; }
		[JsonProperty("shopOrderPackMaster")]
		public ShopOrderPackModel ShopOrderPackMaster { get; set; }
	}

	public class PictureBookBaseModel
	{
		[JsonProperty("characterGroupMaster")]
		public CharacterGroupModel CharacterGroupMaster { get; set; }
		[JsonProperty("pictureBookDetailModelArray")]
		public List<PictureBookDetailModel> PictureBookDetailModelArray { get; set; }
		[JsonProperty("characterMainMasterArray")]
		public List<CharacterMainModel> CharacterMainMasterArray { get; set; }
		[JsonProperty("defaultRoomCharacterMainModel")]
		public dynamic DefaultRoomCharacterMainModel { get; set; }
		[JsonProperty("characterGroupId")]
		public int CharacterGroupId { get; set; }
		[JsonProperty("order")]
		public int Order { get; set; }
		[JsonProperty("roomSelectCharacterId")]
		public int RoomSelectCharacterId { get; set; }
		[JsonProperty("costumeId")]
		public int CostumeId { get; set; }
		[JsonProperty("roomSelectPictureBookDetailModel")]
		public dynamic RoomSelectPictureBookDetailModel { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("shortName")]
		public string ShortName { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
		[JsonProperty("contentsGroupId")]
		public int ContentsGroupId { get; set; }
		[JsonProperty("friendship")]
		public int Friendship { get; set; }
		[JsonProperty("contentsMasterArray")]
		public List<dynamic> ContentsMasterArray { get; set; }
		[JsonProperty("roomStoryMasterArray")]
		public List<dynamic> RoomStoryMasterArray { get; set; }
		[JsonProperty("voiceStoryMasterArray")]
		public List<dynamic> VoiceStoryMasterArray { get; set; }
		[JsonProperty("normalStoryMasterArray")]
		public List<dynamic> NormalStoryMasterArray { get; set; }
		[JsonProperty("adultStoryMasterArray")]
		public List<dynamic> AdultStoryMasterArray { get; set; }
		[JsonProperty("voiceContentsMasterArray")]
		public List<dynamic> VoiceContentsMasterArray { get; set; }
		[JsonProperty("userNormalStoryArray")]
		public List<dynamic> UserNormalStoryArray { get; set; }
		[JsonProperty("userAdultStoryArray")]
		public List<dynamic> UserAdultStoryArray { get; set; }
		[JsonProperty("userVoiceStoryArray")]
		public List<dynamic> UserVoiceStoryArray { get; set; }
		[JsonProperty("userRoomStoryMap")]
		public Dictionary<string, dynamic> UserRoomStoryMap { get; set; }
		[JsonProperty("userNormalStoryMap")]
		public Dictionary<string, dynamic> UserNormalStoryMap { get; set; }
		[JsonProperty("userVoiceStoryMap")]
		public Dictionary<string, dynamic> UserVoiceStoryMap { get; set; }
		[JsonProperty("userAdultStoryMap")]
		public Dictionary<string, dynamic> UserAdultStoryMap { get; set; }
		[JsonProperty("favoriteOrder")]
		public int FavoriteOrder { get; set; }
	}

	public class PictureBookDetailModel
	{
		[JsonProperty("characterMainMaster")]
		public CharacterMainModel CharacterMainMaster { get; set; }
		[JsonProperty("characterGroupMaster")]
		public CharacterGroupModel CharacterGroupMaster { get; set; }
		[JsonProperty("characterFavoriteMasterArray")]
		public List<CharacterFavoriteModel> CharacterFavoriteMasterArray { get; set; }
		[JsonProperty("attribute")]
		public int Attribute { get; set; }
		[JsonProperty("rarity")]
		public int Rarity { get; set; }
		[JsonProperty("exceedLimit")]
		public int ExceedLimit { get; set; }
		[JsonProperty("characterId")]
		public int CharacterId { get; set; }
		[JsonProperty("characterGroupId")]
		public int CharacterGroupId { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("shortName")]
		public string ShortName { get; set; }
		[JsonProperty("skinName")]
		public string SkinName { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
		[JsonProperty("characterType")]
		public int CharacterType { get; set; }
		[JsonProperty("visibleDate")]
		public string VisibleDate { get; set; }
		[JsonProperty("maxFriendship")]
		public dynamic MaxFriendship { get; set; }
		[JsonProperty("union")]
		public int Union { get; set; }
		[JsonProperty("readingName")]
		public string ReadingName { get; set; }
		[JsonProperty("friendshipRate")]
		public double FriendshipRate { get; set; }
		[JsonProperty("friendshipBonusHp")]
		public int FriendshipBonusHp { get; set; }
		[JsonProperty("friendshipBonusAtk")]
		public int FriendshipBonusAtk { get; set; }
		[JsonProperty("friendshipBonusDef")]
		public int FriendshipBonusDef { get; set; }
		[JsonProperty("contentsGroupId")]
		public int ContentsGroupId { get; set; }
		[JsonProperty("friendship")]
		public int Friendship { get; set; }
		[JsonProperty("contentsMasterArray")]
		public List<dynamic> ContentsMasterArray { get; set; }
		[JsonProperty("roomStoryMasterArray")]
		public List<dynamic> RoomStoryMasterArray { get; set; }
		[JsonProperty("normalStoryMasterArray")]
		public List<dynamic> NormalStoryMasterArray { get; set; }
		[JsonProperty("adultStoryMasterArray")]
		public List<dynamic> AdultStoryMasterArray { get; set; }
		[JsonProperty("voiceStoryMasterArray")]
		public List<dynamic> VoiceStoryMasterArray { get; set; }
		[JsonProperty("voiceContentsMasterArray")]
		public List<dynamic> VoiceContentsMasterArray { get; set; }
		[JsonProperty("userNormalStoryArray")]
		public List<dynamic> UserNormalStoryArray { get; set; }
		[JsonProperty("userAdultStoryArray")]
		public List<dynamic> UserAdultStoryArray { get; set; }
		[JsonProperty("userVoiceStoryArray")]
		public List<dynamic> UserVoiceStoryArray { get; set; }
		[JsonProperty("userRoomStoryMap")]
		public Dictionary<string, dynamic> UserRoomStoryMap { get; set; }
		[JsonProperty("userNormalStoryMap")]
		public Dictionary<string, dynamic> UserNormalStoryMap { get; set; }
		[JsonProperty("userAdultStoryMap")]
		public Dictionary<string, dynamic> UserAdultStoryMap { get; set; }
		[JsonProperty("userVoiceStoryMap")]
		public Dictionary<string, dynamic> UserVoiceStoryMap { get; set; }
		[JsonProperty("characterFriendshipContentsMasterArray")]
		public List<dynamic> CharacterFriendshipContentsMasterArray { get; set; }
		[JsonProperty("contentsId")]
		public int ContentsId { get; set; }
		[JsonProperty("conditionType1")]
		public int ConditionType1 { get; set; }
		[JsonProperty("conditionType2")]
		public int ConditionType2 { get; set; }
		[JsonProperty("conditionValue1")]
		public int ConditionValue1 { get; set; }
		[JsonProperty("conditionValue2")]
		public int ConditionValue2 { get; set; }
		[JsonProperty("storyId")]
		public int StoryId { get; set; }
		[JsonProperty("characterStoryContentsMasterArray")]
		public List<dynamic> CharacterStoryContentsMasterArray { get; set; }
		[JsonProperty("lastReleaseFriendshipContentsMaster")]
		public dynamic LastReleaseFriendshipContentsMaster { get; set; }
		[JsonProperty("nextReleaseFriendshipContentsMaster")]
		public dynamic NextReleaseFriendshipContentsMaster { get; set; }
		[JsonProperty("needFriendshipForNextContentsRelease")]
		public dynamic NeedFriendshipForNextContentsRelease { get; set; }
		[JsonProperty("nextReleaseFriendshopContentsText")]
		public string NextReleaseFriendshopContentsText { get; set; }
		[JsonProperty("pictureBookDetailVoiceInfoMap")]
		public Dictionary<string, dynamic> PictureBookDetailVoiceInfoMap { get; set; }
		[JsonProperty("linkModel")]
		public dynamic LinkModel { get; set; }
		[JsonProperty("linkerParentPictureDetailModel")]
		public dynamic LinkerParentPictureDetailModel { get; set; }
	}

	public class PrefModel
	{
		[JsonProperty("alterCardLook")]
		public string AlterCardLook { get; set; }
		[JsonProperty("eventFirstLook_123")]
		public string EventFirstLook_123 { get; set; }
		[JsonProperty("eventFirstLook_1320")]
		public string EventFirstLook_1320 { get; set; }
		[JsonProperty("eventFirstLook_1325")]
		public string EventFirstLook_1325 { get; set; }
		[JsonProperty("eventFirstLook_1331")]
		public string EventFirstLook_1331 { get; set; }
		[JsonProperty("eventFirstLook_1336")]
		public string EventFirstLook_1336 { get; set; }
		[JsonProperty("eventFirstLook_1341")]
		public string EventFirstLook_1341 { get; set; }
		[JsonProperty("eventFirstLook_1344")]
		public string EventFirstLook_1344 { get; set; }
		[JsonProperty("eventFirstLook_1346")]
		public string EventFirstLook_1346 { get; set; }
		[JsonProperty("eventFirstLook_1356")]
		public string EventFirstLook_1356 { get; set; }
		[JsonProperty("eventFirstLook_1363")]
		public string EventFirstLook_1363 { get; set; }
		[JsonProperty("eventFirstLook_1365")]
		public string EventFirstLook_1365 { get; set; }
		[JsonProperty("eventFirstLook_1369")]
		public string EventFirstLook_1369 { get; set; }
		[JsonProperty("eventFirstLook_1375")]
		public string EventFirstLook_1375 { get; set; }
		[JsonProperty("eventFirstLook_1379")]
		public string EventFirstLook_1379 { get; set; }
		[JsonProperty("eventFirstLook_1386")]
		public string EventFirstLook_1386 { get; set; }
		[JsonProperty("eventFirstLook_320")]
		public string EventFirstLook_320 { get; set; }
		[JsonProperty("eventFirstLook_321")]
		public string EventFirstLook_321 { get; set; }
		[JsonProperty("eventFirstLook_322")]
		public string EventFirstLook_322 { get; set; }
		[JsonProperty("eventFirstLook_323")]
		public string EventFirstLook_323 { get; set; }
		[JsonProperty("eventFirstLook_324")]
		public string EventFirstLook_324 { get; set; }
		[JsonProperty("eventFirstLook_325")]
		public string EventFirstLook_325 { get; set; }
		[JsonProperty("eventFirstLook_328")]
		public string EventFirstLook_328 { get; set; }
		[JsonProperty("eventFirstLook_330")]
		public string EventFirstLook_330 { get; set; }
		[JsonProperty("eventFirstLook_331")]
		public string EventFirstLook_331 { get; set; }
		[JsonProperty("eventFirstLook_332")]
		public string EventFirstLook_332 { get; set; }
		[JsonProperty("eventFirstLook_334")]
		public string EventFirstLook_334 { get; set; }
		[JsonProperty("eventFirstLook_336")]
		public string EventFirstLook_336 { get; set; }
		[JsonProperty("eventFirstLook_337")]
		public string EventFirstLook_337 { get; set; }
		[JsonProperty("eventFirstLook_338")]
		public string EventFirstLook_338 { get; set; }
		[JsonProperty("eventFirstLook_339")]
		public string EventFirstLook_339 { get; set; }
		[JsonProperty("eventFirstLook_340")]
		public string EventFirstLook_340 { get; set; }
		[JsonProperty("eventFirstLook_341")]
		public string EventFirstLook_341 { get; set; }
		[JsonProperty("eventFirstLook_342")]
		public string EventFirstLook_342 { get; set; }
		[JsonProperty("eventFirstLook_343")]
		public string EventFirstLook_343 { get; set; }
		[JsonProperty("eventFirstLook_344")]
		public string EventFirstLook_344 { get; set; }
		[JsonProperty("eventFirstLook_345")]
		public string EventFirstLook_345 { get; set; }
		[JsonProperty("eventFirstLook_346")]
		public string EventFirstLook_346 { get; set; }
		[JsonProperty("eventFirstLook_347")]
		public string EventFirstLook_347 { get; set; }
		[JsonProperty("eventFirstLook_348")]
		public string EventFirstLook_348 { get; set; }
		[JsonProperty("eventFirstLook_349")]
		public string EventFirstLook_349 { get; set; }
		[JsonProperty("eventFirstLook_350")]
		public string EventFirstLook_350 { get; set; }
		[JsonProperty("eventFirstLook_351")]
		public string EventFirstLook_351 { get; set; }
		[JsonProperty("eventFirstLook_352")]
		public string EventFirstLook_352 { get; set; }
		[JsonProperty("eventFirstLook_353")]
		public string EventFirstLook_353 { get; set; }
		[JsonProperty("eventFirstLook_354")]
		public string EventFirstLook_354 { get; set; }
		[JsonProperty("eventFirstLook_355")]
		public string EventFirstLook_355 { get; set; }
		[JsonProperty("eventFirstLook_356")]
		public string EventFirstLook_356 { get; set; }
		[JsonProperty("eventFirstLook_357")]
		public string EventFirstLook_357 { get; set; }
		[JsonProperty("eventFirstLook_359")]
		public string EventFirstLook_359 { get; set; }
		[JsonProperty("eventFirstLook_360")]
		public string EventFirstLook_360 { get; set; }
		[JsonProperty("eventFirstLook_361")]
		public string EventFirstLook_361 { get; set; }
		[JsonProperty("eventFirstLook_362")]
		public string EventFirstLook_362 { get; set; }
		[JsonProperty("eventFirstLook_363")]
		public string EventFirstLook_363 { get; set; }
		[JsonProperty("eventFirstLook_364")]
		public string EventFirstLook_364 { get; set; }
		[JsonProperty("eventFirstLook_365")]
		public string EventFirstLook_365 { get; set; }
		[JsonProperty("eventFirstLook_368")]
		public string EventFirstLook_368 { get; set; }
		[JsonProperty("eventFirstLook_369")]
		public string EventFirstLook_369 { get; set; }
		[JsonProperty("eventFirstLook_370")]
		public string EventFirstLook_370 { get; set; }
		[JsonProperty("eventFirstLook_371")]
		public string EventFirstLook_371 { get; set; }
		[JsonProperty("eventFirstLook_373")]
		public string EventFirstLook_373 { get; set; }
		[JsonProperty("eventFirstLook_375")]
		public string EventFirstLook_375 { get; set; }
		[JsonProperty("eventFirstLook_377")]
		public string EventFirstLook_377 { get; set; }
		[JsonProperty("eventFirstLook_378")]
		public string EventFirstLook_378 { get; set; }
		[JsonProperty("eventFirstLook_379")]
		public string EventFirstLook_379 { get; set; }
		[JsonProperty("eventFirstLook_380")]
		public string EventFirstLook_380 { get; set; }
		[JsonProperty("eventFirstLook_384")]
		public string EventFirstLook_384 { get; set; }
		[JsonProperty("eventFirstLook_385")]
		public string EventFirstLook_385 { get; set; }
		[JsonProperty("eventFirstLook_386")]
		public string EventFirstLook_386 { get; set; }
		[JsonProperty("eventFirstLook_387")]
		public string EventFirstLook_387 { get; set; }
		[JsonProperty("eventFirstLook_388")]
		public string EventFirstLook_388 { get; set; }
		[JsonProperty("eventFirstLook_389")]
		public string EventFirstLook_389 { get; set; }
		[JsonProperty("eventFirstLook_390")]
		public string EventFirstLook_390 { get; set; }
		[JsonProperty("eventFirstLook_391")]
		public string EventFirstLook_391 { get; set; }
		[JsonProperty("eventFirstLook_416")]
		public string EventFirstLook_416 { get; set; }
		[JsonProperty("eventFirstLook_417")]
		public string EventFirstLook_417 { get; set; }
		[JsonProperty("eventFirstLook_418")]
		public string EventFirstLook_418 { get; set; }
		[JsonProperty("exchangeArenaLook")]
		public string ExchangeArenaLook { get; set; }
		[JsonProperty("exchangeDailyLook")]
		public string ExchangeDailyLook { get; set; }
		[JsonProperty("exchangeMonthlyLook")]
		public string ExchangeMonthlyLook { get; set; }
		[JsonProperty("exchangeNotice")]
		public string ExchangeNotice { get; set; }
		[JsonProperty("firstQualityPop")]
		public string FirstQualityPop { get; set; }
		[JsonProperty("myPageDeckOutChange")]
		public string MyPageDeckOutChange { get; set; }
		[JsonProperty("myPageNewsRead")]
		public string MyPageNewsRead { get; set; }
		[JsonProperty("myPagePopupRead")]
		public string MyPagePopupRead { get; set; }
		[JsonProperty("pref")]
		public UserPrefModel Pref { get; set; }
		[JsonProperty("receiveTypeMission")]
		public string ReceiveTypeMission { get; set; }
		[JsonProperty("receiveTypePresent")]
		public string ReceiveTypePresent { get; set; }
		[JsonProperty("shopFreeGemDailyLook")]
		public string ShopFreeGemDailyLook { get; set; }
		[JsonProperty("shopMonthlyLook")]
		public string ShopMonthlyLook { get; set; }
		[JsonProperty("sortOrderCharacter")]
		public string SortOrderCharacter { get; set; }
		[JsonProperty("sortOrderWarehouseEquipment")]
		public string SortOrderWarehouseEquipment { get; set; }
		[JsonProperty("sortOrderWarehouseOtherItem")]
		public string SortOrderWarehouseOtherItem { get; set; }
		[JsonProperty("sortOrderWarehouseStorageCharacter")]
		public string SortOrderWarehouseStorageCharacter { get; set; }
		[JsonProperty("sortOrderWarehouseStorageEquipment")]
		public string SortOrderWarehouseStorageEquipment { get; set; }
		[JsonProperty("sortOrderWarehouseStorageMaterial")]
		public string SortOrderWarehouseStorageMaterial { get; set; }
		[JsonProperty("sortTypeCharacter")]
		public string SortTypeCharacter { get; set; }
		[JsonProperty("sortTypeWarehouseEquipment")]
		public string SortTypeWarehouseEquipment { get; set; }
		[JsonProperty("sortTypeWarehouseOtherItem")]
		public string SortTypeWarehouseOtherItem { get; set; }
		[JsonProperty("sortTypeWarehouseStorageCharacter")]
		public string SortTypeWarehouseStorageCharacter { get; set; }
		[JsonProperty("sortTypeWarehouseStorageEquipment")]
		public string SortTypeWarehouseStorageEquipment { get; set; }
		[JsonProperty("sortTypeWarehouseStorageMaterial")]
		public string SortTypeWarehouseStorageMaterial { get; set; }
		[JsonProperty("tutorialHelpRead_DeckScene")]
		public string TutorialHelpRead_DeckScene { get; set; }
		[JsonProperty("tutorialHelpRead_ExchangeScene")]
		public string TutorialHelpRead_ExchangeScene { get; set; }
		[JsonProperty("tutorialHelpRead_MissionScene")]
		public string TutorialHelpRead_MissionScene { get; set; }
		[JsonProperty("tutorialHelpRead_PromoteCharacterSelectScene")]
		public string TutorialHelpRead_PromoteCharacterSelectScene { get; set; }
		[JsonProperty("tutorialHelpRead_RoomCharacterScene")]
		public string TutorialHelpRead_RoomCharacterScene { get; set; }
		[JsonProperty("tutorialHelpRead_RoomScene")]
		public string TutorialHelpRead_RoomScene { get; set; }
		[JsonProperty("tutorialHelpRead_ShopScene")]
		public string TutorialHelpRead_ShopScene { get; set; }
		[JsonProperty("tutorialHelpRead_StoryScene")]
		public string TutorialHelpRead_StoryScene { get; set; }
		[JsonProperty("tutorialHelpRead_WarehouseScene")]
		public string TutorialHelpRead_WarehouseScene { get; set; }
		[JsonProperty("tutorialHelpRead_WeekScene")]
		public string TutorialHelpRead_WeekScene { get; set; }
	}

	public class PresentMessageModel
	{
		[JsonProperty("text")]
		public string Text { get; set; }
		[JsonProperty("messageId")]
		public int MessageId { get; set; }
	}

	public class PvPCharacterModel
	{
		[JsonProperty("pictureBookDetailModel")]
		public PictureBookDetailModel PictureBookDetailModel { get; set; }
		[JsonProperty("characterMainMaster")]
		public CharacterMainModel CharacterMainMaster { get; set; }
		[JsonProperty("characterId")]
		public int CharacterId { get; set; }
		[JsonProperty("availableEquipmentWeaponModelList")]
		public List<dynamic> AvailableEquipmentWeaponModelList { get; set; }
		[JsonProperty("availableEquipmentProtectorModelList")]
		public List<dynamic> AvailableEquipmentProtectorModelList { get; set; }
		[JsonProperty("subAttribute")]
		public int SubAttribute { get; set; }
		[JsonProperty("skillLevel")]
		public int SkillLevel { get; set; }
		[JsonProperty("abilityLevel1")]
		public int AbilityLevel1 { get; set; }
		[JsonProperty("abilityLevel2")]
		public int AbilityLevel2 { get; set; }
		[JsonProperty("abilityLevel3")]
		public int AbilityLevel3 { get; set; }
		[JsonProperty("linkerId")]
		public int LinkerId { get; set; }
	}

	public class PvPClassModel
	{
		[JsonProperty("class")]
		public int Class { get; set; }
		[JsonProperty("coinCoefficient")]
		public int CoinCoefficient { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("pointFrom")]
		public int PointFrom { get; set; }
		[JsonProperty("pointTo")]
		public int PointTo { get; set; }
		[JsonProperty("winPoint")]
		public dynamic WinPoint { get; set; }
	}

	public class PvPClassRewardModel
	{
		[JsonProperty("class")]
		public int Class { get; set; }
		[JsonProperty("order")]
		public int Order { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
		[JsonProperty("itemId")]
		public int ItemId { get; set; }
		[JsonProperty("count")]
		public int Count { get; set; }
	}

	public class PvPDeckModel
	{
	}

	public class PvPEquipmentModel
	{
	}

	public class PvPMainModel
	{
		[JsonProperty("season")]
		public int Season { get; set; }
		[JsonProperty("fromDate")]
		public string FromDate { get; set; }
		[JsonProperty("toDate")]
		public string ToDate { get; set; }
		[JsonProperty("maxStamina")]
		public int MaxStamina { get; set; }
		[JsonProperty("recoveryTime")]
		public string RecoveryTime { get; set; }
		[JsonProperty("recoveryStamina")]
		public int RecoveryStamina { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
		[JsonProperty("itemId")]
		public int ItemId { get; set; }
		[JsonProperty("turn")]
		public int Turn { get; set; }
		[JsonProperty("winPointBasic")]
		public int WinPointBasic { get; set; }
		[JsonProperty("lostTurnPointBasic")]
		public int LostTurnPointBasic { get; set; }
		[JsonProperty("lostAnnihilationPointBasic")]
		public int LostAnnihilationPointBasic { get; set; }
		[JsonProperty("exchangeId")]
		public int ExchangeId { get; set; }
	}

	public class PvPModel
	{
		[JsonProperty("fromDate")]
		public string FromDate { get; set; }
		[JsonProperty("lastRecoveryDate")]
		public string LastRecoveryDate { get; set; }
		[JsonProperty("lastUpdateDate")]
		public string LastUpdateDate { get; set; }
		[JsonProperty("maxScore")]
		public int MaxScore { get; set; }
		[JsonProperty("maxStamina")]
		public int MaxStamina { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("nextClassNeedPoint")]
		public dynamic NextClassNeedPoint { get; set; }
		[JsonProperty("nextClassPoint")]
		public dynamic NextClassPoint { get; set; }
		[JsonProperty("nextPvPClassMaster")]
		public dynamic NextPvPClassMaster { get; set; }
		[JsonProperty("nextStaminaRecoveryTime")]
		public string NextStaminaRecoveryTime { get; set; }
		[JsonProperty("point")]
		public int Point { get; set; }
		[JsonProperty("pvPClassMaster")]
		public PvPClassModel PvPClassMaster { get; set; }
		[JsonProperty("pvPMainMaster")]
		public PvPMainModel PvPMainMaster { get; set; }
		[JsonProperty("pvPMedalItemId")]
		public int PvPMedalItemId { get; set; }
		[JsonProperty("pvpClass")]
		public int PvpClass { get; set; }
		[JsonProperty("recoveryStamina")]
		public int RecoveryStamina { get; set; }
		[JsonProperty("season")]
		public int Season { get; set; }
		[JsonProperty("selectedPlayCount")]
		public int SelectedPlayCount { get; set; }
		[JsonProperty("stamina")]
		public int Stamina { get; set; }
		[JsonProperty("staminaRecoveryTimeArray")]
		public List<dynamic> StaminaRecoveryTimeArray { get; set; }
		[JsonProperty("toDate")]
		public string ToDate { get; set; }
		[JsonProperty("updateCount")]
		public int UpdateCount { get; set; }
		[JsonProperty("winCount")]
		public int WinCount { get; set; }
	}

	public class PvPPictureBookDetailModel
	{
	}

	public class PvPSolidEquipmentModel
	{
	}

	public class QuestAchieveModel
	{
		[JsonProperty("achieveId")]
		public int AchieveId { get; set; }
		[JsonProperty("achieveType")]
		public int AchieveType { get; set; }
		[JsonProperty("conditionValue")]
		public int ConditionValue { get; set; }
		[JsonProperty("count")]
		public int Count { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
	}

	public class QuestAreaModel
	{
		[JsonProperty("rewardItemId")]
		public int RewardItemId { get; set; }
		[JsonProperty("areaId")]
		public int AreaId { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("toDate")]
		public string ToDate { get; set; }
		[JsonProperty("startTime")]
		public string StartTime { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
		[JsonProperty("rewardItemCount")]
		public int RewardItemCount { get; set; }
		[JsonProperty("imageName")]
		public string ImageName { get; set; }
		[JsonProperty("worldId")]
		public int WorldId { get; set; }
		[JsonProperty("index")]
		public int Index { get; set; }
		[JsonProperty("fromDate")]
		public string FromDate { get; set; }
		[JsonProperty("endTime")]
		public string EndTime { get; set; }
		[JsonProperty("rewardItemType")]
		public int RewardItemType { get; set; }
		[JsonProperty("weekTypes")]
		public string WeekTypes { get; set; }
		[JsonProperty("difficult")]
		public int Difficult { get; set; }
		[JsonProperty("maxBattleCount")]
		public int MaxBattleCount { get; set; }
	}

	public class QuestDropModel
	{
		[JsonProperty("itemId")]
		public int ItemId { get; set; }
		[JsonProperty("skipTarget")]
		public int SkipTarget { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
		[JsonProperty("level")]
		public int Level { get; set; }
		[JsonProperty("normalTarget")]
		public int NormalTarget { get; set; }
		[JsonProperty("rate")]
		public int Rate { get; set; }
		[JsonProperty("stageId")]
		public int StageId { get; set; }
		[JsonProperty("countTo")]
		public int CountTo { get; set; }
		[JsonProperty("countFrom")]
		public int CountFrom { get; set; }
		[JsonProperty("group")]
		public dynamic Group { get; set; }
		[JsonProperty("order")]
		public int Order { get; set; }
		[JsonProperty("exceedLimit")]
		public int ExceedLimit { get; set; }
		[JsonProperty("dropType")]
		public int DropType { get; set; }
	}

	public class QuestEventPointModel
	{
		[JsonProperty("countFrom")]
		public int CountFrom { get; set; }
		[JsonProperty("countTo")]
		public int CountTo { get; set; }
		[JsonProperty("index")]
		public int Index { get; set; }
		[JsonProperty("itemId")]
		public int ItemId { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
		[JsonProperty("normalTarget")]
		public int NormalTarget { get; set; }
		[JsonProperty("rate")]
		public int Rate { get; set; }
		[JsonProperty("skipTarget")]
		public int SkipTarget { get; set; }
		[JsonProperty("stageId")]
		public int StageId { get; set; }
	}

	public class QuestIconChangeModel
	{
		[JsonProperty("questIconChangeId")]
		public int QuestIconChangeId { get; set; }
		[JsonProperty("questIconId")]
		public int QuestIconId { get; set; }
		[JsonProperty("iconType")]
		public int IconType { get; set; }
		[JsonProperty("fromDate")]
		public string FromDate { get; set; }
		[JsonProperty("toDate")]
		public string ToDate { get; set; }
	}

	public class QuestIconModel
	{
		[JsonProperty("questIconId")]
		public int QuestIconId { get; set; }
		[JsonProperty("iconName")]
		public string IconName { get; set; }
	}

	public class QuestModel
	{
		[JsonProperty("areaDifficult")]
		public dynamic AreaDifficult { get; set; }
		[JsonProperty("areaId")]
		public int AreaId { get; set; }
		[JsonProperty("areaName")]
		public string AreaName { get; set; }
		[JsonProperty("areaText")]
		public string AreaText { get; set; }
		[JsonProperty("category")]
		public int Category { get; set; }
		[JsonProperty("clearCount")]
		public int ClearCount { get; set; }
		[JsonProperty("defaultSkillGaugeRate")]
		public int DefaultSkillGaugeRate { get; set; }
		[JsonProperty("isClear")]
		public bool IsClear { get; set; }
		[JsonProperty("isClearMission1")]
		public int IsClearMission1 { get; set; }
		[JsonProperty("isClearMission2")]
		public int IsClearMission2 { get; set; }
		[JsonProperty("isClearMission3")]
		public int IsClearMission3 { get; set; }
		[JsonProperty("isCompletedMissions")]
		public bool IsCompletedMissions { get; set; }
		[JsonProperty("isDayChallengeCountRemain")]
		public bool IsDayChallengeCountRemain { get; set; }
		[JsonProperty("lastPlayDate")]
		public string LastPlayDate { get; set; }
		[JsonProperty("lastSkipDate")]
		public string LastSkipDate { get; set; }
		[JsonProperty("maxClearCount")]
		public int MaxClearCount { get; set; }
		[JsonProperty("maxDayPlayCount")]
		public int MaxDayPlayCount { get; set; }
		[JsonProperty("maxSkipCount")]
		public int MaxSkipCount { get; set; }
		[JsonProperty("playCount")]
		public int PlayCount { get; set; }
		[JsonProperty("questAchieveMaster1")]
		public dynamic QuestAchieveMaster1 { get; set; }
		[JsonProperty("questAchieveMaster2")]
		public dynamic QuestAchieveMaster2 { get; set; }
		[JsonProperty("questAchieveMaster3")]
		public dynamic QuestAchieveMaster3 { get; set; }
		[JsonProperty("questAreaMaster")]
		public QuestAreaModel QuestAreaMaster { get; set; }
		[JsonProperty("questDropMasterArray")]
		public List<QuestDropModel> QuestDropMasterArray { get; set; }
		[JsonProperty("questEndStoryMaster")]
		public dynamic QuestEndStoryMaster { get; set; }
		[JsonProperty("questEndUserStoryModel")]
		public dynamic QuestEndUserStoryModel { get; set; }
		[JsonProperty("questStageMaster")]
		public QuestStageModel QuestStageMaster { get; set; }
		[JsonProperty("questStartStoryMaster")]
		public dynamic QuestStartStoryMaster { get; set; }
		[JsonProperty("questStartUserStoryModel")]
		public dynamic QuestStartUserStoryModel { get; set; }
		[JsonProperty("questWorldMaster")]
		public QuestWorldModel QuestWorldMaster { get; set; }
		[JsonProperty("recommendPower")]
		public int RecommendPower { get; set; }
		[JsonProperty("releaseStageId")]
		public int ReleaseStageId { get; set; }
		[JsonProperty("skipItemId")]
		public int SkipItemId { get; set; }
		[JsonProperty("stageId")]
		public int StageId { get; set; }
		[JsonProperty("stageName")]
		public string StageName { get; set; }
		[JsonProperty("stamina")]
		public int Stamina { get; set; }
		[JsonProperty("todayPlayCount")]
		public int TodayPlayCount { get; set; }
		[JsonProperty("todaySkipCount")]
		public int TodaySkipCount { get; set; }
		[JsonProperty("worldCategory")]
		public dynamic WorldCategory { get; set; }
		[JsonProperty("worldId")]
		public int WorldId { get; set; }
		[JsonProperty("worldName")]
		public string WorldName { get; set; }
	}

	public class QuestRestrictionGroupModel
	{
		[JsonProperty("questType")]
		public int QuestType { get; set; }
		[JsonProperty("questId")]
		public int QuestId { get; set; }
		[JsonProperty("restrictionGroupId")]
		public int RestrictionGroupId { get; set; }
		[JsonProperty("errMsgText")]
		public string ErrMsgText { get; set; }
	}

	public class QuestRestrictionMainModel
	{
		[JsonProperty("restrictionGroupId")]
		public int RestrictionGroupId { get; set; }
		[JsonProperty("restrictionType")]
		public int RestrictionType { get; set; }
		[JsonProperty("conditionValue")]
		public int ConditionValue { get; set; }
	}

	public class QuestScenarioModel
	{
		[JsonProperty("worldId")]
		public int WorldId { get; set; }
		[JsonProperty("scenarioNum")]
		public int ScenarioNum { get; set; }
	}

	public class QuestStageConditionModel
	{
		[JsonProperty("stageId")]
		public int StageId { get; set; }
		[JsonProperty("conditionType")]
		public int ConditionType { get; set; }
		[JsonProperty("conditionId")]
		public string ConditionId { get; set; }
		[JsonProperty("conditionValue")]
		public int ConditionValue { get; set; }
	}

	public class QuestStageModel
	{
		[JsonProperty("worldId")]
		public int WorldId { get; set; }
		[JsonProperty("areaId")]
		public int AreaId { get; set; }
		[JsonProperty("stageId")]
		public int StageId { get; set; }
		[JsonProperty("releaseStageId")]
		public int ReleaseStageId { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
		[JsonProperty("recommendPower")]
		public int RecommendPower { get; set; }
		[JsonProperty("stamina")]
		public int Stamina { get; set; }
		[JsonProperty("maxBattleCount")]
		public int MaxBattleCount { get; set; }
		[JsonProperty("skipItemId")]
		public int SkipItemId { get; set; }
		[JsonProperty("maxSkipCount")]
		public int MaxSkipCount { get; set; }
		[JsonProperty("maxClearCount")]
		public int MaxClearCount { get; set; }
		[JsonProperty("userExpFrom")]
		public int UserExpFrom { get; set; }
		[JsonProperty("userExpTo")]
		public int UserExpTo { get; set; }
		[JsonProperty("characterExpFrom")]
		public int CharacterExpFrom { get; set; }
		[JsonProperty("characterExpTo")]
		public int CharacterExpTo { get; set; }
		[JsonProperty("goldFrom")]
		public int GoldFrom { get; set; }
		[JsonProperty("goldTo")]
		public int GoldTo { get; set; }
		[JsonProperty("achieveId1")]
		public int AchieveId1 { get; set; }
		[JsonProperty("achieveId2")]
		public int AchieveId2 { get; set; }
		[JsonProperty("achieveId3")]
		public int AchieveId3 { get; set; }
		[JsonProperty("rewardItemType")]
		public int RewardItemType { get; set; }
		[JsonProperty("rewardItemId")]
		public int RewardItemId { get; set; }
		[JsonProperty("rewardItemCount")]
		public int RewardItemCount { get; set; }
		[JsonProperty("defaultSkillGaugeRate")]
		public int DefaultSkillGaugeRate { get; set; }
		[JsonProperty("background")]
		public string Background { get; set; }
		[JsonProperty("normalWaveBgm")]
		public string NormalWaveBgm { get; set; }
		[JsonProperty("bossWaveBgm")]
		public string BossWaveBgm { get; set; }
	}

	public class QuestWorldModel
	{
		[JsonProperty("worldId")]
		public int WorldId { get; set; }
		[JsonProperty("category")]
		public int Category { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("imageName")]
		public string ImageName { get; set; }
		[JsonProperty("maxBattleCount")]
		public int MaxBattleCount { get; set; }
		[JsonProperty("rewardItemType")]
		public int RewardItemType { get; set; }
		[JsonProperty("rewardItemId")]
		public int RewardItemId { get; set; }
		[JsonProperty("rewardItemCount")]
		public int RewardItemCount { get; set; }
		[JsonProperty("fromDate")]
		public string FromDate { get; set; }
		[JsonProperty("toDate")]
		public string ToDate { get; set; }
	}

	public class RaceAbilityEffectGroupModel
	{
		[JsonProperty("effectGroupId")]
		public int EffectGroupId { get; set; }
		[JsonProperty("effectId")]
		public int EffectId { get; set; }
		[JsonProperty("order")]
		public int Order { get; set; }
	}

	public class RaceAbilityEffectModel
	{
		[JsonProperty("targetType")]
		public int TargetType { get; set; }
		[JsonProperty("effectType")]
		public int EffectType { get; set; }
		[JsonProperty("effectValueType")]
		public int EffectValueType { get; set; }
		[JsonProperty("effectValue")]
		public int EffectValue { get; set; }
		[JsonProperty("rate")]
		public int Rate { get; set; }
		[JsonProperty("effectId")]
		public int EffectId { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
		[JsonProperty("effectTiming")]
		public int EffectTiming { get; set; }
	}

	public class RaceAbilityGroupModel
	{
		[JsonProperty("abilityId")]
		public int AbilityId { get; set; }
		[JsonProperty("category")]
		public int Category { get; set; }
		[JsonProperty("abilityGroupId")]
		public int AbilityGroupId { get; set; }
		[JsonProperty("order")]
		public int Order { get; set; }
	}

	public class RaceAbilityMainModel
	{
		[JsonProperty("abilityId")]
		public int AbilityId { get; set; }
		[JsonProperty("effectGroupId")]
		public int EffectGroupId { get; set; }
		[JsonProperty("conditionType")]
		public int ConditionType { get; set; }
		[JsonProperty("conditionValue")]
		public int ConditionValue { get; set; }
	}

	public class RaceAreaModel
	{
		[JsonProperty("season")]
		public int Season { get; set; }
		[JsonProperty("areaId")]
		public int AreaId { get; set; }
		[JsonProperty("weekTypes")]
		public string WeekTypes { get; set; }
		[JsonProperty("stageGroupId")]
		public int StageGroupId { get; set; }
		[JsonProperty("description")]
		public string Description { get; set; }
	}

	public class RaceCharacterFreeModel
	{
		[JsonProperty("characterId")]
		public int CharacterId { get; set; }
		[JsonProperty("fromDate")]
		public string FromDate { get; set; }
		[JsonProperty("toDate")]
		public string ToDate { get; set; }
	}

	public class RaceCharacterMainModel
	{
		[JsonProperty("fortifyType")]
		public int FortifyType { get; set; }
		[JsonProperty("abilityGroupId")]
		public int AbilityGroupId { get; set; }
		[JsonProperty("minStatusId")]
		public int MinStatusId { get; set; }
		[JsonProperty("maxStatusId")]
		public int MaxStatusId { get; set; }
		[JsonProperty("characterId")]
		public int CharacterId { get; set; }
		[JsonProperty("textGroupId")]
		public int TextGroupId { get; set; }
		[JsonProperty("boostType")]
		public int BoostType { get; set; }
		[JsonProperty("racingNumber")]
		public int RacingNumber { get; set; }
		[JsonProperty("maxPlayCount")]
		public int MaxPlayCount { get; set; }
	}

	public class RaceCharacterModel
	{
		[JsonProperty("characterId")]
		public int CharacterId { get; set; }
		[JsonProperty("addP1")]
		public int AddP1 { get; set; }
		[JsonProperty("addP2")]
		public int AddP2 { get; set; }
		[JsonProperty("addP3")]
		public int AddP3 { get; set; }
		[JsonProperty("addP4")]
		public int AddP4 { get; set; }
		[JsonProperty("stamina")]
		public int Stamina { get; set; }
		[JsonProperty("raceCharacterMainMaster")]
		public RaceCharacterMainModel RaceCharacterMainMaster { get; set; }
		[JsonProperty("param1")]
		public int Param1 { get; set; }
		[JsonProperty("param2")]
		public int Param2 { get; set; }
		[JsonProperty("param3")]
		public int Param3 { get; set; }
		[JsonProperty("param4")]
		public int Param4 { get; set; }
		[JsonProperty("lastRecoveryDate")]
		public string LastRecoveryDate { get; set; }
	}

	public class RaceCommentaryTextModel
	{
		[JsonProperty("situationId")]
		public int SituationId { get; set; }
		[JsonProperty("trapId")]
		public int TrapId { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
	}

	public class RaceEffectTargetModel
	{
		[JsonProperty("targetType")]
		public int TargetType { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
	}

	public class RaceEffectTimingModel
	{
		[JsonProperty("effectTiming")]
		public int EffectTiming { get; set; }
		[JsonProperty("category")]
		public int Category { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
	}

	public class RaceEffectTypeModel
	{
		[JsonProperty("effectType")]
		public int EffectType { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
	}

	public class RaceEffectValueTypeModel
	{
		[JsonProperty("text")]
		public string Text { get; set; }
		[JsonProperty("effectValueType")]
		public int EffectValueType { get; set; }
	}

	public class RaceFortifyModel
	{
		[JsonProperty("fortifyType")]
		public int FortifyType { get; set; }
		[JsonProperty("param1")]
		public int Param1 { get; set; }
		[JsonProperty("param2")]
		public int Param2 { get; set; }
		[JsonProperty("param3")]
		public int Param3 { get; set; }
		[JsonProperty("param4")]
		public int Param4 { get; set; }
	}

	public class RaceMainModel
	{
		[JsonProperty("maxPlayCount")]
		public int MaxPlayCount { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("toDate")]
		public string ToDate { get; set; }
		[JsonProperty("carryOverRate")]
		public int CarryOverRate { get; set; }
		[JsonProperty("season")]
		public int Season { get; set; }
		[JsonProperty("fromDate")]
		public string FromDate { get; set; }
		[JsonProperty("recoveryCount")]
		public int RecoveryCount { get; set; }
		[JsonProperty("recoveryTime")]
		public string RecoveryTime { get; set; }
		[JsonProperty("bgFileName")]
		public string BgFileName { get; set; }
	}

	public class RaceObstacleModel
	{
		[JsonProperty("obstacleId")]
		public int ObstacleId { get; set; }
		[JsonProperty("examValue")]
		public int ExamValue { get; set; }
		[JsonProperty("obstacle1")]
		public int Obstacle1 { get; set; }
		[JsonProperty("obstacle2")]
		public int Obstacle2 { get; set; }
		[JsonProperty("obstacle3")]
		public int Obstacle3 { get; set; }
		[JsonProperty("obstacle4")]
		public int Obstacle4 { get; set; }
	}

	public class RaceRewardModel
	{
		[JsonProperty("itemId")]
		public int ItemId { get; set; }
		[JsonProperty("count")]
		public int Count { get; set; }
		[JsonProperty("order")]
		public int Order { get; set; }
		[JsonProperty("rewardId")]
		public int RewardId { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
	}

	public class RaceSessionModel
	{
		[JsonProperty("season")]
		public int Season { get; set; }
		[JsonProperty("rank")]
		public int Rank { get; set; }
		[JsonProperty("stamina")]
		public int Stamina { get; set; }
		[JsonProperty("lastRaceStartDate")]
		public string LastRaceStartDate { get; set; }
		[JsonProperty("lastRaceEndDate")]
		public string LastRaceEndDate { get; set; }
		[JsonProperty("lastRecoveryDate")]
		public string LastRecoveryDate { get; set; }
		[JsonProperty("raceMainMaster")]
		public RaceMainModel RaceMainMaster { get; set; }
		[JsonProperty("isAvailableRaceSeason")]
		public bool IsAvailableRaceSeason { get; set; }
		[JsonProperty("playableRaceStageMasterArray")]
		public List<dynamic> PlayableRaceStageMasterArray { get; set; }
		[JsonProperty("seasonRemainText")]
		public string SeasonRemainText { get; set; }
	}

	public class RaceStageModel
	{
		[JsonProperty("firstRewardId")]
		public int FirstRewardId { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("memberCount")]
		public int MemberCount { get; set; }
		[JsonProperty("rank")]
		public int Rank { get; set; }
		[JsonProperty("stageGroupId")]
		public int StageGroupId { get; set; }
		[JsonProperty("winRewardId")]
		public int WinRewardId { get; set; }
		[JsonProperty("obstacleId")]
		public int ObstacleId { get; set; }
		[JsonProperty("abilityGroupId")]
		public int AbilityGroupId { get; set; }
		[JsonProperty("loseRewardId")]
		public int LoseRewardId { get; set; }
	}

	public class RaceStatusModel
	{
		[JsonProperty("statusId")]
		public int StatusId { get; set; }
		[JsonProperty("param1")]
		public int Param1 { get; set; }
		[JsonProperty("param2")]
		public int Param2 { get; set; }
		[JsonProperty("param3")]
		public int Param3 { get; set; }
		[JsonProperty("param4")]
		public int Param4 { get; set; }
		[JsonProperty("stamina")]
		public int Stamina { get; set; }
	}

	public class RaceTextModel
	{
		[JsonProperty("textGroupId")]
		public int TextGroupId { get; set; }
		[JsonProperty("textType")]
		public int TextType { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
	}

	public class RaceTopTextModel
	{
		[JsonProperty("characterId")]
		public int CharacterId { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
	}

	public class RaidBattleModel
	{
		[JsonProperty("eventId")]
		public int EventId { get; set; }
		[JsonProperty("stageId")]
		public int StageId { get; set; }
		[JsonProperty("raidBattleType")]
		public List<RaidBattleTypeModel> RaidBattleType { get; set; }
		[JsonProperty("battlePoint")]
		public int BattlePoint { get; set; }
		[JsonProperty("appearCostItemType")]
		public int AppearCostItemType { get; set; }
		[JsonProperty("appearCostItemId")]
		public int AppearCostItemId { get; set; }
		[JsonProperty("appearCostItemCount")]
		public int AppearCostItemCount { get; set; }
		[JsonProperty("rewardId")]
		public int RewardId { get; set; }
	}

	public class RaidBattleTypeModel
	{
		[JsonProperty("raidBattleType")]
		public List<RaidBattleTypeModel> RaidBattleType { get; set; }
		[JsonProperty("maxUserCount")]
		public int MaxUserCount { get; set; }
		[JsonProperty("rescueInterval")]
		public int RescueInterval { get; set; }
		[JsonProperty("appearancePeriod")]
		public int AppearancePeriod { get; set; }
		[JsonProperty("maxTurn")]
		public int MaxTurn { get; set; }
	}

	public class RaidModel
	{
		[JsonProperty("entryRaidBattleSessions")]
		public dynamic EntryRaidBattleSessions { get; set; }
		[JsonProperty("publicRaidBattleSessions")]
		public dynamic PublicRaidBattleSessions { get; set; }
		[JsonProperty("nextRescueEnableDateList")]
		public List<dynamic> NextRescueEnableDateList { get; set; }
	}

	public class RaidRewardGroupModel
	{
		[JsonProperty("rewardGroupId")]
		public int RewardGroupId { get; set; }
		[JsonProperty("order")]
		public int Order { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
		[JsonProperty("itemId")]
		public int ItemId { get; set; }
		[JsonProperty("count")]
		public int Count { get; set; }
		[JsonProperty("rate")]
		public int Rate { get; set; }
	}

	public class RaidRewardModel
	{
		[JsonProperty("rewardId")]
		public int RewardId { get; set; }
		[JsonProperty("normalRewardGroupId")]
		public int NormalRewardGroupId { get; set; }
		[JsonProperty("discovererRewardGroupId")]
		public int DiscovererRewardGroupId { get; set; }
		[JsonProperty("mvpRewardGroupId")]
		public int MvpRewardGroupId { get; set; }
		[JsonProperty("semiMvpRewardGroupId")]
		public int SemiMvpRewardGroupId { get; set; }
	}

	public class RoomCharacterFrameModel
	{
		[JsonProperty("characterFrameCount")]
		public int CharacterFrameCount { get; set; }
		[JsonProperty("costCount")]
		public int CostCount { get; set; }
		[JsonProperty("costId")]
		public int CostId { get; set; }
		[JsonProperty("costType")]
		public int CostType { get; set; }
	}

	public class RoomFurnitureModel
	{
		[JsonProperty("userFurnitureModel")]
		public UserFurnitureModel UserFurnitureModel { get; set; }
		[JsonProperty("furnitureMainMaster")]
		public FurnitureMainModel FurnitureMainMaster { get; set; }
		[JsonProperty("furnitureCollectMaster")]
		public FurnitureCollectModel FurnitureCollectMaster { get; set; }
		[JsonProperty("furnitureId")]
		public int FurnitureId { get; set; }
		[JsonProperty("furnitureName")]
		public string FurnitureName { get; set; }
		[JsonProperty("furnitureCategory")]
		public int FurnitureCategory { get; set; }
		[JsonProperty("collectItemType")]
		public int CollectItemType { get; set; }
		[JsonProperty("collectItemId")]
		public int CollectItemId { get; set; }
		[JsonProperty("collectCountPerStack")]
		public int CollectCountPerStack { get; set; }
		[JsonProperty("collectTime")]
		public int CollectTime { get; set; }
		[JsonProperty("maxStackCount")]
		public int MaxStackCount { get; set; }
		[JsonProperty("maxCollectCount")]
		public int MaxCollectCount { get; set; }
		[JsonProperty("currentStackCount")]
		public int CurrentStackCount { get; set; }
		[JsonProperty("currentCollectCount")]
		public int CurrentCollectCount { get; set; }
		[JsonProperty("remainSecForMaxCollect")]
		public dynamic RemainSecForMaxCollect { get; set; }
		[JsonProperty("remainHmsForMaxCollect")]
		public dynamic RemainHmsForMaxCollect { get; set; }
		[JsonProperty("mapCategory")]
		public int MapCategory { get; set; }
		[JsonProperty("characterGroupId")]
		public int CharacterGroupId { get; set; }
		[JsonProperty("furnitureCd")]
		public string FurnitureCd { get; set; }
		[JsonProperty("nextCollectDate")]
		public string NextCollectDate { get; set; }
		[JsonProperty("lastCollectDate")]
		public dynamic LastCollectDate { get; set; }
		[JsonProperty("correctionCollectSecond")]
		public dynamic CorrectionCollectSecond { get; set; }
	}

	public class RoomMainModel
	{
		[JsonProperty("maxCharacterCount")]
		public int MaxCharacterCount { get; set; }
		[JsonProperty("maxFloor")]
		public dynamic MaxFloor { get; set; }
		[JsonProperty("sizeX")]
		public int SizeX { get; set; }
		[JsonProperty("sizeY")]
		public int SizeY { get; set; }
		[JsonProperty("maxWall")]
		public dynamic MaxWall { get; set; }
		[JsonProperty("maxFurniture")]
		public dynamic MaxFurniture { get; set; }
		[JsonProperty("maxRug")]
		public dynamic MaxRug { get; set; }
		[JsonProperty("maxGoods")]
		public dynamic MaxGoods { get; set; }
	}

	public class RoomModel
	{
		[JsonProperty("furnitureList")]
		public List<dynamic> FurnitureList { get; set; }
		[JsonProperty("roomCharacterList")]
		public List<dynamic> RoomCharacterList { get; set; }
		[JsonProperty("roomFurnitureList")]
		public List<dynamic> RoomFurnitureList { get; set; }
		[JsonProperty("userCd")]
		public string UserCd { get; set; }
	}

	public class ShopDetailConditionModel
	{
		[JsonProperty("listId")]
		public int ListId { get; set; }
		[JsonProperty("conditionType")]
		public int ConditionType { get; set; }
		[JsonProperty("conditionId")]
		public string ConditionId { get; set; }
		[JsonProperty("shopId")]
		public int ShopId { get; set; }
	}

	public class ShopDetailModel
	{
		[JsonProperty("shopId")]
		public int ShopId { get; set; }
		[JsonProperty("listId")]
		public int ListId { get; set; }
		[JsonProperty("order")]
		public int Order { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
		[JsonProperty("costType")]
		public int CostType { get; set; }
		[JsonProperty("costId")]
		public int CostId { get; set; }
		[JsonProperty("costCount")]
		public int CostCount { get; set; }
		[JsonProperty("maxCount")]
		public int MaxCount { get; set; }
		[JsonProperty("resetType")]
		public int ResetType { get; set; }
		[JsonProperty("replenishmentDays")]
		public int ReplenishmentDays { get; set; }
		[JsonProperty("fromDate")]
		public string FromDate { get; set; }
		[JsonProperty("toDate")]
		public string ToDate { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
		[JsonProperty("itemId")]
		public int ItemId { get; set; }
		[JsonProperty("count")]
		public int Count { get; set; }
		[JsonProperty("normalBonus")]
		public int NormalBonus { get; set; }
		[JsonProperty("firstBonus")]
		public int FirstBonus { get; set; }
		[JsonProperty("iconName")]
		public string IconName { get; set; }
		[JsonProperty("skuId")]
		public int SkuId { get; set; }
		[JsonProperty("weekTypes")]
		public string WeekTypes { get; set; }
		[JsonProperty("labelType")]
		public int LabelType { get; set; }
		[JsonProperty("listGroupId")]
		public int ListGroupId { get; set; }
		[JsonProperty("preListId")]
		public int PreListId { get; set; }
		[JsonProperty("missionId")]
		public int MissionId { get; set; }
	}

	public class ShopEventItemConditionModel
	{
		[JsonProperty("eventId")]
		public int EventId { get; set; }
		[JsonProperty("itemId")]
		public int ItemId { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
		[JsonProperty("conditionId")]
		public string ConditionId { get; set; }
		[JsonProperty("count")]
		public int Count { get; set; }
		[JsonProperty("conditionTo")]
		public int ConditionTo { get; set; }
	}

	public class ShopListGroupModel
	{
		[JsonProperty("listGroupId")]
		public int ListGroupId { get; set; }
		[JsonProperty("order")]
		public int Order { get; set; }
		[JsonProperty("listName")]
		public string ListName { get; set; }
	}

	public class ShopMainModel
	{
		[JsonProperty("category")]
		public int Category { get; set; }
		[JsonProperty("order")]
		public int Order { get; set; }
		[JsonProperty("conditionType")]
		public int ConditionType { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("toDate")]
		public string ToDate { get; set; }
		[JsonProperty("shopId")]
		public int ShopId { get; set; }
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
		[JsonProperty("fromDate")]
		public string FromDate { get; set; }
		[JsonProperty("conditionTo")]
		public int ConditionTo { get; set; }
		[JsonProperty("shortName")]
		public string ShortName { get; set; }
		[JsonProperty("conditionFrom")]
		public int ConditionFrom { get; set; }
		[JsonProperty("conditionFrom2")]
		public int ConditionFrom2 { get; set; }
		[JsonProperty("tabColor")]
		public int TabColor { get; set; }
	}

	public class ShopOrderPackModel
	{
		[JsonProperty("shopId")]
		public int ShopId { get; set; }
		[JsonProperty("listId")]
		public int ListId { get; set; }
		[JsonProperty("boxNo")]
		public int BoxNo { get; set; }
		[JsonProperty("index")]
		public int Index { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
		[JsonProperty("itemId")]
		public int ItemId { get; set; }
		[JsonProperty("count")]
		public int Count { get; set; }
	}

	public class SolidEquipmentModel
	{
		[JsonProperty("equipmentCd")]
		public string EquipmentCd { get; set; }
		[JsonProperty("equipmentId")]
		public int EquipmentId { get; set; }
		[JsonProperty("exceedLimit")]
		public int ExceedLimit { get; set; }
		[JsonProperty("count")]
		public int Count { get; set; }
		[JsonProperty("level")]
		public int Level { get; set; }
		[JsonProperty("isProtect")]
		public int IsProtect { get; set; }
		[JsonProperty("exp")]
		public int Exp { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
		[JsonProperty("modelType")]
		public int ModelType { get; set; }
		[JsonProperty("equipmentMainMaster")]
		public EquipmentMainModel EquipmentMainMaster { get; set; }
		[JsonProperty("equipmentMaterialMaster")]
		public EquipmentMaterialModel EquipmentMaterialMaster { get; set; }
		[JsonProperty("equipmentEffectInfoMap")]
		public Dictionary<string, dynamic> EquipmentEffectInfoMap { get; set; }
		[JsonProperty("equipmentLevelMaster")]
		public int EquipmentLevelMaster { get; set; }
		[JsonProperty("isLevelMax")]
		public bool IsLevelMax { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
		[JsonProperty("equipmentGroupId")]
		public int EquipmentGroupId { get; set; }
		[JsonProperty("attribute")]
		public int Attribute { get; set; }
		[JsonProperty("exceedLimitItemType")]
		public int ExceedLimitItemType { get; set; }
		[JsonProperty("salePrice")]
		public int SalePrice { get; set; }
		[JsonProperty("equipmentType")]
		public int EquipmentType { get; set; }
		[JsonProperty("exceedLimitType")]
		public int ExceedLimitType { get; set; }
		[JsonProperty("materialType")]
		public int MaterialType { get; set; }
		[JsonProperty("fortifyPrice")]
		public int FortifyPrice { get; set; }
		[JsonProperty("addExp")]
		public int AddExp { get; set; }
		[JsonProperty("rarity")]
		public int Rarity { get; set; }
		[JsonProperty("isMaxRarity")]
		public int IsMaxRarity { get; set; }
		[JsonProperty("maxLevel")]
		public int MaxLevel { get; set; }
		[JsonProperty("fortifyLevel")]
		public int FortifyLevel { get; set; }
		[JsonProperty("fortifyMaxLevel")]
		public int FortifyMaxLevel { get; set; }
		[JsonProperty("isCharacterEquipment")]
		public bool IsCharacterEquipment { get; set; }
		[JsonProperty("maxHp")]
		public int MaxHp { get; set; }
		[JsonProperty("maxAtk")]
		public int MaxAtk { get; set; }
		[JsonProperty("maxDef")]
		public int MaxDef { get; set; }
		[JsonProperty("minHp")]
		public int MinHp { get; set; }
		[JsonProperty("minAtk")]
		public int MinAtk { get; set; }
		[JsonProperty("minDef")]
		public int MinDef { get; set; }
		[JsonProperty("equipmentEffectMaster")]
		public EquipmentEffectModel EquipmentEffectMaster { get; set; }
		[JsonProperty("effectTextForNormal")]
		public string EffectTextForNormal { get; set; }
		[JsonProperty("effectTextForBoost")]
		public string EffectTextForBoost { get; set; }
		[JsonProperty("equipmentExceedLimitItemMaster")]
		public EquipmentExceedLimitItemModel EquipmentExceedLimitItemMaster { get; set; }
	}

	public class SoundMainModel
	{
		[JsonProperty("soundId")]
		public int SoundId { get; set; }
		[JsonProperty("type")]
		public int Type { get; set; }
		[JsonProperty("title")]
		public string Title { get; set; }
		[JsonProperty("fileName")]
		public string FileName { get; set; }
	}

	public class SoundModel
	{
		[JsonProperty("soundId")]
		public int SoundId { get; set; }
		[JsonProperty("soundMainMaster")]
		public SoundMainModel SoundMainMaster { get; set; }
	}

	public class SpecialRoomActionModel
	{
		[JsonProperty("specialRoomId")]
		public int SpecialRoomId { get; set; }
		[JsonProperty("actionId")]
		public long ActionId { get; set; }
		[JsonProperty("playType")]
		public int PlayType { get; set; }
		[JsonProperty("tapPoint")]
		public string TapPoint { get; set; }
		[JsonProperty("isAdv")]
		public int IsAdv { get; set; }
		[JsonProperty("textId")]
		public int TextId { get; set; }
	}

	public class SpecialRoomBaseSpineModel
	{
		[JsonProperty("specialRoomBaseSpineMasterArray")]
		public List<SpecialRoomBaseSpineModel> SpecialRoomBaseSpineMasterArray { get; set; }
		[JsonProperty("specialRoomId")]
		public int SpecialRoomId { get; set; }
		[JsonProperty("spineDirectoryPath")]
		public string SpineDirectoryPath { get; set; }
		[JsonProperty("spineFileName")]
		public string SpineFileName { get; set; }
		[JsonProperty("bgFileName")]
		public string BgFileName { get; set; }
		[JsonProperty("frontFileName")]
		public string FrontFileName { get; set; }
		[JsonProperty("spVoiceFileName")]
		public string SpVoiceFileName { get; set; }
		[JsonProperty("textBoxPositionX")]
		public int TextBoxPositionX { get; set; }
		[JsonProperty("textBoxPositionY")]
		public int TextBoxPositionY { get; set; }
	}

	public class SpecialRoomConditionalModel
	{
		[JsonProperty("specialRoomId")]
		public int SpecialRoomId { get; set; }
		[JsonProperty("actionId")]
		public long ActionId { get; set; }
		[JsonProperty("month")]
		public int Month { get; set; }
		[JsonProperty("day")]
		public int Day { get; set; }
		[JsonProperty("dayType")]
		public string DayType { get; set; }
		[JsonProperty("startTime")]
		public string StartTime { get; set; }
		[JsonProperty("endTime")]
		public string EndTime { get; set; }
	}

	public class SpecialRoomMainModel
	{
		[JsonProperty("characterGroupId")]
		public int CharacterGroupId { get; set; }
		[JsonProperty("characterShortName")]
		public string CharacterShortName { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("releaseDate")]
		public string ReleaseDate { get; set; }
		[JsonProperty("shortName")]
		public string ShortName { get; set; }
		[JsonProperty("specialRoomId")]
		public int SpecialRoomId { get; set; }
		[JsonProperty("visibleDate")]
		public string VisibleDate { get; set; }
	}

	public class SpecialRoomTapPointModel
	{
		[JsonProperty("specialRoomId")]
		public int SpecialRoomId { get; set; }
		[JsonProperty("tapPoint")]
		public string TapPoint { get; set; }
		[JsonProperty("boneName")]
		public string BoneName { get; set; }
		[JsonProperty("slotName")]
		public string SlotName { get; set; }
	}

	public class SpecialRoomTextModel
	{
		[JsonProperty("specialRoomId")]
		public int SpecialRoomId { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
		[JsonProperty("textId")]
		public int TextId { get; set; }
		[JsonProperty("skinName")]
		public string SkinName { get; set; }
		[JsonProperty("voiceFile")]
		public string VoiceFile { get; set; }
		[JsonProperty("animation")]
		public string Animation { get; set; }
	}

	public class StoryCabinModel
	{
		[JsonProperty("resourceId")]
		public int ResourceId { get; set; }
		[JsonProperty("storyId")]
		public int StoryId { get; set; }
		[JsonProperty("storyGroupId")]
		public int StoryGroupId { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
	}

	public class StoryCategoryModel
	{
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("storyCategory")]
		public int StoryCategory { get; set; }
	}

	public class StoryEventModel
	{
		[JsonProperty("storyGroupId")]
		public int StoryGroupId { get; set; }
		[JsonProperty("storyId")]
		public int StoryId { get; set; }
		[JsonProperty("releaseStoryId")]
		public int ReleaseStoryId { get; set; }
		[JsonProperty("resourceId")]
		public int ResourceId { get; set; }
		[JsonProperty("eventId")]
		public int EventId { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("stageId")]
		public int StageId { get; set; }
		[JsonProperty("playType")]
		public int PlayType { get; set; }
		[JsonProperty("stableEventId")]
		public int StableEventId { get; set; }
	}

	public class StoryGachaModel
	{
		[JsonProperty("resourceId")]
		public int ResourceId { get; set; }
		[JsonProperty("storyId")]
		public int StoryId { get; set; }
		[JsonProperty("characterId")]
		public int CharacterId { get; set; }
		[JsonProperty("storyGroupId")]
		public int StoryGroupId { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
	}

	public class StoryGroupModel
	{
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("storyCategory")]
		public int StoryCategory { get; set; }
		[JsonProperty("storyGroupId")]
		public int StoryGroupId { get; set; }
	}

	public class StoryMemorialEventOtherModel
	{
		[JsonProperty("storyGroupId")]
		public int StoryGroupId { get; set; }
		[JsonProperty("storyId")]
		public int StoryId { get; set; }
		[JsonProperty("resourceId")]
		public int ResourceId { get; set; }
		[JsonProperty("eventId")]
		public int EventId { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("visibleDate")]
		public string VisibleDate { get; set; }
	}

	public class StoryMemorialModel
	{
		[JsonProperty("storyGroupId")]
		public int StoryGroupId { get; set; }
		[JsonProperty("memorialId")]
		public int MemorialId { get; set; }
		[JsonProperty("storyId")]
		public int StoryId { get; set; }
		[JsonProperty("resourceId")]
		public int ResourceId { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
	}

	public class StoryModel
	{
		[JsonProperty("contentMaster")]
		public dynamic ContentMaster { get; set; }
		[JsonProperty("isRead")]
		public int IsRead { get; set; }
		[JsonProperty("lightResourceId")]
		public int LightResourceId { get; set; }
		[JsonProperty("nextStoryId")]
		public int NextStoryId { get; set; }
		[JsonProperty("nextStoryMaster")]
		public dynamic NextStoryMaster { get; set; }
		[JsonProperty("playType")]
		public int PlayType { get; set; }
		[JsonProperty("resourceId")]
		public int ResourceId { get; set; }
		[JsonProperty("storyCategory")]
		public int StoryCategory { get; set; }
		[JsonProperty("storyCategoryMaster")]
		public StoryCategoryModel StoryCategoryMaster { get; set; }
		[JsonProperty("storyGroupId")]
		public int StoryGroupId { get; set; }
		[JsonProperty("storyGroupMaster")]
		public StoryGroupModel StoryGroupMaster { get; set; }
		[JsonProperty("storyId")]
		public int StoryId { get; set; }
		[JsonProperty("storyMaster")]
		public StoryModel StoryMaster { get; set; }
		[JsonProperty("storyName")]
		public string StoryName { get; set; }
		[JsonProperty("userCd")]
		public string UserCd { get; set; }
	}

	public class StoryOtherModel
	{
		[JsonProperty("storyGroupId")]
		public int StoryGroupId { get; set; }
		[JsonProperty("storyId")]
		public int StoryId { get; set; }
		[JsonProperty("resourceId")]
		public int ResourceId { get; set; }
		[JsonProperty("eventId")]
		public int EventId { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("stageId")]
		public int StageId { get; set; }
		[JsonProperty("playType")]
		public int PlayType { get; set; }
	}

	public class StoryPictureBookModel
	{
		[JsonProperty("rewardCount")]
		public int RewardCount { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("storyGroupId")]
		public int StoryGroupId { get; set; }
		[JsonProperty("lightResourceId")]
		public int LightResourceId { get; set; }
		[JsonProperty("resourceId")]
		public int ResourceId { get; set; }
		[JsonProperty("rewardType")]
		public int RewardType { get; set; }
		[JsonProperty("rewardId")]
		public int RewardId { get; set; }
		[JsonProperty("storyId")]
		public int StoryId { get; set; }
		[JsonProperty("visibleDate")]
		public string VisibleDate { get; set; }
	}

	public class StoryQuestModel
	{
		[JsonProperty("storyGroupId")]
		public int StoryGroupId { get; set; }
		[JsonProperty("storyId")]
		public int StoryId { get; set; }
		[JsonProperty("resourceId")]
		public int ResourceId { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("stageId")]
		public int StageId { get; set; }
		[JsonProperty("playType")]
		public int PlayType { get; set; }
	}

	public class StoryRoomModel
	{
		[JsonProperty("storyGroupId")]
		public int StoryGroupId { get; set; }
		[JsonProperty("storyId")]
		public int StoryId { get; set; }
		[JsonProperty("resourceId")]
		public int ResourceId { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("condition1")]
		public int Condition1 { get; set; }
		[JsonProperty("condition2")]
		public int Condition2 { get; set; }
		[JsonProperty("rewardType")]
		public int RewardType { get; set; }
		[JsonProperty("rewardId")]
		public int RewardId { get; set; }
		[JsonProperty("rewardCount")]
		public int RewardCount { get; set; }
		[JsonProperty("visibleDate")]
		public string VisibleDate { get; set; }
	}

	public class StoryTutorialModel
	{
		[JsonProperty("storyGroupId")]
		public int StoryGroupId { get; set; }
		[JsonProperty("storyId")]
		public int StoryId { get; set; }
		[JsonProperty("resourceId")]
		public int ResourceId { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
	}

	public class StoryVoiceModel
	{
		[JsonProperty("storyGroupId")]
		public int StoryGroupId { get; set; }
		[JsonProperty("storyId")]
		public int StoryId { get; set; }
		[JsonProperty("resourceId")]
		public int ResourceId { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
	}

	public class TowerMainModel
	{
		[JsonProperty("dateTo")]
		public string DateTo { get; set; }
		[JsonProperty("areaId")]
		public int AreaId { get; set; }
		[JsonProperty("dateFrom")]
		public string DateFrom { get; set; }
		[JsonProperty("deckIdFrom")]
		public int DeckIdFrom { get; set; }
		[JsonProperty("deckIdTo")]
		public int DeckIdTo { get; set; }
	}

	public class TowerRewardGroupModel
	{
		[JsonProperty("rewardGroupId")]
		public int RewardGroupId { get; set; }
		[JsonProperty("order")]
		public int Order { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
		[JsonProperty("itemId")]
		public int ItemId { get; set; }
		[JsonProperty("count")]
		public int Count { get; set; }
	}

	public class TowerRewardModel
	{
		[JsonProperty("stageId")]
		public int StageId { get; set; }
		[JsonProperty("completeRewardGroupId")]
		public int CompleteRewardGroupId { get; set; }
		[JsonProperty("stageRewardGroupId")]
		public int StageRewardGroupId { get; set; }
		[JsonProperty("stageRewardType")]
		public int StageRewardType { get; set; }
	}

	public class TowerSessionModel
	{
		[JsonProperty("areaId")]
		public int AreaId { get; set; }
		[JsonProperty("battleSessionId")]
		public string BattleSessionId { get; set; }
		[JsonProperty("continueData")]
		public dynamic ContinueData { get; set; }
		[JsonProperty("deckId")]
		public int DeckId { get; set; }
		[JsonProperty("deckType")]
		public int DeckType { get; set; }
		[JsonProperty("recentDate")]
		public string RecentDate { get; set; }
		[JsonProperty("saveData")]
		public dynamic SaveData { get; set; }
		[JsonProperty("sessionId")]
		public string SessionId { get; set; }
		[JsonProperty("stageId")]
		public int StageId { get; set; }
		[JsonProperty("towerSelectCount")]
		public int TowerSelectCount { get; set; }
		[JsonProperty("towerSelectDate")]
		public string TowerSelectDate { get; set; }
		[JsonProperty("towerSelectMaxCount")]
		public int TowerSelectMaxCount { get; set; }
		[JsonProperty("towerStageMasterMap")]
		public Dictionary<string, dynamic> TowerStageMasterMap { get; set; }
	}

	public class TutorialEventModel
	{
		[JsonProperty("tutorialEventId")]
		public int TutorialEventId { get; set; }
		[JsonProperty("completeStep")]
		public int CompleteStep { get; set; }
		[JsonProperty("completeSubStep")]
		public int CompleteSubStep { get; set; }
		[JsonProperty("description")]
		public string Description { get; set; }
		[JsonProperty("actionType")]
		public int ActionType { get; set; }
		[JsonProperty("actionParam1")]
		public string ActionParam1 { get; set; }
		[JsonProperty("actionParam2")]
		public string ActionParam2 { get; set; }
	}

	public class TutorialMainStepModel
	{
		[JsonProperty("step")]
		public int Step { get; set; }
		[JsonProperty("sceneName")]
		public string SceneName { get; set; }
		[JsonProperty("viewName")]
		public string ViewName { get; set; }
		[JsonProperty("viewParam")]
		public string ViewParam { get; set; }
	}

	public class TutorialSkipModel
	{
		[JsonProperty("targetStep")]
		public int TargetStep { get; set; }
		[JsonProperty("nextStep")]
		public int NextStep { get; set; }
		[JsonProperty("headerText")]
		public string HeaderText { get; set; }
		[JsonProperty("mainText")]
		public string MainText { get; set; }
		[JsonProperty("noteName")]
		public string NoteName { get; set; }
	}

	public class TutorialSubStepModel
	{
		[JsonProperty("step")]
		public int Step { get; set; }
		[JsonProperty("subStep")]
		public int SubStep { get; set; }
		[JsonProperty("storyId")]
		public int StoryId { get; set; }
		[JsonProperty("triggerName")]
		public string TriggerName { get; set; }
		[JsonProperty("triggerType")]
		public int TriggerType { get; set; }
		[JsonProperty("triggerParam")]
		public int TriggerParam { get; set; }
	}

	public class UniqueMissionModel
	{
		[JsonProperty("missionGroupId")]
		public int MissionGroupId { get; set; }
	}

	public class UserBasicInfoModel
	{
		[JsonProperty("isBgmMute")]
		public int IsBgmMute { get; set; }
		[JsonProperty("isSeMute")]
		public int IsSeMute { get; set; }
		[JsonProperty("isVoiceMute")]
		public int IsVoiceMute { get; set; }
		[JsonProperty("isSkillAuto")]
		public int IsSkillAuto { get; set; }
		[JsonProperty("staminaValue")]
		public int StaminaValue { get; set; }
		[JsonProperty("characterMaxCount")]
		public int CharacterMaxCount { get; set; }
		[JsonProperty("itemMaxCount")]
		public int ItemMaxCount { get; set; }
		[JsonProperty("defaultDeckId")]
		public int DefaultDeckId { get; set; }
		[JsonProperty("systemDate")]
		public string SystemDate { get; set; }
		[JsonProperty("voiceVolume")]
		public int VoiceVolume { get; set; }
		[JsonProperty("equipmentMaxCount")]
		public int EquipmentMaxCount { get; set; }
		[JsonProperty("isEnabled")]
		public int IsEnabled { get; set; }
		[JsonProperty("userCd")]
		public string UserCd { get; set; }
		[JsonProperty("battleSpeed")]
		public int BattleSpeed { get; set; }
		[JsonProperty("seVolume")]
		public int SeVolume { get; set; }
		[JsonProperty("staminaBonus")]
		public int StaminaBonus { get; set; }
		[JsonProperty("bgmVolume")]
		public int BgmVolume { get; set; }
		[JsonProperty("displayId")]
		public string DisplayId { get; set; }
		[JsonProperty("userName")]
		public string UserName { get; set; }
		[JsonProperty("userNameTextId")]
		public string UserNameTextId { get; set; }
		[JsonProperty("userNameStatus")]
		public int UserNameStatus { get; set; }
		[JsonProperty("partner")]
		public dynamic Partner { get; set; }
		[JsonProperty("level")]
		public int Level { get; set; }
		[JsonProperty("staminaRecoveryDate")]
		public string StaminaRecoveryDate { get; set; }
		[JsonProperty("exp")]
		public int Exp { get; set; }
		[JsonProperty("registerDate")]
		public string RegisterDate { get; set; }
		[JsonProperty("staminaRemainSec")]
		public int StaminaRemainSec { get; set; }
		[JsonProperty("userText")]
		public string UserText { get; set; }
		[JsonProperty("playerType")]
		public int PlayerType { get; set; }
		[JsonProperty("roomCharacterMaxCount")]
		public int RoomCharacterMaxCount { get; set; }
		[JsonProperty("battlePointValue")]
		public int BattlePointValue { get; set; }
		[JsonProperty("battlePointBonus")]
		public int BattlePointBonus { get; set; }
		[JsonProperty("battlePointRemainSec")]
		public int BattlePointRemainSec { get; set; }
		[JsonProperty("battlePointRecoveryDate")]
		public string BattlePointRecoveryDate { get; set; }
		[JsonProperty("tutorialStep")]
		public int TutorialStep { get; set; }
		[JsonProperty("tutorialEndDate")]
		public string TutorialEndDate { get; set; }
	}

	public class UserBoostModel
	{
		[JsonProperty("boostType")]
		public int BoostType { get; set; }
		[JsonProperty("itemId")]
		public int ItemId { get; set; }
		[JsonProperty("parameter")]
		public dynamic Parameter { get; set; }
		[JsonProperty("endDate")]
		public string EndDate { get; set; }
		[JsonProperty("startDate")]
		public string StartDate { get; set; }
	}

	public class UserBuffHelpModel
	{
		[JsonProperty("order")]
		public int Order { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
		[JsonProperty("fileName")]
		public string FileName { get; set; }
	}

	public class UserCabinMissionModel
	{
		[JsonProperty("missionGroupId")]
		public int MissionGroupId { get; set; }
		[JsonProperty("missionId")]
		public int MissionId { get; set; }
		[JsonProperty("receiveCount")]
		public int ReceiveCount { get; set; }
	}

	public class UserCharacterAbilityEffectModel
	{
		[JsonProperty("abilityId")]
		public int AbilityId { get; set; }
		[JsonProperty("addAbilityIdArray")]
		public List<dynamic> AddAbilityIdArray { get; set; }
		[JsonProperty("level")]
		public int Level { get; set; }
		[JsonProperty("index")]
		public int Index { get; set; }
		[JsonProperty("awakeEffectMasterArray")]
		public List<dynamic> AwakeEffectMasterArray { get; set; }
		[JsonProperty("abilityEffectMaster")]
		public dynamic AbilityEffectMaster { get; set; }
		[JsonProperty("successRate")]
		public int SuccessRate { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
		[JsonProperty("shortText")]
		public string ShortText { get; set; }
		[JsonProperty("effectLimit")]
		public int EffectLimit { get; set; }
		[JsonProperty("actionType")]
		public int ActionType { get; set; }
		[JsonProperty("effectType")]
		public int EffectType { get; set; }
		[JsonProperty("endType")]
		public int EndType { get; set; }
		[JsonProperty("abilityAwakeEffectMasterArray")]
		public List<dynamic> AbilityAwakeEffectMasterArray { get; set; }
		[JsonProperty("effectValue")]
		public int EffectValue { get; set; }
		[JsonProperty("occurrenceRate")]
		public int OccurrenceRate { get; set; }
		[JsonProperty("targetType")]
		public int TargetType { get; set; }
		[JsonProperty("targetValue")]
		public string TargetValue { get; set; }
		[JsonProperty("endValue")]
		public string EndValue { get; set; }
		[JsonProperty("effectConditionType")]
		public int EffectConditionType { get; set; }
		[JsonProperty("effectConditionValue")]
		public string EffectConditionValue { get; set; }
	}

	public class UserCharacterAbilityGroupModel
	{
		[JsonProperty("abilityGroupId")]
		public int AbilityGroupId { get; set; }
		[JsonProperty("abilityLevel1")]
		public int AbilityLevel1 { get; set; }
		[JsonProperty("abilityLevel2")]
		public int AbilityLevel2 { get; set; }
		[JsonProperty("abilityLevel3")]
		public int AbilityLevel3 { get; set; }
		[JsonProperty("rarity")]
		public int Rarity { get; set; }
		[JsonProperty("exceedLimit")]
		public int ExceedLimit { get; set; }
		[JsonProperty("exceedLimitMasterArray")]
		public List<dynamic> ExceedLimitMasterArray { get; set; }
		[JsonProperty("awakeEffectMasterArray")]
		public List<dynamic> AwakeEffectMasterArray { get; set; }
		[JsonProperty("abilityGroupMasterArray")]
		public List<dynamic> AbilityGroupMasterArray { get; set; }
		[JsonProperty("abilityAddAwakeEffectMasterArray")]
		public List<dynamic> AbilityAddAwakeEffectMasterArray { get; set; }
		[JsonProperty("userAbilityMainArray")]
		public List<dynamic> UserAbilityMainArray { get; set; }
	}

	public class UserCharacterAbilityMainModel
	{
		[JsonProperty("abilityId")]
		public int AbilityId { get; set; }
		[JsonProperty("level")]
		public int Level { get; set; }
		[JsonProperty("abilityIndex")]
		public int AbilityIndex { get; set; }
		[JsonProperty("rarity")]
		public int Rarity { get; set; }
		[JsonProperty("exceedLimit")]
		public int ExceedLimit { get; set; }
		[JsonProperty("exceedLimitMasterArray")]
		public List<dynamic> ExceedLimitMasterArray { get; set; }
		[JsonProperty("awakeEffectMasterArray")]
		public List<dynamic> AwakeEffectMasterArray { get; set; }
		[JsonProperty("abilityMainMaster")]
		public dynamic AbilityMainMaster { get; set; }
		[JsonProperty("abilityAwakeEffectMasterMap")]
		public Dictionary<string, dynamic> AbilityAwakeEffectMasterMap { get; set; }
		[JsonProperty("abilityExtendedAwakeIdArray")]
		public List<dynamic> AbilityExtendedAwakeIdArray { get; set; }
		[JsonProperty("addAbilityId")]
		public int AddAbilityId { get; set; }
		[JsonProperty("addAbilityIdArray")]
		public List<dynamic> AddAbilityIdArray { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("triggerType")]
		public int TriggerType { get; set; }
		[JsonProperty("triggerValue")]
		public string TriggerValue { get; set; }
		[JsonProperty("conditionMap")]
		public Dictionary<string, dynamic> ConditionMap { get; set; }
		[JsonProperty("invokeLimitCount")]
		public int InvokeLimitCount { get; set; }
		[JsonProperty("abilityFortifyType")]
		public int AbilityFortifyType { get; set; }
		[JsonProperty("needExceedLimitMaster")]
		public dynamic NeedExceedLimitMaster { get; set; }
		[JsonProperty("needExceedLimit")]
		public int NeedExceedLimit { get; set; }
		[JsonProperty("addUserAbilityMainArray")]
		public List<dynamic> AddUserAbilityMainArray { get; set; }
		[JsonProperty("abilityExtendedAwakeEffectMasterArray")]
		public List<dynamic> AbilityExtendedAwakeEffectMasterArray { get; set; }
		[JsonProperty("effectAddAwakeEffectMasterArray")]
		public List<dynamic> EffectAddAwakeEffectMasterArray { get; set; }
		[JsonProperty("nextUserAbilityMain")]
		public dynamic NextUserAbilityMain { get; set; }
		[JsonProperty("userAbilityEffectMap")]
		public Dictionary<string, dynamic> UserAbilityEffectMap { get; set; }
		[JsonProperty("userAbilityEffectMasterMap")]
		public Dictionary<string, dynamic> UserAbilityEffectMasterMap { get; set; }
		[JsonProperty("abilityExtendedAwakeEffectMainMasterArray")]
		public List<dynamic> AbilityExtendedAwakeEffectMainMasterArray { get; set; }
		[JsonProperty("currentUserAbilityEffectArray")]
		public List<dynamic> CurrentUserAbilityEffectArray { get; set; }
		[JsonProperty("isReleased")]
		public bool IsReleased { get; set; }
		[JsonProperty("isSupportAbility")]
		public bool IsSupportAbility { get; set; }
		[JsonProperty("isAwakeAbility")]
		public bool IsAwakeAbility { get; set; }
		[JsonProperty("isTrastAbility")]
		public bool IsTrastAbility { get; set; }
		[JsonProperty("abilityText")]
		public string AbilityText { get; set; }
		[JsonProperty("singleUserAbilityEffectMap")]
		public Dictionary<string, dynamic> SingleUserAbilityEffectMap { get; set; }
		[JsonProperty("singleUserAbilityEffectArray")]
		public List<dynamic> SingleUserAbilityEffectArray { get; set; }
		[JsonProperty("singleAbilityText")]
		public string SingleAbilityText { get; set; }
		[JsonProperty("singleAbilityShortText")]
		public string SingleAbilityShortText { get; set; }
		[JsonProperty("characterCd")]
		public string CharacterCd { get; set; }
		[JsonProperty("characterId")]
		public int CharacterId { get; set; }
		[JsonProperty("parentId")]
		public int ParentId { get; set; }
		[JsonProperty("linkerId")]
		public int LinkerId { get; set; }
		[JsonProperty("priority")]
		public int Priority { get; set; }
		[JsonProperty("skillLevel")]
		public int SkillLevel { get; set; }
		[JsonProperty("abilityLevel1")]
		public int AbilityLevel1 { get; set; }
		[JsonProperty("abilityLevel2")]
		public int AbilityLevel2 { get; set; }
		[JsonProperty("abilityLevel3")]
		public int AbilityLevel3 { get; set; }
	}

	public class UserCharacterModel
	{
		[JsonProperty("characterCd")]
		public string CharacterCd { get; set; }
		[JsonProperty("characterId")]
		public int CharacterId { get; set; }
		[JsonProperty("exp")]
		public int Exp { get; set; }
		[JsonProperty("level")]
		public int Level { get; set; }
		[JsonProperty("addHp")]
		public int AddHp { get; set; }
		[JsonProperty("addAtk")]
		public int AddAtk { get; set; }
		[JsonProperty("addDef")]
		public int AddDef { get; set; }
		[JsonProperty("skillLevel")]
		public int SkillLevel { get; set; }
		[JsonProperty("abilityLevel1")]
		public int AbilityLevel1 { get; set; }
		[JsonProperty("abilityLevel2")]
		public int AbilityLevel2 { get; set; }
		[JsonProperty("abilityLevel3")]
		public int AbilityLevel3 { get; set; }
		[JsonProperty("exceedLimit")]
		public int ExceedLimit { get; set; }
		[JsonProperty("exceedLimitExp")]
		public int ExceedLimitExp { get; set; }
		[JsonProperty("isProtect")]
		public int IsProtect { get; set; }
		[JsonProperty("registerDate")]
		public string RegisterDate { get; set; }
		[JsonProperty("equipmentWeaponCds")]
		public List<string> EquipmentWeaponCds { get; set; }
		[JsonProperty("equipmentProtectorCds")]
		public List<dynamic> EquipmentProtectorCds { get; set; }
		[JsonProperty("awakeIds")]
		public List<dynamic> AwakeIds { get; set; }
		[JsonProperty("battleCount")]
		public int BattleCount { get; set; }
		[JsonProperty("addRarity")]
		public int AddRarity { get; set; }
	}

	public class UserCharacterSkillEffectModel
	{
		[JsonProperty("skillId")]
		public int SkillId { get; set; }
		[JsonProperty("level")]
		public int Level { get; set; }
		[JsonProperty("index")]
		public int Index { get; set; }
		[JsonProperty("awakeEffectMasterArray")]
		public List<dynamic> AwakeEffectMasterArray { get; set; }
		[JsonProperty("skillEffectMaster")]
		public dynamic SkillEffectMaster { get; set; }
		[JsonProperty("effectConditionType")]
		public int EffectConditionType { get; set; }
		[JsonProperty("successRate")]
		public int SuccessRate { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
		[JsonProperty("shortText")]
		public string ShortText { get; set; }
		[JsonProperty("effectConditionValue")]
		public string EffectConditionValue { get; set; }
		[JsonProperty("actionType")]
		public int ActionType { get; set; }
		[JsonProperty("effectType")]
		public int EffectType { get; set; }
		[JsonProperty("endType")]
		public int EndType { get; set; }
		[JsonProperty("skillAwakeEffectMasterArray")]
		public List<dynamic> SkillAwakeEffectMasterArray { get; set; }
		[JsonProperty("effectValue")]
		public int EffectValue { get; set; }
		[JsonProperty("effectLimit")]
		public int EffectLimit { get; set; }
		[JsonProperty("occurrenceRate")]
		public int OccurrenceRate { get; set; }
		[JsonProperty("targetType")]
		public int TargetType { get; set; }
		[JsonProperty("targetValue")]
		public string TargetValue { get; set; }
		[JsonProperty("endValue")]
		public string EndValue { get; set; }
	}

	public class UserCharacterSkillMainModel
	{
		[JsonProperty("skillId")]
		public int SkillId { get; set; }
		[JsonProperty("level")]
		public int Level { get; set; }
		[JsonProperty("skillIndex")]
		public int SkillIndex { get; set; }
		[JsonProperty("awakeEffectMasterArray")]
		public List<dynamic> AwakeEffectMasterArray { get; set; }
		[JsonProperty("skillMainMaster")]
		public dynamic SkillMainMaster { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("effectShowType")]
		public int EffectShowType { get; set; }
		[JsonProperty("spineDirectoryPath")]
		public string SpineDirectoryPath { get; set; }
		[JsonProperty("spineName")]
		public string SpineName { get; set; }
		[JsonProperty("aniName")]
		public string AniName { get; set; }
		[JsonProperty("hitEffectName")]
		public string HitEffectName { get; set; }
		[JsonProperty("hitEffectAniName")]
		public string HitEffectAniName { get; set; }
		[JsonProperty("bgmVolumeAmount")]
		public double BgmVolumeAmount { get; set; }
		[JsonProperty("skillFortifyType")]
		public int SkillFortifyType { get; set; }
		[JsonProperty("skillEffectMasterArray")]
		public List<dynamic> SkillEffectMasterArray { get; set; }
		[JsonProperty("userSkillEffectArray")]
		public List<dynamic> UserSkillEffectArray { get; set; }
		[JsonProperty("effectAddAwakeEffectMasterArray")]
		public List<dynamic> EffectAddAwakeEffectMasterArray { get; set; }
		[JsonProperty("userAwakeSkillEffectArray")]
		public List<dynamic> UserAwakeSkillEffectArray { get; set; }
	}

	public class UserComebackModel
	{
		[JsonProperty("campaignId")]
		public int CampaignId { get; set; }
		[JsonProperty("igniteDate")]
		public string IgniteDate { get; set; }
	}

	public class UserDeckModel
	{
		[JsonProperty("position")]
		public int Position { get; set; }
		[JsonProperty("deckId")]
		public int DeckId { get; set; }
		[JsonProperty("deckType")]
		public int DeckType { get; set; }
		[JsonProperty("roleType")]
		public int RoleType { get; set; }
		[JsonProperty("characterCd")]
		public string CharacterCd { get; set; }
	}

	public class UserEquipmentModel
	{
		[JsonProperty("isProtect")]
		public int IsProtect { get; set; }
		[JsonProperty("registerDate")]
		public string RegisterDate { get; set; }
		[JsonProperty("equipmentId")]
		public int EquipmentId { get; set; }
		[JsonProperty("equipmentCd")]
		public string EquipmentCd { get; set; }
		[JsonProperty("level")]
		public int Level { get; set; }
		[JsonProperty("exp")]
		public int Exp { get; set; }
		[JsonProperty("exceedLimit")]
		public int ExceedLimit { get; set; }
	}

	public class UserEventFriendshipItemModel
	{
		[JsonProperty("friendshipGroupId")]
		public int FriendshipGroupId { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
		[JsonProperty("itemId")]
		public int ItemId { get; set; }
		[JsonProperty("count")]
		public int Count { get; set; }
	}

	public class UserEventItemModel
	{
		[JsonProperty("eventId")]
		public int EventId { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
		[JsonProperty("itemId")]
		public int ItemId { get; set; }
		[JsonProperty("count")]
		public int Count { get; set; }
	}

	public class UserExchangeHistoryModel
	{
		[JsonProperty("todayQuantity")]
		public int TodayQuantity { get; set; }
		[JsonProperty("exchangeId")]
		public int ExchangeId { get; set; }
		[JsonProperty("totalQuantity")]
		public int TotalQuantity { get; set; }
		[JsonProperty("weeklyQuantity")]
		public int WeeklyQuantity { get; set; }
		[JsonProperty("monthlyQuantity")]
		public int MonthlyQuantity { get; set; }
		[JsonProperty("pvPSeasonQuantity")]
		public int PvPSeasonQuantity { get; set; }
		[JsonProperty("listId")]
		public int ListId { get; set; }
		[JsonProperty("lastExchangeDate")]
		public string LastExchangeDate { get; set; }
	}

	public class UserFurnitureModel
	{
		[JsonProperty("furnitureId")]
		public int FurnitureId { get; set; }
		[JsonProperty("furnitureCd")]
		public string FurnitureCd { get; set; }
		[JsonProperty("furnitureCategory")]
		public int FurnitureCategory { get; set; }
		[JsonProperty("isBuyFurniture")]
		public int IsBuyFurniture { get; set; }
		[JsonProperty("level")]
		public int Level { get; set; }
	}

	public class UserGachaModel
	{
		[JsonProperty("addLayoutParam")]
		public dynamic AddLayoutParam { get; set; }
		[JsonProperty("addLayoutType")]
		public int AddLayoutType { get; set; }
		[JsonProperty("banners")]
		public List<dynamic> Banners { get; set; }
		[JsonProperty("buttons")]
		public List<dynamic> Buttons { get; set; }
		[JsonProperty("conditionFrom")]
		public int ConditionFrom { get; set; }
		[JsonProperty("conditionTo")]
		public int ConditionTo { get; set; }
		[JsonProperty("conditionType")]
		public int ConditionType { get; set; }
		[JsonProperty("fromDate")]
		public string FromDate { get; set; }
		[JsonProperty("gachaGroupId")]
		public int GachaGroupId { get; set; }
		[JsonProperty("gachaId")]
		public int GachaId { get; set; }
		[JsonProperty("gachaName")]
		public string GachaName { get; set; }
		[JsonProperty("gachaText")]
		public string GachaText { get; set; }
		[JsonProperty("gachaType")]
		public int GachaType { get; set; }
		[JsonProperty("order")]
		public int Order { get; set; }
		[JsonProperty("toDate")]
		public string ToDate { get; set; }
		[JsonProperty("weekType")]
		public string WeekType { get; set; }
	}

	public class UserGemModel
	{
		[JsonProperty("freeGem")]
		public int FreeGem { get; set; }
		[JsonProperty("paidGem")]
		public int PaidGem { get; set; }
	}

	public class UserHelpModel
	{
		[JsonProperty("sceneName")]
		public string SceneName { get; set; }
		[JsonProperty("order")]
		public int Order { get; set; }
		[JsonProperty("fileName")]
		public string FileName { get; set; }
		[JsonProperty("descriptionText")]
		public string DescriptionText { get; set; }
	}

	public class UserHowToPlayModel
	{
		[JsonProperty("sceneName")]
		public string SceneName { get; set; }
		[JsonProperty("page")]
		public int Page { get; set; }
	}

	public class UserItemModel
	{
		[JsonProperty("itemId")]
		public int ItemId { get; set; }
		[JsonProperty("count")]
		public int Count { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
	}

	public class UserLinearMissionModel
	{
		[JsonProperty("missionGroupId")]
		public int MissionGroupId { get; set; }
		[JsonProperty("step")]
		public int Step { get; set; }
		[JsonProperty("clearCount")]
		public int ClearCount { get; set; }
		[JsonProperty("rewardPoint")]
		public int RewardPoint { get; set; }
		[JsonProperty("startDate")]
		public string StartDate { get; set; }
		[JsonProperty("resetDate")]
		public string ResetDate { get; set; }
	}

	public class UserLoginPackModel
	{
		[JsonProperty("loginPackId")]
		public int LoginPackId { get; set; }
		[JsonProperty("startDate")]
		public string StartDate { get; set; }
		[JsonProperty("endDate")]
		public string EndDate { get; set; }
		[JsonProperty("receivedList")]
		public List<dynamic> ReceivedList { get; set; }
		[JsonProperty("receiveCount")]
		public int ReceiveCount { get; set; }
		[JsonProperty("lastReceiveDate")]
		public string LastReceiveDate { get; set; }
	}

	public class UserLotteryModel
	{
		[JsonProperty("itemId")]
		public int ItemId { get; set; }
		[JsonProperty("lotteryCd")]
		public string LotteryCd { get; set; }
	}

	public class UserMainModel
	{
		[JsonProperty("maxBattlePoint")]
		public int MaxBattlePoint { get; set; }
		[JsonProperty("maxCharacterAddBorder")]
		public int MaxCharacterAddBorder { get; set; }
		[JsonProperty("maxCharatcterAddBorder")]
		public int MaxCharatcterAddBorder { get; set; }
		[JsonProperty("maxExpeditionDeck")]
		public int MaxExpeditionDeck { get; set; }
		[JsonProperty("maxFriend")]
		public int MaxFriend { get; set; }
		[JsonProperty("maxStamina")]
		public int MaxStamina { get; set; }
		[JsonProperty("maxTowerDeck")]
		public int MaxTowerDeck { get; set; }
		[JsonProperty("nextLevelExp")]
		public int NextLevelExp { get; set; }
		[JsonProperty("totalExp")]
		public int TotalExp { get; set; }
		[JsonProperty("userLevel")]
		public int UserLevel { get; set; }
	}

	public class UserMemorialDeckModel
	{
		[JsonProperty("deckType")]
		public int DeckType { get; set; }
		[JsonProperty("deckId")]
		public int DeckId { get; set; }
		[JsonProperty("position")]
		public int Position { get; set; }
		[JsonProperty("memorialId")]
		public int MemorialId { get; set; }
	}

	public class UserMemorialModel
	{
		[JsonProperty("memorialId")]
		public int MemorialId { get; set; }
		[JsonProperty("level")]
		public int Level { get; set; }
		[JsonProperty("exceedLimit")]
		public int ExceedLimit { get; set; }
		[JsonProperty("registerDate")]
		public string RegisterDate { get; set; }
	}

	public class UserMinigameModel
	{
		[JsonProperty("totalPlayCount")]
		public int TotalPlayCount { get; set; }
		[JsonProperty("lastDate")]
		public string LastDate { get; set; }
	}

	public class UserMissionModel
	{
		[JsonProperty("clearCount")]
		public int ClearCount { get; set; }
		[JsonProperty("missionCd")]
		public string MissionCd { get; set; }
		[JsonProperty("missionGroupId")]
		public int MissionGroupId { get; set; }
		[JsonProperty("missionId")]
		public int MissionId { get; set; }
		[JsonProperty("missionType")]
		public int MissionType { get; set; }
		[JsonProperty("receiveCount")]
		public int ReceiveCount { get; set; }
	}

	public class UserModel
	{
		[JsonProperty("userMainMaster")]
		public UserMainModel UserMainMaster { get; set; }
		[JsonProperty("userCd")]
		public string UserCd { get; set; }
		[JsonProperty("userName")]
		public string UserName { get; set; }
		[JsonProperty("userNameTextId")]
		public string UserNameTextId { get; set; }
		[JsonProperty("userNameStatus")]
		public int UserNameStatus { get; set; }
		[JsonProperty("level")]
		public int Level { get; set; }
		[JsonProperty("gem")]
		public UserGemModel Gem { get; set; }
		[JsonProperty("freeGem")]
		public int FreeGem { get; set; }
		[JsonProperty("paidGem")]
		public int PaidGem { get; set; }
		[JsonProperty("seVolume")]
		public int SeVolume { get; set; }
		[JsonProperty("bgmVolume")]
		public int BgmVolume { get; set; }
		[JsonProperty("voiceVolume")]
		public int VoiceVolume { get; set; }
		[JsonProperty("exp")]
		public int Exp { get; set; }
		[JsonProperty("nextLevelExp")]
		public int NextLevelExp { get; set; }
		[JsonProperty("nextLevelExpRate")]
		public double NextLevelExpRate { get; set; }
		[JsonProperty("totalExp")]
		public int TotalExp { get; set; }
		[JsonProperty("maxStamina")]
		public int MaxStamina { get; set; }
		[JsonProperty("maxBattlePoint")]
		public int MaxBattlePoint { get; set; }
		[JsonProperty("itemMaxCount")]
		public int ItemMaxCount { get; set; }
		[JsonProperty("systemDate")]
		public string SystemDate { get; set; }
		[JsonProperty("userText")]
		public string UserText { get; set; }
		[JsonProperty("playerType")]
		public int PlayerType { get; set; }
		[JsonProperty("battleSpeed")]
		public int BattleSpeed { get; set; }
		[JsonProperty("userMaxLevel")]
		public int UserMaxLevel { get; set; }
		[JsonProperty("isBgmMute")]
		public int IsBgmMute { get; set; }
		[JsonProperty("isSeMute")]
		public int IsSeMute { get; set; }
		[JsonProperty("isVoiceMute")]
		public int IsVoiceMute { get; set; }
		[JsonProperty("isSkillAuto")]
		public int IsSkillAuto { get; set; }
		[JsonProperty("roomCharacterMaxCount")]
		public int RoomCharacterMaxCount { get; set; }
		[JsonProperty("maxExpeditionDeck")]
		public int MaxExpeditionDeck { get; set; }
		[JsonProperty("maxTowerDeck")]
		public int MaxTowerDeck { get; set; }
		[JsonProperty("maxCharacterAddBorder")]
		public int MaxCharacterAddBorder { get; set; }
		[JsonProperty("characterMaxCount")]
		public int CharacterMaxCount { get; set; }
		[JsonProperty("equipmentMaxCount")]
		public int EquipmentMaxCount { get; set; }
		[JsonProperty("staminaValue")]
		public int StaminaValue { get; set; }
		[JsonProperty("currentStaminaInfo")]
		public dynamic CurrentStaminaInfo { get; set; }
		[JsonProperty("currentBattlePointInfo")]
		public dynamic CurrentBattlePointInfo { get; set; }
		[JsonProperty("registerDate")]
		public string RegisterDate { get; set; }
		[JsonProperty("tutorialStep")]
		public int TutorialStep { get; set; }
		[JsonProperty("tutorialEndDate")]
		public string TutorialEndDate { get; set; }
		[JsonProperty("designPattern")]
		public dynamic DesignPattern { get; set; }
	}

	public class UserNoticeModel
	{
		[JsonProperty("noticeCd")]
		public string NoticeCd { get; set; }
		[JsonProperty("sceneId")]
		public int SceneId { get; set; }
		[JsonProperty("transitionId")]
		public int TransitionId { get; set; }
		[JsonProperty("title")]
		public string Title { get; set; }
		[JsonProperty("message")]
		public string Message { get; set; }
		[JsonProperty("fromDate")]
		public string FromDate { get; set; }
		[JsonProperty("toDate")]
		public string ToDate { get; set; }
	}

	public class UserOrderPackModel
	{
		[JsonProperty("shopId")]
		public int ShopId { get; set; }
		[JsonProperty("listId")]
		public int ListId { get; set; }
		[JsonProperty("boxNo")]
		public int BoxNo { get; set; }
		[JsonProperty("selectIndex")]
		public int SelectIndex { get; set; }
		[JsonProperty("selectDate")]
		public string SelectDate { get; set; }
		[JsonProperty("decideDate")]
		public string DecideDate { get; set; }
	}

	public class UserPictureBookBaseModel
	{
		[JsonProperty("characterGroupId")]
		public int CharacterGroupId { get; set; }
		[JsonProperty("roomSelectCharacterId")]
		public int RoomSelectCharacterId { get; set; }
	}

	public class UserPictureBookDetailModel
	{
		[JsonProperty("friendship")]
		public int Friendship { get; set; }
		[JsonProperty("characterId")]
		public int CharacterId { get; set; }
		[JsonProperty("exceedLimit")]
		public int ExceedLimit { get; set; }
	}

	public class UserPrefModel
	{
		[JsonProperty("pref")]
		public UserPrefModel Pref { get; set; }
	}

	public class UserProgressModel
	{
		[JsonProperty("progressType")]
		public int ProgressType { get; set; }
		[JsonProperty("progressGroup")]
		public int ProgressGroup { get; set; }
		[JsonProperty("index")]
		public int Index { get; set; }
		[JsonProperty("conditionId")]
		public string ConditionId { get; set; }
		[JsonProperty("conditionParam")]
		public string ConditionParam { get; set; }
		[JsonProperty("releaseTargetParam")]
		public string ReleaseTargetParam { get; set; }
		[JsonProperty("userNoticeType")]
		public int UserNoticeType { get; set; }
		[JsonProperty("userNoticeText")]
		public string UserNoticeText { get; set; }
		[JsonProperty("description")]
		public string Description { get; set; }
	}

	public class UserPurchaseHistoryModel
	{
		[JsonProperty("todayQuantity")]
		public int TodayQuantity { get; set; }
		[JsonProperty("totalQuantity")]
		public int TotalQuantity { get; set; }
		[JsonProperty("shopId")]
		public int ShopId { get; set; }
		[JsonProperty("weeklyQuantity")]
		public int WeeklyQuantity { get; set; }
		[JsonProperty("monthlyQuantity")]
		public int MonthlyQuantity { get; set; }
		[JsonProperty("replenishmentDaysQuantity")]
		public int ReplenishmentDaysQuantity { get; set; }
		[JsonProperty("listId")]
		public int ListId { get; set; }
		[JsonProperty("lastPurchaseDate")]
		public string LastPurchaseDate { get; set; }
	}

	public class UserPvPModel
	{
		[JsonProperty("point")]
		public int Point { get; set; }
		[JsonProperty("season")]
		public int Season { get; set; }
		[JsonProperty("lastUpdateDate")]
		public string LastUpdateDate { get; set; }
		[JsonProperty("stamina")]
		public int Stamina { get; set; }
		[JsonProperty("lastRecoveryDate")]
		public string LastRecoveryDate { get; set; }
		[JsonProperty("updateCount")]
		public int UpdateCount { get; set; }
		[JsonProperty("winCount")]
		public int WinCount { get; set; }
		[JsonProperty("pvpClass")]
		public int PvpClass { get; set; }
		[JsonProperty("maxScore")]
		public int MaxScore { get; set; }
	}

	public class UserQuestModel
	{
		[JsonProperty("isClearMission2")]
		public int IsClearMission2 { get; set; }
		[JsonProperty("isClearMission3")]
		public int IsClearMission3 { get; set; }
		[JsonProperty("isClearMission1")]
		public int IsClearMission1 { get; set; }
		[JsonProperty("stageId")]
		public int StageId { get; set; }
		[JsonProperty("playCount")]
		public int PlayCount { get; set; }
		[JsonProperty("clearCount")]
		public int ClearCount { get; set; }
		[JsonProperty("lastPlayDate")]
		public string LastPlayDate { get; set; }
		[JsonProperty("lastSkipDate")]
		public string LastSkipDate { get; set; }
		[JsonProperty("todaySkipCount")]
		public int TodaySkipCount { get; set; }
		[JsonProperty("todayPlayCount")]
		public int TodayPlayCount { get; set; }
	}

	public class UserRaceCharacterModel
	{
		[JsonProperty("characterId")]
		public int CharacterId { get; set; }
		[JsonProperty("addP1")]
		public int AddP1 { get; set; }
		[JsonProperty("addP2")]
		public int AddP2 { get; set; }
		[JsonProperty("addP3")]
		public int AddP3 { get; set; }
		[JsonProperty("addP4")]
		public int AddP4 { get; set; }
		[JsonProperty("stamina")]
		public int Stamina { get; set; }
	}

	public class UserRaceSessionModel
	{
		[JsonProperty("season")]
		public int Season { get; set; }
		[JsonProperty("rank")]
		public int Rank { get; set; }
		[JsonProperty("stamina")]
		public int Stamina { get; set; }
		[JsonProperty("lastRaceStartDate")]
		public string LastRaceStartDate { get; set; }
		[JsonProperty("lastRaceEndDate")]
		public string LastRaceEndDate { get; set; }
		[JsonProperty("lastRecoveryDate")]
		public string LastRecoveryDate { get; set; }
	}

	public class UserRaidModel
	{
		[JsonProperty("entryRaidBattleSessions")]
		public dynamic EntryRaidBattleSessions { get; set; }
		[JsonProperty("publicRaidBattleSessions")]
		public dynamic PublicRaidBattleSessions { get; set; }
		[JsonProperty("nextRescueEnableDateList")]
		public List<dynamic> NextRescueEnableDateList { get; set; }
	}

	public class UserRoomLayoutModel
	{
		[JsonProperty("layoutId")]
		public int LayoutId { get; set; }
		[JsonProperty("layoutName")]
		public string LayoutName { get; set; }
		[JsonProperty("furnitureList")]
		public List<dynamic> FurnitureList { get; set; }
		[JsonProperty("characterList")]
		public List<CharacterModel> CharacterList { get; set; }
	}

	public class UserRoomModel
	{
		[JsonProperty("furnitureList")]
		public List<dynamic> FurnitureList { get; set; }
		[JsonProperty("characterList")]
		public List<CharacterModel> CharacterList { get; set; }
	}

	public class UserShopHistoryModel
	{
		[JsonProperty("userCd")]
		public string UserCd { get; set; }
	}

	public class UserSolidEquipmentModel
	{
		[JsonProperty("equipmentCd")]
		public string EquipmentCd { get; set; }
		[JsonProperty("equipmentId")]
		public int EquipmentId { get; set; }
		[JsonProperty("exceedLimit")]
		public int ExceedLimit { get; set; }
		[JsonProperty("count")]
		public int Count { get; set; }
	}

	public class UserSoundModel
	{
		[JsonProperty("soundId")]
		public int SoundId { get; set; }
	}

	public class UserStoryModel
	{
		[JsonProperty("storyId")]
		public int StoryId { get; set; }
		[JsonProperty("isRead")]
		public int IsRead { get; set; }
	}

	public class UserTowerSessionModel
	{
		[JsonProperty("sessionId")]
		public string SessionId { get; set; }
		[JsonProperty("towerSelectCount")]
		public int TowerSelectCount { get; set; }
		[JsonProperty("towerSelectMaxCount")]
		public int TowerSelectMaxCount { get; set; }
		[JsonProperty("towerSelectDate")]
		public string TowerSelectDate { get; set; }
		[JsonProperty("areaId")]
		public int AreaId { get; set; }
		[JsonProperty("battleSessionId")]
		public string BattleSessionId { get; set; }
		[JsonProperty("stageId")]
		public int StageId { get; set; }
		[JsonProperty("deckId")]
		public int DeckId { get; set; }
		[JsonProperty("deckType")]
		public int DeckType { get; set; }
		[JsonProperty("continueData")]
		public dynamic ContinueData { get; set; }
	}

	public class UserWarehouseCharacterModel
	{
		[JsonProperty("characterCd")]
		public string CharacterCd { get; set; }
		[JsonProperty("characterId")]
		public int CharacterId { get; set; }
		[JsonProperty("exceedLimit")]
		public int ExceedLimit { get; set; }
		[JsonProperty("count")]
		public int Count { get; set; }
		[JsonProperty("updateDate")]
		public string UpdateDate { get; set; }
	}

	public class UserWarehouseEquipmentModel
	{
		[JsonProperty("equipmentCd")]
		public string EquipmentCd { get; set; }
		[JsonProperty("equipmentId")]
		public int EquipmentId { get; set; }
		[JsonProperty("exceedLimit")]
		public int ExceedLimit { get; set; }
		[JsonProperty("count")]
		public int Count { get; set; }
		[JsonProperty("updateDate")]
		public string UpdateDate { get; set; }
	}

	public class UserWarehouseMaterialModel
	{
		[JsonProperty("materialCd")]
		public string MaterialCd { get; set; }
		[JsonProperty("materialId")]
		public int MaterialId { get; set; }
		[JsonProperty("count")]
		public int Count { get; set; }
		[JsonProperty("category")]
		public int Category { get; set; }
		[JsonProperty("updateDate")]
		public string UpdateDate { get; set; }
	}

	public class WarehouseCharacterModel
	{
		[JsonProperty("attribute")]
		public int Attribute { get; set; }
		[JsonProperty("category")]
		public int Category { get; set; }
		[JsonProperty("characterCd")]
		public string CharacterCd { get; set; }
		[JsonProperty("characterGroupId")]
		public int CharacterGroupId { get; set; }
		[JsonProperty("characterId")]
		public int CharacterId { get; set; }
		[JsonProperty("characterType")]
		public int CharacterType { get; set; }
		[JsonProperty("count")]
		public int Count { get; set; }
		[JsonProperty("exceedLimit")]
		public int ExceedLimit { get; set; }
		[JsonProperty("forceOriginalCharacterId")]
		public int ForceOriginalCharacterId { get; set; }
		[JsonProperty("groupMaster")]
		public dynamic GroupMaster { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
		[JsonProperty("levelMaster")]
		public int LevelMaster { get; set; }
		[JsonProperty("mainMaster")]
		public dynamic MainMaster { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("order")]
		public int Order { get; set; }
		[JsonProperty("rarity")]
		public int Rarity { get; set; }
		[JsonProperty("salePrice")]
		public int SalePrice { get; set; }
		[JsonProperty("shortName")]
		public string ShortName { get; set; }
		[JsonProperty("shortText")]
		public string ShortText { get; set; }
		[JsonProperty("skinName")]
		public string SkinName { get; set; }
		[JsonProperty("subAttribute")]
		public int SubAttribute { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
		[JsonProperty("updateDate")]
		public string UpdateDate { get; set; }
		[JsonProperty("usableCount")]
		public int UsableCount { get; set; }
		[JsonProperty("userCd")]
		public string UserCd { get; set; }
		[JsonProperty("warehouseType")]
		public int WarehouseType { get; set; }
	}

	public class WarehouseEquipmentModel
	{
		[JsonProperty("addExp")]
		public int AddExp { get; set; }
		[JsonProperty("attribute")]
		public int Attribute { get; set; }
		[JsonProperty("category")]
		public int Category { get; set; }
		[JsonProperty("count")]
		public int Count { get; set; }
		[JsonProperty("equipmentCd")]
		public string EquipmentCd { get; set; }
		[JsonProperty("equipmentGroupId")]
		public int EquipmentGroupId { get; set; }
		[JsonProperty("equipmentId")]
		public int EquipmentId { get; set; }
		[JsonProperty("equipmentMaterialMaster")]
		public EquipmentMaterialModel EquipmentMaterialMaster { get; set; }
		[JsonProperty("exceedLimit")]
		public int ExceedLimit { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
		[JsonProperty("levelMaster")]
		public int LevelMaster { get; set; }
		[JsonProperty("mainMaster")]
		public dynamic MainMaster { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("rarity")]
		public int Rarity { get; set; }
		[JsonProperty("salePrice")]
		public int SalePrice { get; set; }
		[JsonProperty("shortName")]
		public string ShortName { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
		[JsonProperty("updateDate")]
		public string UpdateDate { get; set; }
		[JsonProperty("usableCount")]
		public int UsableCount { get; set; }
		[JsonProperty("userCd")]
		public string UserCd { get; set; }
		[JsonProperty("warehouseType")]
		public int WarehouseType { get; set; }
	}

	public class WarehouseMaterialModel
	{
		[JsonProperty("addExp")]
		public int AddExp { get; set; }
		[JsonProperty("attribute")]
		public int Attribute { get; set; }
		[JsonProperty("category")]
		public int Category { get; set; }
		[JsonProperty("characterCd")]
		public string CharacterCd { get; set; }
		[JsonProperty("characterId")]
		public int CharacterId { get; set; }
		[JsonProperty("count")]
		public int Count { get; set; }
		[JsonProperty("equipmentCd")]
		public string EquipmentCd { get; set; }
		[JsonProperty("equipmentId")]
		public int EquipmentId { get; set; }
		[JsonProperty("equipmentMaterialMaster")]
		public EquipmentMaterialModel EquipmentMaterialMaster { get; set; }
		[JsonProperty("exceedLimit")]
		public int ExceedLimit { get; set; }
		[JsonProperty("itemType")]
		public int ItemType { get; set; }
		[JsonProperty("levelMaster")]
		public int LevelMaster { get; set; }
		[JsonProperty("mainMaster")]
		public dynamic MainMaster { get; set; }
		[JsonProperty("materialCd")]
		public string MaterialCd { get; set; }
		[JsonProperty("materialId")]
		public int MaterialId { get; set; }
		[JsonProperty("materialType")]
		public int MaterialType { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("order")]
		public int Order { get; set; }
		[JsonProperty("rarity")]
		public int Rarity { get; set; }
		[JsonProperty("salePrice")]
		public int SalePrice { get; set; }
		[JsonProperty("shortName")]
		public string ShortName { get; set; }
		[JsonProperty("subAttribute")]
		public int SubAttribute { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
		[JsonProperty("updateDate")]
		public string UpdateDate { get; set; }
		[JsonProperty("usableCount")]
		public int UsableCount { get; set; }
		[JsonProperty("userCd")]
		public string UserCd { get; set; }
		[JsonProperty("warehouseType")]
		public int WarehouseType { get; set; }
	}

}

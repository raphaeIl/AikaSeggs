using AikaSeggs.Common.Core;
using AikaSeggs.Common.Database;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace AikaSeggs.Common.Database
{
	public class BattleMonsterModel
	{
		public int EnemyId { get; set; }
		public int Level { get; set; }
		public int Index { get; set; }
		public int SkillId { get; set; }
		public dynamic AbilityData { get; set; }
		public dynamic SkillData { get; set; }
		public int Attribute { get; set; }
		public int SubAttribute { get; set; }
		public int BaseMaxHp { get; set; }
		public int BaseAtk { get; set; }
		public int BaseDef { get; set; }
		public string SpineDirectoryPath { get; set; }
		public string SpineName { get; set; }
		public string IconName { get; set; }
		public List<dynamic> EnemyAIList { get; set; }
		public dynamic NormalAttackData { get; set; }
		public dynamic ResistData { get; set; }
		public string Name { get; set; }
		public double SpineScale { get; set; }
		public bool IsBoss { get; set; }
		public List<dynamic> RageDataList { get; set; }
		public bool IsBeatBoss { get; set; }
		public int SubAttributeAtk { get; set; }
		public int Id { get; set; }
		public dynamic BaseMaxHpExceptEquipEffect { get; set; }
		public dynamic BaseAtkExceptEquipEffect { get; set; }
		public dynamic BaseDefExceptEquipEffect { get; set; }
		public dynamic _MainObjectNode { get; set; }
		public dynamic _DamageShowNode { get; set; }
		public dynamic _EffectShowNode { get; set; }
		public dynamic _BuffShowNode { get; set; }
		public dynamic CharaterModel { get; set; }
		public int UnisonType { get; set; }
		public int NormalAttackId { get; set; }
		public int EffectShowType { get; set; }
		public dynamic EffectShowValue { get; set; }
		public string AniName { get; set; }
		public string HitEffectName { get; set; }
		public string HitEffectAniName { get; set; }
	}

	public class BattleSessionModel
	{
		public string SessionId { get; set; }
		public int DeckId { get; set; }
		public int StageId { get; set; }
		public dynamic SaveData { get; set; }
	}

	public class BoostGroupModel
	{
		public int WorldId { get; set; }
		public int BoostGroupId { get; set; }
		public int BoostType { get; set; }
		public int TargetId { get; set; }
	}

	public class BoostModel
	{
		public int BoostType { get; set; }
		public int ItemId { get; set; }
		public dynamic Parameter { get; set; }
		public string EndDate { get; set; }
		public string StartDate { get; set; }
		public ItemMainModel ItemMainMaster { get; set; }
	}

	public class BossEventPointModel
	{
		public int EventId { get; set; }
		public int StageId { get; set; }
		public int BossId { get; set; }
		public int CountMax { get; set; }
	}

	public class BossGaugeColorModel
	{
		public int GaugeColorId { get; set; }
		public int Red { get; set; }
		public int Green { get; set; }
		public int Blue { get; set; }
		public int Alpha { get; set; }
	}

	public class BossRageAnimationModel
	{
		public int RageAnimId { get; set; }
		public string ActionAnimSuffix { get; set; }
		public string RageAnim { get; set; }
	}

	public class BossStageModel
	{
		public int StageId { get; set; }
		public int Turn { get; set; }
	}

	public class CabinMissionDetailModel
	{
		public int MissionGroupId { get; set; }
		public int MissionId { get; set; }
		public int ConditionType { get; set; }
		public string ConditionValue { get; set; }
	}

	public class CabinMissionMainModel
	{
		public int MissionGroupId { get; set; }
		public dynamic MemorialId1 { get; set; }
		public dynamic MemorialId2 { get; set; }
		public dynamic MemorialId3 { get; set; }
		public dynamic MemorialId4 { get; set; }
		public string VisibleDate { get; set; }
	}

	public class CabinMissionModel
	{
		public int MissionGroupId { get; set; }
		public int MissionId { get; set; }
		public int ReceiveCount { get; set; }
	}

	public class CabinMissionRewardModel
	{
		public int MissionId { get; set; }
		public int ItemType { get; set; }
		public int ItemId { get; set; }
		public int Count { get; set; }
	}

	public class CampaignModel
	{
		public int TargetType { get; set; }
		public dynamic TargetIds { get; set; }
		public int CampaignType { get; set; }
		public dynamic CampaignValue { get; set; }
		public string FromDate { get; set; }
		public string ToDate { get; set; }
		public string WeekTypes { get; set; }
	}

	public class CharacterAbilityConditionModel
	{
		public int AbilityId { get; set; }
		public int ConditionGroup { get; set; }
		public int ConditionType { get; set; }
		public string ConditionValue { get; set; }
	}

	public class CharacterAbilityEffectModel
	{
		public int AbilityId { get; set; }
		public int Index { get; set; }
		public int OccurrenceRate { get; set; }
		public int EffectConditionType { get; set; }
		public int Level { get; set; }
		public int SuccessRate { get; set; }
		public string Text { get; set; }
		public string ShortText { get; set; }
		public int EffectLimit { get; set; }
		public string EffectConditionValue { get; set; }
		public int TargetType { get; set; }
		public int EffectValue { get; set; }
		public int ActionType { get; set; }
		public string EndValue { get; set; }
		public int EffectType { get; set; }
		public int EndType { get; set; }
		public string TargetValue { get; set; }
	}

	public class CharacterAbilityGroupModel
	{
		public int AbilityId { get; set; }
		public int Index { get; set; }
		public int AbilityGroupId { get; set; }
	}

	public class CharacterAbilityMainModel
	{
		public int AbilityId { get; set; }
		public string Name { get; set; }
		public int InvokeLimitCount { get; set; }
		public int AddAbilityId { get; set; }
		public int AbilityFortifyType { get; set; }
		public int TriggerType { get; set; }
		public string TriggerValue { get; set; }
	}

	public class CharacterAbilityUpModel
	{
		public int AbilityFortifyType { get; set; }
		public int Level { get; set; }
		public int MaterialId1 { get; set; }
		public int MaterialCount1 { get; set; }
		public int MaterialId2 { get; set; }
		public int MaterialCount2 { get; set; }
		public int MaterialId3 { get; set; }
		public int MaterialCount3 { get; set; }
		public int MaterialId4 { get; set; }
		public int MaterialCount4 { get; set; }
		public int MaterialId5 { get; set; }
		public int MaterialCount5 { get; set; }
		public int Price { get; set; }
	}

	public class CharacterAlterModel
	{
		public int CharacterId { get; set; }
	}

	public class CharacterAwakeConditionModel
	{
		public string ConditionValue { get; set; }
		public int Index { get; set; }
		public int ConditionType { get; set; }
		public int AwakeId { get; set; }
	}

	public class CharacterAwakeEffectModel
	{
		public int Index { get; set; }
		public int AwakeId { get; set; }
		public string Text { get; set; }
		public int Value { get; set; }
		public int AwakeType { get; set; }
		public string EffectColumn { get; set; }
		public int EffectIndex { get; set; }
		public int TargetIndex { get; set; }
	}

	public class CharacterAwakeGroupModel
	{
		public int AwakeGroupId { get; set; }
		public int EquipmentId { get; set; }
		public int CharacterId { get; set; }
	}

	public class CharacterAwakeMainModel
	{
		public int Index { get; set; }
		public int Price { get; set; }
		public int IconType { get; set; }
		public int AwakeId { get; set; }
		public int AwakeGroupId { get; set; }
	}

	public class CharacterAwakeMaterialModel
	{
		public int Count { get; set; }
		public int Index { get; set; }
		public int AwakeId { get; set; }
		public int MaterialId { get; set; }
		public int MaterialType { get; set; }
	}

	public class CharacterContentsModel
	{
		public dynamic ConditionValue1 { get; set; }
		public dynamic ConditionValue2 { get; set; }
		public dynamic ConditionType1 { get; set; }
		public dynamic ConditionType2 { get; set; }
		public int ContentsId { get; set; }
		public int ContentType { get; set; }
		public int ContentsGroupId { get; set; }
		public int StoryId { get; set; }
		public int TextId { get; set; }
	}

	public class CharacterEvolutionEffectModel
	{
		public int EffectId { get; set; }
		public int HpRate { get; set; }
		public int AtkRate { get; set; }
		public int DefRate { get; set; }
		public int SkillId { get; set; }
		public int AbilityGroupId { get; set; }
	}

	public class CharacterEvolutionMainModel
	{
		public int CharacterId { get; set; }
		public int Rarity { get; set; }
		public int MaterialId { get; set; }
		public int EffectId { get; set; }
		public int SkillFortifyType { get; set; }
	}

	public class CharacterEvolutionMaterialModel
	{
		public int MaterialId { get; set; }
		public int ItemType { get; set; }
		public int ItemId { get; set; }
		public int Count { get; set; }
	}

	public class CharacterExceedLimitModel
	{
		public int ExceedLimitType { get; set; }
		public int ExceedLimit { get; set; }
		public int MaterialId { get; set; }
		public int MaterialCount { get; set; }
		public int TotalExceedLimitExp { get; set; }
		public int NeedExceedLimitExp { get; set; }
		public int EquipmentWeaponCount { get; set; }
		public int EquipmentProtectorCount { get; set; }
		public int AbilityCount { get; set; }
		public int ExceedLimitPrice { get; set; }
	}

	public class CharacterFavoriteModel
	{
		public int CharacterId { get; set; }
		public int FavoriteItemId { get; set; }
		public int AddType { get; set; }
		public int Value { get; set; }
	}

	public class CharacterGroupModel
	{
		public int CharacterGroupId { get; set; }
		public int Order { get; set; }
		public string Name { get; set; }
		public string ShortName { get; set; }
		public string RoomName { get; set; }
		public string ReadingName { get; set; }
		public string Text { get; set; }
		public dynamic Union { get; set; }
		public int ContentsGroupId { get; set; }
		public string FromDate { get; set; }
		public int StandHeadPositionX { get; set; }
		public int StandHeadPositionY { get; set; }
	}

	public class CharacterGroupSeasonModel
	{
		public int CharacterGroupId { get; set; }
		public int TargetType { get; set; }
		public int Value { get; set; }
		public string FromDate { get; set; }
		public string ToDate { get; set; }
	}

	public class CharacterLevelModel
	{
		public int Level { get; set; }
		public int ExpType { get; set; }
		public int SalePrice { get; set; }
		public int FortifyPrice { get; set; }
		public int TotalExp { get; set; }
		public int NextLevelExp { get; set; }
	}

	public class CharacterLinkModel
	{
		public int CharacterId { get; set; }
		public int LinkerId { get; set; }
		public int Priority { get; set; }
	}

	public class CharacterLinkUnitModel
	{
		public int CharacterId { get; set; }
		public int LinkerId { get; set; }
		public int ParentId { get; set; }
		public int Priority { get; set; }
		public string CharacterCd { get; set; }
		public int CharacterExp { get; set; }
		public int Level { get; set; }
		public int ExceedLimitExp { get; set; }
		public int ExceedLimit { get; set; }
		public int AddHp { get; set; }
		public int AddAtk { get; set; }
		public int AddDef { get; set; }
		public List<string> EquipmentWeaponCds { get; set; }
		public List<dynamic> EquipmentProtectorCds { get; set; }
		public int IsProtect { get; set; }
		public int BattleCount { get; set; }
		public int AddRarity { get; set; }
		public List<dynamic> AwakeIds { get; set; }
		public int SkillLevel { get; set; }
		public int AbilityLevel1 { get; set; }
		public int AbilityLevel2 { get; set; }
		public int AbilityLevel3 { get; set; }
		public CharacterMainModel CharacterMainMaster { get; set; }
		public dynamic ParentCharacterModel { get; set; }
		public string Name { get; set; }
		public string ShortName { get; set; }
		public string SkinName { get; set; }
		public int Attribute { get; set; }
		public int SubAttribute { get; set; }
		public int SubAttributePower { get; set; }
		public int HasSubAttribute { get; set; }
		public int BaseRarity { get; set; }
		public int Rarity { get; set; }
		public int CharacterGroupId { get; set; }
		public int ForceOriginalGroupId { get; set; }
		public int Order { get; set; }
		public int ContentsGroupId { get; set; }
		public int CostumeId { get; set; }
		public int CharacterType { get; set; }
		public string SpineName { get; set; }
		public string SpineDirectoryPath { get; set; }
		public int ExceedLimitType { get; set; }
		public int ExceedLimitAlternateId { get; set; }
		public int MaxFortifyHp { get; set; }
		public int MaxFortifyAtk { get; set; }
		public int MaxFortifyDef { get; set; }
		public bool IsSellMaterial { get; set; }
		public bool IsFortifyMaterial { get; set; }
		public bool IsSkillMaterial { get; set; }
		public Dictionary<string, CharacterExceedLimitModel> CharacterExceedLimitMasterMap { get; set; }
		public CharacterExceedLimitModel CharacterExceedLimitMaster { get; set; }
		public dynamic SkillMainMaster { get; set; }
		public CharacterMaterialModel CharacterMaterialMaster { get; set; }
		public List<CharacterExceedLimitModel> CharacterExceedLimitMasterArray { get; set; }
		public CharacterNormalAttackModel CharacterNormalAttackMaster { get; set; }
		public dynamic AwakeGroupMaster { get; set; }
		public Dictionary<string, dynamic> SkillEffectMasterMap { get; set; }
		public int FortifyPrice { get; set; }
		public dynamic UserSkillMainModel { get; set; }
		public dynamic UserAbilityGroupModel { get; set; }
		public List<dynamic> UserSkillEffectModelArray { get; set; }
		public List<dynamic> SkillEffectModelArray { get; set; }
		public List<dynamic> AbilityEffectModelArray { get; set; }
		public List<dynamic> CharacterEquipmentInfoArray { get; set; }
		public dynamic CharacterSkillInfo { get; set; }
		public bool IsLevelMax { get; set; }
		public int NeedExpForNextLevel { get; set; }
		public int ExpRateForNextLevel { get; set; }
		public int NeedExpForNextExceedLimit { get; set; }
		public int MaxSkillLevel { get; set; }
		public string SkillName { get; set; }
		public string SkillText { get; set; }
		public string SkillShortText { get; set; }
		public int AddExp { get; set; }
		public int AddExceedLimitExp { get; set; }
		public double AddSkillUpRate { get; set; }
		public int MaterialType { get; set; }
		public int BaseSkillFortifyType { get; set; }
		public int SkillFortifyType { get; set; }
		public int MaxLevel { get; set; }
		public int TotalBasePower { get; set; }
		public PictureBookDetailModel PictureBookDetailModel { get; set; }
		public dynamic TotalHpExceptEquipEffect { get; set; }
		public int Hp { get; set; }
		public dynamic TotalAtkExceptEquipEffect { get; set; }
		public int Atk { get; set; }
		public dynamic TotalDefExceptEquipEffect { get; set; }
		public int Def { get; set; }
		public dynamic TotalStatus { get; set; }
		public int ExceedLimitMaterialId { get; set; }
		public int ExceedLimitMaterialCount { get; set; }
		public int ExceedLimitPrice { get; set; }
		public dynamic EventBoost { get; set; }
		public List<dynamic> EnabledAwakeMainMasterArray { get; set; }
		public List<dynamic> EnabledAwakeEffectMasterArray { get; set; }
		public CharacterEvolutionMainModel CharacterEvolutionMainMaster { get; set; }
		public int SkillId { get; set; }
		public int AbilityGroupId { get; set; }
		public int HpRate { get; set; }
		public int AtkRate { get; set; }
		public int DefRate { get; set; }
		public List<CharacterLinkUnitModel> CharacterLinkUnitArray { get; set; }
	}

	public class CharacterMainModel
	{
		public int CharacterGroupId { get; set; }
		public int CharacterId { get; set; }
		public int CharacterType { get; set; }
		public string Name { get; set; }
		public string ShortName { get; set; }
		public string SkinName { get; set; }
		public string ReadingName { get; set; }
		public string Text { get; set; }
		public string ShortText { get; set; }
		public string VoiceActorName { get; set; }
		public string IllustratorName { get; set; }
		public int ContentsGroupId { get; set; }
		public int CostumeId { get; set; }
		public int Rarity { get; set; }
		public int Attribute { get; set; }
		public int SubAttribute { get; set; }
		public int SubAttributePower { get; set; }
		public int SkillId { get; set; }
		public int AbilityGroupId { get; set; }
		public int SupportAbilityGroupId { get; set; }
		public int NormalAttackId { get; set; }
		public string SpineDirectoryPath { get; set; }
		public string SpineName { get; set; }
		public string AtlasName { get; set; }
		public string MyPageBgFileName { get; set; }
		public int ExpType { get; set; }
		public int MaterialType { get; set; }
		public int ExceedLimitType { get; set; }
		public int MaxLevel0 { get; set; }
		public int MaxLevel1 { get; set; }
		public int MaxLevel2 { get; set; }
		public int MaxLevel3 { get; set; }
		public int MaxLevel4 { get; set; }
		public int MinHp { get; set; }
		public int MaxHp0 { get; set; }
		public int MaxHp1 { get; set; }
		public int MaxHp2 { get; set; }
		public int MaxHp3 { get; set; }
		public int MaxHp4 { get; set; }
		public int MaxAddHp { get; set; }
		public int MaxFortifyHp { get; set; }
		public int MinAtk { get; set; }
		public int MaxAtk0 { get; set; }
		public int MaxAtk1 { get; set; }
		public int MaxAtk2 { get; set; }
		public int MaxAtk3 { get; set; }
		public int MaxAtk4 { get; set; }
		public int MaxAddAtk { get; set; }
		public int MaxFortifyAtk { get; set; }
		public int MinDef { get; set; }
		public int MaxDef0 { get; set; }
		public int MaxDef1 { get; set; }
		public int MaxDef2 { get; set; }
		public int MaxDef3 { get; set; }
		public int MaxDef4 { get; set; }
		public int MaxAddDef { get; set; }
		public int MaxFortifyDef { get; set; }
		public int MinLuck { get; set; }
		public int MaxLuck0 { get; set; }
		public int MaxLuck1 { get; set; }
		public int MaxLuck2 { get; set; }
		public int MaxLuck3 { get; set; }
		public int MaxLuck4 { get; set; }
		public int MaxAddLuck { get; set; }
		public string ReleaseDate { get; set; }
		public string VisibleDate { get; set; }
	}

	public class CharacterMaterialModel
	{
		public int MaterialType { get; set; }
		public int AddExp { get; set; }
		public int AddHp { get; set; }
		public int AddAtk { get; set; }
		public int AddDef { get; set; }
		public int AddExceedLimitExp { get; set; }
		public double AddSkillUpRate { get; set; }
	}

	public class CharacterModel
	{
		public int CharacterId { get; set; }
		public int ForceOriginalCharacterId { get; set; }
		public string CharacterCd { get; set; }
		public int CharacterExp { get; set; }
		public int Level { get; set; }
		public int ExceedLimitExp { get; set; }
		public int ExceedLimit { get; set; }
		public int AddHp { get; set; }
		public int AddAtk { get; set; }
		public int AddDef { get; set; }
		public List<string> EquipmentWeaponCds { get; set; }
		public List<dynamic> EquipmentProtectorCds { get; set; }
		public int IsProtect { get; set; }
		public int BattleCount { get; set; }
		public int AddRarity { get; set; }
		public List<dynamic> AwakeIds { get; set; }
		public int SkillLevel { get; set; }
		public int AbilityLevel1 { get; set; }
		public int AbilityLevel2 { get; set; }
		public int AbilityLevel3 { get; set; }
		public dynamic ForceOriginalCharacterMainMaster { get; set; }
		public string Name { get; set; }
		public string ShortName { get; set; }
		public string SkinName { get; set; }
		public int Attribute { get; set; }
		public int SubAttribute { get; set; }
		public int SubAttributePower { get; set; }
		public int HasSubAttribute { get; set; }
		public int BaseRarity { get; set; }
		public int Rarity { get; set; }
		public int CharacterGroupId { get; set; }
		public int ForceOriginalGroupId { get; set; }
		public int Order { get; set; }
		public int ContentsGroupId { get; set; }
		public int CostumeId { get; set; }
		public int CharacterType { get; set; }
		public string SpineName { get; set; }
		public string SpineDirectoryPath { get; set; }
		public int ExceedLimitType { get; set; }
		public int ExceedLimitAlternateId { get; set; }
		public int MaxFortifyHp { get; set; }
		public int MaxFortifyAtk { get; set; }
		public int MaxFortifyDef { get; set; }
		public bool IsSellMaterial { get; set; }
		public bool IsFortifyMaterial { get; set; }
		public bool IsSkillMaterial { get; set; }
		public Dictionary<string, CharacterExceedLimitModel> CharacterExceedLimitMasterMap { get; set; }
		public CharacterExceedLimitModel CharacterExceedLimitMaster { get; set; }
		public dynamic SkillMainMaster { get; set; }
		public CharacterMaterialModel CharacterMaterialMaster { get; set; }
		public List<CharacterExceedLimitModel> CharacterExceedLimitMasterArray { get; set; }
		public CharacterNormalAttackModel CharacterNormalAttackMaster { get; set; }
		public dynamic AwakeGroupMaster { get; set; }
		public Dictionary<string, dynamic> SkillEffectMasterMap { get; set; }
		public int CharacterLevelMaster { get; set; }
		public int FortifyPrice { get; set; }
		public int SalePrice { get; set; }
		public dynamic UserSkillMainModel { get; set; }
		public dynamic UserAbilityGroupModel { get; set; }
		public List<dynamic> UserSkillEffectModelArray { get; set; }
		public List<dynamic> SkillEffectModelArray { get; set; }
		public List<dynamic> AbilityEffectModelArray { get; set; }
		public List<CharacterLinkUnitModel> CharacterLinkUnitArray { get; set; }
		public List<dynamic> AvailableEquipmentModelList { get; set; }
		public List<dynamic> AvailableEquipmentWeaponModelList { get; set; }
		public List<dynamic> AvailableEquipmentProtectorModelList { get; set; }
		public List<dynamic> CharacterEquipmentInfoArray { get; set; }
		public dynamic CharacterSkillInfo { get; set; }
		public bool IsLevelMax { get; set; }
		public int NeedExpForNextLevel { get; set; }
		public int ExpRateForNextLevel { get; set; }
		public int NeedExpForNextExceedLimit { get; set; }
		public int MaxSkillLevel { get; set; }
		public string SkillName { get; set; }
		public string SkillText { get; set; }
		public string SkillShortText { get; set; }
		public bool IsDeckUnit { get; set; }
		public int IsMaxExceedLimit { get; set; }
		public int ExceedLimitMaxCount { get; set; }
		public int AddExp { get; set; }
		public int AddExceedLimitExp { get; set; }
		public double AddSkillUpRate { get; set; }
		public int MaterialType { get; set; }
		public int BaseSkillFortifyType { get; set; }
		public int SkillFortifyType { get; set; }
		public int MaxLevel { get; set; }
		public int TotalBasePower { get; set; }
		public PictureBookDetailModel PictureBookDetailModel { get; set; }
		public dynamic TotalHpExceptEquipEffect { get; set; }
		public int Hp { get; set; }
		public dynamic TotalAtkExceptEquipEffect { get; set; }
		public int Atk { get; set; }
		public dynamic TotalDefExceptEquipEffect { get; set; }
		public int Def { get; set; }
		public dynamic TotalStatus { get; set; }
		public int ExceedLimitMaterialId { get; set; }
		public int ExceedLimitMaterialCount { get; set; }
		public int ExceedLimitPrice { get; set; }
		public dynamic EventBoost { get; set; }
		public bool IsCompleteAwake { get; set; }
		public List<dynamic> AwakeMainMasterArray { get; set; }
		public List<dynamic> EnabledAwakeMainMasterArray { get; set; }
		public List<dynamic> EnabledAwakeEffectMasterArray { get; set; }
		public CharacterEvolutionMainModel CharacterEvolutionMainMaster { get; set; }
		public int SkillId { get; set; }
		public int AbilityGroupId { get; set; }
		public int HpRate { get; set; }
		public int AtkRate { get; set; }
		public int DefRate { get; set; }
		public dynamic NextCharacterEvolutionMainMaster { get; set; }
		public bool IsAvailableEvolution { get; set; }
		public bool IsCompleteEvolutionCondition { get; set; }
		public bool IsCompleteEvolutionMaterial { get; set; }
		public int CharacterLinkByPriority { get; set; }
	}

	public class CharacterNormalAttackModel
	{
		public string SpineDirectoryPath { get; set; }
		public string HitEffectName { get; set; }
		public int NormalAttackId { get; set; }
		public string AniName { get; set; }
		public dynamic EffectShowValue { get; set; }
		public int EffectShowType { get; set; }
		public string HitEffectAniName { get; set; }
	}

	public class CharacterSellBonusModel
	{
		public int Rarity { get; set; }
		public int ItemType { get; set; }
		public int ItemId { get; set; }
		public int Count { get; set; }
	}

	public class CharacterSkillEffectModel
	{
		public int Index { get; set; }
		public int OccurrenceRate { get; set; }
		public int EffectConditionType { get; set; }
		public int Level { get; set; }
		public int SuccessRate { get; set; }
		public string Text { get; set; }
		public string ShortText { get; set; }
		public int EffectLimit { get; set; }
		public string EffectConditionValue { get; set; }
		public int TargetType { get; set; }
		public int EffectValue { get; set; }
		public int ActionType { get; set; }
		public string EndValue { get; set; }
		public int EffectType { get; set; }
		public int EndType { get; set; }
		public string TargetValue { get; set; }
		public int SkillId { get; set; }
	}

	public class CharacterSkillMainModel
	{
		public int SkillId { get; set; }
		public string Name { get; set; }
		public int EffectShowType { get; set; }
		public string SpineDirectoryPath { get; set; }
		public string SpineName { get; set; }
		public string AniName { get; set; }
		public string HitEffectName { get; set; }
		public string HitEffectAniName { get; set; }
		public double BgmVolumeAmount { get; set; }
		public int SkillFortifyType { get; set; }
	}

	public class CharacterSkillUpModel
	{
		public int SkillFortifyType { get; set; }
		public int Level { get; set; }
		public int AddSkillUpRate1 { get; set; }
		public int AddSkillUpRate2 { get; set; }
		public int AddSkillUpRate3 { get; set; }
		public int AddSkillUpRate4 { get; set; }
		public int Price { get; set; }
	}

	public class CharacterSkillUpRateModel
	{
		public int LuckTotal { get; set; }
		public int SkillLevel { get; set; }
		public int Rate { get; set; }
	}

	public class CharacterStandPositionModel
	{
		public int CharacterId { get; set; }
		public int StandHeadPositionX { get; set; }
		public int StandHeadPositionY { get; set; }
		public int AtlasHeadPositionX { get; set; }
		public int AtlasHeadPositionY { get; set; }
		public int SpinePositionX { get; set; }
		public int SpinePositionY { get; set; }
	}

	public class CharacterTextModel
	{
		public int CharacterId { get; set; }
		public int SceneType { get; set; }
		public int GroupType { get; set; }
		public int TextId { get; set; }
		public string Title { get; set; }
		public string Text { get; set; }
		public string SkinName { get; set; }
		public string VoiceFile { get; set; }
	}

	public class ComebackGachaModel
	{
		public string ReleaseDate { get; set; }
		public int GachaId { get; set; }
		public int CampaignId { get; set; }
	}

	public class ComebackGroupModel
	{
		public int CampaignGroupId { get; set; }
		public string ToDate { get; set; }
	}

	public class ComebackMainModel
	{
		public int CampaignId { get; set; }
		public int CampaignGroupId { get; set; }
	}

	public class ComebackModel
	{
		public int CampaignId { get; set; }
		public string IgniteDate { get; set; }
	}

	public class ComebackNewsModel
	{
		public int CampaignId { get; set; }
		public int NewsId { get; set; }
	}

	public class ComebackPopupModel
	{
		public string ReleaseDate { get; set; }
		public int PopupId { get; set; }
		public int CampaignId { get; set; }
	}

	public class ComebackShopModel
	{
		public int CampaignId { get; set; }
		public int ShopId { get; set; }
	}

	public class DeckModel
	{
		public CharacterModel CharacterModel { get; set; }
		public string CharacterCd { get; set; }
		public int DeckId { get; set; }
		public int Position { get; set; }
		public int DeckType { get; set; }
		public int RoleType { get; set; }
	}

	public class DmmModel
	{
		public int SkuId { get; set; }
		public string Name { get; set; }
		public string IconName { get; set; }
		public string Text { get; set; }
		public int Price { get; set; }
		public int PurchaseType { get; set; }
	}

	public class EnemyAbilityConditionModel
	{
		public int AbilityId { get; set; }
		public int ConditionGroup { get; set; }
		public int ConditionType { get; set; }
		public string ConditionValue { get; set; }
	}

	public class EquipmentAbilityConditionModel
	{
		public int EquipmentId { get; set; }
		public int ConditionGroup { get; set; }
		public int ConditionType { get; set; }
		public string ConditionValue { get; set; }
	}

	public class EquipmentEffectModel
	{
		public int EquipmentId { get; set; }
		public int BoostType { get; set; }
		public int Rarity { get; set; }
		public int Level { get; set; }
		public int Index { get; set; }
		public string Text { get; set; }
		public int ActionType { get; set; }
		public int EffectType { get; set; }
		public int EffectValue { get; set; }
		public int EffectLimit { get; set; }
		public int EffectConditionType { get; set; }
		public string EffectConditionValue { get; set; }
		public int OccurrenceRate { get; set; }
		public int SuccessRate { get; set; }
		public int TargetType { get; set; }
		public string TargetValue { get; set; }
		public int EndType { get; set; }
		public string EndValue { get; set; }
	}

	public class EquipmentExceedLimitItemModel
	{
		public int ExceedLimitItemType { get; set; }
		public int Rarity { get; set; }
		public int MaterialId { get; set; }
		public int Count { get; set; }
		public int ExceedLimitPrice { get; set; }
	}

	public class EquipmentExceedLimitModel
	{
		public int ExceedLimitType { get; set; }
		public int Rarity { get; set; }
		public int MaterialRarity { get; set; }
		public int ExceedLimitPrice { get; set; }
	}

	public class EquipmentLevelModel
	{
		public int ExpType { get; set; }
		public int Level { get; set; }
		public int TotalExp { get; set; }
		public int NextLevelExp { get; set; }
		public int FortifyPrice { get; set; }
		public int SalePrice { get; set; }
	}

	public class EquipmentMainModel
	{
		public int MaxDef2 { get; set; }
		public int MaxDef3 { get; set; }
		public int ExceedLimitType { get; set; }
		public int MaxAtk4 { get; set; }
		public int MaxAtk3 { get; set; }
		public int MaxAtk2 { get; set; }
		public int MaxAtk1 { get; set; }
		public int MaterialType { get; set; }
		public int MinDef2 { get; set; }
		public string Text { get; set; }
		public int EquipmentId { get; set; }
		public int EquipmentGroupId { get; set; }
		public int MaxDef1 { get; set; }
		public int MinAtk1 { get; set; }
		public int MaxLevel4 { get; set; }
		public int MaxHp2 { get; set; }
		public int MaxHp3 { get; set; }
		public int MaxLevel1 { get; set; }
		public int MinAtk4 { get; set; }
		public int MaxLevel3 { get; set; }
		public int MaxLevel2 { get; set; }
		public string UniqueId { get; set; }
		public int Attribute { get; set; }
		public int MinDef4 { get; set; }
		public int MaxHp1 { get; set; }
		public int MinAtk3 { get; set; }
		public int UniqueType { get; set; }
		public int MinAtk2 { get; set; }
		public int TriggerType { get; set; }
		public int MaxHp4 { get; set; }
		public int MinDef1 { get; set; }
		public int MinHp2 { get; set; }
		public int MinHp3 { get; set; }
		public int MinHp1 { get; set; }
		public string Name { get; set; }
		public int MinHp4 { get; set; }
		public int MinDef3 { get; set; }
		public int EquipmentType { get; set; }
		public int Rarity { get; set; }
		public int ExceedLimitItemType { get; set; }
		public int MaxDef4 { get; set; }
		public string TriggerValue { get; set; }
		public int ResourceId { get; set; }
		public string PostName { get; set; }
		public int InvokeLimitCount { get; set; }
	}

	public class EquipmentMaterialModel
	{
		public int MaterialType { get; set; }
		public int AddExp { get; set; }
	}

	public class EquipmentModel
	{
		public EquipmentMaterialModel EquipmentMaterialMaster { get; set; }
		public EquipmentMainModel EquipmentMainMaster { get; set; }
		public Dictionary<string, dynamic> EquipmentEffectInfoMap { get; set; }
		public int EquipmentLevelMaster { get; set; }
		public int EquipmentGroupId { get; set; }
		public int EquipmentId { get; set; }
		public string EquipmentCd { get; set; }
		public int MaterialType { get; set; }
		public string Name { get; set; }
		public int MaxHp { get; set; }
		public int MaxAtk { get; set; }
		public int MaxDef { get; set; }
		public int MinHp { get; set; }
		public int MinAtk { get; set; }
		public int MinDef { get; set; }
		public int MaxLevel { get; set; }
		public int FortifyMaxLevel { get; set; }
		public int Attribute { get; set; }
		public int UniqueType { get; set; }
		public string Text { get; set; }
		public int Level { get; set; }
		public bool IsLevelMax { get; set; }
		public int FortifyLevel { get; set; }
		public int IsProtect { get; set; }
		public bool IsCharacterEquipment { get; set; }
		public dynamic NeedMaterials { get; set; }
		public int FortifyPrice { get; set; }
		public int AddExp { get; set; }
		public int BaseRarity { get; set; }
		public int Exp { get; set; }
		public int ExceedLimit { get; set; }
		public int Rarity { get; set; }
		public int IsMaxRarity { get; set; }
		public int SalePrice { get; set; }
		public int EquipmentType { get; set; }
		public int ExceedLimitType { get; set; }
		public EquipmentEffectModel EquipmentEffectMaster { get; set; }
		public string EffectTextForNormal { get; set; }
		public string EffectTextForBoost { get; set; }
		public int ExceedLimitItemType { get; set; }
		public EquipmentExceedLimitItemModel EquipmentExceedLimitItemMaster { get; set; }
		public int ItemType { get; set; }
		public int ModelType { get; set; }
	}

	public class EquipmentTimeModel
	{
		public int EquipmentGroupId { get; set; }
		public string FromDate { get; set; }
		public string ToDate { get; set; }
	}

	public class ErrorModel
	{
		public dynamic ErrorCode { get; set; }
		public string Message { get; set; }
		public int HandlingType { get; set; }
	}

	public class EventBoostCharacterModel
	{
		public int EventId { get; set; }
		public int EffectGroupId { get; set; }
		public int CharacterId { get; set; }
		public int SubEffectGroupId { get; set; }
	}

	public class EventBoostEffectModel
	{
		public int GroupId { get; set; }
		public int EffectType { get; set; }
		public int AddType { get; set; }
		public int ConditionType { get; set; }
		public int ConditionId { get; set; }
		public dynamic Value1 { get; set; }
		public dynamic Value2 { get; set; }
		public dynamic Value3 { get; set; }
		public dynamic Value4 { get; set; }
	}

	public class EventCharacterModel
	{
		public int EventId { get; set; }
		public int Order { get; set; }
		public int CharacterId { get; set; }
	}

	public class EventDamageRewardModel
	{
		public int EventId { get; set; }
		public int EventItemId { get; set; }
		public int ItemType { get; set; }
		public int ItemId { get; set; }
		public int Count { get; set; }
		public int Point { get; set; }
	}

	public class EventFriendshipCharacterModel
	{
		public int FriendshipGroupId { get; set; }
		public int CharacterGroupId { get; set; }
		public int CharacterId { get; set; }
		public int ItemType { get; set; }
		public int ItemId { get; set; }
	}

	public class EventFriendshipModel
	{
		public int EventId { get; set; }
		public int FriendshipGroupId { get; set; }
	}

	public class EventFriendshipRewardModel
	{
		public int FriendshipGroupId { get; set; }
		public int CharacterGroupId { get; set; }
		public int ItemType { get; set; }
		public int ItemId { get; set; }
		public int Count { get; set; }
		public int Point { get; set; }
	}

	public class EventHelpModel
	{
		public int EventId { get; set; }
		public int Order { get; set; }
		public string FileName { get; set; }
		public string DescriptionText { get; set; }
	}

	public class EventItemModel
	{
		public int EventId { get; set; }
		public int ItemType { get; set; }
		public int ItemId { get; set; }
	}

	public class EventMainModel
	{
		public int EventId { get; set; }
		public int EventType { get; set; }
		public int WorldId { get; set; }
		public int Index { get; set; }
		public string Name { get; set; }
		public string FromDate { get; set; }
		public string ToDate { get; set; }
		public int MaxUnlockCount { get; set; }
		public int ConditionType { get; set; }
		public int ConditionFrom { get; set; }
		public int ConditionTo { get; set; }
		public int GachaId { get; set; }
		public int IsNotice { get; set; }
		public int AnotherEventId { get; set; }
	}

	public class EventMemorialModel
	{
		public int MemorialId { get; set; }
		public int EventId { get; set; }
		public int IsRandom { get; set; }
		public string OtherDate { get; set; }
	}

	public class EventPointRewardModel
	{
		public int EventId { get; set; }
		public int ItemType { get; set; }
		public int ItemId { get; set; }
		public int Count { get; set; }
		public int Point { get; set; }
	}

	public class EventRewardRarityModel
	{
		public int TargetId { get; set; }
		public int RewardType { get; set; }
		public string ConditionValue { get; set; }
		public int ItemId { get; set; }
		public int ExceedLimit { get; set; }
	}

	public class EventSeasonModel
	{
		public int EventId { get; set; }
		public int TargetType { get; set; }
		public int Value { get; set; }
		public string FromDate { get; set; }
		public string ToDate { get; set; }
	}

	public class EventStoryLinkModel
	{
		public int EventId { get; set; }
		public int TransitionEventId { get; set; }
		public string InductionText { get; set; }
	}

	public class ExCharacterAbilityEffectModel
	{
		public int AbilityId { get; set; }
		public int Index { get; set; }
		public int OccurrenceRate { get; set; }
		public int EffectConditionType { get; set; }
		public int Level { get; set; }
		public int SuccessRate { get; set; }
		public string Text { get; set; }
		public string ShortText { get; set; }
		public int EffectLimit { get; set; }
		public string EffectConditionValue { get; set; }
		public int TargetType { get; set; }
		public int EffectValue { get; set; }
		public int ActionType { get; set; }
		public string EndValue { get; set; }
		public int EffectType { get; set; }
		public int EndType { get; set; }
		public string TargetValue { get; set; }
		public dynamic AbilityMainMaster { get; set; }
	}

	public class ExCharacterAbilityGroupModel
	{
		public int AbilityGroupId { get; set; }
		public int Index { get; set; }
		public int AbilityId { get; set; }
		public dynamic AbilityMainMaster { get; set; }
	}

	public class ExCharacterAbilityMainModel
	{
		public int AbilityId { get; set; }
		public int AddAbilityId { get; set; }
		public string Name { get; set; }
		public int TriggerType { get; set; }
		public string TriggerValue { get; set; }
		public int InvokeLimitCount { get; set; }
		public int AbilityFortifyType { get; set; }
		public Dictionary<string, dynamic> ConditionMasterMap { get; set; }
		public List<dynamic> AbilityConditionMasterArray { get; set; }
		public Dictionary<string, dynamic> AbilityEffectMasterMap { get; set; }
		public List<dynamic> AbilityEffectMasterArray { get; set; }
		public List<dynamic> AddAbilityIdArray { get; set; }
		public List<dynamic> AddAbilityMainMasterArray { get; set; }
		public List<dynamic> AbilityUpMasterArray { get; set; }
		public int MaxAbilityLevel { get; set; }
		public Dictionary<string, dynamic> SingleAbilityEffectMasterMap { get; set; }
		public List<dynamic> SingleAbilityEffectMasterArray { get; set; }
	}

	public class ExCharacterAwakeConditionModel
	{
		public int AwakeId { get; set; }
		public int Index { get; set; }
		public int ConditionType { get; set; }
		public string ConditionValue { get; set; }
		public string ConditionText { get; set; }
	}

	public class ExCharacterAwakeEffectModel
	{
		public int AwakeId { get; set; }
		public int Index { get; set; }
		public string Text { get; set; }
		public int AwakeType { get; set; }
		public int TargetIndex { get; set; }
		public int EffectIndex { get; set; }
		public string EffectColumn { get; set; }
		public int Value { get; set; }
		public string EffectText { get; set; }
	}

	public class ExCharacterAwakeGroupModel
	{
		public int AwakeGroupId { get; set; }
		public int CharacterId { get; set; }
		public int EquipmentId { get; set; }
		public List<dynamic> AwakeMainMasterArray { get; set; }
		public dynamic AwakeEquipmentMaster { get; set; }
		public dynamic MaxAddBattleParameter { get; set; }
	}

	public class ExCharacterAwakeMainModel
	{
		public int AwakeGroupId { get; set; }
		public int AwakeId { get; set; }
		public int Index { get; set; }
		public int Price { get; set; }
		public int IconType { get; set; }
		public dynamic AwakeCostItemMaster { get; set; }
		public List<dynamic> AwakeMaterialMasterArray { get; set; }
		public List<dynamic> AwakeConditionMasterArray { get; set; }
		public List<dynamic> AwakeEffectMasterArray { get; set; }
		public string AwakeCostItemName { get; set; }
		public string AwakeConditionText { get; set; }
		public string AwakeEffectText { get; set; }
		public dynamic PrimaryAwakeEffectMaster { get; set; }
		public int PrimaryAwakeType { get; set; }
	}

	public class ExCharacterAwakeMaterialModel
	{
		public int AwakeId { get; set; }
		public int Index { get; set; }
		public int MaterialType { get; set; }
		public int MaterialId { get; set; }
		public int Count { get; set; }
		public ItemMainModel ItemMainMaster { get; set; }
	}

	public class ExCharacterEvolutionEffectModel
	{
		public int EffectId { get; set; }
		public int HpRate { get; set; }
		public int AtkRate { get; set; }
		public int DefRate { get; set; }
		public int SkillId { get; set; }
		public int AbilityGroupId { get; set; }
	}

	public class ExCharacterEvolutionMainModel
	{
		public int CharacterId { get; set; }
		public int Rarity { get; set; }
		public int MaterialId { get; set; }
		public int EffectId { get; set; }
		public int SkillFortifyType { get; set; }
		public List<dynamic> MaterialMasterArray { get; set; }
		public dynamic EffectMaster { get; set; }
	}

	public class ExCharacterEvolutionMaterialModel
	{
		public int MaterialId { get; set; }
		public int ItemType { get; set; }
		public int ItemId { get; set; }
		public int Count { get; set; }
		public ItemMainModel ItemMainMaster { get; set; }
	}

	public class ExCharacterGroupModel
	{
		public int CharacterGroupId { get; set; }
		public int Order { get; set; }
		public string Name { get; set; }
		public string ShortName { get; set; }
		public string RoomName { get; set; }
		public string ReadingName { get; set; }
		public string Text { get; set; }
		public int ContentsGroupId { get; set; }
		public string FromDate { get; set; }
		public int StandHeadPositionX { get; set; }
		public int StandHeadPositionY { get; set; }
		public dynamic Union { get; set; }
	}

	public class ExCharacterMainModel
	{
		public int CharacterGroupId { get; set; }
		public int CharacterId { get; set; }
		public int ForceOriginalCharacterId { get; set; }
		public int CharacterType { get; set; }
		public string Name { get; set; }
		public string ShortName { get; set; }
		public string SkinName { get; set; }
		public string ReadingName { get; set; }
		public string Text { get; set; }
		public string ShortText { get; set; }
		public string VoiceActorName { get; set; }
		public string IllustratorName { get; set; }
		public int ContentsGroupId { get; set; }
		public int CostumeId { get; set; }
		public int Rarity { get; set; }
		public int SecondaryRarity { get; set; }
		public int Attribute { get; set; }
		public int SubAttribute { get; set; }
		public int SubAttributePower { get; set; }
		public int SkillId { get; set; }
		public int AbilityGroupId { get; set; }
		public int SupportAbilityGroupId { get; set; }
		public int NormalAttackId { get; set; }
		public string SpineDirectoryPath { get; set; }
		public string SpineName { get; set; }
		public string AtlasName { get; set; }
		public string MyPageBgFileName { get; set; }
		public int ExpType { get; set; }
		public int MaterialType { get; set; }
		public int ExceedLimitType { get; set; }
		public int MaxLevel0 { get; set; }
		public int MaxLevel1 { get; set; }
		public int MaxLevel2 { get; set; }
		public int MaxLevel3 { get; set; }
		public int MaxLevel4 { get; set; }
		public int MinHp { get; set; }
		public int MaxHp0 { get; set; }
		public int MaxHp1 { get; set; }
		public int MaxHp2 { get; set; }
		public int MaxHp3 { get; set; }
		public int MaxHp4 { get; set; }
		public int MaxAddHp { get; set; }
		public int MaxFortifyHp { get; set; }
		public int MinAtk { get; set; }
		public int MaxAtk0 { get; set; }
		public int MaxAtk1 { get; set; }
		public int MaxAtk2 { get; set; }
		public int MaxAtk3 { get; set; }
		public int MaxAtk4 { get; set; }
		public int MaxAddAtk { get; set; }
		public int MaxFortifyAtk { get; set; }
		public int MinDef { get; set; }
		public int MaxDef0 { get; set; }
		public int MaxDef1 { get; set; }
		public int MaxDef2 { get; set; }
		public int MaxDef3 { get; set; }
		public int MaxDef4 { get; set; }
		public int MaxAddDef { get; set; }
		public int MaxFortifyDef { get; set; }
		public int MinLuck { get; set; }
		public int MaxLuck0 { get; set; }
		public int MaxLuck1 { get; set; }
		public int MaxLuck2 { get; set; }
		public int MaxLuck3 { get; set; }
		public int MaxLuck4 { get; set; }
		public int MaxAddLuck { get; set; }
		public int StandPositionModel { get; set; }
		public int SpinePositionX { get; set; }
		public int SpinePositionY { get; set; }
		public int StandHeadPositionX { get; set; }
		public int StandHeadPositionY { get; set; }
		public int AtlasHeadPositionX { get; set; }
		public int AtlasHeadPositionY { get; set; }
		public string ReleaseDate { get; set; }
		public string VisibleDate { get; set; }
		public CharacterGroupModel CharacterGroupMaster { get; set; }
		public string CharacterTextMasterArray { get; set; }
		public List<CharacterContentsModel> CharacterContentsMasterArray { get; set; }
		public List<CharacterFavoriteModel> CharacterFavoriteMasterArray { get; set; }
		public dynamic CharacterCostumeMaster { get; set; }
		public int CharacterLevelMasterArray { get; set; }
		public CharacterMaterialModel CharacterMaterialMaster { get; set; }
		public List<CharacterExceedLimitModel> CharacterExceedLimitMasterArray { get; set; }
		public Dictionary<string, CharacterExceedLimitModel> CharacterExceedLimitMasterMap { get; set; }
		public CharacterSkillMainModel CharacterSkillMainMaster { get; set; }
		public List<CharacterAbilityGroupModel> CharacterAbilityGroupMasterArray { get; set; }
		public CharacterNormalAttackModel CharacterNormalAttackMaster { get; set; }
		public CharacterAwakeGroupModel CharacterAwakeGroupMaster { get; set; }
		public List<CharacterEvolutionMainModel> CharacterEvolutionMainMasterArray { get; set; }
		public dynamic MaxCharacterEvolutionMainMaster { get; set; }
		public int MaxRarity { get; set; }
		public int MaxSkillId { get; set; }
		public int MaxAbilityGroupId { get; set; }
		public dynamic MaxCharacterSkillMainMaster { get; set; }
		public List<dynamic> MaxCharacterAbilityGroupMasterArray { get; set; }
		public List<dynamic> MaxAwakeEffectMasterArray { get; set; }
		public dynamic MaxUserSkillMain { get; set; }
		public dynamic MaxIncludeAwakeUserSkillMain { get; set; }
		public List<dynamic> MaxUserAbilityMainArray { get; set; }
		public List<dynamic> MaxIncludeAwakeUserAbilityMainArray { get; set; }
		public dynamic AlterMaster { get; set; }
		public List<dynamic> UserDataArray { get; set; }
		public int CurrentMaxRarity { get; set; }
	}

	public class ExCharacterSkillMainModel
	{
		public int SkillId { get; set; }
		public string Name { get; set; }
		public int EffectShowType { get; set; }
		public string SpineDirectoryPath { get; set; }
		public string SpineName { get; set; }
		public string AniName { get; set; }
		public string HitEffectName { get; set; }
		public string HitEffectAniName { get; set; }
		public double BgmVolumeAmount { get; set; }
		public int SkillFortifyType { get; set; }
		public Dictionary<string, dynamic> SkillEffectMasterMap { get; set; }
		public List<dynamic> SkillEffectMasterArray { get; set; }
		public List<dynamic> SkillUpMasterArray { get; set; }
		public int MaxSkillLevel { get; set; }
	}

	public class ExEquipmentMainModel
	{
		public int EquipmentGroupId { get; set; }
		public int EquipmentId { get; set; }
		public int Attribute { get; set; }
		public int EquipmentType { get; set; }
		public int Rarity { get; set; }
		public int ResourceId { get; set; }
		public string Name { get; set; }
		public string PostName { get; set; }
		public string Text { get; set; }
		public int UniqueType { get; set; }
		public string UniqueId { get; set; }
		public int ExceedLimitType { get; set; }
		public int ExceedLimitItemType { get; set; }
		public int MaterialType { get; set; }
		public int SkillId { get; set; }
		public int MaxLevel1 { get; set; }
		public int MaxLevel2 { get; set; }
		public int MaxLevel3 { get; set; }
		public int MaxLevel4 { get; set; }
		public int MinHp1 { get; set; }
		public int MinHp2 { get; set; }
		public int MinHp3 { get; set; }
		public int MinHp4 { get; set; }
		public int MaxHp1 { get; set; }
		public int MaxHp2 { get; set; }
		public int MaxHp3 { get; set; }
		public int MaxHp4 { get; set; }
		public int MinAtk1 { get; set; }
		public int MinAtk2 { get; set; }
		public int MinAtk3 { get; set; }
		public int MinAtk4 { get; set; }
		public int MaxAtk1 { get; set; }
		public int MaxAtk2 { get; set; }
		public int MaxAtk3 { get; set; }
		public int MaxAtk4 { get; set; }
		public int MinDef1 { get; set; }
		public int MinDef3 { get; set; }
		public int MaxDef1 { get; set; }
		public int MinDef2 { get; set; }
		public int MinDef4 { get; set; }
		public int MaxDef2 { get; set; }
		public int MaxDef3 { get; set; }
		public int MaxDef4 { get; set; }
		public int TriggerType { get; set; }
		public string TriggerValue { get; set; }
		public int InvokeLimitCount { get; set; }
		public dynamic AbilityConditionMaster { get; set; }
		public EquipmentTimeModel EquipmentTimeMaster { get; set; }
		public List<EquipmentEffectModel> EquipmentEffectMasterArray { get; set; }
		public Dictionary<string, EquipmentEffectModel> EquipmentEffectMasterMap { get; set; }
		public Dictionary<string, dynamic> EquipmentEffectInfoMap { get; set; }
		public bool IsRangeOfDate { get; set; }
	}

	public class ExEventFriendshipCharacterModel
	{
		public int FriendshipGroupId { get; set; }
		public int CharacterGroupId { get; set; }
		public int CharacterId { get; set; }
		public int ItemType { get; set; }
		public int ItemId { get; set; }
		public List<dynamic> RewardMasterArray { get; set; }
		public int MaxFriendshipCount { get; set; }
	}

	public class ExEventFriendshipModel
	{
		public int EventId { get; set; }
		public int FriendshipGroupId { get; set; }
		public List<CharacterModel> CharacterMasterArray { get; set; }
	}

	public class ExEventMainModel
	{
		public int EventId { get; set; }
		public int EventType { get; set; }
		public int WorldId { get; set; }
		public int Index { get; set; }
		public string Name { get; set; }
		public string FromDate { get; set; }
		public string ToDate { get; set; }
		public int MaxUnlockCount { get; set; }
		public int ConditionType { get; set; }
		public int ConditionFrom { get; set; }
		public int ConditionTo { get; set; }
		public int GachaId { get; set; }
		public int IsNotice { get; set; }
		public int AnotherEventId { get; set; }
		public dynamic WorldMaster { get; set; }
		public string QuestToDate { get; set; }
		public string CurrentToDate { get; set; }
	}

	public class ExEventMemorialModel
	{
		public int MemorialId { get; set; }
		public int EventId { get; set; }
		public int IsRandom { get; set; }
		public string OtherDate { get; set; }
		public EventMainModel EventMainMaster { get; set; }
	}

	public class ExExchangeItemDetailModel
	{
		public int ExchangeId { get; set; }
		public int ListId { get; set; }
		public int Order { get; set; }
		public string Name { get; set; }
		public string Text { get; set; }
		public int MaxCount { get; set; }
		public int MaxCountType { get; set; }
		public int IsLimited { get; set; }
		public string FromDate { get; set; }
		public string ToDate { get; set; }
		public int ItemType { get; set; }
		public int ItemId { get; set; }
		public int Count { get; set; }
		public int CostType1 { get; set; }
		public int CostId1 { get; set; }
		public int CostCount1 { get; set; }
		public int CostType2 { get; set; }
		public int CostId2 { get; set; }
		public int CostCount2 { get; set; }
		public int CostType3 { get; set; }
		public int CostId3 { get; set; }
		public int CostCount3 { get; set; }
		public int CostType4 { get; set; }
		public int CostId4 { get; set; }
		public int CostCount4 { get; set; }
		public int CostType5 { get; set; }
		public int CostId5 { get; set; }
		public int CostCount5 { get; set; }
		public ExchangeMainModel ExchangeMainMaster { get; set; }
	}

	public class ExExchangeMainModel
	{
		public int ExchangeId { get; set; }
		public int ExchangeGroupId { get; set; }
		public int Order { get; set; }
		public int ExchangeType { get; set; }
		public string Name { get; set; }
		public string FromDate { get; set; }
		public string ToDate { get; set; }
		public int CostType { get; set; }
		public int CostId { get; set; }
		public string TabIconResourceId { get; set; }
		public int EventId { get; set; }
		public PvPMainModel PvPMainMaster { get; set; }
		public int PvPExchangeId { get; set; }
	}

	public class ExExchangePointDetailModel
	{
		public int ExchangeId { get; set; }
		public int ListId { get; set; }
		public int Order { get; set; }
		public string Name { get; set; }
		public string Text { get; set; }
		public int CostCount { get; set; }
		public int MaxCount { get; set; }
		public int MaxCountType { get; set; }
		public int IsLimited { get; set; }
		public string FromDate { get; set; }
		public string ToDate { get; set; }
		public int IsToDateDisplayFlg { get; set; }
		public int ItemType { get; set; }
		public int ItemId { get; set; }
		public int Count { get; set; }
		public ExchangeMainModel ExchangeMainMaster { get; set; }
		public int CostType { get; set; }
		public int CostId { get; set; }
	}

	public class ExFurnitureMainModel
	{
		public int FurnitureId { get; set; }
		public int FurnitureCategory { get; set; }
		public int FurnitureType { get; set; }
		public int MapCategory { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public int EventId { get; set; }
		public string FurnitureAnimation { get; set; }
		public string CharacterAnimation { get; set; }
		public int MaxLimitCount { get; set; }
		public string FromDate { get; set; }
		public string ToDate { get; set; }
		public int SizeX { get; set; }
		public int SizeY { get; set; }
		public int SizeZ { get; set; }
		public int MaxCount { get; set; }
		public string SpineName { get; set; }
		public double AnchorX { get; set; }
		public int AnchorY { get; set; }
		public int AnimationPositionX { get; set; }
		public int AnimationPositionY { get; set; }
		public FurnitureCostModel FurnitureCostMaster { get; set; }
		public bool IsFurnitureShopLineup { get; set; }
	}

	public class ExItemMainModel
	{
		public int ItemId { get; set; }
		public int ResourceId { get; set; }
		public List<ItemCategoryModel> ItemCategory { get; set; }
		public int ItemType { get; set; }
		public string CountSuffix { get; set; }
		public string Name { get; set; }
		public string Text { get; set; }
		public int SalePrice { get; set; }
		public int EffectValue { get; set; }
		public int EffectTime { get; set; }
		public int Rarity { get; set; }
		public int Attribute { get; set; }
		public string FromDate { get; set; }
		public string ToDate { get; set; }
		public ItemSellBonusModel ItemSellBonusMaster { get; set; }
		public dynamic BonusSellItemMainMaster { get; set; }
		public dynamic DefaultSellItemMainMaster { get; set; }
		public dynamic PrimarySellItemMainMaster { get; set; }
		public int PrimarySellPrice { get; set; }
		public string ShortName { get; set; }
		public bool IsExpired { get; set; }
		public dynamic ExistsSaleItem { get; set; }
	}

	public class ExLinearMissionDetailModel
	{
		public int MissionGroupId { get; set; }
		public int Step { get; set; }
		public int RewardPoint { get; set; }
		public int MissionType { get; set; }
		public string Name { get; set; }
		public string Text { get; set; }
		public int ConditionCount { get; set; }
		public string ConditionRarity { get; set; }
		public string ConditionAttribute { get; set; }
		public int ConditionId { get; set; }
	}

	public class ExLinearMissionMainModel
	{
		public int MissionGroupId { get; set; }
		public int CycleType { get; set; }
		public int RewardPointLimit { get; set; }
		public string FromDate { get; set; }
		public string ToDate { get; set; }
		public string CycleText { get; set; }
		public List<LinearMissionDetailModel> LinearMissionDetailMasterArray { get; set; }
		public Dictionary<string, LinearMissionDetailModel> LinearMissionDetailMasterMap { get; set; }
		public List<LinearMissionRewardModel> LinearMissionRewardMasterArray { get; set; }
		public Dictionary<string, LinearMissionRewardModel> LinearMissionRewardMasterMap { get; set; }
	}

	public class ExLinearMissionRewardModel
	{
		public int MissionGroupId { get; set; }
		public int RewardPoint { get; set; }
		public int ItemType { get; set; }
		public int ItemId { get; set; }
		public int Count { get; set; }
		public ItemMainModel ItemMainMaster { get; set; }
		public string ItemName { get; set; }
	}

	public class ExMemorialAbilityGroupModel
	{
		public int AbilityGroupId { get; set; }
		public int Index { get; set; }
		public int AbilityId { get; set; }
		public dynamic AbilityMainMaster { get; set; }
	}

	public class ExMemorialAbilityMainModel
	{
		public int AbilityId { get; set; }
		public int AddAbilityId { get; set; }
		public string Name { get; set; }
		public int TriggerType { get; set; }
		public string TriggerValue { get; set; }
		public int InvokeLimitCount { get; set; }
		public Dictionary<string, dynamic> ConditionMasterMap { get; set; }
		public List<dynamic> AbilityConditionMasterArray { get; set; }
		public Dictionary<string, dynamic> AbilityEffectMasterMap { get; set; }
		public List<dynamic> AbilityEffectMasterArray { get; set; }
		public List<dynamic> AddAbilityMainMasterArray { get; set; }
	}

	public class ExMemorialMainModel
	{
		public int MemorialId { get; set; }
		public string Name { get; set; }
		public int UnisonType { get; set; }
		public int BoostGroup1 { get; set; }
		public int BoostGroup2 { get; set; }
		public int StatusId { get; set; }
		public int LevelType { get; set; }
		public int ExceedLimitType { get; set; }
		public string VoiceActorNames { get; set; }
		public string IllustratorName { get; set; }
		public string Description { get; set; }
		public bool IsCollaboration { get; set; }
		public int MemorialFilterType { get; set; }
		public Dictionary<string, MemorialStatusModel> MemorialStatusMasterMap { get; set; }
		public int BaseRarity { get; set; }
		public int MaxRarity { get; set; }
		public int MemorialLevelMasterArray { get; set; }
		public int MemorialLevelMasterMap { get; set; }
		public int MaxLevel { get; set; }
		public List<MemorialExceedLimitModel> MemorialExceedLimitMasterArray { get; set; }
		public List<MemorialAbilityGroupModel> MemorialAbilityGroupMasterArray { get; set; }
		public string MemorialTextMasterArray { get; set; }
	}

	public class ExMissionMainModel
	{
		public int MissionGroupId { get; set; }
		public int Category { get; set; }
		public int Index { get; set; }
		public string FromDate { get; set; }
		public string ToDate { get; set; }
		public int EventId { get; set; }
		public string MissionName { get; set; }
		public EventMainModel EventMainMaster { get; set; }
		public bool IsRangeOfDate { get; set; }
		public bool IsCommonMission { get; set; }
		public bool IsProgressingMission { get; set; }
		public MissionDetailModel MissionDetailMaster { get; set; }
		public string Name { get; set; }
		public string MissionTabName { get; set; }
	}

	public class ExMyPageNewsModel
	{
		public int NewsId { get; set; }
		public int AdultType { get; set; }
		public int Order { get; set; }
		public string Name { get; set; }
		public int BandId { get; set; }
		public string Text { get; set; }
		public string DateFrom { get; set; }
		public string DateTo { get; set; }
		public int ConditionType { get; set; }
		public int ConditionFrom { get; set; }
		public int ConditionTo { get; set; }
		public dynamic ComebackCampaignIds { get; set; }
	}

	public class ExMyPagePopupModel
	{
		public int PopupId { get; set; }
		public int RepeatType { get; set; }
		public string DateFrom { get; set; }
		public string DateTo { get; set; }
		public int Order { get; set; }
		public string Title { get; set; }
		public string FileName { get; set; }
		public string Description { get; set; }
		public int TransitionId { get; set; }
		public int TransitionParam1 { get; set; }
		public int TransitionParam2 { get; set; }
		public int TransitionParam3 { get; set; }
		public dynamic ComebackCampaignIds { get; set; }
	}

	public class ExQuestAreaModel
	{
		public int WorldId { get; set; }
		public int AreaId { get; set; }
		public int Index { get; set; }
		public string Name { get; set; }
		public string FromDate { get; set; }
		public string ToDate { get; set; }
		public string StartTime { get; set; }
		public string EndTime { get; set; }
		public string Text { get; set; }
		public string ImageName { get; set; }
		public int RewardItemType { get; set; }
		public int RewardItemId { get; set; }
		public int RewardItemCount { get; set; }
		public string WeekTypes { get; set; }
		public int Difficult { get; set; }
		public int MaxBattleCount { get; set; }
		public int CampaignCount { get; set; }
		public int MaxBattleCountWithBoost { get; set; }
		public int BattlePlayCount { get; set; }
		public int MaxBattlePlayCount { get; set; }
		public int BattleDisplayCount { get; set; }
		public bool CanPlayQuest { get; set; }
		public dynamic WorldMaster { get; set; }
		public int Category { get; set; }
		public List<dynamic> TargetStoryMasterArray { get; set; }
		public List<dynamic> StageMasterArray { get; set; }
		public Dictionary<string, dynamic> StageMasterMap { get; set; }
		public List<StoryModel> StoryMasterArray { get; set; }
		public List<dynamic> AvailableStoryMasterArray { get; set; }
	}

	public class ExQuestScenarioModel
	{
		public int WorldId { get; set; }
		public int ScenarioNum { get; set; }
	}

	public class ExQuestStageConditionModel
	{
		public int StageId { get; set; }
		public int ConditionType { get; set; }
		public int ConditionId { get; set; }
		public string ConditionValue { get; set; }
	}

	public class ExQuestStageModel
	{
		public int WorldId { get; set; }
		public int AreaId { get; set; }
		public int StageId { get; set; }
		public int ReleaseStageId { get; set; }
		public string Name { get; set; }
		public string Text { get; set; }
		public int RecommendPower { get; set; }
		public int Stamina { get; set; }
		public int MaxBattleCount { get; set; }
		public int SkipItemId { get; set; }
		public int MaxSkipCount { get; set; }
		public int MaxClearCount { get; set; }
		public int UserExpFrom { get; set; }
		public int UserExpTo { get; set; }
		public int CharacterExpFrom { get; set; }
		public int CharacterExpTo { get; set; }
		public int GoldFrom { get; set; }
		public int GoldTo { get; set; }
		public int AchieveId1 { get; set; }
		public int AchieveId2 { get; set; }
		public int AchieveId3 { get; set; }
		public int RewardItemType { get; set; }
		public int RewardItemId { get; set; }
		public int RewardItemCount { get; set; }
		public int DefaultSkillGaugeRate { get; set; }
		public string Background { get; set; }
		public string NormalWaveBgm { get; set; }
		public string BossWaveBgm { get; set; }
		public dynamic UserData { get; set; }
		public dynamic AreaMaster { get; set; }
		public int Difficult { get; set; }
		public string FromDate { get; set; }
		public string ToDate { get; set; }
		public bool IsClear { get; set; }
		public bool IsExistStartStory { get; set; }
		public dynamic StartUserStory { get; set; }
		public dynamic SkipItemMaster { get; set; }
		public int SkipItemType { get; set; }
	}

	public class ExQuestWorldModel
	{
		public int WorldId { get; set; }
		public int Category { get; set; }
		public string Name { get; set; }
		public string ImageName { get; set; }
		public int MaxBattleCount { get; set; }
		public int RewardItemType { get; set; }
		public int RewardItemId { get; set; }
		public int RewardItemCount { get; set; }
		public string FromDate { get; set; }
		public string ToDate { get; set; }
		public int MaxBattleCountWithBoost { get; set; }
		public int BattlePlayCount { get; set; }
		public int MaxBattlePlayCount { get; set; }
		public int BattleDisplayCount { get; set; }
		public bool CanPlayQuest { get; set; }
		public List<dynamic> AreaMasterArray { get; set; }
		public Dictionary<string, dynamic> AreaMasterMap { get; set; }
		public bool IsRangeOfDate { get; set; }
	}

	public class ExRaceAbilityEffectGroupModel
	{
		public int EffectGroupId { get; set; }
		public int Order { get; set; }
		public int EffectId { get; set; }
		public dynamic EffectMaster { get; set; }
	}

	public class ExRaceAbilityEffectModel
	{
		public int EffectId { get; set; }
		public int EffectTiming { get; set; }
		public int Rate { get; set; }
		public int TargetType { get; set; }
		public int EffectType { get; set; }
		public int EffectValue { get; set; }
		public int EffectValueType { get; set; }
		public string Text { get; set; }
		public dynamic EffectTimingMaster { get; set; }
		public dynamic EffectTargetMaster { get; set; }
		public dynamic EffectTypeMaster { get; set; }
		public dynamic EffectValueTypeMaster { get; set; }
		public string DisplayRateText { get; set; }
		public string DisplayEffectValueText { get; set; }
		public string DisplayText { get; set; }
		public int EffectValueWithType { get; set; }
		public string SimpleEffectText { get; set; }
	}

	public class ExRaceAbilityGroupModel
	{
		public int AbilityGroupId { get; set; }
		public int Category { get; set; }
		public int Order { get; set; }
		public int AbilityId { get; set; }
		public dynamic AbilityMainMaster { get; set; }
	}

	public class ExRaceAbilityMainModel
	{
		public int AbilityId { get; set; }
		public int EffectGroupId { get; set; }
		public int ConditionType { get; set; }
		public string ConditionValue { get; set; }
		public List<dynamic> EffectGroupMasterArray { get; set; }
		public Dictionary<string, dynamic> EffectGroupMasterMap { get; set; }
		public string AbilityText { get; set; }
	}

	public class ExRaceAreaModel
	{
		public int Season { get; set; }
		public int AreaId { get; set; }
		public string WeekTypes { get; set; }
		public int StageGroupId { get; set; }
		public string Description { get; set; }
		public List<RaceStageModel> RaceStageMasterArray { get; set; }
		public Dictionary<string, RaceStageModel> RaceStageMasterMap { get; set; }
	}

	public class ExRaceCharacterMainModel
	{
		public int CharacterId { get; set; }
		public int MinStatusId { get; set; }
		public int MaxStatusId { get; set; }
		public int FortifyType { get; set; }
		public int AbilityGroupId { get; set; }
		public int TextGroupId { get; set; }
		public int BoostType { get; set; }
		public int RacingNumber { get; set; }
		public int MaxPlayCount { get; set; }
		public CharacterMainModel CharacterMainMaster { get; set; }
		public RaceCharacterFreeModel RaceCharacterFreeMaster { get; set; }
		public dynamic MinRaceStatusMaster { get; set; }
		public dynamic MaxRaceStatusMaster { get; set; }
		public dynamic MaxRaceFortifyMaster { get; set; }
		public List<dynamic> AbilityGroupMasterArray { get; set; }
		public Dictionary<string, dynamic> AbilityGroupMasterMap { get; set; }
		public Dictionary<string, dynamic> AbilityEffectMasterMap { get; set; }
		public string TextMasterArray { get; set; }
		public string TextMasterMap { get; set; }
		public string TopTextMasterArray { get; set; }
		public ShopDetailModel ShopDetailMaster { get; set; }
		public dynamic CostItemMainMaster { get; set; }
		public int CostItemType { get; set; }
		public int CostItemId { get; set; }
		public string CostItemName { get; set; }
		public dynamic UserData { get; set; }
		public bool IsFreeReceivable { get; set; }
		public bool IsBaseCharacter { get; set; }
	}

	public class ExRaceCommentaryTextModel
	{
		public int SituationId { get; set; }
		public int TrapId { get; set; }
		public string Text { get; set; }
		public string DisplayText { get; set; }
	}

	public class ExRaceMainModel
	{
		public int Season { get; set; }
		public int MaxPlayCount { get; set; }
		public string RecoveryTime { get; set; }
		public int RecoveryCount { get; set; }
		public int CarryOverRate { get; set; }
		public string Name { get; set; }
		public string BgFileName { get; set; }
		public string FromDate { get; set; }
		public string ToDate { get; set; }
		public List<RaceAreaModel> RaceAreaMasterArray { get; set; }
		public Dictionary<string, RaceAreaModel> RaceAreaMasterMap { get; set; }
		public dynamic PlayableAreaMaster { get; set; }
		public List<dynamic> StaminaRecoveryTimeArray { get; set; }
		public bool IsRangeOfDate { get; set; }
	}

	public class ExRaceObstacleModel
	{
		public int ObstacleId { get; set; }
		public int ExamValue { get; set; }
		public int Obstacle1 { get; set; }
		public int Obstacle2 { get; set; }
		public int Obstacle3 { get; set; }
		public int Obstacle4 { get; set; }
		public dynamic ObstacleMaxWeight { get; set; }
		public dynamic ObstacleWeight1 { get; set; }
		public dynamic ObstacleWeight2 { get; set; }
		public dynamic ObstacleWeight3 { get; set; }
		public dynamic ObstacleWeight4 { get; set; }
		public dynamic ObstacleExamValue1 { get; set; }
		public dynamic ObstacleExamValue2 { get; set; }
		public dynamic ObstacleExamValue3 { get; set; }
		public dynamic ObstacleExamValue4 { get; set; }
		public int ObstacleCount1 { get; set; }
		public int ObstacleCount2 { get; set; }
		public int ObstacleCount3 { get; set; }
		public int ObstacleCount4 { get; set; }
	}

	public class ExRaceRewardModel
	{
		public int RewardId { get; set; }
		public int Order { get; set; }
		public int ItemType { get; set; }
		public int ItemId { get; set; }
		public int Count { get; set; }
		public ItemMainModel ItemMainMaster { get; set; }
	}

	public class ExRaceStageModel
	{
		public int StageGroupId { get; set; }
		public int Rank { get; set; }
		public string Name { get; set; }
		public int MemberCount { get; set; }
		public int ObstacleId { get; set; }
		public int AbilityGroupId { get; set; }
		public int FirstRewardId { get; set; }
		public int WinRewardId { get; set; }
		public int LoseRewardId { get; set; }
		public dynamic ObstacleMaster { get; set; }
		public List<dynamic> AbilityGroupMasterArray { get; set; }
		public Dictionary<string, dynamic> AbilityGroupMasterMap { get; set; }
		public Dictionary<string, dynamic> AbilityEffectMasterMap { get; set; }
		public List<dynamic> FirstRewardMasterArray { get; set; }
		public List<dynamic> WinRewardMasterArray { get; set; }
		public List<dynamic> LoseRewardMasterArray { get; set; }
	}

	public class ExRaceTextModel
	{
		public int TextGroupId { get; set; }
		public int TextType { get; set; }
		public string Text { get; set; }
		public string DisplayText { get; set; }
	}

	public class ExShopDetailModel
	{
		public int ShopId { get; set; }
		public int ListId { get; set; }
		public int Order { get; set; }
		public string Name { get; set; }
		public string Text { get; set; }
		public int CostType { get; set; }
		public int CostId { get; set; }
		public int CostCount { get; set; }
		public int MaxCount { get; set; }
		public int ResetType { get; set; }
		public int ReplenishmentDays { get; set; }
		public string FromDate { get; set; }
		public string ToDate { get; set; }
		public int ItemType { get; set; }
		public int ItemId { get; set; }
		public int Count { get; set; }
		public int NormalBonus { get; set; }
		public int FirstBonus { get; set; }
		public string IconName { get; set; }
		public int SkuId { get; set; }
		public string WeekTypes { get; set; }
		public int LabelType { get; set; }
		public int ListGroupId { get; set; }
		public int PreListId { get; set; }
		public int MissionId { get; set; }
		public ShopMainModel ShopMainMaster { get; set; }
		public bool IsRangeOfDate { get; set; }
		public List<ShopOrderPackModel> ShopOrderPackMasterArray { get; set; }
		public dynamic ComebackCampaignIds { get; set; }
	}

	public class ExSoundMainModel
	{
		public int SoundId { get; set; }
		public int Type { get; set; }
		public string Title { get; set; }
		public string FileName { get; set; }
		public bool IsSettingToHomeBGM { get; set; }
		public bool IsPlayable { get; set; }
		public int CostItemType { get; set; }
		public int CostItemId { get; set; }
		public string CostItemName { get; set; }
		public int CostItemCount { get; set; }
		public int ItemType { get; set; }
		public bool IsAvailable { get; set; }
		public ShopDetailModel ShopDetailMaster { get; set; }
		public dynamic CostItemMainMaster { get; set; }
		public UserSoundModel UserSoundModel { get; set; }
	}

	public class ExStoryCabinModel
	{
		public int StoryGroupId { get; set; }
		public int StoryId { get; set; }
		public int ResourceId { get; set; }
		public string Name { get; set; }
	}

	public class ExStoryCategoryModel
	{
		public string Name { get; set; }
		public int StoryCategory { get; set; }
		public List<StoryGroupModel> StoryGroupMasterArray { get; set; }
		public Dictionary<string, StoryGroupModel> StoryGroupMasterMap { get; set; }
	}

	public class ExStoryEventModel
	{
		public int StoryId { get; set; }
		public int ReleaseStoryId { get; set; }
		public int EventId { get; set; }
		public string Name { get; set; }
		public int StageId { get; set; }
		public int PlayType { get; set; }
		public int StableEventId { get; set; }
		public dynamic StageMaster { get; set; }
		public EventMainModel EventMainMaster { get; set; }
	}

	public class ExStoryGachaModel
	{
		public int StoryGroupId { get; set; }
		public int StoryId { get; set; }
		public int ResourceId { get; set; }
		public string Name { get; set; }
		public int CharacterId { get; set; }
	}

	public class ExStoryGroupModel
	{
		public string Name { get; set; }
		public int StoryCategory { get; set; }
		public int StoryGroupId { get; set; }
		public List<dynamic> StoryDetailMasterArray { get; set; }
		public List<dynamic> AvailableStoryDetailMasterArray { get; set; }
		public List<dynamic> TargetStoryDetailMasterArray { get; set; }
	}

	public class ExStoryMemorialEventOtherModel
	{
		public int StoryGroupId { get; set; }
		public int StoryId { get; set; }
		public int ResourceId { get; set; }
		public int EventId { get; set; }
		public string Name { get; set; }
		public string VisibleDate { get; set; }
		public EventMainModel EventMainMaster { get; set; }
	}

	public class ExStoryMemorialModel
	{
		public int StoryGroupId { get; set; }
		public int MemorialId { get; set; }
		public int StoryId { get; set; }
		public int ResourceId { get; set; }
		public string Name { get; set; }
	}

	public class ExStoryOtherModel
	{
		public int EventId { get; set; }
		public string Name { get; set; }
		public int StageId { get; set; }
		public int PlayType { get; set; }
		public EventMainModel EventMainMaster { get; set; }
	}

	public class ExStoryPictureBookModel
	{
		public string Name { get; set; }
		public int LightResourceId { get; set; }
		public int RewardType { get; set; }
		public int RewardId { get; set; }
		public int RewardCount { get; set; }
		public string VisibleDate { get; set; }
	}

	public class ExStoryQuestModel
	{
		public string Name { get; set; }
		public int StageId { get; set; }
		public int PlayType { get; set; }
		public dynamic StageMaster { get; set; }
	}

	public class ExStoryRoomModel
	{
		public string Name { get; set; }
		public int Condition1 { get; set; }
		public int Condition2 { get; set; }
		public int RewardType { get; set; }
		public int RewardId { get; set; }
		public int RewardCount { get; set; }
		public string VisibleDate { get; set; }
	}

	public class ExStoryTutorialModel
	{
		public string Name { get; set; }
	}

	public class ExStoryVoiceModel
	{
		public string Name { get; set; }
	}

	public class ExUniqueMissionModel
	{
		public int MissionGroupId { get; set; }
	}

	public class ExceedLimitAlternateItemModel
	{
		public int CharacterId { get; set; }
		public int AlternateItemId { get; set; }
		public int ItemId { get; set; }
	}

	public class ExchangeGroupModel
	{
		public int ExchangeGroupId { get; set; }
		public string ExchangeGroupName { get; set; }
		public string TabIconResourceId { get; set; }
		public int Order { get; set; }
	}

	public class ExchangeItemDetailModel
	{
		public int ExchangeId { get; set; }
		public int ListId { get; set; }
		public int Order { get; set; }
		public string Name { get; set; }
		public string Text { get; set; }
		public int MaxCount { get; set; }
		public int MaxCountType { get; set; }
		public int IsLimited { get; set; }
		public string FromDate { get; set; }
		public string ToDate { get; set; }
		public int ItemType { get; set; }
		public int ItemId { get; set; }
		public int Count { get; set; }
		public int CostType1 { get; set; }
		public int CostId1 { get; set; }
		public int CostCount1 { get; set; }
		public int CostType2 { get; set; }
		public int CostId2 { get; set; }
		public int CostCount2 { get; set; }
		public int CostType3 { get; set; }
		public int CostId3 { get; set; }
		public int CostCount3 { get; set; }
		public int CostType4 { get; set; }
		public int CostId4 { get; set; }
		public int CostCount4 { get; set; }
		public int CostType5 { get; set; }
		public int CostId5 { get; set; }
		public int CostCount5 { get; set; }
	}

	public class ExchangeMainModel
	{
		public int ExchangeId { get; set; }
		public int ExchangeGroupId { get; set; }
		public int Order { get; set; }
		public int ExchangeType { get; set; }
		public string Name { get; set; }
		public string FromDate { get; set; }
		public string ToDate { get; set; }
		public int CostType { get; set; }
		public int CostId { get; set; }
		public string TabIconResourceId { get; set; }
		public int EventId { get; set; }
	}

	public class ExchangePointDetailModel
	{
		public int ExchangeId { get; set; }
		public int ListId { get; set; }
		public int Order { get; set; }
		public string Name { get; set; }
		public string Text { get; set; }
		public int CostCount { get; set; }
		public int MaxCount { get; set; }
		public int MaxCountType { get; set; }
		public int IsLimited { get; set; }
		public string FromDate { get; set; }
		public string ToDate { get; set; }
		public int IsToDateDisplayFlg { get; set; }
		public int ItemType { get; set; }
		public int ItemId { get; set; }
		public int Count { get; set; }
	}

	public class FreeStoryModel
	{
		public int StoryId { get; set; }
	}

	public class FurnitureCategoryModel
	{
		public string Name { get; set; }
		public int FurnitureCategory { get; set; }
	}

	public class FurnitureCollectModel
	{
		public int ItemId { get; set; }
		public int Count { get; set; }
		public int ItemType { get; set; }
		public int CollectTime { get; set; }
		public int FurnitureId { get; set; }
		public int MaxStackCount { get; set; }
	}

	public class FurnitureCostModel
	{
		public int CostCount { get; set; }
		public int CostId { get; set; }
		public int FurnitureId { get; set; }
		public int CostType { get; set; }
	}

	public class FurnitureMainModel
	{
		public int EventId { get; set; }
		public int MapCategory { get; set; }
		public string FurnitureAnimation { get; set; }
		public double AnchorX { get; set; }
		public string Description { get; set; }
		public string CharacterAnimation { get; set; }
		public string ToDate { get; set; }
		public int MaxLimitCount { get; set; }
		public int FurnitureType { get; set; }
		public int SizeX { get; set; }
		public int SizeY { get; set; }
		public int FurnitureId { get; set; }
		public int FurnitureCategory { get; set; }
		public int AnimationPositionY { get; set; }
		public int AnimationPositionX { get; set; }
		public string FromDate { get; set; }
		public int SizeZ { get; set; }
		public int MaxCount { get; set; }
		public string SpineName { get; set; }
		public int AnchorY { get; set; }
		public string Name { get; set; }
	}

	public class FurnitureModel
	{
		public FurnitureMainModel FurnitureMainMaster { get; set; }
		public FurnitureCostModel FurnitureCostMaster { get; set; }
		public FurnitureCategoryModel FurnitureCategoryMaster { get; set; }
		public FurnitureTypeModel FurnitureTypeMaster { get; set; }
		public FurnitureCollectModel FurnitureCollectMaster { get; set; }
		public string FurnitureName { get; set; }
		public string FurnitureDescription { get; set; }
		public int FurnitureId { get; set; }
		public string FurnitureCd { get; set; }
		public int IsBuyFurniture { get; set; }
		public int Level { get; set; }
		public int FurnitureCategory { get; set; }
		public int FurnitureType { get; set; }
		public int MapCategory { get; set; }
		public int AnimationPosition { get; set; }
		public int MaxCount { get; set; }
		public dynamic FurnitureSize { get; set; }
		public double FurnitureAnchor { get; set; }
		public string FurnitureCategoryName { get; set; }
		public string FurnitureTypeName { get; set; }
		public string FurnitureAnimationName { get; set; }
		public string CharacterAnimationName { get; set; }
		public int CollectTime { get; set; }
		public int CollectCountPerStack { get; set; }
		public int MaxStackCount { get; set; }
	}

	public class FurnitureStoryModel
	{
		public int CharacterId { get; set; }
		public string Title { get; set; }
		public int FurnitureId { get; set; }
		public int StoryId { get; set; }
	}

	public class FurnitureTypeModel
	{
		public int FurnitureType { get; set; }
		public string Name { get; set; }
	}

	public class GachaCautionModel
	{
		public string Text { get; set; }
		public int CautionId { get; set; }
	}

	public class GachaContentsModel
	{
		public int Category { get; set; }
		public int CharacterId { get; set; }
		public string DetailIds { get; set; }
		public int DetailPosX { get; set; }
		public int DetailPosY { get; set; }
		public string Text { get; set; }
		public int Order { get; set; }
		public string BannerFile { get; set; }
		public int ContentsId { get; set; }
		public int Description_type { get; set; }
	}

	public class GachaDiscountModel
	{
		public int DiscountCondition { get; set; }
		public int DiscountTpe { get; set; }
		public string ButtonId { get; set; }
		public int Step { get; set; }
		public int DiscountCost { get; set; }
		public int GachaId { get; set; }
	}

	public class GachaFixGroupModel
	{
		public int FixLineupId { get; set; }
		public int FixRarity { get; set; }
		public int FixCount { get; set; }
		public int FixType { get; set; }
		public int FixGroupId { get; set; }
	}

	public class GachaLineupModel
	{
		public int Rate { get; set; }
		public int IconType { get; set; }
		public int CharacterId { get; set; }
		public int LineupId { get; set; }
	}

	public class GachaMainModel
	{
		public string ToDate { get; set; }
		public int ButtonCount { get; set; }
		public List<dynamic> ButtonList { get; set; }
		public int BannerCount { get; set; }
		public List<dynamic> BannerList { get; set; }
		public string WeekType { get; set; }
		public int ItemType { get; set; }
		public int ConditionFrom { get; set; }
		public string Text { get; set; }
		public int ConditionTo { get; set; }
		public int ConditionType { get; set; }
		public int ContentsId { get; set; }
		public int LineupButtonId { get; set; }
		public string FromDate { get; set; }
		public int GachaType { get; set; }
		public int GachaId { get; set; }
		public int CautionId { get; set; }
		public int LimitCount { get; set; }
		public int Order { get; set; }
		public string Name { get; set; }
	}

	public class GachaOddsModel
	{
		public int OddsId { get; set; }
		public dynamic Rare4 { get; set; }
		public dynamic Rare1 { get; set; }
		public dynamic Rare3 { get; set; }
		public dynamic Rare2 { get; set; }
		public dynamic Total { get; set; }
	}

	public class GachaPresentGroupModel
	{
		public int ItemId { get; set; }
		public int Rate { get; set; }
		public int PresentGroupId { get; set; }
		public int ItemCount { get; set; }
		public int ItemType { get; set; }
	}

	public class GachaStepModel
	{
		public int ItemId { get; set; }
		public int Count { get; set; }
		public int OddsId { get; set; }
		public string ButtonId { get; set; }
		public int FixGroupId { get; set; }
		public int Step { get; set; }
		public dynamic Cost { get; set; }
		public int LineupId { get; set; }
		public int GachaId { get; set; }
		public int PresentGroupId { get; set; }
	}

	public class InitCharacterModel
	{
		public int CharacterId { get; set; }
		public int ExceedLimit { get; set; }
		public int Level { get; set; }
	}

	public class InitEquipmentModel
	{
		public int EquipmentId { get; set; }
		public int Level { get; set; }
	}

	public class InitItemModel
	{
		public int ItemId { get; set; }
		public int Count { get; set; }
		public int ItemType { get; set; }
	}

	public class ItemApRecoveryGemModel
	{
		public int EffectValue { get; set; }
		public int CostCount { get; set; }
	}

	public class ItemCategoryModel
	{
		public int MaxCount { get; set; }
		public List<ItemCategoryModel> ItemCategory { get; set; }
		public string Name { get; set; }
	}

	public class ItemMainModel
	{
		public int ItemId { get; set; }
		public int ResourceId { get; set; }
		public List<ItemCategoryModel> ItemCategory { get; set; }
		public int ItemType { get; set; }
		public string CountSuffix { get; set; }
		public string Name { get; set; }
		public string Text { get; set; }
		public int SalePrice { get; set; }
		public int EffectValue { get; set; }
		public int EffectTime { get; set; }
		public int Rarity { get; set; }
		public int Attribute { get; set; }
		public string FromDate { get; set; }
		public string ToDate { get; set; }
	}

	public class ItemModel
	{
		public ItemMainModel ItemMainMaster { get; set; }
		public ItemRecipeModel ItemRecipeMaster { get; set; }
		public ItemSetModel ItemSetMaster { get; set; }
		public ItemSelectModel ItemSelectMaster { get; set; }
		public ItemSellBonusModel ItemSellBonusMaster { get; set; }
		public dynamic SellBonusItemMainMaster { get; set; }
		public int ItemId { get; set; }
		public string Name { get; set; }
		public int Count { get; set; }
		public string Text { get; set; }
		public int ItemType { get; set; }
		public List<ItemCategoryModel> ItemCategory { get; set; }
		public int SetItemId { get; set; }
		public int EffectValue { get; set; }
		public int SetId { get; set; }
		public int SelectItemId { get; set; }
		public int SalePrice { get; set; }
		public int Rarity { get; set; }
		public string FromDate { get; set; }
		public string ToDate { get; set; }
	}

	public class ItemQuestLockModel
	{
		public int ItemId { get; set; }
		public string QuestIds { get; set; }
		public int ReleaseType { get; set; }
		public int QuestType { get; set; }
	}

	public class ItemRecipeModel
	{
		public int NeedCount { get; set; }
		public int ItemId { get; set; }
		public int RecipeItemId { get; set; }
		public int ItemType { get; set; }
	}

	public class ItemSelectModel
	{
		public int ItemId { get; set; }
		public int Count { get; set; }
		public int SelectItemId { get; set; }
		public int SetId { get; set; }
		public int ItemType { get; set; }
		public int ExceedLimit { get; set; }
	}

	public class ItemSellBonusModel
	{
		public int ItemId { get; set; }
		public int Count { get; set; }
		public int BonusItemId { get; set; }
		public int BonusItemType { get; set; }
	}

	public class ItemSetModel
	{
		public int ItemId { get; set; }
		public int Count { get; set; }
		public int ExceedLimit { get; set; }
		public int ItemType { get; set; }
		public int SetItemId { get; set; }
		public int Rate { get; set; }
		public int SetId { get; set; }
	}

	public class ItemStoryReleaseModel
	{
		public int ItemId { get; set; }
		public int Count { get; set; }
		public int IsLimited { get; set; }
		public int StoryId { get; set; }
	}

	public class ItemVoteModel
	{
		public int VoteId { get; set; }
		public int VoteType { get; set; }
	}

	public class LinearMissionDetailModel
	{
		public int MissionType { get; set; }
		public int MissionGroupId { get; set; }
		public string Name { get; set; }
		public string ConditionAttribute { get; set; }
		public string Text { get; set; }
		public int ConditionId { get; set; }
		public int ConditionCount { get; set; }
		public int RewardPoint { get; set; }
		public string ConditionRarity { get; set; }
		public int Step { get; set; }
	}

	public class LinearMissionMainModel
	{
		public string ToDate { get; set; }
		public int MissionGroupId { get; set; }
		public int CycleType { get; set; }
		public string FromDate { get; set; }
		public int RewardPointLimit { get; set; }
	}

	public class LinearMissionModel
	{
		public int MissionGroupId { get; set; }
		public int Step { get; set; }
		public int ClearCount { get; set; }
		public int RewardPoint { get; set; }
		public string StartDate { get; set; }
		public string ResetDate { get; set; }
		public LinearMissionMainModel LinearMissionMainMaster { get; set; }
		public dynamic CurrentStepMissionDetailMaster { get; set; }
	}

	public class LinearMissionRewardModel
	{
		public int ItemId { get; set; }
		public int Count { get; set; }
		public int MissionGroupId { get; set; }
		public int ItemType { get; set; }
		public int RewardPoint { get; set; }
	}

	public class LoadingCharacterModel
	{
		public int CharacterId { get; set; }
		public string Serif { get; set; }
		public string Description { get; set; }
		public int MainPosX { get; set; }
		public int MainPosY { get; set; }
		public int BackPosX { get; set; }
		public int BackPosY { get; set; }
	}

	public class LoadingIllustModel
	{
		public int IllustId { get; set; }
		public string VisibleDate { get; set; }
	}

	public class LoadingMainModel
	{
		public int LoadingType { get; set; }
		public int Count { get; set; }
	}

	public class LoadingTipsModel
	{
		public string Title { get; set; }
		public string Description { get; set; }
	}

	public class LoginBonusModel
	{
		public string MessageParameter2 { get; set; }
		public string ToDate { get; set; }
		public int LoginBonusType { get; set; }
		public string Name { get; set; }
		public int LoginBonusId { get; set; }
		public string LayoutName { get; set; }
		public int IsLoop { get; set; }
		public int MaxColumn { get; set; }
		public string MessageParameter1 { get; set; }
		public string FromDate { get; set; }
		public string MessageEndParameter { get; set; }
		public int CharacterId2 { get; set; }
		public int Order { get; set; }
		public int CharacterId1 { get; set; }
		public int ResourceType { get; set; }
		public int Character1X { get; set; }
		public int Character1Y { get; set; }
		public int Character2X { get; set; }
		public int Character2Y { get; set; }
	}

	public class LoginPackMainModel
	{
		public int LoginPackId { get; set; }
		public string Name { get; set; }
		public int LoginBonusDays { get; set; }
		public int LoginPackReceiveType { get; set; }
	}

	public class LoginPackRewardModel
	{
		public int LoginPackId { get; set; }
		public int LoginCount { get; set; }
		public int ItemType { get; set; }
		public int ItemId { get; set; }
		public int ItemCount { get; set; }
	}

	public class LoginRewardModel
	{
		public int LoginBonusId { get; set; }
		public int LoginCount { get; set; }
		public int ItemType { get; set; }
		public int ItemId { get; set; }
		public int Amount { get; set; }
		public int ItemType2 { get; set; }
		public int ItemId2 { get; set; }
		public int Amount2 { get; set; }
	}

	public class LotteryModel
	{
		public int ItemId { get; set; }
		public string LotteryCd { get; set; }
		public ItemMainModel ItemMainMaster { get; set; }
		public string ItemName { get; set; }
	}

	public class MemorialAbilityConditionModel
	{
		public int AbilityId { get; set; }
		public int ConditionGroup { get; set; }
		public int ConditionType { get; set; }
		public string ConditionValue { get; set; }
	}

	public class MemorialAbilityEffectModel
	{
		public int AbilityId { get; set; }
		public int Rarity { get; set; }
		public int Index { get; set; }
		public string Text { get; set; }
		public int ActionType { get; set; }
		public int EffectType { get; set; }
		public int EffectValue { get; set; }
		public int EffectLimit { get; set; }
		public int EffectConditionType { get; set; }
		public string EffectConditionValue { get; set; }
		public int OccurrenceRate { get; set; }
		public int SuccessRate { get; set; }
		public int TargetType { get; set; }
		public string TargetValue { get; set; }
		public int EndType { get; set; }
		public string EndValue { get; set; }
	}

	public class MemorialAbilityGroupModel
	{
		public int AbilityGroupId { get; set; }
		public int Index { get; set; }
		public int AbilityId { get; set; }
	}

	public class MemorialAbilityMainModel
	{
		public int AbilityId { get; set; }
		public int AddAbilityId { get; set; }
		public string Name { get; set; }
		public int TriggerType { get; set; }
		public string TriggerValue { get; set; }
		public int InvokeLimitCount { get; set; }
	}

	public class MemorialCollaboModel
	{
		public int MemorialId { get; set; }
	}

	public class MemorialConvertModel
	{
		public int UnisonType { get; set; }
		public int Rarity { get; set; }
		public int ItemType { get; set; }
		public int ItemId { get; set; }
		public int Count { get; set; }
	}

	public class MemorialDeckModel
	{
		public int DeckId { get; set; }
		public int DeckType { get; set; }
		public int Position { get; set; }
		public int MemorialId { get; set; }
		public int RoleType { get; set; }
	}

	public class MemorialExceedLimitModel
	{
		public int ExceedLimitType { get; set; }
		public int Rarity { get; set; }
		public int MaterialType { get; set; }
		public int MaterialId { get; set; }
		public int Count { get; set; }
	}

	public class MemorialExchangeDetailModel
	{
		public int ExchangeId { get; set; }
		public int ListId { get; set; }
		public int ExceedLimit { get; set; }
	}

	public class MemorialLevelModel
	{
		public int LevelType { get; set; }
		public int Level { get; set; }
		public int MaterialType { get; set; }
		public int MaterialId { get; set; }
		public int Count { get; set; }
	}

	public class MemorialMainModel
	{
		public int MemorialId { get; set; }
		public string Name { get; set; }
		public int UnisonType { get; set; }
		public int BoostGroup1 { get; set; }
		public int BoostGroup2 { get; set; }
		public int StatusId { get; set; }
		public int LevelType { get; set; }
		public int ExceedLimitType { get; set; }
		public string VoiceActors { get; set; }
		public string Illustrator { get; set; }
		public string Description { get; set; }
	}

	public class MemorialModel
	{
		public MemorialMainModel MemorialMainMaster { get; set; }
		public int MemorialId { get; set; }
		public int Level { get; set; }
		public int ExceedLimit { get; set; }
		public string Name { get; set; }
		public int UnisonType { get; set; }
		public int StatusId { get; set; }
		public int LevelType { get; set; }
		public int MaxLevel { get; set; }
		public int MaxLevelByMaxRarity { get; set; }
		public bool IsLevelMax { get; set; }
		public int Rarity { get; set; }
		public int MaxRarity { get; set; }
		public int IsMaxRarity { get; set; }
		public int MaxHp { get; set; }
		public int MaxAtk { get; set; }
		public int MaxDef { get; set; }
		public int MinHp { get; set; }
		public int MinAtk { get; set; }
		public int MinDef { get; set; }
		public int Hp { get; set; }
		public int Atk { get; set; }
		public int Def { get; set; }
		public int BaseRarity { get; set; }
		public dynamic NeedMaterials { get; set; }
		public int ExceedLimitType { get; set; }
		public List<MemorialExceedLimitModel> MemorialExceedLimitModelArray { get; set; }
		public List<dynamic> AbilityEffectModelArray { get; set; }
		public int ItemType { get; set; }
		public string AbilityText { get; set; }
		public string AbilityShortText { get; set; }
		public int MemorialFilterType { get; set; }
	}

	public class MemorialShopDetailModel
	{
		public int ShopId { get; set; }
		public int ListId { get; set; }
		public int ExceedLimit { get; set; }
	}

	public class MemorialStatusModel
	{
		public int StatusId { get; set; }
		public int MaxLevel { get; set; }
		public int Rarity { get; set; }
		public int MinHp { get; set; }
		public int MaxHp { get; set; }
		public int MinAtk { get; set; }
		public int MaxAtk { get; set; }
		public int MinDef { get; set; }
		public int MaxDef { get; set; }
	}

	public class MemorialTextModel
	{
		public int MemorialId { get; set; }
		public string Text { get; set; }
		public string VoiceFile { get; set; }
	}

	public class MinigameCharacterMainModel
	{
		public int CharacterId { get; set; }
		public string Name { get; set; }
	}

	public class MinigameCharacterTextModel
	{
		public int TextId { get; set; }
		public int CharacterId { get; set; }
		public int RivalCharacterId { get; set; }
		public int Index { get; set; }
		public string Text { get; set; }
	}

	public class MinigameMainModel
	{
		public dynamic LoseAmount { get; set; }
		public int ItemType { get; set; }
		public int ItemId { get; set; }
		public string RecoveryTime { get; set; }
		public dynamic WinAmount { get; set; }
	}

	public class MissionDetailModel
	{
		public int MissionType { get; set; }
		public int MissionGroupId { get; set; }
		public string Name { get; set; }
		public int MissionId { get; set; }
		public int ReleaseMissionId { get; set; }
		public string Text { get; set; }
		public int ConditionCount { get; set; }
		public int ConditionId { get; set; }
	}

	public class MissionMainModel
	{
		public int Category { get; set; }
		public int Index { get; set; }
		public int MissionGroupId { get; set; }
		public string ToDate { get; set; }
		public string FromDate { get; set; }
		public int EventId { get; set; }
		public string MissionName { get; set; }
	}

	public class MissionModel
	{
		public dynamic MissionMainMater { get; set; }
		public MissionDetailModel MissionDetailMaster { get; set; }
		public dynamic MissionRewardMater { get; set; }
		public bool IsSelectMissionReward { get; set; }
		public dynamic ReleaseMissionModel { get; set; }
		public dynamic EventMainMater { get; set; }
		public int ClearCount { get; set; }
		public int Category { get; set; }
		public int Index { get; set; }
		public string FromDate { get; set; }
		public string ToDate { get; set; }
		public int MissionId { get; set; }
		public int MissionGroupId { get; set; }
		public string MissionCd { get; set; }
		public string Name { get; set; }
		public string Text { get; set; }
		public int Count { get; set; }
		public int ItemId { get; set; }
		public int ItemType { get; set; }
		public int ReceiveCount { get; set; }
		public int MissionType { get; set; }
		public int ReleaseMissionId { get; set; }
		public int ConditionCount { get; set; }
		public int ConditionId { get; set; }
		public bool IsReceivable { get; set; }
		public bool IsCompleted { get; set; }
		public bool IsReceived { get; set; }
		public bool IsReleased { get; set; }
	}

	public class MissionRewardModel
	{
		public int Count { get; set; }
		public int ItemType { get; set; }
		public int MissionId { get; set; }
		public int ItemId { get; set; }
		public int Order { get; set; }
		public int RewardGroup { get; set; }
	}

	public class MyPageBannerModel
	{
		public int TransitionParam1 { get; set; }
		public int TransitionParam2 { get; set; }
		public int TransitionParam3 { get; set; }
		public string DateTo { get; set; }
		public string DateFrom { get; set; }
		public string FileName { get; set; }
		public int TransitionId { get; set; }
		public int BannerId { get; set; }
		public int Order { get; set; }
	}

	public class MyPageEventModel
	{
		public string DateTo { get; set; }
		public string DateFrom { get; set; }
		public string Bgm { get; set; }
		public string Background { get; set; }
	}

	public class MyPageMainModel
	{
		public int StageIdTo { get; set; }
		public string Background { get; set; }
		public int StageIdFrom { get; set; }
		public string Bgm { get; set; }
	}

	public class MyPageNewsModel
	{
		public int NewsId { get; set; }
		public int AdultType { get; set; }
		public int Order { get; set; }
		public string Name { get; set; }
		public int BandId { get; set; }
		public string Text { get; set; }
		public string DateFrom { get; set; }
		public string DateTo { get; set; }
		public int ConditionType { get; set; }
		public int ConditionFrom { get; set; }
		public int ConditionTo { get; set; }
	}

	public class MyPagePopupModel
	{
		public int PopupId { get; set; }
		public int RepeatType { get; set; }
		public string DateFrom { get; set; }
		public string DateTo { get; set; }
		public int Order { get; set; }
		public string Title { get; set; }
		public string FileName { get; set; }
		public string Description { get; set; }
		public int TransitionId { get; set; }
		public int TransitionParam1 { get; set; }
		public int TransitionParam2 { get; set; }
		public int TransitionParam3 { get; set; }
	}

	public class OrderPackModel
	{
		public int ShopId { get; set; }
		public int ListId { get; set; }
		public int BoxNo { get; set; }
		public int SelectIndex { get; set; }
		public string SelectDate { get; set; }
		public string DecideDate { get; set; }
		public ShopOrderPackModel ShopOrderPackMaster { get; set; }
	}

	public class PictureBookBaseModel
	{
		public CharacterGroupModel CharacterGroupMaster { get; set; }
		public List<PictureBookDetailModel> PictureBookDetailModelArray { get; set; }
		public List<CharacterMainModel> CharacterMainMasterArray { get; set; }
		public dynamic DefaultRoomCharacterMainModel { get; set; }
		public int CharacterGroupId { get; set; }
		public int Order { get; set; }
		public int RoomSelectCharacterId { get; set; }
		public int CostumeId { get; set; }
		public dynamic RoomSelectPictureBookDetailModel { get; set; }
		public string Name { get; set; }
		public string ShortName { get; set; }
		public string Text { get; set; }
		public int ContentsGroupId { get; set; }
		public int Friendship { get; set; }
		public List<dynamic> ContentsMasterArray { get; set; }
		public List<dynamic> RoomStoryMasterArray { get; set; }
		public List<dynamic> VoiceStoryMasterArray { get; set; }
		public List<dynamic> NormalStoryMasterArray { get; set; }
		public List<dynamic> AdultStoryMasterArray { get; set; }
		public List<dynamic> VoiceContentsMasterArray { get; set; }
		public List<dynamic> UserNormalStoryArray { get; set; }
		public List<dynamic> UserAdultStoryArray { get; set; }
		public List<dynamic> UserVoiceStoryArray { get; set; }
		public Dictionary<string, dynamic> UserRoomStoryMap { get; set; }
		public Dictionary<string, dynamic> UserNormalStoryMap { get; set; }
		public Dictionary<string, dynamic> UserVoiceStoryMap { get; set; }
		public Dictionary<string, dynamic> UserAdultStoryMap { get; set; }
		public int FavoriteOrder { get; set; }
	}

	public class PictureBookDetailModel
	{
		public CharacterMainModel CharacterMainMaster { get; set; }
		public CharacterGroupModel CharacterGroupMaster { get; set; }
		public List<CharacterFavoriteModel> CharacterFavoriteMasterArray { get; set; }
		public int Attribute { get; set; }
		public int Rarity { get; set; }
		public int ExceedLimit { get; set; }
		public int CharacterId { get; set; }
		public int CharacterGroupId { get; set; }
		public string Name { get; set; }
		public string ShortName { get; set; }
		public string SkinName { get; set; }
		public string Text { get; set; }
		public int CharacterType { get; set; }
		public string VisibleDate { get; set; }
		public dynamic MaxFriendship { get; set; }
		public dynamic Union { get; set; }
		public string ReadingName { get; set; }
		public double FriendshipRate { get; set; }
		public int FriendshipBonusHp { get; set; }
		public int FriendshipBonusAtk { get; set; }
		public int FriendshipBonusDef { get; set; }
		public int ContentsGroupId { get; set; }
		public int Friendship { get; set; }
		public List<dynamic> ContentsMasterArray { get; set; }
		public List<dynamic> RoomStoryMasterArray { get; set; }
		public List<dynamic> NormalStoryMasterArray { get; set; }
		public List<dynamic> AdultStoryMasterArray { get; set; }
		public List<dynamic> VoiceStoryMasterArray { get; set; }
		public List<dynamic> VoiceContentsMasterArray { get; set; }
		public List<dynamic> UserNormalStoryArray { get; set; }
		public List<dynamic> UserAdultStoryArray { get; set; }
		public List<dynamic> UserVoiceStoryArray { get; set; }
		public Dictionary<string, dynamic> UserRoomStoryMap { get; set; }
		public Dictionary<string, dynamic> UserNormalStoryMap { get; set; }
		public Dictionary<string, dynamic> UserAdultStoryMap { get; set; }
		public Dictionary<string, dynamic> UserVoiceStoryMap { get; set; }
		public List<dynamic> CharacterFriendshipContentsMasterArray { get; set; }
		public int ContentsId { get; set; }
		public dynamic ConditionType1 { get; set; }
		public dynamic ConditionType2 { get; set; }
		public dynamic ConditionValue1 { get; set; }
		public dynamic ConditionValue2 { get; set; }
		public int StoryId { get; set; }
		public List<dynamic> CharacterStoryContentsMasterArray { get; set; }
		public dynamic LastReleaseFriendshipContentsMaster { get; set; }
		public dynamic NextReleaseFriendshipContentsMaster { get; set; }
		public dynamic NeedFriendshipForNextContentsRelease { get; set; }
		public string NextReleaseFriendshopContentsText { get; set; }
		public Dictionary<string, dynamic> PictureBookDetailVoiceInfoMap { get; set; }
		public dynamic LinkModel { get; set; }
		public dynamic LinkerParentPictureDetailModel { get; set; }
	}

	public class PrefModel
	{
		public UserPrefModel Pref { get; set; }
	}

	public class PresentMessageModel
	{
		public string Text { get; set; }
		public int MessageId { get; set; }
	}

	public class PvPCharacterModel
	{
		public PictureBookDetailModel PictureBookDetailModel { get; set; }
		public CharacterMainModel CharacterMainMaster { get; set; }
		public int CharacterId { get; set; }
		public List<dynamic> AvailableEquipmentWeaponModelList { get; set; }
		public List<dynamic> AvailableEquipmentProtectorModelList { get; set; }
		public int SubAttribute { get; set; }
		public int SkillLevel { get; set; }
		public int AbilityLevel1 { get; set; }
		public int AbilityLevel2 { get; set; }
		public int AbilityLevel3 { get; set; }
		public int LinkerId { get; set; }
	}

	public class PvPClassModel
	{
		public dynamic WinPoint { get; set; }
		public int PointFrom { get; set; }
		public int Class { get; set; }
		public int PointTo { get; set; }
		public string Name { get; set; }
	}

	public class PvPClassRewardModel
	{
		public int Class { get; set; }
		public int Order { get; set; }
		public int ItemType { get; set; }
		public int ItemId { get; set; }
		public int Count { get; set; }
	}

	public class PvPMainModel
	{
		public int Season { get; set; }
		public string FromDate { get; set; }
		public string ToDate { get; set; }
		public int MaxStamina { get; set; }
		public string RecoveryTime { get; set; }
		public int RecoveryStamina { get; set; }
		public int ItemType { get; set; }
		public int ItemId { get; set; }
		public int Turn { get; set; }
		public int WinPointBasic { get; set; }
		public int LostTurnPointBasic { get; set; }
		public int LostAnnihilationPointBasic { get; set; }
		public int ExchangeId { get; set; }
	}

	public class PvPModel
	{
		public PvPMainModel PvPMainMaster { get; set; }
		public PvPClassModel PvPClassMaster { get; set; }
		public dynamic NextPvPClassMaster { get; set; }
		public List<dynamic> StaminaRecoveryTimeArray { get; set; }
		public string Name { get; set; }
		public int MaxStamina { get; set; }
		public int RecoveryStamina { get; set; }
		public string NextStaminaRecoveryTime { get; set; }
		public int Point { get; set; }
		public dynamic NextClassNeedPoint { get; set; }
		public dynamic NextClassPoint { get; set; }
		public int PvpClass { get; set; }
		public string FromDate { get; set; }
		public string ToDate { get; set; }
		public int SelectedPlayCount { get; set; }
		public int Stamina { get; set; }
		public int UpdateCount { get; set; }
		public int WinCount { get; set; }
		public int MaxScore { get; set; }
		public int PvPMedalItemId { get; set; }
	}

	public class QuestAchieveModel
	{
		public string ConditionValue { get; set; }
		public int Count { get; set; }
		public int ItemType { get; set; }
		public string Text { get; set; }
		public int AchieveId { get; set; }
		public int AchieveType { get; set; }
		public string Name { get; set; }
	}

	public class QuestAreaModel
	{
		public int RewardItemId { get; set; }
		public int AreaId { get; set; }
		public string Name { get; set; }
		public string ToDate { get; set; }
		public string StartTime { get; set; }
		public string Text { get; set; }
		public int RewardItemCount { get; set; }
		public string ImageName { get; set; }
		public int WorldId { get; set; }
		public int Index { get; set; }
		public string FromDate { get; set; }
		public string EndTime { get; set; }
		public int RewardItemType { get; set; }
		public string WeekTypes { get; set; }
		public int Difficult { get; set; }
		public int MaxBattleCount { get; set; }
	}

	public class QuestDropModel
	{
		public int ItemId { get; set; }
		public int SkipTarget { get; set; }
		public int ItemType { get; set; }
		public int Level { get; set; }
		public int NormalTarget { get; set; }
		public int Rate { get; set; }
		public int StageId { get; set; }
		public int CountTo { get; set; }
		public int CountFrom { get; set; }
		public dynamic Group { get; set; }
		public int Order { get; set; }
		public int ExceedLimit { get; set; }
		public int DropType { get; set; }
	}

	public class QuestEventPointModel
	{
		public int ItemId { get; set; }
		public int Index { get; set; }
		public int ItemType { get; set; }
		public int CountFrom { get; set; }
		public int CountTo { get; set; }
		public int Rate { get; set; }
		public int StageId { get; set; }
	}

	public class QuestIconChangeModel
	{
		public int QuestIconChangeId { get; set; }
		public int QuestIconId { get; set; }
		public int IconType { get; set; }
		public string FromDate { get; set; }
		public string ToDate { get; set; }
	}

	public class QuestIconModel
	{
		public int QuestIconId { get; set; }
		public string IconName { get; set; }
	}

	public class QuestModel
	{
		public QuestStageModel QuestStageMaster { get; set; }
		public QuestWorldModel QuestWorldMaster { get; set; }
		public QuestAreaModel QuestAreaMaster { get; set; }
		public dynamic QuestAchieveMaster1 { get; set; }
		public dynamic QuestAchieveMaster2 { get; set; }
		public dynamic QuestAchieveMaster3 { get; set; }
		public List<QuestDropModel> QuestDropMasterArray { get; set; }
		public dynamic QuestStartStoryMaster { get; set; }
		public dynamic QuestEndStoryMaster { get; set; }
		public dynamic QuestStartUserStoryModel { get; set; }
		public dynamic QuestEndUserStoryModel { get; set; }
		public dynamic WorldCategory { get; set; }
		public int WorldId { get; set; }
		public string WorldName { get; set; }
		public int AreaId { get; set; }
		public string AreaName { get; set; }
		public dynamic AreaDifficult { get; set; }
		public string AreaText { get; set; }
		public int StageId { get; set; }
		public string StageName { get; set; }
		public int RecommendPower { get; set; }
		public int IsClearMission1 { get; set; }
		public int IsClearMission2 { get; set; }
		public int IsClearMission3 { get; set; }
		public bool IsCompletedMissions { get; set; }
		public int PlayCount { get; set; }
		public int ClearCount { get; set; }
		public int Category { get; set; }
		public int Stamina { get; set; }
		public int TodaySkipCount { get; set; }
		public int MaxSkipCount { get; set; }
		public int TodayPlayCount { get; set; }
		public int SkipItemId { get; set; }
		public int MaxDayPlayCount { get; set; }
		public int MaxClearCount { get; set; }
		public bool IsDayChallengeCountRemain { get; set; }
		public int ReleaseStageId { get; set; }
		public int DefaultSkillGaugeRate { get; set; }
		public bool IsClear { get; set; }
	}

	public class QuestRestrictionGroupModel
	{
		public int QuestType { get; set; }
		public int QuestId { get; set; }
		public int RestrictionGroupId { get; set; }
		public string ErrMsgText { get; set; }
	}

	public class QuestRestrictionMainModel
	{
		public int RestrictionGroupId { get; set; }
		public int RestrictionType { get; set; }
		public string ConditionValue { get; set; }
	}

	public class QuestScenarioModel
	{
		public int WorldId { get; set; }
		public int ScenarioNum { get; set; }
	}

	public class QuestStageConditionModel
	{
		public int StageId { get; set; }
		public int ConditionType { get; set; }
		public int ConditionId { get; set; }
		public string ConditionValue { get; set; }
	}

	public class QuestStageModel
	{
		public int WorldId { get; set; }
		public int AreaId { get; set; }
		public int StageId { get; set; }
		public int ReleaseStageId { get; set; }
		public string Name { get; set; }
		public string Text { get; set; }
		public int RecommendPower { get; set; }
		public int Stamina { get; set; }
		public int MaxBattleCount { get; set; }
		public int SkipItemId { get; set; }
		public int MaxSkipCount { get; set; }
		public int MaxClearCount { get; set; }
		public int UserExpFrom { get; set; }
		public int UserExpTo { get; set; }
		public int CharacterExpFrom { get; set; }
		public int CharacterExpTo { get; set; }
		public int GoldFrom { get; set; }
		public int GoldTo { get; set; }
		public int AchieveId1 { get; set; }
		public int AchieveId2 { get; set; }
		public int AchieveId3 { get; set; }
		public int RewardItemType { get; set; }
		public int RewardItemId { get; set; }
		public int RewardItemCount { get; set; }
		public int DefaultSkillGaugeRate { get; set; }
		public string Background { get; set; }
		public string NormalWaveBgm { get; set; }
		public string BossWaveBgm { get; set; }
	}

	public class QuestWorldModel
	{
		public int WorldId { get; set; }
		public int Category { get; set; }
		public string Name { get; set; }
		public string ImageName { get; set; }
		public int MaxBattleCount { get; set; }
		public int RewardItemType { get; set; }
		public int RewardItemId { get; set; }
		public int RewardItemCount { get; set; }
		public string FromDate { get; set; }
		public string ToDate { get; set; }
	}

	public class RaceAbilityEffectGroupModel
	{
		public int EffectGroupId { get; set; }
		public int EffectId { get; set; }
		public int Order { get; set; }
	}

	public class RaceAbilityEffectModel
	{
		public int TargetType { get; set; }
		public int EffectType { get; set; }
		public int EffectValueType { get; set; }
		public int EffectValue { get; set; }
		public int Rate { get; set; }
		public int EffectId { get; set; }
		public string Text { get; set; }
		public int EffectTiming { get; set; }
	}

	public class RaceAbilityGroupModel
	{
		public int AbilityId { get; set; }
		public int Category { get; set; }
		public int AbilityGroupId { get; set; }
		public int Order { get; set; }
	}

	public class RaceAbilityMainModel
	{
		public int AbilityId { get; set; }
		public int EffectGroupId { get; set; }
		public int ConditionType { get; set; }
		public string ConditionValue { get; set; }
	}

	public class RaceAreaModel
	{
		public int Season { get; set; }
		public int AreaId { get; set; }
		public string WeekTypes { get; set; }
		public int StageGroupId { get; set; }
		public string Description { get; set; }
	}

	public class RaceCharacterFreeModel
	{
		public int CharacterId { get; set; }
		public string FromDate { get; set; }
		public string ToDate { get; set; }
	}

	public class RaceCharacterMainModel
	{
		public int FortifyType { get; set; }
		public int AbilityGroupId { get; set; }
		public int MinStatusId { get; set; }
		public int MaxStatusId { get; set; }
		public int CharacterId { get; set; }
		public int TextGroupId { get; set; }
		public int BoostType { get; set; }
		public int RacingNumber { get; set; }
		public int MaxPlayCount { get; set; }
	}

	public class RaceCharacterModel
	{
		public int CharacterId { get; set; }
		public int AddP1 { get; set; }
		public int AddP2 { get; set; }
		public int AddP3 { get; set; }
		public int AddP4 { get; set; }
		public int Stamina { get; set; }
		public RaceCharacterMainModel RaceCharacterMainMaster { get; set; }
		public int Param1 { get; set; }
		public int Param2 { get; set; }
		public int Param3 { get; set; }
		public int Param4 { get; set; }
		public string LastRecoveryDate { get; set; }
	}

	public class RaceCommentaryTextModel
	{
		public int SituationId { get; set; }
		public int TrapId { get; set; }
		public string Text { get; set; }
	}

	public class RaceEffectTargetModel
	{
		public int TargetType { get; set; }
		public string Text { get; set; }
	}

	public class RaceEffectTimingModel
	{
		public int EffectTiming { get; set; }
		public int Category { get; set; }
		public string Text { get; set; }
	}

	public class RaceEffectTypeModel
	{
		public int EffectType { get; set; }
		public string Text { get; set; }
	}

	public class RaceEffectValueTypeModel
	{
		public string Text { get; set; }
		public int EffectValueType { get; set; }
	}

	public class RaceFortifyModel
	{
		public int FortifyType { get; set; }
		public int Param1 { get; set; }
		public int Param2 { get; set; }
		public int Param3 { get; set; }
		public int Param4 { get; set; }
	}

	public class RaceMainModel
	{
		public int MaxPlayCount { get; set; }
		public string Name { get; set; }
		public string ToDate { get; set; }
		public int CarryOverRate { get; set; }
		public int Season { get; set; }
		public string FromDate { get; set; }
		public int RecoveryCount { get; set; }
		public string RecoveryTime { get; set; }
		public string BgFileName { get; set; }
	}

	public class RaceObstacleModel
	{
		public int ObstacleId { get; set; }
		public int ExamValue { get; set; }
		public int Obstacle1 { get; set; }
		public int Obstacle2 { get; set; }
		public int Obstacle3 { get; set; }
		public int Obstacle4 { get; set; }
	}

	public class RaceRewardModel
	{
		public int ItemId { get; set; }
		public int Count { get; set; }
		public int Order { get; set; }
		public int RewardId { get; set; }
		public int ItemType { get; set; }
	}

	public class RaceSessionModel
	{
		public int Season { get; set; }
		public int Rank { get; set; }
		public int Stamina { get; set; }
		public string LastRaceStartDate { get; set; }
		public string LastRaceEndDate { get; set; }
		public string LastRecoveryDate { get; set; }
		public RaceMainModel RaceMainMaster { get; set; }
		public bool IsAvailableRaceSeason { get; set; }
		public List<dynamic> PlayableRaceStageMasterArray { get; set; }
		public string SeasonRemainText { get; set; }
	}

	public class RaceStageModel
	{
		public int FirstRewardId { get; set; }
		public string Name { get; set; }
		public int MemberCount { get; set; }
		public int Rank { get; set; }
		public int StageGroupId { get; set; }
		public int WinRewardId { get; set; }
		public int ObstacleId { get; set; }
		public int AbilityGroupId { get; set; }
		public int LoseRewardId { get; set; }
	}

	public class RaceStatusModel
	{
		public int StatusId { get; set; }
		public int Param1 { get; set; }
		public int Param2 { get; set; }
		public int Param3 { get; set; }
		public int Param4 { get; set; }
		public int Stamina { get; set; }
	}

	public class RaceTextModel
	{
		public int TextGroupId { get; set; }
		public int TextType { get; set; }
		public string Text { get; set; }
	}

	public class RaceTopTextModel
	{
		public int CharacterId { get; set; }
		public string Text { get; set; }
	}

	public class RaidBattleModel
	{
		public int EventId { get; set; }
		public int StageId { get; set; }
		public List<RaidBattleTypeModel> RaidBattleType { get; set; }
		public int BattlePoint { get; set; }
		public int AppearCostItemType { get; set; }
		public int AppearCostItemId { get; set; }
		public int AppearCostItemCount { get; set; }
		public int RewardId { get; set; }
	}

	public class RaidBattleTypeModel
	{
		public List<RaidBattleTypeModel> RaidBattleType { get; set; }
		public int MaxUserCount { get; set; }
		public int RescueInterval { get; set; }
		public int AppearancePeriod { get; set; }
		public int MaxTurn { get; set; }
	}

	public class RaidModel
	{
		public dynamic EntryRaidBattleSessions { get; set; }
		public dynamic PublicRaidBattleSessions { get; set; }
		public List<dynamic> NextRescueEnableDateList { get; set; }
	}

	public class RaidRewardGroupModel
	{
		public int RewardGroupId { get; set; }
		public int Order { get; set; }
		public int ItemType { get; set; }
		public int ItemId { get; set; }
		public int Count { get; set; }
		public int Rate { get; set; }
	}

	public class RaidRewardModel
	{
		public int RewardId { get; set; }
		public int NormalRewardGroupId { get; set; }
		public int DiscovererRewardGroupId { get; set; }
		public int MvpRewardGroupId { get; set; }
		public int SemiMvpRewardGroupId { get; set; }
	}

	public class RoomCharacterFrameModel
	{
		public int CharacterFrameCount { get; set; }
		public int CostCount { get; set; }
		public int CostId { get; set; }
		public int CostType { get; set; }
	}

	public class RoomFurnitureModel
	{
		public UserFurnitureModel UserFurnitureModel { get; set; }
		public FurnitureMainModel FurnitureMainMaster { get; set; }
		public FurnitureCollectModel FurnitureCollectMaster { get; set; }
		public int FurnitureId { get; set; }
		public string FurnitureName { get; set; }
		public int FurnitureCategory { get; set; }
		public int CollectItemType { get; set; }
		public int CollectItemId { get; set; }
		public int CollectCountPerStack { get; set; }
		public int CollectTime { get; set; }
		public int MaxStackCount { get; set; }
		public int MaxCollectCount { get; set; }
		public int CurrentStackCount { get; set; }
		public int CurrentCollectCount { get; set; }
		public dynamic RemainSecForMaxCollect { get; set; }
		public dynamic RemainHmsForMaxCollect { get; set; }
		public int MapCategory { get; set; }
		public int CharacterGroupId { get; set; }
		public string FurnitureCd { get; set; }
		public string NextCollectDate { get; set; }
		public dynamic LastCollectDate { get; set; }
		public dynamic CorrectionCollectSecond { get; set; }
	}

	public class RoomMainModel
	{
		public int MaxCharacterCount { get; set; }
		public dynamic MaxFloor { get; set; }
		public int SizeX { get; set; }
		public int SizeY { get; set; }
		public dynamic MaxWall { get; set; }
		public dynamic MaxFurniture { get; set; }
		public dynamic MaxRug { get; set; }
		public dynamic MaxGoods { get; set; }
	}

	public class RoomModel
	{
		public List<dynamic> RoomFurnitureList { get; set; }
		public List<dynamic> RoomCharacterList { get; set; }
	}

	public class ShopDetailConditionModel
	{
		public int ListId { get; set; }
		public int ConditionType { get; set; }
		public int ConditionId { get; set; }
		public int ShopId { get; set; }
	}

	public class ShopDetailModel
	{
		public int ShopId { get; set; }
		public int ListId { get; set; }
		public int Order { get; set; }
		public string Name { get; set; }
		public string Text { get; set; }
		public int CostType { get; set; }
		public int CostId { get; set; }
		public int CostCount { get; set; }
		public int MaxCount { get; set; }
		public int ResetType { get; set; }
		public int ReplenishmentDays { get; set; }
		public string FromDate { get; set; }
		public string ToDate { get; set; }
		public int ItemType { get; set; }
		public int ItemId { get; set; }
		public int Count { get; set; }
		public int NormalBonus { get; set; }
		public int FirstBonus { get; set; }
		public string IconName { get; set; }
		public int SkuId { get; set; }
		public string WeekTypes { get; set; }
		public int LabelType { get; set; }
		public int ListGroupId { get; set; }
		public int PreListId { get; set; }
		public int MissionId { get; set; }
	}

	public class ShopEventItemConditionModel
	{
		public int EventId { get; set; }
		public int ItemId { get; set; }
		public int ItemType { get; set; }
		public int ConditionId { get; set; }
		public int Count { get; set; }
		public int ConditionTo { get; set; }
	}

	public class ShopListGroupModel
	{
		public int ListGroupId { get; set; }
		public int Order { get; set; }
		public string ListName { get; set; }
	}

	public class ShopMainModel
	{
		public int Category { get; set; }
		public int Order { get; set; }
		public int ConditionType { get; set; }
		public string Name { get; set; }
		public string ToDate { get; set; }
		public int ShopId { get; set; }
		public string ReleaseDate { get; set; }
		public string FromDate { get; set; }
		public int ConditionTo { get; set; }
		public string ShortName { get; set; }
		public int ConditionFrom { get; set; }
		public int ConditionFrom2 { get; set; }
		public int TabColor { get; set; }
	}

	public class ShopOrderPackModel
	{
		public int ShopId { get; set; }
		public int ListId { get; set; }
		public int BoxNo { get; set; }
		public int Index { get; set; }
		public int ItemType { get; set; }
		public int ItemId { get; set; }
		public int Count { get; set; }
	}

	public class SolidEquipmentModel
	{
		public string EquipmentCd { get; set; }
		public int EquipmentId { get; set; }
		public int ExceedLimit { get; set; }
		public int Count { get; set; }
		public int Level { get; set; }
		public int IsProtect { get; set; }
		public int Exp { get; set; }
		public int ItemType { get; set; }
		public int ModelType { get; set; }
		public EquipmentMainModel EquipmentMainMaster { get; set; }
		public EquipmentMaterialModel EquipmentMaterialMaster { get; set; }
		public Dictionary<string, dynamic> EquipmentEffectInfoMap { get; set; }
		public int EquipmentLevelMaster { get; set; }
		public bool IsLevelMax { get; set; }
		public string Name { get; set; }
		public string Text { get; set; }
		public int EquipmentGroupId { get; set; }
		public int Attribute { get; set; }
		public int ExceedLimitItemType { get; set; }
		public int SalePrice { get; set; }
		public int EquipmentType { get; set; }
		public int ExceedLimitType { get; set; }
		public int MaterialType { get; set; }
		public int FortifyPrice { get; set; }
		public int AddExp { get; set; }
		public int Rarity { get; set; }
		public int IsMaxRarity { get; set; }
		public int MaxLevel { get; set; }
		public int FortifyLevel { get; set; }
		public int FortifyMaxLevel { get; set; }
		public bool IsCharacterEquipment { get; set; }
		public int MaxHp { get; set; }
		public int MaxAtk { get; set; }
		public int MaxDef { get; set; }
		public int MinHp { get; set; }
		public int MinAtk { get; set; }
		public int MinDef { get; set; }
		public EquipmentEffectModel EquipmentEffectMaster { get; set; }
		public string EffectTextForNormal { get; set; }
		public string EffectTextForBoost { get; set; }
		public EquipmentExceedLimitItemModel EquipmentExceedLimitItemMaster { get; set; }
	}

	public class SoundMainModel
	{
		public int SoundId { get; set; }
		public int Type { get; set; }
		public string Title { get; set; }
		public string FileName { get; set; }
	}

	public class SoundModel
	{
		public int SoundId { get; set; }
		public SoundMainModel SoundMainMaster { get; set; }
	}

	public class SpecialRoomActionModel
	{
		public int SpecialRoomId { get; set; }
		public long ActionId { get; set; }
		public int PlayType { get; set; }
		public string TapPoint { get; set; }
		public int IsAdv { get; set; }
		public int TextId { get; set; }
	}

	public class SpecialRoomBaseSpineModel
	{
		public List<SpecialRoomBaseSpineModel> SpecialRoomBaseSpineMasterArray { get; set; }
		public int SpecialRoomId { get; set; }
		public string SpineDirectoryPath { get; set; }
		public string SpineFileName { get; set; }
		public string BgFileName { get; set; }
		public string FrontFileName { get; set; }
		public string SpVoiceFileName { get; set; }
		public int TextBoxPositionX { get; set; }
		public int TextBoxPositionY { get; set; }
	}

	public class SpecialRoomConditionalModel
	{
		public int SpecialRoomId { get; set; }
		public long ActionId { get; set; }
		public int Month { get; set; }
		public int Day { get; set; }
		public string DayType { get; set; }
		public string StartTime { get; set; }
		public string EndTime { get; set; }
	}

	public class SpecialRoomMainModel
	{
		public int CharacterGroupId { get; set; }
		public int SpecialRoomId { get; set; }
		public string Name { get; set; }
		public string CharacterShortName { get; set; }
		public string VisibleDate { get; set; }
		public string ReleaseDate { get; set; }
	}

	public class SpecialRoomTapPointModel
	{
		public int SpecialRoomId { get; set; }
		public string TapPoint { get; set; }
		public string BoneName { get; set; }
		public string SlotName { get; set; }
	}

	public class SpecialRoomTextModel
	{
		public int SpecialRoomId { get; set; }
		public string Text { get; set; }
		public int TextId { get; set; }
		public string SkinName { get; set; }
		public string VoiceFile { get; set; }
		public string Animation { get; set; }
	}

	public class StoryCabinModel
	{
		public int ResourceId { get; set; }
		public int StoryId { get; set; }
		public int StoryGroupId { get; set; }
		public string Name { get; set; }
	}

	public class StoryCategoryModel
	{
		public string Name { get; set; }
		public int StoryCategory { get; set; }
	}

	public class StoryEventModel
	{
		public int StoryGroupId { get; set; }
		public int StoryId { get; set; }
		public int ReleaseStoryId { get; set; }
		public int ResourceId { get; set; }
		public int EventId { get; set; }
		public string Name { get; set; }
		public int StageId { get; set; }
		public int PlayType { get; set; }
		public int StableEventId { get; set; }
	}

	public class StoryGachaModel
	{
		public int ResourceId { get; set; }
		public int StoryId { get; set; }
		public int CharacterId { get; set; }
		public int StoryGroupId { get; set; }
		public string Name { get; set; }
	}

	public class StoryGroupModel
	{
		public string Name { get; set; }
		public int StoryCategory { get; set; }
		public int StoryGroupId { get; set; }
	}

	public class StoryMemorialEventOtherModel
	{
		public int StoryGroupId { get; set; }
		public int StoryId { get; set; }
		public int ResourceId { get; set; }
		public int EventId { get; set; }
		public string Name { get; set; }
		public string VisibleDate { get; set; }
	}

	public class StoryMemorialModel
	{
		public int StoryGroupId { get; set; }
		public int MemorialId { get; set; }
		public int StoryId { get; set; }
		public int ResourceId { get; set; }
		public string Name { get; set; }
	}

	public class StoryModel
	{
		public StoryModel StoryMaster { get; set; }
		public StoryGroupModel StoryGroupMaster { get; set; }
		public StoryCategoryModel StoryCategoryMaster { get; set; }
		public int StoryId { get; set; }
		public int IsRead { get; set; }
		public int StoryGroupId { get; set; }
		public int StoryCategory { get; set; }
		public string StoryName { get; set; }
		public int ResourceId { get; set; }
		public int PlayType { get; set; }
		public int LightResourceId { get; set; }
		public dynamic ContentMaster { get; set; }
		public dynamic NextStoryMaster { get; set; }
		public int NextStoryId { get; set; }
	}

	public class StoryOtherModel
	{
		public int StoryGroupId { get; set; }
		public int StoryId { get; set; }
		public int ResourceId { get; set; }
		public int EventId { get; set; }
		public string Name { get; set; }
		public int StageId { get; set; }
		public int PlayType { get; set; }
	}

	public class StoryPictureBookModel
	{
		public int RewardCount { get; set; }
		public string Name { get; set; }
		public int StoryGroupId { get; set; }
		public int LightResourceId { get; set; }
		public int ResourceId { get; set; }
		public int RewardType { get; set; }
		public int RewardId { get; set; }
		public int StoryId { get; set; }
		public string VisibleDate { get; set; }
	}

	public class StoryQuestModel
	{
		public int StoryGroupId { get; set; }
		public int StoryId { get; set; }
		public int ResourceId { get; set; }
		public string Name { get; set; }
		public int StageId { get; set; }
		public int PlayType { get; set; }
	}

	public class StoryRoomModel
	{
		public int StoryGroupId { get; set; }
		public int StoryId { get; set; }
		public int ResourceId { get; set; }
		public string Name { get; set; }
		public int Condition1 { get; set; }
		public int Condition2 { get; set; }
		public int RewardType { get; set; }
		public int RewardId { get; set; }
		public int RewardCount { get; set; }
		public string VisibleDate { get; set; }
	}

	public class StoryTutorialModel
	{
		public int StoryGroupId { get; set; }
		public int StoryId { get; set; }
		public int ResourceId { get; set; }
		public string Name { get; set; }
	}

	public class StoryVoiceModel
	{
		public int StoryGroupId { get; set; }
		public int StoryId { get; set; }
		public int ResourceId { get; set; }
		public string Name { get; set; }
	}

	public class TowerMainModel
	{
		public string DateTo { get; set; }
		public int AreaId { get; set; }
		public string DateFrom { get; set; }
		public int DeckIdFrom { get; set; }
		public int DeckIdTo { get; set; }
	}

	public class TowerRewardGroupModel
	{
		public int RewardGroupId { get; set; }
		public int Order { get; set; }
		public int ItemType { get; set; }
		public int ItemId { get; set; }
		public int Count { get; set; }
	}

	public class TowerRewardModel
	{
		public int StageId { get; set; }
		public int CompleteRewardGroupId { get; set; }
		public int StageRewardGroupId { get; set; }
		public int StageRewardType { get; set; }
	}

	public class TowerSessionModel
	{
		public string SessionId { get; set; }
		public int AreaId { get; set; }
		public string BattleSessionId { get; set; }
		public int StageId { get; set; }
		public int DeckId { get; set; }
		public int DeckType { get; set; }
		public dynamic ContinueData { get; set; }
		public string TowerSelectDate { get; set; }
		public int TowerSelectMaxCount { get; set; }
		public string RecentDate { get; set; }
		public Dictionary<string, dynamic> TowerStageMasterMap { get; set; }
		public int TowerSelectCount { get; set; }
	}

	public class TutorialEventModel
	{
		public int TutorialEventId { get; set; }
		public int CompleteStep { get; set; }
		public int CompleteSubStep { get; set; }
		public string Description { get; set; }
		public int ActionType { get; set; }
		public string ActionParam1 { get; set; }
		public string ActionParam2 { get; set; }
	}

	public class TutorialMainStepModel
	{
		public int Step { get; set; }
		public string SceneName { get; set; }
		public string ViewName { get; set; }
		public string ViewParam { get; set; }
	}

	public class TutorialSkipModel
	{
		public int TargetStep { get; set; }
		public int NextStep { get; set; }
		public string HeaderText { get; set; }
		public string MainText { get; set; }
		public string NoteName { get; set; }
	}

	public class TutorialSubStepModel
	{
		public int Step { get; set; }
		public int SubStep { get; set; }
		public int StoryId { get; set; }
		public string TriggerName { get; set; }
		public int TriggerType { get; set; }
		public int TriggerParam { get; set; }
	}

	public class UniqueMissionModel
	{
		public int MissionGroupId { get; set; }
	}

	public class UserBasicInfoModel
	{
		public int IsBgmMute { get; set; }
		public int IsSeMute { get; set; }
		public int IsVoiceMute { get; set; }
		public int IsSkillAuto { get; set; }
		public int StaminaValue { get; set; }
		public int CharacterMaxCount { get; set; }
		public int ItemMaxCount { get; set; }
		public int DefaultDeckId { get; set; }
		public string SystemDate { get; set; }
		public int VoiceVolume { get; set; }
		public int EquipmentMaxCount { get; set; }
		public int IsEnabled { get; set; }
		public string UserCd { get; set; }
		public int BattleSpeed { get; set; }
		public int SeVolume { get; set; }
		public int StaminaBonus { get; set; }
		public int BgmVolume { get; set; }
		public string DisplayId { get; set; }
		public string UserName { get; set; }
		public string UserNameTextId { get; set; }
		public int UserNameStatus { get; set; }
		public dynamic Partner { get; set; }
		public int Level { get; set; }
		public string StaminaRecoveryDate { get; set; }
		public int Exp { get; set; }
		public string RegisterDate { get; set; }
		public int StaminaRemainSec { get; set; }
		public string UserText { get; set; }
		public int PlayerType { get; set; }
		public int RoomCharacterMaxCount { get; set; }
		public int BattlePointValue { get; set; }
		public int BattlePointBonus { get; set; }
		public int BattlePointRemainSec { get; set; }
		public string BattlePointRecoveryDate { get; set; }
		public int TutorialStep { get; set; }
		public string TutorialEndDate { get; set; }
	}

	public class UserBoostModel
	{
		public int BoostType { get; set; }
		public int ItemId { get; set; }
		public dynamic Parameter { get; set; }
		public string EndDate { get; set; }
		public string StartDate { get; set; }
	}

	public class UserBuffHelpModel
	{
		public int Order { get; set; }
		public string Name { get; set; }
		public string Text { get; set; }
		public string FileName { get; set; }
	}

	public class UserCabinMissionModel
	{
		public int MissionGroupId { get; set; }
		public int MissionId { get; set; }
		public int ReceiveCount { get; set; }
	}

	public class UserCharacterAbilityEffectModel
	{
		public int AbilityId { get; set; }
		public List<dynamic> AddAbilityIdArray { get; set; }
		public int Level { get; set; }
		public int Index { get; set; }
		public List<dynamic> AwakeEffectMasterArray { get; set; }
		public dynamic AbilityEffectMaster { get; set; }
		public int SuccessRate { get; set; }
		public string Text { get; set; }
		public string ShortText { get; set; }
		public int EffectLimit { get; set; }
		public int ActionType { get; set; }
		public int EffectType { get; set; }
		public int EndType { get; set; }
		public List<dynamic> AbilityAwakeEffectMasterArray { get; set; }
		public int EffectValue { get; set; }
		public int OccurrenceRate { get; set; }
		public int TargetType { get; set; }
		public string TargetValue { get; set; }
		public string EndValue { get; set; }
		public int EffectConditionType { get; set; }
		public string EffectConditionValue { get; set; }
	}

	public class UserCharacterAbilityGroupModel
	{
		public int AbilityGroupId { get; set; }
		public int AbilityLevel1 { get; set; }
		public int AbilityLevel2 { get; set; }
		public int AbilityLevel3 { get; set; }
		public int Rarity { get; set; }
		public int ExceedLimit { get; set; }
		public List<dynamic> ExceedLimitMasterArray { get; set; }
		public List<dynamic> AwakeEffectMasterArray { get; set; }
		public List<dynamic> AbilityGroupMasterArray { get; set; }
		public List<dynamic> AbilityAddAwakeEffectMasterArray { get; set; }
		public List<dynamic> UserAbilityMainArray { get; set; }
	}

	public class UserCharacterAbilityMainModel
	{
		public int AbilityId { get; set; }
		public int Level { get; set; }
		public int AbilityIndex { get; set; }
		public int Rarity { get; set; }
		public int ExceedLimit { get; set; }
		public List<dynamic> ExceedLimitMasterArray { get; set; }
		public List<dynamic> AwakeEffectMasterArray { get; set; }
		public dynamic AbilityMainMaster { get; set; }
		public Dictionary<string, dynamic> AbilityAwakeEffectMasterMap { get; set; }
		public List<dynamic> AbilityExtendedAwakeIdArray { get; set; }
		public int AddAbilityId { get; set; }
		public List<dynamic> AddAbilityIdArray { get; set; }
		public string Name { get; set; }
		public int TriggerType { get; set; }
		public string TriggerValue { get; set; }
		public Dictionary<string, dynamic> ConditionMap { get; set; }
		public int InvokeLimitCount { get; set; }
		public int AbilityFortifyType { get; set; }
		public dynamic NeedExceedLimitMaster { get; set; }
		public int NeedExceedLimit { get; set; }
		public List<dynamic> AddUserAbilityMainArray { get; set; }
		public List<dynamic> AbilityExtendedAwakeEffectMasterArray { get; set; }
		public List<dynamic> EffectAddAwakeEffectMasterArray { get; set; }
		public dynamic NextUserAbilityMain { get; set; }
		public Dictionary<string, dynamic> UserAbilityEffectMap { get; set; }
		public Dictionary<string, dynamic> UserAbilityEffectMasterMap { get; set; }
		public List<dynamic> AbilityExtendedAwakeEffectMainMasterArray { get; set; }
		public List<dynamic> CurrentUserAbilityEffectArray { get; set; }
		public bool IsReleased { get; set; }
		public bool IsSupportAbility { get; set; }
		public bool IsAwakeAbility { get; set; }
		public bool IsTrastAbility { get; set; }
		public string AbilityText { get; set; }
		public Dictionary<string, dynamic> SingleUserAbilityEffectMap { get; set; }
		public List<dynamic> SingleUserAbilityEffectArray { get; set; }
		public string SingleAbilityText { get; set; }
		public string SingleAbilityShortText { get; set; }
		public string CharacterCd { get; set; }
		public int CharacterId { get; set; }
		public int ParentId { get; set; }
		public int LinkerId { get; set; }
		public int Priority { get; set; }
		public int SkillLevel { get; set; }
		public int AbilityLevel1 { get; set; }
		public int AbilityLevel2 { get; set; }
		public int AbilityLevel3 { get; set; }
	}

	public class UserCharacterModel
	{
		public string CharacterCd { get; set; }
		public int CharacterId { get; set; }
		public int Exp { get; set; }
		public int Level { get; set; }
		public int AddHp { get; set; }
		public int AddAtk { get; set; }
		public int AddDef { get; set; }
		public int SkillLevel { get; set; }
		public int AbilityLevel1 { get; set; }
		public int AbilityLevel2 { get; set; }
		public int AbilityLevel3 { get; set; }
		public int ExceedLimit { get; set; }
		public int ExceedLimitExp { get; set; }
		public int IsProtect { get; set; }
		public string RegisterDate { get; set; }
		public List<string> EquipmentWeaponCds { get; set; }
		public List<dynamic> EquipmentProtectorCds { get; set; }
		public List<dynamic> AwakeIds { get; set; }
		public int BattleCount { get; set; }
		public int AddRarity { get; set; }
	}

	public class UserCharacterSkillEffectModel
	{
		public int SkillId { get; set; }
		public int Level { get; set; }
		public int Index { get; set; }
		public List<dynamic> AwakeEffectMasterArray { get; set; }
		public dynamic SkillEffectMaster { get; set; }
		public int EffectConditionType { get; set; }
		public int SuccessRate { get; set; }
		public string Text { get; set; }
		public string ShortText { get; set; }
		public string EffectConditionValue { get; set; }
		public int ActionType { get; set; }
		public int EffectType { get; set; }
		public int EndType { get; set; }
		public List<dynamic> SkillAwakeEffectMasterArray { get; set; }
		public int EffectValue { get; set; }
		public int EffectLimit { get; set; }
		public int OccurrenceRate { get; set; }
		public int TargetType { get; set; }
		public string TargetValue { get; set; }
		public string EndValue { get; set; }
	}

	public class UserCharacterSkillMainModel
	{
		public int SkillId { get; set; }
		public int Level { get; set; }
		public int SkillIndex { get; set; }
		public List<dynamic> AwakeEffectMasterArray { get; set; }
		public dynamic SkillMainMaster { get; set; }
		public string Name { get; set; }
		public int EffectShowType { get; set; }
		public string SpineDirectoryPath { get; set; }
		public string SpineName { get; set; }
		public string AniName { get; set; }
		public string HitEffectName { get; set; }
		public string HitEffectAniName { get; set; }
		public double BgmVolumeAmount { get; set; }
		public int SkillFortifyType { get; set; }
		public List<dynamic> SkillEffectMasterArray { get; set; }
		public List<dynamic> UserSkillEffectArray { get; set; }
		public List<dynamic> EffectAddAwakeEffectMasterArray { get; set; }
		public List<dynamic> UserAwakeSkillEffectArray { get; set; }
	}

	public class UserComebackModel
	{
		public int CampaignId { get; set; }
		public string IgniteDate { get; set; }
	}

	public class UserDeckModel
	{
		public int Position { get; set; }
		public int DeckId { get; set; }
		public int DeckType { get; set; }
		public int RoleType { get; set; }
		public string CharacterCd { get; set; }
	}

	public class UserEquipmentModel
	{
		public int IsProtect { get; set; }
		public string RegisterDate { get; set; }
		public int EquipmentId { get; set; }
		public string EquipmentCd { get; set; }
		public int Level { get; set; }
		public int Exp { get; set; }
		public int ExceedLimit { get; set; }
	}

	public class UserEventFriendshipItemModel
	{
		public int FriendshipGroupId { get; set; }
		public int ItemType { get; set; }
		public int ItemId { get; set; }
		public int Count { get; set; }
	}

	public class UserEventItemModel
	{
		public int EventId { get; set; }
		public int ItemType { get; set; }
		public int ItemId { get; set; }
		public int Count { get; set; }
	}

	public class UserExchangeHistoryModel
	{
		public int TodayQuantity { get; set; }
		public int ExchangeId { get; set; }
		public int TotalQuantity { get; set; }
		public int WeeklyQuantity { get; set; }
		public int MonthlyQuantity { get; set; }
		public int PvPSeasonQuantity { get; set; }
		public int ListId { get; set; }
		public string LastExchangeDate { get; set; }
	}

	public class UserFurnitureModel
	{
		public int FurnitureId { get; set; }
		public string FurnitureCd { get; set; }
		public int FurnitureCategory { get; set; }
		public int IsBuyFurniture { get; set; }
		public int Level { get; set; }
	}

	public class UserGachaModel
	{
		public string ToDate { get; set; }
		public string GachaText { get; set; }
		public string WeekType { get; set; }
		public string GachaName { get; set; }
		public List<dynamic> Buttons { get; set; }
		public List<dynamic> Banners { get; set; }
		public string FromDate { get; set; }
		public int GachaType { get; set; }
		public int GachaId { get; set; }
		public int Order { get; set; }
		public int ConditionType { get; set; }
		public int ConditionFrom { get; set; }
		public int ConditionTo { get; set; }
		public int AddLayoutType { get; set; }
		public dynamic AddLayoutParam { get; set; }
	}

	public class UserGemModel
	{
		public int FreeGem { get; set; }
		public int PaidGem { get; set; }
	}

	public class UserHelpModel
	{
		public string SceneName { get; set; }
		public int Order { get; set; }
		public string FileName { get; set; }
		public string DescriptionText { get; set; }
	}

	public class UserHowToPlayModel
	{
		public string SceneName { get; set; }
		public int Page { get; set; }
	}

	public class UserItemModel
	{
		public int ItemId { get; set; }
		public int Count { get; set; }
		public int ItemType { get; set; }
	}

	public class UserLinearMissionModel
	{
		public int MissionGroupId { get; set; }
		public int Step { get; set; }
		public int ClearCount { get; set; }
		public int RewardPoint { get; set; }
		public string StartDate { get; set; }
		public string ResetDate { get; set; }
	}

	public class UserLoginPackModel
	{
		public int LoginPackId { get; set; }
		public string StartDate { get; set; }
		public string EndDate { get; set; }
		public List<dynamic> ReceivedList { get; set; }
		public int ReceiveCount { get; set; }
		public string LastReceiveDate { get; set; }
	}

	public class UserLotteryModel
	{
		public int ItemId { get; set; }
		public string LotteryCd { get; set; }
	}

	public class UserMainModel
	{
		public int UserLevel { get; set; }
		public int TotalExp { get; set; }
		public int NextLevelExp { get; set; }
		public int MaxStamina { get; set; }
		public int MaxBattlePoint { get; set; }
		public int MaxFriend { get; set; }
		public int MaxExpeditionDeck { get; set; }
		public int MaxTowerDeck { get; set; }
		public int MaxCharacterAddBorder { get; set; }
	}

	public class UserMemorialDeckModel
	{
		public int DeckType { get; set; }
		public int DeckId { get; set; }
		public int Position { get; set; }
		public int MemorialId { get; set; }
	}

	public class UserMemorialModel
	{
		public int MemorialId { get; set; }
		public int Level { get; set; }
		public int ExceedLimit { get; set; }
		public string RegisterDate { get; set; }
	}

	public class UserMinigameModel
	{
		public int TotalPlayCount { get; set; }
		public string LastDate { get; set; }
	}

	public class UserMissionModel
	{
		public int ClearCount { get; set; }
		public string MissionCd { get; set; }
		public int MissionGroupId { get; set; }
		public int MissionId { get; set; }
		public int MissionType { get; set; }
		public int ReceiveCount { get; set; }
	}

	public class UserModel
	{
		public UserMainModel UserMainMaster { get; set; }
		public string UserCd { get; set; }
		public string UserName { get; set; }
		public string UserNameTextId { get; set; }
		public int UserNameStatus { get; set; }
		public int Level { get; set; }
		public UserGemModel Gem { get; set; }
		public int FreeGem { get; set; }
		public int PaidGem { get; set; }
		public int SeVolume { get; set; }
		public int BgmVolume { get; set; }
		public int VoiceVolume { get; set; }
		public int Exp { get; set; }
		public int NextLevelExp { get; set; }
		public double NextLevelExpRate { get; set; }
		public int TotalExp { get; set; }
		public int MaxStamina { get; set; }
		public int MaxBattlePoint { get; set; }
		public int ItemMaxCount { get; set; }
		public string SystemDate { get; set; }
		public string UserText { get; set; }
		public int PlayerType { get; set; }
		public int BattleSpeed { get; set; }
		public int UserMaxLevel { get; set; }
		public int IsBgmMute { get; set; }
		public int IsSeMute { get; set; }
		public int IsVoiceMute { get; set; }
		public int IsSkillAuto { get; set; }
		public int RoomCharacterMaxCount { get; set; }
		public int MaxExpeditionDeck { get; set; }
		public int MaxTowerDeck { get; set; }
		public int MaxCharacterAddBorder { get; set; }
		public int CharacterMaxCount { get; set; }
		public int EquipmentMaxCount { get; set; }
		public int StaminaValue { get; set; }
		public dynamic CurrentStaminaInfo { get; set; }
		public dynamic CurrentBattlePointInfo { get; set; }
		public string RegisterDate { get; set; }
		public int TutorialStep { get; set; }
		public string TutorialEndDate { get; set; }
		public dynamic DesignPattern { get; set; }
	}

	public class UserNoticeModel
	{
		public string NoticeCd { get; set; }
		public int SceneId { get; set; }
		public int TransitionId { get; set; }
		public string Title { get; set; }
		public string Message { get; set; }
		public string FromDate { get; set; }
		public string ToDate { get; set; }
	}

	public class UserOrderPackModel
	{
		public int ShopId { get; set; }
		public int ListId { get; set; }
		public int BoxNo { get; set; }
		public int SelectIndex { get; set; }
		public string SelectDate { get; set; }
		public string DecideDate { get; set; }
	}

	public class UserPictureBookBaseModel
	{
		public int CharacterGroupId { get; set; }
		public int RoomSelectCharacterId { get; set; }
	}

	public class UserPictureBookDetailModel
	{
		public int Friendship { get; set; }
		public int CharacterId { get; set; }
		public int ExceedLimit { get; set; }
	}

	public class UserPrefModel
	{
		public UserPrefModel Pref { get; set; }
	}

	public class UserProgressModel
	{
		public int ProgressType { get; set; }
		public int ProgressGroup { get; set; }
		public int Index { get; set; }
		public int ConditionId { get; set; }
		public string ConditionParam { get; set; }
		public string ReleaseTargetParam { get; set; }
		public int UserNoticeType { get; set; }
		public string UserNoticeText { get; set; }
		public string Description { get; set; }
	}

	public class UserPurchaseHistoryModel
	{
		public int TodayQuantity { get; set; }
		public int TotalQuantity { get; set; }
		public int ShopId { get; set; }
		public int WeeklyQuantity { get; set; }
		public int MonthlyQuantity { get; set; }
		public int ReplenishmentDaysQuantity { get; set; }
		public int ListId { get; set; }
		public string LastPurchaseDate { get; set; }
	}

	public class UserPvPModel
	{
		public int Point { get; set; }
		public int Season { get; set; }
		public string LastUpdateDate { get; set; }
		public int Stamina { get; set; }
		public string LastRecoveryDate { get; set; }
		public int UpdateCount { get; set; }
		public int WinCount { get; set; }
		public int PvpClass { get; set; }
		public int MaxScore { get; set; }
	}

	public class UserQuestModel
	{
		public int IsClearMission2 { get; set; }
		public int IsClearMission3 { get; set; }
		public int IsClearMission1 { get; set; }
		public int StageId { get; set; }
		public int PlayCount { get; set; }
		public int ClearCount { get; set; }
		public string LastPlayDate { get; set; }
		public string LastSkipDate { get; set; }
		public int TodaySkipCount { get; set; }
		public int TodayPlayCount { get; set; }
	}

	public class UserRaceCharacterModel
	{
		public int CharacterId { get; set; }
		public int AddP1 { get; set; }
		public int AddP2 { get; set; }
		public int AddP3 { get; set; }
		public int AddP4 { get; set; }
		public int Stamina { get; set; }
	}

	public class UserRaceSessionModel
	{
		public int Season { get; set; }
		public int Rank { get; set; }
		public int Stamina { get; set; }
		public string LastRaceStartDate { get; set; }
		public string LastRaceEndDate { get; set; }
		public string LastRecoveryDate { get; set; }
	}

	public class UserRaidModel
	{
		public dynamic EntryRaidBattleSessions { get; set; }
		public dynamic PublicRaidBattleSessions { get; set; }
		public List<dynamic> NextRescueEnableDateList { get; set; }
	}

	public class UserRoomLayoutModel
	{
		public int LayoutId { get; set; }
		public string LayoutName { get; set; }
		public List<dynamic> FurnitureList { get; set; }
		public List<CharacterModel> CharacterList { get; set; }
	}

	public class UserRoomModel
	{
		public List<dynamic> FurnitureList { get; set; }
		public List<CharacterModel> CharacterList { get; set; }
	}

	public class UserShopHistoryModel
	{
		public string UserCd { get; set; }
	}

	public class UserSolidEquipmentModel
	{
		public string EquipmentCd { get; set; }
		public int EquipmentId { get; set; }
		public int ExceedLimit { get; set; }
		public int Count { get; set; }
	}

	public class UserSoundModel
	{
		public int SoundId { get; set; }
	}

	public class UserStoryModel
	{
		public int StoryId { get; set; }
		public int IsRead { get; set; }
	}

	public class UserTowerSessionModel
	{
		public string SessionId { get; set; }
		public int TowerSelectCount { get; set; }
		public int TowerSelectMaxCount { get; set; }
		public string TowerSelectDate { get; set; }
		public int AreaId { get; set; }
		public string BattleSessionId { get; set; }
		public int StageId { get; set; }
		public int DeckId { get; set; }
		public int DeckType { get; set; }
		public dynamic ContinueData { get; set; }
	}

	public class UserWarehouseCharacterModel
	{
		public string CharacterCd { get; set; }
		public int CharacterId { get; set; }
		public int ExceedLimit { get; set; }
		public int Count { get; set; }
		public string UpdateDate { get; set; }
	}

	public class UserWarehouseEquipmentModel
	{
		public string EquipmentCd { get; set; }
		public int EquipmentId { get; set; }
		public int ExceedLimit { get; set; }
		public int Count { get; set; }
		public string UpdateDate { get; set; }
	}

	public class UserWarehouseMaterialModel
	{
		public string MaterialCd { get; set; }
		public int MaterialId { get; set; }
		public int Count { get; set; }
		public int Category { get; set; }
		public string UpdateDate { get; set; }
	}

	public class WarehouseCharacterModel
	{
		public dynamic MainMaster { get; set; }
		public int LevelMaster { get; set; }
		public dynamic GroupMaster { get; set; }
		public int Order { get; set; }
		public string CharacterCd { get; set; }
		public int CharacterId { get; set; }
		public int ForceOriginalCharacterId { get; set; }
		public int CharacterGroupId { get; set; }
		public int ExceedLimit { get; set; }
		public int Count { get; set; }
		public int UsableCount { get; set; }
		public string UpdateDate { get; set; }
		public int CharacterType { get; set; }
		public int Attribute { get; set; }
		public int SubAttribute { get; set; }
		public string Name { get; set; }
		public string SkinName { get; set; }
		public string ShortName { get; set; }
		public string Text { get; set; }
		public string ShortText { get; set; }
		public int Rarity { get; set; }
		public int ItemType { get; set; }
		public int SalePrice { get; set; }
		public int Category { get; set; }
		public int WarehouseType { get; set; }
	}

	public class WarehouseEquipmentModel
	{
		public dynamic MainMaster { get; set; }
		public int LevelMaster { get; set; }
		public EquipmentMaterialModel EquipmentMaterialMaster { get; set; }
		public string EquipmentCd { get; set; }
		public int EquipmentGroupId { get; set; }
		public int EquipmentId { get; set; }
		public int ExceedLimit { get; set; }
		public int Count { get; set; }
		public int UsableCount { get; set; }
		public string UpdateDate { get; set; }
		public int Attribute { get; set; }
		public string Name { get; set; }
		public string ShortName { get; set; }
		public string Text { get; set; }
		public int Rarity { get; set; }
		public int ItemType { get; set; }
		public int SalePrice { get; set; }
		public int Category { get; set; }
		public int WarehouseType { get; set; }
		public int AddExp { get; set; }
	}

	public class WarehouseMaterialModel
	{
		public dynamic MainMaster { get; set; }
		public int LevelMaster { get; set; }
		public EquipmentMaterialModel EquipmentMaterialMaster { get; set; }
		public int Order { get; set; }
		public string MaterialCd { get; set; }
		public string CharacterCd { get; set; }
		public string EquipmentCd { get; set; }
		public int MaterialId { get; set; }
		public int CharacterId { get; set; }
		public int EquipmentId { get; set; }
		public int Count { get; set; }
		public int UsableCount { get; set; }
		public int Category { get; set; }
		public string UpdateDate { get; set; }
		public int Attribute { get; set; }
		public int SubAttribute { get; set; }
		public string Name { get; set; }
		public string ShortName { get; set; }
		public string Text { get; set; }
		public int Rarity { get; set; }
		public int ExceedLimit { get; set; }
		public int ItemType { get; set; }
		public int MaterialType { get; set; }
		public int SalePrice { get; set; }
		public int WarehouseType { get; set; }
		public int AddExp { get; set; }
	}

}

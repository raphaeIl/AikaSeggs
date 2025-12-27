using AikaSeggs.Common.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace AikaSeggs.Common
{
	public enum AdvGame_Z_ORDER
	{
		UI_HEADER = 246,
		UI = 247,
		UI_BACK_BUTTON = 248,
		GRAY_BACK = 252,
		POPUP = 253,
		FRONT_PARTICLE = 254,
		LOADING = 255,
		SYSTEM_POPUP = 256,
		BAND = 257,
	}

	public enum AdvLocalData_LOCAL_STORAGE_GET_TYPE
	{
		STRING = 0,
		BOOLEAN = 1,
		INTEGER = 2,
		FLOAT = 3,
	}

	public enum Character_CHARACTER_TYPE
	{
		NORMAL = 1,
		FORTIFY = 2,
		EXCEEDLIMIT = 3,
		SELL = 4,
		SKILL_UP = 5,
		ABILITY_UP = 6,
		ROOM = 9,
		DEFAULT = 10,
		W_UNIT = 20,
	}

	public enum Character_MATERIAL_DATA_TYPE
	{
		CHARACTER = 0,
		WAREHOUSE = 1,
	}

	public enum Character_MATERIAL_CATEGORY
	{
		N = 0,
		R = 1,
		SR = 2,
		SSR = 3,
		SKILL = 4,
		ABILITY = 5,
		SAME = 6,
	}

	public enum Character_EXCEED_LIMIT_MATERIAL_TYPE
	{
		CHARACTER = 0,
		ITEM = 1,
	}

	public enum Character_PROMOTE_TYPE
	{
		STATUS = 0,
		FORTIFY = 1,
		EXCEED_LIMIT = 2,
	}

	public enum Character_TEXT_SCENE_TYPE
	{
		ROOM = 1,
		MYPAGE = 2,
		QUEST = 3,
		MISSION = 4,
		STORY = 5,
		SHOP = 6,
		GACHA = 7,
		PROMOTE = 8,
		BATTLE = 9,
		TITLE = 10,
	}

	public enum CharacterFilter_FILTER_TYPE
	{
		ATTRIBUTE_FIRE = 0,
		ATTRIBUTE_WATER = 1,
		ATTRIBUTE_WIND = 2,
		ATTRIBUTE_THUNDER = 3,
		ATTRIBUTE_LIGHT = 4,
		ATTRIBUTE_DARK = 5,
		RARITY_1 = 6,
		RARITY_2 = 7,
		RARITY_3 = 8,
		RARITY_4 = 9,
		ATTACK_UP = 10,
		ATTACK_DOWN = 11,
		DEFENCE_UP = 12,
		DEFENCE_DOWN = 13,
		SKILL_DAMAGE_UP = 14,
		INCREASE_SKILL_RATE = 15,
		HEAL = 16,
		RECOVERY_POWER_UP = 17,
		REGENERATION = 18,
		HP_CHANGE = 19,
		LOW_HP_ATK_UP = 20,
		LOW_HP_DEF_UP = 21,
		DAMAGE_UP = 22,
		DAMAGE_DOWN = 23,
		DAMAGE_BARRIER = 24,
		POISON = 25,
		PARALYSIS = 26,
		EROSION = 27,
		CONFUSE = 28,
		SEAL_SKILL = 29,
		OTHER_DEBUFF = 30,
		PREVENT_BAD_CONDITION = 31,
		BAD_CONDITION_CHANCE = 32,
		CANCEL_DEBUFF = 33,
		CANCEL_BUFF = 34,
		CRITICAL_CHANCE = 35,
		ATTACK_ONE = 36,
		ATTACK_ALL = 37,
		ATTACK_RANDOM_HIT = 38,
		UNISON_ATTACK = 39,
		ATTACK_TURN_START = 40,
		ATTACK_TURN_END = 41,
		COUNTER = 42,
	}

	public enum CharacterFilter_SELL_FILTER_TYPE
	{
		ATTRIBUTE_FIRE = 0,
		ATTRIBUTE_WATER = 1,
		ATTRIBUTE_WIND = 2,
		ATTRIBUTE_THUNDER = 3,
		ATTRIBUTE_LIGHT = 4,
		ATTRIBUTE_DARK = 5,
		RARITY_1 = 6,
		RARITY_2 = 7,
		RARITY_3 = 8,
		RARITY_4 = 9,
		FORTIFY = 10,
		SELL = 11,
		UNIT = 12,
	}

	public enum CharacterFilter_SKILL_FILTER_TYPE
	{
		ATTRIBUTE_FIRE = 0,
		ATTRIBUTE_WATER = 1,
		ATTRIBUTE_WIND = 2,
		ATTRIBUTE_THUNDER = 3,
		ATTRIBUTE_LIGHT = 4,
		ATTRIBUTE_DARK = 5,
		RARITY_1 = 6,
		RARITY_2 = 7,
		RARITY_3 = 8,
		RARITY_4 = 9,
		SKILL = 10,
		UNIT = 11,
	}

	public enum CharacterFilter_AUTO_DECK_FILTER_TYPE
	{
		ATTRIBUTE_FIRE = 0,
		ATTRIBUTE_WATER = 1,
		ATTRIBUTE_WIND = 2,
		ATTRIBUTE_THUNDER = 3,
		ATTRIBUTE_LIGHT = 4,
		ATTRIBUTE_DARK = 5,
	}

	public enum CharacterFilter_MATERIAL_FILTER_TYPE
	{
		RARITY_1 = 0,
		RARITY_2 = 1,
		RARITY_3 = 2,
		RARITY_4 = 3,
		UNIT = 4,
	}

	public enum CharacterFilter_MATERIAL_CHARACTER_FILTER_TYPE
	{
		RARITY_1 = 0,
		RARITY_2 = 1,
		RARITY_3 = 2,
		RARITY_4 = 3,
	}

	public enum CharacterGroupFilter_FILTER_TYPE
	{
		NAME_A_TO_S = 0,
		NAME_T_TO_H = 1,
		NAME_M_TO_W = 2,
		UNION_A = 3,
		UNION_B = 4,
		UNION_C = 5,
	}

	public enum CharacterSort_SORT_TYPE
	{
		GETTING = 0,
		LEVEL = 1,
		ATTRIBUTE = 2,
		RARE = 3,
		TOTAL = 4,
		HP = 5,
		ATK = 6,
		DEF = 7,
		BOOST = 8,
	}

	public enum DeckSort_CHARACTER_SORT_TYPE
	{
		TOTAL = 0,
		HP = 1,
		ATK = 2,
		DEF = 3,
	}

	public enum DeckSort_EQUIPMENT_SORT_TYPE
	{
		TOTAL = 0,
		HP = 1,
		ATK = 2,
		DEF = 3,
	}

	public enum DeckSort_MEMORIAL_SORT_TYPE
	{
		TOTAL = 0,
		HP = 1,
		ATK = 2,
		DEF = 3,
	}

	public enum Equipment_PROMOTE_TYPE
	{
		STATUS = 0,
		FORTIFY = 1,
		EXCEED_LIMIT = 2,
	}

	public enum Equipment_RARITY
	{
		N = 1,
		R = 2,
		SR = 3,
		SSR = 4,
	}

	public enum Equipment_EFFECT_TYPE
	{
		HP_RATE = 801,
		ATK_RATE = 802,
		DEF_RATE = 803,
	}

	public enum Equipment_ALERT_TYPE
	{
		FORTIFY = 1,
		LIMIT = 2,
		SELL = 3,
		BRING = 4,
	}

	public enum EquipmentFilter_FILTER_TYPE
	{
		ATTRIBUTE_FIRE = 0,
		ATTRIBUTE_WATER = 1,
		ATTRIBUTE_WIND = 2,
		ATTRIBUTE_THUNDER = 3,
		ATTRIBUTE_LIGHT = 4,
		ATTRIBUTE_DARK = 5,
		RARITY_1 = 6,
		RARITY_2 = 7,
		RARITY_3 = 8,
		RARITY_4 = 9,
		MATERIAL = 10,
		EQUIPMENT = 11,
	}

	public enum EquipmentFilter_EQUIP_FILTER_TYPE
	{
		ATTRIBUTE_FIRE = 0,
		ATTRIBUTE_WATER = 1,
		ATTRIBUTE_WIND = 2,
		ATTRIBUTE_THUNDER = 3,
		ATTRIBUTE_LIGHT = 4,
		ATTRIBUTE_DARK = 5,
		RARITY_1 = 6,
		RARITY_2 = 7,
		RARITY_3 = 8,
		RARITY_4 = 9,
	}

	public enum EquipmentFilter_MATERIAL_FILTER_TYPE
	{
		RARITY_1 = 0,
		RARITY_2 = 1,
		RARITY_3 = 2,
		RARITY_4 = 3,
		EQUIPMENT = 4,
	}

	public enum EquipmentFilter_WAREHOUSE_FILTER_TYPE
	{
		ATTRIBUTE_FIRE = 0,
		ATTRIBUTE_WATER = 1,
		ATTRIBUTE_WIND = 2,
		ATTRIBUTE_THUNDER = 3,
		ATTRIBUTE_LIGHT = 4,
		ATTRIBUTE_DARK = 5,
		RARITY_1 = 6,
		RARITY_2 = 7,
		RARITY_3 = 8,
		RARITY_4 = 9,
	}

	public enum EquipmentSort_SORT_TYPE
	{
		GETTING = 0,
		LEVEL = 1,
		ATTRIBUTE = 2,
		RARE = 3,
		TOTAL = 4,
		HP = 5,
		ATK = 6,
		DEF = 7,
	}

	public enum EquipmentSort_WAREHOUSE_SORT_TYPE
	{
		NUMBER = 0,
		ATTRIBUTE = 1,
	}

	public enum Gacha_GACH_POSITION
	{
		GACHA_ICON_RIGHT = 234,
		GACHA_NAME_Y = 187,
	}

	public enum Gacha_GACHA_TYPE
	{
		NORMAL = 1,
		STEP_UP = 2,
		TICKET = 3,
		BOX = 4,
		SELECT_PICK = 6,
	}

	public enum Gacha_BUTTON_TYPE
	{
		NORMAL = 1,
		DAILY = 2,
	}

	public enum Gacha_BANNER_TYPE
	{
		NON = 0,
		LEFT = 1,
		RIGHT = 2,
		STEP_UP = 3,
		MOVIE = 4,
	}

	public enum Gacha_DISCOUNT_TYPE
	{
		DISCOUNT_FIRST = 1,
		DISCOUNT_DAY_FIRST = 2,
		DISCOUNT_LAP = 11,
		DISCOUNT_EVERY_LAP = 12,
	}

	public enum Gacha_RATE_TYPE
	{
		NORMAL_RATE = 0,
		APPEARANCE_RATE = 1,
		LIMITED_RATE = 2,
	}

	public enum Gacha_ADD_LAYOUT_TYPE
	{
		MEMORIAL = 1,
	}

	public enum Gallery_EPISODE_TYPE
	{
		CHARACTER = 1,
		FURNITURE = 2,
		RIVIVE = 3,
		RECOLLECTION = 4,
	}

	public enum Gallery_CHARACTER_GROUP_ID
	{
		ALL = 0,
	}

	public enum Gallery_TUTORIAL
	{
		CHARACTER_GROUP_ID = 1035,
		STORY_ID = 600010003,
	}

	public enum Game_DIRECTION_TYPE
	{
		NONE = 0,
		UP = 1,
		DOWN = 2,
		LEFT = 3,
		RIGHT = 4,
	}

	public enum Game_ATTRIBUTE
	{
		NONE = 0,
		FIRE = 1,
		WATER = 2,
		WIND = 3,
		THUNDER = 4,
		LIGHT = 5,
		DARK = 6,
	}

	public enum Game_RARITY
	{
		N = 1,
		R = 2,
		SR = 3,
		SSR = 4,
	}

	public enum Game_MEMORIAL_RARITY
	{
		N = 1,
		R = 2,
		SR = 3,
		SR_PLUS = 4,
		SSR = 5,
		SSR_PLUS = 6,
		LR = 7,
	}

	public enum Game_UNISON_TYPE
	{
		R = 1,
		B = 2,
		G = 3,
	}

	public enum Game_NATURE
	{
		DORMENT = 1,
		CONCEPTION = 2,
		MINION = 3,
		INDEPENDENCE = 4,
		STILL = 5,
		MARIONETTE = 6,
		PARASITISM = 7,
	}

	public enum Game_UNION
	{
		NONE = 0,
		A = 1,
		B = 2,
		C = 3,
	}

	public enum Game_CHECK_STATE
	{
		NONE = 0,
		SELL = 1,
		PROTECT = 2,
		MATERIAL = 3,
	}

	public enum Game_WORLD_CATEGORY
	{
		NORMAL = 1,
		WEEK = 2,
		TOWER = 3,
		RAID = 4,
		EVENT = 5,
		ATTRIBUTE = 6,
		CHALLENGE = 7,
		TRIAL_EVENT = 10,
	}

	public enum Game_Z_ORDER
	{
		UI_HEADER = 245,
		UI = 246,
		UI_BACK_BUTTON = 247,
		GRAY_BACK = 248,
		SYSTEM_WINDOW = 249,
		POPUP = 250,
		TUTORIAL_SUB_ROOT = 251,
		FRONT_PARTICLE = 252,
		LOADING = 253,
		SYSTEM_POPUP = 254,
		BAND = 255,
	}

	public enum Game_BOOST_TYPE
	{
		USER_EXP = 1,
		QUEST_UNLOCK = 2,
		QUEST_LIMITED_UNLOCK = 3,
		QUEST_COUNT_BOOST = 4,
		SHOP_LIMITED_UNLOCK = 5,
		SHOP_ITEM_LIMITED_UNLOCK = 6,
	}

	public enum Game_QUEST_TYPE
	{
		WORLD = 1,
		AREA = 2,
		STAGE = 3,
	}

	public enum Game_DROP_TYPE
	{
		NORMAL = 0,
		LIMITED = 1,
		ADDITIONAL_WAVE = 2,
	}

	public enum Game_NORMAL
	{
		NORMAL = 1,
		HARD = 2,
		EX = 3,
		FRIENDSHIP = 9,
		DAILY_LIMIT = 10,
		VS = 11,
		BOSS = 101,
	}

	public enum Game_TOWER
	{
		NORMAL = 1,
		HARD = 2,
		EX = 3,
		EX_2 = 4,
		EX_3 = 5,
		EX_4 = 6,
	}

	public enum Game_EVENT_ADVENT
	{
		EASY = 1,
		NORMAL = 2,
		HARD = 3,
		EXTREME = 4,
		CHALLENGE = 5,
		DAILY_LIMIT = 10,
		BOSS = 101,
	}

	public enum Game_EVENT_EQUIPMENT
	{
		EASY = 1,
		NORMAL = 2,
		HARD = 3,
		EXTREME = 4,
		BOSS = 101,
	}

	public enum Game_QUEST_TEXT_GROUP
	{
		NORMAL = 0,
		WEEK = 1,
		EVENT_SELECT = 2,
	}

	public enum Game_QUEST_ICON_TYPE
	{
		WEEK = 1,
	}

	public enum Game_CAMPAIGN_TARGET_TYPE
	{
		WORLD = 1,
		AREA = 2,
		STAGE = 3,
	}

	public enum Game_UNLOCK_TYPE
	{
		FREE = 1,
		GEM = 2,
		ITEM = 3,
	}

	public enum Game_LOCK_STATE
	{
		LOCK = 1,
		FREE_LOCK = 2,
		WEEK_UNLOCK = 3,
		BOOST_UNLOCK = 4,
	}

	public enum Game_PRESENT_CATEGORY
	{
		UNIT = 1,
		EQUIPMENT = 2,
		ITEM = 3,
		OTHER = 4,
	}

	public enum Game_LOADING_TYPE
	{
		COVER = 1,
		CHARACTER = 2,
		TIPS = 3,
	}

	public enum Game_LOGIN_BONUS_TYPE
	{
		NORMAL = 1,
		SPECIAL = 2,
	}

	public enum Game_RESULT_RIBBON_ANIM_IDX
	{
		FORTIFY_NORMAL = 0,
		FORTIFY_GREAT = 1,
		EXCEED_EQUIP = 2,
		EXCEED_CHARACTER = 3,
		FORTIFY_FAILURE = 4,
		RARITYUP_COMPLETE = 5,
		UPDATE_TRIAL_DAMAGE = 6,
	}

	public enum Game_INSPECTION_TYPE
	{
		GET = 0,
		UPDATE = 1,
	}

	public enum Game_OPEN_CONDITION_TYPE
	{
		NON = 0,
		RANK = 1,
		REGISTER_DATE = 2,
		QUEST_FIRST_CLEAR = 3,
		COMEBACK_IGNITE_MINUTES = 4,
		TRIAL = 5,
	}

	public enum Game_ADULT_TYPE
	{
		NORMAL = 0,
		ADULT = 1,
		LIGHT_NORMAL = 2,
		LIGHT_ADULT = 3,
	}

	public enum Game_LOGIN_PACK_RECEIVE_TYPE
	{
		PURCHASE_PERIOD = 1,
		TOTAL_LOGIN_DAYS = 2,
	}

	public enum Game_FILTER_TYPE
	{
		CHARACTER = 0,
		EQUIPMENT = 1,
		MEMORIAL = 2,
	}

	public enum Game_MEMORIAL_TYPE
	{
		BACKGROUND = 1,
		CHARACTER = 2,
	}

	public enum Game_DISPLAY_TYPE
	{
		CHARACTER = 0,
		MEMORIAL = 1,
		SPECIAL_ROOM = 2,
	}

	public enum Item_ITEM_CATEGORY
	{
		NONE = 0,
		RECIPE = 1,
		EQUIPMENT = 2,
		MATERIAL = 3,
		CONSUME = 4,
	}

	public enum Item_ITEM_TYPE
	{
		DMM_POINT = 100,
		FREE_GEM = 101,
		PAID_GEM = 102,
		ONLY_FREE_GEM = 103,
		GOLD = 201,
		GACHA_POINT = 202,
		LOTTERY_TICKET = 211,
		WINNING_TICKET = 212,
		EQUIPMENT_FORTIFY_MATERIAL = 301,
		EQUIPMENT_RECIPE = 302,
		EQUIPMENT_EXCEED_LIMIT_MATERIAL = 303,
		MEMORIAL_PIECE = 311,
		CHARA_POSSESSION_BORDER = 401,
		EQUIPMENT_POSSESSION_BORDER = 402,
		LOGIN_PACK = 411,
		GIFT_FROM = 501,
		GIFT_TO = 599,
		CHARACTER_EXCEED_LIMIT_MATERIAL = 601,
		CHARACTER_ABILITY_MATERIAL = 602,
		CHARACTER_AWAKE_MATERIAL = 603,
		RACE_PROMOTE_ITEM = 611,
		AP_RECOVERY = 701,
		KEY = 711,
		QUEST_COUNT_BOOST = 713,
		SKIP_TICKET = 721,
		LIMITED_SKIP_TICKET = 722,
		SELECT_TICKET = 731,
		UNIQUE_SELECT_TICKET = 732,
		MAX_FORTIFY_SELECT_TICKET = 733,
		RELEASE_RACE_SD = 734,
		SPECIAL_ROOM_SELECT_TICKET = 735,
		RELEASE_STORY_TICKET = 741,
		RELEASE_STORY_LIMITED_TICKET = 742,
		RELEASE_ALTER_CHARACTER_STORY_LIMITED_TICKET = 743,
		RELEASE_STORY_UNSALEABLE = 744,
		GACHA_TICKET = 781,
		ANOTHER_GACHA_TICKET = 782,
		SET_ITEM = 791,
		USABLE_SET_ITEM = 792,
		USABLE_MAX_FORTIFY_SET_ITEM = 793,
		EXCHANGE_POINT = 801,
		FRIENDSHIP_POINT = 802,
		VOTE_POINT = 811,
		RELEASE_SET = 900,
		CHARACTER = 910,
		EQUIPMENT = 911,
		RACE_CHARACTER = 912,
		STORY = 913,
		MEMORIAL = 914,
		SPECIAL_ROOM = 915,
		FURNITURE = 961,
		BGM = 971,
		AP = 991,
		TRIAL_ACCUMULATION_DAMAGE = 803,
		TRIAL_MAX_DAMAGE = 804,
	}

	public enum Item_GIFT_ITEM_FAVORITE_ADD_TYPE
	{
		RATE = 1,
		ADD = 2,
		OVERWRITE = 3,
	}

	public enum Item_EQUIPMENT_BOOST_TYPE
	{
		NORMAL = 0,
		BOOST = 1,
	}

	public enum Item_GEM_ITEM_ID
	{
		FREE = 101001,
		PAID = 102001,
	}

	public enum Item_SHOP_TAB
	{
		CAMPAIGN = 0,
		GEM = 1,
		SET = 2,
		NORMAL = 3,
		BOX = 4,
		SPOT_ARRIVAL = 5,
		STEP = 6,
		TRIAL = 7,
	}

	public enum Item_SHOP_CATEGORY
	{
		CAMPAIGN = 1,
		GEM = 2,
		SET = 3,
		NORMAL = 4,
		BOX = 5,
		SPOT_ARRIVAL = 6,
		VIP = 7,
		STEP = 8,
		TRIAL = 9,
		OUTSIDE = 99,
	}

	public enum Item_WAREHOUSE_TAB
	{
		CONSUME = 0,
		GIFT = 1,
		EQUIPMENT = 2,
		CHARACTER_STORAGE = 3,
		EQUIPMENT_STORAGE = 4,
		MATERIAL_STORAGE = 5,
		OTHER = 6,
	}

	public enum LocalData_LOCAL_STORAGE_GET_TYPE
	{
		STRING = 0,
		BOOLEAN = 1,
		INTEGER = 2,
		FLOAT = 3,
	}

	public enum LocalData_CHARACTER_RESOURCE_TYPE
	{
		SPRITE = 1,
		SD_SPINE = 2,
	}

	public enum Memorial_BOOST_TYPE
	{
		NONE = 0,
		NORMAL = 1,
		BOOST = 2,
	}

	public enum Memorial_RARITY
	{
		N = 1,
		R = 2,
		SR = 3,
		SR_PLUS = 4,
		SSR = 5,
		SSR_PLUS = 6,
		LR = 7,
	}

	public enum Memorial_RING_RARITY
	{
		N = 1,
		R = 2,
		SR = 3,
		SSR = 4,
		LR = 5,
	}

	public enum MemorialFilter_FILTER_TYPE
	{
		UNISON_1 = 0,
		UNISON_2 = 1,
		UNISON_3 = 2,
		MEMORIALTYPE_1 = 3,
		MEMORIALTYPE_2 = 4,
		ATTACK_UP = 5,
		ATTACK_DOWN = 6,
		DEFENCE_UP = 7,
		DEFENCE_DOWN = 8,
		SKILL_DAMAGE_UP = 9,
		INCREASE_SKILL_RATE = 10,
		HEAL = 11,
		RECOVERY_POWER_UP = 12,
		REGENERATION = 13,
		HP_CHANGE = 14,
		LOW_HP_ATK_UP = 15,
		LOW_HP_DEF_UP = 16,
		DAMAGE_UP = 17,
		DAMAGE_DOWN = 18,
		DAMAGE_BARRIER = 19,
		POISON = 20,
		PARALYSIS = 21,
		EROSION = 22,
		CONFUSE = 23,
		SEAL_SKILL = 24,
		OTHER_DEBUFF = 25,
		PREVENT_BAD_CONDITION = 26,
		BAD_CONDITION_CHANCE = 27,
		CANCEL_DEBUFF = 28,
		CANCEL_BUFF = 29,
		CRITICAL_CHANCE = 30,
		ATTACK_ONE = 31,
		ATTACK_ALL = 32,
		ATTACK_RANDOM_HIT = 33,
		UNISON_ATTACK = 34,
	}

	public enum MemorialFilter_AUTO_DECK_FILTER_TYPE
	{
		ATTRIBUTE_1 = 0,
		ATTRIBUTE_2 = 1,
		ATTRIBUTE_3 = 2,
	}

	public enum MemorialSort_SORT_TYPE
	{
		NUMBER = 0,
		LEVEL = 1,
		RARE = 2,
		TOTAL = 3,
		HP = 4,
		ATK = 5,
		DEF = 6,
		UNISON = 7,
	}

	public enum PictureBookDetailFilter_FILTER_TYPE
	{
		ATTRIBUTE_FIRE = 0,
		ATTRIBUTE_WATER = 1,
		ATTRIBUTE_THUNDER = 2,
		ATTRIBUTE_WIND = 3,
		ATTRIBUTE_DARK = 4,
		ATTRIBUTE_LIGHT = 5,
		RARITY_1 = 6,
		RARITY_2 = 7,
		RARITY_3 = 8,
		RARITY_4 = 9,
	}

	public enum PictureBookDetailSort_SORT_TYPE
	{
		GETTING = 0,
		ATTRIBUTE = 1,
		RARE = 2,
		FRIENDSHIP = 3,
	}

	public enum Present_FILTER_IDX
	{
		UNIT = 0,
		EQUIPMENT = 1,
		ITEM = 2,
		OTHER = 3,
		HAS_PERIOD = 4,
		NO_PERIOD = 5,
	}

	public enum Present_FILTER_SUB_IDX
	{
		UNIT_MATERIAL = 0,
		UNIT_RARITY_SSR = 1,
		UNIT_RARITY_SR = 2,
		UNIT_RARITY_R = 3,
		UNIT_RARITY_N = 4,
		EQUIPMENT_MATERIAL = 5,
		EQUIPMENT_RARITY_SSR = 6,
		EQUIPMENT_RARITY_SR = 7,
		EQUIPMENT_RARITY_R = 8,
		EQUIPMENT_RARITY_N = 9,
		GEM = 10,
		GACHA_EXCHANGE_ITEM = 11,
		IS_INCLUDE_BOX = 12,
	}

	public enum Present_RECEIVE_TYPE
	{
		HOLDING = 0,
		WAREHOUSE = 1,
	}

	public enum Questionnaire_QUESTIONNAIRE_INPUT_TYPE
	{
		TEXT = 1,
		RADIO = 2,
	}

	public enum Room_FURNITURE_CATEGORY
	{
		DEFAULT = 0,
		SPECIAL = 9,
	}

	public enum Room_MAP_CATEGORY
	{
		INTERIOR = 1,
		FLOOR = 2,
		FURNITURE_1 = 3,
		FURNITURE_2 = 4,
		WALL_1 = 5,
		WALL_2 = 6,
	}

	public enum Room_IDX_CATEGORY
	{
		INTERIOR = 0,
		FLOOR = 1,
		FURNITURE_1 = 2,
		FURNITURE_2 = 3,
		WALL_1 = 4,
		WALL_2 = 5,
	}

	public enum Room_FURNITURE_SELECT_TYPE
	{
		EDIT = 0,
		SHOP = 1,
	}

	public enum Room_ROOM_CHARACTER_DETAIL_TOP_TAB
	{
		SINGLE = 0,
		LIST = 1,
	}

	public enum Room_ROOM_CARD_DETAIL_TOP_TAB
	{
		CONTENT = 0,
		FRIENDSHIP = 1,
	}

	public enum Room_ROOM_PICTURE_BOOK_DETAIL_TOP_TAB
	{
		FRIENDSHIP = 0,
		SCENARIO = 1,
	}

	public enum Room_ROOM_PICTURE_BOOK_DETAIL_SCENARIO_TAB
	{
		CHARACTER_SCENARIO = 0,
		VOICE_SCENARIO = 1,
		VOICE = 2,
	}

	public enum Room_ROOM_CONTENTS_TYPE
	{
		NONE = 0,
		VOICE_SCENARIO = 1,
		NORMAL_SCENARIO = 2,
		ADULT_SCENARIO = 3,
		ROOM_SCENARIO = 9,
	}

	public enum Room_RELEASE_CONDITION_TYPE
	{
		NON = 0,
		FRIENDSHIP = 1,
		EXCEEDLIMIT = 2,
		STORY = 3,
		STAGE = 4,
		ITEM = 5,
	}

	public enum Room_ROOM_INIT_FURNITURE_ID
	{
		INTERIOR = 1,
		FLOOR = 2,
	}

	public enum Story_STORY_PLAY_TYPE
	{
		BATTLE_START = 1,
		BATTLE_END = 2,
		RW = 3,
		RW_BATTLE_START = 4,
		RW_BATTLE_END = 5,
	}

	public enum Story_STORY_TEXT_GROUP
	{
		CATEGORY = 0,
		WORLD = 1,
		AREA = 2,
		STAGE = 3,
		EVENT = 4,
		SCENARIO = 5,
	}

	public enum Story_STORY_CATEGORY
	{
		MAIN = 1,
		EVENT = 2,
		OTHER = 3,
		ROOM = 4,
		PICTURE_BOOK = 5,
		TUTORIAL = 6,
		GACHA = 7,
		MEMORIAL = 8,
		RECOLLECTION = 9,
		MEMORIAL_EVENT_OTHER = 10,
	}

	public enum Story_STORY_GROUP_ROOM
	{
		NORMAL = 401,
		ADULT = 402,
		OTHER = 9,
	}

	public enum Story_STORY_GROUP_PICTURE_BOOK
	{
		BASE = 501,
		DETAIL = 502,
		VOICE = 503,
	}

	public enum Story_STORY_GROUP_GACHA
	{
		SAMPLE_CHARACTER = 70,
		SAMPLE_MEMORIAL = 80,
		OTHER = 7,
	}

	public enum Warehouse_TAB_CATEGORY
	{
		CONSUMEITEM = 0,
		MATERIAL = 1,
		EQUIPMENT = 2,
		RECIPE = 3,
	}

	public enum Warehouse_TAB_INDEX
	{
		CONSUMPTION_ITEM = 0,
		GIFT = 1,
		EQUIPMENT = 2,
		UNIT_WAREHOUSE = 3,
		EQUIPMENT_WAREHOUSE = 4,
		MATERIAL_WAREHOUSE = 5,
		OTHERS = 6,
	}

	public enum Warehouse_WAREHOUSE_STORAGE_TYPE
	{
		CHARACTER = 1,
		EQUIPMENT = 2,
		MATERIAL = 3,
	}

	public enum Warehouse_MATERIAL_CATEGORY
	{
		CHARACTER = 1,
		EQUIPMENT = 2,
	}

	public enum Warehouse_WAREHOUSE_STORAGE_CHARACTER_FILTER_TYPE
	{
		ATTRIBUTE_FIRE = 0,
		ATTRIBUTE_WATER = 1,
		ATTRIBUTE_WIND = 2,
		ATTRIBUTE_THUNDER = 3,
		ATTRIBUTE_LIGHT = 4,
		ATTRIBUTE_DARK = 5,
		RARITY_1 = 6,
		RARITY_2 = 7,
		RARITY_3 = 8,
		RARITY_4 = 9,
	}

	public enum Warehouse_WAREHOUSE_STORAGE_EQUIPMENT_FILTER_TYPE
	{
		ATTRIBUTE_FIRE = 0,
		ATTRIBUTE_WATER = 1,
		ATTRIBUTE_WIND = 2,
		ATTRIBUTE_THUNDER = 3,
		ATTRIBUTE_LIGHT = 4,
		ATTRIBUTE_DARK = 5,
		RARITY_1 = 6,
		RARITY_2 = 7,
		RARITY_3 = 8,
		RARITY_4 = 9,
	}

	public enum Warehouse_WAREHOUSE_FILTER_TYPE
	{
		ATTRIBUTE_FIRE = 0,
		ATTRIBUTE_WATER = 1,
		ATTRIBUTE_WIND = 2,
		ATTRIBUTE_THUNDER = 3,
		ATTRIBUTE_LIGHT = 4,
		ATTRIBUTE_DARK = 5,
		RARITY_1 = 6,
		RARITY_2 = 7,
		RARITY_3 = 8,
		RARITY_4 = 9,
		CATEGORY_CHARACTER = 10,
		CATEGORY_EQUIPMENT = 11,
	}

	public enum Warehouse_WAREHOUSE_OTHER_ITEM_FILTER_TYPE
	{
		CHARACTER_EXCEED_LIMIT_MATERIAL = 0,
		CHARACTER_ABILITY_MATERIAL = 1,
		CHARACTER_AWAKE_MATERIAL = 2,
		OTHER = 3,
	}

	public enum Warehouse_WAREHOUSE_STORAGE_CHARACTER_SORT_TYPE
	{
		UPDATING = 0,
		NUMBER = 1,
		ATTRIBUTE = 2,
		RARITY = 3,
	}

	public enum Warehouse_WAREHOUSE_STORAGE_EQUIPMENT_SORT_TYPE
	{
		UPDATING = 0,
		NUMBER = 1,
		ATTRIBUTE = 2,
		RARITY = 3,
	}

	public enum Warehouse_WAREHOUSE_STORAGE_SORT_TYPE
	{
		UPDATING = 0,
		NUMBER = 1,
		ATTRIBUTE = 2,
		RARITY = 3,
	}

	public enum Warehouse_WAREHOUSE_OTHER_ITEM_SORT_TYPE
	{
		NUMBER = 0,
	}

}

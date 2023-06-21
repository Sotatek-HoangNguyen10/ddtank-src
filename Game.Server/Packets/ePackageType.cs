namespace Game.Server.Packets
{
    public enum ePackageType
    {
        LABYRINTH = 131,
        ITEM_ADVANCE = 138,
        USE_CHANGE_SEX = 252,
        OPTION_CHANGE = 158,
        PET = 68,
        INVITE_FRIEND = 107,
        FIRSTRECHARGE = 259,
        NOVICEACTIVITY = 258,
        VIP_LEVELUP_AWARDS = 8,
        GOTO_CARD_LOTTERY = 239,
        CAN_CARD_LOTTERY = 93,
        LOTTERY_AWARD = 251,
        LUCK_LOTTERY = 105,
        CARD_LOTTERY = 104,
        UPDATE_SHOP = 109,
        WISHBEADEQUIP = 106,
        LEFT_GUN_ROULETTE_COMPLETTE = 130,
        LEFT_GUN_ROULETTE_SOCKET = 128,
        LEFT_GUN_ROULETTE_START = 163,
        LEFT_GUN_ROULETTE = 137,
        ELITEGAME = 162,
        PICC = 30,
        FARM = 81,
        OPEN_ALL_CARDBOX = 204,
        LITTLEGAME_ACTIVED = 80,
        IM_CMD = 160,
        TEXP = 99,
        GOODS_EXCHANGE = 0x1F,
        COLLECTINFO = 0x20,
        DAILYRECORD = 103,
        FRIEND_BRITHDAY = 223,
        CHAT_FILTERING_FRIENDS_SHARE = 17,
        GET_PLAYER_CARD = 18,
        OPTION_UPDATE = 0x40,
        CARD_RESET = 196,
        CARDS_DATA = 216,
        PROP_USE = 66,
        LEAGUE_START_NOTICE = 42,
        SYSTEM_LUCKYNUM = 47,
        USER_LUCKYNUM = 161,
        WEEKLY_CLICK_CNT = 219,
        USER_ANSWER = 0xF,
        BAG_LOCKED = 25,
        MARRY_ROOM_CREATE = 241,
        MARRY_ROOM_LOGIN = 242,
        MARRY_SCENE_LOGIN = 240,
        PLAYER_ENTER_MARRY_ROOM = 243,
        PLAYER_EXIT_MARRY_ROOM = 244,
        MARRY_APPLY = 247,
        MARRY_APPLY_REPLY = 250,
        DIVORCE_APPLY = 248,
        MARRY_STATUS = 246,
        SCENE_STATE = 251,
        QQTIPS_GET_INFO = 99,
        EDICTUM_GET_SERVION = 75,
        MARRY_ROOM_STATE = 252,
        MARRY_ROOM_INFO_UPDATE = 253,
        MARRYPROP_GET = 234,
        MARRY_ROOM_UPDATE = 0xFF,
        MARRY_ROOM_DISPOSE = 254,
        MARRY_CMD = 249,
        CHURCH_MOVIE_OVER = 167,
        MARRY_SCENE_CHANGE = 233,
        CLIENT_LOG = 8,
        SCENE_CHAT = 19,
        SCENE_FACE = 20,
        SCENE_CHANNEL_CHANGE = 24,
        CHANGE_STATE = 0x20,
        CHANGE_NICKNAME = 33,
        AC_ACTION = 35,
        SYNCH_ACTION = 36,
        CHAT_PERSONAL = 37,
        UPDATE_PRIVATE_INFO = 38,
        UPDATE_HOTPOINT = 39,
        GET_DYNAMIC = 39,
        SNS_MSG_RECEIVE = 40,
        SAVE_STYLE = 41,
        DELETE_GOODS = 42,
        CONSORTIA_MAIL_MESSAGE = 43,
        ROOM_SAVE_OBJECT = 0x80,
        GAME_VISITOR_DATA = 224,
        LOGIN = 1,
        DAILY_AWARD = 13,
        GET_SIGNAWARD = 90,
        GAME_ROOM = 94,
        SCENE_ADD_USER = 18,
        KIT_USER = 2,
        SCENE_LOGIN = 0x10,
        GAME_CMD = 91,
        GAME_CHANGE_MAP = 104,
        SCENE_REMOVE_USER = 21,
        CHANGE_PLACE_GOODS = 49,
        REClAIM_GOODS = 127,
        CHANGE_PLACE_GOODS_ALL = 124,
        SEll_GOODS = 48,
        USER_RANK = 34,
        FIGHT_NPC = 50,
        UPDATE_GOODS = 51,
        UPDATE_COUPONS = 46,
        ITEM_STORE = 79,
        BUY_GOODS = 44,
        BUY_QUICK_GOLDBOX = 126,
        BUY_GIFTBAG = 46,
        CHAIN_EQUIP = 52,
        UNCHAIN_EQUIP = 47,
        REPAIR_GOODS = 53,
        DELETE_MAIL = 112,
        GET_MAIL_ATTACHMENT = 113,
        UPDATE_MAIL = 114,
        UPDATE_NEW_MAIL = 115,
        SEND_MAIL = 116,
        MAIL_RESPONSE = 117,
        MAIL_CANCEL = 118,
        PROP_BUY = 54,
        PROP_SELL = 55,
        PROP_CHAIN = 56,
        GOODS_PRESENT = 57,
        GOODS_COUNT = 168,
        GRID_GOODS = 64,
        GRID_PROP = 65,
        UPDATE_PLAYER_INFO = 67,
        GAME_TAKE_OUT = 106,
        EQUIP_CHANGE = 66,
        PING = 4,
        NETWORK = 6,
        GAME_TAKE_TEMP = 108,
        RSAKEY = 7,
        SYS_MESSAGE = 3,
        ITEM_COMPOSE = 58,
        ITEM_STRENGTHEN = 59,
        ITEM_TRANSFER = 61,
        GAME_CAPTAIN_CHOICE = 110,
        GAME_CAPTAIN_AFFIRM = 111,
        SCENE_USERS_LIST = 69,
        GAME_INVITE = 70,
        S_BUGLE = 71,
        B_BUGLE = 72,
        C_BUGLE = 73,
        DEFY_AFFICHE = 123,
        ITEM_HIDE = 60,
        ITEM_OBTAIN = 73,
        QUEST_ADD = 176,
        QUEST_REMOVE = 177,
        QUEST_UPDATE = 178,
        QUEST_FINISH = 179,
        QUSET_OBTAIN = 180,
        QUEST_CHECK = 181,
        ITEM_CONTINUE = 62,
        SYS_DATE = 5,
        ITEM_EQUIP = 74,
        MATE_ONLINE_TIME = 85,
        SYS_NOTICE = 10,
        ITEM_OPENUP = 0x3F,
        ACTIVE_PULLDOWN = 11,
        EDITION_ERROR = 12,
        ITEM_FUSION = 78,
        EQUIP_RECYCLE_ITEM = 222,
        ITEM_FUSION_PREVIEW = 76,
        ITEM_REFINERY = 110,
        ITEM_REFINERY_PREVIEW = 111,
        ITEM_INLAY = 121,
        ITEM_EMBED_BACKOUT = 125,
        OPEN_FIVE_SIX_HOLE = 217,
        ITEM_TREND = 120,
        CLEAR_STORE_BAG = 122,
        ITEM_OVERDUE = 77,
        AUCTION_ADD = 192,
        AUCTION_UPDATE = 193,
        AUCTION_DELETE = 194,
        AUCTION_REFRESH = 195,
        CHECK_CODE = 200,
        CONSORTIA_CMD = 129,
        CONSORTIA_RESPONSE = 0x80,
        CID_CHECK = 224,
        ENTHRALL_LIGHT = 227,
        ENTHRALL_SWITCH = 225,
        CID_INFO_VALID = 226,
        BUFF_INFO = 0,
        USE_COLOR_CARD = 182,
        CARD_USE = 183,
        USE_CHANGE_COLOR_SHELL = 205,
        CHANGE_COLOR_OVER_DUE = 206,
        USE_REWORK_NAME = 171,
        USE_CONSORTIA_REWORK_NAME = 188,
        BUFF_ADD = 184,
        BUFF_UPDATE = 185,
        BUFF_OBTAIN = 186,
        MARRYINFO_GET = 235,
        MARRYINFO_ADD = 236,
        MARRYINFO_UPDATE = 237,
        MARRYINFO_DELETE = 238,
        AMARRYINFO_REFRESH = 239,
        LINKREQUEST_GOODS = 119,
        GET_ITEM_MESS = 14,
        SAVE_DB = 172,
        LITTLEGAME_COMMAND = 166,
        HOTSPRING_CMD = 191,
        HOTSPRING_CMD_B = 12,
        HOTSPRING_ENTER = 187,
        HOTSPRING_ROOM_CREATE = 175,
        HOTSPRING_ROOM_REMOVE = 174,
        HOTSPRING_ROOM_ADD_OR_UPDATE = 173,
        HOTSPRING_ROOM_LIST_GET = 197,
        HOTSPRING_ROOM_QUICK_ENTER = 190,
        HOTSPRING_ROOM_ENTER = 202,
        HOTSPRING_ROOM_ENTER_VIEW = 201,
        HOTSPRING_ROOM_PLAYER_ADD = 198,
        HOTSPRING_ROOM_PLAYER_REMOVE = 169,
        HOTSPRING_ROOM_PLAYER_REMOVE_NOTICE = 199,
        HOTSPRING_ROOM_ENTER_CONFIRM = 212,
        GET_TIME_BOX = 53,
        ACHIEVEMENT_FINISH = 230,
        ACHIEVEMENT_UPDATE = 229,
        ACHIEVEMENT_INIT = 228,
        ACHIEVEMENTDATA_INIT = 231,
        USER_CHANGE_RANK = 189,
        LOOKUP_EFFORT = 203,
        LOTTERY_OPEN_BOX = 26,
        LOTTERY_RANDOM_SELECT = 27,
        LOTTERY_FINISH = 28,
        LOTTERY_ALTERNATE_LIST = 29,
        LOTTERY_GET_ITEM = 30,
        CADDY_SELL_ALL_GOODS = 232,
        CADDY_GET_AWARDS = 245,
        CADDY_GET_BADLUCK = 45,
        FEEDBACK_REPLY = 213,
        QUESTION_REPLY = 89,
        ANSWERBOX_QUESTIN = 0x1F,
        REQUEST_UPDATE = 225,
        VIP_RENEWAL = 92,
        USE_LOG = 213,
        LOAD_RESOURCE = 223,
        USER_GET_GIFTS = 218,
        USER_SEND_GIFTS = 221,
        USER_UPDATE_GIFT = 220,
        USER_RELOAD_GIFT = 214,
        NEWCHICKENBOX_SYS = 87,
        WORLDBOSS_CMD = 102,
        RING_STATION = 404,
        ACTIVITY_PACKAGE = 84,
        LATENT_ENERGY = 133,
        FIGHT_SPIRIT = 209,
        LIGHTROAD_SYSTEM = 145,
        ACCUMULATIVELOGIN_AWARD = 338,
        AVATAR_COLLECTION = 402,
        ACTIVITY_SYSTEM = 145,
        BAGLOCK_PWD = 403,
        TOTEM = 136,
        NECKLACE_STRENGTH = 95,
        HONOR_UP_COUNT = 96,
        NEWTITLE_CARD = 265,
    }
}

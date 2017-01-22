using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class World
    {
        public static readonly List<Item> Items = new List<Item>();
        public static readonly List<Monster> Monsters = new List<Monster>();
        public static readonly List<Quest> Quests = new List<Quest>();
        public static readonly List<Location> Locations = new List<Location>();

        /* EQUIPMENT 0-100 */
        public const int ITEM_ID_WOODEN_SWORD = 1;
        public const int ITEM_ID_IRON_SWORD = 2;
        public const int ITEM_ID_STEEL_SWORD = 3;
        public const int ITEM_ID_ORCISH_SWORD = 4;
        public const int ITEM_ID_DWARVEN_SWORD = 5;
        public const int ITEM_ID_ELVEN_SWORD = 6;
        public const int ITEM_ID_NORDIC_SWORD = 7;
        public const int ITEM_ID_GLASS_SWORD = 8;
        public const int ITEM_ID_EBONY_SWORD = 9;
        public const int ITEM_ID_STALHRIM_SWORD = 10;
        public const int ITEM_ID_DAEDRIC_SWORD = 11;
        public const int ITEM_ID_DRAGONBONE_SWORD = 12;
        /* Drop 100-200 */
        public const int ITEM_ID_ABECEAN_LONG_FIN = 101; //р
        public const int ITEM_ID_CRIMSON_NIRN_ROOT = 102; //т
        public const int ITEM_ID_WHITE_CAP = 103; //г
        public const int ITEM_ID_IMP_STOOL = 104; //г
        public const int ITEM_ID_RIVER_BETTY = 105; //р
        public const int ITEM_ID_SWAMP_FUNGAL_POD = 106; //г
        public const int ITEM_ID_LARGE_ANTLERS = 107; //ж
        public const int ITEM_ID_HANGING_MOSS = 108; //г мох
        public const int ITEM_ID_BRIAR_HEART = 109; //ж
        public const int ITEM_ID_THISTLE_BRANCH = 110; //т
        public const int ITEM_ID_JAZBAY_GRAPES = 111; //т
        public const int ITEM_ID_GIANTLICHEN = 112; //ь
        public const int ITEM_ID_EYE_OF_SABRE_CAT = 113; //ж
        public const int ITEM_ID_NAMIRAS_ROT = 114;//г
        public const int ITEM_ID_BLUE_MOUNTAIN_FLOWER = 115;//т
        public const int ITEM_ID_DWARVEN_OIL = 116;
        public const int ITEM_ID_CHARRED_SKEEVER_HIDE = 117;
        public const int ITEM_ID_PEARL = 118;
        public const int ITEM_ID_SPRIGGAN_SAP = 119;
        public const int ITEM_ID_TROLL_FATT = 120;
        public const int ITEM_ID_ICE_WRAITH_TEETH = 121;
        public const int ITEM_ID_SLAUGHTERFISH_EGG = 122;
        public const int ITEM_ID_NIRNROOT = 123;
        public const int ITEM_ID_RED_MOUNTAIN_FLOWER = 124;
        public const int ITEM_ID_MUDCRAB_CHITIN = 125;
        public const int ITEM_ID_SABRE_CAT_TOOTH = 126;
        public const int ITEM_ID_HAWK_BEAK = 127;
        public const int ITEM_ID_HAGRAVEN_CLAW = 128;
        public const int ITEM_ID_BONEMEAL = 129;
        public const int ITEM_ID_BLEEDINGCROWN = 130;
        /* Animals Peacefull 0-10 */
        public const int MONSTER_ID_GOAT = 1;
        public const int MONSTER_ID_COW = 2;
        public const int MONSTER_ID_CHICKEN = 3;
        public const int MONSTER_ID_HORSE = 4;
        public const int MONSTER_ID_DOG = 5;
        public const int MONSTER_ID_DEAR = 6;
        public const int MONSTER_ID_RABBIT = 7;
        public const int MONSTER_ID_FOX = 8;
        public const int MONSTER_ID_MAMMOTH = 9;
        public const int MONSTER_ID_HAWK = 10;
        /* Animals Aggresive 10-20 */
        public const int MONSTER_ID_WHITE_BEAR = 11;
        public const int MONSTER_ID_HORKER = 12;
        public const int MONSTER_ID_WOLF = 13;
        public const int MONSTER_ID_MUD_CRAB = 14;
        public const int MONSTER_ID_SABRE_CAT = 15;
        public const int MONSTER_ID_SKEEVER = 16;
        public const int MONSTER_ID_BEAR = 17;
        public const int MONSTER_ID_CAVE_BEAR = 18;
        public const int MONSTER_ID_ICE_WOLF = 19;
        public const int MONSTER_ID_SNOWY_SABRE_CAT = 20;
        /* Monsters 20-100 */
        public const int MONSTER_ID_VAMPIRE = 21;
        /* Quest 0-100 */
        public const int QUEST_ID = 1;
        /* Location 0-100 */
        public const int LOCATION_ID = 1;
    }
}

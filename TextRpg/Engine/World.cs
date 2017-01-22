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
        public const int ITEM_ID_BOAR_TUSK = 131;
        /* Animals Peacefull 0-20 */
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
        /* Animals Aggresive 20-40 */
        public const int MONSTER_ID_WHITE_BEAR = 21;
        public const int MONSTER_ID_WILD_BOAR = 22;
        public const int MONSTER_ID_WOLF = 23;
        public const int MONSTER_ID_MUD_CRAB = 24;
        public const int MONSTER_ID_SABRE_CAT = 25;
        public const int MONSTER_ID_SKEEVER = 26;
        public const int MONSTER_ID_BEAR = 27;
        public const int MONSTER_ID_CAVE_BEAR = 28;
        public const int MONSTER_ID_ICE_WOLF = 29;
        public const int MONSTER_ID_SNOWY_SABRE_CAT = 30;
        /* Monsters 40-100 */
        public const int MONSTER_ID_VAMPIRE = 41;
        public const int MONSTER_ID_GIANT = 42;
        public const int MONSTER_ID_HAGRAVEN = 43;
        public const int MONSTER_ID_GARGOYLE = 44;
        public const int MONSTER_ID_DEATH_HOUND = 45;
        public const int MONSTER_ID_DRAGON = 46;
        public const int MONSTER_ID_WISP = 47;
        public const int MONSTER_ID_ICE_WRAITH = 48;
        public const int MONSTER_ID_FROST_GIANT = 49;
        public const int MONSTER_ID_FROST_TROLL = 50;
        public const int MONSTER_ID_MAGIC_ANOMALY = 51;
        public const int MONSTER_ID_WISP_MOTHER = 52;
        public const int MONSTER_ID_WERWOLF = 53;
        public const int MONSTER_ID_SPRIGGAN = 54;
        public const int MONSTER_ID_TROLL = 55;
        public const int MONSTER_ID_SKELETON = 56;
        public const int MONSTER_ID_SPIDER = 57;
        public const int MONSTER_ID_GIANT_SPIDER = 58;
        /* Quest 0-100 */
        public const int QUEST_ID_COWS_COUNTER_ATTACK = 1;
        public const int QUEST_ID_SECRET_MEDECINE_OF_THE_FORREST = 2;
        public const int QUEST_ID_BOARS_GET_WILD = 3;
        /* Location 0-100 */
        public const int LOCATION_ID_LEVEL_1_DEFAULT_CITY = 1;
        public const int LOCATION_ID_LEVEL_1_DARK_FOREST = 2;
        public const int LOCATION_ID_LEVEL_1_HUNTING_GROUNDS = 3;
        public const int LOCATION_ID_LEVEL_1_IRON_KEEP = 4;
        public const int LOCATION_ID_LEVEL_1_FOREST = 5;
        public const int LOCATION_ID_LEVEL_1_TOLBANA = 6;
        public const int LOCATION_ID_LEVEL_1_DUNGEON = 7;

        static World()
        {
            PopulateItems();
            PopulateMonsters();
            PopulateQuests();
            PopulateLocations();
        }
        private static void PopulateItems()
        {
            Items.Add(new Weapon(ITEM_ID_WOODEN_SWORD, "Деревянный меч", "Деревянных мечей", 5));
            Items.Add(new Weapon(ITEM_ID_IRON_SWORD, "Железный меч", "Железных мечей", 8));
            Items.Add(new Weapon(ITEM_ID_STEEL_SWORD, "Стальной меч", "Стальных мечей", 12));
            Items.Add(new Weapon(ITEM_ID_ORCISH_SWORD, "Орочий меч", "Орочьих мечей", 16));
            Items.Add(new Weapon(ITEM_ID_DWARVEN_SWORD, "Двемерский меч", "Двемерских мечей", 19));
        }
        private static void PopulateMonsters()
        {
            Monster wildBoar = new Monster(MONSTER_ID_WILD_BOAR, "Дикий кабан", 2, 27, 30, 10, 10);
            wildBoar.LootTable.Add(new LootItem(ItemByID(ITEM_ID_BOAR_TUSK), 95, false));

            Monsters.Add(wildBoar);
        }
        private static void PopulateQuests()
        {
            Quest boarsGetWild = new Quest(QUEST_ID_BOARS_GET_WILD, "Кабаны сошли с ума", "Кабаны посходили с ума и нападают на странников на дороге, принеси мне 10 бивней и я тебе заплачу", 140, 150,0);
            boarsGetWild.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_BOAR_TUSK), 10));

            Quests.Add(boarsGetWild);
        }
        private static void PopulateLocations()
        {
            Location level1DefaultCity = new Location(LOCATION_ID_LEVEL_1_DEFAULT_CITY, "Стартовый город", "Город расположенный на 1-м этаже Айнкрада. Имеет большое количество дорог, вымощенных камнем, и средневековых улочек, освещенных уличными огнями");
            level1DefaultCity.QuestAvailableHere = QuestByID(QUEST_ID_BOARS_GET_WILD);
            Location level1HuntingGrounds = new Location(LOCATION_ID_LEVEL_1_HUNTING_GROUNDS, "Охотничьи угодья", "Обширная зона охоты для персонажей низкого уровня");
            level1HuntingGrounds.MonsterLivingHere = MonsterByID(MONSTER_ID_WILD_BOAR);

            Locations.Add(level1DefaultCity);
            Locations.Add(level1HuntingGrounds);
        }

        public static Item ItemByID(int id)
        {
            foreach (Item item in Items)
            {
                if (item.ID == id)
                {
                    return item;
                }
            }
            return null;
        }
        public static Monster MonsterByID(int id)
        {
            foreach (Monster monster in Monsters)
            {
                if (monster.ID == id)
                {
                    return monster;
                }
            }
            return null;
        }
        public static Quest QuestByID(int id)
        {
            foreach (Quest quest in Quests)
            {
                if (quest.ID == id)
                {
                    return quest;
                }
            }
            return null;
        }

    }
}

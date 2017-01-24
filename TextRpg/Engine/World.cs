using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Drawing;
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
        #region Health Potion ID
        public const int ITEM_ID_LITTLEHEALTHPOTION = 990;
        public const int ITEM_ID_MEDIUMHEALTPOTION = 991;
        #endregion
        #region Weapon ID
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
        public const int ITEM_ID_TEMPERED_SWORD = 13;
        #endregion
        # region Drop ID
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
        public const int ITEM_ID_NEPENT_LIVER = 132;
        public const int ITEM_ID_COWS_BELL = 133;
        #endregion
        #region Peacefull Animal ID
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
        #endregion
        #region Aggresive Animal ID
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
        #endregion
        #region Monsters ID
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
        public const int MONSTER_ID_LITTLE_NEPENT = 59;
        public const int MONSTER_ID_COW_LEADER = 60;
        #endregion
        #region Quest ID
        /* Quest 0-100 */
        public const int QUEST_ID_COWS_COUNTER_ATTACK = 1;
        public const int QUEST_ID_SECRET_MEDECINE_OF_THE_FORREST = 2;
        public const int QUEST_ID_BOARS_GET_WILD = 3;
        #endregion
        #region Location ID
        /* Location 0-100 */
        public const int LOCATION_ID_LEVEL_1_DEFAULT_CITY = 1;
        public const int LOCATION_ID_LEVEL_1_DARK_FOREST = 2;
        public const int LOCATION_ID_LEVEL_1_HUNTING_GROUNDS = 3;
        public const int LOCATION_ID_LEVEL_1_DEFAULT_CITY_IRON_KEEP = 4;
        public const int LOCATION_ID_LEVEL_1_FOREST = 5;
        public const int LOCATION_ID_LEVEL_1_TOLBANA = 6;
        public const int LOCATION_ID_LEVEL_1_DUNGEON = 7;
        public const int LOCATION_ID_LEVEL_1_DEFAULT_CITY_MARKET = 8;
        public const int LOCATION_ID_LEVEL_1_DEFAULT_CITY_INN = 9;
        public const int LOCATION_ID_LEVEL_1_CHURCH = 10;
        public const int LOCATION_ID_LEVEL_1_MONUMENTOFLIFE = 11;
        public const int LOCATION_ID_LEVEL_1_TOLBANA_CENTRAL_SQUARE = 12;
        public const int LOCATION_ID_LEVEL_1_TOLBANA_INN = 13;
        public const int LOCATION_ID_LEVEL_1_TOLBANA_WEAPONSHOP = 14;
        public const int LOCATION_ID_LEVEL_1_LAKE = 15;
        public const int LOCATION_ID_LEVEL_1_HORUNKA = 16;
        public const int LOCATION_ID_LEVEL_1_HORUNKA_INN = 17;
        public const int LOCATION_ID_LEVEL_1_HORUNKA_SHOP = 18;
        public const int LOCATION_ID_LEVEL_1_HORUNKA_CENTRAL_SQUARE = 19;
        #endregion
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
            Items.Add(new Weapon(ITEM_ID_TEMPERED_SWORD, "Закалённый меч", "Закалённых мечей", 15));
            Items.Add(new Weapon(ITEM_ID_ORCISH_SWORD, "Орочий меч", "Орочьих мечей", 16));
            Items.Add(new Weapon(ITEM_ID_DWARVEN_SWORD, "Двемерский меч", "Двемерских мечей", 19));           

            Items.Add(new Item(ITEM_ID_BOAR_TUSK, "Бивень кабана", "Бивней кабана"));
            Items.Add(new Item(ITEM_ID_NEPENT_LIVER, "Семяпочка малого Непента", "Семяпочки малого Непента"));
            Items.Add(new Item(ITEM_ID_COWS_BELL, "Коровий колокольчик", "Коровьих колокольчика"));

            Items.Add(new HealingPotion(ITEM_ID_LITTLEHEALTHPOTION, "Маленькое лечебное зелье", "Маленьких лечебных зелья", 30));
            Items.Add(new HealingPotion(ITEM_ID_MEDIUMHEALTPOTION, "Среднее лечебное зелье", "Средних лечебных зелий", 100));
        }
        private static void PopulateMonsters()
        {
            Monster wildBoar = new Monster(MONSTER_ID_WILD_BOAR, "Дикий кабан", 2, 27, 10, 10, 10, Properties.Resources.level1WildBoar);
            wildBoar.LootTable.Add(new LootItem(ItemByID(ITEM_ID_BOAR_TUSK), 95, false));
            wildBoar.LootTable.Add(new LootItem(ItemByID(ITEM_ID_LITTLEHEALTHPOTION), 10, false));
            Monsters.Add(wildBoar);
            Monster wildWolf = new Monster(MONSTER_ID_WOLF, "Волк", 3, 30, 20, 15, 15, Properties.Resources.level1wolf);
            Monsters.Add(wildWolf);
            Monster littleNepent = new Monster(MONSTER_ID_LITTLE_NEPENT, "Малый Непент", 5, 40, 30, 25, 25, Properties.Resources.level1Nepent);
            littleNepent.LootTable.Add(new LootItem(ItemByID(ITEM_ID_NEPENT_LIVER), 1, false));
            littleNepent.LootTable.Add(new LootItem(ItemByID(ITEM_ID_LITTLEHEALTHPOTION), 10, false));
            Monsters.Add(littleNepent);
            Monster cowLeader = new Monster(MONSTER_ID_COW_LEADER, "Лидер коров", 7, 40, 40, 35, 35, Properties.Resources.level1cowLeader);
            cowLeader.LootTable.Add(new LootItem(ItemByID(ITEM_ID_COWS_BELL), 50, false));
            cowLeader.LootTable.Add(new LootItem(ItemByID(ITEM_ID_LITTLEHEALTHPOTION), 20, false));
            cowLeader.LootTable.Add(new LootItem(ItemByID(ITEM_ID_MEDIUMHEALTPOTION), 10, false));
            Monsters.Add(cowLeader);
        }
        private static void PopulateQuests()
        {
            Quest boarsGetWild = new Quest(QUEST_ID_BOARS_GET_WILD, "Кабаны сошли с ума", "Кабаны посходили с ума и нападают на странников на дороге, принеси мне 10 бивней и я тебе заплачу.", 140, 150);
            boarsGetWild.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_BOAR_TUSK), 10));
            boarsGetWild.RewardItem = ItemByID(ITEM_ID_IRON_SWORD);
            Quests.Add(boarsGetWild);
            Quest secretMedecineOfTheForrest = new Quest(QUEST_ID_SECRET_MEDECINE_OF_THE_FORREST, "Секретная лесная медицина", "В лесу неподалёку обитают Непенты. Это такое ходячее хищное растение полутораметрового роста, ты их нисчем не перепутаешь. Иногда среди них можно встретить экземпляр с распущенным цветком вот именно он мне и нужен", 550, 800);
            secretMedecineOfTheForrest.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_NEPENT_LIVER), 1));
            secretMedecineOfTheForrest.RewardItem = ItemByID(ITEM_ID_TEMPERED_SWORD);
            Quests.Add(secretMedecineOfTheForrest);
            Quest cowsCounterAttack = new Quest(QUEST_ID_COWS_COUNTER_ATTACK, "Коровые наносят ответный удар", "На нашей ферме у озера произошли странные события, сперва коровы всем скопом куда-то исчезли а после вернулись назад но уже другими. У них появлись своя иерархия, лидеры. Они нападают на фермеров стоит им только приблизиться, эту проблему нужно решать.", 400, 500);
            cowsCounterAttack.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_COWS_BELL), 10));
            cowsCounterAttack.RewardItem = ItemByID(ITEM_ID_STEEL_SWORD);
            Quests.Add(cowsCounterAttack);
        }
        private static void PopulateLocations()
        {
            Location level1DefaultCity = new Location(LOCATION_ID_LEVEL_1_DEFAULT_CITY, "Стартовый город", "Город расположенный на 1-м этаже Айнкрада. Имеет большое количество дорог, вымощенных камнем, и средневековых улочек, освещенных уличными огнями", Properties.Resources.level1DefaultCity);
            Location level1DefaultCityInn = new Location(LOCATION_ID_LEVEL_1_DEFAULT_CITY_INN, "Таверна", "Внутри таверны чисто, уютно и тепло, в очаге жарко горит огонь. На стенах висят гобелены и картины с видами Айнкрада. ", Properties.Resources.level1DefaultCityInn);
            level1DefaultCityInn.QuestAvailableHere = QuestByID(QUEST_ID_BOARS_GET_WILD);
            Location level1DefaulCityMarket = new Location(LOCATION_ID_LEVEL_1_DEFAULT_CITY_MARKET, "Рыночная площадь", "Самая большая торговая площадь в Айнкраде, которая славится тем, что здесь много торговцев, торгующих редкими вещами, порой даже запрещенными. Тут можно найти абсолютно все: от продуктов питания до легендарного оружия с боссов ", Properties.Resources.level1DefaultCityMarket);
            Location level1DefaulCityIronKeep = new Location(LOCATION_ID_LEVEL_1_DEFAULT_CITY_IRON_KEEP, "Железный дворец", "Штаб квартира гильдии Армия освобождения Айнкрада",Properties.Resources.level1IronKeep);
            Location level1MonumentOfLife = new Location(LOCATION_ID_LEVEL_1_MONUMENTOFLIFE, "Монумент жизни", "Крупная каменная тибличка. На ней высечены имена всех игроков.", Properties.Resources.level1MonumentOfLife);
            Location level1Church = new Location(LOCATION_ID_LEVEL_1_CHURCH, "Церковь", "Прибежище всех страждующих", Properties.Resources.level1Church);
            Location level1HuntingGrounds = new Location(LOCATION_ID_LEVEL_1_HUNTING_GROUNDS, "Охотничьи угодья", "Обширная зона охоты для персонажей низкого уровня", Properties.Resources.level1HuntingGrounds);
            level1HuntingGrounds.MonsterLivingHere = MonsterByID(MONSTER_ID_WILD_BOAR);
            Location level1Lake = new Location(LOCATION_ID_LEVEL_1_LAKE, "Озеро", "", Properties.Resources.level1Lake);
            level1Lake.MonsterLivingHere = MonsterByID(MONSTER_ID_COW_LEADER);
            Location level1Forest = new Location(LOCATION_ID_LEVEL_1_FOREST, "Лес", "", Properties.Resources.level1Forest);
            level1Forest.MonsterLivingHere = MonsterByID(MONSTER_ID_WOLF);
            Location level1Horunka = new Location(LOCATION_ID_LEVEL_1_HORUNKA, "Хорунка", "", Properties.Resources.level1Horunka);
            Location level1HorunkaCentralSquare = new Location(LOCATION_ID_LEVEL_1_HORUNKA_CENTRAL_SQUARE, "Центральная площадь", "", Properties.Resources.level1HorunkaCentral);
            Location level1HorunkaShop = new Location(LOCATION_ID_LEVEL_1_HORUNKA_SHOP, "Магазин", "", Properties.Resources.Level1HorunkaShop);
            Location level1HorunkaInn = new Location(LOCATION_ID_LEVEL_1_HORUNKA_INN, "Таверна", "", Properties.Resources.level1HorunkaInn);
            level1HorunkaInn.QuestAvailableHere = QuestByID(QUEST_ID_SECRET_MEDECINE_OF_THE_FORREST);
            Location level1DarkForest = new Location(LOCATION_ID_LEVEL_1_DARK_FOREST, "Тёмный лес", "", Properties.Resources.level1Forest2);
            level1DarkForest.MonsterLivingHere = MonsterByID(MONSTER_ID_LITTLE_NEPENT);
            Location level1Tolbana = new Location(LOCATION_ID_LEVEL_1_TOLBANA, "Толбана", "",Properties.Resources.level1TolbanaCentralSquare);
            Location level1TolbanaCentralSquare = new Location(LOCATION_ID_LEVEL_1_TOLBANA_CENTRAL_SQUARE, "Центральная площадь Толбаны", "", Properties.Resources.level1TolbanaCentral);
            Location level1TolbanaWeaponShop = new Location(LOCATION_ID_LEVEL_1_TOLBANA_WEAPONSHOP, "Оружейный магазин", "", Properties.Resources.level1TolbanaWeaponShop);
            Location level1TolbanaInn = new Location(LOCATION_ID_LEVEL_1_TOLBANA_INN, "Таверна", "", Properties.Resources.level1TolbanaInn);
            level1TolbanaInn.QuestAvailableHere = QuestByID(QUEST_ID_COWS_COUNTER_ATTACK);
            Location level1Dungeon = new Location(LOCATION_ID_LEVEL_1_DUNGEON, "Данж", "", Properties.Resources.level1TolbanaDungeonEnter);
            #region ROOTLINE
            level1DefaultCity.LocationToNorth = level1HuntingGrounds;
            level1DefaultCity.LocationToWest = level1DefaultCityInn;
            level1DefaultCity.LocationToEast = level1DefaulCityMarket;
            level1DefaultCity.LocationToSouth = level1DefaulCityIronKeep;

            level1DefaulCityIronKeep.LocationToNorth = level1DefaultCity;
            level1DefaulCityIronKeep.LocationToWest = level1Church;
            //level1DefaulCityIronKeep.LocationToEast = ;
            level1DefaulCityIronKeep.LocationToSouth = level1MonumentOfLife;

            level1MonumentOfLife.LocationToNorth = level1DefaulCityIronKeep;

            level1Church.LocationToEast = level1DefaulCityIronKeep;

            level1DefaulCityMarket.LocationToWest = level1DefaultCity;

            level1DefaultCityInn.LocationToEast = level1DefaultCity;

            level1HuntingGrounds.LocationToWest = level1Forest;
            level1HuntingGrounds.LocationToEast = level1Lake;
            level1HuntingGrounds.LocationToSouth = level1DefaultCity;

            level1Lake.LocationToWest = level1HuntingGrounds;
            //level1Lake.LocationToNorth = ;

            level1Forest.LocationToNorth = level1Horunka;
            level1Forest.LocationToEast = level1HuntingGrounds;

            level1Horunka.LocationToNorth = level1HorunkaCentralSquare;
            level1Horunka.LocationToSouth = level1Forest;

            level1HorunkaCentralSquare.LocationToNorth = level1HorunkaInn;
            level1HorunkaCentralSquare.LocationToWest = level1HorunkaShop;
            level1HorunkaCentralSquare.LocationToEast = level1DarkForest;
            level1HorunkaCentralSquare.LocationToSouth = level1Horunka;

            level1HorunkaShop.LocationToEast = level1HorunkaCentralSquare;

            level1HorunkaInn.LocationToSouth = level1HorunkaCentralSquare;

            level1DarkForest.LocationToNorth = level1Tolbana;
            level1DarkForest.LocationToWest = level1HorunkaCentralSquare;

            level1Tolbana.LocationToNorth = level1TolbanaCentralSquare;
            level1Tolbana.LocationToSouth = level1DarkForest;
            //level1DarkForest.LocationToEast = ;

            level1TolbanaCentralSquare.LocationToNorth = level1Dungeon;
            level1TolbanaCentralSquare.LocationToWest = level1TolbanaInn;
            level1TolbanaCentralSquare.LocationToEast = level1TolbanaWeaponShop;
            level1TolbanaCentralSquare.LocationToSouth = level1Tolbana;

            level1TolbanaInn.LocationToEast = level1TolbanaCentralSquare;

            level1TolbanaWeaponShop.LocationToWest = level1TolbanaCentralSquare;

            level1Dungeon.LocationToSouth = level1TolbanaCentralSquare;
            #endregion

            Locations.Add(level1DefaultCity);
            Locations.Add(level1DefaultCityInn);
            Locations.Add(level1DefaulCityMarket);
            Locations.Add(level1DefaulCityIronKeep);
            Locations.Add(level1Church);
            Locations.Add(level1MonumentOfLife);

            Locations.Add(level1HuntingGrounds);
            Locations.Add(level1Lake);
            Locations.Add(level1Forest);

            Locations.Add(level1Horunka);
            Locations.Add(level1HorunkaCentralSquare);
            Locations.Add(level1HorunkaInn);
            Locations.Add(level1HorunkaShop);

            Locations.Add(level1DarkForest);

            Locations.Add(level1Tolbana);
            Locations.Add(level1TolbanaCentralSquare);
            Locations.Add(level1TolbanaInn);
            Locations.Add(level1TolbanaWeaponShop);

            Locations.Add(level1Dungeon);
        }
        #region ID engine
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
        public static Location LocationByID(int id)
        {
            foreach (Location location in Locations)
            {
                if (location.ID == id)
                {
                    return location;
                }
            }
            return null;
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Monster : LivingCreature
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Damage { get; set; }
        public int RewardExperinece { get; set; }
        public int RewardGold { get; set; }
        public List<LootItem> LootTable { get; set; }

        public Monster(int id, string name, int damage, int rewardExperience, int rewardGold, int currentHealth, int maximumHealth) : base(currentHealth,maximumHealth)
        {
            ID = id;
            Name = name;
            Damage = damage;
            RewardExperinece = rewardExperience;
            RewardGold = rewardGold;
            LootTable = new List<LootItem>();
        }
    }
}

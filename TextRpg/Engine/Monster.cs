using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    class Monster : LivingCreature
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Damage { get; set; }
        public int RewardExperinece { get; set; }
        public int RewardGold { get; set; }
    }
}

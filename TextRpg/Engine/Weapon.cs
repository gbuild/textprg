using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Weapon : Item
    {
        public int Damage { get; set; }

        public Weapon(int id,string name, string namePlural, int damage) :base(id,name,namePlural)
        {
            Damage = damage;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Armor: Item
    {
        public int Defence { get; set; }

        public Armor (int id, string name, string namePlural, int defence ) :base (id,name,namePlural)
        {
            Defence = defence;
        }
    }
}

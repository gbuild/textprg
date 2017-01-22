using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player
    {
        public int CurrentHealth { get; set; }
        public int MaximumHealth { get; set; }
        public int Gold { get; set; }
        public int Experience{ get; set;}
        public int Level { get; set;}
    }
}

﻿using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Resources;
using System.Threading.Tasks;

namespace Engine
{
    public class Location
    { 
        public int ID { get; set; }
        public string Name { get; set; }      
        public string Description { get; set; }
        public Quest QuestAvailableHere { get; set; }
        public Monster MonsterLivingHere { get; set; }
        public Location LocationToNorth { get; set; }
        public Location LocationToSouth { get; set; }
        public Location LocationToWest { get; set; }
        public Location LocationToEast { get; set; }
        public Image LocationDisplayImage { get; set; }

        public Location(int id, string name, string description, Image locationDisplayImage = null, Quest questAvailableHere = null, Monster monsterLivingHere = null)
        {
            ID = id;
            Name = name;
            Description = description;
            LocationDisplayImage = locationDisplayImage;
        }
    }
}

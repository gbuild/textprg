using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Quest
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RewardExperience { get; set; }
        public int RewardGold { get; set; }
        public int RewardItem { get; set; }
        public List<QuestCompletionItem> QuestCompletionItems { get; set; }

        public Quest(int id, string name, string description, int rewardExperience, int rewardGold, int rewardItem)
        {
            ID = id;
            Name = name;
            Description = description;
            RewardExperience = rewardExperience;
            RewardGold = rewardGold;
            RewardItem = rewardItem;
            QuestCompletionItems = new List<QuestCompletionItem>();
        }
    }
}

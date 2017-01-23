using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player : LivingCreature
    {
        public int Gold { get; set; }
        public int Experience{ get; set;}
        public int Level { get { return ((Experience / 500) + 1); } }
        public Location CurrentLocation { get; set; }
        public List<InventoryItem> Inventory { get; set; }
        public List<PlayerQuest> Quests { get; set; }

        public Player (int gold, int experience, int currentHealth, int maximumHealth) :base(currentHealth,maximumHealth)
        {
            Gold = gold;
            Experience = experience;
            Inventory = new List<InventoryItem>();
            Quests = new List<PlayerQuest>();
        }
        public bool HasThisQuest(Quest quest)
        {
            foreach (PlayerQuest playerQuest in Quests)
            {
                if (playerQuest.Details.ID == quest.ID)
                {
                    return true;
                }
            }
            return false;
        }
        public bool CompletedThisQuest(Quest quest)
        {
            foreach (PlayerQuest playerQuest in Quests)
            {
                if (playerQuest.Details.ID == quest.ID)
                {
                    return playerQuest.IsCompleted;
                }
            }
            return false;
        }
        public bool HasAllQuestCompletionItems(Quest quest)
        {
            foreach(QuestCompletionItem qci in quest.QuestCompletionItems)
            {
                bool foundItemInPlayerInventory = false;
                foreach(InventoryItem ii in Inventory)
                {
                    if (ii.Details.ID == qci.Details.ID)
                    {
                        foundItemInPlayerInventory = true;
                        if (ii.Quantity < qci.Quantity)
                        {
                            return false;
                        }
                    }
                }
                if(!foundItemInPlayerInventory)
                {
                    return false;
                }
            }
            return true;
        }
        public bool RemoveQuestCompletionItems(Quest quest)
        {
            foreach (QuestCompletionItem qci in quest.QuestCompletionItems)
            {
                foreach (InventoryItem ii in Inventory)
                {
                    if (ii.Details.ID == qci.Details.ID)
                    {
                        ii.Quantity -= qci.Quantity;
                        break;
                    }
                }
            }
            return false;
        }
        public void AddItemToInventory (Item itemToAdd)
        {
            foreach (InventoryItem ii in Inventory)
            {
                if (ii.Details.ID == itemToAdd.ID)
                {
                    ii.Quantity++;
                    return;
                }
            }
            Inventory.Add(new InventoryItem(itemToAdd, 1));
        }

        public void MarkQuestCompleted (Quest quest)
        {
            foreach (PlayerQuest pq in Quests)
            {
                if(pq.Details.ID == quest.ID)
                {
                    pq.IsCompleted = true;
                    return;
                }
            }
        }
    }
}

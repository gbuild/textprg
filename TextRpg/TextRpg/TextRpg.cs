using System;
using System.Resources;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;

namespace TextRpg
{
    public partial class TextRpg : Form
    {
        private Player _player;
        private Monster _currentMonster;
        private List<Bitmap> images;

        public TextRpg()
        {     
            InitializeComponent();
            _player = new Player(0,0,1,100,100);
            _player.Inventory.Add(new InventoryItem(World.ItemByID(World.ITEM_ID_WOODEN_SWORD), 1));
            MoveTo(World.LocationByID(World.LOCATION_ID_LEVEL_1_DEFAULT_CITY));
            images = new List<Bitmap>();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            StatsScreen statsScreen = new StatsScreen(_player);
            statsScreen.StartPosition = FormStartPosition.CenterParent;
            statsScreen.ShowDialog(this);
        }

        private void btnNorth_Click(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentLocation.LocationToNorth);
        }

        private void btnSouth_Click(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentLocation.LocationToSouth);
        }

        private void btnWest_Click(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentLocation.LocationToWest);
        }

        private void btnEast_Click(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentLocation.LocationToEast);
        }

        private void MoveTo(Location newLocation)
        {
            _player.CurrentLocation = newLocation;
            pbCurrent.Image = newLocation.LocationDisplayImage;
            btnNorth.Visible = (newLocation.LocationToNorth !=null);
            btnSouth.Visible = (newLocation.LocationToSouth !=null);
            btnWest.Visible = (newLocation.LocationToWest!= null);
            btnEast.Visible = (newLocation.LocationToEast != null);

            rtbMessages.Text = newLocation.Name + Environment.NewLine;
            rtbMessages.Text += newLocation.Description + Environment.NewLine;
            if(newLocation.QuestAvailableHere!=null)
            {
                bool playerAlreadyHasQuest = false;
                bool playerAlreadyCompeletedQuest = false;
                foreach(PlayerQuest playerQuest in _player.Quests)
                {
                    if(playerQuest.Details.ID == newLocation.QuestAvailableHere.ID)
                    {
                        playerAlreadyHasQuest = true;
                        
                        if (playerQuest.IsCompleted)
                        {
                            playerAlreadyCompeletedQuest = true;
                        }                     
                    }
                }

                if (playerAlreadyHasQuest)
                {
                    if (!playerAlreadyCompeletedQuest)
                    {
                        bool playerHasAllItemsToCopleteQuest = true;
                        foreach (QuestCompletionItem qci in newLocation.QuestAvailableHere.QuestCompletionItems)
                        {
                            bool foundItemInPlayersInventory = false;
                            foreach (InventoryItem ii in _player.Inventory)
                            {
                                if (ii.Details.ID == qci.Details.ID)
                                {
                                    foundItemInPlayersInventory = true;
                                    if (ii.Quantity < qci.Quantity)
                                    {
                                        playerHasAllItemsToCopleteQuest = false;
                                        break;
                                    }
                                    break;
                                }
                            }

                            if (!foundItemInPlayersInventory)
                            {
                                playerHasAllItemsToCopleteQuest = false;
                                break;
                            }
                        }

                        if (playerHasAllItemsToCopleteQuest)
                        {
                            rtbMessages.Text += Environment.NewLine;
                            rtbMessages.Text += $"Вы выполнили {newLocation.QuestAvailableHere.Name} квест. " + Environment.NewLine;
                            foreach (QuestCompletionItem qci in newLocation.QuestAvailableHere.QuestCompletionItems)
                            {
                                foreach (InventoryItem ii in _player.Inventory)
                                {
                                    if (ii.Details.ID == qci.Details.ID)
                                    {
                                        ii.Quantity -= qci.Quantity;
                                        break;
                                    }
                                }
                            }
                            rtbMessages.Text += "Вы получили: " + Environment.NewLine;
                            rtbMessages.Text += newLocation.QuestAvailableHere.RewardExperience.ToString() + " очков опыта " + Environment.NewLine;
                            rtbMessages.Text += newLocation.QuestAvailableHere.RewardGold.ToString() + " золота " + Environment.NewLine;
                            rtbMessages.Text += newLocation.QuestAvailableHere.RewardItem.Name + Environment.NewLine;

                            _player.Experience += newLocation.QuestAvailableHere.RewardExperience;
                            _player.Gold += newLocation.QuestAvailableHere.RewardGold;

                            bool addedItemToPlayerInventory = false;

                            foreach (InventoryItem ii in _player.Inventory)
                            {
                                if (ii.Details.ID == newLocation.QuestAvailableHere.RewardItem.ID)
                                {
                                    ii.Quantity++;
                                    addedItemToPlayerInventory = true;
                                    break;
                                }
                            }

                            if (!addedItemToPlayerInventory)
                            {
                                _player.Inventory.Add(new InventoryItem(newLocation.QuestAvailableHere.RewardItem, 1));
                            }

                            foreach (PlayerQuest pq in _player.Quests)
                            {
                                if (pq.Details.ID == newLocation.QuestAvailableHere.ID)
                                {
                                    pq.IsCompleted = true;
                                    break;
                                }
                            }
                        }
                    }
                }

                else
                {
                    rtbMessages.Text += $"Вы взяли новый квест {newLocation.QuestAvailableHere.Name}."+Environment.NewLine;
                    rtbMessages.Text += newLocation.QuestAvailableHere.Description + Environment.NewLine;
                    rtbMessages.Text += "Для выполнения принесите мне: ";
                    foreach (QuestCompletionItem qci in newLocation.QuestAvailableHere.QuestCompletionItems)
                    {
                        if (qci.Quantity == 1)
                        {
                            rtbMessages.Text += qci.Quantity.ToString() + " " + qci.Details.Name + Environment.NewLine;
                        }
                        else
                        {
                            rtbMessages.Text += qci.Quantity.ToString() + " " + qci.Details.NamePlural + Environment.NewLine;
                        }
                    }
                    rtbMessages.Text += Environment.NewLine;
                    _player.Quests.Add(new PlayerQuest(newLocation.QuestAvailableHere));
                }
            }
            if (newLocation.MonsterLivingHere !=null)
            {
                rtbMessages.Text += $"Вы видите {newLocation.MonsterLivingHere.Name}" + Environment.NewLine;
                Monster standartMonster = World.MonsterByID(newLocation.MonsterLivingHere.ID);
                _currentMonster = new Monster(standartMonster.ID, standartMonster.Name, standartMonster.Damage, standartMonster.RewardExperinece, standartMonster.RewardGold, standartMonster.CurrentHealth, standartMonster.MaximumHealth);
                foreach (LootItem lootItem in standartMonster.LootTable)
                {
                    _currentMonster.LootTable.Add(lootItem);
                }
                cboWeapons.Visible = true;
                cboSkills.Visible = true;
                cboPotions.Visible = true;
                btnUseWeapon.Visible = true;
                btnUseSkill.Visible = true;
                btnUsePotion.Visible = true;
            }
            else
            {
                _currentMonster = null;
                cboWeapons.Visible = false;
                cboSkills.Visible = false;
                cboPotions.Visible = false;
                btnUseWeapon.Visible = false;
                btnUseSkill.Visible = false;
                btnUsePotion.Visible = false;
            }
            pbCurrent.Image = Properties.Resources.level1DefaultCity;

        }

        private void btnAction_Click(object sender, EventArgs e)
        {

        }

        private void btnUseWeapon_Click(object sender, EventArgs e)
        {

        }

        private void btnUseSkill_Click(object sender, EventArgs e)
        {

        }

        private void btnUsePotion_Click(object sender, EventArgs e)
        {

        }

        private void btnRun_Click(object sender, EventArgs e)
        {

        }
    }
}

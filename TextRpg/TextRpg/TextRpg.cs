﻿using System;
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
            _player = new Player(0,0,10,100,100);
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
        private void UpdatePotionList ()
        {
            List<HealingPotion> healingPotions = new List<HealingPotion>();
            foreach (InventoryItem inventoryItem in _player.Inventory)
            {
                if (inventoryItem.Details is HealingPotion)
                {
                    if (inventoryItem.Quantity > 0)
                    {
                        healingPotions.Add((HealingPotion)inventoryItem.Details);
                    }
                }
            }
            if (healingPotions.Count == 0)
            {
                cboPotions.Visible = false;
                btnUsePotion.Visible = false;
            }
            else
            {
                cboPotions.DataSource = healingPotions;
                cboPotions.DisplayMember = "Name";
                cboPotions.ValueMember = "ID";
                cboPotions.SelectedIndex = 0;
            }
        }
        private void UpdateWeaponList ()
        {
            List<Weapon> weapons = new List<Weapon>();
            foreach (InventoryItem inventoryItem in _player.Inventory)
            {
                if (inventoryItem.Details is Weapon)
                {
                    if (inventoryItem.Quantity > 0)
                    {
                        weapons.Add((Weapon)inventoryItem.Details);
                    }
                }
            }
            if (weapons.Count == 0)
            {
                cboWeapons.Visible = false;
                btnUseWeapon.Visible = false;
            }
            else
            {
                cboWeapons.SelectedIndexChanged -= cboWeapons_SelectedIndexChanged;
                cboWeapons.DataSource = weapons;
                cboWeapons.SelectedIndexChanged += cboWeapons_SelectedIndexChanged;
                cboWeapons.DisplayMember = "Name";
                cboWeapons.ValueMember = "ID";
                if (_player.CurrentWeapon != null)
                {
                    cboWeapons.SelectedItem = _player.CurrentWeapon;
                }
                else
                {
                    cboWeapons.SelectedIndex = 0;
                }
            }
        }
        private void cboWeapons_SelectedIndexChanged(object sender, EventArgs e)
        {
            _player.CurrentWeapon = (Weapon)cboWeapons.SelectedItem;
        }
        private void MoveTo(Location newLocation)
        {
            _player.CurrentLocation = newLocation;           
            pbCurrent.Image = newLocation.LocationDisplayImage;
            /* Для рефактора от */
            if (newLocation.LocationToNorth != null)
            {
                btnNorth.Text = newLocation.LocationToNorth.Name;
                btnNorth.Visible = true;
            }
            else { btnNorth.Visible = false; 
            }
            if (newLocation.LocationToSouth != null)
            {
                btnSouth.Text = newLocation.LocationToSouth.Name;
                btnSouth.Visible = true;
            }
            else { btnSouth.Visible = false;}
            if(newLocation.LocationToWest != null)
            {
                btnWest.Text = newLocation.LocationToWest.Name;
                btnWest.Visible = true;
            }
            else
            { btnWest.Visible = false;}
            if (newLocation.LocationToEast != null)
            {
                btnEast.Text = newLocation.LocationToEast.Name;
                btnEast.Visible = true;
            }
            else {btnEast.Visible = false;}
            /* До */
            rtbMessages.Text = newLocation.Name + Environment.NewLine;
            rtbMessages.Text += newLocation.Description + Environment.NewLine;
            if(newLocation.QuestAvailableHere!=null)
            {
                bool playerAlreadyHasQuest = _player.HasThisQuest(newLocation.QuestAvailableHere) ;
                bool playerAlreadyCompeletedQuest = _player.CompletedThisQuest(newLocation.QuestAvailableHere);

                if (playerAlreadyHasQuest)
                {
                    if (!playerAlreadyCompeletedQuest)
                    {
                        bool playerHasAllItemsToCopleteQuest = _player.HasAllQuestCompletionItems(newLocation.QuestAvailableHere);
                        if (playerHasAllItemsToCopleteQuest)
                        {
                            rtbMessages.Text += Environment.NewLine;
                            rtbMessages.Text += $"Вы успешно выполнили задание {newLocation.QuestAvailableHere.Name}. " + Environment.NewLine;
                            _player.RemoveQuestCompletionItems(newLocation.QuestAvailableHere);
                            rtbMessages.Text += "Вы получили: " + Environment.NewLine;
                            rtbMessages.Text += newLocation.QuestAvailableHere.RewardExperience.ToString() + " очков опыта " + Environment.NewLine;
                            rtbMessages.Text += newLocation.QuestAvailableHere.RewardGold.ToString() + " золота " + Environment.NewLine;
                            rtbMessages.Text += newLocation.QuestAvailableHere.RewardItem.Name + Environment.NewLine;
                            _player.AddExperiencePoints(newLocation.QuestAvailableHere.RewardExperience);
                            _player.Gold += newLocation.QuestAvailableHere.RewardGold;
                            _player.AddItemToInventory(newLocation.QuestAvailableHere.RewardItem);
                            _player.MarkQuestCompleted(newLocation.QuestAvailableHere);
                        }
                    }
                }

                else
                {
                    rtbMessages.Text += $"Вы получили новое задание {newLocation.QuestAvailableHere.Name}."+Environment.NewLine;
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
                _currentMonster = new Monster(standartMonster.ID, standartMonster.Name, standartMonster.Damage, standartMonster.RewardExperinece, standartMonster.RewardGold, standartMonster.CurrentHealth, standartMonster.MaximumHealth,standartMonster.MonsterDisplayImage);
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
                btnUseWeapon.Visible = false;
                btnUseSkill.Visible = false;
            }
            UpdateWeaponList();
            UpdatePotionList();

        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentLocation);
        }

        private void btnUseWeapon_Click(object sender, EventArgs e)
        {
            pbCurrent.Image= _currentMonster.MonsterDisplayImage;
            Weapon currentWeapon = (Weapon)cboWeapons.SelectedItem;
            int damageToMonster = currentWeapon.Damage + _player.Strength;
            if (damageToMonster > 0)
            {
                _currentMonster.CurrentHealth -= damageToMonster;
            }
            else
            {
                rtbMessages.Text += "Вы безоружные, возьмите в руки оружие." + Environment.NewLine;
            }
            rtbMessages.Text += $"Вы нанесли цели {_currentMonster.Name} {damageToMonster.ToString()} едениц урона. " +Environment.NewLine;
            if(_currentMonster.CurrentHealth <= 0)
            {
                rtbMessages.Text += Environment.NewLine;
                rtbMessages.Text += $"Вы одержали победу над {_currentMonster.Name}" + Environment.NewLine;
                _player.AddExperiencePoints(_currentMonster.RewardExperinece);
                rtbMessages.Text += $"За победу вы получили {_currentMonster.RewardExperinece.ToString()} едениц опыта." + Environment.NewLine;
                _player.Gold += _currentMonster.RewardGold;
                rtbMessages.Text += $"У противника вы нашли {_currentMonster.RewardGold.ToString()} золотых монет"+Environment.NewLine;
                List<InventoryItem> lootedItems = new List<InventoryItem>();
                foreach (LootItem lootitem in _currentMonster.LootTable)
                {
                    if(RandomNumberGenerator.NumberBetween(1,100)<= lootitem.DropPercentage)
                    {
                        lootedItems.Add(new InventoryItem(lootitem.Details, 1));
                    }
                }
                if (lootedItems.Count == 0)
                {
                    foreach(LootItem lootItem in _currentMonster.LootTable)
                    {
                        if (lootItem.IsDefaultItem)
                        {
                            lootedItems.Add(new InventoryItem(lootItem.Details, 1));
                        }
                    }
                }
                foreach (InventoryItem inventoryItem in lootedItems)
                {
                    _player.AddItemToInventory(inventoryItem.Details);
                    if (inventoryItem.Quantity == 1)
                    {
                        rtbMessages.Text += $"Вы нашли {inventoryItem.Quantity.ToString()} {inventoryItem.Details.Name}" + Environment.NewLine;
                    }
                    else
                    {
                        rtbMessages.Text += $"Вы нашли {inventoryItem.Quantity.ToString()}  {inventoryItem.Details.NamePlural}" + Environment.NewLine;
                    }
                }
                UpdatePotionList();
                UpdateWeaponList();
                rtbMessages.Text += Environment.NewLine;
                btnUseWeapon.Visible = false;
                cboWeapons.Visible = false;
                btnUseSkill.Visible = false;
                cboSkills.Visible = false;
                //MoveTo(_player.CurrentLocation);            
            }
            else
            {
                int damageToPlayer = _currentMonster.Damage;
                rtbMessages.Text += $"Ваш противник {_currentMonster.Name} нанёс вам {damageToPlayer.ToString()} едениц урона." + Environment.NewLine;
                _player.CurrentHealth -= damageToPlayer;
                if(_player.CurrentHealth <= 0)
                {                   
                    rtbMessages.Text += $"Вас убил {_currentMonster.Name}" + Environment.NewLine;
                    MoveTo(World.LocationByID(World.LOCATION_ID_LEVEL_1_MONUMENTOFLIFE));
                    _player.CurrentHealth = _player.MaximumHealth;

                }
            }
        }

        private void btnUseSkill_Click(object sender, EventArgs e)
        {

        }

        private void btnUsePotion_Click(object sender, EventArgs e)
        {
            HealingPotion potion = (HealingPotion)cboPotions.SelectedItem;
            _player.CurrentHealth = (_player.CurrentHealth + potion.AmountToHeal);
            if (_player.CurrentHealth>_player.MaximumHealth)
            {
                _player.CurrentHealth = _player.MaximumHealth;
            }
            foreach(InventoryItem ii in _player.Inventory)
            {
                if (ii.Details.ID == potion.ID)
                {
                    ii.Quantity--;
                    UpdatePotionList();
                    break;
                }
            }
           rtbMessages.Text += $"Вы использовали {potion.Name}. Восстановленно {potion.AmountToHeal} едениц здоровья." + Environment.NewLine;
            /*int damageToPlayer = _currentMonster.Damage;
            rtbMessages.Text += $"{_currentMonster.Name} нанёс вам {damageToPlayer.ToString()} едениц урона."+Environment.NewLine;
            _player.CurrentHealth -= damageToPlayer;
            if (_player.CurrentHealth <= 0)
            {
                rtbMessages.Text += $"Вас убил {_currentMonster.Name}" + Environment.NewLine;
                MoveTo(World.LocationByID(World.LOCATION_ID_LEVEL_1_MONUMENTOFLIFE));
            }*/
        }

        private void btnRun_Click(object sender, EventArgs e)
        {

        }

        private void rtbMessages_TextChanged(object sender, EventArgs e)
        {
            rtbMessages.SelectionStart = rtbMessages.Text.Length;
            rtbMessages.ScrollToCaret();
        }
    }
}

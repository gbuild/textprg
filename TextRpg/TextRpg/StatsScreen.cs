using System;
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
    public partial class StatsScreen : Form
    {
        private Player _currentPlayer;
        public StatsScreen(Player player)
        {
            _currentPlayer = player;
            InitializeComponent();
            UpdateStats(_currentPlayer);
            UpdateInventoryList(_currentPlayer);
            UpdateQuestList(_currentPlayer);
            //pbIcon.Image = Properties.Resources._5435345;

        }
        private void UpdateStats (Player player)
        {
            globalLevelCount.Text = player.Level.ToString();
            globalExpCount.Visible = false;
            //globalExpCount.Text = player.Experience.ToString();
            globalHealthCount.Text = $"{player.CurrentHealth.ToString()}\\{player.MaximumHealth}";
            globalGoldCount.Text = player.Gold.ToString();            
        }
        private void UpdateInventoryList(Player player)
        {
            dgvInventory.RowHeadersVisible = false;
            dgvInventory.ColumnCount = 2;
            dgvInventory.Columns[0].Name = "Название";
            dgvInventory.Columns[0].Width = 220;
            dgvInventory.Columns[1].Name = "Колличество";
            dgvInventory.Columns[1].Width = 96;
            dgvInventory.Rows.Clear();
            foreach (InventoryItem inventoryItem in player.Inventory)
            {
                if (inventoryItem.Quantity > 0)
                {
                    dgvInventory.Rows.Add(new[] { inventoryItem.Details.Name, inventoryItem.Quantity.ToString() });
                }
            }
        }
        private void UpdateQuestList(Player player)
        {
            dgbQuests.RowHeadersVisible = false;
            dgbQuests.ColumnCount = 2;
            dgbQuests.Columns[0].Name = "Название";
            dgbQuests.Columns[0].Width = 160;
            dgbQuests.Columns[1].Name = "Выполнено";
            dgbQuests.Columns[1].Width = 96;
            dgbQuests.Rows.Clear();
            foreach (PlayerQuest playerQuest in player.Quests)
            {
                dgbQuests.Rows.Add(new[] { playerQuest.Details.Name, playerQuest.IsCompleted.ToString() });
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

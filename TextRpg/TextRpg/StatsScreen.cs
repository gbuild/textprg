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
            globalLevelCount.Text = player.Level.ToString();
            globalExpCount.Text = player.Experience.ToString();
            globalHealthCount.Text = player.CurrentHealth.ToString();
            globalGoldCount.Text = player.Gold.ToString();
            pbIcon.Image = Properties.Resources._5435345;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

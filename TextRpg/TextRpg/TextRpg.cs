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
    public partial class TextRpg : Form
    {
        private Player _player;
        public TextRpg()
        {
            InitializeComponent();
            _player = new Player(0,0,1,100,100);         
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            StatsScreen statsScreen = new StatsScreen(_player);
            statsScreen.StartPosition = FormStartPosition.CenterParent;
            statsScreen.ShowDialog(this);
        }
    }
}

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
            _player = new Player();
            _player.CurrentHealth = 100;
            _player.MaximumHealth = 100;
            _player.Gold = 0;
            _player.Experience = 1;
            _player.Level = 1;

            globalLevelCount.Text = _player.Level.ToString();
            globalExpCount.Text = _player.Experience.ToString();
            globalHealthCount.Text = _player.CurrentHealth.ToString();
            globalGoldCount.Text = _player.Gold.ToString();

        }
    }
}

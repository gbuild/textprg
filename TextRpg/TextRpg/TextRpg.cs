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

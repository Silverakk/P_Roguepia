using P_RogueTower.Data;
using P_RogueTower.LivingCreatures;
using P_RogueTower;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_Roguepia
{
    public partial class NewGamePlus : Form
    {
        private Game game;
        internal Game NewGame = null;
        internal bool StartANewGame = false;

        internal Game Game { get => game; set => game = value; }

        public NewGamePlus()
        {
            InitializeComponent();
        }

        private void NewGamePlus_Load(object sender, EventArgs e)
        {
            if (Game.Player.MainDroite != null)
            {
                lblArme.Text = Game.Player.MainDroite.Name;
            }
            else
            {
                lblArme.Text = "vide";
            }
            lblChance.Text = Game.Player.Chance.ToString();
            lblEndurance.Text = Game.Player.Endurance.ToString();
            lblHabilite.Text = Game.Player.Habilite.ToString();
            lblLyres.Text = Game.Player.Lyre.ToString();
            lblNom.Text = Game.Player.Name;
            lblRace.Text = Game.Player.NameRace;
            lblNumberOfEnnemySlain.Text = Game.NumberOfEnnemySlain.ToString();
            UpdateInventoryBox();
            lbxShop.DisplayMember = "Name";
            foreach (Item item in DataItems.GetShopItem())
            {
                lbxShop.Items.Add(item);
            }
            lbxDonjons.DisplayMember = "Name";
            foreach (Tower tower in DataTowers.GetNewGamePlusDunjons())
            {
                lbxDonjons.Items.Add(tower);
            }
            btnNewGame.Enabled = false;
        }

        private void UpdateInventoryBox()
        {
            lbxInventory.Items.Clear();
            lbxInventory.DisplayMember = "Name";
            foreach (Item item in Game.Player.Inventaire)
            {
                lbxInventory.Items.Add(item);
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            NewGame = new Game(
                Game.Player as Player,
                Game.Player.MainDroite as Arme,
                null,
                Game.Player.Name,
                lbxDonjons.SelectedItem as Tower
                );
            StartANewGame = true;
            this.Close();
        }

        private void lbxShop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxShop.SelectedItem != null)
            {
                lblSelectedInfo.Text = (lbxShop.SelectedItem as Item).Description;
            }
        }

        private void lbxInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxInventory.SelectedItem != null)
            {
                lblSelectedInfo.Text = (lbxInventory.SelectedItem as Item).Description;
            }
        }

        private void lbxDonjons_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lbxDonjons.SelectedItem != null)
            {
                bool IsNotDone = true;
                foreach (string s in Game.DonjonsDone)
                {
                    if (s == (lbxDonjons.SelectedItem as Tower).Name)
                    {
                        IsNotDone = false;
                    }
                }
                btnNewGame.Enabled = lbxDonjons != null && IsNotDone;
                lblSelectedInfo.Text = (lbxDonjons.SelectedItem as Tower).Description;
            }
            
        }

        private void lbxShop_DoubleClick(object sender, EventArgs e)
        {
            if((lbxShop.SelectedItem as Item).Price <= Game.Player.Lyre)
            {
                Game.Player.Lyre -= (lbxShop.SelectedItem as Item).Price;
                Game.Player.Inventaire.Add((lbxShop.SelectedItem as Item));
                lblLyres.Text = Game.Player.Lyre.ToString();
            }
            UpdateInventoryBox();
        }
    }
}

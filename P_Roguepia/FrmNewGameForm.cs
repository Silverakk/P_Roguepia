using P_RogueTower.Data;
using P_RogueTower.LivingCreatures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_RogueTower
{
    public partial class FrmNewGameForm : Form
    {
        internal Game NewGame = null;
        internal bool StartANewGame = false;

        public FrmNewGameForm()
        {
            InitializeComponent();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void FrmNewGameForm_Load(object sender, EventArgs e)
        {
            lbxRaces.DisplayMember = "NameRace";
            foreach (Player race in DataRaces.GetAllRaces())
            {
                lbxRaces.Items.Add(race);
            }
            lbxStartingItems.DisplayMember = "Name";
            foreach (Item item in DataItems.GetStartingItem())
            {
                lbxStartingItems.Items.Add(item);
            }
            lbxArmes.DisplayMember = "Name";
            foreach (Arme arme in DataEquipement.GetStartingWeapons())
            {
                lbxArmes.Items.Add(arme);
            }
            lbxDonjons.DisplayMember = "Name";
            foreach (Tower tower in DataTowers.GetAllDunjons())
            {
                lbxDonjons.Items.Add(tower);
            }
            btnNewGame.Enabled = !(lbxRaces.SelectedItem == null || lbxArmes.Items == null || lbxStartingItems == null || lbxDonjons == null);
        }


        private void btnNewGame_Click(object sender, EventArgs e)
        {
            this.NewGame = new Game(
                lbxRaces.SelectedItem as Player,
                lbxArmes.SelectedItem as Arme,
                lbxStartingItems.SelectedItem as Item,
                tbxPlayerName.Text,lbxDonjons.SelectedItem as Tower
                );
            StartANewGame = true;
            this.Close();
        }

        private void lbxRaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbxRaces.SelectedItem != null)
            {
                btnNewGame.Enabled = !(tbxPlayerName.Text == string.Empty || lbxRaces.SelectedItem == null || lbxArmes.SelectedItem == null || lbxStartingItems.SelectedItem == null || lbxDonjons.SelectedItem == null);
                lblSelectedInfo.Text = (lbxRaces.SelectedItem as Player).DescriptionOfLivingCreature;
            }
            
            
        }

        private void lbxArmes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxArmes.SelectedItem != null)
            {
                btnNewGame.Enabled = !(tbxPlayerName.Text == string.Empty || lbxRaces.SelectedItem == null || lbxArmes.SelectedItem == null || lbxStartingItems.SelectedItem == null || lbxDonjons.SelectedItem == null);
                lblSelectedInfo.Text = (lbxArmes.SelectedItem as Arme).Description;
            }
        }

        private void lbxStartingItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxStartingItems.SelectedItem != null)
            {
                btnNewGame.Enabled = !(tbxPlayerName.Text == string.Empty || lbxRaces.SelectedItem == null || lbxArmes.SelectedItem == null || lbxStartingItems.SelectedItem == null || lbxDonjons.SelectedItem == null);
                lblSelectedInfo.Text = (lbxStartingItems.SelectedItem as Item).Description;
            }
        }
        private void tbxPlayerName_TextChanged(object sender, EventArgs e)
        {
            btnNewGame.Enabled = !(tbxPlayerName.Text == string.Empty || lbxRaces.SelectedItem == null || lbxArmes.SelectedItem == null || lbxStartingItems.SelectedItem == null || lbxDonjons.SelectedItem == null);

        }

        private void lbxDonjons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbxDonjons.SelectedItem != null)
            {
                btnNewGame.Enabled = !(tbxPlayerName.Text == string.Empty || lbxRaces.SelectedItem == null || lbxArmes.SelectedItem == null || lbxStartingItems.SelectedItem == null || lbxDonjons.SelectedItem == null);
                lblSelectedInfo.Text = (lbxDonjons.SelectedItem as Tower).Description;
            }
        }
    
    }
}

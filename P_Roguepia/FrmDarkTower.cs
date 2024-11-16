//
// Robin Chessex
//
// 2024
//
//
//
using P_RogueTower;
using P_Tarot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_Roguepia
{
    public partial class FrmDarkTower : Form
    {
        internal Game CurrentGame;

        public FrmDarkTower()
        {
            
            InitializeComponent();

            this.BackColor = Color.White;
            Color transparance = Color.FromArgb(135, Color.Black);
            Color transparanceBtn = Color.FromArgb(180, Color.Black);
            Color transparanceStrip = Color.FromArgb(90, Color.Black);

            gbxTowerInfo.BackColor = transparance;
            gbxActions.BackColor = transparance;
            gbxCaract.BackColor = transparance;
            gbxMonster.BackColor = transparance;
            gbxLeftInfo.BackColor = transparance;
            gbxTowerInfo.BackColor = transparance;
            gbxWeapon.BackColor = transparance;

            btnAction.BackColor = transparanceBtn;
            btnAttaquer.BackColor = transparanceBtn;
            btnAvancer.BackColor = transparanceBtn;
            btnChance.BackColor = transparanceBtn;

            newGameToolStripMenuItem.BackColor = transparanceStrip;
            menuStrip1.BackColor = transparanceStrip;

            btnChance.Enabled = false;
            btnAction.Enabled = false;
            btnAttaquer.Enabled = false;
            btnAvancer.Enabled = false;

            UpdateForm();

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

        private void tsmiNewGame_Click(object sender, EventArgs e)
        {
            FrmNewGameForm newGameForm = new FrmNewGameForm();
            newGameForm.ShowDialog();
            if (newGameForm.StartANewGame == true)
            {
                CurrentGame = newGameForm.NewGame;
                
                
                if (CurrentGame.TheTower.TowerImage != null)
                {
                    this.BackgroundImage = CurrentGame.TheTower.TowerImage;
                }
                UpdateForm();
            }

        }

        private void UpdateForm()
        {
            UpdateButtons();
            UpdateView();

        }

        private void UpdateView()
        {

            // Vide les label

            // gbx Top Left
            lblNombreEtage.Text = string.Empty;
            lblNomDuJoueur.Text = string.Empty;
            lblRaceDuJoueur.Text = string.Empty;

            // gbx Down Left
            lblBrasGauche.Text = string.Empty;
            lblLyre.Text = string.Empty;


            // gbx Arme
            lblArme.Text = string.Empty;
            lblPuissance.Text = string.Empty;
            lblMalusHabiliteNumber.Text = string.Empty;
            lblMalusHabiliteNumber.Text = string.Empty;
            lblNumberOfEnnemySlain.Text = string.Empty;

            // gbx Carac
            lblEndurance.Text = string.Empty;
            lblChance.Text = string.Empty;
            lblHabilite.Text = string.Empty;


            lblTowerInfo.Text = string.Empty;
            

            string infoRoomLight = string.Empty;
            string infoPlayerLight = string.Empty;
            string infoLockedRoom = string.Empty;
            string isCreatureMagic = string.Empty;
            string AreThereCreatureInTheRoom = string.Empty;
            string DescriptionOfAction = string.Empty;

            if(CurrentGame == null) return;
            
            // Traitement


            this.Text = CurrentGame.TheTower.Name;

            lblNombreEtage.Text = CurrentGame.TheTower.CurrentLevel.ToString();
            lblNomDuJoueur.Text = CurrentGame.Player.Name;
            lblRaceDuJoueur.Text = CurrentGame.Player.NameRace;
            lblLyre.Text = CurrentGame.Player.Lyre.ToString();
            lblEndurance.Text = CurrentGame.Player.Endurance.ToString();
            lblChance.Text = CurrentGame.Player.Chance.ToString();
            lblHabilite.Text = CurrentGame.Player.Habilite.ToString();
            lblNumberOfEnnemySlain.Text = CurrentGame.NumberOfEnnemySlain.ToString();
            lblnomdetage.Text = CurrentGame.GetLevel().Name;
            lblnomsalle.Text = CurrentGame.GetRoom().Name;
            lblTowerName.Text = CurrentGame.TheTower.Name;


            if (CurrentGame.Player.IsLighted)
            {
                infoPlayerLight = "\nVous êtes éclairé.";
            }
            if (CurrentGame.GetRoom().Light)
            {
                infoRoomLight = "\nLa pièce est illuminée.";
            }
            else if (!CurrentGame.GetRoom().Light && !CurrentGame.Player.IsLighted)
            {
                infoRoomLight = "\nLa pièce est dans l'obscurité, Malus de 1 d'Habilité.";
            }
            else
            {
                infoRoomLight = "\nLa pièce est dans l'obscurité";
            }

            if (!CurrentGame.GetRoom().AreMonstersDead())
            {
                if (CurrentGame.GetMonster().IsMagic)
                {
                    isCreatureMagic = "La créature vous combattant à l'air d'être magique.";
                }
                if (CurrentGame.GetRoom().MonsterPool.Count > 1)
                {
                    AreThereCreatureInTheRoom = "Il y a plusieurs créatures devant vous.";
                }
                else
                {
                    AreThereCreatureInTheRoom = "Il y a un monstre devant vous.";
                }

            }
            
            if (CurrentGame.GetRoom() is Actionable)
            {
                DescriptionOfAction = CurrentGame.ActionDescription;
            }
            else
            {
                DescriptionOfAction = string.Empty;
            }

            lblTowerInfo.Text =
                CurrentGame.GetRoom().Description + "\n" +
                AreThereCreatureInTheRoom + "\n" +
                isCreatureMagic + "\n" +
                DescriptionOfAction +
                infoPlayerLight +
                infoRoomLight + "\n" +
                infoLockedRoom + "\n\n" +
                CurrentGame.GetLevel().Description;

            // Change la couleur selon la vie
            if (CurrentGame.Player.Chance <= 7)
            {
                lblChance.ForeColor = Color.Red;
            }
            else
            {
                lblChance.ForeColor = Color.White;
            }

            if (CurrentGame.Player.Endurance <= 4)
            {
                lblEndurance.ForeColor = Color.Red;
            }
            else
            {
                lblEndurance.ForeColor = Color.White;
            }

            // gestion du label combat logs
            
            int count = 15;
            if(CurrentGame.CombatLogs.Count() < 15)
            {
                count = CurrentGame.CombatLogs.Count();
            }
            int bufferZoneIraq = Math.Max(CurrentGame.CombatLogs.Count() - 15, 0);
            
            lblCombatLogs.Text = string.Join("\n\r", CurrentGame.CombatLogs.GetRange(bufferZoneIraq, count));
            

            // gestion des labels des armes 
            if (CurrentGame.Player.MainDroite != null)
            {
                lblArme.Text = CurrentGame.Player.MainDroite.Name;
                lblPuissance.Text = CurrentGame.Player.MainDroite.Puissance.ToString();
                lblMalusHabiliteNumber.Text = Math.Abs(CurrentGame.Player.MainDroite.MalusdHabilite).ToString();
            }
            else
            {
                lblArme.Text = "Rien";
                lblPuissance.Text = " ";
                lblMalusHabiliteNumber.Text = " ";
            }

            // gestion des labels de malus ou bonus d'habilité de l'arme
            if (CurrentGame.Player.MainDroite != null)
            {

                lblMalusHabiliteNumber.Text = CurrentGame.Player.MainDroite.MalusdHabilite.ToString();
                if (!CurrentGame.GetRoom().Light && !CurrentGame.Player.IsLighted)
                {
                    lblMalusHabiliteNumber.Text = (CurrentGame.Player.MainDroite.MalusdHabilite - 1).ToString();
                }
            }


            if (CurrentGame.Player.MainDroite != null)
            {
                if (CurrentGame.Player.MainDroite.MalusdHabilite < 0)
                {
                    lblMalusHabiliteTitle.Text = "Bonus d'Habilité";
                }
                else
                {
                    lblMalusHabiliteTitle.Text = "Malus d'Habilité";
                }
            }



            if (CurrentGame.Player.MainGauche != null)
            {
                lblBrasGauche.Text = CurrentGame.Player.MainGauche.Name;
            }
            else
            {
                lblBrasGauche.Text = "Vide";
            }
            // Gestion du label monstre
            if (!CurrentGame.GetRoom().AreMonstersDead())
            {

                lblEnduranceMonstre.Text = CurrentGame.GetMonster().Endurance.ToString();
                lblMonstreHabilite.Text = CurrentGame.GetMonster().Habilite.ToString();
                lblMonstreNom.Text = CurrentGame.GetMonster().Name;
                lblMonstrePuissance.Text = CurrentGame.GetMonster().Puissance.ToString();

            }
            else
            {
                lblEnduranceMonstre.Text = string.Empty;
                lblMonstreHabilite.Text = string.Empty;
                lblMonstreNom.Text = string.Empty;
                lblMonstrePuissance.Text = string.Empty;
            }
            // Gestion de la listebox des objets
            lbxItems.Items.Clear();
            lbxItems.DisplayMember = "Name";

            for (int i = 0; i < CurrentGame.Player.Inventaire.Count(); i++)
            {

                lbxItems.Items.Add(CurrentGame.Player.Inventaire[i]);

            }
            // Gestion de la picture box
            if (pbxMonstre.Image == null && !CurrentGame.GetRoom().AreMonstersDead())
            {
                pbxMonstre.Image = CurrentGame.GetMonster().MobPicture;
                
            }
            else if (CurrentGame.GetRoom().AreMonstersDead())
            {
                pbxMonstre.Image = null;
            }
            // Death Screen
            if (!CurrentGame.IsPlayerAlive())
            {
                Death deathscreen = new Death();
                deathscreen.ShowDialog();
            }
        }

        private void FrmDarkTower_Load(object sender, EventArgs e)
        {

            CurrentGame = Sauvegarde.Deserialisation();
            /*if(CurrentGame == null)
            {
                CurrentGame = new Game(DataRaces.Vide(), DataEquipement.BrasDroit(),null, " ",DataTowers.Vide);
                CurrentGame.Player.Inventaire = new Inventory();
            }
            this.Text = CurrentGame.TheTower.Name;*/
            if(CurrentGame != null)
            {
                this.BackgroundImage = CurrentGame.TheTower.TowerImage;
            }
            
            UpdateForm();
        }

        private void btnAttaquer_Click(object sender, EventArgs e)
        {
            CurrentGame.CombatRound1v1();

            UpdateForm();
            
        }
        private void btnAvancer_Click(object sender, EventArgs e)
        {

            if (!CurrentGame.CanAdvance && !CurrentGame.GetRoom().AreMonstersDead() && CurrentGame.CanBeFlee())
            {

                CurrentGame.Fuir();
                UpdateForm(); ;
            }
            else
            {
                CurrentGame.Avancer();
                UpdateForm();
            }
            
        }
        private void btnAction_Click(object sender, EventArgs e)
        {
            
            CurrentGame.UseAction();
            UpdateForm();
            
        }

        private void btnChance_Click(object sender, EventArgs e)
        {

            if (CurrentGame.CanChanceAttack)
            {
                CurrentGame.AugmenterDegat();
            }
            else if (CurrentGame.CanChanceDefense)
            {
                CurrentGame.ReduireDegat();
            }
            UpdateForm();
            
        }
        private void UpdateButtons()
        {
            if(CurrentGame != null)
            {
                btnAvancer.Enabled = CurrentGame.CanAvanceBtnCheck();
                btnAttaquer.Enabled = CurrentGame.CanAttaqueBtnCheck();
                btnAction.Enabled = CurrentGame.CanActionBtnCheck();
                btnChance.Enabled = CurrentGame.CanChanceBtnCheck();
            }
            

            if (CurrentGame != null)
            {

                if (!CurrentGame.CanAdvance && !CurrentGame.GetRoom().AreMonstersDead() && CurrentGame.CanBeFlee())
                {

                    btnAvancer.Text = "Fuir";
                    btnAvancer.ForeColor = Color.White;
                }
                else
                {
                    btnAvancer.Text = "Avancez";
                    btnAvancer.ForeColor = Color.White;
                }

                btnAttaquer.Text = "Attaquer";
                
            }
        }



        private void lbxItems_DoubleClick(object sender, EventArgs e)
        {
            if (CurrentGame.IsPlayerAlive())
            {
                CurrentGame.UseItem(lbxItems.SelectedItem as Item);
                UpdateForm();
            }
        }



        private void lbxItems_Click(object sender, EventArgs e)
        {
            if (lbxItems.SelectedItem != null)
            {
                lbltbxItems.Text = (lbxItems.SelectedItem as Item).Description;
            }

            
        }

        private void lblNombreEnnemiTué_Click(object sender, EventArgs e)
        {
            if (CurrentGame != null)
            {
                CurrentGame.RemoveShieldOnClick();
            }
            UpdateForm();
            
        }

        private void lblArme_Click(object sender, EventArgs e)
        {
            if (CurrentGame != null)
            {
                CurrentGame.RemoveWeaponOnClick();
                
            }
            UpdateForm();
        }

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void menuStrip1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void FrmDarkTower_FormClosed(object sender, FormClosedEventArgs e)
        {
            Sauvegarde.Serialisation(CurrentGame);
        }

        private void currentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrentGame.TheTower.TowerImage != null)
            {
                this.BackgroundImage = CurrentGame.TheTower.TowerImage;
            }
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrentGame.TheTower.TowerImage != null)
            {
                this.BackgroundImage = Properties.Resources.defaultscreen;
            }
        }

        private void tsmiTarot_Click(object sender, EventArgs e)
        {
            FrmTarot tarot = new FrmTarot();
            tarot.Show();
        }

        
        private void newGamePlusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(CurrentGame != null)
            {
                if (CurrentGame.GameWon && CurrentGame.IsPlayerAlive())
                {
                    NewGamePlus newgame = new NewGamePlus();
                    newgame.Game = CurrentGame;
                    newgame.ShowDialog();
                    if (newgame.StartANewGame)
                    {
                        CurrentGame = newgame.NewGame;
                        CurrentGame.DonjonsDone = newgame.Game.DonjonsDone;
                        CurrentGame.NumberOfEnnemySlain = newgame.Game.NumberOfEnnemySlain;

                        if (CurrentGame.TheTower.TowerImage != null)
                        {
                            this.BackgroundImage = CurrentGame.TheTower.TowerImage;
                        }
                        UpdateForm();
                    }
                }
            }
            
        }

        private void sauvegarderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sauvegarde.Serialisation(CurrentGame);
        }
    }
}

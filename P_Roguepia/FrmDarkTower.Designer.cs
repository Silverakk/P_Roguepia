namespace P_Roguepia
{
    partial class FrmDarkTower
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvellePartieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTarot = new System.Windows.Forms.ToolStripMenuItem();
            this.fermerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbxLeftInfo = new System.Windows.Forms.GroupBox();
            this.lbltbxItems = new System.Windows.Forms.Label();
            this.lblNumberOfEnnemySlain = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblRaceDuJoueur = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblNomDuJoueur = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNombreEtage = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.lblTowerName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxTowerInfo = new System.Windows.Forms.GroupBox();
            this.lblCombatLogs = new System.Windows.Forms.Label();
            this.lblTowerInfo = new System.Windows.Forms.Label();
            this.lblnomsalle = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.lblnomdetage = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.gbxActions = new System.Windows.Forms.GroupBox();
            this.btnAction = new System.Windows.Forms.Button();
            this.btnAvancer = new System.Windows.Forms.Button();
            this.btnChance = new System.Windows.Forms.Button();
            this.btnAttaquer = new System.Windows.Forms.Button();
            this.gbxCaract = new System.Windows.Forms.GroupBox();
            this.lblLyre = new System.Windows.Forms.Label();
            this.lblHabilite = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblEndurance = new System.Windows.Forms.Label();
            this.lblChance = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.gbxMonster = new System.Windows.Forms.GroupBox();
            this.pbxMonstre = new System.Windows.Forms.PictureBox();
            this.label34 = new System.Windows.Forms.Label();
            this.lblMonstreNom = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.lblMonstrePuissance = new System.Windows.Forms.Label();
            this.lblEnduranceMonstre = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.lblMonstreHabilite = new System.Windows.Forms.Label();
            this.gbxWeapon = new System.Windows.Forms.GroupBox();
            this.lblBrasGauche = new System.Windows.Forms.Label();
            this.lblMalusHabiliteNumber = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblMalusHabiliteTitle = new System.Windows.Forms.Label();
            this.lblArme = new System.Windows.Forms.Label();
            this.lblPuissance = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.lbxItems = new System.Windows.Forms.ListBox();
            this.newGamePlusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sauvegarderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.gbxLeftInfo.SuspendLayout();
            this.gbxTowerInfo.SuspendLayout();
            this.gbxActions.SuspendLayout();
            this.gbxCaract.SuspendLayout();
            this.gbxMonster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMonstre)).BeginInit();
            this.gbxWeapon.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(13, 5, 0, 5);
            this.menuStrip1.Size = new System.Drawing.Size(1129, 46);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseMove);
            this.menuStrip1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseUp);
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouvellePartieToolStripMenuItem,
            this.newGamePlusToolStripMenuItem,
            this.backgroundToolStripMenuItem,
            this.tsmiTarot,
            this.sauvegarderToolStripMenuItem,
            this.fermerToolStripMenuItem});
            this.newGameToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGameToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(66, 36);
            this.newGameToolStripMenuItem.Text = "Jeu";
            // 
            // nouvellePartieToolStripMenuItem
            // 
            this.nouvellePartieToolStripMenuItem.Name = "nouvellePartieToolStripMenuItem";
            this.nouvellePartieToolStripMenuItem.Size = new System.Drawing.Size(293, 40);
            this.nouvellePartieToolStripMenuItem.Text = "Nouvelle Partie";
            this.nouvellePartieToolStripMenuItem.Click += new System.EventHandler(this.tsmiNewGame_Click);
            // 
            // backgroundToolStripMenuItem
            // 
            this.backgroundToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultToolStripMenuItem,
            this.currentToolStripMenuItem});
            this.backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            this.backgroundToolStripMenuItem.Size = new System.Drawing.Size(293, 40);
            this.backgroundToolStripMenuItem.Text = "Background";
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(198, 40);
            this.defaultToolStripMenuItem.Text = "Default";
            this.defaultToolStripMenuItem.Click += new System.EventHandler(this.defaultToolStripMenuItem_Click);
            // 
            // currentToolStripMenuItem
            // 
            this.currentToolStripMenuItem.Name = "currentToolStripMenuItem";
            this.currentToolStripMenuItem.Size = new System.Drawing.Size(198, 40);
            this.currentToolStripMenuItem.Text = "Current";
            this.currentToolStripMenuItem.Click += new System.EventHandler(this.currentToolStripMenuItem_Click);
            // 
            // tsmiTarot
            // 
            this.tsmiTarot.Name = "tsmiTarot";
            this.tsmiTarot.Size = new System.Drawing.Size(293, 40);
            this.tsmiTarot.Text = "Tarot Divinatoire";
            this.tsmiTarot.Click += new System.EventHandler(this.tsmiTarot_Click);
            // 
            // fermerToolStripMenuItem
            // 
            this.fermerToolStripMenuItem.Name = "fermerToolStripMenuItem";
            this.fermerToolStripMenuItem.Size = new System.Drawing.Size(293, 40);
            this.fermerToolStripMenuItem.Text = "Fermer";
            this.fermerToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem1_Click);
            // 
            // gbxLeftInfo
            // 
            this.gbxLeftInfo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gbxLeftInfo.Controls.Add(this.lbltbxItems);
            this.gbxLeftInfo.Controls.Add(this.lblNumberOfEnnemySlain);
            this.gbxLeftInfo.Controls.Add(this.label10);
            this.gbxLeftInfo.Controls.Add(this.lblRaceDuJoueur);
            this.gbxLeftInfo.Controls.Add(this.label8);
            this.gbxLeftInfo.Controls.Add(this.lblNomDuJoueur);
            this.gbxLeftInfo.Controls.Add(this.label4);
            this.gbxLeftInfo.Controls.Add(this.lblNombreEtage);
            this.gbxLeftInfo.Controls.Add(this.lb);
            this.gbxLeftInfo.Controls.Add(this.lblTowerName);
            this.gbxLeftInfo.Controls.Add(this.label1);
            this.gbxLeftInfo.Font = new System.Drawing.Font("MS Reference Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxLeftInfo.Location = new System.Drawing.Point(12, 42);
            this.gbxLeftInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxLeftInfo.Name = "gbxLeftInfo";
            this.gbxLeftInfo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxLeftInfo.Size = new System.Drawing.Size(212, 629);
            this.gbxLeftInfo.TabIndex = 1;
            this.gbxLeftInfo.TabStop = false;
            // 
            // lbltbxItems
            // 
            this.lbltbxItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbltbxItems.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltbxItems.ForeColor = System.Drawing.SystemColors.Control;
            this.lbltbxItems.Location = new System.Drawing.Point(14, 343);
            this.lbltbxItems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltbxItems.Name = "lbltbxItems";
            this.lbltbxItems.Size = new System.Drawing.Size(190, 274);
            this.lbltbxItems.TabIndex = 12;
            // 
            // lblNumberOfEnnemySlain
            // 
            this.lblNumberOfEnnemySlain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumberOfEnnemySlain.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfEnnemySlain.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNumberOfEnnemySlain.Location = new System.Drawing.Point(8, 295);
            this.lblNumberOfEnnemySlain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberOfEnnemySlain.Name = "lblNumberOfEnnemySlain";
            this.lblNumberOfEnnemySlain.Size = new System.Drawing.Size(195, 30);
            this.lblNumberOfEnnemySlain.TabIndex = 11;
            this.lblNumberOfEnnemySlain.Text = "999";
            this.lblNumberOfEnnemySlain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(8, 265);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(195, 30);
            this.label10.TabIndex = 10;
            this.label10.Text = "Ennemis tués";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRaceDuJoueur
            // 
            this.lblRaceDuJoueur.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRaceDuJoueur.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaceDuJoueur.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRaceDuJoueur.Location = new System.Drawing.Point(8, 234);
            this.lblRaceDuJoueur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRaceDuJoueur.Name = "lblRaceDuJoueur";
            this.lblRaceDuJoueur.Size = new System.Drawing.Size(195, 30);
            this.lblRaceDuJoueur.TabIndex = 9;
            this.lblRaceDuJoueur.Text = "RaceExemple";
            this.lblRaceDuJoueur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(8, 204);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 30);
            this.label8.TabIndex = 8;
            this.label8.Text = "Race";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNomDuJoueur
            // 
            this.lblNomDuJoueur.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNomDuJoueur.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomDuJoueur.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNomDuJoueur.Location = new System.Drawing.Point(8, 167);
            this.lblNomDuJoueur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomDuJoueur.Name = "lblNomDuJoueur";
            this.lblNomDuJoueur.Size = new System.Drawing.Size(195, 30);
            this.lblNomDuJoueur.TabIndex = 7;
            this.lblNomDuJoueur.Text = "Exemple Nom";
            this.lblNomDuJoueur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(8, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nom";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombreEtage
            // 
            this.lblNombreEtage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombreEtage.CausesValidation = false;
            this.lblNombreEtage.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEtage.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombreEtage.Location = new System.Drawing.Point(8, 107);
            this.lblNombreEtage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreEtage.Name = "lblNombreEtage";
            this.lblNombreEtage.Size = new System.Drawing.Size(195, 30);
            this.lblNombreEtage.TabIndex = 3;
            this.lblNombreEtage.Text = "0";
            this.lblNombreEtage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb
            // 
            this.lb.CausesValidation = false;
            this.lb.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.ForeColor = System.Drawing.SystemColors.Control;
            this.lb.Location = new System.Drawing.Point(8, 77);
            this.lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(195, 30);
            this.lb.TabIndex = 2;
            this.lb.Text = "Étage";
            this.lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTowerName
            // 
            this.lblTowerName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTowerName.CausesValidation = false;
            this.lblTowerName.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTowerName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTowerName.Location = new System.Drawing.Point(8, 47);
            this.lblTowerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTowerName.Name = "lblTowerName";
            this.lblTowerName.Size = new System.Drawing.Size(195, 30);
            this.lblTowerName.TabIndex = 1;
            this.lblTowerName.Text = "DonjonTest";
            this.lblTowerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tour";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbxTowerInfo
            // 
            this.gbxTowerInfo.Controls.Add(this.lblCombatLogs);
            this.gbxTowerInfo.Controls.Add(this.lblTowerInfo);
            this.gbxTowerInfo.Controls.Add(this.lblnomsalle);
            this.gbxTowerInfo.Controls.Add(this.label39);
            this.gbxTowerInfo.Controls.Add(this.lblnomdetage);
            this.gbxTowerInfo.Controls.Add(this.label37);
            this.gbxTowerInfo.Location = new System.Drawing.Point(231, 42);
            this.gbxTowerInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxTowerInfo.Name = "gbxTowerInfo";
            this.gbxTowerInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxTowerInfo.Size = new System.Drawing.Size(585, 338);
            this.gbxTowerInfo.TabIndex = 2;
            this.gbxTowerInfo.TabStop = false;
            // 
            // lblCombatLogs
            // 
            this.lblCombatLogs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCombatLogs.Location = new System.Drawing.Point(375, 107);
            this.lblCombatLogs.Name = "lblCombatLogs";
            this.lblCombatLogs.Size = new System.Drawing.Size(203, 217);
            this.lblCombatLogs.TabIndex = 18;
            this.lblCombatLogs.Text = "label3";
            // 
            // lblTowerInfo
            // 
            this.lblTowerInfo.Location = new System.Drawing.Point(7, 107);
            this.lblTowerInfo.Name = "lblTowerInfo";
            this.lblTowerInfo.Size = new System.Drawing.Size(362, 217);
            this.lblTowerInfo.TabIndex = 17;
            this.lblTowerInfo.Text = "label3";
            // 
            // lblnomsalle
            // 
            this.lblnomsalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblnomsalle.CausesValidation = false;
            this.lblnomsalle.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnomsalle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblnomsalle.Location = new System.Drawing.Point(308, 59);
            this.lblnomsalle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnomsalle.Name = "lblnomsalle";
            this.lblnomsalle.Size = new System.Drawing.Size(270, 30);
            this.lblnomsalle.TabIndex = 16;
            this.lblnomsalle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label39
            // 
            this.label39.CausesValidation = false;
            this.label39.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.SystemColors.Control;
            this.label39.Location = new System.Drawing.Point(308, 29);
            this.label39.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(270, 30);
            this.label39.TabIndex = 15;
            this.label39.Text = "Nom de la salle";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblnomdetage
            // 
            this.lblnomdetage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblnomdetage.CausesValidation = false;
            this.lblnomdetage.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnomdetage.ForeColor = System.Drawing.SystemColors.Control;
            this.lblnomdetage.Location = new System.Drawing.Point(7, 59);
            this.lblnomdetage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnomdetage.Name = "lblnomdetage";
            this.lblnomdetage.Size = new System.Drawing.Size(270, 30);
            this.lblnomdetage.TabIndex = 14;
            this.lblnomdetage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label37
            // 
            this.label37.CausesValidation = false;
            this.label37.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.SystemColors.Control;
            this.label37.Location = new System.Drawing.Point(7, 29);
            this.label37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(270, 30);
            this.label37.TabIndex = 13;
            this.label37.Text = "Nom de l\'étage";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbxActions
            // 
            this.gbxActions.Controls.Add(this.btnAction);
            this.gbxActions.Controls.Add(this.btnAvancer);
            this.gbxActions.Controls.Add(this.btnChance);
            this.gbxActions.Controls.Add(this.btnAttaquer);
            this.gbxActions.Location = new System.Drawing.Point(419, 385);
            this.gbxActions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxActions.Name = "gbxActions";
            this.gbxActions.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxActions.Size = new System.Drawing.Size(276, 286);
            this.gbxActions.TabIndex = 3;
            this.gbxActions.TabStop = false;
            // 
            // btnAction
            // 
            this.btnAction.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAction.Location = new System.Drawing.Point(141, 149);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(120, 120);
            this.btnAction.TabIndex = 3;
            this.btnAction.Text = "Action";
            this.btnAction.UseVisualStyleBackColor = false;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // btnAvancer
            // 
            this.btnAvancer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAvancer.Location = new System.Drawing.Point(141, 26);
            this.btnAvancer.Name = "btnAvancer";
            this.btnAvancer.Size = new System.Drawing.Size(120, 120);
            this.btnAvancer.TabIndex = 2;
            this.btnAvancer.Text = "Avancer";
            this.btnAvancer.UseVisualStyleBackColor = false;
            this.btnAvancer.Click += new System.EventHandler(this.btnAvancer_Click);
            // 
            // btnChance
            // 
            this.btnChance.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnChance.Location = new System.Drawing.Point(15, 149);
            this.btnChance.Name = "btnChance";
            this.btnChance.Size = new System.Drawing.Size(120, 120);
            this.btnChance.TabIndex = 1;
            this.btnChance.Text = "Tenter sa chance";
            this.btnChance.UseVisualStyleBackColor = false;
            this.btnChance.Click += new System.EventHandler(this.btnChance_Click);
            // 
            // btnAttaquer
            // 
            this.btnAttaquer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAttaquer.Location = new System.Drawing.Point(15, 26);
            this.btnAttaquer.Name = "btnAttaquer";
            this.btnAttaquer.Size = new System.Drawing.Size(120, 120);
            this.btnAttaquer.TabIndex = 0;
            this.btnAttaquer.Text = "Attaquer";
            this.btnAttaquer.UseVisualStyleBackColor = false;
            this.btnAttaquer.Click += new System.EventHandler(this.btnAttaquer_Click);
            // 
            // gbxCaract
            // 
            this.gbxCaract.Controls.Add(this.lblLyre);
            this.gbxCaract.Controls.Add(this.lblHabilite);
            this.gbxCaract.Controls.Add(this.label25);
            this.gbxCaract.Controls.Add(this.label17);
            this.gbxCaract.Controls.Add(this.label13);
            this.gbxCaract.Controls.Add(this.lblEndurance);
            this.gbxCaract.Controls.Add(this.lblChance);
            this.gbxCaract.Controls.Add(this.label15);
            this.gbxCaract.Location = new System.Drawing.Point(701, 385);
            this.gbxCaract.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxCaract.Name = "gbxCaract";
            this.gbxCaract.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxCaract.Size = new System.Drawing.Size(205, 286);
            this.gbxCaract.TabIndex = 3;
            this.gbxCaract.TabStop = false;
            // 
            // lblLyre
            // 
            this.lblLyre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLyre.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLyre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLyre.Location = new System.Drawing.Point(7, 239);
            this.lblLyre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLyre.Name = "lblLyre";
            this.lblLyre.Size = new System.Drawing.Size(191, 30);
            this.lblLyre.TabIndex = 14;
            this.lblLyre.Text = "999";
            this.lblLyre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHabilite
            // 
            this.lblHabilite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHabilite.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHabilite.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHabilite.Location = new System.Drawing.Point(7, 179);
            this.lblHabilite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHabilite.Name = "lblHabilite";
            this.lblHabilite.Size = new System.Drawing.Size(191, 30);
            this.lblHabilite.TabIndex = 18;
            this.lblHabilite.Text = "0";
            this.lblHabilite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.SystemColors.Control;
            this.label25.Location = new System.Drawing.Point(7, 213);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(191, 30);
            this.label25.TabIndex = 13;
            this.label25.Text = "Lyres";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.Control;
            this.label17.Location = new System.Drawing.Point(7, 26);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(191, 30);
            this.label17.TabIndex = 13;
            this.label17.Text = "Endurance";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(7, 149);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(191, 30);
            this.label13.TabIndex = 17;
            this.label13.Text = "Habilité";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEndurance
            // 
            this.lblEndurance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEndurance.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndurance.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEndurance.Location = new System.Drawing.Point(7, 56);
            this.lblEndurance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndurance.Name = "lblEndurance";
            this.lblEndurance.Size = new System.Drawing.Size(191, 30);
            this.lblEndurance.TabIndex = 14;
            this.lblEndurance.Text = "0";
            this.lblEndurance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblChance
            // 
            this.lblChance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblChance.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChance.ForeColor = System.Drawing.SystemColors.Control;
            this.lblChance.Location = new System.Drawing.Point(7, 118);
            this.lblChance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChance.Name = "lblChance";
            this.lblChance.Size = new System.Drawing.Size(191, 30);
            this.lblChance.TabIndex = 16;
            this.lblChance.Text = "0";
            this.lblChance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(7, 86);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(191, 30);
            this.label15.TabIndex = 15;
            this.label15.Text = "Chance";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbxMonster
            // 
            this.gbxMonster.Controls.Add(this.pbxMonstre);
            this.gbxMonster.Controls.Add(this.label34);
            this.gbxMonster.Controls.Add(this.lblMonstreNom);
            this.gbxMonster.Controls.Add(this.label32);
            this.gbxMonster.Controls.Add(this.lblMonstrePuissance);
            this.gbxMonster.Controls.Add(this.lblEnduranceMonstre);
            this.gbxMonster.Controls.Add(this.label28);
            this.gbxMonster.Controls.Add(this.label29);
            this.gbxMonster.Controls.Add(this.lblMonstreHabilite);
            this.gbxMonster.Location = new System.Drawing.Point(822, 42);
            this.gbxMonster.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxMonster.Name = "gbxMonster";
            this.gbxMonster.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxMonster.Size = new System.Drawing.Size(295, 338);
            this.gbxMonster.TabIndex = 3;
            this.gbxMonster.TabStop = false;
            // 
            // pbxMonstre
            // 
            this.pbxMonstre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxMonstre.Location = new System.Drawing.Point(78, 25);
            this.pbxMonstre.Name = "pbxMonstre";
            this.pbxMonstre.Size = new System.Drawing.Size(134, 134);
            this.pbxMonstre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMonstre.TabIndex = 28;
            this.pbxMonstre.TabStop = false;
            // 
            // label34
            // 
            this.label34.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label34.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label34.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.SystemColors.Control;
            this.label34.Location = new System.Drawing.Point(148, 168);
            this.label34.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(134, 30);
            this.label34.TabIndex = 27;
            this.label34.Text = "Nom";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMonstreNom
            // 
            this.lblMonstreNom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMonstreNom.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonstreNom.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMonstreNom.Location = new System.Drawing.Point(6, 168);
            this.lblMonstreNom.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblMonstreNom.Name = "lblMonstreNom";
            this.lblMonstreNom.Size = new System.Drawing.Size(134, 30);
            this.lblMonstreNom.TabIndex = 26;
            this.lblMonstreNom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label32
            // 
            this.label32.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label32.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label32.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.SystemColors.Control;
            this.label32.Location = new System.Drawing.Point(148, 207);
            this.label32.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(134, 30);
            this.label32.TabIndex = 25;
            this.label32.Text = "Endurance";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMonstrePuissance
            // 
            this.lblMonstrePuissance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMonstrePuissance.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonstrePuissance.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMonstrePuissance.Location = new System.Drawing.Point(6, 287);
            this.lblMonstrePuissance.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblMonstrePuissance.Name = "lblMonstrePuissance";
            this.lblMonstrePuissance.Size = new System.Drawing.Size(134, 30);
            this.lblMonstrePuissance.TabIndex = 19;
            this.lblMonstrePuissance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEnduranceMonstre
            // 
            this.lblEnduranceMonstre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEnduranceMonstre.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnduranceMonstre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEnduranceMonstre.Location = new System.Drawing.Point(6, 207);
            this.lblEnduranceMonstre.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblEnduranceMonstre.Name = "lblEnduranceMonstre";
            this.lblEnduranceMonstre.Size = new System.Drawing.Size(134, 30);
            this.lblEnduranceMonstre.TabIndex = 24;
            this.lblEnduranceMonstre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label28
            // 
            this.label28.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label28.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label28.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.SystemColors.Control;
            this.label28.Location = new System.Drawing.Point(148, 287);
            this.label28.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(134, 30);
            this.label28.TabIndex = 21;
            this.label28.Text = "Puissance";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label29
            // 
            this.label29.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label29.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label29.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.SystemColors.Control;
            this.label29.Location = new System.Drawing.Point(148, 247);
            this.label29.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(134, 30);
            this.label29.TabIndex = 23;
            this.label29.Text = "Habilité";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMonstreHabilite
            // 
            this.lblMonstreHabilite.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMonstreHabilite.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonstreHabilite.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMonstreHabilite.Location = new System.Drawing.Point(6, 247);
            this.lblMonstreHabilite.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblMonstreHabilite.Name = "lblMonstreHabilite";
            this.lblMonstreHabilite.Size = new System.Drawing.Size(134, 30);
            this.lblMonstreHabilite.TabIndex = 22;
            this.lblMonstreHabilite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbxWeapon
            // 
            this.gbxWeapon.Controls.Add(this.lblBrasGauche);
            this.gbxWeapon.Controls.Add(this.lblMalusHabiliteNumber);
            this.gbxWeapon.Controls.Add(this.label20);
            this.gbxWeapon.Controls.Add(this.label21);
            this.gbxWeapon.Controls.Add(this.lblMalusHabiliteTitle);
            this.gbxWeapon.Controls.Add(this.lblArme);
            this.gbxWeapon.Controls.Add(this.lblPuissance);
            this.gbxWeapon.Controls.Add(this.label27);
            this.gbxWeapon.Location = new System.Drawing.Point(912, 385);
            this.gbxWeapon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxWeapon.Name = "gbxWeapon";
            this.gbxWeapon.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxWeapon.Size = new System.Drawing.Size(205, 286);
            this.gbxWeapon.TabIndex = 19;
            this.gbxWeapon.TabStop = false;
            // 
            // lblBrasGauche
            // 
            this.lblBrasGauche.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBrasGauche.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrasGauche.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBrasGauche.Location = new System.Drawing.Point(7, 239);
            this.lblBrasGauche.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBrasGauche.Name = "lblBrasGauche";
            this.lblBrasGauche.Size = new System.Drawing.Size(191, 30);
            this.lblBrasGauche.TabIndex = 14;
            this.lblBrasGauche.Text = "NOMBOUCLIER";
            this.lblBrasGauche.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBrasGauche.Click += new System.EventHandler(this.lblNombreEnnemiTué_Click);
            // 
            // lblMalusHabiliteNumber
            // 
            this.lblMalusHabiliteNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMalusHabiliteNumber.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMalusHabiliteNumber.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMalusHabiliteNumber.Location = new System.Drawing.Point(7, 179);
            this.lblMalusHabiliteNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMalusHabiliteNumber.Name = "lblMalusHabiliteNumber";
            this.lblMalusHabiliteNumber.Size = new System.Drawing.Size(191, 30);
            this.lblMalusHabiliteNumber.TabIndex = 18;
            this.lblMalusHabiliteNumber.Text = "0";
            this.lblMalusHabiliteNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.Control;
            this.label20.Location = new System.Drawing.Point(7, 213);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(191, 30);
            this.label20.TabIndex = 13;
            this.label20.Text = "Protection";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.Control;
            this.label21.Location = new System.Drawing.Point(7, 26);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(191, 30);
            this.label21.TabIndex = 13;
            this.label21.Text = "Arme";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMalusHabiliteTitle
            // 
            this.lblMalusHabiliteTitle.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMalusHabiliteTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMalusHabiliteTitle.Location = new System.Drawing.Point(7, 149);
            this.lblMalusHabiliteTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMalusHabiliteTitle.Name = "lblMalusHabiliteTitle";
            this.lblMalusHabiliteTitle.Size = new System.Drawing.Size(191, 30);
            this.lblMalusHabiliteTitle.TabIndex = 17;
            this.lblMalusHabiliteTitle.Text = "Malus";
            this.lblMalusHabiliteTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArme
            // 
            this.lblArme.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblArme.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArme.ForeColor = System.Drawing.SystemColors.Control;
            this.lblArme.Location = new System.Drawing.Point(7, 56);
            this.lblArme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArme.Name = "lblArme";
            this.lblArme.Size = new System.Drawing.Size(191, 30);
            this.lblArme.TabIndex = 14;
            this.lblArme.Text = "NOMDARME";
            this.lblArme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblArme.Click += new System.EventHandler(this.lblArme_Click);
            // 
            // lblPuissance
            // 
            this.lblPuissance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPuissance.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuissance.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPuissance.Location = new System.Drawing.Point(7, 118);
            this.lblPuissance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPuissance.Name = "lblPuissance";
            this.lblPuissance.Size = new System.Drawing.Size(191, 30);
            this.lblPuissance.TabIndex = 16;
            this.lblPuissance.Text = "0";
            this.lblPuissance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            this.label27.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.SystemColors.Control;
            this.label27.Location = new System.Drawing.Point(7, 86);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(191, 30);
            this.label27.TabIndex = 15;
            this.label27.Text = "Puissance";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbxItems
            // 
            this.lbxItems.FormattingEnabled = true;
            this.lbxItems.ItemHeight = 27;
            this.lbxItems.Location = new System.Drawing.Point(231, 385);
            this.lbxItems.Name = "lbxItems";
            this.lbxItems.Size = new System.Drawing.Size(182, 274);
            this.lbxItems.TabIndex = 4;
            this.lbxItems.Click += new System.EventHandler(this.lbxItems_Click);
            this.lbxItems.DoubleClick += new System.EventHandler(this.lbxItems_DoubleClick);
            // 
            // newGamePlusToolStripMenuItem
            // 
            this.newGamePlusToolStripMenuItem.Name = "newGamePlusToolStripMenuItem";
            this.newGamePlusToolStripMenuItem.Size = new System.Drawing.Size(293, 40);
            this.newGamePlusToolStripMenuItem.Text = "New Game Plus";
            this.newGamePlusToolStripMenuItem.Click += new System.EventHandler(this.newGamePlusToolStripMenuItem_Click);
            // 
            // sauvegarderToolStripMenuItem
            // 
            this.sauvegarderToolStripMenuItem.Name = "sauvegarderToolStripMenuItem";
            this.sauvegarderToolStripMenuItem.Size = new System.Drawing.Size(293, 40);
            this.sauvegarderToolStripMenuItem.Text = "Sauvegarder";
            this.sauvegarderToolStripMenuItem.Click += new System.EventHandler(this.sauvegarderToolStripMenuItem_Click);
            // 
            // FrmDarkTower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::P_Roguepia.Properties.Resources.defaultscreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1129, 701);
            this.Controls.Add(this.lbxItems);
            this.Controls.Add(this.gbxWeapon);
            this.Controls.Add(this.gbxMonster);
            this.Controls.Add(this.gbxCaract);
            this.Controls.Add(this.gbxActions);
            this.Controls.Add(this.gbxTowerInfo);
            this.Controls.Add(this.gbxLeftInfo);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmDarkTower";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmDarkTower_FormClosed);
            this.Load += new System.EventHandler(this.FrmDarkTower_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbxLeftInfo.ResumeLayout(false);
            this.gbxTowerInfo.ResumeLayout(false);
            this.gbxActions.ResumeLayout(false);
            this.gbxCaract.ResumeLayout(false);
            this.gbxMonster.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxMonstre)).EndInit();
            this.gbxWeapon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox gbxLeftInfo;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouvellePartieToolStripMenuItem;
        private System.Windows.Forms.Label lblNomDuJoueur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbltbxItems;
        private System.Windows.Forms.Label lblNumberOfEnnemySlain;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gbxTowerInfo;
        private System.Windows.Forms.GroupBox gbxActions;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Button btnAvancer;
        private System.Windows.Forms.Button btnChance;
        private System.Windows.Forms.Button btnAttaquer;
        private System.Windows.Forms.GroupBox gbxCaract;
        private System.Windows.Forms.Label lblNombreEtage;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label lblTowerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHabilite;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblEndurance;
        private System.Windows.Forms.Label lblChance;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox gbxMonster;
        private System.Windows.Forms.Label lblRaceDuJoueur;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblLyre;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label lblMonstrePuissance;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label lblMonstreNom;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label lblEnduranceMonstre;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label lblMonstreHabilite;
        private System.Windows.Forms.GroupBox gbxWeapon;
        private System.Windows.Forms.Label lblBrasGauche;
        private System.Windows.Forms.Label lblMalusHabiliteNumber;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblMalusHabiliteTitle;
        private System.Windows.Forms.Label lblArme;
        private System.Windows.Forms.Label lblPuissance;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lblnomsalle;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label lblnomdetage;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.ToolStripMenuItem fermerToolStripMenuItem;
        private System.Windows.Forms.Label lblTowerInfo;
        private System.Windows.Forms.ToolStripMenuItem backgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiTarot;
        private System.Windows.Forms.PictureBox pbxMonstre;
        private System.Windows.Forms.ListBox lbxItems;
        private System.Windows.Forms.Label lblCombatLogs;
        private System.Windows.Forms.ToolStripMenuItem newGamePlusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sauvegarderToolStripMenuItem;
    }
}


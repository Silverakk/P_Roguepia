namespace P_Roguepia
{
    partial class NewGamePlus
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblSelectedInfo = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.gbxDonjon = new System.Windows.Forms.GroupBox();
            this.lbxDonjons = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblArme = new System.Windows.Forms.Label();
            this.lblArmeInfo = new System.Windows.Forms.Label();
            this.lblHabilite = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblChance = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblEndurance = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblNumberOfEnnemySlain = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblLyres = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblRace = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxShop = new System.Windows.Forms.GroupBox();
            this.lbxShop = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbxInventory = new System.Windows.Forms.ListBox();
            this.groupBox3.SuspendLayout();
            this.gbxDonjon.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbxShop.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblSelectedInfo);
            this.groupBox3.Location = new System.Drawing.Point(194, 289);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(541, 197);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // lblSelectedInfo
            // 
            this.lblSelectedInfo.Location = new System.Drawing.Point(6, 22);
            this.lblSelectedInfo.Name = "lblSelectedInfo";
            this.lblSelectedInfo.Size = new System.Drawing.Size(529, 160);
            this.lblSelectedInfo.TabIndex = 0;
            this.lblSelectedInfo.Text = "label1";
            // 
            // btnNewGame
            // 
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.Location = new System.Drawing.Point(194, 492);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(541, 83);
            this.btnNewGame.TabIndex = 10;
            this.btnNewGame.Text = "N o u v e l l e   P a r t i e";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // gbxDonjon
            // 
            this.gbxDonjon.Controls.Add(this.lbxDonjons);
            this.gbxDonjon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDonjon.Location = new System.Drawing.Point(559, 12);
            this.gbxDonjon.Name = "gbxDonjon";
            this.gbxDonjon.Size = new System.Drawing.Size(176, 281);
            this.gbxDonjon.TabIndex = 15;
            this.gbxDonjon.TabStop = false;
            this.gbxDonjon.Text = "Donjon";
            // 
            // lbxDonjons
            // 
            this.lbxDonjons.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxDonjons.FormattingEnabled = true;
            this.lbxDonjons.ItemHeight = 22;
            this.lbxDonjons.Location = new System.Drawing.Point(6, 25);
            this.lbxDonjons.Name = "lbxDonjons";
            this.lbxDonjons.Size = new System.Drawing.Size(153, 246);
            this.lbxDonjons.TabIndex = 0;
            this.lbxDonjons.SelectedIndexChanged += new System.EventHandler(this.lbxDonjons_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblArme);
            this.groupBox2.Controls.Add(this.lblArmeInfo);
            this.groupBox2.Controls.Add(this.lblHabilite);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.lblChance);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.lblEndurance);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.lblNumberOfEnnemySlain);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblLyres);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblRace);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblNom);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(194, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 281);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personnage";
            // 
            // lblArme
            // 
            this.lblArme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArme.Location = new System.Drawing.Point(177, 232);
            this.lblArme.Name = "lblArme";
            this.lblArme.Size = new System.Drawing.Size(163, 30);
            this.lblArme.TabIndex = 15;
            this.lblArme.Text = "000";
            this.lblArme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArmeInfo
            // 
            this.lblArmeInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblArmeInfo.Location = new System.Drawing.Point(177, 202);
            this.lblArmeInfo.Name = "lblArmeInfo";
            this.lblArmeInfo.Size = new System.Drawing.Size(163, 30);
            this.lblArmeInfo.TabIndex = 14;
            this.lblArmeInfo.Text = "Ame";
            this.lblArmeInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHabilite
            // 
            this.lblHabilite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHabilite.Location = new System.Drawing.Point(177, 172);
            this.lblHabilite.Name = "lblHabilite";
            this.lblHabilite.Size = new System.Drawing.Size(163, 30);
            this.lblHabilite.TabIndex = 13;
            this.lblHabilite.Text = "000";
            this.lblHabilite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(177, 142);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(163, 30);
            this.label12.TabIndex = 12;
            this.label12.Text = "Habilité";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblChance
            // 
            this.lblChance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChance.Location = new System.Drawing.Point(177, 112);
            this.lblChance.Name = "lblChance";
            this.lblChance.Size = new System.Drawing.Size(163, 30);
            this.lblChance.TabIndex = 11;
            this.lblChance.Text = "Race";
            this.lblChance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Location = new System.Drawing.Point(177, 82);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(163, 30);
            this.label14.TabIndex = 10;
            this.label14.Text = "Chance";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEndurance
            // 
            this.lblEndurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndurance.Location = new System.Drawing.Point(177, 52);
            this.lblEndurance.Name = "lblEndurance";
            this.lblEndurance.Size = new System.Drawing.Size(163, 30);
            this.lblEndurance.TabIndex = 9;
            this.lblEndurance.Text = "Nom";
            this.lblEndurance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label16.Location = new System.Drawing.Point(177, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(163, 30);
            this.label16.TabIndex = 8;
            this.label16.Text = "Enduance";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumberOfEnnemySlain
            // 
            this.lblNumberOfEnnemySlain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfEnnemySlain.Location = new System.Drawing.Point(6, 232);
            this.lblNumberOfEnnemySlain.Name = "lblNumberOfEnnemySlain";
            this.lblNumberOfEnnemySlain.Size = new System.Drawing.Size(165, 30);
            this.lblNumberOfEnnemySlain.TabIndex = 7;
            this.lblNumberOfEnnemySlain.Text = "000";
            this.lblNumberOfEnnemySlain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(6, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 30);
            this.label8.TabIndex = 6;
            this.label8.Text = "Ennemis Tués";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLyres
            // 
            this.lblLyres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLyres.Location = new System.Drawing.Point(6, 172);
            this.lblLyres.Name = "lblLyres";
            this.lblLyres.Size = new System.Drawing.Size(165, 30);
            this.lblLyres.TabIndex = 5;
            this.lblLyres.Text = "000";
            this.lblLyres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(6, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 30);
            this.label6.TabIndex = 4;
            this.label6.Text = "Lyres";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRace
            // 
            this.lblRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRace.Location = new System.Drawing.Point(6, 112);
            this.lblRace.Name = "lblRace";
            this.lblRace.Size = new System.Drawing.Size(165, 30);
            this.lblRace.TabIndex = 3;
            this.lblRace.Text = "Race";
            this.lblRace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(6, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 30);
            this.label4.TabIndex = 2;
            this.label4.Text = "Race";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNom
            // 
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(6, 52);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(165, 30);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom";
            this.lblNom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbxShop
            // 
            this.gbxShop.Controls.Add(this.lbxShop);
            this.gbxShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxShop.Location = new System.Drawing.Point(12, 12);
            this.gbxShop.Name = "gbxShop";
            this.gbxShop.Size = new System.Drawing.Size(176, 281);
            this.gbxShop.TabIndex = 12;
            this.gbxShop.TabStop = false;
            this.gbxShop.Text = "Shop";
            // 
            // lbxShop
            // 
            this.lbxShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxShop.FormattingEnabled = true;
            this.lbxShop.ItemHeight = 22;
            this.lbxShop.Location = new System.Drawing.Point(6, 25);
            this.lbxShop.Name = "lbxShop";
            this.lbxShop.Size = new System.Drawing.Size(153, 246);
            this.lbxShop.TabIndex = 0;
            this.lbxShop.SelectedIndexChanged += new System.EventHandler(this.lbxShop_SelectedIndexChanged);
            this.lbxShop.DoubleClick += new System.EventHandler(this.lbxShop_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbxInventory);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 289);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 286);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inventaire";
            // 
            // lbxInventory
            // 
            this.lbxInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxInventory.FormattingEnabled = true;
            this.lbxInventory.ItemHeight = 22;
            this.lbxInventory.Location = new System.Drawing.Point(6, 25);
            this.lbxInventory.Name = "lbxInventory";
            this.lbxInventory.Size = new System.Drawing.Size(153, 246);
            this.lbxInventory.TabIndex = 0;
            this.lbxInventory.SelectedIndexChanged += new System.EventHandler(this.lbxInventory_SelectedIndexChanged);
            // 
            // NewGamePlus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 596);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxDonjon);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbxShop);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnNewGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "NewGamePlus";
            this.Text = "NewGamePlus";
            this.Load += new System.EventHandler(this.NewGamePlus_Load);
            this.groupBox3.ResumeLayout(false);
            this.gbxDonjon.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.gbxShop.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblSelectedInfo;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.GroupBox gbxDonjon;
        private System.Windows.Forms.ListBox lbxDonjons;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gbxShop;
        private System.Windows.Forms.ListBox lbxShop;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLyres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblRace;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblArme;
        private System.Windows.Forms.Label lblArmeInfo;
        private System.Windows.Forms.Label lblHabilite;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblChance;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblEndurance;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblNumberOfEnnemySlain;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbxInventory;
    }
}
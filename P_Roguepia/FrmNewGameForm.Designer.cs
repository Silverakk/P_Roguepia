namespace P_RogueTower
{
    partial class FrmNewGameForm
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
            this.gbxRaces = new System.Windows.Forms.GroupBox();
            this.lbxRaces = new System.Windows.Forms.ListBox();
            this.gbxArmes = new System.Windows.Forms.GroupBox();
            this.lbxArmes = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbxStartingItems = new System.Windows.Forms.ListBox();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblSelectedInfo = new System.Windows.Forms.Label();
            this.tbxPlayerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxDonjon = new System.Windows.Forms.GroupBox();
            this.lbxDonjons = new System.Windows.Forms.ListBox();
            this.gbxRaces.SuspendLayout();
            this.gbxArmes.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbxDonjon.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxRaces
            // 
            this.gbxRaces.Controls.Add(this.lbxRaces);
            this.gbxRaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxRaces.Location = new System.Drawing.Point(12, 12);
            this.gbxRaces.Name = "gbxRaces";
            this.gbxRaces.Size = new System.Drawing.Size(176, 265);
            this.gbxRaces.TabIndex = 0;
            this.gbxRaces.TabStop = false;
            this.gbxRaces.Text = "Races";
            // 
            // lbxRaces
            // 
            this.lbxRaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxRaces.FormattingEnabled = true;
            this.lbxRaces.ItemHeight = 22;
            this.lbxRaces.Location = new System.Drawing.Point(6, 25);
            this.lbxRaces.Name = "lbxRaces";
            this.lbxRaces.Size = new System.Drawing.Size(153, 224);
            this.lbxRaces.TabIndex = 0;
            this.lbxRaces.SelectedIndexChanged += new System.EventHandler(this.lbxRaces_SelectedIndexChanged);
            // 
            // gbxArmes
            // 
            this.gbxArmes.Controls.Add(this.lbxArmes);
            this.gbxArmes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxArmes.Location = new System.Drawing.Point(194, 12);
            this.gbxArmes.Name = "gbxArmes";
            this.gbxArmes.Size = new System.Drawing.Size(176, 265);
            this.gbxArmes.TabIndex = 1;
            this.gbxArmes.TabStop = false;
            this.gbxArmes.Text = "Armes";
            // 
            // lbxArmes
            // 
            this.lbxArmes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxArmes.FormattingEnabled = true;
            this.lbxArmes.ItemHeight = 22;
            this.lbxArmes.Location = new System.Drawing.Point(6, 25);
            this.lbxArmes.Name = "lbxArmes";
            this.lbxArmes.Size = new System.Drawing.Size(153, 224);
            this.lbxArmes.TabIndex = 0;
            this.lbxArmes.SelectedIndexChanged += new System.EventHandler(this.lbxArmes_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbxStartingItems);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(376, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(176, 265);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Objet de départ";
            // 
            // lbxStartingItems
            // 
            this.lbxStartingItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxStartingItems.FormattingEnabled = true;
            this.lbxStartingItems.ItemHeight = 22;
            this.lbxStartingItems.Location = new System.Drawing.Point(6, 25);
            this.lbxStartingItems.Name = "lbxStartingItems";
            this.lbxStartingItems.Size = new System.Drawing.Size(153, 224);
            this.lbxStartingItems.TabIndex = 0;
            this.lbxStartingItems.SelectedIndexChanged += new System.EventHandler(this.lbxStartingItems_SelectedIndexChanged);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.Location = new System.Drawing.Point(12, 492);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(723, 83);
            this.btnNewGame.TabIndex = 2;
            this.btnNewGame.Text = "N o u v e l l e   P a r t i e";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblSelectedInfo);
            this.groupBox3.Location = new System.Drawing.Point(12, 315);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(723, 171);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // lblSelectedInfo
            // 
            this.lblSelectedInfo.Location = new System.Drawing.Point(6, 22);
            this.lblSelectedInfo.Name = "lblSelectedInfo";
            this.lblSelectedInfo.Size = new System.Drawing.Size(711, 146);
            this.lblSelectedInfo.TabIndex = 0;
            this.lblSelectedInfo.Text = "label1";
            // 
            // tbxPlayerName
            // 
            this.tbxPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPlayerName.Location = new System.Drawing.Point(200, 283);
            this.tbxPlayerName.Name = "tbxPlayerName";
            this.tbxPlayerName.Size = new System.Drawing.Size(529, 32);
            this.tbxPlayerName.TabIndex = 4;
            this.tbxPlayerName.TextChanged += new System.EventHandler(this.tbxPlayerName_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom du personnage :";
            // 
            // gbxDonjon
            // 
            this.gbxDonjon.Controls.Add(this.lbxDonjons);
            this.gbxDonjon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDonjon.Location = new System.Drawing.Point(559, 12);
            this.gbxDonjon.Name = "gbxDonjon";
            this.gbxDonjon.Size = new System.Drawing.Size(176, 265);
            this.gbxDonjon.TabIndex = 2;
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
            this.lbxDonjons.Size = new System.Drawing.Size(153, 224);
            this.lbxDonjons.TabIndex = 0;
            this.lbxDonjons.SelectedIndexChanged += new System.EventHandler(this.lbxDonjons_SelectedIndexChanged);
            // 
            // FrmNewGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 596);
            this.Controls.Add(this.gbxDonjon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxPlayerName);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbxArmes);
            this.Controls.Add(this.gbxRaces);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmNewGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nouvelle Partie";
            this.Load += new System.EventHandler(this.FrmNewGameForm_Load);
            this.gbxRaces.ResumeLayout(false);
            this.gbxArmes.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.gbxDonjon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxRaces;
        private System.Windows.Forms.ListBox lbxRaces;
        private System.Windows.Forms.GroupBox gbxArmes;
        private System.Windows.Forms.ListBox lbxArmes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbxStartingItems;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblSelectedInfo;
        private System.Windows.Forms.TextBox tbxPlayerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbxDonjon;
        private System.Windows.Forms.ListBox lbxDonjons;
    }
}
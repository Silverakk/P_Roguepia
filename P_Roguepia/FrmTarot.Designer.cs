namespace P_Tarot
{
    partial class FrmTarot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTarot));
            this.gbxDecks = new System.Windows.Forms.GroupBox();
            this.rbtnTarotMer = new System.Windows.Forms.RadioButton();
            this.rbtnPacteEtoiles = new System.Windows.Forms.RadioButton();
            this.rbtnBriscola = new System.Windows.Forms.RadioButton();
            this.rbtnTarotEgytian = new System.Windows.Forms.RadioButton();
            this.rbtnRiderWaite = new System.Windows.Forms.RadioButton();
            this.rbtn36CardsGame = new System.Windows.Forms.RadioButton();
            this.rbtnTarotDeMarseille = new System.Windows.Forms.RadioButton();
            this.rbtnNormalCardGame = new System.Windows.Forms.RadioButton();
            this.btnDraw = new System.Windows.Forms.Button();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.tbxTirage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTirageEnCroix = new System.Windows.Forms.Button();
            this.btnTirageEnLigne = new System.Windows.Forms.Button();
            this.numTirageEnLigne = new System.Windows.Forms.NumericUpDown();
            this.gbxDecks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTirageEnLigne)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxDecks
            // 
            this.gbxDecks.Controls.Add(this.rbtnTarotMer);
            this.gbxDecks.Controls.Add(this.rbtnPacteEtoiles);
            this.gbxDecks.Controls.Add(this.rbtnBriscola);
            this.gbxDecks.Controls.Add(this.rbtnTarotEgytian);
            this.gbxDecks.Controls.Add(this.rbtnRiderWaite);
            this.gbxDecks.Controls.Add(this.rbtn36CardsGame);
            this.gbxDecks.Controls.Add(this.rbtnTarotDeMarseille);
            this.gbxDecks.Controls.Add(this.rbtnNormalCardGame);
            this.gbxDecks.Location = new System.Drawing.Point(15, 12);
            this.gbxDecks.Name = "gbxDecks";
            this.gbxDecks.Size = new System.Drawing.Size(213, 282);
            this.gbxDecks.TabIndex = 6;
            this.gbxDecks.TabStop = false;
            // 
            // rbtnTarotMer
            // 
            this.rbtnTarotMer.AutoSize = true;
            this.rbtnTarotMer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnTarotMer.Location = new System.Drawing.Point(16, 115);
            this.rbtnTarotMer.Name = "rbtnTarotMer";
            this.rbtnTarotMer.Size = new System.Drawing.Size(154, 24);
            this.rbtnTarotMer.TabIndex = 7;
            this.rbtnTarotMer.Text = "Tarot des Mers";
            this.rbtnTarotMer.UseVisualStyleBackColor = true;
            this.rbtnTarotMer.CheckedChanged += new System.EventHandler(this.rbtnTarotMer_CheckedChanged);
            // 
            // rbtnPacteEtoiles
            // 
            this.rbtnPacteEtoiles.AutoSize = true;
            this.rbtnPacteEtoiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPacteEtoiles.Location = new System.Drawing.Point(16, 145);
            this.rbtnPacteEtoiles.Name = "rbtnPacteEtoiles";
            this.rbtnPacteEtoiles.Size = new System.Drawing.Size(174, 24);
            this.rbtnPacteEtoiles.TabIndex = 6;
            this.rbtnPacteEtoiles.Text = "Pacte des Étoiles";
            this.rbtnPacteEtoiles.UseVisualStyleBackColor = true;
            this.rbtnPacteEtoiles.CheckedChanged += new System.EventHandler(this.rbtnPacteEtoiles_CheckedChanged);
            // 
            // rbtnBriscola
            // 
            this.rbtnBriscola.AutoSize = true;
            this.rbtnBriscola.Location = new System.Drawing.Point(16, 235);
            this.rbtnBriscola.Name = "rbtnBriscola";
            this.rbtnBriscola.Size = new System.Drawing.Size(90, 24);
            this.rbtnBriscola.TabIndex = 5;
            this.rbtnBriscola.Text = "Briscola";
            this.rbtnBriscola.UseVisualStyleBackColor = true;
            this.rbtnBriscola.CheckedChanged += new System.EventHandler(this.rbtnBriscola_CheckedChanged);
            // 
            // rbtnTarotEgytian
            // 
            this.rbtnTarotEgytian.AutoSize = true;
            this.rbtnTarotEgytian.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnTarotEgytian.Location = new System.Drawing.Point(16, 85);
            this.rbtnTarotEgytian.Name = "rbtnTarotEgytian";
            this.rbtnTarotEgytian.Size = new System.Drawing.Size(194, 24);
            this.rbtnTarotEgytian.TabIndex = 2;
            this.rbtnTarotEgytian.Text = "Tarot des Égyptiens";
            this.rbtnTarotEgytian.UseVisualStyleBackColor = true;
            this.rbtnTarotEgytian.CheckedChanged += new System.EventHandler(this.rbtnTarotEgytian_CheckedChanged);
            // 
            // rbtnRiderWaite
            // 
            this.rbtnRiderWaite.AutoSize = true;
            this.rbtnRiderWaite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnRiderWaite.Location = new System.Drawing.Point(16, 55);
            this.rbtnRiderWaite.Name = "rbtnRiderWaite";
            this.rbtnRiderWaite.Size = new System.Drawing.Size(176, 24);
            this.rbtnRiderWaite.TabIndex = 1;
            this.rbtnRiderWaite.Text = "Tarot Rider-Waite";
            this.rbtnRiderWaite.UseVisualStyleBackColor = true;
            this.rbtnRiderWaite.CheckedChanged += new System.EventHandler(this.rbtnRiderWaite_CheckedChanged);
            // 
            // rbtn36CardsGame
            // 
            this.rbtn36CardsGame.AutoSize = true;
            this.rbtn36CardsGame.Location = new System.Drawing.Point(16, 205);
            this.rbtn36CardsGame.Name = "rbtn36CardsGame";
            this.rbtn36CardsGame.Size = new System.Drawing.Size(152, 24);
            this.rbtn36CardsGame.TabIndex = 4;
            this.rbtn36CardsGame.Text = "Jeu de 36 cartes";
            this.rbtn36CardsGame.UseVisualStyleBackColor = true;
            this.rbtn36CardsGame.CheckedChanged += new System.EventHandler(this.rbtn36CardsGame_CheckedChanged);
            // 
            // rbtnTarotDeMarseille
            // 
            this.rbtnTarotDeMarseille.AutoSize = true;
            this.rbtnTarotDeMarseille.Checked = true;
            this.rbtnTarotDeMarseille.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnTarotDeMarseille.Location = new System.Drawing.Point(16, 25);
            this.rbtnTarotDeMarseille.Name = "rbtnTarotDeMarseille";
            this.rbtnTarotDeMarseille.Size = new System.Drawing.Size(177, 24);
            this.rbtnTarotDeMarseille.TabIndex = 0;
            this.rbtnTarotDeMarseille.TabStop = true;
            this.rbtnTarotDeMarseille.Text = "Tarot de Marseille";
            this.rbtnTarotDeMarseille.UseVisualStyleBackColor = true;
            this.rbtnTarotDeMarseille.CheckedChanged += new System.EventHandler(this.rbtnTarotDeMarseille_CheckedChanged);
            // 
            // rbtnNormalCardGame
            // 
            this.rbtnNormalCardGame.AutoSize = true;
            this.rbtnNormalCardGame.Location = new System.Drawing.Point(16, 175);
            this.rbtnNormalCardGame.Name = "rbtnNormalCardGame";
            this.rbtnNormalCardGame.Size = new System.Drawing.Size(152, 24);
            this.rbtnNormalCardGame.TabIndex = 3;
            this.rbtnNormalCardGame.Text = "Jeu de 54 cartes";
            this.rbtnNormalCardGame.UseVisualStyleBackColor = true;
            this.rbtnNormalCardGame.CheckedChanged += new System.EventHandler(this.rbtnNormalCardGame_CheckedChanged);
            // 
            // btnDraw
            // 
            this.btnDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDraw.Location = new System.Drawing.Point(15, 300);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(213, 61);
            this.btnDraw.TabIndex = 1;
            this.btnDraw.Text = "Tirage Simple";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // btnShuffle
            // 
            this.btnShuffle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShuffle.Location = new System.Drawing.Point(15, 508);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(213, 68);
            this.btnShuffle.TabIndex = 5;
            this.btnShuffle.Text = "Mélanger";
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // tbxTirage
            // 
            this.tbxTirage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxTirage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTirage.Location = new System.Drawing.Point(234, 12);
            this.tbxTirage.Multiline = true;
            this.tbxTirage.Name = "tbxTirage";
            this.tbxTirage.ReadOnly = true;
            this.tbxTirage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxTirage.Size = new System.Drawing.Size(488, 646);
            this.tbxTirage.TabIndex = 7;
            this.tbxTirage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxTirage.WordWrap = false;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 579);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 79);
            this.label1.TabIndex = 0;
            this.label1.Text = "L\'interprétation des cartes dépend entièrement du conteur.\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTirageEnCroix
            // 
            this.btnTirageEnCroix.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTirageEnCroix.Location = new System.Drawing.Point(15, 367);
            this.btnTirageEnCroix.Name = "btnTirageEnCroix";
            this.btnTirageEnCroix.Size = new System.Drawing.Size(213, 62);
            this.btnTirageEnCroix.TabIndex = 2;
            this.btnTirageEnCroix.Text = "Tirage en Croix";
            this.btnTirageEnCroix.UseVisualStyleBackColor = true;
            this.btnTirageEnCroix.Click += new System.EventHandler(this.btnTirageEnCroix_Click);
            // 
            // btnTirageEnLigne
            // 
            this.btnTirageEnLigne.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTirageEnLigne.Location = new System.Drawing.Point(15, 435);
            this.btnTirageEnLigne.Name = "btnTirageEnLigne";
            this.btnTirageEnLigne.Size = new System.Drawing.Size(126, 67);
            this.btnTirageEnLigne.TabIndex = 3;
            this.btnTirageEnLigne.Text = "Tirage en Ligne";
            this.btnTirageEnLigne.UseVisualStyleBackColor = true;
            this.btnTirageEnLigne.Click += new System.EventHandler(this.btnTirageEnLigne_Click);
            // 
            // numTirageEnLigne
            // 
            this.numTirageEnLigne.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTirageEnLigne.Location = new System.Drawing.Point(147, 445);
            this.numTirageEnLigne.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.numTirageEnLigne.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numTirageEnLigne.Name = "numTirageEnLigne";
            this.numTirageEnLigne.Size = new System.Drawing.Size(78, 44);
            this.numTirageEnLigne.TabIndex = 4;
            this.numTirageEnLigne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numTirageEnLigne.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // FrmTarot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(734, 679);
            this.Controls.Add(this.numTirageEnLigne);
            this.Controls.Add(this.btnTirageEnLigne);
            this.Controls.Add(this.btnTirageEnCroix);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxTirage);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.gbxDecks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmTarot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tirage de Tarot Divinatoire";
            this.Load += new System.EventHandler(this.FrmTarot_Load);
            this.gbxDecks.ResumeLayout(false);
            this.gbxDecks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTirageEnLigne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxDecks;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.RadioButton rbtnRiderWaite;
        private System.Windows.Forms.RadioButton rbtnTarotDeMarseille;
        private System.Windows.Forms.RadioButton rbtnTarotEgytian;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.TextBox tbxTirage;
        private System.Windows.Forms.RadioButton rbtnNormalCardGame;
        private System.Windows.Forms.RadioButton rbtn36CardsGame;
        private System.Windows.Forms.RadioButton rbtnBriscola;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTirageEnCroix;
        private System.Windows.Forms.Button btnTirageEnLigne;
        private System.Windows.Forms.NumericUpDown numTirageEnLigne;
        private System.Windows.Forms.RadioButton rbtnPacteEtoiles;
        private System.Windows.Forms.RadioButton rbtnTarotMer;
    }
}


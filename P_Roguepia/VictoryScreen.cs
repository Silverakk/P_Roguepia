using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P_Roguepia.Properties;

namespace P_RogueTower
{
    public partial class VictoryScreen : Form
    {
        public VictoryScreen()
        {


            InitializeComponent();
            Random rdn = new Random();
            List<System.Drawing.Bitmap> victoryimagelist = new List<System.Drawing.Bitmap>() { Resources.winningscreen1,Resources.winningscreen2, Resources.winningscreen3};
            this.BackgroundImage = victoryimagelist[rdn.Next(1, victoryimagelist.Count())];
            this.BackColor = Color.White;
            label1.BackColor = Color.FromArgb(135, Color.Black);

        }
        
        private void VictoryScreen_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            label1.BackColor = Color.FromArgb(135, Color.Black);
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
    }
}

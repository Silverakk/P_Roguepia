using P_Roguepia.Properties;
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
    public partial class Death : Form
    {
        public Death()
        {
            InitializeComponent();
            Random rdn = new Random();

            List<System.Drawing.Bitmap> deathimagelist = new List<System.Drawing.Bitmap>() { Resources.deathscreen1, Resources.deathscreen2, Resources.deathscreen3, Resources.deathscreen4};
            this.BackgroundImage = deathimagelist[rdn.Next(1, deathimagelist.Count())];
            label1.BackColor = Color.FromArgb(135, Color.Black);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

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
        private void Death_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projem
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }



        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {





        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Helper.OpenNewFormLogin();
            this.Hide();
            
        }

        private void ayarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kullanıcılarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helper.OpenNewFormUserSettings();
            this.Hide();
            
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

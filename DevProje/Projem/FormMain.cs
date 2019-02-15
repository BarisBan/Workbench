using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
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

        private void kullanıcılarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUserSettings formUserSettings = new FormUserSettings();
            formUserSettings.Show();
            
            
        }
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();
            
            
        }

        private void ayarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.Show();
        }

        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUrun formUrun = new FormUrun();
            formUrun.Show();
        }

        private void şubelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSube sube = new FormSube();
            sube.Show();

        }
    }
}

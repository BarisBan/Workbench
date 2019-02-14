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
    public partial class FormDeleteUser : Form
    {
        public FormDeleteUser()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Helper.OpenNewFormMain();
            this.Hide();

        }

        private void btSil_Click(object sender, EventArgs e)
        {
            DialogResult box = MessageBox.Show("Kişiyi silmek istediğinizden emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (box == DialogResult.Yes)
            {

            }
            else
            {
                MessageBox.Show("İşlem iptal edildi");
            }
        }
    }
}

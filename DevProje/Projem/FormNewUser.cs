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
    public partial class FormNewUser : Form
    {
        public FormNewUser()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormNewUser_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnKayıtOl_Click(object sender, EventArgs e)
        {

            this.Hide();

        }

        private void btOnay_Click(object sender, EventArgs e)
        {
            DialogResult box= MessageBox.Show("Kişiyi eklemek istediğinizden emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(box==DialogResult.Yes)
            {

            }
            else
            {
                MessageBox.Show("İşlem iptal edildi");
            }

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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class FormUserUpdate : Form
    {
        public FormUserUpdate()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btBaglan_Click(object sender, EventArgs e)
        {
            DialogResult box = MessageBox.Show("Kişiyi güncellemek istediğinizden emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (box == DialogResult.Yes)
            {

            }
            else
            {
                MessageBox.Show("İşlem iptal edildi");
            }
        }

        private void btnKayıtOl_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

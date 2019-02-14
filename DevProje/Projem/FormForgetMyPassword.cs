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
    public partial class FormForgetMyPassword : Form
    {
        public FormForgetMyPassword()
        {
            InitializeComponent();
        }

        private void btBaglan_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{txbforgetmypass.Text} Adresine kurtarma şifresi gönderildi. Lütfen Mailinizi kontrol edin.", "Gönder", MessageBoxButtons.OK, MessageBoxIcon.Information);

            MessageBox.Show("Email Adersi Doğrulanamadı.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}

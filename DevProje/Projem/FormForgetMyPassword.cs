using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Projem
{
    public partial class FormForgetMyPassword : Form
    {
       FormMain formMain = new FormMain();
        public FormForgetMyPassword()
        {
            InitializeComponent();
        }

        private void btBaglan_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(ConnectionHelper.GetConnectionString());
            connect.Open();
            string Email = txbforgetmypass.Text.Trim();

            SqlCommand command = new SqlCommand("Select Email from Employees where Email = '"+Email+"'", connect);
            

            object varmi= command.ExecuteScalar();

            if(varmi!=null)
            {
            MessageBox.Show($"{txbforgetmypass.Text} Adresine kurtarma şifresi gönderildi. Lütfen Mailinizi kontrol edin.", "Gönder", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
            MessageBox.Show("Email Adersi Doğrulanamadı.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            connect.Close();


           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           
            this.Hide();
        }
    }
}

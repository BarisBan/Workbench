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
using System.Configuration;

namespace Projem
{
    public partial class FormLogin : Form
    {
        string connString = ConnectionHelper.GetConnectionString();
        SqlConnection connect;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btBaglan_Click(object sender, EventArgs e)
        {

            FormMain formMain = new FormMain();
            connect = new SqlConnection(connString);
            connect.Open();

            string userName = txbUserName.Text.Trim();
            string userPass = txbPass.Text.Trim();

            try
            {

                SqlDataAdapter da = new SqlDataAdapter(ConnectionHelper.GetLoginString(userName, userPass), connect);

                DataTable dt = new DataTable();
                da.Fill(dt);
           
                


                if (dt.Rows.Count>0)
                {
                    if (dt.Rows[0][6].ToString() == "1")
                    {
                        MessageBox.Show($"Hoşgeldin Yönetici {dt.Rows[0][1].ToString()} {dt.Rows[0][3].ToString()}", "Giriş Başarılı", MessageBoxButtons.OK);
                        this.Hide();
                        formMain.ayarlarToolStripMenuItem.Enabled = true;
                        formMain.satısToolStripMenuItem.Enabled = true;
                        formMain.stockToolStripMenuItem.Enabled = true;
                        formMain.raporlarToolStripMenuItem.Enabled = true;         
                        formMain.Show();
                    }
                    else
                    {
                        MessageBox.Show($"Hoşgeldin {dt.Rows[0][1].ToString()} {dt.Rows[0][3].ToString()}", "Giriş Başarılı", MessageBoxButtons.OK);
                        this.Hide();                     

                        formMain.satısToolStripMenuItem.Enabled = true;
                        formMain.stockToolStripMenuItem.Enabled = true;
                        formMain.raporlarToolStripMenuItem.Enabled = true;
                        formMain.Show();
                    }
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Kullanıcı veya Şifre Hatalı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            connect.Close();
        }

        private void btnKayıtOl_Click(object sender, EventArgs e)
        {
            FormCreateUser formCreateUser = new FormCreateUser();
            formCreateUser.Show();
            this.Hide();

        }

        private void txbPass_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btUnut_Click(object sender, EventArgs e)
        {
            FormForgetMyPassword formForgetMyPassword = new FormForgetMyPassword();
            formForgetMyPassword.Show();
            this.Hide();
        }
    }
}

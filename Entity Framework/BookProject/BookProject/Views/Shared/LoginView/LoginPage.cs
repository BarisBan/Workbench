using BookProject.DAL.ORM.Context;
using BookProject.Views.Admin.MasterView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookProject.Views.Shared.LoginView
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        ProjectContext db = new ProjectContext();
        MasterPage mp = new MasterPage();

        public bool EmptyCatcher() // Bu metodun amacı butona tıklandığında eğer boş bir textbox varsa hata mesajı çıkarsın.
        {
            bool i = false;

            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    if (string.IsNullOrWhiteSpace(item.Text))
                    {
                        i = false;
                        return i;
                    }
                    else
                    {
                        i = true;
                    }
                }
            }
            return i;
        }
        private void BtnSignIn_Click(object sender, EventArgs e)
        { // sayfa yönlendirmeleri yapılacak.

            if (EmptyCatcher())
            {
                if (db.AppUsers.Any(x => x.UserName == txtUserName.Text && x.Password == txtPassword.Text && x.Status == DAL.ORM.Enum.Status.Active && x.Role == DAL.ORM.Enum.Role.Admin))
                {
                    mp.panelToolStripMenuItem.Visible = true;
                    mp.panelToolStripMenuItem.Enabled = true;
                    mp.Show();
                    this.Hide();

                }
                else if (db.AppUsers.Any(x => x.UserName == txtUserName.Text && x.Password == txtPassword.Text && x.Status == DAL.ORM.Enum.Status.Active && x.Role == DAL.ORM.Enum.Role.Member))
                {
                    mp.panelToolStripMenuItem.Visible = false;
                    mp.Show();
                    this.Hide();


                }
                else if (db.AppUsers.Any(x => x.UserName == txtUserName.Text && x.Password == txtPassword.Text && x.Status == DAL.ORM.Enum.Status.Active && x.Role == DAL.ORM.Enum.Role.Employee))
                {
                    mp.panelToolStripMenuItem.Enabled = true;
                    mp.userPanelToolStripMenuItem.Visible = false;
                    mp.categoryPanelToolStripMenuItem.Enabled = true;
                    mp.bookPanelToolStripMenuItem.Enabled = true;
                    mp.Show();
                }
                else if (db.AppUsers.Any(x => x.UserName == txtUserName.Text && x.Password == txtPassword.Text && x.Status == DAL.ORM.Enum.Status.Active && x.Role == DAL.ORM.Enum.Role.Author))
                {
                    mp.panelToolStripMenuItem.Enabled = true;
                    mp.userPanelToolStripMenuItem.Visible = false;
                    mp.categoryPanelToolStripMenuItem.Enabled = false;
                    mp.bookPanelToolStripMenuItem.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Lütfen ilgili alanları boş bırakmayınız...!!!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private void LoginPage_Load(object sender, EventArgs e)
        {
            txtUserName.Text = "DKadir";
            txtPassword.Text = "1234";
        }
    }
}

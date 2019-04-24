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
        {




            if (EmptyCatcher())
            {
                if (db.AppUsers.Any(x => x.UserName == txtUserName.Text && x.Password == txtPassword.Text && x.Role == DAL.ORM.Enum.Role.Admin && (x.Status == DAL.ORM.Enum.Status.Active || x.Status == DAL.ORM.Enum.Status.Updated)))
                {

                    foreach (MasterPage mp in Application.OpenForms.OfType<MasterPage>())
                    {
                        foreach (MenuStrip tst in mp.Controls.OfType<MenuStrip>())
                        {
                            if(tst.Name == "menuStrip1")
                            {
                                tst.Items[1].Visible = true;
                                tst.Items[1].Enabled = true;
                                tst.Items[2].Enabled = true;
                            }
                        }
                    }
                    this.Close();                   

                }
                else if (db.AppUsers.Any(x => x.UserName == txtUserName.Text && x.Password == txtPassword.Text && x.Role == DAL.ORM.Enum.Role.Member && (x.Status == DAL.ORM.Enum.Status.Active)))
                {
                    foreach (MasterPage mp in Application.OpenForms.OfType<MasterPage>())
                    {
                        foreach (MenuStrip tst in mp.Controls.OfType<MenuStrip>())
                        {
                            if (tst.Name == "menuStrip1")
                            {
                                tst.Items[1].Visible = false;
                                tst.Items[1].Enabled = false;
                                tst.Items[2].Enabled = true;
                            }
                        }
                    }                    
                    this.Close();

                }
                else if (db.AppUsers.Any(x => x.UserName == txtUserName.Text && x.Password == txtPassword.Text && x.Role == DAL.ORM.Enum.Role.Employee && (x.Status == DAL.ORM.Enum.Status.Active || x.Status == DAL.ORM.Enum.Status.Updated)))
                {

                    foreach (MasterPage mp in Application.OpenForms.OfType<MasterPage>())
                    {
                        foreach (MenuStrip tst in mp.Controls.OfType<MenuStrip>())
                        {
                            if (tst.Name == "menuStrip1")
                            {
                                 tst.Items[1].Visible = true;
                                 tst.Items[1].Enabled = true;
                               
                            }
                        }
                    }

                    //mp.panelToolStripMenuItem.Enabled = true;
                    //mp.userPanelToolStripMenuItem.Visible = false;
                    //mp.categoryPanelToolStripMenuItem.Enabled = true;
                    //mp.bookPanelToolStripMenuItem.Enabled = true;
                    //mp.Show();
                    this.Close();
                }
                else if (db.AppUsers.Any(x => x.UserName == txtUserName.Text && x.Password == txtPassword.Text && x.Role == DAL.ORM.Enum.Role.Author || (x.Status == DAL.ORM.Enum.Status.Active || x.Status == DAL.ORM.Enum.Status.Updated)))
                {
                    foreach (MasterPage mp in Application.OpenForms.OfType<MasterPage>())
                    {
                        foreach (MenuStrip tst in mp.Controls.OfType<MenuStrip>())
                        {
                            if (tst.Name == "menuStrip1")
                            {
                                tst.Items[1].Visible = true;
                                tst.Items[1].Enabled = true;
                            }
                        }
                    }
                    //mp.panelToolStripMenuItem.Enabled = true;
                    //mp.userPanelToolStripMenuItem.Visible = false;
                    //mp.categoryPanelToolStripMenuItem.Enabled = false;
                    //mp.bookPanelToolStripMenuItem.Enabled = true;
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

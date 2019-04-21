using BookProject.Views.Admin.AppUserView;
using BookProject.Views.Admin.BookView;
using BookProject.Views.Admin.CategoryView;
using BookProject.Views.Shared.LoginView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookProject.Views.Admin.MasterView
{
    public partial class MasterPage : Form
    {
        public MasterPage()
        {
            InitializeComponent();
        }

        private void LoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginPage login = new LoginPage();
            login.ShowDialog();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MasterPage_Load(object sender, EventArgs e)
        {

           
            
        }

        private void UserPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppUserPage userPage = new AppUserPage();
            userPage.ShowDialog();
        }

        private void CategoryPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryPage categoryPage = new CategoryPage();
            categoryPage.ShowDialog();
        }

        private void BookPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookPage bookPage = new BookPage();
            bookPage.ShowDialog();
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelToolStripMenuItem.Visible = false;
        }
    }
}

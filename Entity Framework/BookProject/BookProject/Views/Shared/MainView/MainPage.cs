using BookProject.Views.Admin.AppUserView;
using BookProject.Views.Admin.BookView;
using BookProject.Views.Admin.CategoryView;
using BookProject.Views.Admin.MasterView;
using BookProject.Views.Member.MemberView;
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

namespace BookProject.Views.Shared.MainView
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

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
            Application.Restart();

        }

        private void ShopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemberPage mbPage = new MemberPage();
            mbPage.ShowDialog();
        }

        private void adminPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MasterPage masterPage = new MasterPage();
            masterPage.ShowDialog();
        }
    }
}

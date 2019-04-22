using BookProject.DAL.ORM.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookProject.Views.Member.MemberView
{
    public partial class MemberPage : Form
    {
        public MemberPage()
        {
            InitializeComponent();
        }
        ProjectContext db = new ProjectContext();

        public void TexBoxEraser()
        {
            foreach (Control item in gbBookSearch.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

        }

        public void CategoryTakeList()
        {
            cbCategory.DataSource = db.Categories.Where(x => x.Status == DAL.ORM.Enum.Status.Active || x.Status == DAL.ORM.Enum.Status.Updated).Select(x => x.CategoryName).ToList();
            cbCategory.SelectedIndex = -1;
        }
        public void AutorsTakeList()
        {
            cbAutors.DataSource = db.AppUsers.Where(x => x.Role == DAL.ORM.Enum.Role.Author && ( x.Status == DAL.ORM.Enum.Status.Active || x.Status == DAL.ORM.Enum.Status.Updated)).Select(x=> x.FirstName).ToList();
            cbAutors.SelectedIndex = -1;
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sepettekileri onaylıyor musunuz?", "???", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }   
        
        private void MemberPage_Load(object sender, EventArgs e)
        {
            CategoryTakeList();
            AutorsTakeList();
        }
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvBookList.DataSource = db.Books.Where(x => x.Category.CategoryName == cbCategory.Text.Trim()).ToList();
            

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvBookList.DataSource = db.Books.Where(x=>x.BookName.Contains(txbBookName.Text)).ToList();
             TexBoxEraser();
        }

        private void cbAutors_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvBookList.DataSource = db.Books.Where(x => x.AppUser.FirstName == cbAutors.Text.Trim() || x.AppUser.LastName == cbAutors.Text.Trim()).ToList();
        }
    }
}

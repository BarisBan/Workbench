using BookProject.DAL.ORM.Context;
using BookProject.DAL.ORM.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookProject.Views.Admin.CategoryView
{
    public partial class CategoryPage : Form
    {
        public CategoryPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        ProjectContext db = new ProjectContext();

        public void TexBoxEraser()
        {
            foreach (Control item in grpCategoryAdd.Controls)
            {
                if(item is TextBox)
                {
                    item.Text = "";
                }
            }
            foreach (Control item in grpCategoryUpdate.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            foreach (Control item in grpCategoryDelete.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        public void CategoryList()
        {
            dataGridView1.DataSource = db.Categories.Where(x => x.Status == DAL.ORM.Enum.Status.Active || x.Status == DAL.ORM.Enum.Status.Updated).ToList();
        }

        private void btnCategoryAdd_Click(object sender, EventArgs e)
        {
            Category category = new Category();

            category.CategoryName = txtCategoryAdd.Text;
            category.Distription = txtCategoryDiscriptionAdd.Text;

            db.Categories.Add(category);
            db.SaveChanges();

            CategoryList();
            TexBoxEraser();
        }

        private void CategoryPage_Load(object sender, EventArgs e)
        {
            CategoryList();
        }

        int id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCategoryUpdate.Text = dataGridView1.CurrentRow.Cells["CategoryName"].Value.ToString();
            txtCategoryUpdate.Text = dataGridView1.CurrentRow.Cells["Discription"].Value.ToString();
            id = int.Parse(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
            txtCategoryDelete.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
        }

        private void btnCategoryUpdate_Click(object sender, EventArgs e)
        {
            Category category = db.Categories.FirstOrDefault(x => x.ID == id);
            category.CategoryName = txtCategoryUpdate.Text;
            category.Distription = txtCategoryDiscriptionUpdate.Text;
            category.UpdateDate = DateTime.Now;
            category.Status = DAL.ORM.Enum.Status.Updated;

            db.SaveChanges();

            CategoryList();
            TexBoxEraser();
        }

        private void btnCategoryDelete_Click(object sender, EventArgs e)
        {
            Category category = db.Categories.FirstOrDefault(x => x.ID == id);

            category.DeleteDate = DateTime.Now;
            category.Status = DAL.ORM.Enum.Status.Deleted;
            db.SaveChanges();
            CategoryList();
            TexBoxEraser();
        }
    }
}

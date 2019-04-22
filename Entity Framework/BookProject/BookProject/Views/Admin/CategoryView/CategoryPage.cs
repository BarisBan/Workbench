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
        ProjectContext db = new ProjectContext();

        public void TexBoxEraser()
        {
            foreach (Control item in grpCategoryAdd.Controls)
            {
                if (item is TextBox)
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


        public void CategoryTakeList()
        {
            dataGridView1.DataSource = db.Categories.Where(x => x.Status == DAL.ORM.Enum.Status.Active || x.Status == DAL.ORM.Enum.Status.Updated).ToList();
        }
        public bool EmptyCatcher(char _isCreateOrUpdate) //AppUserView deki Metotla aynı mantık.
        {
            bool i = false;

            switch (_isCreateOrUpdate)
            {
                case 'C':

                    foreach (Control item in grpCategoryAdd.Controls)
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
                    break;

                case 'U':

                    foreach (Control item in grpCategoryUpdate.Controls)
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
                    break;
            }
            return i;
        }

        private void btnCategoryAdd_Click(object sender, EventArgs e)
        {
            bool _isEmpty = EmptyCatcher('C');

            if (_isEmpty == true)
            {

                Category category = new Category();

                category.CategoryName = txtCategoryAdd.Text;
                category.Distription = txtCategoryDiscriptionAdd.Text;
                category.AddDate = DateTime.Now;
                category.Status = DAL.ORM.Enum.Status.Active;
                db.Categories.Add(category);
                db.SaveChanges();
                TexBoxEraser();

            }
            else
            {
                MessageBox.Show("Lütfen Boş kalan yerleri Doldurunuz.");
            }
            CategoryTakeList();
        }

        private void CategoryPage_Load(object sender, EventArgs e)
        {
            CategoryTakeList();
        }

        int id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCategoryUpdate.Text = dataGridView1.CurrentRow.Cells["CategoryName"].Value.ToString();
            txtCategoryDiscriptionUpdate.Text = dataGridView1.CurrentRow.Cells["Distription"].Value.ToString();
            id = int.Parse(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
            txtCategoryDelete.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
        }

        private void btnCategoryUpdate_Click(object sender, EventArgs e)
        {
            bool _isEmpty = EmptyCatcher('U');

            if (EmptyCatcher('U'))
            {

                Category category = db.Categories.FirstOrDefault(x => x.ID == id);
                category.CategoryName = txtCategoryUpdate.Text;
                category.Distription = txtCategoryDiscriptionUpdate.Text;
                category.UpdateDate = DateTime.Now;
                category.Status = DAL.ORM.Enum.Status.Updated;

                db.SaveChanges();
                TexBoxEraser();

            }
            else
            {
                MessageBox.Show("Lütfen Boş kalan yerleri Doldurunuz.");
            }
            CategoryTakeList();
        }

        private void btnCategoryDelete_Click(object sender, EventArgs e)
        {
            Category category = db.Categories.FirstOrDefault(x => x.ID == id);

            category.DeleteDate = DateTime.Now;
            category.Status = DAL.ORM.Enum.Status.Deleted;
            db.SaveChanges();
            CategoryTakeList();
            TexBoxEraser();
        }
    }
}

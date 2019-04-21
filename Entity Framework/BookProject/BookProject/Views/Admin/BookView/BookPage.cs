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

namespace BookProject.Views.Admin.BookView
{
    public partial class BookPage : Form
    {
        public BookPage()
        {
            InitializeComponent();
        }
        ProjectContext db = new ProjectContext();
        void CategoryList()
        {
            cmbBookCategoriesAdd.DataSource = db.Categories.Where(x => x.Status == DAL.ORM.Enum.Status.Active || x.Status == DAL.ORM.Enum.Status.Updated).ToList();
            cmbBookCategoriesAdd.Text = "CategoryName";
            cmbBookCategoriesAdd.DisplayMember = "CategoryName";
            cmbBookCategoriesAdd.ValueMember = "Id";
            cmbBookCategoriesAdd.SelectedIndex = -1;

            cmbBookCategoriesUpdate.DataSource = db.Categories.Where(x => x.Status == DAL.ORM.Enum.Status.Active || x.Status == DAL.ORM.Enum.Status.Updated).ToList();;
            cmbBookCategoriesUpdate.Text = "CategoryName";            
            cmbBookCategoriesUpdate.DisplayMember = "CategoryName"; ;
            cmbBookCategoriesUpdate.ValueMember = "Id";;
            cmbBookCategoriesUpdate.SelectedIndex = -1; ;
        }

        void AppUserList()
        {
            cmbBookAddAuthor.DataSource = db.AppUsers.Where(x => x.Status == DAL.ORM.Enum.Status.Active || x.Status == DAL.ORM.Enum.Status.Updated).ToList();
            cmbBookAddAuthor.Text = "FullName";
            cmbBookAddAuthor.DisplayMember = "FullName";
            cmbBookAddAuthor.ValueMember = "Id";
            cmbBookAddAuthor.SelectedIndex = -1;

            cmbBookAuthorUpdate.DataSource = db.AppUsers.Where(x => x.Status == DAL.ORM.Enum.Status.Active || x.Status == DAL.ORM.Enum.Status.Updated).ToList();
            cmbBookAuthorUpdate.Text = "FullName";
            cmbBookAuthorUpdate.DisplayMember = "FullName";
            cmbBookAuthorUpdate.ValueMember = "Id";
            cmbBookAuthorUpdate.SelectedIndex = -1;

        }
        public void TextBoxEraser()
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
            foreach (Control item in groupBox3.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
            foreach (Control item in groupBox4.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        public void BookTakeList()
        {
            dataGridView1.DataSource = db.Books.Where(x => x.Status == DAL.ORM.Enum.Status.Active || x.Status == DAL.ORM.Enum.Status.Updated).ToList();
        }

        public bool EmptyCatcher(char _isCreateOrUpdate) // Bu metodun amacı butona tıklandığında eğer boş bir textbox varsa hata mesajı çıkarsın.
        {
            bool i = false;

            switch (_isCreateOrUpdate)
            {
                case 'C': //AddGroupbox'taki texboxlar için;
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
                    break;
                case 'U'://UpdateGroupbox'taki textboxlar için

                    foreach (Control item in groupBox3.Controls)
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
        private void BookPage_Load(object sender, EventArgs e)
        {
            CategoryList();
            BookTakeList();
            AppUserList();
        }

        private void BtnBookAdd_Click(object sender, EventArgs e)
        {
            if (EmptyCatcher('C'))
            {

                Book book = new Book();
                book.BookName = txtBookNameAdd.Text;
                book.BookDescription = txtBookDescriptionAdd.Text;
                book.CategoryID = (int)cmbBookCategoriesAdd.SelectedValue;
                book.Category.CategoryName = cmbBookCategoriesAdd.SelectedText;
                book.AppUserID = (int)cmbBookAddAuthor.SelectedValue;
                book.AppUser.FullName = cmbBookAddAuthor.SelectedText;
                
                book.Status = DAL.ORM.Enum.Status.Active;
                book.AddDate = DateTime.Now;

                db.Books.Add(book);
                db.SaveChanges();
                TextBoxEraser();

            }
            else
            {
                MessageBox.Show("Lütfen İlgili yerdeki alanları boş bırakmayınız.");
            }
            BookTakeList();
        }
        int id;
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBookNameUpdate.Text = dataGridView1.CurrentRow.Cells["BookName"].Value.ToString();
            txtBookDescriptionUpdate.Text = dataGridView1.CurrentRow.Cells["BookDescription"].Value.ToString();
            txBookDelete.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
            id = int.Parse(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void BtnBookUpdate_Click(object sender, EventArgs e)
        {
            if (EmptyCatcher('U'))
            {

                Book book = db.Books.FirstOrDefault(x => x.ID == id);
                book.BookName = txtBookNameUpdate.Text;
                book.BookDescription = txtBookDescriptionUpdate.Text;
                book.CategoryID = (int)cmbBookCategoriesUpdate.SelectedValue;
                book.Category.CategoryName = cmbBookCategoriesUpdate.SelectedText;
                book.AppUserID = (int)cmbBookAuthorUpdate.SelectedValue;
                book.AppUser.FullName = cmbBookCategoriesUpdate.SelectedText;
                book.Status = DAL.ORM.Enum.Status.Updated;
                book.UpdateDate = DateTime.Now;
                
                db.SaveChanges();
                TextBoxEraser();
            }
            else
            {
                MessageBox.Show("Lütfen İlgili yerdeki alanları boş bırakmayınız.");
            }
            BookTakeList();
        }

        private void BtnBookDelete_Click(object sender, EventArgs e)
        {
            Book book = db.Books.FirstOrDefault(x => x.ID == id);
            book.Status = DAL.ORM.Enum.Status.Deleted;
            book.DeleteDate = DateTime.Now;
            db.SaveChanges();
            BookTakeList();
            TextBoxEraser();
            
        }
    }
}

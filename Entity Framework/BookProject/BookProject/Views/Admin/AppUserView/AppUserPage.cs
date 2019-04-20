using BookProject.DAL.ORM.Context;
using BookProject.DAL.ORM.Enum;
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

namespace BookProject.Views.Admin.AppUserView
{
    public partial class AppUserPage : Form
    {
        public AppUserPage()
        {
            InitializeComponent();
        }
        ProjectContext db = new ProjectContext();

        public void TextBoxEraser()
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
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
            }
            foreach (Control item in groupBox4.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        public void AppUserTakeList()
        {
            dataGridView1.DataSource = db.AppUsers.Where(x => x.Status == DAL.ORM.Enum.Status.Active || x.Status == DAL.ORM.Enum.Status.Updated).ToList();
        }

        public void EnumList()
        {
            cmbUserAddGender.Items.AddRange(Enum.GetNames(typeof(Gender)));
            cmbUserAddGender.SelectedIndex = 0;
            cmbUserAddRole.Items.AddRange(Enum.GetNames(typeof(Role)));
            cmbUserAddRole.SelectedIndex = 0;

            cmbGenderUpdate.Items.AddRange(Enum.GetNames(typeof(Gender)));
            cmbGenderUpdate.SelectedIndex = 0;
            cmbUpdateRole.Items.AddRange(Enum.GetNames(typeof(Role)));
            cmbUpdateRole.SelectedIndex = 0;

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


        private void AppUserView_Load(object sender, EventArgs e)
        {
            AppUserTakeList();
            EnumList();
        }

        bool _isEmpty;
        private void BtnUserAdd_Click(object sender, EventArgs e)
        {
            _isEmpty = EmptyCatcher('C'); // C yi ben atıyorum ki AddGroupboxtaki texboxları alsın.

            if (_isEmpty == true)
            {
                AppUser user = new AppUser();

                user.FirstName = txtFirstNameAdd.Text;
                user.LastName = txtLastNameAdd.Text;
                user.Email = txtEmailAdd.Text;
                user.Password = txtPasswordAdd.Text;
                user.UserName = txtUserNameAdd.Text;
                user.Gender = (Gender)Enum.Parse(typeof(Gender), cmbUserAddGender.Text);
                user.Role = (Role)Enum.Parse(typeof(Role), cmbUserAddRole.Text);
                user.AddDate = DateTime.Now;
                user.Status = DAL.ORM.Enum.Status.Active;

                db.AppUsers.Add(user);
                db.SaveChanges();
                TextBoxEraser();
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alanları doldurunuz.");
            }

            AppUserTakeList();

        }
        int id;
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtFirstNameUpdate.Text = dataGridView1.CurrentRow.Cells["FirstName"].Value.ToString();
            txtLastNameUpdate.Text = dataGridView1.CurrentRow.Cells["LastName"].Value.ToString();
            txtUserNameUpdate.Text = dataGridView1.CurrentRow.Cells["UserName"].Value.ToString();
            txtPasswordUpdate.Text = dataGridView1.CurrentRow.Cells["Password"].Value.ToString();
            txtEmailUpdate.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
            cmbGenderUpdate.Text = dataGridView1.CurrentRow.Cells["Gender"].Value.ToString();
            cmbUpdateRole.Text = dataGridView1.CurrentRow.Cells["Role"].Value.ToString();
            txtUserDelete.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
            id = int.Parse(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
        }


        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            _isEmpty = EmptyCatcher('U'); // U'yu ben atıyorum ki Updategroupbox taki textboxlari kapsasın.
            if (_isEmpty == true)
            {
                AppUser appuser = db.AppUsers.FirstOrDefault(x => x.ID == id);
                appuser.FirstName = txtFirstNameUpdate.Text;
                appuser.LastName = txtLastNameUpdate.Text;
                appuser.UserName = txtUserNameUpdate.Text;
                appuser.Email = txtEmailUpdate.Text;
                appuser.Password = txtPasswordUpdate.Text;
                appuser.Role = (Role)Enum.Parse(typeof(Role), cmbUpdateRole.Text);
                appuser.Gender = (Gender)Enum.Parse(typeof(Gender), cmbGenderUpdate.Text);
                appuser.UpdateDate = DateTime.Now;
                appuser.Status = DAL.ORM.Enum.Status.Updated;
                db.SaveChanges();
                TextBoxEraser();
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alanları doldurunuz.");
            }

            AppUserTakeList();
        }

        private void BtnUserDelete_Click(object sender, EventArgs e)
        {
            AppUser appuser = db.AppUsers.FirstOrDefault(x => x.ID == id);
            appuser.Status = DAL.ORM.Enum.Status.Deleted;
            appuser.DeleteDate = DateTime.Now;
            db.SaveChanges();
            AppUserTakeList();
            txtUserDelete.Clear();
            TextBoxEraser();
        }
    }
}

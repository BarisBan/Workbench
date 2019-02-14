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

namespace Projem
{
    public partial class FormNewUser : Form
    {
        public FormNewUser()
        {
            InitializeComponent();
        }

        private void FormNewUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'm303SalesDBDataSet4.NewUser' table. You can move, or remove it, as needed.
            this.newUserTableAdapter1.Fill(this.m303SalesDBDataSet4.NewUser);
            // TODO: This line of code loads data into the 'm303SalesDBDataSet3.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter1.Fill(this.m303SalesDBDataSet3.Employees);
            // TODO: This line of code loads data into the 'm303SalesDBDataSet2.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.m303SalesDBDataSet2.Employees);
            // TODO: This line of code loads data into the 'm303SalesDBDataSet1.NewUser' table. You can move, or remove it, as needed.
            this.newUserTableAdapter.Fill(this.m303SalesDBDataSet1.NewUser);
            // TODO: This line of code loads data into the 'm303SalesDBDataSet.Cities' table. You can move, or remove it, as needed.
            this.citiesTableAdapter.Fill(this.m303SalesDBDataSet.Cities);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnKayıtOl_Click(object sender, EventArgs e)
        {

            this.Hide();

        }

        private void btOnay_Click(object sender, EventArgs e)
        {
            Helper helper = new Helper(); 
            
            DialogResult box= MessageBox.Show("Kişiyi eklemek istediğinizden emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(box==DialogResult.Yes)
            {
                string ad = txbNewFirstName.Text;
                string orta = "0";
                string soyad = txbNewLastName.Text;
                string username = txbNewUserName.Text;
                string userpass = txbNewPass.Text;
                string yetki = cbKulTip.SelectedText;
                string email = txbEmail.Text;
                string tel = txbPhone.Text;
                string sube = cbSube.SelectedValue.ToString();
                string cinsiyet = "";
                bool isChecked = rbKadın.Checked;
                if (isChecked)
                    cinsiyet = rbKadın.Text;
                else

                    cinsiyet = rbErkek.Text;
                if (yetki == "Yetkili")
                    yetki = "1";
                else
                    yetki = "0";

                string aktiflik = "1";

                string phone = helper.PhoneCorrector(tel);

                SqlConnection connect = new SqlConnection(ConnectionHelper.GetConnectionString());
                connect.Open();

                SqlCommand command = new SqlCommand("Insert Into Employees values('" + ad.Trim() + "','" + orta.Trim() + "','" + soyad.Trim() + "','" + username.Trim() + "','" + userpass.Trim() + "','" + yetki.Trim() + "','" + email.Trim() + "','" + phone.Trim() + "','"+sube+ "','" + cinsiyet.Trim() + "','"+ aktiflik.Trim() + "')",connect);

                int secilen = dataGridView1.SelectedCells[0].RowIndex;
                string ID=dataGridView1.Rows[secilen].Cells[0].Value.ToString();
                SqlCommand com2 = new SqlCommand("Delete From NewUser Where NewUserID="+ID.Trim(),connect);
                command.ExecuteNonQuery();
                connect.Close();

               DialogResult box1 = MessageBox.Show("Kişi Başarıyla Kayıt Edilmiştir."," Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
                if(box1== DialogResult.OK)
                {
                    dataGridView1.Refresh();
                }


            }
            else
            {
                MessageBox.Show("İşlem iptal edildi");
            }

        }

        private void btSil_Click(object sender, EventArgs e)
        {
            DialogResult box = MessageBox.Show("Kişiyi silmek istediğinizden emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (box == DialogResult.Yes)
            {
                int secilen = dataGridView1.SelectedCells[0].RowIndex;
                 string ID= dataGridView1.Rows[secilen].Cells[0].Value.ToString();
                
                SqlConnection connect = new SqlConnection(ConnectionHelper.GetConnectionString());
                connect.Open();

                SqlCommand command = new SqlCommand("DELETE FROM NewUser WHERE NewUserID="+ ID.Trim(),connect);
                command.ExecuteNonQuery();
                connect.Close();

                DialogResult box1 = MessageBox.Show("Kişi Başarıyla Silindi.", " Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (box1 == DialogResult.OK)
                {
                    dataGridView1.Refresh();
                }


            }
            else
            {
                MessageBox.Show("İşlem iptal edildi");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Helper.OpenNewFormMain();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            string ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            string soyad = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            string username = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            string sifre = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            string yetki= dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            string email = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            string tel = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            string cinsiyet = dataGridView1.Rows[secilen].Cells[9].Value.ToString();

            txbNewFirstName.Text = ad;
            txbNewLastName.Text = soyad;
            txbNewUserName.Text = username;
            txbNewPass.Text = sifre;
            txbEmail.Text = email;
            txbPhone.Text = tel;
            if(cinsiyet=="Erkek")
            {
                rbErkek.Select();
            }
            else
            {
                rbKadın.Select();
            }


            
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            string ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            string soyad = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            string username = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            string sifre = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            string yetki = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            string email = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            string tel = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            string cinsiyet = dataGridView1.Rows[secilen].Cells[9].Value.ToString();

            txbNewFirstName.Text = ad;
            txbNewLastName.Text = soyad;
            txbNewUserName.Text = username;
            txbNewPass.Text = sifre;
            txbEmail.Text = email;
            txbPhone.Text = tel;
            if (cinsiyet == "Erkek")
            {
                rbErkek.Select();
            }
            else
            {
                rbKadın.Select();
            }
        }
    }
}

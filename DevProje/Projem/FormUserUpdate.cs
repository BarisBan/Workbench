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
    public partial class FormUserUpdate : Form
    {

        Helper helper = new Helper();
        public FormUserUpdate()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btBaglan_Click(object sender, EventArgs e)
        {
            DialogResult box = MessageBox.Show("Kişiyi güncellemek istediğinizden emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (box == DialogResult.Yes)
            {


                string ad = txbFirstName.Text;
                string orta = "0";
                string soyad = txbLastName.Text;
                string username = txbUserName.Text;
                string userpass = txbPass.Text;
                string email = txbEmail.Text;
                string yetki = cbKulTip.SelectedText;
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
                int secilen = dgPersonel.SelectedCells[0].RowIndex;
                string ID = dgPersonel.Rows[secilen].Cells[0].Value.ToString();


                string phone = helper.PhoneCorrector(tel);

                SqlConnection connect = new SqlConnection(ConnectionHelper.GetConnectionString());
                connect.Open();

                SqlCommand command = new SqlCommand($"Update Employees Set FirstName='{ad.Trim()}', MiddleInitial='{orta.Trim()}',LastName='{soyad.Trim()}',UserName='{username.Trim()}',UserPass='{userpass.Trim()}',Yetki='{yetki.Trim()}',Email='{email.Trim()}',PhoneNumber='{phone.Trim()}',CityID='{sube}',Cinsiyet='{cinsiyet.Trim()}',Aktiflik='{aktiflik.Trim()}' Where EmployeeID={ID.Trim()}", connect);

                command.ExecuteNonQuery();

                connect.Close();

                DialogResult box1 = MessageBox.Show("Kişi Başarıyla Güncellendi.", " Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (box1 == DialogResult.OK)
                {
                    SqlConnection con = new SqlConnection(ConnectionHelper.GetConnectionString());
                    con.Open();

                    SqlDataAdapter da = new SqlDataAdapter("Select * from Employees", con);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgPersonel.DataSource = dt;
                    con.Close();


                }


            }
            else
            {
                MessageBox.Show("İşlem iptal edildi");
            }
        }

        private void btnKayıtOl_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void FormUserUpdate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'm303SalesDBDataSet7.Cities' table. You can move, or remove it, as needed.
            this.citiesTableAdapter.Fill(this.m303SalesDBDataSet7.Cities);
            // TODO: This line of code loads data into the 'm303SalesDBDataSet5.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.m303SalesDBDataSet5.Employees);

        }

        private void dgPersonel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            int secilen = dgPersonel.SelectedCells[0].RowIndex;

            string ad = dgPersonel.Rows[secilen].Cells[1].Value.ToString();
            string soyad = dgPersonel.Rows[secilen].Cells[3].Value.ToString();
            string username = dgPersonel.Rows[secilen].Cells[4].Value.ToString();
            string sifre = dgPersonel.Rows[secilen].Cells[5].Value.ToString();
            string yetki = dgPersonel.Rows[secilen].Cells[6].Value.ToString();
            string email = dgPersonel.Rows[secilen].Cells[7].Value.ToString();
            string tel = dgPersonel.Rows[secilen].Cells[8].Value.ToString();
            string cinsiyet = dgPersonel.Rows[secilen].Cells[10].Value.ToString();


            txbFirstName.Text = ad;
            txbLastName.Text = soyad;
            txbUserName.Text = username;
            txbPass.Text = sifre;
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

            tabControl1.SelectedTab = tabPage2;
        }

        private void txbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbPhone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}

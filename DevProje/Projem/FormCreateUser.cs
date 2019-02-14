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
    public partial class FormCreateUser : Form
    {
        string connString = ConnectionHelper.GetConnectionString();
        SqlConnection connect;
        public FormCreateUser()
        {
            InitializeComponent();
        }

        private void btnKayıtOl_Click(object sender, EventArgs e)
        {
            connect = new SqlConnection(connString);
            connect.Open();

            // Öncelikle Kullanıcı Adı uygunmu değilmi şifre uygunmu değil mi bak
            //sonra veritabanında böyle bir kullanıcı adı varmı bak varsa hata ver yoksa Bu kullanıcı alınabilir.

            //isim soyad  Eposta telefon doğumtarihi iste  bunlarda uygunsa veri tabanındaki yeni kullanıcıya at ordan da yönetici çekip onayı verince employees içine atsın atılan da silinsin. 

            //SqlDataAdapter da = new SqlDataAdapter(ConnectionHelper.GetLoginString(userName, userPass), connect);

            //DataTable dt = new DataTable();
            //da.Fill(dt);


            connect.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FormCreateUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'm303SalesDBDataSet.Cities' table. You can move, or remove it, as needed.
            this.citiesTableAdapter.Fill(this.m303SalesDBDataSet.Cities);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.citiesTableAdapter.FillBy(this.m303SalesDBDataSet.Cities);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btBaglan_Click(object sender, EventArgs e)
        {
            #region  Kontroller
            // Şifre boşluk olmasın...
            bool check = false; // bu değer True olursa Kayıt butonu çalışıcak. yoksa mesaj vericek

            Helper helper = new Helper();
            string ad = txbNewFirstName.Text;
            string soyad = txbNewLastName.Text;
            string tel = txbPhone.Text;
            string email = txbEmail.Text;
            string user = txbNewUserName.Text;
            string pass = txbNewPass.Text;
            string passcheck = txbCheck.Text;
            DateTime birthday = Convert.ToDateTime(dtNewBirth.Text);
            string cinsiyet = "";                
            bool isChecked = rbKadın.Checked;
            if (isChecked)
                cinsiyet = rbKadın.Text;
            else
                cinsiyet = rbErkek.Text;

            //email Konntrolü

            //isim soyisim kontrolü
            check = helper.TextController(ad, soyad);
            if (check == false)
            {

                return;
            }
            // user pass kontrolü
            check = helper.TextController(user, pass);
            if (check == false)
            {
                return;
            }
            // userin veritabanındaki kontrolü
            check = helper.UserController(user);
            if (check == false)
            {

                return;
            }

            //tel kontrolü
            check = helper.PhoneController(tel);
            if (check == false)
            {
                MessageBox.Show("Girdiğiniz telefon numarası geçersiz ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // mail adres kontroü
            check = helper.MailIsAccept(email);
            if (check)
            {

                check = true;
            }
            else
            {
                MessageBox.Show("E-mail Adresi Geçersiz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                check = false;
                return;
            }

            //Cinsiyet kontrolü
            if (rbNone.Checked == true)
            {
                MessageBox.Show("Lütfen Cinsiyetinizi belirtin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                check = false;
                return;
            }
            else
            {
                check = true;
            }

            //doğum tarihi kontrolü
            check = helper.DateController(birthday);
            if (check == false)
            {
                return;
            }

            // şifre/şifretekrar kontrolü 
            if (pass != passcheck)
            {
                MessageBox.Show("Girdiğiniz (Şifre/Şifre Tekrar) Uyumsuz ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                check = false;
                return;
            }
            else
            {

                check = true;
            }
            // kontroller uygunsa Veritabanına atılacak            

            #endregion
            if (check == true)

            {

                MessageBox.Show("Kaydınız işleme alınmıştır. İşlem tamamlandığında bilgilendiriliceksiniz", "Kayıt Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    SqlConnection connect = new SqlConnection(ConnectionHelper.GetConnectionString());
                    connect.Open();

                try
                {
                    byte yetki = 0;

                    string tel2 = helper.PhoneCorrector(tel);                   

                    string orta = "";
                    SqlCommand command = new SqlCommand(ConnectionHelper.CreateNewUserString(ad, orta, soyad, user, pass, yetki.ToString(), email, tel2, cinsiyet), connect);

                    command.ExecuteNonQuery();


                }
                catch (Exception)
                {
                    MessageBox.Show("Niye böyle oldu yaa", "Bir hata Saptandı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                   
                }
                connect.Close();
            }
            
                
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

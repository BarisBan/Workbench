using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Collections;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Projem
{
    class Helper
    {


        // email kontrolü yapan metod
        public bool MailIsAccept(string email)
        {
            const string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
    @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
    @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

            return (new Regex(strRegex)).IsMatch(email);
        }

        // ad soyad kontrolü yapan metod
        public bool TextController(string ad, string soyad)
        {
            bool uygunluk = false;

            if (ad.Trim() == "" && soyad.Trim() == "")
            {
                MessageBox.Show("Lütfen Bütün Bilgileri Doldurunuz !", "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                uygunluk = false;

            }
            else
            {
                uygunluk = true;
            }
            return uygunluk;
        }

        // user veri tabanında olup olmadığını kontrol eden metod
        public bool UserController(string user)
        {
            bool uygunluk = false;
            SqlConnection connect = new SqlConnection(ConnectionHelper.GetConnectionString());
            connect.Open();

            SqlCommand comand = new SqlCommand("Select UserName From Employees Where UserName = @User ", connect);
            comand.Parameters.AddWithValue("@User", user);

            object varMi = comand.ExecuteScalar();

            SqlCommand comand2 = new SqlCommand("Select UserName From NewUser Where UserName = @User ", connect);
            comand2.Parameters.AddWithValue("@User", user);

            object varMi2 = comand2.ExecuteScalar();
            comand.Parameters.Clear();
            connect.Close();

            if (varMi != null)
            {
                MessageBox.Show("Bu kullanıcı ismi kullanılıyor. Lütfen başka bir kullanıcı ismi giriniz.");
                uygunluk = false;
            }
            else
            {
                uygunluk = true;
            }

            if (varMi2 != null)
            {
                MessageBox.Show("Bu kullanıcı ismi kullanılıyor. Lütfen başka bir kullanıcı ismi giriniz.");
                uygunluk = false;
            }
            else
            {
                uygunluk = true;
            }
            return uygunluk;
        }

        // telefon kontrolü
        public bool PhoneController(string tel)
        {

            string[] tel2 = tel.Split('(', ')');

            string tel3 = "";
            foreach (var item in tel2)
            {
                tel3 = tel3 + item;
                tel3.Trim();
            }

            string result = @"^(5(\d{2}) (\d{3})-(\d{4}))$";

            Match match = Regex.Match(tel3, result, RegexOptions.IgnoreCase);

            return match.Success;
        }
        // Doğumtarihi Kontrolü
        public bool DateController(DateTime dogumtarihi)
        {
            bool uygunluk = false;
            int yas;

            yas = DateTime.Now.Year - dogumtarihi.Year;

            if (yas >= 18)
            {
                uygunluk = true;
            }
            else
            {
                MessageBox.Show("Kayıt olmak için 18 Yaşından büyük olmanız gerekmektedir. ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                uygunluk = false;
            }
            return uygunluk;
        }

        public string PhoneCorrector(string phone)
        {
            char[] tel2 = phone.ToCharArray();
            string tel3 = "";
            foreach (var item in tel2)
            {
                if (item != '(' && item != ')' && item != '-' && item != ' ')
                {
                    tel3 = tel3 + item;
                }
                else
                {

                }
            }
            return tel3;
        }

        public static void OpenNewFormMain()
        {
            FormMain f = new FormMain();
            f.Show();
        }
        public static void OpenNewFormCreateUser()
        {
            FormCreateUser f = new FormCreateUser();
            f.Show();
        }
        public static void OpenNewFormDeleteUser()
        {
            FormDeleteUser f = new FormDeleteUser();
            f.Show();
        }
        public static void OpenNewFormForgetMyPassword()
        {
            FormForgetMyPassword f = new FormForgetMyPassword();
            f.Show();
        }
        public static void OpenNewFormLogin()
        {
            FormLogin f = new FormLogin();
            f.Show();
        }
        public static void OpenNewFormNewUser()
        {
            FormNewUser f = new FormNewUser();
            f.Show();
        }
        public static void OpenNewFormStock()
        {
            FormStock f = new FormStock();
            f.Show();
        }
        public static void OpenNewFormUserSettings()
        {
            FormUserSettings f = new FormUserSettings();
            f.Show();
        }
        public static void OpenNewFormUserUdate()
        {
            FormUserUpdate f = new FormUserUpdate();
            f.Show();
        }
    }
}
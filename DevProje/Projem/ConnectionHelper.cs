﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Projem
{
    class ConnectionHelper
    {
        internal static string GetConnectionString()
        {
            string conString = null;
            //ConnectionStringSettings conn_string = ConfigurationManager.ConnectionStrings["Projem.Properties.Settings.KullanıcıConnectionString"];
            ConnectionStringSettings conn_string = ConfigurationManager.ConnectionStrings["Projem.Properties.Settings.KullanıcıConStriSmartpro"];


            conString = conn_string.ConnectionString.ToString();

            return conString;
        }

        internal static string GetLoginString(string userName, string userPass)
        {
            string loginString = "Select * from dbo.fn_login('" + userName + "','" + userPass + "')";

            return loginString;
        }
        //yeni kullanıcı ekleyecek metodun connection stringi
        internal static string CreateNewUserString(string ad, string orta, string soyad, string username, string userpass, string yetki, string email, string phone, string cinsiyet)
        {

            
            string createNewUserString = "Insert Into NewUser values('" + ad + "','" + orta + "','" + soyad + "','" + username + "','" + userpass + "','" + yetki + "','" + email + "'," + phone + ",'" + cinsiyet + "')";

            return createNewUserString;
        }
    }
}

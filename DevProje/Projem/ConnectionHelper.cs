using System;
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
            string loginString = "Select * from dbo.fn_login('" + userName + "', " + userPass + ")";

            return loginString;
        }
        internal static string CreateNewUserString(string ad, string? orta, string soyad,)
        {
            Insert into NewUser values('ali', null, 'ali', null, null, null, null, null, null, null)
        }
    }
}

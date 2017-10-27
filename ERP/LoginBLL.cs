using System;
using System.Data.SqlClient;
using System.Data;
namespace ERP
{
    class LoginBLL
    {
        public static bool authenticateUser(string userId, string password)
        {
            string pass = DAL.Encrypt(password);
            string Where = "where Username='" + userId + "' and Password='" + pass + "' ";
            DataTable dt = DAL.ExecuteQuery("select * from ", "[Records].dbo.[Student Credentials]", Where);

            if (dt.Rows.Count == 0)
            {               
                return false;
            }
            else
            
               return true;

        }
    }
}
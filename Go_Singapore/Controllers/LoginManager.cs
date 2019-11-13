using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/* 
 * this class implements the LoginManager control class, which is responsible for one function only: 
 * to verify user's log-in credentials. This function is called within the LoginPage.aspx.cs file
 * 
 * @author: Irving
 */

namespace Go_Singapore.Controllers
{
    public class LoginManager
    {
        public static String LoginProcess(String strUsername, String strPassword)
        {
            String message = "";
            //my connection string
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GoSingaporeDB.mdf;Integrated Security = True;");
            SqlCommand cmd = new SqlCommand("Select * from Users where username=@Username", con);
            cmd.Parameters.AddWithValue("@Username", strUsername);
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Boolean login = (strPassword.Equals(reader["password"].ToString(), StringComparison.InvariantCulture)) ? true : false;
                    if (login)
                    {
                        message = "1";
                    }
                    else
                        message = "Invalid Credentials";
                }
                else
                    message = "Invalid Credentials";
                reader.Close();
                reader.Dispose();
                cmd.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                message = ex.Message.ToString() + "Error.";
            }
            return message;
        }
    }
}

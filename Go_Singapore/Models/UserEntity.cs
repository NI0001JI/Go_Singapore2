using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Go_Singapore.Models
{
    public class UserEntity
    {
        
        static string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GoSingaporeDB.mdf;Integrated Security = True;";
        // Validate() takes in the email and password combination of the user, if they exist in the users table, the method will return true, else false

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

        public static bool Validate(string inputEmail, string inputPassword)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand command;
            string validateCommand = "SELECT COUNT(1) FROM users WHERE email = '" + inputEmail + "' AND password = '" + inputPassword + "'";
            con.Open();

            try
            {
                command = new SqlCommand(validateCommand, con);
                int result = Convert.ToInt32(command.ExecuteScalar());
                if (result == 1)
                {
                    command.Dispose();
                    con.Close();
                    return true;
                }
                else
                {
                    command.Dispose();
                    con.Close();
                    return false;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("WARNING: " + e.ToString());
                Console.WriteLine("Please try again ... ");
            }

            con.Close();
            return false;
        }

        public static bool CheckExisting(string inputEmail, string inputUsername)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand command;
            string validateCommand = "SELECT COUNT(1) FROM users WHERE email = '" + inputEmail + "' OR username = '" + inputUsername + "'";
            con.Open();

            try
            {
                command = new SqlCommand(validateCommand, con);
                int result = Convert.ToInt32(command.ExecuteScalar());
                if (result > 0)
                {
                    command.Dispose();
                    con.Close();
                    return true;
                }
                else
                {
                    command.Dispose();
                    con.Close();
                    return false;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("WARNING: " + e.ToString());
                Console.WriteLine("Please try again ... ");
            }

            con.Close();
            return false;
        }

        // InsertEntry() takes in 4 string arguments and insert them into the "users" table
        public static void InsertEntry(string inputName, string inputUserName, string inputEmail, string inputPassword)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand command;
            string insertCommand = "";
            con.Open();

            //  try
            //  {
            insertCommand = "INSERT INTO Users (name, username, email, password) " +
                "VALUES ('" + inputName + "','" + inputUserName + "','" + inputEmail + "','" + inputPassword + "')";
            command = new SqlCommand(insertCommand, con);
            da.InsertCommand = command;
            da.InsertCommand.ExecuteNonQuery();
            Console.WriteLine("Item successfully inserted");
            da.Dispose();
            command.Dispose();
            // }
            //  catch(Exception e)
            // {
            //     Console.WriteLine("WARNING: " + e.ToString());
            //     Console.WriteLine("Please try again ... ");
            // }

            con.Close();
        }

        public static void DeleteEntry(string inputEmail)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand command;
            string deleteCommand = "";
            con.Open();

            try
            {
                deleteCommand = "DELETE FROM users WHERE email = '" + inputEmail + "'";
                command = new SqlCommand(deleteCommand, con);
                da.DeleteCommand = command;
                da.DeleteCommand.ExecuteNonQuery();
                Console.WriteLine("Item successfully deleted");
                da.Dispose();
                command.Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine("WARNING: " + e.ToString());
                Console.WriteLine("Please try again ... ");
            }

            con.Close();
        }

        // UpdatePassword() takes in the requester's email and updates its password to a new one
        // We may want to combine Validate() with UpdatePassword
        public static void UpdatePassword(string inputEmail, string inputPassword)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand command;
            string updateCommand = "";
            con.Open();

            try
            {
                updateCommand = "UPDATE users SET password = '" + inputPassword + "' WHERE email = '" + inputEmail + "'";
                command = new SqlCommand(updateCommand, con);
                da.UpdateCommand = command;
                da.UpdateCommand.ExecuteNonQuery();
                Console.WriteLine("Password successfully updated");
                da.Dispose();
                command.Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine("WARNING: " + e.ToString());
                Console.WriteLine("Please try again ... ");
            }

            con.Close();
        }
    }
}

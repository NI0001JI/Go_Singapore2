using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Go_Singapore.Models
{
    public static class Database
    {

        static SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GoSingaporeDB.mdf;Integrated Security = True;");

        //Read data from database
        public static DataTable getTable(string sql)
        {
            DataTable results = new DataTable();
            SqlCommand cmd = new SqlCommand(sql, con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataAdapter a = new SqlDataAdapter(cmd);
            a.Fill(results);
            // con.Close();

            return results;
        }

        public static int ExecuteSQLCommand(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            int result = cmd.ExecuteNonQuery();
            return result;
        }


    }
}
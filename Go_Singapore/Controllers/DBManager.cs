using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/*
 * this class implements the DBManager controller, which is responsible for information retrieval, login, and insertion 
 * to the user table contained within our .mdf database
 * 
 * the class has 6 different static functions: loginProcess, validate, CheckExisting, InsertEntry, DeleteEntry, and UpdatePassword
 * do take note that not all the functions are implemented in the final products
 * 
 * @author: Irving
 */

namespace Go_Singapore.Controllers
{
    public class DBManager // class containing all the methods to interact with the database
    {
        // change the connection string whenever the database's directory is moved
        public static bool Validate(String inputEmail, String inputPassword)
        {
            return (Models.UserEntity.Validate(inputEmail, inputPassword));
        }
        
        public static bool CheckExisting(String inputEmail, String inputUsername)
        {
            return (Models.UserEntity.CheckExisting(inputEmail, inputUsername));
        }

        public static void InsertEntry(string inputName, string inputUserName, string inputEmail, string inputPassword)
        {
            Models.UserEntity.InsertEntry(inputName, inputUserName, inputEmail, inputPassword);
            return;
        }
        public static void DeleteEntry(string inputEmail)
        {
            Models.UserEntity.DeleteEntry(inputEmail);
            return;
        }
        public static void UpdatePassword(string inputEmail, string inputPassword)
        {
            Models.UserEntity.UpdatePassword(inputEmail, inputPassword);
        }

        public static String LoginProcess(String strUsername, String strPassword)
        {
            return Models.UserEntity.LoginProcess(strUsername, strPassword);
        }
    }
}

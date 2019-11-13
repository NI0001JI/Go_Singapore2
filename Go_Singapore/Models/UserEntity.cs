using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Go_Singapore.Models
{
    public class UserEntity
    {
        public DataTable getUsers(string username, string password)
        {
            string sql = "SELECT * FROM USERS WHERE username='" + username + "' AND password='" + password + "'";
            return Database.getTable(sql);
        }
    }
}
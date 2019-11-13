using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Go_Singapore.Controllers;

/*
 * this class serves as the controller of the design object implemented in the LoginPage.aspx file
 * the log in button calls the LoginProcess() method that is set in the LoginManager control class
 * 
 * @author: Irving
 */

namespace Go_Singapore.Views
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string inputUsername = txtUsername.Text;
            string inputPassword = txtPassword.Text;

            if (inputUsername.Equals("admin", StringComparison.InvariantCultureIgnoreCase) &&
                inputPassword.Equals("admin", StringComparison.InvariantCultureIgnoreCase))
            {
                Session["admin"] = "true";
                Session["username"] = "admin";
                Response.Redirect("Index.aspx");
            }
            
            string loginStatus = LoginManager.LoginProcess(inputUsername, inputPassword);
            if(loginStatus == "1")
            {
                Session["username"] = inputUsername;
                Response.Redirect("Index.aspx");
            }
            else
            {
                Label1.Text = loginStatus;
            }

        }
    }
}

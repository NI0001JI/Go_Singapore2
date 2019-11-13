using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Go_Singapore.Controllers;

/* this class is responsible for the control logic behind the design elements in Register.aspx file
 * the methods implemented within this controller are mostly called from the DBManager.cs control class
 * 
 * the functions used are:  DBManager.CheckExisting -> to ensure that the user has not already registered
 *                          DBManager.InsertEntry -> to insert new entry to the user table in the .mdf file
 *                          
 * @author: Irving
 */

namespace Go_Singapore.Views
{
    public partial class WebForm2 : System.Web.UI.Page
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
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string inputPassword = txtPassword.Text;
            string inputPasswordConfirm = txtPasswordConfirm.Text;
            string inputUsername = txtUsername.Text;
            string inputName = txtName.Text;
            string inputEmail = txtEmail.Text;

            if((inputPassword == inputPasswordConfirm)
                && !((txtUsername.Text == String.Empty) || (txtName.Text == String.Empty) ||
                (txtPassword.Text == String.Empty) || (txtPasswordConfirm.Text == String.Empty) ||
                (txtEmail.Text == String.Empty)))
            {
                if(DBManager.CheckExisting(inputEmail, inputUsername))
                {
                    Label1.Text = "Username / Email is already taken, please try again";
                }
                else
                {
                    DBManager.InsertEntry(inputName, inputUsername, inputEmail, inputPassword);
                    Label1.Text = "Registration successful!";
                    Response.Redirect("LoginPage.aspx");
                }
            }
            else if((txtUsername.Text == String.Empty) || (txtName.Text == String.Empty) || 
                (txtPassword.Text == String.Empty) || (txtPasswordConfirm.Text == String.Empty) || 
                (txtEmail.Text == String.Empty))
            {
                Label1.Text = "Please fill in ALL the fields";
                
            }
            else
            {
                Label1.Text = "Password doesn't match, please try again";
            }
        }
    }
}

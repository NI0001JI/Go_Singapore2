using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace Go_Singapore.Controllers
{
    public class Email
    {
        private static string myEmail = "ntuemailsender@gmail.com";
        private static string myPassword = "!Password1";
        public static bool SendEmail(string email, string subject, string message)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
               
                mail.From = new MailAddress(myEmail);
                mail.To.Add(email);
                mail.Subject = "subject";
                mail.Body = "message";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(myEmail, myPassword);
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
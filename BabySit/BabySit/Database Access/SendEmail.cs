
namespace BabySit.Database_Access
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Mail;
    using System.Threading.Tasks;

    public class SendEmail
    {
        public bool SendEmailVerify(string toEmail, string emailSubject, string emailContent, int verifyCode)
        {
            bool check = false;
            try
            {
                MailMessage mail = new MailMessage();
                // you need to enter your mail address
                mail.From = new MailAddress("hakanai2020@gmail.com");
                //To Email Address - your need to enter your to email address
                mail.To.Add(toEmail);
                mail.Subject = emailSubject;
                mail.IsBodyHtml = true;
                string content = emailContent + verifyCode;
                mail.Body = content;
                //you need to pass mail server address and you can also specify the port number if you required
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                //Create nerwork credential and you need to give from email address and password
                NetworkCredential networkCredential = new NetworkCredential("hakanai2020@gmail.com", "binhbe1223");
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = networkCredential;
                smtpClient.Port = 587; // this is default port number - you can also change this
                smtpClient.EnableSsl = true; // if ssl required you need to enable it
                smtpClient.Send(mail);
                check = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return check;
        }
    }
}


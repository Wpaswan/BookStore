using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace RepositoryLayer.Service
{
    public class EmailServices
    {
        public static void sendmail(string email, string token)
        {
            using (SmtpClient client = new SmtpClient("smtp.gmail.com", 587))
            {
                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = true;
                client.Credentials = new NetworkCredential("dablumcapaswan@gmail.com", "Dablu1#@1paswan");

                MailMessage msgobj = new MailMessage();
                msgobj.To.Add(email);
                msgobj.From = new MailAddress("dablumcapaswan@gmail.com");
                msgobj.Subject = "password reset link";
                //msgobj.Body = $"BookStoreApplication/{token}";
                msgobj.Body = $"www.BookStoreApplication.com/reset-password/{token}";
                client.Send(msgobj);
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LoginC
{
    internal class EmailHelper
    {
        public void SendConfirmationEmail(string email, string confirmationLink)
        {
            var smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential("ctump147@gmail.com", "violeter");
            smtpClient.EnableSsl = true;

            var mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("ctump147@gmail.com");
            mailMessage.To.Add("hoangtuan.th484@gmail.com");
            mailMessage.Subject = "Confirm your email";
            mailMessage.Body = $@"<p>Please confirm your email by clicking this link: <a href='{confirmationLink}'>{confirmationLink}</a></p>";
            mailMessage.IsBodyHtml = true;

            smtpClient.Send(mailMessage);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Mail;

namespace FinalProjectITI.Services
{
    public class EmailHelper
    {
        //public bool SendEmail(string userEmail, string confirmationLink)
        //{
        //    MailMessage mailMessage = new MailMessage();
        //    mailMessage.From = new MailAddress("tarekgalaleldeen@gmail.com");
        //    mailMessage.To.Add(new MailAddress(userEmail));

        //    mailMessage.Subject = "Confirm your email";
        //    mailMessage.IsBodyHtml = true;
        //    mailMessage.Body = confirmationLink;

        //    SmtpClient client = new SmtpClient();
        //    client.Credentials = new System.Net.NetworkCredential("tarekgalaleldeen@gmail.com", "erufbthyoywllher");
        //    client.Host = "smtp.gmail.com";
        //    client.Port = 587;
        //    client.EnableSsl = true;

        //    try
        //    {
        //        client.Send(mailMessage);
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
                
        //        // log exception
        //    }
        //    return false;
        //}
    }
}

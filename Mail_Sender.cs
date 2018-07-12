using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Email_Send_Simulation
{
    class Mail_Sender
    {
        public static void Send_Mail(string sender, string recipient, string message, string subject)
        {
            using (MailMessage Message = new MailMessage(sender, recipient))
            {

                Message.Subject = subject;
                Message.Body = message;
                Message.IsBodyHtml = true;

                using (SmtpClient smtp = new SmtpClient())
                {
                    smtp.Host = "smtp.gmail.com";
                    smtp.EnableSsl = true;
                    NetworkCredential NetworkCard = new NetworkCredential("piotr.murdzia.csharp.testy@gmail.com", "takiehaslo123456789");
                    smtp.UseDefaultCredentials = true;
                    smtp.Credentials = NetworkCard;
                    smtp.Port = 587;
                    smtp.Send(Message);

                    Console.WriteLine("Message send");
                }
            }
        }
    }
}

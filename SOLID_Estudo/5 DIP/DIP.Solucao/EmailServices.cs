using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Estudo._5_DIP.DIP.Solucao
{
    public class EmailServices
    {
        internal static bool IsValid(string email)
        {
            return email.Contains("@");
        }

        internal static void Enviar(string fromEmail, string toEmail, string subject, string body)
        {
            var mail = new MailMessage(fromEmail, toEmail);
            var client = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mail.Subject = subject;
            mail.Body = body;
            client.Send(mail);
        }
    }
}

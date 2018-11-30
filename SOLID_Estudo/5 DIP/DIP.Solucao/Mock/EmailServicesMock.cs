using SOLID_Estudo._5_DIP.DIP.Solucao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Estudo._5_DIP.DIP.Solucao.Mock
{
    public class EmailServicesMock : IEmailServices
    {
        public void Enviar(string fromEmail, string toEmail, string subject, string body)
        {
            // Envia email 
        }

        public bool IsValid(string email)
        {
            return email.Contains("@");
        }
    }
}

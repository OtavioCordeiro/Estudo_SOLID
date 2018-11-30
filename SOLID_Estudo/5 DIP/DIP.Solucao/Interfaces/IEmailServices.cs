using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Estudo._5_DIP.DIP.Solucao.Interfaces
{
    public interface IEmailServices
    {
        bool IsValid(string email);

        void Enviar(string fromEmail, string toEmail, string subject, string body);
    }
}

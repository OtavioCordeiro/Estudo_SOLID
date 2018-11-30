using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Estudo._4_ISP.ISP.Solucao
{
    public class CadastroCliente : ICadastroCliente
    {
        public void EnviarEmail()
        {
            // Enviar email
        }

        public void SalvarBanco()
        {
            // Insert banco
        }

        public void ValidarDados()
        {
            // Valida email e cpf
        }
    }
}

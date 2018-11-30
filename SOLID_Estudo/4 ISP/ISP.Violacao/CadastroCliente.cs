using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Estudo._4_ISP.ISP.Violacao
{
    public class CadastroCliente : ICadastro
    {
        public void EnviarEmail()
        {
            // Enviar email para o cliente
        }

        public void SalvarBanco()
        {
            // Insert na tabela cliente
        }

        public void ValidarDados()
        {
            // Validar cpf, email
        }
    }
}

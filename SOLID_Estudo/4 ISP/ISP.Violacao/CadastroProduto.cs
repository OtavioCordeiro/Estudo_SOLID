using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Estudo._4_ISP.ISP.Violacao
{
    public class CadastroProduto : ICadastro
    {
        public void EnviarEmail()
        {
            // Produto não tem email, o que eu faço agora ? 
        }

        public void SalvarBanco()
        {
            // Insert tabela produto
        }

        public void ValidarDados()
        {
            // Validar valor
        }
    }
}

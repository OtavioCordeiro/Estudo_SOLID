using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Estudo._2_OCP.OCP.Solucao
{
    public class DebitoOutroTipoDeConta : DebitoConta
    {
        public override string Debitar(decimal valor, string conta)
        {
            //Debita conta investimento
            // Isentar taxas
            return NumeroTransacao;
        }
    }
}

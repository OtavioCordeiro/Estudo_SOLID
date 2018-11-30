using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Estudo._2_OCP.OCP.Solucao
{
    public class DebitoContaCorrente : DebitoConta
    {
        public override string Debitar(decimal valor, string conta)
        {
            // Debita conta corrente

            return NumeroTransacao;
        }
    }
}

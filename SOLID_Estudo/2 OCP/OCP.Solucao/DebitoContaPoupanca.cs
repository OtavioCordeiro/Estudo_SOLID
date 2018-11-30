using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Estudo._2_OCP.OCP.Solucao
{
    public class DebitoContaPoupanca : DebitoConta
    {
        public override string Debitar(decimal valor, string conta)
        {
            // Valida aniversário da conta
            // Debita conta poupança
            return NumeroTransacao;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Estudo._2_OCP.OCP.Violacao
{
    public class DebitoConta
    {
        public void Debitar(decimal valor, string conta, TipoConta tipoConta)
        {
            if (tipoConta == TipoConta.Corrente)
            {
                // Debita conta corrente
            }

            if (tipoConta == TipoConta.Poupanca)
            {
                // Valida aniversário da conta
                // Debita conta poupança
            }

            // Se entrar mais um tipo de conta, vamos ter que adicionar mais um if e assim o código fica aberto
        }
    }
}

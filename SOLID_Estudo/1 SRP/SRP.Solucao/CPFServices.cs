using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Estudo._1_SRP.SRP.Solucao
{
    public class CPFServices
    {
        internal static bool IsValid(string cpf)
        {
            return cpf.Length == 11;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Estudo._1_SRP.SRP.Solucao
{
    public class Cliente
    {
        public int ClientId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime DataCadastro { get; set; }

        public bool IsValid()
        {
            return EmailServices.IsValid(Email) && CPFServices.IsValid(CPF);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Estudo._3_LSP.LSP.Violacao
{
    public class Quadrado : Retangulo
    {
        public override double Altura
        {
            set => base.Altura = base.Largura = value;
        }

        public override double Largura
        {
             set => base.Altura = base.Largura = value;
        }
    }
}

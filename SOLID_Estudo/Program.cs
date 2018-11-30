using SOLID_Estudo._3_LSP.LSP.Violacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Estudo
{
    class Program
    {
        static void Main(string[] args)
        {
            var quad = new Quadrado()
            {
                Altura = 10,
                Largura = 5
            };

            // Usando o quadrado como um retangulo, neste caso a classe filha não esta substituindo plenamente a classe base.
            // é necessário pensar mais do que o quadrado é um retangulo.
            ObterAreaRetangulo(quad);
        }

        private static void ObterAreaRetangulo(Retangulo ret)
        {
            Console.WriteLine("Calculo da área do retangulo");
            Console.WriteLine(ret.Altura.ToString() + " * " + ret.Largura.ToString());
            Console.WriteLine(ret.Area);
            Console.ReadKey();
        }
    }
}

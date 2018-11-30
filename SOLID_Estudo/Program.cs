using Ninject;
using SOLID_Estudo._3_LSP.LSP.Violacao;
using SOLID_Estudo._5_DIP.DIP.Solucao;
using SOLID_Estudo._5_DIP.DIP.Solucao.Interfaces;
using SOLID_Estudo._5_DIP.DIP.Solucao.Mock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Estudo
{
    class Program
    {
        static IKernel ninjectKernel;

        static void Main(string[] args)
        {
            //LSP_Test();

            DIP_Test();

            Console.ReadKey();
        }

        private static void DIP_Test()
        {
            ninjectKernel = new StandardKernel();

            InjetarDependencia();

            IClienteService clienteService = ninjectKernel.Get<IClienteService>();
            ICPFServices cpfServices = ninjectKernel.Get<ICPFServices>();
            IEmailServices emailServices = ninjectKernel.Get<IEmailServices>();

            Cliente cliente = new Cliente(cpfServices, emailServices)
            {
                ClientId = 1,
                CPF = "12345678913",
                DataCadastro = DateTime.Now,
                Email = "test@test.com",
                Nome = "Test Name"
            };

            string result = clienteService.AdicionarCliente(cliente);

            Console.WriteLine(result);
        }

        private static void LSP_Test()
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

        private static void InjetarDependencia()
        {
            //ninjectKernel.Bind<IClienteRepository>().To<ClienteRepository>();
            ninjectKernel.Bind<IClienteRepository>().To<ClienteRepositoryMock>();
            ninjectKernel.Bind<IClienteService>().To<ClienteService>();
            ninjectKernel.Bind<ICPFServices>().To<CPFServices>();
            //ninjectKernel.Bind<IEmailServices>().To<EmailServices>();
            ninjectKernel.Bind<IEmailServices>().To<EmailServicesMock>();

        }
    }
}

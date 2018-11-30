using SOLID_Estudo._5_DIP.DIP.Solucao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Estudo._5_DIP.DIP.Solucao.Mock
{
    public class ClienteRepositoryMock : IClienteRepository
    {
        public void AdicionarCliente(Cliente cliente)
        {
            // Adiciona ao banco
        }
    }
}

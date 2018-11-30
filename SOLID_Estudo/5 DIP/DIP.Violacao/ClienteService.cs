using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Estudo._5_DIP.DIP.Violacao
{
    public class ClienteService
    {
        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.IsValid())
                return "Dados inválidos";

            // estou dependendo de uma implementação aqui
            var repo = new ClienteRepository();
            repo.AdicionarCliente(cliente);

            // estou dependendo de uma implementação aqui ( Acoplamento não é legal )
            EmailServices.Enviar("empresa@empresa.com", cliente.Email, "Bem Vindo", "Parabéns está Cadastrado");

            return "Cliente cadastrado com sucesso";
        }
    }
}

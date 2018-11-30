using SOLID_Estudo._5_DIP.DIP.Solucao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Estudo._5_DIP.DIP.Solucao
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IEmailServices _emailServices;

        // Recebendo injeção de dependencia via construtor
        public ClienteService(IClienteRepository clienteRepository, IEmailServices emailServices)
        {
            _clienteRepository = clienteRepository;
            _emailServices = emailServices;
        }

        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.IsValid())
                return "Dados inválidos";

            _clienteRepository.AdicionarCliente(cliente);

            // estou dependendo de uma implementação aqui ( Acoplamento não é legal )
            _emailServices.Enviar("empresa@empresa.com", cliente.Email, "Bem Vindo", "Parabéns está Cadastrado");

            return "Cliente cadastrado com sucesso";
        }
    }
}

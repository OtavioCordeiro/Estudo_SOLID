using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Estudo._1_SRP.SRP.Violacao
{
    public class Cliente
    {
        public int ClientId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime DataCadastro { get; set; }

        // A classe cliente não deveria ser responsavel por se adicionar ao banco de dados, ela deveria no máximo validar seus campos

        // 4 Violações do principio de responsabilidade única dentro do método
        public string AdicionarCliente()
        {
            // Um método não é obrigado a saber como validar um email
            if (!Email.Contains("@"))
                return "Cliente com e-mail inválido";

            // Um método não é obrigado a saber como validar um cpf
            if (CPF.Length != 11)
                return "Cliente com CPF inválido";

            // Não é obrigado a conectar ao banco de dados e nem saber como se conecta
            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();
                cn.ConnectionString = "MinhaConnectionString";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO CLIENTE (NOME, EMAIL, CPF, DATACADASTRO) VALUES (@nome, @email, @cpf, @dataCad))";

                cmd.Parameters.AddWithValue("nome", Nome);
                cmd.Parameters.AddWithValue("email", Email);
                cmd.Parameters.AddWithValue("cpf", CPF);
                cmd.Parameters.AddWithValue("dataCad", DataCadastro);

                cn.Open();
                cmd.ExecuteNonQuery();
            }

            // Não deve saber como enviar email
            var mail = new MailMessage("empresa@empresa.com", Email);
            var client = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mail.Subject = "Bem Vindo.";
            mail.Body = "Parabéns! Você está cadastrado.";
            client.Send(mail);

            return "Cliente cadastrado com sucesso";
        }         
    }
}

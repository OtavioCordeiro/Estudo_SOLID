using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Estudo._1_SRP.SRP.Solucao
{
    public class ClienteRepository
    {
        public void AdicionarCliente(Cliente cliente)
        {
            using (var cn = new SqlConnection())
            {
                // Essa classe não deveria conhecer o banco de dados, mas por enquanto vamos deixar assim.
                var cmd = new SqlCommand();
                cn.ConnectionString = "MinhaConnectionString";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO CLIENTE (NOME, EMAIL, CPF, DATACADASTRO) VALUES (@nome, @email, @cpf, @dataCad))";

                cmd.Parameters.AddWithValue("nome", cliente.Nome);
                cmd.Parameters.AddWithValue("email", cliente.Email);
                cmd.Parameters.AddWithValue("cpf", cliente.CPF);
                cmd.Parameters.AddWithValue("dataCad", cliente.DataCadastro);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}

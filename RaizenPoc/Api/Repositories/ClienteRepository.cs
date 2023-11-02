using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Api.Data;
using Api.Models;
using Dapper;
using Microsoft.Data.SqlClient;


namespace Api.Repositories
{
    public class ClienteRepository
    {

        public ClienteRepository(){  }  
        public bool SalvarCliente(Cliente input)
        {
            var connection = new SqlConnection("");
            connection.Open();
            var rowsAffected = connection.Execute(ClienteQueries.SALVAR_CLIENTE,input);
            if (rowsAffected == 0) return false;    
            connection.Close();
            return true;
        }
        public bool AtualizarCliente(Cliente input)
        {
            var connection = new SqlConnection("");
            connection.Open();
            var rowsAffected = connection.Execute(ClienteQueries.ATUALIZAR_CLIENTE, input);
            if (rowsAffected == 0) return false;
            connection.Close();
            return true;
        }
        public bool ObterCliente(int? id)
        {
            var connection = new SqlConnection("");
            connection.Open();

            List<Cliente> insertedCustomers = new List<Cliente>();
            if (id == null)
                insertedCustomers = connection.Query<Cliente>(ClienteQueries.OBTER_CLIENTE).ToList();
            else
            {
                var parameters = new { Id = id };
                insertedCustomers = connection.Query<Cliente>(ClienteQueries.OBTER_CLIENTE_ID,parameters).ToList();
            }
            connection.Close();
            return true;
        }
    }
}

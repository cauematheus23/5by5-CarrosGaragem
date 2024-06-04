using Dapper;
using Microsoft.Data.SqlClient;
using Models;
using System.Configuration;

namespace Repositories
{
    public class ServicoRepository : IServicoRepositoryInterface
    {
        private string Conn { get; set; }
        public ServicoRepository()
        {
            Conn = ConfigurationManager.ConnectionStrings["StringConnection"].ConnectionString;
        }
        public int InserirServico(Servico servico)
        {
            int status = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(Conn))
                {
                    connection.Open();
                    status = connection.ExecuteScalar<int>(Servico.INSERT, servico);
                    connection.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return status;
        }
    }
}

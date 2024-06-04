using Dapper;
using Microsoft.Data.SqlClient;
using Models;
using System.Configuration;

namespace Repositories
{
    public class CarroRepository
    {
        private string Conn { get; set; }

        public CarroRepository()
        {
            Conn = ConfigurationManager.ConnectionStrings["StringConnection"].ConnectionString;
        }

        public bool Insert(List<Carro> listaCarros)
        {
            var status = false;
            try
            {
                using (var conexaosql = new SqlConnection(Conn))
                {
                    conexaosql.Open();
                    foreach (var carro in listaCarros)
                    {
                        conexaosql.Execute(Carro.INSERT, carro);
                    }
                    status = true;
                    conexaosql.Close();
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

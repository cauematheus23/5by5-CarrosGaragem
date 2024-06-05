using Dapper;
using Microsoft.Data.SqlClient;
using Models;
using System.Configuration;

namespace Repositories
{
    public class CarroRepository : ICarroRepository
    {
        private string Conn { get; set; }

        public CarroRepository()
        {
            Conn = ConfigurationManager.ConnectionStrings["StringConnection"].ConnectionString;
        }
        public List<Carro> RetornarCarros()
        {
            var carros = new List<Carro>();
            try
            {
                using (SqlConnection connection = new SqlConnection(Conn))
                {
                    connection.Open();
                    carros = connection.Query<Carro>(Carro.SELECT).ToList();
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("Erro: " + e.Message);
            }
            return carros;
        }
        public List<Carro_Servico> ServicosCarros()
        {
            var servicos_carros = new List<Carro_Servico>();
            using (SqlConnection conn = new SqlConnection(Conn))
            {
                conn.Open();
                servicos_carros = conn.Query<Carro_Servico, Carro, Servico, Carro_Servico>(Carro_Servico.SELECT,
                    (carroServico, carro, servico) => { carroServico.Carro = carro; carroServico.Servico = servico; return carroServico; }, splitOn: "Placa,Id").ToList();
            }
            return servicos_carros;
        }
        public List<Carro> CarrosComServicos()
        {
            var carros = new List<Carro>();
            using (SqlConnection conn = new SqlConnection(Conn))
            {
                conn.Open();
                carros = conn.Query<Carro>(Carro.SELECTStatus).ToList();
                conn.Close();
            }
            return carros;
        }
    }
}

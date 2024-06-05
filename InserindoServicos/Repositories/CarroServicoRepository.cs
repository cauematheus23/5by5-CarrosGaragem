using Dapper;
using Microsoft.Data.SqlClient;
using Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CarroServicoRepository : ICarroServicoRepositoryInterface
    {
        string Conn { get; set; }
        public CarroServicoRepository()
        {
            Conn = ConfigurationManager.ConnectionStrings["StringConnection"].ConnectionString;
        }
        public bool InserirCarroServico(Carro_Servico carro_Servico)
        {
            var status = false;
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conn))
                {
                    conexao.Open();
                    conexao.Execute("INSERT INTO TB_CARROSERVICO (PlacaCarro, IdServico,Status) VALUES (@PlacaCarro, @IdServico, @Status);", new { PlacaCarro = carro_Servico.Carro.Placa, IdServico = carro_Servico.Servico.Id, Status = carro_Servico.Status});
                    conexao.Close();
                    status = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
            return status;
        }
        public bool AgregarCarroServico(string placa,int idServico, bool stats)
        {
            var status = false;
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conn))
                {
                    conexao.Open();
                    var query = "INSERT INTO TB_CARROSERVICO (PlacaCarro, IdServico, Status) VALUES (@PlacaCarro, @IdServico, @Status);";
                    var parametros = new DynamicParameters();
                    parametros.Add("@PlacaCarro", placa);
                    parametros.Add("@IdServico", idServico);
                    parametros.Add("@Status", stats);
                    conexao.Execute(query,parametros);
                    conexao.Close();
                    status = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Parametros nao encontrado na base de dados");
                Console.WriteLine(e.Message);

            }
            return status;
        }
    }
}

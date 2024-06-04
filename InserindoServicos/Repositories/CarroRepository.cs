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
    public class CarroRepository : ICarroRepository
    {
        private string Conn { get; set; }
        public CarroRepository()
        {
            Conn = ConfigurationManager.ConnectionStrings["StringConnection"].ConnectionString;
        }
        public bool InserirApenasCarro(Carro carro)
        {
            var status = false;
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conn))
                {
                    conexao.Open();
                    conexao.Execute(Carro.INSERT, carro);
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
    
        public string InserirCarro(Carro carro)
        {
            var status = "";
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conn))
                {
                    conexao.Open();
                    status = conexao.ExecuteScalar<string>(Carro.INSERTCAST, carro);
                    conexao.Close();
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

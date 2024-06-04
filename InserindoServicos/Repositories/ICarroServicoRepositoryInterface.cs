using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ICarroServicoRepositoryInterface
    {
        public bool InserirCarroServico(Carro_Servico carroServico);
        public bool AgregarCarroServico(string placa, int idServico, bool stats);
    }
}

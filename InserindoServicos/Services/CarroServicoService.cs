using Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CarroServicoService
    {
        private ICarroServicoRepositoryInterface _carroServicoRepository;
        private ICarroRepository _carroRepository;
        IServicoRepositoryInterface _servicoRepository;
        public CarroServicoService()
        {
            _carroServicoRepository = new CarroServicoRepository();
            _carroRepository = new CarroRepository();
            _servicoRepository = new ServicoRepository();
        }
        public bool InserirCarroServico(Carro_Servico cs)
        {
            string Placa = _carroRepository.InserirCarro(cs.Carro);
            cs.Carro.Placa = Placa;
            int IdServico = _servicoRepository.InserirServico(cs.Servico);
            cs.Servico.Id = IdServico;
            return _carroServicoRepository.InserirCarroServico(cs);
        }
        public bool AgregarCarroServico(string placa, int idServico, bool stats)
        {
            return _carroServicoRepository.AgregarCarroServico(placa, idServico, stats);
        }

    }
}

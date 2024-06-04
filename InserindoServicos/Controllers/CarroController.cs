using Models;
using Services;

namespace Controllers
{
    public class CarroController
    {
        private CarroService _carroService;
        private CarroServicoService _carroServicoService;
        private ServicoService _servicoService;
        public CarroController()
        {
            _carroService = new CarroService();
            _carroServicoService = new CarroServicoService();
            _servicoService = new ServicoService();
        }
        public bool InserirApenasCarro(Carro carro)
        {
            return _carroService.InserirApenasCarro(carro);
        }
        public bool InserirCarroServico(Carro_Servico carroServico)
        {
            return _carroServicoService.InserirCarroServico(carroServico);
        }
        public int InserirServico(Servico servico)
        {
            return _servicoService.InserirServico(servico);
        }
        public string InserirCarro(Carro carro)
        {
            return _carroService.InserirCarro(carro);
        }
        public bool AgregarCarroServico(string placa, int idServico, bool stats)
        {
            return _carroServicoService.AgregarCarroServico(placa, idServico, stats);
        }
    }
}

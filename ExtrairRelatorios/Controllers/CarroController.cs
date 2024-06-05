using Models;
using Services;

namespace Controllers
{
    public class CarroController
    {
        private CarroService _carroService;
        public CarroController()
        {
            _carroService = new CarroService();
        }
        public List<Carro> RetornarCarros()
        {
            return _carroService.RetornarCarros();
        }
        public List<Carro> CarrosComServicos()
        {
            return _carroService.CarrosComServicos();
        }
        public List<Carro_Servico> ServicosCarros()
        {
            return _carroService.ServicosCarros();
        }
    }
}

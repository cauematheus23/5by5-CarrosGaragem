using Models;
using Repositories;

namespace Services
{
    public class CarroService
    {
        private ICarroRepository _carroRepository;
        public CarroService()
        {
            _carroRepository = new CarroRepository();
        }
        public List<Carro> RetornarCarros()
        {
            return _carroRepository.RetornarCarros();
        }
        public List<Carro> CarrosComServicos()
        {
            return _carroRepository.CarrosComServicos();
        }
        public List<Carro_Servico> ServicosCarros()
        {
            return _carroRepository.ServicosCarros();
        }
    }
}

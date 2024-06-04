using Models;
using Services;

namespace Controllers
{
    public class CarroController
    {
        private CarroServico _carroServico;

            public CarroController()
        {
            _carroServico = new CarroServico();
        }

        public bool Insert(List<Carro> listaCarros)
        {
            return _carroServico.Insert(listaCarros);
        }
    }
}

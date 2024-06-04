using Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CarroService
    {
        private ICarroRepository _carroRepository;
        public CarroService()
        {
            _carroRepository = new CarroRepository();
        }
        public string  InserirCarro(Carro carro)
        {
            return _carroRepository.InserirCarro(carro);
        }
        public bool InserirApenasCarro(Carro carro)
        {
            return _carroRepository.InserirApenasCarro(carro);
        }
    }
}

using Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CarroServico
    {
        private readonly CarroRepository _carrorepository;
        public CarroServico()
        {
            _carrorepository = new CarroRepository();
        }
        public bool Insert(List<Carro> listaCarros)
        {
            return _carrorepository.Insert(listaCarros);
        }
    }
}

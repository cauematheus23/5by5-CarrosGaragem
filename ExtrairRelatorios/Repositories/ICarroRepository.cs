using Models;

namespace Repositories
{
    public interface ICarroRepository
    {
        List<Carro> RetornarCarros();
        List<Carro_Servico> ServicosCarros();
        List<Carro> CarrosComServicos();
    }
}
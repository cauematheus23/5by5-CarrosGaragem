using Models;
using Repositories;

namespace Services
{
    public class ServicoService
    {
        private ServicoRepository _servicoRepository;
        public ServicoService()
        {
            _servicoRepository = new ServicoRepository();
        }
        public int InserirServico(Servico servico)
        {
            return _servicoRepository.InserirServico(servico);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Carro_Servico
    {
        public int Id { get; set; }
        public Carro Carro { get; set; }
        public Servico Servico { get; set; }
        public bool Status { get; set; }

        public override string? ToString() => $"Id: {Id},\n Carro: {Carro.Placa},\n Serviço: {Servico.Id},\n Status: {Status}";
    }
}

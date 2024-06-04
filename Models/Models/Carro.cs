namespace Models
{
    public class Carro
    {
        public string Placa { get; set; }
        public string Nome { get; set; }
        public int AnoModelo { get; set; }
        public int AnoFabricacao { get; set; }
        public string Cor { get; set; }

        public override string? ToString() => $"Placa: {Placa},\n Nome: {Nome},\n Ano Modelo: {AnoModelo},\n Ano Fabricação: {AnoFabricacao},\n Cor: {Cor}";
    }
}

using Newtonsoft.Json;

namespace Models
{
    public class Carro
    {
        public readonly static string INSERT = "INSERT INTO TB_CARRO (Placa, Nome, AnoModelo, AnoFabricacao, Cor) VALUES (@Placa, @Nome, @AnoModelo, @AnoFabricacao, @Cor);";
        [JsonProperty("Placa")]
        public string Placa { get; set; }
        [JsonProperty("Nome")]
        public string Nome { get; set; }
        [JsonProperty("AnoModelo")]
        public int AnoModelo { get; set; }
        [JsonProperty("AnoFabricacao")]
        public int AnoFabricacao { get; set; }
        [JsonProperty("Cor")]
        public string Cor { get; set; }

        public override string? ToString() => $"Placa: {Placa},\nNome: {Nome},\nAno Modelo: {AnoModelo},\nAno Fabricação: {AnoFabricacao},\nCor: {Cor}";
    }
}

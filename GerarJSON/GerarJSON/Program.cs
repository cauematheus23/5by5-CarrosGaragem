using GerarJSON;
using Newtonsoft.Json;
string[] cores = new string[] { "Branco", "Preto", "Vermelho", "Azul", "Verde", "Amarelo", "Rosa", "Roxo", "Laranja", "Cinza" };
string[] nomesCarros = {
            "Fusca",
            "Gol",
            "Palio",
            "Uno",
            "Civic",
            "Corolla",
            "Focus",
            "Onix",
            "Celta",
            "HB20",
            "Fiesta",
            "Siena",
            "Prisma",
            "Cruze",
            "Renegade"
        };
List<Carro> list = new List<Carro>();

for (int i = 0; i < 30; i++)
{

    list.Add(new Carro
    {
        Placa = "ABC-123" + i,
        Nome = nomesCarros[new Random().Next(0, nomesCarros.Length)],
        AnoModelo = new Random().Next(1990, 2024),
        AnoFabricacao = new Random().Next(1990, 2024),
        Cor = cores[new Random().Next(0, cores.Length)]
    });
}


if (list.Count > 0)
{
    string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Documents\\Dados\\";
    string file = "carros.json";

    if (!Directory.Exists(path))
    {
        Directory.CreateDirectory(path);
    }
    if (!File.Exists(path + file))
    {
        var x = File.Create(path + file);
        x.Close();
    }
    StreamWriter sw = new StreamWriter(path + file);
    sw.Write(JsonConvert.SerializeObject(list));
    sw.Close();
}



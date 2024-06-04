
using Controllers;
using Models;

string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Documents\\Dados\\carros.json";
List<Carro> teste = ReadFile.GetCarros(path);
CarroController carroController = new CarroController();

if (carroController.Insert(teste))
{
    Console.WriteLine("Inserido com sucesso");
}
else
{
    Console.WriteLine("Erro ao inserir");
}
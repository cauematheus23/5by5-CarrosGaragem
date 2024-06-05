// Retornar todos os carros que estão com o serviço em andamento (status = true)
// retornar todos os carros vermelhos existentes
// retornar todos os carros fabricados entre 2010 e 2011
//Converter as 3 consultas para XML

using Repositories;

CarroRepository cr = new CarroRepository();

var carros = cr.CarrosComServicos();
Console.WriteLine("Carros com serviços ativos");
foreach (var c in carros)
    {
    Console.WriteLine(c);
    Console.WriteLine();
}
Console.WriteLine("Carros Vermelhos");
var carros_vermelhos = cr.RetornarCarros().Where(c => c.Cor == "Vermelho");
foreach(var carro in carros_vermelhos)
{
    Console.WriteLine(carro);
    Console.WriteLine();
}
var carros_fabricados = cr.RetornarCarros().Where(c => c.AnoFabricacao >= 2010 && c.AnoFabricacao <= 2011);
Console.WriteLine("Carros fabricados entre 2010 e 2011");
foreach (var carro in carros_fabricados)
{
    Console.WriteLine(carro);
    Console.WriteLine();
}


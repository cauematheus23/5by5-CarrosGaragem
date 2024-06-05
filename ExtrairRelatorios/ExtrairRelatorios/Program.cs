// Retornar todos os carros que estão com o serviço em andamento (status = true)
// retornar todos os carros vermelhos existentes
// retornar todos os carros fabricados entre 2010 e 2011
//Converter as 3 consultas para XML

using Models;
using Repositories;
using System.Xml.Linq;



CarroRepository cr = new CarroRepository();
var x = cr.ServicosCarros();
foreach (var item in x)
{
    Console.WriteLine(item);
    Console.WriteLine();
}

var carros = cr.CarrosComServicos();
Console.WriteLine("Carros com serviços ativos");

Console.WriteLine("Carros Vermelhos");
List<Carro> carros_vermelhos = new List<Carro>( cr.RetornarCarros().Where(c => c.Cor == "Vermelho"));

var carros_fabricados = new List<Carro>(cr.RetornarCarros().Where(c => c.AnoFabricacao >= 2010 && c.AnoFabricacao <= 2011));
Console.WriteLine("Carros fabricados entre 2010 e 2011");


bool GenerateXMLCarroVermelho(List<Carro> lst)
{
    string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Documents\\Dados\\";
    string file = "RedCars";
    if (!Directory.Exists(path))
    {
        Directory.CreateDirectory(path);
    }
    if (!File.Exists(path + file))
    {
        var x = File.Create(path + file);
        x.Close();
    }
    if (lst.Count > 0)
    {
        var infracao = new XElement("Root", from carro in lst
                                            select new XElement("Carro",
                                                new XElement("Placa", carro.Placa),
                                                new XElement("Nome", carro.Nome),
                                                new XElement("AnoModelo", carro.AnoModelo),
                                                new XElement("AnoFabricacao", carro.AnoFabricacao),
                                                new XElement("Cor", carro.Cor)
                                            )
        );

        StreamWriter sw = new StreamWriter(path + file);
        sw.Write(infracao);
        sw.Close();
        return true;
    }
    else
    {
        return false;
    }

}
bool GenerateXMLStatusTrue(List<Carro> lst)
{
    string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Documents\\Dados\\";
    string file = "CarStatsTrue";
    if (!Directory.Exists(path))
    {
        Directory.CreateDirectory(path);
    }
    if (!File.Exists(path + file))
    {
        var x = File.Create(path + file);
        x.Close();
    }
    if (lst.Count > 0)
    {
        var infracao = new XElement("Root", from carro in lst
                                            select new XElement("Carro",
                                                new XElement("Placa", carro.Placa),
                                                new XElement("Nome", carro.Nome),
                                                new XElement("AnoModelo", carro.AnoModelo),
                                                new XElement("AnoFabricacao", carro.AnoFabricacao),
                                                new XElement("Cor", carro.Cor)
                                            )
        );

        StreamWriter sw = new StreamWriter(path + file);
        sw.Write(infracao);
        sw.Close();
        return true;
    }
    else
    {
        return false;
    }
}
bool GenerateXMLAnoFabricado(List<Carro> lst)
{
    string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Documents\\Dados\\";
    string file = "CarsFabricateBetween";
    if (!Directory.Exists(path))
    {
        Directory.CreateDirectory(path);
    }
    if (!File.Exists(path + file))
    {
        var x = File.Create(path + file);
        x.Close();
    }
    if (lst.Count > 0)
    {
        var infracao = new XElement("Root", from carro in lst
                                            select new XElement("Carro",
                                                new XElement("Placa", carro.Placa),
                                                new XElement("Nome", carro.Nome),
                                                new XElement("AnoModelo", carro.AnoModelo),
                                                new XElement("AnoFabricacao", carro.AnoFabricacao),
                                                new XElement("Cor", carro.Cor)
                                            )
        );

        StreamWriter sw = new StreamWriter(path + file);
        sw.Write(infracao);
        sw.Close();
        return true;
    }
    else
    {
        return false;
    }

}


Console.WriteLine(GenerateXMLCarroVermelho(carros_vermelhos));
Console.WriteLine(GenerateXMLStatusTrue(carros));
Console.WriteLine(GenerateXMLAnoFabricado(carros_fabricados));
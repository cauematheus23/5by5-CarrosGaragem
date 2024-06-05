// Retornar todos os carros que estão com o serviço em andamento (status = true)
// retornar todos os carros vermelhos existentes
// retornar todos os carros fabricados entre 2010 e 2011
//Converter as 3 consultas para XML

using Controllers;
using Models;
using Repositories;
using System.Xml.Linq;

 void Enter()
{
    Console.WriteLine("Press Enter to continue");
    Console.ReadLine();
    Console.Clear();
}
void CriarMenu()
{
    
    do
    {
        switch (new Menu().ChamarMenu())
        {
            case 0:
                Console.WriteLine("Finalizando o Programa");
                Environment.Exit(0);
                break;
            case 1:
                Console.WriteLine("Carros Vermelhos");
                new CarroController().RetornarCarros().Where(c => c.Cor == "Vermelho").ToList().ForEach(c => Console.WriteLine(c));
                Enter();
                break;
            case 2:
                Console.WriteLine("Gerando XML Carros Vermelhos");
                Console.WriteLine(new GenerateXMLs().GenerateXMLCarroVermelho(new CarroController().RetornarCarros().Where(c => c.Cor == "Vermelho").ToList()) ? "Criado com sucesso":"erro ao criar");
                Enter();
                break;
            case 3:
                Console.WriteLine("Carros com Status True");
                new CarroController().ServicosCarros().ForEach(c => Console.WriteLine(c));
                Enter();
                break;
            case 4:
                Console.WriteLine("Gerando XML Carros com Status True");
                Console.WriteLine( new GenerateXMLs().GenerateXMLStatusTrue(new CarroController().CarrosComServicos()) ? "Criado com sucesso" : "erro ao criar");
                Enter();
                break;
            case 5:
                Console.WriteLine("Carros fabricados entre 2010 e 2011");
                new CarroController().RetornarCarros().Where(c => c.AnoFabricacao >= 2010 && c.AnoFabricacao <= 2011).ToList().ForEach(c => Console.WriteLine(c));
                Enter();
                break;
            case 6:
                Console.WriteLine("Gerando XML Carros fabricados entre 2010 e 2011");
                Console.WriteLine(new GenerateXMLs().GenerateXMLAnoFabricado(new CarroController().RetornarCarros().Where(c => c.AnoFabricacao >= 2010 && c.AnoFabricacao <= 2011).ToList()) ? "Criado com sucesso" : "erro ao criar");
                Enter();
                break;

        }
    } while (true);
}
CriarMenu();


using Controllers;
using Models;

CarroController controller = new CarroController();


/*controller.InserirCarroServico(new Carro_Servico
{
    Carro = new Carro { Placa = "TESTE1", Nome = "Mercedes Benz", AnoFabricacao = 2012, AnoModelo = 2024, Cor = "Preto" },
    Servico = new Servico { Descricao = "Troca de óleo" },
    Status = (new Random().Next(0, 2) == 1)
});*/

controller.AgregarCarroServico("PUY-3041", 1, true);

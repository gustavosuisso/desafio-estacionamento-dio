using DesafioEstacionamento.Model;

Estacionamento estacionamento = new Estacionamento();
string opcao = null;
bool continuar = true;


while(continuar)
{
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veiculo \n2 - Remover veiculo \n3 - Listar veiculos \n4 - Encerrar");
    opcao = Console.ReadLine();

    switch(opcao){

        case "1":

            Console.WriteLine("Digite a placa do veiculo para estacionar: ");
            string placaCadastro = Console.ReadLine();

            estacionamento.CadastrarVeiculo(placaCadastro);

            break;
        
        case "2":

            Console.WriteLine("Digite a placa do veiculo para remover:");
            string placaRemover = Console.ReadLine();
            Console.WriteLine("Digite a quantidade horas que o veiculo permaneceu estaciodo:");
            int quantidadeHoras = int.Parse(Console.ReadLine());

            estacionamento.RemoverVeiculo(placaRemover, quantidadeHoras);

            break;
        
        case "3":

            Console.WriteLine("Veiculos estacionados: ");
            estacionamento.ListarVeiculos();
            
            break;

        case "4": 

            Console.WriteLine("Encerrando programa.");
            continuar = false;
            break;

        default:

            Console.WriteLine("Opção inválida.");
            break;

    }


    if(opcao != "4")
    {
        Console.WriteLine("Pressione uma tecla para continuar: ");
        opcao = Console.ReadLine();
        Console.Clear();
    }

}

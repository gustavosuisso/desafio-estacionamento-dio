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

            estacionamento.CadastrarVeiculo();
            break;
        
        case "2":

            estacionamento.RemoverVeiculo();
            break;
        
        case "3":

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

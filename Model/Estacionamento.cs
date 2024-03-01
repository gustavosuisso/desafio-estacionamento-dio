using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioEstacionamento.Model
{
    public class Estacionamento
    {
        // criando uma lista como atributo, sendo ela do tipo Carro para armazenarmos nossos carros
        private List<Carro> carros = new List<Carro>();
        private decimal valorTaxaFixa = 5M;
        private decimal valorTaxaHora = 2M;

        public void CadastrarVeiculo()
        {

            Console.WriteLine("Digite a placa do veiculo para estacionar: ");
            string placaCadastro = Console.ReadLine();

            Carro carro = new Carro(placaCadastro);
            carros.Add(carro);

            Console.WriteLine("Veiculo estacionado com sucesso.");

        }

        public void ListarVeiculos()
        {

            Console.WriteLine("Veiculos estacionados: ");

            Console.WriteLine("Listando as placas dos veiculos estacionados:");

            foreach(Carro carro in carros)
            {
                Console.WriteLine(carro.Placa);
            }

        }

        public void RemoverVeiculo()
        {


            Console.WriteLine("Digite a placa do veiculo para remover:");
            string placa = Console.ReadLine();
            Console.WriteLine("Digite a quantidade horas que o veiculo permaneceu estaciodo:");
            decimal quantidadeHoras = decimal.Parse(Console.ReadLine());

            for(int i = 0; i < carros.Count(); i++)
            {

                
                    if(carros[i].Placa == placa)
                    {
                        string numeroPlaca = carros[i].Placa;
                        bool removeu = carros.Remove(carros[i]);
                        if(removeu){

                            Console.WriteLine($"O veiculo com a placa {numeroPlaca} foi removido e o preço total foi " 
                            + $"de: {CalcularTaxa(quantidadeHoras)}");

                        }
                    }
                

            }
        }

        public decimal CalcularTaxa(decimal quantidadeHoras){

            decimal valorTotal = valorTaxaFixa + (valorTaxaHora * quantidadeHoras);
            return valorTotal;

        }
        
    }
}
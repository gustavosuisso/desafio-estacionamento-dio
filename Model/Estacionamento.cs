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

        public void CadastrarVeiculo(string placa)
        {

            Carro carro = new Carro(placa);
            carros.Add(carro);

        }

        public void ListarVeiculos()
        {

            Console.WriteLine("Listando as placas dos veiculos estacionados:");

            foreach(Carro carro in carros)
            {
                Console.WriteLine(carro.Placa);
            }

        }

        public void RemoverVeiculo(string placa, decimal quantidadeHoras)
        {

            Carro veiculo;
            for(int i = 0; i < carros.Count(); i++)
            {

                if(carros[i].Placa == placa)
                {

                    bool removeu = carros.Remove(carros[i]);
                    if(removeu){

                        Console.WriteLine($"O veiculo com a placa {carros[i].Placa} foi removido e o preço total foi " 
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
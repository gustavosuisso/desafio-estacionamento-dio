using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioEstacionamento.Model
{

    // classe onde armazenaremos apenas o número da placa do carro
    public class Carro
    {
        // campo onde armazenaremos a placa informada
        private string _placa;

        // atributo que usaremos para passar o valor e pegar o valor do campo (ou atributo) _placa
        public string Placa 
        {

            get => _placa; // usando body expressions para abreviar o get

            set
            {
                if(value != "")
                {
                    _placa = value;
                } 
                else 
                {
                    throw new ArgumentException();
                }
            }

        }


        public Carro(){

        }

        // construtor para passarmos um número da placa ao instanciarmos o objeto
        public Carro(string numeroPlaca)
        {
            Placa = numeroPlaca;
        }
    }
}
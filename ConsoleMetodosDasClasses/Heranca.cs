using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMetodosDasClasses
{
    // Herança em classes

    class Veiculo
    {
        public string Cor { get; set; }
        public string Marca { get; set; }
        public void Acelerar()
        {
            Console.WriteLine("Acelerou!");
        }

        public void Parar()
        {
            Console.WriteLine("Parou!");
        }
    }

    class Carro : Veiculo
    {
       public void LigarMotor()
        {

        }       
        
    }

    class Bicicleta : Veiculo
    {

    }
}

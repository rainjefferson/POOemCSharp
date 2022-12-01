using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMetodosDasClasses
{
    class SobrecargaMetodos
    {
        // sobrecarga de metodos permite usar o mesmo nome de metodo para diferentes implementações.
        public void Cumprimentar()
        {
            Console.WriteLine("Olá!");
        }

        public void Cumprimentar(string nome)
        {
            Console.WriteLine("Olá " + nome + "!");
        }

        public bool SaoIguais(int value1, int value2)
        {
            return value1 == value2;
        }

        public bool SaoIguais(string value1, string value2)
        {
            return value1 == value2;
        }
    }
}

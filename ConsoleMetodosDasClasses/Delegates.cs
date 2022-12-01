using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMetodosDasClasses
{
    class Delegates
    {
        /*
          
           Tipo de dado criado para armazenar referencias de metodos com mesma estrutura do método, com mesmo retorno
           e  mesma assinatura de parametros.

         */

        public void Somar(int n1, int n2)
        {
            Console.WriteLine("Soma é: " + (n1 + n2));
        }

        public void Subtrair(int n1, int n2)
        {
            Console.WriteLine("Subtação é: " + (n1 - n2));
        }

        public void Multiplicar(int n1, int n2)
        {
            Console.WriteLine("Multiplicação é: " + (n1 * n2));
        }


    }
}

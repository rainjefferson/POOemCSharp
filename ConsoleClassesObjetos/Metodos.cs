using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClassesObjetos
{
    class Metodos
    {
        public void Cumprimentar()
        {
            Console.WriteLine("Olá!");
        }

        // metodos com parametros
        public void Somar(int num1, int num2)
        {
            int resultado = num1 + num2;
            Console.WriteLine("Resultado da soma: " + resultado);
        }
    }
}

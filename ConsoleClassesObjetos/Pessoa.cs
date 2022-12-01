using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClassesObjetos
{
    class Pessoa
    {
        public string nome;
        public string sobrenome;

        // void -> significa que o metodo não tem retorno
        public void Cumprimentar()
        {
            Console.WriteLine("Olá eu so o " + nome);
        }

    }
}

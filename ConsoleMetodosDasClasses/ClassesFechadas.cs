using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMetodosDasClasses
{
    // Funciona de forma contraria ao aobstrato, a classe SEALED ninguem pode herdar
    sealed class ClassesFechadas
    {
        //Essa classe não pode ser herdada por ninguem       
    }

    class Humano
    {
        // Metodos Viruais pode ter uma implementação e pode ser sobescritos por classes descendentes 
        public virtual void Nascer()
        {

        }
    }

    class Pessoa : Humano
    {
        public override void Nascer()
        {
            Console.WriteLine("Nasceu a pessoa.");
        }
    }

    class Homem : Pessoa
    {
        // A partir desse momento, o clausula sealed não permit que o metodo Nascer seja sobrescrito de quem herdar
        public sealed override void Nascer()
        {
            Console.WriteLine("Nasceu a pessoa.");
        }
    }
}

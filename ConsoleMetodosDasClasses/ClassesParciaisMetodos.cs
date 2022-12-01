using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMetodosDasClasses
{
    partial class ClassesParciais
    {
        public void Apresentar()
        {
            Console.WriteLine("Olá, meu nome é " + this.nome);
        }

        public int AnoNascimento()
        {
            return 2022 - this.idade;
        }
    }
}

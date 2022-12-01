using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMetodosDasClasses
{
    class ModificadoresVisibilidade
    {
        // Protected fica visivel para classes que herdam, mas não para objeto instanciado
        protected string Nome { get; set; }
        // Private fica visivel somente para a classe que declarou
        private string Sobrenome { get; set; }
        // Internal fica restrito para o mesma aplicação - assembly/compilação
        internal int Idade { get; set; }
    }

    class ClasseHerdada : ModificadoresVisibilidade
    {
        public void MostraNome()
        {
            Console.WriteLine("Nome é: " + Nome);            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMetodosDasClasses
{
    // Uma classe estática deve ter todos seus membros como estáticos também nas suas declarações
    // Não se pode criar uma instancia de objeto de uma classe estática.
    static class ClasseEstatica
    {
        public static int taxa;

        public static int Adicionar(int valor)
        {
            return valor + taxa;
        }

        public static int Diminuir(int valor)
        {
            return valor - taxa;
        }
    }

}

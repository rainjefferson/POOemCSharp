using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMetodosDasClasses
{
    class MetodoParametrosReferenciaValor
    {
        // passagem de parametros por valor
        public void Multiplicar(int valor1, int valor2)
        {
            Console.WriteLine("Resultado da multiplicação: " + (valor1 * valor2));
        }
        
        // passagem de paramtros por referencia - variavel original passada no parametro é manipulada no metodo
        public void AumentarValor(ref int Valor)
        {
            Valor++;
            Console.WriteLine("Aumentou valor: " + Valor);
        }
    }
}

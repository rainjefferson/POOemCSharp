using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMetodosDasClasses
{
    class Program
    {
        delegate void Operacao(int numero1, int numero2);

        static void Main(string[] args)
        {
            Metodos m = new Metodos();
            m.Cumprimentar();

            MetodoParametrosReferenciaValor m2 = new MetodoParametrosReferenciaValor();
            m2.Multiplicar(2, 6);

            int numero = 100;
            m2.AumentarValor(ref numero);

            MetodosComRetorno montanome = new MetodosComRetorno();

            Console.WriteLine(montanome.NomeCompleto("jEFFERSON", "RAIN"));

            // Testanto delegate
            Delegates d = new Delegates();

            Operacao minhasoperacoes = null;

            // Atribui a referencia do metodo
            minhasoperacoes = d.Somar;

            // executa o metodo somar - pois só tem ele atribuido
            minhasoperacoes(10,27);

            // acumula também o metodo subtrair
            minhasoperacoes += d.Subtrair;
            minhasoperacoes += d.Multiplicar;

            // Executa todos os metodos atribuidos acumulados de uma só vez
            minhasoperacoes(18, 5);

            // remove a referencia do subtrair
            minhasoperacoes -= d.Subtrair;

            minhasoperacoes(20, 4);

            // Testando classe estática
            ClasseEstatica.taxa = 18;
            int ValorImposto = ClasseEstatica.Adicionar(400);

            Console.WriteLine("O Valor do imposto com taxa é: " + ValorImposto);

            Console.ReadKey();
        }
    }
}

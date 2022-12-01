using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClassesObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            MinhaClasse mClasse = new MinhaClasse();
            MinhaClasse mClasse2 = null;

            // a classe está declarada em outro arquivo, mas no mesmo namespace
            OutraClasse outra = new OutraClasse();
            OutraClasse outracopia = outra; // referencia

            Pessoa p1 = new Pessoa();
            p1.nome = "Jefferson";
            p1.sobrenome = "Rain";

            Pessoa p2 = new Pessoa() { nome = "Rafaela", sobrenome = "Rain" };

        }
    }

    class MinhaClasse
    {

    }

}

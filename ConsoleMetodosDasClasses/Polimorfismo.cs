using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMetodosDasClasses
{
    // Conceito de polimorfismo -> Muitas formas
    // è o principio onde duas ou mais classes com herança comum podem invocar
    // metodos de mesma assinatura mas comportamentos diferentes.
    class Forma
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Altura { get; set; }
        public int Largura { get; set; }
        public int Raio { get; set; }

        public virtual void Desenhar()
        {
            // Método que podem ser sobrescritos pelos descendentes
            Console.WriteLine("preparando para desenhar");
        }
        public virtual void Area()
        {

        }
    }

    class Circulo : Forma
    {
        public override void Desenhar()
        {
            base.Desenhar(); // Chamo o metodo ancestral
            Console.WriteLine("desenhando um circulo");
        }
        public override void Area()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMetodosDasClasses
{
    class Construtores
    {
        public string nome;
        public string sobrenome;
        public int peso;

        public Construtores()
        {
            this.nome = "Desconhecido";
            this.sobrenome = "Não informado";
            this.peso = 0;
        }

        public Construtores(string nome, string sobrenome, int peso)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.peso = peso;
        }
    }
}

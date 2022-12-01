using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMetodosDasClasses
{
    class PropriedadesGetSet
    {
        // definições de campos
        private string _nome;
        private string _sobrenome;
        private int _idade;

        // definições de propriedades da classe
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }

        public string SobreNome
        {
            get
            {
                return _sobrenome;
            }
            set
            {
                _sobrenome = value;
            }
        }

        public int Idade
        {
            get
            {
                return _idade;
            }
            set
            {
                _idade = value;
            }
        }

        // Definição de propriedades com get e set abreviado
        public string Cidade { get; set; }

        // Definição de propriedades com valor padrão

        public string Pais { get; } = "Brasil";

        public void Apresentar()
        {
            if (_nome != "")
            {
                Console.WriteLine("Olá " + _nome);
            }
        }
    }
}

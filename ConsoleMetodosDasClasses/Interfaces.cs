using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMetodosDasClasses
{
    // Interface também tem o comportamento igual ao de uma classe abstrata
    class CaixaEletronico : IConta
    {
        string Usuario { get; set; }
        int NumeroConta { get; set; }
        public void Depositar()
        {

        }
        public int ContaCorrente()
        {
            return NumeroConta; 
        }
    }

    interface IConta
    {
        string Usuario { get; set; }
        void Depositar();
        int ContaCorrente();
    }
}

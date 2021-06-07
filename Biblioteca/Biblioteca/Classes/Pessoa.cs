using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Classes
{
    public class Pessoa
    {
        public string CPF { get; } // set is readonly
        public string Name { get; } // set is readonly        
        public int LivrosEmprestados { get; private set; }

        public Pessoa(string CPF, string Name)
        {
            this.CPF = CPF;
            this.Name = Name;
        }        

    }
}

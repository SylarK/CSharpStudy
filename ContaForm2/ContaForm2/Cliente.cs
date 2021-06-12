using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaForm2
{
    public class Cliente
    {

        public string Nome { get; private set; }

        public Cliente() { }

        public Cliente(string nome)
        {
            this.Nome = nome;
        }

    }
}

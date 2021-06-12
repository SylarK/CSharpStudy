using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaForm1.Classes
{
    public class Cliente
    {
        public string Nome { get; }
        public string CPF { get; }

        public Cliente() { }
        public Cliente(string nome, string cpf)
        {
            this.Nome = nome;
            this.CPF = cpf;
        }
    }
}

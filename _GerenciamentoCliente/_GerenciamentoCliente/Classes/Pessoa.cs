using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _GerenciamentoCliente.Classes
{
    public class Pessoa
    {
        public string nome { get; }
        public string sobrenome { get; }
        public string cpf { get; }

        public Pessoa() { }
        public Pessoa(string nome, string sobrenome, string cpf) {

            if(_ValidaCPF.IsCpf(cpf) == false)
            {
                throw new ArgumentException("CPF inválido.", nameof(cpf));
            }

            this.cpf = cpf;
            this.nome = nome;
            this.sobrenome = sobrenome;
        }


    }

}

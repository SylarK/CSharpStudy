using _GerenciamentoCliente.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _GerenciamentoCliente.Classes
{
    class Cliente : Pessoa
    {

        public double saldoAbertura { get; private set; }

        public Cliente() { }
        public Cliente(string nome, string sobrenome, string cpf) 
            : base(nome, sobrenome, cpf) { }

        public void setSaldoAbertura(double saldoAbertura)
        {
            if(saldoAbertura <= 0)
            {
                throw new ValidaSaldoException("O valor do saldo para abertura deve ser maior que zero.");
            }
            
            this.saldoAbertura = saldoAbertura;
        }
    }
}

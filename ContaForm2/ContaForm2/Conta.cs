using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaForm2
{
    class Conta
    {

        public Cliente Cliente { get; }
        public int Numero { get; }
        public double Saldo { get; private set; }

        public Conta() { }

        public Conta(Cliente cliente, int numero, double valorAbertura = 0) {
            this.Cliente = cliente;
            this.Numero = numero;
            this.Saldo = valorAbertura;
        }

        public void Depositar(double valor)
        {
            this.Saldo += valor;
        }

        public void Sacar(double valor)
        {
            this.Saldo -= valor;
        }

    }
}

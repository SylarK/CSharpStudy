using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaForm1.Classes
{
    public class Conta
    {
        public Cliente Cliente { get; }
        public double Saldo { get; private set; }
        public int Numero { get; set; }

        public Conta() { }
        public Conta(Cliente cliente, double saldo, int conta) {
            this.Cliente = cliente;
            this.Saldo = saldo;
            this.Numero = conta;
        }

        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public void Sacar(double valor)
        {
            this.Saldo -= valor;
        }

    }
}

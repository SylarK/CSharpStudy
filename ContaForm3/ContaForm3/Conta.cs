using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaForm3
{
    public class Conta
    {
        public int Agencia { get; }
        public int Numero { get; }
        public double Saldo { get; private set; }
        public Cliente Cliente { get; private set; }

        public Conta() { }

        public Conta(Cliente Cliente) { this.Cliente = Cliente; }

        public Conta(Cliente Cliente, int Agencia, int Numero, double Saldo) 
        { 
            this.Cliente = Cliente;
            this.Agencia = Agencia;
            this.Numero = Numero;
            this.Saldo = Saldo;
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

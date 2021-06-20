using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_ByteBank
{
    public class ContaCorrente
    {
        public Cliente cliente;
        public double saldo;
        public int agencia;

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if(this.saldo > valor)
            {
                this.saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if(this.saldo > valor)
            {
                this.saldo -= valor;
                destino.saldo += valor;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

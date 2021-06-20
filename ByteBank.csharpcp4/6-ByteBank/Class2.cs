using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_ByteBank
{
    public class ContaCorrente
    {
        private Cliente cliente;
        private double _saldo;
        private int _agencia;

        public Cliente Cliente
        {
            get
            {
                return cliente;
            }
            set
            {
                this.cliente = value;
            }
        }

        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if(this._saldo > valor)
            {
                this._saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if(this._saldo > valor)
            {
                this._saldo -= valor;
                destino._saldo += valor;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

// using _05_ByteBank;

using ByteBank.Exceptions;
using System;

namespace ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }

        public static double TaxaOperacao { get; private set; }
        public static int TotalDeContasCriadas { get; private set; }

        public int Agencia { get; } //SET is readonly

        public int Numero { get; } //SET is readonly

        private double _saldo = 100;

        public int TentativaSaqueInvalido { get; private set; }
        public int TentativaTransferenciaInvalida { get; private set; }

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }


        public ContaCorrente(int agencia, int numero)
        {
            
            if (agencia <= 0)
            {
                throw new ArgumentException("O argumento agência deve ser maior que zero.", nameof(agencia));
            }
            if(numero <= 0)
            {
                throw new ArgumentException("O argumento número deve ser maior que zero.", nameof(numero));
            }


            this.Agencia = agencia;
            this.Numero = numero;    

            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;

        }


        public void Sacar(double valor)
        {
            if(valor <= 0)
            {
                throw new ArgumentException("O valor de saque deve ser maior que R$ 0", nameof(valor));
            }

            if (_saldo < valor)
            {
                TentativaSaqueInvalido++;
                throw new ValidaSaldoException(valor, this.Saldo);
            }

            _saldo -= valor;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }


        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor <= 0)
            {
                throw new ArgumentException("O valor de transferência deve ser maior que R$ 0", nameof(valor));
            }
            try
            {
                Sacar(valor);
            }
            catch (ValidaSaldoException e)
            {
                TentativaTransferenciaInvalida++;
                throw new OperacaoFinanceiraException("Operação não finalizada!", e);
            }
            contaDestino.Depositar(valor);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Exceptions
{
    public class ValidaSaldoException : Exception
    {
        public ValidaSaldoException(double valorSaque, double valorSaldo) 
            : this("Erro: Não é possível realizar o saque de R$" + valorSaque + " no saldo de R$" + valorSaldo) { }
        public ValidaSaldoException(string message) : base(message) { }
        public ValidaSaldoException(string message, Exception inner) : base(message, inner) { }
        public ValidaSaldoException() { }
    }
}

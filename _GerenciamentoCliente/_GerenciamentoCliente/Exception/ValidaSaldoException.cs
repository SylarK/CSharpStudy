using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _GerenciamentoCliente.Exception
{
    public class ValidaSaldoException : System.Exception
    {
        public ValidaSaldoException() { }
        public ValidaSaldoException(string message) : base(message) { }
        public ValidaSaldoException(string message, System.Exception inner) 
            : base(message, inner){ }
    }
}

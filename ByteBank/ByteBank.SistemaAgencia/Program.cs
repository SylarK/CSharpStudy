using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(847, 498653);
            Funcionario funcionario = null;
            Console.WriteLine(conta.Numero);

            ContaCorrente conta1 = new ContaCorrente(456, 4567);

            Console.ReadLine();
        }
    }
}

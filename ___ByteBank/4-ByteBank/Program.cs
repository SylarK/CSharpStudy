using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente conta1 = new ContaCorrente();
            ContaCorrente conta2 = new ContaCorrente();


            conta1.Depositar(800);

            conta1.Sacar(88);

            Console.WriteLine(conta1.saldo);

            conta1.Transferir(550, conta2);

            Console.WriteLine(conta2.saldo);

            Console.ReadLine();



        }
    }
}

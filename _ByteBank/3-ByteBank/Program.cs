using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("3-Bytebank");

            ContaCorrente conta1 = new ContaCorrente();
            conta1.nome = "Lucas";
            conta1.numeroConta = 889563;
            conta1.saldo = 10000;
            

            ContaCorrente conta2 = new ContaCorrente();
            conta2.nome = "Marilia";
            conta2.numeroConta = 999563;
            conta2.saldo = 10500;
            conta2.indativo = true;

            if(conta1 == conta2)
            {
                Console.WriteLine("Objetos iguais.");
            }
            else
            {
                Console.WriteLine("Objetos diferentes.");
            }

            Console.WriteLine(conta1.indativo);

            Console.ReadLine();

        }
    }
}

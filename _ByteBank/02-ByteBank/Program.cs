using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            //valor padrão

            ContaCorrente conta1 = new ContaCorrente();

            Console.WriteLine("String padrão : ", conta1.nome);
            Console.WriteLine("Int padrão : ", conta1.agencia);
            Console.WriteLine("Double padrão : ", conta1.saldo);
            Console.WriteLine("Bool padrão : ", conta1.indativo);

            Console.ReadLine();

        }
    }
}

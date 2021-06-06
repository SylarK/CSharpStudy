using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(125, 58889);

                Console.WriteLine(ContaCorrente.TaxaOperacao);
            }
            catch (Exception e)
            {
                Console.WriteLine("Aconteceu um erro!");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            Console.ReadLine();
        }
    }
}

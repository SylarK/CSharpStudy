using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente cliente1 = new Cliente("Lucas", "99999999999", 26, "Desenvolvedor Full Stack");
            ContaCorrente conta1 = new ContaCorrente(cliente1, 89569, 10000);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            Cliente cliente2 = new Cliente("Jonas", "99999999999", 29, "Desenvolvedor Full Stack");
            ContaCorrente conta2 = new ContaCorrente(cliente2, 89569, 10000);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);


            Console.ReadLine();

        }
    }
}

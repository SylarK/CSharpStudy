using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente cliente1 = new Cliente();
            cliente1.Nome = "Lucas Amado";
            cliente1.Idade = 26;
            cliente1.Cpf = "999.999.999-99";
            cliente1.Profssao = "Desenvolvedor Full Stack";

            Console.WriteLine(cliente1.Nome + " " + cliente1.Idade + " anos - " + cliente1.Cpf);

            ContaCorrente conta1 = new ContaCorrente();
            conta1.Cliente = cliente1;

            Console.WriteLine(conta1.Cliente.Profssao);

            Console.ReadLine();
        }
    }
}

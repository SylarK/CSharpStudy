using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente cliente1 = new Cliente();
            cliente1.nome = "Lucas";
            cliente1.idade = 26;
            cliente1.cpf = "999.999.999-99";

            ContaCorrente conta1 = new ContaCorrente();
            conta1.cliente = cliente1;
            conta1.agencia = 999;
            conta1.saldo = 10000;

            ContaCorrente conta2 = new ContaCorrente();
            conta2.saldo = 10;

            conta1.Transferir(2500, conta2);

            Console.WriteLine("Saldo conta 1: " + conta1.saldo);
            Console.WriteLine("Saldo conta 2: " + conta2.saldo);
            Console.ReadLine();


        }
    }
}

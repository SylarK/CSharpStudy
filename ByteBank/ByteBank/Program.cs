using ByteBank.Exceptions;
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
                //ContaCorrente conta = new ContaCorrente(125, 58889);
                //ContaCorrente conta = new ContaCorrente(0, 4567);
                ContaCorrente conta = new ContaCorrente(123, 45569);

                conta.Depositar(1500.00);
                //conta.Sacar(2000.00);
                conta.Sacar(-2000.00);
                Console.WriteLine("Saldo: R$", conta.Saldo);

                Console.WriteLine(ContaCorrente.TaxaOperacao);
            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine("Aconteceu um erro do tipo Operação Financeira");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            catch(ArgumentException e)
            {
                Console.WriteLine("Aconteceu um erro do tipo ArgumentException");
                Console.WriteLine(e.Message);
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

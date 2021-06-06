using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_ByteBank
{
    public class ContaCorrente
    {

        public Cliente Cliente { get; set; }
        public int Agencia { get; set; }
        
        public double Saldo { get; set; }

        public static int TotalDeContasCriadas { get; private set; }

        public ContaCorrente(Cliente cliente, int agencia, double saldo)
        {
            Cliente = cliente;
            Agencia = agencia;
            Saldo = saldo;
            TotalDeContasCriadas++;
        }

        public static int ObterTotalDeContasCriadas()
        {
            return TotalDeContasCriadas;
        }

    }
}

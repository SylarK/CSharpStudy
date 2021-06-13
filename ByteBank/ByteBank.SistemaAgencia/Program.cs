using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //ContaCorrente conta = new ContaCorrente(847, 498653);
            //Funcionario funcionario = null;
            //Console.WriteLine(conta.Numero);

            //ContaCorrente conta1 = new ContaCorrente(456, 4567);

            DateTime dataFimPagamento = new DateTime(2021, 12, 12);
            DateTime dataCorrente = DateTime.Now;
            TimeSpan diferencaEntreDatas = dataFimPagamento - dataCorrente;

            Console.WriteLine(dataCorrente);
            Console.WriteLine(dataFimPagamento);
            Console.WriteLine("Vencimento em : " + TimeSpanHumanizeExtensions.Humanize(diferencaEntreDatas, 1, System.Globalization.CultureInfo.GetCultureInfo("pt-BR")));

            Console.ReadLine();
        }

        //static string GetIntervaloDeTempoLegivel(TimeSpan timeSpan)
        //{
        //    if(timeSpan.Days > 30)
        //    {
        //        int quantidadeMeses = timeSpan.Days / 30;
        //        return quantidadeMeses + " meses";
                    
        //    }
        //    return timeSpan.Days + " dias";
        //}
    }
}

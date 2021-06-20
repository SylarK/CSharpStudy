using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humanizer;
using System.Text.RegularExpressions;

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

            //DateTime dataFimPagamento = new DateTime(2021, 12, 12);
            //DateTime dataCorrente = DateTime.Now;
            //TimeSpan diferencaEntreDatas = dataFimPagamento - dataCorrente;

            //Console.WriteLine(dataCorrente);
            //Console.WriteLine(dataFimPagamento);
            //Console.WriteLine("Vencimento em : " + TimeSpanHumanizeExtensions.Humanize(diferencaEntreDatas, 1, System.Globalization.CultureInfo.GetCultureInfo("pt-BR")));

            //WorkingWithStrings();

            string padrao = "[0-9]{3}.?[0-9]{3}.?[0-9]{3}-?[0-9]{2}";
            string testeVariavel = "O meu cpf possui a seguinte estrutura 95698865355";
            Match guardarCpf = Regex.Match(testeVariavel, padrao);

            Console.WriteLine(guardarCpf);

            Console.ReadLine();
        }

        static void WorkingWithStrings()
        {

            ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL(null);

            string url = "pagina?moedaOrigem=real&moedaDestino=dolar";

            int indiceInterrogacao = url.IndexOf("?");

            string v = url.Substring(indiceInterrogacao + 1);
            Console.WriteLine(url);
            Console.WriteLine(v);
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

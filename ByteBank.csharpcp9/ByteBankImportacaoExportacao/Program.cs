using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao 
{ 
    partial class Program 
    { 
        static void Main(string[] args) 
        {
            //CriarArquivo();
            //CriarArquivoComWriter();
            //TestaEscrita();
            //EscritaBinaria();
            //LeituraBinaria();
            UsarStreamDeEntrada();

            Console.WriteLine("Aplicação finalizada...");
            Console.ReadLine();
        }

        

    }
} 
 
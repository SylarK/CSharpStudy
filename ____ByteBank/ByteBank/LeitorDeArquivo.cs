using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class LeitorDeArquivo : IDisposable
    {
        public string Arquivo { get; private set; }

        public LeitorDeArquivo(string arquivo)
        {
            this.Arquivo = arquivo;
            Console.WriteLine("Lendo arquivo " + arquivo);

            //throw new FileNotFoundException("Arquivo não foi encontrado");
        }

        public void LerProximaLinha()
        {
            Console.WriteLine("Lendo linha...");
            Console.WriteLine("Lendo linha...");
            Console.WriteLine("Lendo linha...");
            //throw new IOException();
        }

        public void Fechar()
        {
            Console.WriteLine("Fechando arquivo.");

        }

        public void Dispose() { Console.WriteLine("Fechando arquivo.");  }
    }
}

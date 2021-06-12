using _GerenciamentoCliente.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _GerenciamentoCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            TestaAplicacao();
            Console.ReadLine();
        }

        public static void TestaAplicacao()
        {
            try
            {
                //Pessoa pessoa = new Pessoa("Lucas", "Amado", "144.242.650-05");
                //Pessoa pessoa = new Pessoa("Lucas", "Amado", "144.242.650-10"); //CPF -> Inválido
                string[] colecao = new string[] { "Lucas", "Marilia", "Noah", "Olivia" };

                for (int i = 0; i < colecao.Length; i++)
                {
                    Console.WriteLine("Position " + i + ": " + colecao[i]);
                }

                Console.WriteLine();

            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            
        }
    }
}

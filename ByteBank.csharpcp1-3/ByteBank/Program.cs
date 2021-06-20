using ByteBank.Funcionarios;
using ByteBank.Sistemas;
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
            //CalcularBonificacao();
            Autenticacao();

            Console.ReadLine();
        }

        public static void Autenticacao()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("159.689.655-33");
            roberta.Name = "Roberta";
            roberta.Senha = "123";

            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(roberta, "abc456");

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123456";

            sistemaInterno.Logar(parceiro, "123456");

        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Auxiliar carlos = new Auxiliar("659.569.988-66");
            gerenciadorBonificacao.Registrar(carlos);
            Console.WriteLine("Bonificação Carlos : " + carlos.GetBonificacao());

            Designer frederico = new Designer("669.569.448-85");
            gerenciadorBonificacao.Registrar(frederico);
            Console.WriteLine("Bonificação Frederico : " + frederico.GetBonificacao());

            Diretor charles = new Diretor("477.512.369-44");
            gerenciadorBonificacao.Registrar(charles);
            Console.WriteLine("Bonificação Charles : " + charles.GetBonificacao());

            

            Console.WriteLine("Total de Bonificações : " + gerenciadorBonificacao.getBonificacao());
        }
    }
}

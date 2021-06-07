using Biblioteca.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            Implementacao();
            Console.ReadLine();
        }

        static void Implementacao()
        {
            /*Cadastro de Pessoas*/
            Pessoa pessoa1 = new Pessoa("456.789.456-99", "Roberta");
            Pessoa pessoa2 = new Pessoa("996.985.556-12", "Carlos");
            Pessoa pessoa3 = new Pessoa("555.695.489-45", "Henrique");

            /*Cadastro de Livros*/
            Livro livro1 = new Livro("Discovery the Winter", 2008);
            Livro livro2 = new Livro("The rainbown cycle", 2011);
            Livro livro3 = new Livro("Roolback in everthing", 2006);

            /*Emprestimos*/
            Emprestimo emprestimo1 = new Emprestimo(pessoa1, livro1, "07/06/2021");
            Emprestimo emprestimo2 = new Emprestimo(pessoa2, livro2, "01/06/2021");
            Emprestimo emprestimo3 = new Emprestimo(pessoa3, livro3, "25/05/2021");
            Emprestimo emprestimo4 = new Emprestimo(pessoa2, livro3, "03/06/2021");

            Console.WriteLine(emprestimo3.situacao);
            //Console.WriteLine(emprestimo1.idEmprestimo);
            Console.WriteLine(Livro.totalLivrosCadastrados);
        }
    }
}

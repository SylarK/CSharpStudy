using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Classes
{
    public class Emprestimo
    {
        public Pessoa pessoa { get; }
        public Livro livro { get;  }
        public string dataEmprestimo { get; private set; }
        public string situacao { get; private set; }
        public int idEmprestimo { get;  }

        public Emprestimo(Pessoa pessoa, Livro livro, string dataEmprestimo)
        {
            if (livro.Disponivel)
            {
                livro.setDisponibilidade();
                this.pessoa = pessoa;
                this.livro = livro;
                this.dataEmprestimo = dataEmprestimo;
                this.situacao = "Aguardando devolução.";
                this.idEmprestimo++;
            }
            else
            {
                Console.WriteLine("O Livro não está disponível para empréstimo no momento.");
            }
            
        }

        public void entregarLivro(string data)
        {
            this.situacao = "Livro entregue no dia " + data;
            livro.setDisponibilidade();
        }

    }
}

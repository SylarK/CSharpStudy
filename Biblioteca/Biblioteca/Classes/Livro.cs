using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Classes
{
    public class Livro
    {
        public string Titulo { get; }
        public int AnoPublicacao { get; }
        public bool Disponivel { get; private set; }

        public static int totalLivrosCadastrados { get; set; }


        public Livro(string Titulo, int anoPublicacao)
        {
            this.Titulo = Titulo;
            this.AnoPublicacao = anoPublicacao;
            this.Disponivel = true;
            totalLivrosCadastrados++;
        }

        public void setDisponibilidade()
        {
            if(this.Disponivel)
            {
                this.Disponivel = false;
            }
            else
            {
                this.Disponivel = true;
            }
        }
        
    }
}

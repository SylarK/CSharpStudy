using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    class Diretor : Funcionario
    {
        public Diretor(string CPF) : base(5000, CPF)
        {
            Console.WriteLine("Criando DIRETOR.");
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }

        public override double GetBonificacao()
        {
            return Salario + (Salario * 0.42);
        }
    }
}

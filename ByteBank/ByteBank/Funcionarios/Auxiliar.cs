using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    class Auxiliar : Funcionario
    {
        public Auxiliar(string CPF) : base(2500, CPF)
        {
            Console.WriteLine("Criando AUXILIAR.");
        }

        public override void AumentarSalario()
        {
            this.Salario *= 0.25;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.3;
        }

    }
}

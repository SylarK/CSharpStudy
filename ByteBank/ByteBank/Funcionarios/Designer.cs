using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    class Designer : Funcionario
    {
        public Designer(string CPF) : base(3600, CPF)
        {
            Console.WriteLine("Criando DESIGNER.");
        }

        public override void AumentarSalario()
        {
            this.Salario *= 0.35;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.42;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalFuncionarios { get; private set; }

        public string Name { get; set; }
        public string CPF { get; set; }
        public double Salario { get; protected set; } 

        public Funcionario(double salario, string CPF)
        {
            Console.WriteLine("Criando FUNCIONARIO.");
            this.CPF = CPF;
            this.Salario = salario;
            TotalFuncionarios++;
        }

        public abstract void AumentarSalario();

        public abstract double GetBonificacao();

/*
        public virtual void AumentarSalario()
        {
            this.Salario *= 1.1;
        }

        public virtual double GetBonificacao()
        {
            return Salario * 0.10;
        }
*/


    }
}

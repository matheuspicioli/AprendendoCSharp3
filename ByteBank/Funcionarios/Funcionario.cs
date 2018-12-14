using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; protected set; }

        public Funcionario(double salario, string cpf)
        {
            this.CPF = cpf;
            this.Salario = salario;
            Console.WriteLine("Criando um FUNCIONARIO");
        }

        public virtual void AumentarSalario()
        {
            // Salario = Salario + (Salario * 0.1);
            // Salario = Salario * 1.1;
            this.Salario *= 1.1;
        }

        public virtual double GetBonificacao()
        {
            return this.Salario * 0.10;
        }
    }
}

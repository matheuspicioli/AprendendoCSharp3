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
            CPF = cpf;
            Salario = salario;
        }

        public abstract void AumentarSalario();
        //{
        // Salario = Salario + (Salario * 0.1);
        // Salario = Salario * 1.1;
        //Salario *= 1.1;
        //}

        public abstract double GetBonificacao();
        //{
            //return Salario * 0.10;
        //}
    }
}

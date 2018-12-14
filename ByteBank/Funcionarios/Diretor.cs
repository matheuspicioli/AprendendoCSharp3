using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    public class Diretor: Funcionario
    {
        // SEMPRE EXECUTA O CONSTRUTOR DA
        // CLASSE BASE PRIMEIRO
        public Diretor(string cpf) : base(5000, cpf)
        {
            Console.WriteLine("Criando um DIRETOR");
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }

        public override double GetBonificacao()
        {
            return this.Salario * 0.5;
        }
    }
}
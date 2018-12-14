using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    public class GerenteDeConta: Funcionario
    {
        public GerenteDeConta(string cpf): base(4000, cpf)
        {

        }

        public override void AumentarSalario()
        {
            this.Salario *= 0.05;
        }

        public override double GetBonificacao()
        {
            return this.Salario * 0.25;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    public class Funcionario
    {
        private int _tipo;
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

        public double GetBonificacao()
        {
            return Salario * 0.10;
        }

        public Funcionario(int tipo)
        {
            this._tipo = tipo;
        }

        public double GetBonificacao(int tipo)
        {
            if (_tipo == 1)
                return this.Salario;

            return this.Salario * 0.10;
        }
    }
}

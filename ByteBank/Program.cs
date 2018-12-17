using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            // CalcularBonificacao();
            UsarSistemaInterno();

            Console.ReadLine();
        }

        public static void UsarSistemaInterno()
        {
            Diretor pedro = new Diretor("565.912.131-32");
            pedro.Nome = "Pedro";
            pedro.Senha = "123";

            ParceiroComercial camila = new ParceiroComercial();
            camila.Senha = "abc";

            // DESIGNER NÃO TEM ACESSO AO SISTEMA INTERNO
            // NOSSO CÓDIGO NÃO PERMITE ISSO
            //Designer designer = new Designer("555.555.555-22");
            //designer.Nome = "Estagiario";
            //designer.Senha = "teste";

            SistemaInterno sistema = new SistemaInterno();
            //sistema.Logar(designer, "teste");
            sistema.Logar(pedro, "123");
            sistema.Logar(camila, "abc");
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Designer roberta = new Designer("404.691.928-22");
            roberta.Nome = "Roberta";

            Diretor pedro = new Diretor("565.912.131-32");
            pedro.Nome = "Pedro";

            Auxiliar igor = new Auxiliar("891.524.923-11");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("999.222.111-22");
            camila.Nome = "Camila";

            gerenciador.Registrar(roberta);
            gerenciador.Registrar(pedro);
            gerenciador.Registrar(igor);
            gerenciador.Registrar(camila);

            Console.WriteLine("Total bonificação: R$" + gerenciador.GetTotalBonificacao());

        }
    }
}

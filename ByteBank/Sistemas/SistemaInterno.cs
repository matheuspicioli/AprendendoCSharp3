using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Sistemas
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionario, string tentativaSenha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(tentativaSenha);

            if(usuarioAutenticado)
            {
                Console.WriteLine("Bem-vindo!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha inválida!");
                return false;
            }
        }
    }
}

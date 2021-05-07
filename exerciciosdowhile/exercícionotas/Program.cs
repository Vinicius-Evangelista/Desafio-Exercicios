using System;

namespace exercícionotas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Por favor coloque um nome de usuário e uma senha. \n");
            Console.Write("Nome de usuário: ");
            string usuario = Console.ReadLine();
            Console.WriteLine("\n Agora faça uma senha. Aviso essa senha não pode ser igual ao seu nome de usuário.");
            Console.Write("Senha: ");
            string senha = Console.ReadLine();
            // aquisição de dados

            // dados devem ser analisado de qualquer forma para que haja uma conclusão;
            bool usuarioSenha = false;

            do
            {
                if (usuario == senha)
                // se o usuario for igual senha
                {
                    Console.WriteLine("\n Erro ! Usuário é igual a sua senha. \n");
                    Console.WriteLine("\n Por favor coloque um nome de usuário e uma senha. \n");
                    Console.Write("Nome de usuário: ");
                    usuario = Console.ReadLine();
                    Console.WriteLine("\n Agora faça uma senha. Aviso essa senha não pode ser igual ao seu nome de usuário.");
                    Console.Write("Senha: ");
                    senha = Console.ReadLine();

                }
                else
                // se estiver certo anule o loop
                {
                    Console.WriteLine("\n Obrigado ! :) \n");
                    usuarioSenha = true;
                }
            } while (usuarioSenha == false);
        }
    }
}

using System;
using Exercício1POO.Classes;


namespace Exercício1POO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Menu que faz como o usuário decida algumas opcões

            Console.WriteLine("\nPara qual finalidade o elevador será usado ?");
            Console.WriteLine("\nDigite:");
            Console.WriteLine(@"
1- Transportar pessoas.
2- Transportar caixas etec...  ");
            string respostaUser = Console.ReadLine();


            // verificação da repostaUser
            if (respostaUser == "1")
            {
                // instância do Elavador social-
                ElevadorSocial es = new ElevadorSocial();
                string AcaoUsuario;
                es.Inicializar();

                do
                {


                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\nVocê está usando o elevador social !");
                    Console.ResetColor();


                    Console.WriteLine("\nControle o fluxo de pessoas e o elevador.\n");

                    Console.WriteLine("O que você deseja ?");

                    Console.WriteLine($@"
1- Adicionar uma pessoa
2- Tirar uma pessoa
3- Subir
4- Descer
5- Encerrar simulação.

   {es.AndarAtual}° Andar
   {es.CapacidadeElevador} qtd.
 ");

                    AcaoUsuario = Console.ReadLine();

                    switch (AcaoUsuario)
                    {
                        case "1":
                            es.Entrar();
                            break;

                        case "2":
                            es.Sair();
                            break;

                        case "3":
                            es.Subir();
                            break;

                        case "4":
                            es.Descer();
                            break;

                        default:
                            break;
                    }



                } while (AcaoUsuario != "5");
            }

            // verificação da resposta
            if (respostaUser == "2")
            {
                Console.WriteLine("Você está usando o elevador de serviço !");

                // instância do ElevadorServico
                ElevadorServico ese = new ElevadorServico();
                ese.Inicializar();
                string AcaoUsuario;


                do
                {
                    // estrutura de repetição para mostrar o menu
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\nVocê está usando o elevador de serviço !");
                    Console.ResetColor();

                    Console.WriteLine("\nControle o fluxo de caixas e o elevador.\n");

                    Console.WriteLine("O que você deseja ?");

                    Console.WriteLine($@"
1- Adicionar uma caixa
2- Tirar uma caixa
3- Subir
4- Descer
5- Encerrar simulação.

   {ese.AndarAtual}° Andar
   {ese.CapacidadeElevador} qtd.


 ");

                    AcaoUsuario = Console.ReadLine();
                    // exibição do menu e resposta do usuario

                    switch (AcaoUsuario)
                    {
                        case "1":
                            ese.ColcocarCaixas();
                            break;

                        case "2":
                            ese.TirarCaixas();
                            break;

                        case "3":
                            ese.Subir();
                            break;

                        case "4":
                            ese.Descer();
                            break;

                        default:
                            break;
                    }
                } while (AcaoUsuario != "5");
                {

                }

            }

        }
    }
}


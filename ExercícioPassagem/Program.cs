using System;

namespace ExercícioPassagem
{
    class Program
    {
        static void Main(string[] args)
        {

            bool validarCadastro = false;


            string[] nomePassagem = new string[5];
            string[] origemPassagem = new string[5];
            string[] destinoPassagem = new string[5];
            string[] dataPassagem = new string[5];
            // variáveis para guardar as informações.

            Console.WriteLine("\nColque a sua senha e o seu usuário para acessar o sistema !");
            Console.Write("Usuário: ");
            string usuario = Console.ReadLine();
            // var armazena usuario
            Console.Write("Senha: ");
            string senha = Console.ReadLine();
            // var armazena senha


            do
            // execução da interface
            {

                if (senha == "123456" && usuario == "usuario123")
                // validação de senha e usuário
                {

                    Console.WriteLine("\nBem-vindo !\n");

                    Console.WriteLine("O que você deseja ?");

                    Console.WriteLine("'1' - Cadastrar passagem");
                    Console.WriteLine("'2' - Listar Passagens");
                    Console.WriteLine("'3' - Sair");
                    Console.Write("\nR: ");
                    int validarOpções = int.Parse(Console.ReadLine());


                    // variáveis para fazer validações e contador
                    bool addPassagem = false;
                    string validarPassagem = "";
                    int c = 0;

                    // switch para exercutar funções ditas pelas usuário
                    switch (validarOpções)
                    {

                        case 1:
                            // fazer cadastro
                            while (addPassagem == false)
                            // estrutura de repetição para ir cadastrando as passagens
                            {
                                Console.WriteLine("Preencha os dados a seguir para fazer o cadastro");
                                Console.Write("Passageiro: ");
                                nomePassagem[c] = Console.ReadLine();
                                Console.Write("Origem: ");
                                origemPassagem[c] = Console.ReadLine();
                                Console.Write("Destino: ");
                                destinoPassagem[c] = Console.ReadLine();
                                Console.Write("Data de voo: ");
                                dataPassagem[c] = Console.ReadLine();
                                c++;

                                Console.WriteLine("Deseja Cadastrar uma nova passagem ?");
                                Console.WriteLine("Responda com 's' para sim e 'n' para não");
                                validarPassagem = Console.ReadLine();
                                // validar se o usuário deseja cadastrar mais passagens

                                if (validarPassagem == "n")
                                // caso a resposta for não a bool validarPassagem vira true;
                                // sai do switch e vai para o menu;
                                {
                                    addPassagem = true;
                                }

                            }
                            break;

                        case 2:

                            for (int i = 0; i < nomePassagem.Length; i++)
                            // listar as passagens 
                            {

                                Console.WriteLine($"Passagem:{nomePassagem[i]}");
                                Console.WriteLine($"Origem:{origemPassagem[i]}");
                                Console.WriteLine($"Destino:{destinoPassagem[i]}");
                                Console.WriteLine($"Data:{dataPassagem[i]}\n");
                            }
                            break;

                        case 3:
                            // encerrar o sistema, vai acabar saindo do "do whiel" que está sobre eles.
                            validarCadastro = true;
                            break;

                        default:
                            break;
                    }
                }
                else
                // caso a senha seja digitada incorretamente
                {
                    Console.WriteLine("Usuario/Senha estam errados digite novamente.");
                    Console.WriteLine("\nColque a sua senha e o seu usuário para acessar o sistema !");
                    Console.Write("Usuário: ");
                    usuario = Console.ReadLine();
                    Console.Write("Senha: ");
                    senha = Console.ReadLine();
                }
            }
            while (validarCadastro == false);
            // execute o algoritmo dentro do 'do' enquanto validar cadastro for false





        }


    }
}


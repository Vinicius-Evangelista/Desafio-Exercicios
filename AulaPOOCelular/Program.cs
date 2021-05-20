using System;

namespace ExercícioCelular
{
    class Program
    {
        static void Main(string[] args)
        {
            celular celular1 = new celular();
            celular1.marca = "Xiaomi";
            celular1.modelo = "Redmi S2";
            celular1.tela = 5.99;
            celular1.cor = "Cinza";
            celular1.memoria = "32GB";
            celular1.ram = "4GB RAM";
            celular1.bateria = "3000 mAh";
            celular1.ligado = false;
            // especificações 


            DateTime data = DateTime.Now;
            string validarAcao = "";
            string respostaOpcoes;
            // variáveis para determinar ações

            Console.WriteLine("\nO celular está desligado !");
            Console.WriteLine("Deseja ligá-lo ?");
            Console.WriteLine("responda com 's' para sim ou 'n' não.");
            validarAcao = Console.ReadLine();

            if (validarAcao == "s")
            {
                celular1.Ligar();
            }
            else
            {
                celular1.Desligar();
            }


            if (celular1.ligado == true)
            {
                do
                {
                    Console.WriteLine("\nBem vindo ! O que deseja ?");

                    respostaOpcoes = Interface();

                    switch (respostaOpcoes)
                    {
                        case "1":
                            Console.WriteLine("Digite o número da pessoa que você deseja ligar");
                            Console.ReadLine();
                            Console.WriteLine("\nDiscando...\n");
                            Console.ForegroundColor= ConsoleColor.DarkRed;
                            Console.WriteLine(celular1.Ligacao());
                            Console.ResetColor();
                            
                            break;

                        case "2":
                            Console.WriteLine("\nQuam irá receber essa mensagem ?");
                            Console.Write("R:");
                            Console.ReadLine();
                            Console.WriteLine("Digita mensagem !");
                            Console.ReadLine();
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("\n" +celular1.Mensagem());
                            Console.ResetColor();

                            break;

                        case "3":
                            Especificacoes(celular1.marca, celular1.modelo, celular1.tela, celular1.cor, celular1.memoria, celular1.ram, celular1.bateria);
                            break;

                        case "4":

                            celular1.Desligar();

                            break;

                        default:
                            break;
                    }

                } while (celular1.ligado == true);

            }
            else
            {

                celular1.ligado = false;

            }



        }

        static string Interface()
        {
            // interface do celular

            Console.WriteLine("'1'Fazer ligação");
            Console.WriteLine("'2'Enviar uma mensagem");
            Console.WriteLine("'3'Especificações\n");
            Console.WriteLine("'4' Desligar\n");
            Console.Write("R:");

            string respostaAcao = Console.ReadLine();
            // validação das ações
            return respostaAcao;
            // retorna o valor das ações

        }

        static void Especificacoes(string valor1, string valor2, double valor3, string valor4, string valor5, string valor6, string valor7)
        {
            Console.WriteLine($"\nMarca: {valor1}");
            Console.WriteLine($"Modelo: {valor2}");
            Console.WriteLine($"Tela: {valor3}");
            Console.WriteLine($"Cor: {valor4}");
            Console.WriteLine($"Armazenamento: {valor5}");
            Console.WriteLine($"RAM: {valor6}");
            Console.WriteLine($"Bateria: {valor7}\n");
        }
    }
}

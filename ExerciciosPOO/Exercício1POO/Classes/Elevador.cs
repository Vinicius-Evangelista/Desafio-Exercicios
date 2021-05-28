using System;

namespace Exercício1POO.Classes
{
     public abstract class Elevador
    {
        public int AndarAtual
        { get; set; }
        // var para saber qual é o andar atual

        private int AndaresPredios;
        // var que guarda quantos andares o prédio possui

        public int EspacoElevador
        {get; set;}
        // var que mostra o espaço do elevador

        public int CapacidadeElevador
        { get; set; }
        // var que mostra a capacidade do elevador


        public void Inicializar()
        {
            //  funcao que inicializa o programa

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("[Configurações prévias]\n");

            Console.WriteLine("Quantos andares o prédio possui ?");
            AndaresPredios = int.Parse(Console.ReadLine());


            Console.WriteLine("\nCapacidade máxima do elevador ?");
            EspacoElevador = int.Parse(Console.ReadLine());
            Console.ResetColor();

        }

        public void Entrar()
        {
            // essa funcao verifica a qualtidade de pessoas ou caixas no elevador e se não estiver na quantidade máxima adiciona 1

            if (CapacidadeElevador == EspacoElevador)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nCapacidade máxima do elevador atingida");
                Console.ResetColor();
            }
            else
            {
                CapacidadeElevador++;
            }
        }

        public void Sair()
        {
            // essa funcao verifica a qualtidade de pessoas ou caixas no elevador e se não estiver na quantidade mínima tira 1
            
            if (CapacidadeElevador == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nNão há ninguém no elevador");
                Console.ResetColor();
            }
            else
            {
                CapacidadeElevador--;
            }
        }

        public void Subir()
        {
            // essa funcao verifica o andar no qual o elevador está e se não estiver no último andar sobe 1 andar

            if (AndarAtual == AndaresPredios)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nO elevador não pode subir porque o andar máximo foi atingido.");
                Console.ResetColor();
            }
            else
            {

                AndarAtual++;
            }
        }


        public void Descer()
        {
            // essa funcao verifica o andar no qual o elevador está e se não estiver no térreo andar desce 1 andar

            if (AndarAtual == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nO elevador não pode descer pois está no térreo.");
                Console.ResetColor();
            }
            else
            {
                AndarAtual--;
            }
        }
    }
}
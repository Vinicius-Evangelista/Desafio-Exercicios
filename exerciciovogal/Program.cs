using System;

namespace exerciciovogal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é o seu nome ?");
            string nome = Console.ReadLine();
            string letra= nome.Substring(0,1).ToLower();

            switch (letra)
            {
                case "a":
                    Console.WriteLine("Seu nome começa com "+ letra + " de Avelã !");
                    break;

                case "e":
                    Console.WriteLine("Seu nome começa com " + letra + " de Êma !");
                    break;

                case "i":
                    Console.WriteLine("Seu nome começa com " + letra + " de Impala !");
                    break;

                case "o":
                    Console.WriteLine("Seu nome começa com " + letra + " de Onça !");
                    break;

                default:
                    Console.WriteLine("Seu nome começa com começa com uma consoante :(");
                    break;
            }
            
        }
    }
}

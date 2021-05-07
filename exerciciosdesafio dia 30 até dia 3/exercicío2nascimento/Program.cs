using System;

namespace exercicío2nascimento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, coloque ano de seu nascimento: ");
            int nascimento = int.Parse(Console.ReadLine());

            int idadeUse = 2021 - nascimento;
            // calculo da idade 

            int idadeWeek = idadeUse * 52;
            // calculo da idade em semanas


            Console.WriteLine("A sua idade é: " + idadeUse+" anos !");
            Console.WriteLine("A sua idade em semanas é " + idadeWeek + " em semanas !");


        }
    }
}

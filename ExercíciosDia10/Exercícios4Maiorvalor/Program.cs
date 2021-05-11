using System;

namespace Exercícios4Maiorvalor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coloque 10 valores.");

            int[] valores = null;
            valores= new int [10];
            // valor da variável será igual a dez assim como está no exercício.

            for (var i = 0; i < 10; i++)
            // cuidado para não colocar igual == 10 se não ele não vai executar (Eu passei 30min para descobrir isso kkkkkkk)
            {
                Console.Write("R: ");
                valores[i] = int.Parse(Console.ReadLine());
            }
            // acho que essa parte tu já entende kkkkkkkk



            Array.Sort(valores);
            int maiorValor = valores.GetUpperBound(0);
            // pegue o maior valor
            int menorValor = valores.GetLowerBound(0);
            // pegue o menor valor


            Console.WriteLine("O maior valor é: " + valores[maiorValor]);
            Console.WriteLine("O menor valor é: " + valores[menorValor]);
        }
    }
}




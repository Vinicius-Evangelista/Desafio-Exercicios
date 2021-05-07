using System;

namespace exercícios2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Por favor coloque a nota do aluno.");
            Console.Write("R: ");
            int nota = int.Parse(Console.ReadLine());

            bool notaCorreta =  false;

            do
            {
                if (nota <= 10)
                {
                    Console.WriteLine("Obrigado pela preferência !");
                    notaCorreta = true;
                }
                else
                {
                    Console.WriteLine("Valor inválido !");
                    Console.WriteLine("Por favor coloque a nota do aluno.");
                    Console.Write("R: ");
                    nota = int.Parse(Console.ReadLine());

                }
            } while (notaCorreta == false);

            }

    }
}
  

using System;

namespace exercicío1_idade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é a sua idade ?");
            int idade = int.Parse(Console.ReadLine());

            int idadeMeses = idade * 12;
            int idadeDias = idade * 365;
            Double idadeHoras = idade * 8.760;
            Double idadeMinutos = idade * 525.600;

            Console.WriteLine("A sua idade em meses é: " + idadeMeses + " meses" + "\n");
            Console.WriteLine("A sua idade em dias é: " + idadeDias + " dias" + "\n");
            Console.WriteLine("A sua idade em horas é: " + idadeHoras + " horas" + "\n");
            Console.WriteLine("A sua idade em minutos é: " + idadeMinutos + " minutos" + "\n");

        }
    }
}

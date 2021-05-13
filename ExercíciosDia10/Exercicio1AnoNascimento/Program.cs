using System;

namespace Exercicio1AnoNascimento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor digite o seu ano de nascimento.");
            
            int anoNascimento = int.Parse(Console.ReadLine());

            DateTime dataAtual= DateTime.Now;

            int anoAtual = dataAtual.Year;

            int validarAno = anoAtual - anoNascimento;
            

            if (validarAno < 16)
            { 
               Console.WriteLine("Desculpe mas você não tem idade suficiente para votar :( !");
            }else{
                    Console.WriteLine("Obrigado ! Vote com consciência !");
            }

            
            


        }
    }
}

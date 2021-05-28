using System;

namespace Exercicio2POO.Classes
{
    public abstract class Jogador
    {
        public string Nome
        { get; set; }

        public int AnoNascimento
        { get; set; }

        public int Idade;

        private string Nacionalidade
        { get; set; }

        private double Altura
        { get; set; }

        private double Peso
        { get; set; }

        public string Posição
        { get; set; }
        private DateTime AnoAtual = DateTime.Now;




        public void ReceberInformações()
        {
            do
            {Console.WriteLine("\nColoque as informações do jogador e você quanto tempo falta para ele se aponsetar.\n");
            Console.Write("\nNome: ");
            Nome = Console.ReadLine();
            Console.Write("Ano de nascimento: ");
            AnoNascimento = int.Parse(Console.ReadLine());
            Console.Write("Nacionalidade: ");
            Nacionalidade = Console.ReadLine();
            Console.Write("Altura: ");
            Altura = double.Parse(Console.ReadLine());
            Console.Write("Peso: ");
            Peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Posição: ");

            Console.WriteLine(@"
1 - Atacante
2 - Defensor
3 - Meio-Campo
                     ");

            Posição = Console.ReadLine();
            }while (Posição != "1" && Posição != "2" && Posição != "3");
        }


        public void CalculoIdade()
        {
            Idade = AnoAtual.Year - AnoNascimento;  
        }



        public virtual void Aposentar()
        {

            if (Idade >= 30)
            {
                Console.WriteLine("O jogador deve se aposentar, pois já atingiu a idade máxima para a sua posição.");

            }
            else
            {

                Console.WriteLine($"Faltam {Idade - 30} anos para o jogador {Nome} se aposentar");
            }

        }

        public void MostrarInformacoes()
        {

            Console.WriteLine($"\nNome: {Nome}");
            Console.WriteLine($"Ano de nascimento: {AnoNascimento}");
            Console.WriteLine($"Nacionalidade: {Nacionalidade}");
            Console.WriteLine($"Altura: {Altura:N2}m");
            Console.WriteLine($"Peso: {Peso}kg");
            Console.WriteLine($"Idade: {Idade}");

        }
    }

}
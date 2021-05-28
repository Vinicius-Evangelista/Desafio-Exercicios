using System;
using Exercicio2POO.Classes;

namespace Exercicio2POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saudações !");

            JogadorAtaque a = new JogadorAtaque();

            JogadorDefesa d = new JogadorDefesa();

            JogadorMeioCampo m = new JogadorMeioCampo();

            a.ReceberInformações();

            switch (a.Posição)
            {
                case "1":
                                        
                 a.CalculoIdade();
                 a.MostrarInformacoes();
                 a.Aposentar();   
                    break;

                case "2":
                d.Nome = a.Nome;
                d.AnoNascimento = a.AnoNascimento;
                d.CalculoIdade();
                a.Idade = d.Idade;
                a.MostrarInformacoes();
                d.Aposentar();

                    break;
                case "3":

                m.Nome = a.Nome;
                m.AnoNascimento = a.AnoNascimento;
                m.CalculoIdade();
                a.Idade = m.Idade;
                a.MostrarInformacoes();
                m.Aposentar();
                    break;
                default:
                    break;
            }
        }
    }
}

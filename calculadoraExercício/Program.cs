using System;

namespace calculadoraExercício
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nQual operação aritimética você deseja utilizar ?\n");
            string resposta = Console.ReadLine().ToLower();

            switch (resposta)
            {
                case "multiplicação":


                    Console.Write("Digite o primeiro número: ");
                    float n1 = float.Parse(Console.ReadLine());

                    Console.Write("Digite o segundo número: ");
                    float n2 = float.Parse(Console.ReadLine());

                    Console.Write("\nResultado: " + Mutiplicacao(n1, n2));


                    break;

                case "divisão":


                    Console.Write("Digite o primeiro número: ");
                    n1 = float.Parse(Console.ReadLine());

                    Console.Write("Digite o segundo número: ");
                    n2 = float.Parse(Console.ReadLine());

                    Console.Write("\nResultado: " + Divisao(n1, n2));


                    break;
                case "soma":

                    Console.Write("Digite o primeiro número: ");
                    n1 = float.Parse(Console.ReadLine());

                    Console.Write("Digite o segundo número: ");
                    n2 = float.Parse(Console.ReadLine());

                    Console.Write("\nResultado: " + Soma(n1, n2));

                    break;

                case "adição":


                    Console.Write("Digite o primeiro número: ");
                    n1 = float.Parse(Console.ReadLine());

                    Console.Write("Digite o segundo número: ");
                    n2 = float.Parse(Console.ReadLine());

                    Console.Write("\nResultado: " + Soma(n1, n2));


                    break;

                case "menos":


                    Console.Write("Digite o primeiro número: ");
                    n1 = float.Parse(Console.ReadLine());

                    Console.Write("Digite o segundo número: ");
                    n2 = float.Parse(Console.ReadLine());


                    Console.Write("\nResultado: " + Menos(n1, n2));


                    break;

                case "subtração":


                    Console.Write("Digite o primeiro número: ");
                    n1 = float.Parse(Console.ReadLine());

                    Console.Write("Digite o segundo número: ");
                    n2 = float.Parse(Console.ReadLine());

                    Console.Write("\nResultado: " + Menos(n1, n2));


                    break;


                default:
                    break;
            }

        }

        static float Mutiplicacao(float numero1, float numero2)
        {
            return (numero1 * numero2);
        }

        static float Divisao(float numero1, float numero2)
        {
            return (numero1 / numero2);
        }

        static float Soma(float numero1, float numero2)
        {
            return (numero1 + numero2);
        }

        static float Menos(float numero1, float numero2)
        {
            return (numero1 - numero2);
        }

    }
}

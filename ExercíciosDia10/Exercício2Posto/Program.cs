using System;

namespace Exercício2Posto
{
    class Program
    {
        private const double V = 4.90;

        static void Main(string[] args)
        {
            Console.WriteLine("\nO que você está levando ?\n");
            Console.WriteLine("Digite 'A' para Alcool e 'G' para gasolina");
            string aG = Console.ReadLine().ToUpper();

            Console.WriteLine("\nQuantos litros você está levando ?\n");
            int litros = int.Parse(Console.ReadLine());

            double preçoAcool = 4.90 * litros;
            double preçoGasolina = 5.30 * litros;

            double descontoAlcool = preçoAcool - alcool20(preçoAcool);
            double descontoAlcool20mais = preçoAcool - alcool20mais(preçoAcool);

            double descontoGasolina = preçoGasolina - gasolina20(preçoGasolina);
            double descontoGasolina20mais = preçoGasolina - gasolina20mais(preçoGasolina);


            switch (aG)
            {
                case "A":



                    if (litros <= 20)
                    {
                        Console.WriteLine("Seu valor com desconto é: " + descontoAlcool);
                    }else{
                        Console.WriteLine("Seu valor com desconto é: " + descontoAlcool20mais);
                    }

                    break;

                case "G":

                    if (litros <= 20)
                    {
                        Console.WriteLine("Seu valor com desconto é: " + descontoGasolina);
                    }else{
                        Console.WriteLine("Seu valor com desconto é: " + descontoGasolina20mais);
                    }

                    break;

                default:
                    break;
            }


        }
        static double alcool20(double valor1, double valor2 = 3, double valor3 = 100)
        {
            return (valor1 * (valor2 / valor3));
        }

        static double alcool20mais(double valor1, double valor2 = 5, double valor3 = 100)
        {
            return (valor1 * (valor2 / valor3));
        }


        static double gasolina20(double valor1, double valor2 = 4, double valor3 = 100)
        {
            return (valor1 * (valor2 / valor3));
        }

        static double gasolina20mais(double valor1, double valor2 = 6, double valor3 = 100)
        {
            return (valor1 * (valor2 / valor3));
        }


    }
}

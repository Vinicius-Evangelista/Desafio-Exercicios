using System;

namespace Exercício3DescProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coloque o nome do produto");
            string nomeProduto = Console.ReadLine().ToLower();
            // pedir nome

            Console.WriteLine($"Quantos {nomeProduto} você está levando ?");
            int quantidadeProduto = int. Parse(Console.ReadLine());
            // pedir quantidade


            Console.WriteLine("Por favor coloque o valor do produto.");
            double valorProduto = double.Parse(Console.ReadLine());
            // pedir valor


            double valorTotal = quantidadeProduto * valorProduto;
            //  calculo do valor da compra


            // variaveis para modificar o número de casas decimais
            double valores1 = valorTotal- desconto1(valorTotal);
            double valores2 = valorTotal- desconto2(valorTotal);
            double valores3 = valorTotal- desconto3(valorTotal);

            
            // condições para fazer o calculo do com base na quantidade de produtos
            if(quantidadeProduto <= 5)
            {
               Console.WriteLine($"Seu valor com desconto é: {valores1.ToString("F")} reais");
    
            }else if (quantidadeProduto <= 10)
            {
                Console.WriteLine($"Seu valor com desconto é: {valores2.ToString("F")} reais");         
            }  
            
            if ( quantidadeProduto > 10)
            {
                 Console.WriteLine($"Seu valor com desconto é: {valores3.ToString("F")} reais");
                 
            }

            

        }

        // funções para fazer o calculo do desconto
        static double desconto1 (double valor1, double valor2 = 2, double valor3 = 100)
        {
            return (valor1 * (valor2/valor3));
        }
        static double desconto2 (double valor1, double valor2 = 3, double valor3 = 100)
        {
            return (valor1 * (valor2/valor3));
        }
        static double desconto3 (double valor1, double valor2 = 5, double valor3 = 100)
        {
            return (valor1 * (valor2/valor3));
        }
    
    }
}

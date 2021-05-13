using System;

namespace DesafioMercado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos produtos você deseja cadastrar ?");

            int[] produtos = null;
            int quantidadesProdutos = int.Parse(Console.ReadLine());
            produtos = new int[quantidadesProdutos];

            // quantidade de produtos = quantidades de indices que essa variavel vai ter

            Console.WriteLine("\nPor favor coloque o nome de cada produto.\n");

            string[] nomes = new string[quantidadesProdutos];

            // a string nome vai nomear cada indice baseado na quantidade de produtos

            for (var i = 0; i < quantidadesProdutos; i++)
            
            //repita essas perguntas igual a quantidades de produtos 

            {
                Console.Write((i + 1) + "º Produto ");
                Console.Write("Nome: ");
                nomes[i] = (Console.ReadLine());

                // nomes[i] o serve para colocar informações nos indices do array. Exemplo: nomes[ indice 0] coloque tal informação lá, nomes[1] coloque tal informação no indice de número 1, então i só vai até a variavel quantidadeProdutos


            }

            Console.WriteLine("Agora coloque a quantidade de cada produto.");


            foreach (var item in nomes)
            // repita esse parte igual a quantidade de itens que tem na variavel nome
            {
                Console.Write(item + ": ");
                // os items são os nomes que estão na variavel nome
                int quantidadeCadaproduto = int.Parse(Console.ReadLine());
                // coloque a quantidade de cada produto e armazene na variavel 
            }
            Console.WriteLine("@      ");
        }
    }
}


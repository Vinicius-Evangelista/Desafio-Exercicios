using System;

namespace paodequeijodesafio
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Quantos pacotes de pão de queijo tem em cada prateleira");

        int [] pacotes = null;
        // valor de indices indefinido
        int quantidadePacotes = int.Parse(Console.ReadLine());
        // usuario define o número de indices
        pacotes = new int [quantidadePacotes];
        // método para aplicar o número de indices que o usuário colocou no array

        Console.WriteLine("\n Agora digite a quantidade de pão de queijo em cada pacote. \n");

        for (var i = 0; i < quantidadePacotes; i++)
        // repita i até que o valor seja menor que os indices colocado pelo usuário, I será acrescentado de um em um;
        {
            
            Console.Write((i+1) + "º pacote: ");
            pacotes[i] = int.Parse(Console.ReadLine());
            // preencha o valor de cada indices
           
        }

        Console.WriteLine(" \n Aqui está a lista com os valores preenchidos \n");

        int t = 1;
        foreach(var item in pacotes)
        // repita essas infomações em ordem crescente igual a quantidade de indices 
        {
            Console.WriteLine((t)+ "º pacote: " + item);
            t++;
        }

        Console.WriteLine("\n Tenha um bom dia ^_^ ! \n");
        }
    }
}

       







           
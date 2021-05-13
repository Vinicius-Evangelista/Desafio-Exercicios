using System;

namespace Exercício6Lernomes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[10];

            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine($"Por favor escreva o {(i+1)}° nome.");
                nomes[i] = Console.ReadLine();
            }

            Console.WriteLine("\nDeseja efetuar a busca de algum um nome ?\n");
            Console.WriteLine("Digite 'sim' ou 'não'");
            string validarBusca = Console.ReadLine();

            bool validação = false;

            foreach(var item in nomes)
            {
                if(validarBusca == item)
                {
                    validação = true;
                }
            }
            
            if(validação)
            {
                Console.WriteLine("Achei");
            }else{

                Console.WriteLine("Não achei");
            }

            
            
            
            
            
            // } while (validarAquisicao == false);


            //  bool validarAquisicao= false;

            // do
            // {
            //     int t = 1;
            //     if (validarBusca =="sim")
            //     {
            //         Console.WriteLine("\nDigite o nome que você deseja procurar\n");
            //         Console.Write("R: ");
            //         Console.ReadLine();
                    

                    
            //         foreach (var item in nomes)
            //         {
            //             Console.WriteLine($"{t}° nome: {item}");
            //             t++;
            //         }

            //         Console.WriteLine("\nConseguiu achar o que você estava procurando ?\n");
            //         Console.WriteLine("\nResponde com 'achei' ou 'não achei'\n");
            //         string confirmacao = Console.ReadLine();

            //         if(confirmacao == "achei"){
            //             Console.WriteLine("Obrigado");
            //             validarAquisicao = true;
            //         }

            //     }else{
            //          Console.WriteLine("Obrigado ! :)");
            //          validarAquisicao = true;
            //     }

                   

               

           


        }
    }
}


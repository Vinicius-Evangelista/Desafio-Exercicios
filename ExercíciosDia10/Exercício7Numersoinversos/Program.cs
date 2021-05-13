using System;

namespace Exercício7Numersoinversos
{
    class Program
    {
        static void Main(string[] args)
        {

            int [] arrayNumeros = new int [15];
            int [] arrayInverso = arrayNumeros;
    
            Console.WriteLine("Digite 15 números");

            for (var i = 0; i < 15; i++)
            {
                Console.WriteLine($"{(i+1)}° número: ");
                Console.Write("R: ");
                arrayNumeros[i]= int.Parse(Console.ReadLine());
            }
            

            Console.WriteLine("==========================");

            int t = 0;
            foreach (var item in arrayNumeros)
            {
                
                Console.WriteLine($"{(t+1)}° número: {item}");

                t++;
            }

            Console.ForegroundColor= ConsoleColor.DarkBlue;
            Console.WriteLine("\n===========================\n");
            Console.WriteLine("\ninvertidokkkkkkkk\n");

            // Array.Reverse(arrayInverso);

            // int w = 0;
            // foreach(var item in arrayNumeros)
            // {
            //      Console.WriteLine($"{(w+1)}° número: {item}");

            //     w ++;
            // }


            
            

            
            

            for(var i = (arrayNumeros.Length-1) ; i>= 0 ; i--)
            {
                
                Console.WriteLine($"{arrayNumeros[i]}");

            
            }


            
        }

        // static int arrayInvertida (int [] valor1)
        // {
        //    return Array.Reverse(valor1);
        // }
    }
}

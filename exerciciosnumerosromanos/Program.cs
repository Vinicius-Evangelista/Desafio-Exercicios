using System;

namespace exerciciosnumerosromanos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor preencha o espaço com um numero com um algarismo romano !");
            string algarismoRomanos = Console.ReadLine().ToUpper();

            switch (algarismoRomanos)
            {
                case "I":
                     Console.WriteLine("R: = 1");
                    break;
                
                case "II":
                    Console.WriteLine("R: = 2");
                    break;
                
                case "III":
                    Console.WriteLine("R: = 3");
                    break;
                
                case "IV":
                     Console.WriteLine("R: = 4");
                    break;
                
                case "V":
                     Console.WriteLine("R: = 5");
                    break;
                
                case "VI":
                     Console.WriteLine("R: = 6");
                    break;
                
                case "VII":
                     Console.WriteLine("R: = 7");
                    break;
                
                case "VIII":
                    Console.WriteLine("R: = 8");
                    break;
                
                case "IX":
                     Console.WriteLine("R: = 9");
                    break;
                
                case "X":
                     Console.WriteLine("R: = 10");
                    break;
               
                default:
                    Console.WriteLine("Por favor escreva um algarismo romano."+ "\n");
                    Console.WriteLine("Exemplo: I, II, III, IV, V, VI, VII, VIII, IX, X." + "\n");
                    break;
            }
            
        }
    }
}

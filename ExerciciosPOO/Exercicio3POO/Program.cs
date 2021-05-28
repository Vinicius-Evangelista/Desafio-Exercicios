using System;
using Exercicio3POO.Classes;

namespace Exercicio3POO
{
    class Program
    {
        static void Main(string[] args)
        {

            bool sairSistema = true;
         
            MaquinaCafe n = new MaquinaCafe();

            do
            {Console.WriteLine("\nBem - vindo !\n");

            Console.WriteLine($"Quantidade de açúcar disponível: {n.acucarDisponivel}g");
            
            Console.WriteLine("\nDeseja colocar açúcar no seu café ?");
            Console.WriteLine(@"
1 - Sim 
2 - Não
3 - Sair
            ");
            Console.Write("R:");
            n.validacaoAcucar = Console.ReadLine();
            

            switch (n.validacaoAcucar)
            {
                case "1":
                    n.fazerCafe(n.respostaInt);
                    break;
                
                case "2":
                    n.fazerCafe();
                    break;
                
                case "3":
                    sairSistema = false;
                    break;

                default:
                    break;
            }
            }while (sairSistema == true);

            
            
            
            
        }
    }
}

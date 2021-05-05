using System;

namespace desafio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é a idade do nadador ?");
            int idadeNadador = int.Parse(Console.ReadLine());

            if (idadeNadador > 17)
            {
                Console.WriteLine("O nadador pertence ao grupo: Sênior");
                // mostrar ao grupo sênior
            }

            if (idadeNadador >= 5 && idadeNadador <= 7)
            {
                Console.WriteLine("O nadador pertence ao grupo: Infantil A");
                // mostrar ao grupo infantil A
            }
            if (idadeNadador >= 8 && idadeNadador <= 10)
            {
                Console.WriteLine("O nadador pertence ao grupo: Infantil B");
                // mostrar ao grupo infantil B
            }

            if (idadeNadador >= 11 && idadeNadador <= 13)
            {
                Console.WriteLine("O nadador pertence ao grupo: Juvenil A");
                // mostrar ao grupo juvenil A
            }


            if (idadeNadador >= 14 && idadeNadador <= 17)
            {
                Console.WriteLine("O nadador pertence ao grupo: Juvenil B");
                // mostrar ao grupo Juvenil B
            }

            if(idadeNadador < 5)
            {
                Console.WriteLine("O nadador não pode participar, pois não se encaixa na idade mínima exigida."+ "\n");
                // mostrar que não tem a idade mínima
            }

            string idadeConsulta="";


            do
            {
              Console.WriteLine("Você quer refazer a consulta ?");
              Console.WriteLine("Responda com sim ou não.");
              idadeConsulta= Console.ReadLine().ToLower();


            } while (idadeConsulta == "sim");
            
               Console.WriteLine("Qual é a idade do nadador ?");
                 idadeNadador = int.Parse(Console.ReadLine());

            if (idadeNadador > 17)
            {
                Console.WriteLine("O nadador pertence ao grupo: Sênior");
                // mostrar ao grupo sênior
            }

            if (idadeNadador >= 5 && idadeNadador <= 7)
            {
                Console.WriteLine("O nadador pertence ao grupo: Infantil A");
                // mostrar ao grupo infantil A
            }
            if (idadeNadador >= 8 && idadeNadador <= 10)
            {
                Console.WriteLine("O nadador pertence ao grupo: Infantil B");
                // mostrar ao grupo infantil B
            }

            if (idadeNadador >= 11 && idadeNadador <= 13)
            {
                Console.WriteLine("O nadador pertence ao grupo: Juvenil A");
                // mostrar ao grupo juvenil A
            }


            if (idadeNadador >= 14 && idadeNadador <= 17)
            {
                Console.WriteLine("O nadador pertence ao grupo: Juvenil B");
                // mostrar ao grupo Juvenil B
            }

            if(idadeNadador < 5)
            {
                Console.WriteLine("O nadador não pode participar, pois não se encaixa na idade mínima exigida."+ "\n");
                // mostrar que não tem a idade mínima
            }

            }









        }
    }
}

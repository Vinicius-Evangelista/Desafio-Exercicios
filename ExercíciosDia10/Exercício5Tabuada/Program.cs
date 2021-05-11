using System;

namespace Exercício5Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {

            

            int numero = 0;
            // contador fora do for para mudar depois de um ciclo

            for (var i = 0; i <= 10; i++)
            // tabuada até o 10
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"Tabuada do {i}");
                // formatação para deixar bunitinho kkkkklk

                for (var t = 0; t <= 10; t++)
                {
                    int multiplicacao = numero *t;
                    // só a operação mesmo kkkkk
                    Console.WriteLine ($"{numero} x {t} = {multiplicacao}");
                    // a varivel numero,  (aquela que está lá em cima esta) está aqui pq elá vai ser o número que tem que ficar fixo;
                    
                    // a variável 't' serve para ser o numero que vai subindo de um em um;

                    // e mais um pouco contenação para ilustrar
                }

                numero++;
                // aqui que está a jogada, o numero fixo que eu preciso só vai mudar quando o ciclo do for (esse que tem a variavel 't') terminar
                
                // ai vai somar de um em um só quando o for executado 

                Console.WriteLine("==============================");
                // kkkkk só para não deixar bagunçado
            }
        }
    }
}

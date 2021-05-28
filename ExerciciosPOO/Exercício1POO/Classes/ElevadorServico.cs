using System;
namespace Exercício1POO.Classes
{
    public class ElevadorServico : Elevador
    {

        public void TirarCaixas()
        {

            // essa funcao verifica a qualtidade de pessoas ou caixas no elevador e se não estiver na quantidade mínima tira 1

            if (CapacidadeElevador == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nNão há nenhuma caixa a ser tirada !");
                Console.ResetColor();
            }
            else
            {
                CapacidadeElevador--;
            }
        }


        public void ColcocarCaixas(){
            
            // essa funcao verifica a qualtidade de pessoas ou caixas no elevador e se não estiver na quantidade máxima adiciona 1
            

            if (CapacidadeElevador > EspacoElevador)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nLimite máximo atingido !");
                Console.ResetColor();
            }else{

                CapacidadeElevador++;
            }
        }
    }
}
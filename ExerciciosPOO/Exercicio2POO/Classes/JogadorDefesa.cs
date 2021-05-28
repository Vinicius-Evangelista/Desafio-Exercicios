using System;

namespace Exercicio2POO.Classes
{
    public class JogadorDefesa : Jogador
    {
        
        public override void Aposentar()
        {

            if (Idade >= 40)
            {
                Console.WriteLine("O jogador deve se aposentar, pois já atingiu a idade máxima de um defensor.");

            }else if (Idade < 17){
                
                Console.WriteLine("O jogador não a idade mínima exigida para jogar futebol.");
            }
            else
            {
                Console.WriteLine($"Faltam {40 - this.Idade} anos para o jogador {Nome} se aposentar !");
            }

        }
    }
}
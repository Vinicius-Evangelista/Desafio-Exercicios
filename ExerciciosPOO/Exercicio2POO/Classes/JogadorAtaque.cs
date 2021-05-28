using System;

namespace Exercicio2POO.Classes
{
    public class JogadorAtaque : Jogador
    {
        public override void Aposentar()
        {

            if (Idade >= 35)
            {
                Console.WriteLine("O jogador deve se aposentar, pois já atingiu a idade máxima de um atacante.");

            }else if (Idade < 17){
                
                Console.WriteLine("O jogador não a idade mínima exigida para jogar futebol.");
            }
           else
             {

                Console.WriteLine($"Faltam {(35 - this.Idade)} anos para o jogador {this.Nome} se aposentar");
            }

        }

    }
}
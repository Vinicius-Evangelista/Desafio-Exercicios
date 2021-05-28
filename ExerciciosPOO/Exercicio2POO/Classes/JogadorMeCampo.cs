using System;

namespace Exercicio2POO.Classes
{
    public class JogadorMeioCampo : Jogador
    {
        public override void Aposentar()
        {

            if (Idade >= 38)
            {
                Console.WriteLine("O jogador deve se aposentar, pois já atingiu a idade máxima de um Meio-Campo.");

            }else if (Idade < 17){
                
                Console.WriteLine("O jogador não a idade mínima exigida para jogar futebol.");
            }
            else
            {

                Console.WriteLine($"Faltam { 38 - this.Idade} anos para o jogador {this.Nome} se aposentar");
            }

        }
    }
}
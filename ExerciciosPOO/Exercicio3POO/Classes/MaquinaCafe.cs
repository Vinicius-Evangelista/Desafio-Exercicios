using System;

namespace Exercicio3POO.Classes
{
    public class MaquinaCafe
    {
        public int acucarDisponivel = 10;
        public string respostaUsuario;

        public string validacaoAcucar;

        public int respostaInt;





        public void fazerCafe(int respostaInt)
        {

            Console.WriteLine("Por favor digite a quantidade de açúcar que você deseja colcocar.");
            respostaUsuario = Console.ReadLine();


            if (respostaUsuario == "")
            {
                Console.WriteLine("Como não foi informado a quatidade de café exigida o seu café está pronto, porém sem açúcar.");
            
            } 
            else if (respostaUsuario != ""){

            respostaInt = int.Parse(respostaUsuario);
            acucarDisponivel = acucarDisponivel - respostaInt;

            Console.WriteLine("Pronto, o seu café está adocado do jeito que você gosta !");

            }if (respostaInt > 0)
            {
                Console.WriteLine("A quantidade de açúcar exigida não está disponível.");
                Console.WriteLine("Então o seu café sairá sem açúcar, pedimos perdão pela falta de recursos ! ;)");
            }

        }


        public void fazerCafe(){

            Console.WriteLine("Pronto o seu café está pronto para o consumo, mas sem açúcar como foi exigido.");

        }


    }
}
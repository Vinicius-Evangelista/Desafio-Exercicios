using System;

namespace exercício3empresa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é o seu salário ?");
            float salario = float.Parse(Console.ReadLine());

            Double porcentagem = salario * 0.3;
            Double aumento = salario + porcentagem;

            if (salario < 500)
            {
                Console.WriteLine("Parabéns você recebeu um aumento ! O seu salário atual é: " + aumento.ToString("C"));
                //mostrar o salário mais o aumento 
            }
            else
            {
                Console.WriteLine("Que pena, você não pode receber um aumento :(");
                // mostrar mensagem de invalidez
            }

        }

    }
}

using System;

namespace exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor preencha as seguintes informações.");

            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            

            bool validarNome = false;

            while (validarNome == false)
            {
                if (nome == "")
                {
                    Console.WriteLine("Você não preencheu está informação.");
                    Console.WriteLine("Por favor preencha as seguintes informações.");

                    Console.WriteLine("Nome: ");
                    nome = Console.ReadLine();
                }
                else
                {
                    validarNome = true;
                }

            }

            Console.WriteLine("Idade: ");
            int idade = int.Parse(Console.ReadLine());

            bool validarIdade = false;

            while (validarIdade == false)
            {
                if (idade <=0 && idade >= 150)
                {
                    Console.WriteLine("\n Por favor uma idade de 0 a 150. \n");
                    Console.WriteLine("Idade: ");
                    idade = int.Parse(Console.ReadLine());
                }
                else
                {
                    validarIdade = true;
                }

               
            }

            Console.WriteLine("Salário ");
            float salario = float.Parse(Console.ReadLine());

            bool validarSalario = false;

            while (validarSalario == false)
            {
                if (salario == 0 )
                {
                    Console.WriteLine("Erro ! Coloque um valor maior do que zero");
                    Console.WriteLine("Salário ");
                    salario = float.Parse(Console.ReadLine());
                }
                else
                {
                    validarSalario = true;
                }
            }

            Console.WriteLine("Estado Civil");

            Console.Write("Digite: ");

            Console.WriteLine("'s' para Solteiro(a)");
            Console.WriteLine("'c' para Casado(a)");
            Console.WriteLine("'v' para Viúvo(a)");
            Console.WriteLine("'d' para Divorciado(a)");
            string estadoCivivl = Console.ReadLine().ToLower();

            bool validarEstadocivil = false;

            while (validarEstadocivil == false)
            {
                if (estadoCivivl != "s" && estadoCivivl != "c" && estadoCivivl != "v" && estadoCivivl !="d")
                {
                    Console.WriteLine("Prencha com uma das letras");
                    Console.WriteLine("Estado Civil");

                    Console.Write("Digite :");

                    Console.WriteLine("'s' para Solteiro(a)");
                    Console.WriteLine("'c' para Casado(a)");
                    Console.WriteLine("'v' para Viúvo(a)");
                    Console.WriteLine("'d' para Divorciado(a)");
                    estadoCivivl = Console.ReadLine().ToLower();
                }
                else
                {
                    validarEstadocivil = true;
                }
            }
        }
    }
}

using System;

namespace exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor preencha as seguintes informações.");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();


            bool validarNome = false;
            // validacão de dados

            while (validarNome == false)
            {
                if (nome == "")
                // validação de dados incorreta
                {
                    Console.WriteLine("Você não preencheu está informação.");
                    Console.WriteLine("Por favor preencha as seguintes informações.");

                    Console.Write("Nome: ");
                    nome = Console.ReadLine();
                }
                else
                // validação de dados correta
                {
                    validarNome = true;
                }

            }

            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());

            bool validarIdade = false;
            // validacão de dados

            while (validarIdade == false)
            {
                if (idade <= 0 && idade >= 150)
                // validação de dados incorreta
                {
                    Console.WriteLine("\n Por favor uma  idade de 0 a 150. \n");
                    Console.Write("Idade: ");
                    idade = int.Parse(Console.ReadLine());
                }
                else
                // validação de dados correta
                {
                    validarIdade = true;
                }


            }

            Console.Write("Salário: ");
            float salario = float.Parse(Console.ReadLine());

            bool validarSalario = false;
            // validacão de dados


            while (validarSalario == false)
            {
                if (salario == 0)
                // validação de dados incorreta

                {
                    Console.WriteLine("Erro ! Coloque um valor maior do que zero");
                    Console.Write("Salário: ");
                    salario = float.Parse(Console.ReadLine());
                }
                else
                // validação de dados correta

                {
                    validarSalario = true;
                }
            }

            Console.WriteLine("Estado Civil");

            Console.WriteLine("Digite: ");

            Console.WriteLine("'s' para Solteiro(a)");
            Console.WriteLine("'c' para Casado(a)");
            Console.WriteLine("'v' para Viúvo(a)");
            Console.WriteLine("'d' para Divorciado(a)");
            string estadoCivivl = Console.ReadLine().ToLower();

            bool validarEstadocivil = false;
            // validação de dados


            while (validarEstadocivil == false)
            {
                if (estadoCivivl != "s" && estadoCivivl != "c" && estadoCivivl != "v" && estadoCivivl != "d")
                // validação de dados incorreta
                {
                    Console.WriteLine("Prencha com uma das letras:");
                    Console.WriteLine("Estado Civil");

                    Console.WriteLine("Digite :");

                    Console.WriteLine("'s' para Solteiro(a)");
                    Console.WriteLine("'c' para Casado(a)");
                    Console.WriteLine("'v' para Viúvo(a)");
                    Console.WriteLine("'d' para Divorciado(a)");
                    estadoCivivl = Console.ReadLine().ToLower();
                }
                else
                // validação de dados correta

                {
                    validarEstadocivil = true;
                }
            }



            Console.WriteLine("\n Os dados estão corretos ? \n");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade + "anos");
            Console.WriteLine("Salario: " + salario.ToString("C"));

            switch (estadoCivivl)
            {
                case "s":
                    // tomada de decisão após tal acão
                    string solteiro = "Solteiro(a)";
                    Console.WriteLine("Estado civil: " + solteiro);
                    break;
                case "c":
                    // tomada de decisão após tal acão
                    string casado = "Casado(a)";
                    Console.WriteLine("Estado civil: " + casado);
                    break;
                case "v":
                    // tomada de decisão após tal acão
                    string viuvo = "Viúvo(a)";
                    Console.WriteLine("Estado civil: " + viuvo);
                    break;
                case "d":
                    // tomada de decisão após tal acão
                    string divorciado = "Divorciado(a)";
                    Console.WriteLine("Estado civil: " + divorciado);
                    break;
                default:
                    break;
            }

            Console.WriteLine("\n Obrigado ! :) \n");

        }
    }
}


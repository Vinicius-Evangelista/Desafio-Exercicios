using System;

namespace ExercícioSistemadeProdutos
{
    class Program
    {

        static string[] nomeProdutos = new string[3];
        // array para guardar o nome dos produtos
        string[] armazenaNomes = new string[3];
        // array que passa o que está array de cima para essa
        static float[] precoProdutos = new float[3];
        // armazena o preço dos produtos
        static string menuProduto;
        // guarda a resposta do menu
        static int contador = 0;
        // catador que passa as informações para cada index
        static bool addProdutos;
        // bool para adicionar mais produtos até o limite máximo

        static string definirPromocao;
        // variavel que vai dizer se está em promoção ou não. 

        static bool promocoes;
        // bool que avalia que vai mudar para true ou false 

        static string validaProdutos;
        // variavel que avalia se o usuario vai querer mais produtos ou não.


        static void Main(string[] args)
        {

            bool validarAcoes = false;
            // validar acao para tirar do loop

            string menuResposta;
            // tomar decisão perante a resposta do usuário  


            do
            {

                menuResposta = MostrarMenu(menuProduto);
                // avalia resposta do usuario e guarda a resposta de função

                switch (menuResposta)
                {
                    case "1":

                        string armazenaNomes = NomesProdutos(validaProdutos);
                        // esssa variavel armazena os nomes da que vão retornar da função. (a variavel que está dentro da função serve para ser a variavel que vai armazenar )

                        Console.WriteLine("\nAgora coloque o preço de cada produto.\n");
                        PrecoProduto();



                        break;

                    case "2":

                        ListarProdutos();
                        // exibi os nomes e os preços

                        break;
                    case "3":

                        validarAcoes = true;
                        // sai do loop 
                        break;

                    default:

                        menuResposta = MostrarMenu(menuProduto);
                        // caso resposta seja diferente de 1,2,3 volta para o menu
                        break;
                }
            } while (validarAcoes == false);


        }


        static string NomesProdutos(string valor1)
        {
            int i = 0;

            while (addProdutos == false)
            {
                Console.Write($"{i + 1}° Produtos: ");
                nomeProdutos[i] = Console.ReadLine();

                Console.WriteLine("\nDeseja adicionar mais um produto ?\n");
                Console.WriteLine("responda com 'sim' ou não 'não'");
                valor1 = Console.ReadLine();
                i++;


                if (valor1 == "não" )
                {
                    addProdutos = true;
                }
                if (i == 3)
                {
                    Console.WriteLine("Você atingiu o número máximo de produtos");
                    addProdutos = true;
                }
 
            }

            return nomeProdutos[contador];
        }

        static float[] PrecoProduto()
        {
            for (var i = 0; i < nomeProdutos.Length; i++)
            {
                Console.Write($"{nomeProdutos[i]}: R$");
                precoProdutos[i] = float.Parse(Console.ReadLine());
            }

            return precoProdutos;
            // retorna o valor dos preços    
        }

        static void ListarProdutos()
        {

            int i = 0;
            if(precoProdutos[i] > 20)
            {
               definirPromocao= "ESTÁ EM PROMOÇÃO";     
            }else{
                definirPromocao = "NÃO ESTA EM PROMOÇÃO";
            }

            foreach (var item in nomeProdutos)
            {
                Console.WriteLine($"{nomeProdutos[i]}: R${precoProdutos[i]} |{definirPromocao}");
                i++;
            }

            // lista o nome e o preço
        }

        static string MostrarMenu(string valor1)
        {
            Console.WriteLine("\nO que você deseja ?\n");
            Console.WriteLine("'1' Cadastrar produto");
            Console.WriteLine("'2' Listar produtos");
            Console.WriteLine("'3' sair");
            Console.Write("\nR:");
            menuProduto = Console.ReadLine();

            // exibi opções e retorna a resposta para a tomada de decisão.

            return menuProduto;
        }
    }

}

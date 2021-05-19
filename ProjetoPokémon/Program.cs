using System;

namespace ProjetoPokémon
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon pokemon1 = new Pokemon();
            pokemon1.nome = "Chamander";
            pokemon1.type = "fogo";
            pokemon1.atk = 12;
            pokemon1.hp = 39;

            // novo pokemon

            Pokemon pokemon2 = new Pokemon();
            pokemon2.nome = "Squirtle";
            pokemon2.type = "água";
            pokemon2.atk = 14;
            pokemon2.hp = 44;

            // novo pokemon

            Pokemon pokemon3 = new Pokemon();
            pokemon3.nome = "Bulbasaur";
            pokemon3.type = "grama/veneno";
            pokemon3.atk = 15;
            pokemon3.hp = 45;

            bool duelo = false;
            // var que vai acabar com duelo
            string escolhaPokemon;
            // var que vai receber o pokemon
            

            Menu();
            // função que vai mostrar o menu
            escolhaPokemon = Console.ReadLine();
            // o usuario vai escolhar os pokemons

            switch (escolhaPokemon)
            {
                case "1":

                    Console.WriteLine("Parabéns seu novo pokemon é o Charmander !");
                    escolhaPokemon = "Charmander";

                    // mensagens que vão aparecer caso o usuário escolha uns dos pokemons
                    
                    break;
                case "2":
                    Console.WriteLine("Parabéns seu novo pokemon é o Squirtle");
                    escolhaPokemon = "Squirtle";
                    break;

                case "3":
                    Console.WriteLine("Parabéns seu novo pokémon é o Bulbasaur");
                    escolhaPokemon = "Bulbasaur";
                    break;

                default:
                    Menu();
                    escolhaPokemon = Console.ReadLine();
                    break;
            }

            Console.WriteLine("\nOh não !\n");

            Console.WriteLine("\nSquirtle apareceu !\n");

            Console.WriteLine("...");
            // diálogo clássico kkkkk
            do
            // loop que só vai acabar o duelo caso um dos pokemons fiquem com o hp menor ou igual a zero
            {




                Menuatk(escolhaPokemon);
                // menu que vai mostrar as opções de atk
                string respostaCombate = Console.ReadLine();

                Console.WriteLine("\nSimule o IA");

                Console.WriteLine($@"
1- Atacar 
2- Esquivar            
            ");

                string respostaCombataia = Console.ReadLine();
                // por enquanto o usuario tem que simular o ia (por enquanto...)


                if (respostaCombate == "1" && respostaCombataia == "1")
                // os if's e os else if adiane é sobre a ação requerida pelo usuário
                {
                    Console.Write(pokemon1.nome);
                    Console.WriteLine(pokemon1.Atacar());
                    // aparecer a mensagem que vai exibir a ação do pokémon

                    pokemon2.hp = pokemon2.hp - pokemon1.atk;
                    // calculo das variáveis conforme a ação dos dos pokemons

                    Console.WriteLine($"HP Charmander: {pokemon1.hp}");
                    Console.WriteLine($"HP Squirtle: {pokemon2.hp}");
                    // exibição do hp dos pokémons

                    Console.Write(pokemon2.nome);
                    Console.WriteLine(pokemon2.Atacar());

                   pokemon1.hp = pokemon1.hp - pokemon2.atk;
                    // calculo do hp do segundo pokémon    
                    
                    Console.WriteLine($"HP Charmander: {pokemon1.hp}");
                    Console.WriteLine($"HP Squirtle: {pokemon2.hp}");

                }else if (respostaCombate == "1" && respostaCombataia == "2"){
                    Console.WriteLine(pokemon1.nome);
                    Console.WriteLine(pokemon1.Atacar());
                    
                    Console.WriteLine(pokemon2.nome);
                    Console.WriteLine(pokemon2.Esquivar());

                    pokemon2.hp = pokemon2.hp - (pokemon1.atk-6);
                    // se o pokémon esquivar podemos diminuir 

                    Console.WriteLine($"HP Charmander: {pokemon1.hp}");
                    Console.WriteLine($"HP Squirtle: {pokemon2.hp}");
                
                }else if (respostaCombate == "2" && respostaCombataia == "1"){

                    Console.WriteLine(pokemon1.nome);
                    Console.WriteLine(pokemon1.Esquivar());

                    Console.WriteLine(pokemon2.nome);
                    Console.WriteLine(pokemon2.Atacar());

                    pokemon1.hp = pokemon1.hp-(pokemon2.atk - 6);

                    Console.WriteLine($"HP Charmander: {pokemon1.hp}");
                    Console.WriteLine($"HP Squirtle: {pokemon2.hp}");
                    
                } else if (respostaCombate == "2" && respostaCombataia == "2"){
                    
                    Console.WriteLine(pokemon1.nome);
                    Console.WriteLine(pokemon1.Esquivar());

                    Console.WriteLine(pokemon2.nome);
                    Console.WriteLine(pokemon2.Esquivar());

                    Console.WriteLine($"HP Charmander: {pokemon1.hp}");
                    Console.WriteLine($"HP Squirtle: {pokemon2.hp}");
                }
                

                if(pokemon1.hp <=0 ){

                    duelo = true;
                    Console.WriteLine($"{escolhaPokemon} Perdeu :( !");
                    // caso o hp segue a zero, loop vai acabar mudando para true e o duelo vai acabar 
                } else if(pokemon2.hp <= 0){

                    Console.WriteLine($"{escolhaPokemon} Venceu :) !");
                }



            } while (duelo == false);
            // bool duelo que vai manter o duelo até que o hp de uns dos pokemons chegue a zero 

        }

        //Funções para "diminuir o código"

        static void Menu()
        {
            Console.WriteLine("\nEscolha o seu pokemon inicial !\n");

            Console.WriteLine($@"
================
|1 - Charmander|
|              |
|2 - Squirtle  |
|              |
|3 - Bulbasaur |
================                
                ");
            Console.Write("\nR:");
        }

        static void Menuatk(string escolhaPokemon)
        {

            Console.WriteLine($"\nVamos nessa {escolhaPokemon} !");

            Console.WriteLine($@"
1- Atacar 
2- Esquivar            
            ");
        }
    }
}

using System;

namespace JocDePreguntes
{
    class Program
    {
        static void Main(string[] args)
        {
            int eleccio;

            mostrarMenu();
            Console.WriteLine("Tria el tema : ");
            eleccio = Convert.ToInt32(Console.ReadLine());

            while (eleccio != 0)
            {
                if (eleccio == 1) menuPokemon();
                
                Console.WriteLine("Pots triar un altre tema. En cas de voler sortir polsa 0");
                eleccio = Convert.ToInt32(Console.ReadLine());

            }

        }
        static void mostrarMenu()
        {
            Console.WriteLine("Tema 1: Pokemon");
            Console.WriteLine("Tema 2: Operacions");
            Console.WriteLine("Tema 3: Smite");

        }
        static void menuPokemon()
        {
            char resposta;
            int comptador = 0;
            Console.WriteLine("Tema de Pokemon! Endivina quina es la resposta correcta de les 5 preguntes seguents. \n");
            
            Console.WriteLine("Pregunta 1: Quants pokemons hi ha a la primera generació?");
            Console.WriteLine(" A) 151 \n B) 435 \n C) 34 \n D) 1 \n");
            Console.Write("La teva resposta és: ");
            resposta = Convert.ToChar(Console.ReadLine());
            if (resposta == 'A' || resposta == 'a') { Console.WriteLine("Correcte! \n"); comptador++; }
            else Console.WriteLine("Incorrecte :( \n");

            Console.WriteLine("Pregunta 2: Quins son els pokemons inicials de la primera generació");
            Console.WriteLine(" A) Charmander, Pikachu, Ditto \n B) Charmander, Bulbasur, Squirtle \n C) Lucario, Mew, Pichu \n D) Mewtwo, Mewthree, Mewfour \n");
            Console.Write("La teva resposta és: ");
            resposta = Convert.ToChar(Console.ReadLine());
            if (resposta == 'B' || resposta == 'b') { Console.WriteLine("Correcte! \n"); comptador++; }
            else Console.WriteLine("Incorrecte :( \n");

            Console.WriteLine("Pregunta 3: Quants Pokemons Fosil podiem encontrar en la primera generació?");
            Console.WriteLine(" A) 5 \n B) Cap \n C) 3 \n D) 1 \n");
            Console.Write("La teva resposta és: ");
            resposta = Convert.ToChar(Console.ReadLine());
            if (resposta == 'A' || resposta == 'a') { Console.WriteLine("Correcte! \n"); comptador++; }
            else Console.WriteLine("Incorrecte :( \n");

            Console.WriteLine("Pregunta 4: Quin d'aquests pokemons es considerat un Pokemon legendari?");
            Console.WriteLine(" A) Pikachu \n B) Torterra \n C) Lucario \n D) Mew \n");
            Console.Write("La teva resposta és: ");
            resposta = Convert.ToChar(Console.ReadLine());
            if (resposta == 'D' || resposta == 'd') { Console.WriteLine("Correcte! \n"); comptador++; }
            else Console.WriteLine("Incorrecte :( \n");

            Console.WriteLine("Pregunta 5: Com es diu el nom del protagonista de Pokemon?");
            Console.WriteLine(" A) Luffy \n B) Naruto \n C) Ash \n D) Tinkywinky \n");
            Console.Write("La teva resposta és: ");
            resposta = Convert.ToChar(Console.ReadLine());
            if (resposta == 'C' || resposta == 'c') { Console.WriteLine("Correcte! \n"); comptador++; }
            else Console.WriteLine("Incorrecte :( \n");

            Console.WriteLine("El teu resultat és de {0} / 5 ",comptador);




        }
    }
}

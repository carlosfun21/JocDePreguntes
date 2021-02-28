using System;

namespace JocDePreguntes
{
    class Program
    {
        static void Main(string[] args)
        {
            int eleccio;

            mostrarMenu();
            Console.WriteLine("Per triar el tema s'ha de escriure el numero assignat a cada tema.\nTria el tema : ");
            eleccio = Convert.ToInt32(Console.ReadLine());

            while (eleccio != 0)
            {
                if (eleccio == 1) temaPokemon();
                if (eleccio == 2) temaOperacions();
                if (eleccio == 3) temaSmite();


                Console.WriteLine("Pots triar un altre tema. En cas de voler sortir polsa 0 \n");
                mostrarMenu();
                Console.Write("Triar tema :");  eleccio = Convert.ToInt32(Console.ReadLine());


            }

        }
        public static void mostrarMenu()
        {
            Console.WriteLine("Tema 1: Pokemon");
            Console.WriteLine("Tema 2: Operacions");
            Console.WriteLine("Tema 3: Smite");

        }
        
        public static void temaPokemon()
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

        public static void temaOperacions()
        {
            char resposta;
            int comptador = 0;
            Console.WriteLine("Tema d'Operacions! Endivina quina es la resposta correcta de les 5 preguntes seguents. \n");

            Console.WriteLine("Pregunta 1: Quant és 1+1 ?");
            Console.WriteLine(" A) 2 \n B) 1 \n C) 0 \n D) 11 \n");
            Console.Write("La teva resposta és: ");
            resposta = Convert.ToChar(Console.ReadLine());
            if (resposta == 'A' || resposta == 'a') { Console.WriteLine("Correcte! \n"); comptador++; }
            else Console.WriteLine("Incorrecte :( \n");

            Console.WriteLine("Pregunta 2: Quant és 453634-1 ?");
            Console.WriteLine(" A) 435643 \n B) 453633 \n C) 453654 \n D) 345635 \n");
            Console.Write("La teva resposta és: ");
            resposta = Convert.ToChar(Console.ReadLine());
            if (resposta == 'B' || resposta == 'b') { Console.WriteLine("Correcte! \n"); comptador++; }
            else Console.WriteLine("Incorrecte :( \n");

            Console.WriteLine("Pregunta 3: Quant és 34 x 2 ?");
            Console.WriteLine(" A) 68 \n B) 0 \n C) 16 \n D) 342 \n");
            Console.Write("La teva resposta és: ");
            resposta = Convert.ToChar(Console.ReadLine());
            if (resposta == 'A' || resposta == 'a') { Console.WriteLine("Correcte! \n"); comptador++; }
            else Console.WriteLine("Incorrecte :( \n");

            Console.WriteLine("Pregunta 4: Quant és 100 / 1");
            Console.WriteLine(" A) 50 \n B) 10 \n C) 1 \n D) 100 \n");
            Console.Write("La teva resposta és: ");
            resposta = Convert.ToChar(Console.ReadLine());
            if (resposta == 'D' || resposta == 'd') { Console.WriteLine("Correcte! \n"); comptador++; }
            else Console.WriteLine("Incorrecte :( \n");

            Console.WriteLine("Pregunta 5: Quant és 3 + (3 x 3) ?");
            Console.WriteLine(" A) 18 \n B) 6 \n C) 12 \n D) 3 \n");
            Console.Write("La teva resposta és: ");
            resposta = Convert.ToChar(Console.ReadLine());
            if (resposta == 'C' || resposta == 'c') { Console.WriteLine("Correcte! \n"); comptador++; }
            else Console.WriteLine("Incorrecte :( \n");

            Console.WriteLine("El teu resultat és de {0} / 5 ", comptador);
        }

        public static void temaSmite()
        {
            char resposta;
            int comptador = 0;
            Console.WriteLine("Tema de Smite! Endivina quina es la resposta correcta de les 5 preguntes seguents. \n");

            Console.WriteLine("Pregunta 1: Quants personatges jugables hi ha actualment en Smite?");
            Console.WriteLine(" A) 100 \n B) 90 \n C) 56 \n D) 112 \n");
            Console.Write("La teva resposta és: ");
            resposta = Convert.ToChar(Console.ReadLine());
            if (resposta == 'D' || resposta == 'd') { Console.WriteLine("Correcte! \n"); comptador++; }
            else Console.WriteLine("Incorrecte :( \n");

            Console.WriteLine("Pregunta 2: Quin d'aquests personatges es de tipus cazador");
            Console.WriteLine(" A) Ymir \n B) Cupid \n C) Sobek \n D) Ra \n");
            Console.Write("La teva resposta és: ");
            resposta = Convert.ToChar(Console.ReadLine());
            if (resposta == 'B' || resposta == 'b') { Console.WriteLine("Correcte! \n"); comptador++; }
            else Console.WriteLine("Incorrecte :( \n");

            Console.WriteLine("Pregunta 3: Quin es el personatge més gran? (altura) ");
            Console.WriteLine(" A) Chuthulu \n B) Ymir \n C) Jorgurmandr \n D) Ratatoskr \n");
            Console.Write("La teva resposta és: ");
            resposta = Convert.ToChar(Console.ReadLine());
            if (resposta == 'A' || resposta == 'a') { Console.WriteLine("Correcte! \n"); comptador++; }
            else Console.WriteLine("Incorrecte :( \n");

            Console.WriteLine("Pregunta 4: Quants modes de joc hi ha actualment a Smite?");
            Console.WriteLine(" A) 8 \n B) 4 \n C) 5 \n D) 9 \n");
            Console.Write("La teva resposta és: ");
            resposta = Convert.ToChar(Console.ReadLine());
            if (resposta == 'D' || resposta == 'd') { Console.WriteLine("Correcte! \n"); comptador++; }
            else Console.WriteLine("Incorrecte :( \n");

            Console.WriteLine("Pregunta 5: Quin es el maxim de jugadors que pot tenir una partida?");
            Console.WriteLine(" A) 2 \n B) 20 \n C) 10 \n D) 5 \n");
            Console.Write("La teva resposta és: ");
            resposta = Convert.ToChar(Console.ReadLine());
            if (resposta == 'C' || resposta == 'c') { Console.WriteLine("Correcte! \n"); comptador++; }
            else Console.WriteLine("Incorrecte :( \n");

            Console.WriteLine("El teu resultat és de {0} / 5 ", comptador);
        }
    }
}

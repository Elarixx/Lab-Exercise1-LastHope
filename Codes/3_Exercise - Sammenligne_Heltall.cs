using System; // Brukes for Console

namespace LastHope;
    internal static class Exercise3
    {
        // Kjør øvelse 3: sammenligne to heltall
        public static void Run()
        {
            // Deklarer to heltallsvariabler
            int tall_1 = 77;
            int tall_2 = 24;

            //-----------------------------------------------------------\\

            // Bruker if-else betingelser for å sammenligne tallene og skrive ut riktig melding

            // Hvis tall_1 er større enn tall_2, skriv ut at tall_1 er større.
            if (tall_1 > tall_2) 
            {
                Console.WriteLine($"{tall_1} er større enn {tall_2}");
            }

            // Hvis tall_1 er mindre enn tall_2, skriv ut at tall_1 er mindre.
            else if (tall_1 < tall_2)
            {
                Console.WriteLine($"{tall_1} er mindre enn {tall_2}");
            }

            // Hvis ingen av "if" eller "else if", tallen er like.
            else
            {
                Console.WriteLine($"{tall_1} og {tall_2} er like");
            }
        }
    }

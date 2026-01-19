using System; // Brukes for Console

namespace LastHope;
    internal static class Exercise3
    {
        // Kjør øvelse 3: sammenligne to heltall
        public static void Run()
        {
            // Deklarer to heltallsvariabler
            int tall1 = 77;
            int tall2 = 24;

            //-----------------------------------------------------------\\

            // Bruker if-else betingelser for å sammenligne tallene og skrive ut riktig melding

            if (tall1 > tall2)    // Hvis tall_1 er større enn tall_2, skriv ut at tall_1 er større.
                {
                  Console.WriteLine($"{tall1} er større enn {tall2}");
                }            
            else if (tall1 < tall2)   // Hvis tall_1 er mindre enn tall_2, skriv ut at tall_1 er mindre.
                {
                  Console.WriteLine($"{tall1} er mindre enn {tall2}");
                }
            else  // Hvis ingen av "if" eller "else if", tallen er like.
                {
                  Console.WriteLine($"{tall1} og {tall2} er like");
                }
        }
    }

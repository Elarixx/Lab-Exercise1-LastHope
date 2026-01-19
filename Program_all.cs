using System;
using System.Text;

namespace LastHope
{
    internal class Program
    {
        // Program entry point: kaller hver øvelse for å demonstrere temaene én etter én.
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8; // Sikrer at Unicode-tegn (f.eks. punktlister) vises riktig i konsollen

            WriteSeparator();                 // ---------------------- (over Solution)
            WriteTitle("Solution: LastHope"); // Fet tittel med ==== understrek
            Console.WriteLine();              // lite mellomrom mellom ==== og ---
            WriteSeparator();                 // ----------------------
            WaitForNext("Øvelse 1", addLeadingBlank: false); // Ikke ekstra blank linje (kun én mellom --- og ~~~)
            WriteSeparator();                 // --- før første øvelse

            WriteHeading("Øvelse 1 – Variabler og aritmetikk");
            One.Run();                        // Kjører øvelse 1
            WaitForNext("Øvelse 2");          // Ekstra luft før ~~~ via default false? (her er det én blank linje fra separatoren)
            WriteSeparator();                 // Skiller øvelse 1 fra neste

            WriteHeading("Øvelse 2 – Betingelser (if/else) med intervaller");
            Exercise2.Run();                  // Kjører øvelse 2
            WaitForNext("Øvelse 3", addLeadingBlank: true); // Ett mellomrom (blank linje) mellom kode og ~~~
            WriteSeparator();                 // Skiller øvelse 2 fra neste

            WriteHeading("Øvelse 3 – Sammenligne to heltall");
            Exercise3.Run();                  // Kjører øvelse 3
            WaitForNext("Øvelse 4", addLeadingBlank: true); // Ett mellomrom (blank linje) mellom kode og ~~~
            WriteSeparator();                 // Skiller øvelse 3 fra neste

            WriteHeading("Øvelse 4 – Klasse: Person");
            Exercise4.Run();                  // Kjører øvelse 4
            WaitForNext("avslutning");        // Standard
            WriteSeparator();                 // Avsluttende skillelinje

            Console.WriteLine("Trykk en tast for å avslutte...");
            Console.ReadKey();
        }



        //-----------------------------------------------------------
        // S T Y L E
        //-----------------------------------------------------------   


        // Skriver tittel for løsningen; bruker ANSI-escape-koder (\u001b) for fet skrift og legger på en tydelig understrek.
        // ANSI-escape-koder er standard kontrollsekvenser for terminalformattering (farger, fet tekst, etc.) støttet i moderne konsoller.
        private static void WriteTitle(string title)
        {
            const string boldOn = "\u001b[1m";  // ANSI-kode som slår på fet skrift
            const string boldOff = "\u001b[0m"; // ANSI-kode som nullstiller tekstformat

            Console.WriteLine($"{boldOn}{title}{boldOff}");
            Console.WriteLine(new string('=', Math.Max(title.Length, 30))); // "større" tittel via understrek
        }

        // Skriver overskrift i fet skrift (ANSI) og legger til en blank linje etter
        private static void WriteHeading(string title)
        {
            const string boldOn = "\u001b[1m";  // Slår på fet skrift
            const string boldOff = "\u001b[0m"; // Slår av (resetter) fet skrift
            Console.WriteLine($"{boldOn}{title}{boldOff}");
            Console.WriteLine(); // blank linje
        }

        // Skriver separator; ingen blank linje før, én etter
        private static void WriteSeparator()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine(); // blank linje etter separator
        }

        // Ber bruker trykke en tast før neste øvelse vises; valgfri ekstra luft før markøren
        private static void WaitForNext(string nextLabel, bool addLeadingBlank = false)
        {
            if (addLeadingBlank)
            {
                Console.WriteLine(); // ekstra luft før markøren
            }
            Console.WriteLine("~~~");                    // liten markørlinje
            Console.WriteLine($"Trykk en tast for å vise {nextLabel}...");
            Console.ReadKey(intercept: true);            // Leser ett tastetrykk uten ekko
            Console.WriteLine();                         // blank linje etter tastepress
        }
    }
}
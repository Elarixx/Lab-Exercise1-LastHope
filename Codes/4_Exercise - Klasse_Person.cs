using System;

namespace LastHope
{
    // Kjør øvelse 4: opprett en Person og skriv ut data
    internal static class Exercise4
    {
        public static void Run()
        {
            // Lager en ny Person-instans og fyller feltene under
            var person = new Person
            {
                ID = 77,
                Name = "Saylor Sinclair",
                BirthDate = new DateTime(2004, 07, 07),
                Address = "Alpha sector 7, 7777 Pandora Moon"
            };

            person.PrintInfo(); // Skriv ut all info for personen
        }
    }

    // Enkel modell for en person med utskriftsmetode
    internal class Person
    {
        public int ID { get; set; }                    // Unik identifikator
        public string Name { get; set; } = string.Empty; // Personens navn
        public DateTime BirthDate { get; set; }        // Fødselsdato
        public string Address { get; set; } = string.Empty; // Adresse

        // Skriver personinformasjon til konsollen
        public void PrintInfo()
        {
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Navn: {Name}");
            Console.WriteLine($"Fødselsdato: {BirthDate:yyyy-MM-dd}");
            Console.WriteLine($"Adresse: {Address}");
            Console.WriteLine();
        }
    }
}

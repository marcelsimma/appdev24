using System;

namespace FlorianBaier.Week04
{

    public class Datentabelle
    {

        public static void Start()
        {
            string[] firstName = { "Alfonso", "Beatrix-Eleonor", "Cecil", "Daniel", "Elmar" };
            string[] lastName = { "Klein", "Kinderdorfer", "Al Elmenar", "Schmidt", "Simma" };
            int[] age = { 40, 78, 5, 18, 81 };
            string[] city = { "Wien", "Schwarzach", "Wiener Neudorf", "Sankt Pölten", "Sankt Pölten" };
            float[] distanceFromCapital = { 0f, 654.4f, 12.457634366f, 120.0f, 119.9999f };

            Console.WriteLine("| Vorname           | Nachname          | Alter | Ort               | Entfernung von der Hauptstadt (km)  |");
            Console.WriteLine("|-------------------|-------------------|-------|-------------------|-------------------------------------|");

            for (int i = 0; i < firstName.Length; i++)
            {
                Console.WriteLine($"| {firstName[i].PadRight(17)} | {lastName[i].PadRight(17)} | {age[i].ToString().PadLeft(5)} | {city[i].PadRight(17)} | {distanceFromCapital[i].ToString("F2").PadLeft(35)} |");
            }
        }
    }
}

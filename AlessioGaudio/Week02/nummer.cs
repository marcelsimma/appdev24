using System;
using System.Data;

using System.Text.RegularExpressions;
using AlessioGaudio.Week02;

namespace AlessioGaudio.Week04
{
    public class Regexx
    {
        public static void Start()

        // /43 [0-9]{3} [0-9]{3} [0-9]{4}/g Alle anderen Bundesstaaten
        // /43 [0-9]{1} [0-9]{3} [0-9]{4}/g Wiener nummer

        {
            string input = (@"In Graz erreichen Sie uns unter +43 316 123 4567. Bei weiteren Fragen können Sie ebenfalls +43 316 123 4568 oder +43 316 123 4569 anrufen.Der Support für Salzburg ist unter +43 662 876 5432 erreichbar. Unsere Hotline-Nummern dort sind +43 662 876 5433 und +43 662 876 5434.Falls Sie aus Linz anrufen, verwenden Sie bitte +43 732 543 2109 oder die alternative Nummer +43 732 543 2110.In Innsbruck ist das Büro unter +43 512 987 6543 und der Hotline +43 512 987 6544 erreichbar. ");

            string regexx = @"(\+43)( ?\d{1,3})( ?\d{3})( ?\d{4})";

            Regex rx = new Regex(regexx);

            foreach (Match match in Regex.Matches(input, regexx))
            {
                Console.WriteLine($"Die Nummer {match} ist richtig.");
            }

            // if ( richtig  == true)

            // {
            //     Console.WriteLine($"folgende nummern sind richtig: {rx.Match(input).Value}");
            // }

            // else

            // {
            //     Console.WriteLine("keine nummer Gefunden");
            // }

        }

    }
}
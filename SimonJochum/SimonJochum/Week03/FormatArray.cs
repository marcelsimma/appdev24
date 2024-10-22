using System;

namespace SimonJochum.Week03
{
    public class FormatArray
    {
        public static void Start()
        {
            String[] header = {"Vorname", "Nachname", "Alter", "Wohnort", "Entfernung"};
            String[] firstName = { "Alfonso", "Beatrix-Eleonor", "Cecil", "Daniel", "Elmar" };
            String[] lastName = { "Klein", "Kinderdorfer", "Al Elmenar", "Schmidt", "Simma" };
            int[] age = { 40, 78, 5, 18, 81 };
            String[] place = { "Wien", "Schwarzach", "Wiener Neudorf", "Sankt Pölten", "Sankt Pölten" };
            float[] distanceFromCapital = { 0f, 654.4f, 12.457634366f, 120.0f, 119.9999f };

            Console.WriteLine(string.Format("{0,-15} | {1,-12} | {2,5:N0} | {3,-14} | {4,8:N2}",
               header[0], header[1], header[2], header[3], header[4]) + "\n" + "---------------------------------------------------------------------");
            Console.WriteLine(string.Format("{0,-15} | {1,-12} | {2,5:N0} | {3,-14} | {4,8:N2}",
               firstName[0], lastName[0], age[0], place[0], distanceFromCapital[0]) + "\n" + "---------------------------------------------------------------------");
            Console.WriteLine(string.Format("{0,-15} | {1,-12} | {2,5:N0} | {3,-14} | {4,8:N2}",
               firstName[1], lastName[1], age[1], place[1], distanceFromCapital[1]) + "\n" + "---------------------------------------------------------------------");
            Console.WriteLine(string.Format("{0,-15} | {1,-12} | {2,5:N0} | {3,-14} | {4,8:N2}",
               firstName[2], lastName[2], age[2], place[2], distanceFromCapital[2]) + "\n" + "---------------------------------------------------------------------");
            Console.WriteLine(string.Format("{0,-15} | {1,-12} | {2,5:N0} | {3,-14} | {4,8:N2}",
               firstName[3], lastName[3], age[3], place[3], distanceFromCapital[3]) + "\n" + "---------------------------------------------------------------------");
            Console.WriteLine(string.Format("{0,-15} | {1,-12} | {2,5:N0} | {3,-14} | {4,8:N2}",
               firstName[4], lastName[4], age[4], place[4], distanceFromCapital[4]) + "\n" + "---------------------------------------------------------------------");
        }
    }       //string.Format {0 für den ersten Eintrag im Array, -/+ links/rechtsbündig, :nach dem Doppelpunkt Formatierung für Zahlen mit N}
}
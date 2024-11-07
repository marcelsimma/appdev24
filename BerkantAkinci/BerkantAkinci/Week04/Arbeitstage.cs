using System;
using System.ComponentModel;
using System.Security.Cryptography;

namespace BerkantAkinci.Week04
{

    class Arbeitstage
    {
        public static void Start()
        {

            PrintArbeitstage(2024, 10);
        }

        public static void PrintArbeitstage(int year, int month)
        {
            DateTime monat = new DateTime(year, month, 1);
            DateTime start = new DateTime(year, month, 1);
            DateTime ende = start.AddMonths(1);

            TimeSpan days = ende - start;

            int count = 0;
            for (int i = 0; i < days.Days; i++)
            {
                if ((int)start.DayOfWeek >= 1 && (int)start.DayOfWeek <= 5)
                {
                    count++;
                }
                start = start.AddDays(1);
            }

            System.Console.WriteLine("Ausgabe: ");
            System.Console.WriteLine($"Der Monat {monat.ToString("MMMM")} hat {count} Arbeitstage!");
        }
    }
}

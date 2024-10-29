using System;
using System.Diagnostics.Metrics;

namespace CheyenneHarbarth.Week04
{

    class Workdays
    {


        public static void Start()
        {
            GetWorkdays(2024, 10);

        }
        public static void GetWorkdays(int year, int month)
        {
            DateTime start = new DateTime(year, month, 1);              // 2024.10.01
            DateTime Monat = new DateTime(year, month, 1);
            DateTime end = start.AddMonths(1);                          // 2024.11.01

            TimeSpan days = end - start;

            int counter = 0;

            for (int i = 0; i < days.Days; i++)
            {
                if ((int)start.DayOfWeek >= 1 && (int)start.DayOfWeek <= 5)     //Jeder Wochentag hat einen Integer, z.B. Sonntag = 0, Dienstag = 2, Samstag = 6
                {
                    counter++;                                                  //bei Erfolg steigt der Counter für die Arbeitstage
                }
                start = start.AddDays(1);                                       //nach jeder Iteration soll ein Tag dazu gezählt werden
            }

            Console.WriteLine($"Der {Monat.ToString("MMMM")} {year} hat {counter} Arbeitstage");
        }
    }
}
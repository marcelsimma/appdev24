using System;
using System.Globalization;

namespace SimonJochum.Week04
{
    public class DisplayCalendar
    {
        public static void Start(int year, int month)
        {
            DateTime start = new DateTime(year, month, 1);
            DateTime actual = DateTime.Now;
            string[,] calendar = new string[6, 7]; // Maximale Anzahl an Wochen in einem Monat

            Console.WriteLine($"{start.ToString("MMMM")} {year}\n |  Mo |  Di |  Mi |  Do |  Fr |  Sa |  So |");

            // Starttag und Endtag des Monats
            int daysInMonth = DateTime.DaysInMonth(year, month);
            int dayCount = 1;

            // Fülle den Kalender
            for (int i = 0; i < calendar.GetLength(0); i++)
            {
                bool hasDays = false; // für das Vorhandensein von Tagen in der Zeile

                for (int j = 0; j < calendar.GetLength(1); j++)
                {
                    if (i == 0 && j < (int)start.DayOfWeek - 1) // Leere Felder für die Tage vor dem ersten Tag
                    {
                        calendar[i, j] = "  ";
                    }
                    else if (dayCount <= daysInMonth)
                    {
                        // Setze den Tag und prüfe, ob es der aktuelle Tag ist
                        string actualDay = dayCount.ToString();
                        if (actual.Year == year && actual.Month == month && actual.Day == dayCount)
                        {
                            actualDay = "*" + actualDay; // Sternchen für den heutigen Tag
                        }
                        calendar[i, j] = actualDay;
                        dayCount++;
                        hasDays = true; // Zeile enthält einen Tag
                    }
                    else
                    {
                        calendar[i, j] = "  "; // Leere Felder nach dem letzten Tag des Monats
                    }
                }


                if (i < 5 || hasDays) // Gebe die letzte Zeile nur aus, wenn sie Tage enthält
                {
                    Console.Write($" | {calendar[i, 0],3} | {calendar[i, 1],3} | {calendar[i, 2],3} | {calendar[i, 3],3} | {calendar[i, 4],3} | {calendar[i, 5],3} | {calendar[i, 6],3} |");
                    Console.WriteLine();
                }
            }
        }

        public static void Start2WithCalendarWeeks(int year, int month)
        {
            DateTime start = new DateTime(year, month, 1);
            DateTime actual = DateTime.Now;
            string[,] calendar = new string[6, 8]; // Kalender mit 6 Reihen und 8 Spalten (KW und 7 Wochentagen)

            Console.WriteLine($"{start.ToString("MMMM")} {year}\n |  KW |  Mo |  Di |  Mi |  Do |  Fr |  Sa |  So |");

            int daysInMonth = DateTime.DaysInMonth(year, month);
            int dayCount = 1;
            int weekNumber = ISOWeek.GetWeekOfYear(start); // Startwochenzahl des Monats

            for (int i = 1; i < calendar.GetLength(0); i++) // Iteriere durch die Wochen
            {
                bool hasDays = false;

                for (int j = 1; j < calendar.GetLength(1); j++) // Iteriere durch die Wochentage
                {
                    if (i == 1 && j < (int)start.DayOfWeek) // Wenn erste Woche und Tag vor dem Starttag
                    {
                        calendar[i, j] = "  ";  // Leere Felder für Tage vor dem Starttag
                    }
                    else if (dayCount <= daysInMonth) // Wenn noch Tage im Monat vorhanden sind
                    {
                        string actualDay = dayCount.ToString("D2"); // Formatieren der Tagesnummer mit führender Null
                        if (actual.Year == year && actual.Month == month && actual.Day == dayCount) // Hervorhebung des aktuellen Tages
                        {
                            actualDay = "*" + actualDay;
                        }
                        calendar[i, j] = actualDay;
                        dayCount++;
                        hasDays = true; // Angeben, dass es noch Tage gibt
                    }
                    else
                    {
                        calendar[i, j] = "  "; // Leere Felder nach den letzten Tagen des Monats
                    }
                }

                // Wenn die Woche nicht leer ist (also mindestens ein Tag vorhanden ist), gib sie aus
                if (hasDays)
                {
                    Console.Write($" | {weekNumber,3} | {calendar[i, 1],3} | {calendar[i, 2],3} | {calendar[i, 3],3} | {calendar[i, 4],3} | {calendar[i, 5],3} | {calendar[i, 6],3} | {calendar[i, 7],3} |");
                    Console.WriteLine();
                    weekNumber++; // Wochennummer erhöhen
                }
            }
        }
    }
}
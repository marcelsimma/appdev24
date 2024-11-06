using System;
using System.Globalization;

namespace MarcelSimma.Week05
{
    public class DrawCalendar
    {
        /*
        Vorgehensweise:

          1. heutiger Tag
          2. Wie viele Tage hat der Monat
          3. Erster Wochentag des Monats
          4. Tablle
          5. Bonus: Kalenderwoche
        */

        public static void Start()
        {
            // 1. heutiger Tag
            DateTime today = DateTime.Today;
            //today = today.AddMonths(1);
            Console.WriteLine(today.ToString());

            // 2. Tage im Nomat
            int tageImMonat = DateTime.DaysInMonth(today.Year, today.Month);
            Console.WriteLine(tageImMonat);

            // 3. erster Wochentag des Monats
            DateTime firstDayOfMonth = new DateTime(today.Year, today.Month, 1);
            DayOfWeek firstDayOfMonthAsEnum = firstDayOfMonth.DayOfWeek;
            int firstDayOfMonthAsInt = (int)firstDayOfMonthAsEnum;
            Console.WriteLine(firstDayOfMonthAsInt);

            /* 
            alternative Möglichkeit
            DateTime firstDayOfMonth2 = today.AddDays(today.Day * -1 + 1);
            */

            /*
            Laut C# Doku, sind die Wochentage mit Sonntag = 0 bis Samstag = 6 durchnummeriert. 
            Wir setzen voraus, dass Sonntag = 7 ist. 
            Deswegen die if-Abfrage.
            Zur Doku: https://learn.microsoft.com/de-de/dotnet/api/system.dayofweek?view=net-8.0
            */
            if (firstDayOfMonthAsInt == 0)
            {
                firstDayOfMonthAsInt = 7;
            }

            // 4. Tablle    
            
            // Negative Felder werden als leer ausgegeben. Erst, wenn der Counter positiv ist, werden die Felder mit Zahl und ggf. * ausgegeben.
            int counter = firstDayOfMonthAsInt * -1 + 2;

            // Tabellenkopf
            Console.WriteLine("| Mo | Di | Mi | Do | Fr | Sa | So |");

            // Tabelleninhalt

            // äußere Schleife: Zeilen
            for (int i = 0; i < 7; i++)
            {
                // innere Schleife: Spalten und Wwerte
                for (int j = 0; j < 7; j++)
                {
                    if (counter == today.Day)
                    {
                        Console.Write($"| {counter,2}*");
                    }
                    else if (counter > tageImMonat || counter < 1)
                    {
                        Console.Write($"|    ");
                    }
                    else
                    {
                        Console.Write($"| {counter,2} ");
                    }
                    counter++;

                }
                Console.WriteLine("|");

                // Sobald jene Zeile fertig geschrieben ist, in welcher der letzte Kalendertag ist, wird die Schleife abgebrochen, da keine weiteren Zeilen mehr notwendig sind. 
                if (counter > tageImMonat)
                {
                    break;
                }
            }


            // Bonus: Kalenderwoche

            // kalenderspezifische Kulturinformation für Österreich und die Deutsche Sprache
            CultureInfo aut = new CultureInfo("de-AT");

            // der erste Tag in der Woche in Österreich
            DayOfWeek firstDayOfWeekInAt = aut.DateTimeFormat.FirstDayOfWeek;

            // Regeln für den Umgang mit Kalenderwochen in Österreich
            CalendarWeekRule cwr = aut.DateTimeFormat.CalendarWeekRule;

            int week = aut.Calendar.GetWeekOfYear(today, cwr, firstDayOfWeekInAt);

            // Experimet: Wie verändert sich die Kalenderwoche, wenn du die CultureInfo von "de-AT" auf "en-US" änderst?

            Console.WriteLine("Aktuelle Kalenderwoche: " + week);
        }
    }
}
using System;
using System.Globalization;

namespace MarcelSimma.Week05
{

    public class DrawCalendar
    {

        /*
        Vorgehensweise:

          1. Wie viele Tage hat der Monat
          2. Erster Wochentag des Monats
          3. heutiger Tag
          4. Tablle
          5. Erster Tag der Woche (Sonntag, Montag)
        */

        public static void Start()
        {

            // 3. heutiger Tag
            DateTime today = DateTime.Today;
            Console.WriteLine(today.ToString());

            Console.WriteLine((int)today.DayOfWeek);

            // 1. Tage im Nomat
            int tageImMonat = DateTime.DaysInMonth(today.Year, today.Month);
            Console.WriteLine(tageImMonat);


            // 2. erster Wochentag des Monats
            DateTime firstDayOfMonth = new DateTime(today.Year, today.Month, 1);
            Console.WriteLine(firstDayOfMonth);
            DayOfWeek firstDayOfMonthLong = firstDayOfMonth.DayOfWeek;
            Console.WriteLine((int)firstDayOfMonthLong);


            /* alternative Möglichkeit
            DateTime firstDayOfMonth2 = today.AddDays(today.Day * -1 + 1);
            Console.WriteLine(firstDayOfMonth2);
            */

            // 4. Tablle

            // Tabellenkopf
            Console.WriteLine("| Mo | Di | Mi | Do | Fr | Sa | So |");

            // negative Felder werden übersprungen und leer ausgegeben
            int counter = (int)firstDayOfMonthLong * -1 + 2;

            for (int i = 0; i < 7; i++)
            {
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
                if (counter > tageImMonat)
                {
                    break;

                }
            }




        }









        /*


                public static void Start()
                {

                    // heutiges Datum
                    DateTime today = DateTime.Today;

                    // welcher Wochentag ist heute?
                    DayOfWeek todaysDay = today.DayOfWeek;
                    Console.WriteLine(today.DayOfWeek);




                    // erster Tag des Monats
                    DateTime firstDayOfMonth = new DateTime(2024, 11, 1);
                    Console.WriteLine((int)firstDayOfMonth.DayOfWeek);


                    // Kalenderwoche

                    // kalenderspezifische Kulturinformation für Österreich und die Deutsche Sprache
                    CultureInfo aut = new CultureInfo("us-US");

                    // der erste Tag in der Woche in Österreich
                    Console.WriteLine(aut.DateTimeFormat.FirstDayOfWeek);

                    // Regeln für den Umgang mit Kalenderwochen in Österreich
                    CalendarWeekRule cwr = aut.DateTimeFormat.CalendarWeekRule;

                    int week = aut.Calendar.GetWeekOfYear(today, cwr, aut.DateTimeFormat.FirstDayOfWeek);

                    Console.WriteLine(week);


                }
                */
    }
}
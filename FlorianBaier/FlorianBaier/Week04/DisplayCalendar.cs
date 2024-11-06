using System;
using System.Globalization;

namespace FlorianBaier.Week04
{

    public class DisplayCalendar
    {

        public static void Start()
        {
            Console.WriteLine("Enter the year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the month: ");
            int month = Convert.ToInt32(Console.ReadLine());

            DateTime start = new DateTime(year, month, 1);
            DateTime end = start.AddMonths(1);
            DateTime today = DateTime.Now;
            int[,] monthFormat = new int[6, 7];  // Kalender mit maximal 6 Wochen und 7 Tage
            int counter = 0;

            // Berechnung der Anzahl der Tage im Monat
            TimeSpan days = end - start;

            // Kultur und Kalenderinstanz für die Berechnung der Kalenderwoche
            var cultureInfo = CultureInfo.CurrentCulture;
            var calendar = cultureInfo.Calendar;

            // Ausgabe der Monatsüberschrift
            Console.WriteLine($"\n{year} {start.ToString("MMMM")}");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("| KW | Mo | Di | Mi | Do | Fr | Sa | So |");

            // Kalender erstellen
            for (int i = 0; i < monthFormat.GetLength(0); i++)  // Jede Woche (max. 6 Wochen)
            {
                for (int j = 0; j < monthFormat.GetLength(1); j++)  // Jeden Wochentag (7 Tage)
                {
                    // Berechnung des aktuellen Datums für den Kalender
                    DateTime currentDate = start.AddDays(counter);
                    int calendarWeek = calendar.GetWeekOfYear(currentDate, cultureInfo.DateTimeFormat.CalendarWeekRule, cultureInfo.DateTimeFormat.FirstDayOfWeek);

                    // 1. Tag festgelegt
                    if (i == 0 && (int)start.DayOfWeek == 0)  // Falls der 1. Tag auf Sonntag fällt
                    {
                        monthFormat[0, 6] = start.Day;
                        counter = 0;
                    }
                    else if (i == 0 && j == ((int)start.DayOfWeek - 1))  // Start am ersten Tag der Woche
                    {
                        monthFormat[0, (int)start.DayOfWeek - 1] = start.Day;
                        counter = 0;
                    }

                    // Restliche Tage festgelegt
                    else if (j > ((int)start.DayOfWeek - 1) && j < monthFormat.GetLength(1))
                    {
                        start = start.AddDays(1);
                        monthFormat[i, j] = start.Day;
                    }

                    // Ende des Monats festgelegt
                    if (counter >= days.Days)
                    {
                        monthFormat[i, j] = 0;
                    }

                    // Ausgabe der Kalenderwoche in der ersten Spalte
                    if (j == 0)  // KW in der ersten Spalte
                    {
                        Console.Write($"| {calendarWeek,2} ");
                    }

                    // Ausgabe des Datums, wenn es der heutige Tag ist
                    if (monthFormat[i, j] == today.Day)
                    {
                        Console.Write($"| {monthFormat[i, j],2}*");
                    }
                    else
                    {
                        Console.Write($"| {monthFormat[i, j],2} ");
                    }
                    counter++;
                }

                // Zeilenumbruch nach jeder Woche
                Console.WriteLine("|");
            }
            Console.WriteLine("------------------------------------");
        }
    }
}
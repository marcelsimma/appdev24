using System;
using System.Diagnostics.Metrics;
using System.Reflection;
using Microsoft.VisualBasic;

namespace CheyenneHarbarth.Week04
{

    class Calendar
    {

        public static void PrintCalendar(int year, int month)
        {
            DateTime start = new DateTime(year, month, 1);
            DateTime end = start.AddMonths(1);
            DateTime heute = DateTime.Now;
            int[,] Monat = new int[6, 7];
            int counter = 0;

            TimeSpan days = end - start;

            //Monat, Jahr und Kalenderstruktur ausgeben
            Console.WriteLine($"\n{year} {start.ToString("MMMM")}");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("| Mo | Di | Mi | Do | Fr | Sa | So |");

            for (int i = 0; i < Monat.GetLength(0); i++)
            {
                for (int j = 0; j < Monat.GetLength(1); j++)
                {
                    //1. Tag festgelegt
                    if (i == 0 && (int)start.DayOfWeek == 0)      //Umrechnung falls der 1. auf einen Sonntag fällt
                    {
                        Monat[0, 6] = start.Day;
                        counter = 0;
                    }
                    else if (i == 0 && j == ((int)start.DayOfWeek - 1))
                    {
                        Monat[0, ((int)start.DayOfWeek - 1)] = start.Day;
                        counter = 0;
                    }

                    //restliche Tage festgelegt
                    else if (j > ((int)start.DayOfWeek - 1) && j < Monat.GetLength(1))
                    {
                        start = start.AddDays(1);
                        Monat[i, j] = start.Day;
                    }
                    //Ende des Monats festgelegt
                    if (counter >= days.Days)
                    {
                        Monat[i, j] = 0;
                    }
                    //* für heutigen Tag definiert
                    if (Monat[i, j] == heute.Day)
                    {
                        Console.Write($"| {Monat[i, j],2}*");
                    }
                    else
                    {
                        Console.Write($"| {Monat[i, j],2} ");
                    }
                    counter++;
                    
                }
                Console.Write("|" + "\n");
            }
            Console.WriteLine("------------------------------------");
        }
    }
}
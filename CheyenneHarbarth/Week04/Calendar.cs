using System;
using Microsoft.VisualBasic;

namespace CheyenneHarbarth.Week04
{

    class Calendar
    {

        public static void PrintCalendar(int year, int month)
        {
            DateTime start = new DateTime(year, month, 1);
            DateTime heute = DateTime.Now;
            int[,] Monat = new int[5, 7];

            //Monat, Jahr und Kalenderstruktur ausgeben
            Console.WriteLine($" {year} {start.ToString("MMMM")}");
            Console.WriteLine($" | Mo | Di | Mi | Do | Fr | Sa | So |");

            //Console.WriteLine($"{start.ToString("dddd")} {(int)start.DayOfWeek}");

            for (int i = 0; i < Monat.GetLength(0); i++)
            {
                for (int j = 0; j < Monat.GetLength(1); j++)
                {
                    //1. Tag festgelegt und restliche Zeile geschrieben

                    //des o in "if" setzen sunsch wirds vo else überschrieben

                    if (j == ((int)start.DayOfWeek - 1))
                    {
                        Monat[i, ((int)start.DayOfWeek - 1)] = start.Day;
                    }
                    else if (j > ((int)start.DayOfWeek - 1) && j < Monat.GetLength(1))
                    {
                        start = start.AddDays(1);
                        Monat[i, j] = start.Day;
                    }
                    Console.Write($" | {Monat[i, j],2}");

                    //2. Woche festlegen
                }
                Console.Write(" |" + "\n");
            }

        }


        public static void Calculate()
        {


        }
    }
}
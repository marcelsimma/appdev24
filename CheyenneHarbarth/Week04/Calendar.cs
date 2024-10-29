using System;
using Microsoft.VisualBasic;

namespace CheyenneHarbarth.Week04
{

    class Calendar
    {

        public static void PrintCalendar(int year, int month)
        {
            DateTime start = new DateTime(year, month, 1);
            Console.WriteLine($" {year} {start.ToString("MMMM")}");
            Console.WriteLine($" | Mo | Di | Mi | Do | Fr | Sa | So |");
            DateTime heute = DateTime.Now;

            int[,] Monat = new int[5, 7];

            for (int i = 0; i < Monat.GetLength(0); i++)
            {
                for (int j = 0; j < Monat.GetLength(1); j++)
                {
                    //1. Tag festgelegt und restliche Zeile geschrieben
                    Monat[0, (int)start.Day] = (int)start.Day;
                    if (j > (int)start.Day && j < Monat.GetLength(1))
                    {
                        start = start.AddDays(1);
                        Monat[0, j] = (int)start.Day;
                    }
                    if (j < (int)start.Day && j >= 0)
                    {
                        Monat[0,j] = 2;
                    }
                    Console.Write(" |  " + Monat[0, j]);

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
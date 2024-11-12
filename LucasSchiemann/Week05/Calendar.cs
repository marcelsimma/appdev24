using System;
using System.Security.Principal;

namespace LucasSchiemann.Week05;

public static class Calendar
{

    public static void start()
    {

        DateTime firstDay = DateTime.Today;

        int tageImMonat = DateTime.DaysInMonth(firstDay.Year, firstDay.Month);

        DateTime firstDayOfMonth = new DateTime(firstDay.Year, firstDay.Month, 1);

        DayOfWeek firstDayOfMonthAsEnum = firstDayOfMonth.DayOfWeek;

        int firstDayOfMonthAsInt = (int)firstDayOfMonthAsEnum;

        int counter = firstDayOfMonthAsInt * -1 + 2;
        if (firstDayOfMonthAsInt == 0)
        {
            firstDayOfMonthAsInt = 7;
        }

        

        for (int i = 0; i < 7; i++)
        {
            for (int x = 0; x < 7; x++)
            {
                if (counter == firstDay.Day)
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
        }



    }
}




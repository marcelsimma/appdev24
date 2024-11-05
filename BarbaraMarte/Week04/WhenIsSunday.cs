using System;
using System.Collections.Generic;

namespace BarbaraMarte.Week04;

class WhenIsSunday
{
    private const int DAYS_IN_WEEK = 7;

    /// <summary>
    /// Hallo Joachim
    /// </summary>
    /// <param name="amountOfSundays">die Anzahl der Sonntage in der Zukunft. Darf nicht kleiner 0 sein!</param>
    public static void PrintNextSundays(int amountOfSundays = 3)
    {
        DateTime today = DateTime.Now;

        //count to the next sunday
        int daysTillSunday = (DAYS_IN_WEEK - (int)today.DayOfWeek) % DAYS_IN_WEEK;
        DateTime nextSunday = today.AddDays(daysTillSunday == 0 ? DAYS_IN_WEEK : daysTillSunday);

        for (int i = 0; i < amountOfSundays; i++)
        {
            Console.WriteLine(nextSunday.AddDays(i * DAYS_IN_WEEK).ToString("dddd, dd MMMM yyyy"));
        }
    }
}
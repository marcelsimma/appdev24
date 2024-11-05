using System;
using System.Globalization;

namespace BarbaraMarte.Week04;

class MyBirthday
{

    public static void Print()
    {
        Console.WriteLine("When is your Birthday? (dd.MM.yyyy)");
        DateTime bDay = Convert.ToDateTime(Console.ReadLine());

        // CultureInfo austrian = new CultureInfo("de-AT");
        // DayOfWeek day = austrian.DateTimeFormat.FirstDayOfWeek;

        Console.WriteLine("You are born on a: " + bDay.ToString("dddd"));

        Console.WriteLine("Is your birth year a leap year? ture or false:");
        int year = Convert.ToInt32(Console.ReadLine());

        if ((year % 4) == 0)
        {
            Console.WriteLine(year + "Is a leap year.");
        }
        else
        {
            Console.WriteLine(year + "Is not a leap year.");
        }
    }
}


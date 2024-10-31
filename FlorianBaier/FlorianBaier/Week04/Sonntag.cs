using System;
using System.Globalization;

namespace FlorianBaier.Week04
{

    public class Sonntag
    {
        public static void Start()
        {
            DateTime today = DateTime.Today;
            int daysUntilSunday = ((int)DayOfWeek.Sunday - (int)today.DayOfWeek + 7) % 7;

            for (int i = 0; i < 3; i++)
            {
                DateTime nextSunday = today.AddDays(daysUntilSunday + (i * 7));
                Console.WriteLine($"Sonntag {i + 1}: {nextSunday.ToShortDateString()}");
            }
        }
    }
}
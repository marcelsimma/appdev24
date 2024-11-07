using System;
using System.Globalization;

namespace SimonJochum.Week04
{
    public class GetWorkday
    {
        public static void Start()
        {
            GetWorkdays(2024,10);
        }

        public static void GetWorkdays(int year, int month)
        {
            DateTime monthStart = new DateTime(year, month, 1);
            int counter = 0;
            int amountOfDays = DateTime.DaysInMonth(year, month);
            int amountDaysTillEnd = DateTime.DaysInMonth(year, month) + DateTime.DaysInMonth(year, 11) + DateTime.DaysInMonth(year,12);

            for (int i = 0; i < amountOfDays; i++)
            {
                DateTime currentDate = monthStart.AddDays(i);
                DayOfWeek dayOfWeek = currentDate.DayOfWeek;

                //                     6 = Samstag                   0 = Sonntag
                if (dayOfWeek != DayOfWeek.Saturday && dayOfWeek != DayOfWeek.Sunday)
                {
                    counter++;
                }
            }
            Console.WriteLine("Der Monat Oktober hat " + counter + " Arbeitstage.");

            counter = 0;
            for (int i = 0; i < amountDaysTillEnd; i++)
            {
                DateTime currentDate = monthStart.AddDays(i);
                DayOfWeek dayOfWeek = currentDate.DayOfWeek;

                //                     6 = Samstag                   0 = Sonntag
                if (dayOfWeek != DayOfWeek.Saturday && dayOfWeek != DayOfWeek.Sunday)
                {
                    counter++;
                }
            }
            Console.WriteLine($"Bis zum Ende des Jahres sind es {counter} Arbeitstage.");
        }
    }
}
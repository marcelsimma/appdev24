using System;
using System.Globalization;

namespace FlorianBaier.Week04
{

    public class Arbeitstage
    {
        public static void Start()
        {
            int year = 2024;
            int month = 10;

            int workdaysInMonth = GetWorkdays(year, month);
            Console.WriteLine($"Der Monat {GetMonthName(month)} hat {workdaysInMonth} Arbeitstage.");

            int workdaysRemainingYear = GetWorkdaysRemainingYear(year, month);
            Console.WriteLine($"Der Rest des Jahres hat {workdaysRemainingYear} Arbeitstage.");
        }

        static int GetWorkdays(int year, int month)
        {
            int workdays = 0;
            DateTime firstDay = new DateTime(year, month, 1);
            int daysInMonth = DateTime.DaysInMonth(year, month);

            for (int day = 1; day <= daysInMonth; day++)
            {
                DateTime currentDay = new DateTime(year, month, day);
                if (currentDay.DayOfWeek != DayOfWeek.Saturday && currentDay.DayOfWeek != DayOfWeek.Sunday)
                {
                    workdays++;
                }
            }

            return workdays;
        }

        static int GetWorkdaysRemainingYear(int year, int startMonth)
        {
            int workdays = 0;
            for (int month = startMonth; month <= 12; month++)
            {
                workdays += GetWorkdays(year, month);
            }
            return workdays;
        }

        static string GetMonthName(int month)
        {
            return CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month);
        }
    }
}

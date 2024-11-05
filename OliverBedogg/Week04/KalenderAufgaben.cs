using System;
using System.Globalization;

namespace OliverBedogg.Week02
{

    public class KalenderAufgaben
    {
        public static void Start()
        {
            getWorkdays(2024, 1);
            Zeitspanne(2024, 1);
            Console.WriteLine("\n--------------------");
            getWorkdays(2024, 2);
            Zeitspanne(2024, 2);
            Console.WriteLine("\n--------------------");
            getWorkdays(2024, 3);
            Zeitspanne(2024, 3);
            Console.WriteLine("\n--------------------");
            getWorkdays(2024, 4);
            Zeitspanne(2024, 4);
            Console.WriteLine("\n--------------------");
            getWorkdays(2024, 5);
            Zeitspanne(2024, 5);
            Console.WriteLine("\n--------------------");
            getWorkdays(2024, 6);
            Zeitspanne(2024, 6);
            Console.WriteLine("\n--------------------");
            getWorkdays(2024, 7);
            Zeitspanne(2024, 7);
            Console.WriteLine("\n--------------------");
            getWorkdays(2024, 8);
            Zeitspanne(2024, 8);
            Console.WriteLine("\n--------------------");
            getWorkdays(2024, 9);
            Zeitspanne(2024, 9);
            Console.WriteLine("\n--------------------");
            getWorkdays(2024, 10);
            Zeitspanne(2024, 10);
            Console.WriteLine("\n--------------------");
            getWorkdays(2024, 11);
            Zeitspanne(2024, 11);
            Console.WriteLine("\n--------------------");
            getWorkdays(2024, 12);
            Zeitspanne(2024, 12);
            Console.WriteLine("\n--------------------");
        }

        public static void getWorkdays(int year, int month)
        {
            DateTime dt = new DateTime(year, month, 1);
            int count = 0;

            while (dt.Month == month)
            {
                if ((int)dt.DayOfWeek >= 1 && (int)dt.DayOfWeek <= 5)
                {
                    count++;
                }
                dt = dt.AddDays(1);
            }

            Console.WriteLine($"{year}.{month} hat {count} Arbeitstage.");
        }


        public static void Zeitspanne(int year, int month)
        {
            DateTime start = new DateTime(year, month, 1); // 2024.10.01
            DateTime end = start.AddMonths(1); // 2024.11.01

            TimeSpan days = end - start;
            int daysOfMonth = DateTime.DaysInMonth(year, month);

            // grob
            double weeks = days.Days / 7.0;
            double workingDays = weeks * 5;

            // zerlegt
            int firstWeek = 6 - (int)start.DayOfWeek;
            if (firstWeek > 5)
                firstWeek = 5;

            int lastWeek = (int)end.AddDays(-1).DayOfWeek;
            if (lastWeek == 6 || lastWeek == 0)
                lastWeek = 5;

            int workDays = firstWeek + 15 + lastWeek;

            Console.WriteLine($"{year}.{month} hat ca. {workingDays} Arbeitstage. DayOfWeek: {start.DayOfWeek}");
            Console.WriteLine($"{year}.{month} hat {workDays} Arbeitstage.");
            Console.WriteLine($"{year}.{month} hat {days.Days} Tage und hat {weeks} Wochen.");

        }
    }
}
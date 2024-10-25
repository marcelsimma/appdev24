using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Globalization;

namespace MagdalenaMueller.Week04
{
    public class Calender
    {
        public static void CalenderExample()
        {
            DateTime now = DateTime.Now;

            Console.WriteLine(now.ToString("dd.MM.yyyy"));
            Console.WriteLine(now.ToString("T"));
            Console.WriteLine(now);
            Console.WriteLine(now + now.ToString(" K"));
            Console.WriteLine(now.ToString("s.f"));

        }
        public static void Birthday()
        {
            Console.WriteLine("Gib dein geburtstag ein: ");
            string? input = Console.ReadLine();
            
            DateTime birthday = Convert.ToDateTime(input);

            DayOfWeek birthdayWeekDay = birthday.DayOfWeek;

            Console.WriteLine(birthday.ToString("-------------------------\ndddd", new CultureInfo("de-DE")));

            if(birthday.Year % 4 == 0)
            {
                Console.WriteLine("Dein Geburtstag war in einem Schaltjahr");
            }
            else
            {
                Console.WriteLine("Dein Geburtstag war nicht in einem Schaltjahr");
            }
        }
        public static void CountSunday()
        {
            DateTime now = DateTime.Now;
            DayOfWeek sunday = now.DayOfWeek;

           int sundayCounter = 3;

            for(int i = 0; i < sundayCounter;)
            {
                if(now.DayOfWeek == DayOfWeek.Sunday)
                {
                    Console.WriteLine(now.ToString("dddd, dd.MM.yy", new CultureInfo("de-DE")));
                    i++;
                }
                now = now.AddDays(1);
            }
        }
        public static void WorkDays(int year, int month)
        {
            DateTime date = new DateTime(year, month, 1);
            int countWorkdaysMonth = 0;
            int countWorkdaysYear = 0;

            int daysInMonth = DateTime.DaysInMonth(year, month);

            DateTime startDate = new DateTime(year, month, 1);
            DateTime endOfYear = new DateTime(year, 12, 31);
            int remainingDays = (endOfYear - startDate).Days;

            for (int i = 0; i < daysInMonth; i++)
            {
                if (date.DayOfWeek != DayOfWeek.Sunday && date.DayOfWeek != DayOfWeek.Saturday)
                {
                    countWorkdaysMonth++;
                }
                date = date.AddDays(1); 
            }

            date = new DateTime(year,month,1);

            for(int i = 0; i< remainingDays; i++)
            {
                if (date.DayOfWeek != DayOfWeek.Sunday && date.DayOfWeek != DayOfWeek.Saturday)
                {
                    countWorkdaysYear++;
                }
                date = date.AddDays(1); 
            }

            string monthName = new DateTime(year, month, 1).ToString("MMMM", new CultureInfo("de-DE"));
            Console.WriteLine($"Der Monat {monthName} hat {countWorkdaysMonth} Arbeitstage.");
            Console.WriteLine($"Das Restliche Jahr {year} hat {countWorkdaysYear} Arbeitstage");
        }
    }
}
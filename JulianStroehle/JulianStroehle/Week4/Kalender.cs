using System;
using System.Globalization;
namespace JulianStroehle.Week4
{
    public class Kalender
    {
        public static void Start()
        {
            string[,] kalender = new string[7, 7];
            kalender[0, 0] = "Mo";
            kalender[0, 1] = "Di";
            kalender[0, 2] = "Mi";
            kalender[0, 3] = "Do";
            kalender[0, 4] = "Fr";
            kalender[0, 5] = "Sa";
            kalender[0, 6] = "So";
            Console.WriteLine("Heutiges Datum eingeben: (dd.MM.yyyy)");
            string[] seite = Console.ReadLine().Split('.');
            int day = Convert.ToInt32(seite[0]);
            int month = Convert.ToInt32(seite[1]);
            int year = Convert.ToInt32(seite[2]);
            string Monat = month switch
            {
                1 => "Januar",
                2 => "Februar",
                3 => "März",
                4 => "April",
                5 => "Mai",
                6 => "Juni",
                7 => "Juli",
                8 => "August",
                9 => "September",
                10 => "Oktober",
                11 => "November",
                12 => "Dezember",
                _ => " ",
            };
            Console.WriteLine("\n" + Monat + " " + year);
            DateTime dt = new(year, month, 1);
            DateTime dtm = new(year, month, day);
            CultureInfo currentCulture = CultureInfo.CurrentCulture;
            Calendar cal = currentCulture.Calendar;
			int calendarWeek = cal.GetWeekOfYear(dtm, currentCulture.DateTimeFormat.CalendarWeekRule, currentCulture.DateTimeFormat.FirstDayOfWeek);
			if (calendarWeek > 52)
			{
				dtm = dtm.AddDays(7);
				int testCalendarWeek = cal.GetWeekOfYear(dtm, currentCulture.DateTimeFormat.CalendarWeekRule, currentCulture.DateTimeFormat.FirstDayOfWeek);
				if (testCalendarWeek == 2)
                {
                    calendarWeek = 1;
                }
			}
            Console.WriteLine("Kalenderwoche " + calendarWeek);
            int count = 0;
            for (int i = 1; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {

                    string Day = " ";
                    switch (dt.DayOfWeek)
                    {
                        case DayOfWeek.Monday: Day = "Mo"; break;
                        case DayOfWeek.Tuesday: Day = "Di"; break;
                        case DayOfWeek.Wednesday: Day = "Mi"; break;
                        case DayOfWeek.Thursday: Day = "Do"; break;
                        case DayOfWeek.Friday: Day = "Fr"; break;
                        case DayOfWeek.Saturday: Day = "Sa"; break;
                        case DayOfWeek.Sunday: Day = "So"; break;
                    }
                    if (kalender[0, j] == Day)
                    {
                        count++;
                    }
                    if (count > 0 && dt.Month == month)
                    {
                        kalender[i, j] = Convert.ToString(dt.Day);
                        dt = dt.AddDays(1);
                    }
                }
            }
            int count2 = 0;
            for (int i = 0; i < kalender.GetLength(0); i++)
            {
                if (i == 5 && kalender[5, 0] == null || i == 6 && kalender[6, 0] == null)
                {
                    break;
                }
                Console.Write("\n|");
                for (int j = 0; j < kalender.GetLength(1); j++)
                {
                    if (kalender[6, 0] != "\0" && count2 == 0)
                    {
                        count2++;
                    }
                    if (i == 5 && kalender[5, 0] == null || i == 6 && kalender[6, 0] == null)
                    {
                        break;
                    }
                    string star = null;
                    if (kalender[i, j] == Convert.ToString(day))
                    {
                        star = "*";
                    }
                    Console.Write(string.Format("{0,7}", star + kalender[i, j] + " |"));
                }
            }
        }
    }
}
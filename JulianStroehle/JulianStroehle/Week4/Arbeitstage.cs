using System;
namespace JulianStroehle.Week4
{
    public class Arbeitstage
    {
        public static void Start()
        {
            Console.WriteLine("Jahr eingeben: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Monat eingeben: ");
            string? Monat = Console.ReadLine();

            int month = Monat switch
            {
                "Januar" => 1,
                "Februar" => 2,
                "März" => 3,
                "April" => 4,
                "Mai" => 5,
                "Juni" => 6,
                "Juli" => 7,
                "August" => 8,
                "September" => 9,
                "Oktober" => 10,
                "November" => 11,
                "Dezember" => 12,
                _ => 0,
            };
            if (month != 0)
            {
                GetWorkdays(year, month, Monat);
            }
            else
            {
                Console.WriteLine("Fehler bei der Eingabe.");
            }
        }
        static void GetWorkdays(int year, int month, string Monat)
        {
            int count = 0;
            int count2 = 0;
            DateTime dt = new DateTime(year, month, 1);
            for (int i = 1; i < 367; i++)
            {
                dt = dt.AddDays(1);
                if (dt.Month == month && dt.DayOfWeek != DayOfWeek.Saturday && dt.DayOfWeek != DayOfWeek.Sunday)
                {
                    count++;
                }
                if (dt.Month > month && dt.DayOfWeek != DayOfWeek.Saturday && dt.DayOfWeek != DayOfWeek.Sunday)
                {
                    count2++;
                }
            }
            Console.WriteLine("Der Monat " + Monat + " des Jahres " + year + " hat " + count + " Arbeitstage");
            Console.WriteLine("Das restliche Jahr nach dem Monat hat " + count2 + " Arbeitstage");
        }
    }
}
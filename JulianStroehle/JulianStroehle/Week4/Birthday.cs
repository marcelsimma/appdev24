using System;
namespace JulianStroehle.Week4
{
    public class Birthday
    {
        public static void Start()
        {
            Console.WriteLine("Wann war dein Geburtstag (dd.MM.yyyy)");
            string Date = Console.ReadLine();
            string[] date = Date.Split('.');
            int day = Convert.ToInt32(date[0]);
            int month = Convert.ToInt32(date[1]);
            int year = Convert.ToInt32(date[2]);
            DateTime dt = new DateTime(year, month, day);
            Console.Write("Du hattest an einem " + dt.ToString("ddddd"));
            if (dt.Year % 4 == 0)
            {
                Console.Write(" in einem Schaltjahr");
            }
            Console.WriteLine(" Geburtstag");
        }
    }
}
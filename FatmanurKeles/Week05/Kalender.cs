using System;
using System.Diagnostics;
namespace FatmanurKeles.Week04
{
    public class Kalender
    {
        public static void Start()
        {
            while (true)
            {
                Console.WriteLine("1. Aktuelles Datum anzeigen");
                Console.WriteLine("2. Kalenderansicht anzeigen");
                Console.WriteLine("3. Programm beenden");
                string auswahl = Console.ReadLine();

                if (auswahl == "1")
                {
                    todaysDate();
                }

                else if (auswahl == "2")
                {
                    showCalender(DateTime.Today);
                }

                else if (auswahl == "3")
                {
                    Console.WriteLine("Programm wird beendet.");
                    break;
                }
            }
        }

        public static void todaysDate()
        {
            DateTime today = DateTime.Today;
            Console.WriteLine($"Heutiges Datum: {today}\n");
        }
        public static void showCalender(DateTime today)
        {
            // Kalender Tabelle wird angezeigt
            int year = today.Year;
            int month = today.Month;
            int todaysDate = today.Day;

            Console.WriteLine($"Heutiges Datum: {today}\n");
            Console.WriteLine("| Mo | Di | Mi | Do | Fr | Sa | So |");

            //tage im Monat werden bestimmt
            DateTime firstDayOfMonth = new DateTime(year, month, 1);

            //starttag wird bestimmt
            DateTime firstDayofMonth = new DateTime(year, month, 1);
            int startDay = (int)firstDayOfMonth.DayOfWeek;
            if (startDay == 0) startDay = 7;

            int daysInMonth = DateTime.DaysInMonth(year, month);

            //leere Tage in der Tabelle
            for (int i = 1; i < startDay; i++)
            {
                Console.WriteLine("  ");
            }

            // tage des Monats werden ausgegeben 
            
            for (int day = 1; day <=daysInMonth; day++)
            {
                if (day == todaysDate)
                {
                    Console.Write($"| {day,2}*");
                }
                else if (day > daysInMonth || day < 1)
                {
                    Console.Write($"|    ");
                }
                else 
                {
                    Console.Write($"| {day,2} ");
                }
                day++;

            }
                

            /*
            Console.WriteLine("Bitte Jahr eingeben: ");
            int jahr = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Bitte Monat (1-12) eingeben: ");
            int monat = Convert.ToInt32(Console.ReadLine());
            */
        }
    }
}



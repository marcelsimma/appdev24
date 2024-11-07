using System;
using System.Globalization;
using SimonJochum.Week02;

namespace SimonJochum.Week04
{
    public class WhenAndWhere
    {
        public static void Start()
        {
            // ActualDate();
            // CalculateBirthday();
            // FindSundays();
            // UserInput();
            GetWorkdaysTillEndYear();
        }

        public static void ActualDate()
        {
            DateTime date = DateTime.Now;
            Console.WriteLine(date.ToString("dd.MM.yyyy")); // Datumsformate

            DateTime time = DateTime.Now;
            Console.WriteLine(time.ToString("HH:mm:ss")); // Zeitformate

            DateTime dateAndTime = DateTime.Now;
            Console.WriteLine(dateAndTime.ToString("dd.MM.yyyy HH:mm:ss"));

            DateTime dateWithUTC = DateTime.Now;
            Console.WriteLine(dateWithUTC.ToString("dd.MM.yyyy HH:mm:ss zzz")); // zzz für die Zeitzone

            DateTime timeSecondAndMillisecond = DateTime.Now;
            Console.WriteLine(timeSecondAndMillisecond.ToString("ss:fff")); // fff für die Millisekunden

        }

        public static void CalculateBirthday()
        {
            Console.WriteLine("Bitte Gib deinen Geburtstag ein. (dd.MM.yyyy)");
            string? date = Console.ReadLine();

            DateTime value = DateTime.Parse(date); // Umwandlung vom String in ein Datumsformat
            int year = value.Year; // .Year um aus dem Datumsformat das Jahr zu extrahieren
            Console.WriteLine(value.ToString("dddd")); // Ausgabe des Tages
            if (DateTime.IsLeapYear(year) == true) // Abfrage ob das Jahr ein Schaltjahr ist
            {
                Console.WriteLine("Dein Geburtsjahr war ein Schaltjahr.");
            }
            else
            {
                Console.WriteLine("Dein Geburtsjahr war kein Schaltjahr");
            }

        }

        public static void FindSundays()
        {
            Console.WriteLine("Wie viele Sonntage möchtest du herraussuchen?");
            int amount = Convert.ToInt32(Console.ReadLine());
            DateTime today = DateTime.Today;
            DateTime nextSunday = today.AddDays(7 - (int)today.DayOfWeek); // Berechnung 7-Zahl des heutigen Tages

            Console.WriteLine($"Die nächsten {amount} Sonntage sind am:");
            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine(nextSunday.ToString("dd.MM.yyyy"));
                nextSunday = nextSunday.AddDays(7);
            }
        }

        public static void UserInput()
        {
            Console.WriteLine("In welchem Monat möchtest du die Arbeitstage zählen?");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("In welchem Jahr möchtest du die Arbeitstage zählen?");
            int year = Convert.ToInt32(Console.ReadLine());
            GetWorkdays(year, month);

        }

        public static void GetWorkdays(int year, int month)
        {
            DateTime monthStart = new DateTime(year, month, 1);
            DateTime monthEnd = monthStart.AddDays(DateTime.DaysInMonth(year, month) - 1);
            int workdayCount = 0;

            for (DateTime currentDay = monthStart; currentDay <= monthEnd; currentDay = currentDay.AddDays(1))
            {
                // Überprüfen, ob der Tag ein Werktag ist (Montag bis Freitag)
                if (currentDay.DayOfWeek != DayOfWeek.Saturday && currentDay.DayOfWeek != DayOfWeek.Sunday)
                {
                    workdayCount++;
                }
            }

            Console.WriteLine("Der Monat hat " + workdayCount + " Arbeitstage.");
        }

        public static void GetWorkdaysTillEndYear()
        {
            Console.WriteLine("Ab welchem Monat möchtest du die Arbeitstage zählen?");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bis zu welchem Monat möchtest du die Arbeitstage zählen?");
            int monthToEnd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("In welchem Jahr möchtest du die Arbeitstage zählen?");
            int year = Convert.ToInt32(Console.ReadLine());
            DateTime monthStart = new DateTime(year, month, 1);
            DateTime monthEnd = new DateTime (year, monthToEnd, DateTime.DaysInMonth(year, monthToEnd) - 1);
            int workdayCount = 0;

            for(DateTime currentDay = monthStart; currentDay <= monthEnd; currentDay = currentDay.AddDays(1))
            {
                if (currentDay.DayOfWeek != DayOfWeek.Saturday && currentDay.DayOfWeek != DayOfWeek.Sunday)
                {
                    workdayCount++;
                }
            }
            Console.WriteLine("In der angegebenen Zeitspanne sind es " + workdayCount + " Arbeitstage.");
        }
    }
}

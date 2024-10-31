using System;
using System.Globalization;

namespace FlorianBaier.Week04
{

    public class Geburtstag
    {
        public static void Start()
        {
            Console.Write("Please enter your birthday using this format dd.MM.yyyy : ");
            string? input = Console.ReadLine();

            if (DateTime.TryParseExact(input, "dd.MM.yyyy", null, DateTimeStyles.None, out DateTime birthday))
            {
                string dayOfTheWeek = birthday.DayOfWeek.ToString();
                Console.WriteLine($"You were born on a {dayOfTheWeek}.");

                bool isLeapyear = DateTime.IsLeapYear(birthday.Year);
                if (isLeapyear)
                {
                    Console.WriteLine($"{birthday.Year} was a leapyear.");
                }
                else
                {
                    Console.WriteLine($"{birthday.Year} wasn't a leapyear.");
                }
            }
            else
            {
                Console.WriteLine("Ungültiges Datum. Bitte überprüfe das Format.");
            }
        }
    }
}
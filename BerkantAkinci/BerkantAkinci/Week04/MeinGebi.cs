using System;
using System.Globalization;

namespace BerkantAkinci.Week04
{

    class MeinGebi
    {

        public static void PrintMeinGebi()
        {
            DateTime input = new DateTime();
            DateTime birthday = new DateTime(2003, 07, 31);
            CultureInfo austrian = new CultureInfo("de-AT");
            DayOfWeek day = birthday.DayOfWeek;
            string dayDeutsch = austrian.DateTimeFormat.GetDayName(day);

            do
            {
                System.Console.Write("Errate mein Geburtstag: ");
                input = Convert.ToDateTime(Console.ReadLine());

                if (input == birthday)
                {
                    Console.WriteLine($"Gratuliere, du hast mein Geburtstag erraten!\nIch bin an einem {dayDeutsch} auf die Welt gekomemen! ");
                }

                else
                {
                    System.Console.WriteLine("Falsch, bitte versuche es nochmal!");
                }

            } while (input != birthday);
        }
    }
}
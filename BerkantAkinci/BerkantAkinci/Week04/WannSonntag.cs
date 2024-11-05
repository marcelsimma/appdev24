using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

namespace BerkantAkinci.Week04
{

    class WannSonntag
    {

        public static void PrintSonntag()
        {
            DateTime today = DateTime.Today;

            // Nächsten Sonntag ermitteln
            int daysUntilSunday = ((int)DayOfWeek.Sunday - (int)today.DayOfWeek + 7) % 7;
            
            if (daysUntilSunday == 0)
            {
                daysUntilSunday = 7; // falls heute Sonntag ist, ist der nächste Sonntag in 7 Tagen
            }
            DateTime firstSunday = today.AddDays(daysUntilSunday);
            DateTime secondSunday = firstSunday.AddDays(7);
            DateTime thirdSunday = secondSunday.AddDays(7);

            Console.WriteLine(firstSunday.ToString("dd.MM.yyyy"));
            Console.WriteLine(secondSunday.ToString("dd.MM.yyyy"));
            Console.WriteLine(thirdSunday.ToString("dd.MM.yyyy"));
        }
    }
}

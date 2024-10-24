using System;
using System.Globalization;

namespace FlorianBaier.Week04
{

    public class WannUndWo
    {
        public static void Start()
        {
        DateTime currentDate = DateTime.Now;
        DateTime currentTime = DateTime.Now;
        DateTime currentDateTime = DateTime.Now;
        DateTime currentSecondWithMilliseconds = DateTime.Now;

        Console.WriteLine($"Datum: {currentDate.ToShortDateString()}");
        Console.WriteLine($"Uhrzeit: {currentTime:HH:mm:sszzz}");
        Console.WriteLine($"Datum und Uhrzeit: {currentDateTime} | Zeitzone: {TimeZoneInfo.Local.StandardName} | Aktuelle Sekunde mit Millisekunde: {currentSecondWithMilliseconds:HH:mm:ss.fff}"); 
        }
    }
}
using System;
using System.Globalization;

namespace FlorianBaier.Week04
{

    public class Calendar
    {
        public static void Start()
        {
            // Zeitpunkt();
            Zeitspanne();
        }

        public static void Zeitpunkt()
        {
            // Struktur für einen Zeitstempel
            DateTime dt1 = new DateTime(); // 01/01/0001 00:00:00
            DateTime dt2 = new DateTime(2024, 10, 24); // Jahr, Monat, Tag

            Console.WriteLine(dt1.ToString());
            Console.WriteLine(dt2.ToString());

            Console.WriteLine(dt2.ToString("dd.MM.yy"));

            Console.WriteLine("\n--------------------");

            DateTime moment = DateTime.Now;

            // https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-8.0

            Console.WriteLine(moment.ToString());
            Console.WriteLine("\n--------------------");

            CultureInfo austrian = new CultureInfo("de-AT");
            DayOfWeek dow = austrian.DateTimeFormat.FirstDayOfWeek;
            Console.WriteLine(dow);

            // ToString mit vordefinierten Formaten
            // https://learn.microsoft.com/en-us/dotnet/api/system.datetime.tostring?view=net-8.0#system-datetime-tostring
            Console.WriteLine(moment.ToString("d"));
            Console.WriteLine(moment.ToString("d", austrian));
            Console.WriteLine(moment.ToString("t"));
            Console.WriteLine(moment.ToString("t", austrian));
            Console.WriteLine(moment.ToString("F"));
            Console.WriteLine(moment.ToString("F", austrian));

            // TODO
            // Teste verschiedene Formate und kulturelle Kontexte
            // + Gib ein Datum im Format Donnerstag, 24. Oktober 2024 aus
            // + Welche Kürzel gibt es für Jahr, Monat, Tag, Stunde, Minute, Sekunde
        }

        public static void Zeitspanne()
        {
            // Struktur für eine Zeitspanne
            TimeSpan ts = new TimeSpan(25, 20, 55); // Stunden, Minuten, Sekunden
            DateTime jetzt = DateTime.Now;

            jetzt.AddHours(25.5);

            Console.WriteLine(jetzt.ToString());

            DateTime spaeter = jetzt.Add(ts);
            Console.WriteLine(spaeter.ToString());

            // Beginn der Unix-Epoche
            // 1.1.1970 00:00 UTC
            DateTimeOffset dto = new DateTimeOffset(jetzt.ToUniversalTime());
            long seconds = dto.ToUnixTimeSeconds();
            Console.WriteLine(seconds);
            Console.WriteLine("\n--------------------");
        }
    }
}
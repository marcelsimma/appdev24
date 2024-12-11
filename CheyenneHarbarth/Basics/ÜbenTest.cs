using System;
using System.Globalization;

namespace CheyenneHarbarth.Basics
{
    public class ÜbenTest
    {
        //Übungen zu DateTime und Datenströme
        //Aufgabe Wann und Wo?
        public static void Start()
        {
            DateTime Today = DateTime.Now;
            DateTime test = DateTime.MaxValue;

            Console.WriteLine();
            Console.WriteLine(test);


            CultureInfo austrian = new CultureInfo("de-AT");
            TimeZoneInfo Austria = TimeZoneInfo.Local;                                      //TimeZoneInfo ist die Klasse für die Zeitzonen

            System.Console.WriteLine();
            Console.WriteLine($"Heutiges Datum: {Today.ToShortDateString()}");                  //Klammern nicht vergessen, Alternativer Code: Today.ToString("dd.MM.yy");

            Console.WriteLine($"Aktuelle Uhrzeit: {Today.ToShortTimeString()}");                //Alternativer 

            Console.WriteLine($"Datum und Uhrzeit: {Today.ToString(austrian)}");            //CultureInfo liefert nur die richtige Schreibweise mit, gibt nicht die Zeitzone mit

            System.Console.WriteLine();
            Console.WriteLine($"Zeitzone: {Austria.DisplayName}");                  //Zeitunterschied + Namen der Städte wo diese Zeitzone gültig ist
            Console.WriteLine($"Zeitzone: {Austria.Id}");                           //Name der Zeitzone internation
            Console.WriteLine($"Zeitzone: {Austria.StandardName}");                 //gebräuchlicher Name der Zeitzone
            Console.WriteLine($"Zeitzone: {Austria.DaylightName}");                 //Sommerzeitzonenname
            Console.WriteLine($"Zeitzone: {Austria.BaseUtcOffset}");                // Der Zeitunterschied nur als Zahl
            System.Console.WriteLine();

            Console.WriteLine($"Aktuelle Sekunde mit Millisekunde: {Today.Second} {Today.Millisecond}");

            //Die wichtigsten Formatierungen für DateTime
            System.Console.WriteLine();
            Console.WriteLine(Today.ToString());                        //Datum ohne Wochentag: 25.11.2024 10:01
            Console.WriteLine(Today.ToString("d"));                     //kurzes Datum: 25.11.2024
            Console.WriteLine(Today.ToString("D"));                     //langes Datum: Montag, 25.11.2024
            Console.WriteLine(Today.ToString("t"));                     //kurze Zeit: 10:01
            Console.WriteLine(Today.ToString("T"));                     //lange zeit: 10:01:43
            Console.WriteLine(Today.ToString("f"));                     //Datum und Zeit: Montag, 25.11.2024 10:01
            Console.WriteLine(Today.ToString("M"));                     //Tag und Monat: 25. Nov
            Console.WriteLine(Today.ToString("Y"));                     //Monat und Jahr: November 2024
            Console.WriteLine(Today.ToString("dd" + "ddd" + "dddd"));   //Tag: 25 Mon Montag
            Console.WriteLine(Today.ToString("MM" + "MMM" + "MMMM"));   //Monat: 11 Nov November
            Console.WriteLine(Today.ToString("yy" + "yyyy"));           //jahr: 24 2024
            Console.WriteLine(Today.ToString("fff" + "FFF"));           //Millisekunde: 430 43
            //mm für Minuten, hh oder HH für Stunden, ss für Sekunden


            //DateOnly um nur mit dem Datum zu arbeiten, verschieden Möglichkeiten DateOnly zu initialisieren
            DateOnly tomorow = DateOnly.FromDateTime(Today.AddDays(1));
            DateOnly probe = new DateOnly(2024, 11, 30);

            System.Console.WriteLine();
            Console.WriteLine($"DateOnly Typ: {tomorow}");
            Console.WriteLine($"DateOnly Typ: {probe}");

            //TimeOnly um nur mit der Zeit zu arbeiten
            TimeOnly morning = new TimeOnly(07, 43, 21);
            TimeOnly evening = TimeOnly.FromDateTime(Today.AddHours(12));

            System.Console.WriteLine();
            Console.WriteLine($"TimeOnly Typ: {morning}");
            Console.WriteLine($"TimeOnly Typ: {evening}");
        }
        public static void Practice()
        {
            DateTime zeitpunkt = new DateTime(1000000000);              //Ticks
            Console.WriteLine(zeitpunkt);

            DateTime aktuell = new DateTime(1964, 10, 05);              //vorgebenes Jahr, Monat und Tag
            Console.WriteLine(aktuell);

            //Eigenschaften von DateTime
            zeitpunkt = DateTime.Now;           //gibt die aktuelle Zeit deines Geräts an
            Console.WriteLine(zeitpunkt);

            Console.WriteLine($"Tag: {zeitpunkt.Day}");
            Console.WriteLine($"Monat: {zeitpunkt.Month}");
            Console.WriteLine($"Jahr: {zeitpunkt.Year}");


            //Methoden von DateTime
            Console.WriteLine($"Datum in 10 Jahren: {zeitpunkt.AddYears(10)}");
            Console.WriteLine($"Datum vor 20 Jahren: {zeitpunkt.AddYears(-20)}");
            Console.WriteLine($"Datum in 50 Tagen: {zeitpunkt.AddDays(50)}");


            //Formatierungs-Methoden von DateTime
            Console.WriteLine(zeitpunkt.ToLongDateString());
            Console.WriteLine(zeitpunkt.ToShortDateString());

            Console.WriteLine(zeitpunkt.ToShortTimeString());
            Console.WriteLine(zeitpunkt.ToLongTimeString());

        }

        public static void Birthday()
        {
            while (true)
            {
                Console.WriteLine("Wann hast du Geburtstag?");
                string input = Console.ReadLine();

                if (DateTime.TryParse(input, out DateTime birthday))
                {
                    Console.WriteLine($"Du bist an einem {birthday.DayOfWeek} auf die Welt gekommen");
                    break;
                }
                else
                {
                    Console.WriteLine("Das war nicht das richtige Format, versuche es erneut! dd.mm.yyyy");
                }
            }
        }
    }
}
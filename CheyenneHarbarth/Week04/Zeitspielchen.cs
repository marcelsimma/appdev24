using System;
using System.Globalization;
using CheyenneHarbarth.Week02;

namespace CheyenneHarbarth.Week04
{

    class Zeitspielchen
    {
        public static void Start()
        {
            DateTime time = DateTime.Now;
            Console.WriteLine($"Aktuelles Datum: {time.ToShortDateString()}");
            Console.WriteLine($"Aktuelle Uhrzeit: {time.ToShortTimeString()}");
            Console.WriteLine("------------------------");

            Console.WriteLine($"Datum und Uhrzeit {time}");
            Console.WriteLine("------------------------");

            Console.WriteLine($"{time}");

            Console.Write($"{time.Second} Sekunden und {time.Millisecond} Milliskeunden \n");
            Console.WriteLine("------------------------");
        }

        public static void AskBirthday()
        {
            Console.WriteLine("Wann hast du Geburtstag? Format: dd.mm.yyyy");


            //DateTime.TryParse konvertiert die Eingabe in ein Datum, sollte es nicht zum konvertieren gehen, gibt es einen "false" Wert zurück
            while (true)
            {
                string input = Console.ReadLine();
                if (DateTime.TryParse(input, out DateTime Birthday))
                {
                    //Datum in String "umrechnen" = Der Wochentag des Datums
                    Console.WriteLine($"Du bist an einem {Birthday.ToString("dddd", new CultureInfo("de-AT"))} auf die Welt gekommen!");        //Wir konvertieren das Datum in einen String --> den Wochentag; "dddd" ist das Format, du könntest den Tag auch abkürzen; CultureInfo damit der Tag auf Deutsch ausgegeben wird
                    break;
                }
                else
                {
                    Console.WriteLine("Das war kein gültiges Format! Es muss folgendes Format sein: dd.mm.yyyy");
                }
            }
        }

        public static void DreiSonntage()
        {
            DateTime today = DateTime.Today;

            // Nächsten Sonntag ermitteln
            int daysUntilSunday = (int)DayOfWeek.Sunday - (int)today.DayOfWeek + 7;         //x = 0 - 4 + 7  = 3, also noch 3 Tage bis Sonntag                                   

            //3 Sonntage berechnen
            DateTime firstSunday = today.AddDays(daysUntilSunday);
            DateTime secondSunday = firstSunday.AddDays(7);
            DateTime thirdSunday = secondSunday.AddDays(7);             //er nimmt immer den letzten Sonntag und addiert sieben 7 Tage dazu

            //Sonntage ausgeben
            Console.WriteLine(firstSunday.ToString("dd.MM.yyyy"));
            Console.WriteLine(secondSunday.ToString("dd.MM.yyyy"));
            Console.WriteLine(thirdSunday.ToString("dd.MM.yyyy"));
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
    }
}
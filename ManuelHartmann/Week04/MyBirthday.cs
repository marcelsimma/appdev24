

using System.Globalization;

namespace ManuelHartmann.Week04
{
    public class MyBirthday
    {
        public static void Start()
        {
            Console.WriteLine("Tell me the Date of your Birthday -> dd.MM.yyyy");
            string birthdayDate = Console.ReadLine();
            CurrentDate();
            CurrentTime();
            CurrentDateAndTime();
            CurrentDateAndTimeAndTimeZone();
            SecondsAndMilliSeconds();
            WeekdayOfBirthday(birthdayDate);
        }
        // Gibt das heutige Datum aus. (von diesem Rechner)
        static void CurrentDate()
        {
            //  Gibt den derzeitigen Zeitpunkt (Tag.Monat.Jahr und Uhrzeit) von diesem PC zurueck.
            DateTime dateTime = DateTime.Now;

            //  Beim Arbeiten mit Zeiten (Kalender etc.) werden die benötigten Informationen immer erst bei der Ausgabe angepasst.
            //  In diesem Fall benötigen wir die Uhrzeit nicht, sondern nur das Datum des heutigen Tages.
            Console.WriteLine("'dd.MM.yy': " + dateTime.ToString("dd.MM.yy"));
        }
        // Gibt die derzeitige Uhrzeit aus. (von diesem Rechner)
        static void CurrentTime()
        {
            //  Gibt den derzeitigen Zeitpunkt (Tag.Monat.Jahr und Uhrzeit) von diesem PC zurueck.
            DateTime dateTime = DateTime.Now;

            //  Kurzes Uhrzeitformat. (ohne MS)
            Console.WriteLine("'t': " + dateTime.ToString("t"));

            //  Langes Uhrzeitformat. (mit MS)
            Console.WriteLine("'T': " + dateTime.ToString("T"));
        }
        static void CurrentDateAndTime()
        {
            //  Gibt den derzeitigen Zeitpunkt (Tag.Monat.Jahr und Uhrzeit) von diesem PC zurueck.
            DateTime dateTime = DateTime.Now;

            //  'f' -> kombiniert die lange Datumsform 'D' und die kurze Uhrzeitsform 't'.
            Console.WriteLine("'f': " + dateTime.ToString("f"));

            //  'F' -> benutzerdefinierte Datums- und Uhrzeitzeichenfolge (von diesem Rechner -> Kulturbezogen)
            Console.WriteLine("'F': " + dateTime.ToString("F"));

            //  'g' -> kombiniert die kurze Datumsform 'd' und die kurze Uhrzeitsform 't'.
            Console.WriteLine("'g': " + dateTime.ToString("g"));

            //  'G' -> kombiniert die kurze Datumsform 'd' und die lange Uhrzeitsform 'T'.
            Console.WriteLine("'G': " + dateTime.ToString("G"));

            //  Kann auch ueber eine KulturInformation ausgegeben werde. In diesem Fall, wie man das Datum- und Uhrzeit in Austria ausgibt.
            CultureInfo austria = new CultureInfo("de-AT");
            Console.WriteLine("KulturInfo AT: " + dateTime.ToString(austria.DateTimeFormat));
        }
        //  Current Date with Time and related TimeZone.
        static void CurrentDateAndTimeAndTimeZone()
        {
            DateTime dateTime = DateTime.Now;

            //  'K' -> ZeitZone kann nur in Kombination einer Zeit und/oder Datum verwendet werden.
            Console.WriteLine(dateTime.ToString("g") + " TimeZone:" + dateTime.ToString("tK"));
        }
        //  Display the current Time with seconds and milliseconds.
        static void SecondsAndMilliSeconds()
        {
            DateTime dateTime = DateTime.Now;

            Console.Write("Current Time with seconds and milliseconds: ");
            Console.Write(dateTime.ToString("T"));
            Console.Write(":" + dateTime.Millisecond);
        }
        static void WeekdayOfBirthday(string birthdayDate)
        {
            int day = 0;
            int month = 0;
            int year = 0;

            string[] splitBdDate = birthdayDate.Split(".");

            if (int.TryParse(splitBdDate[0], out day))
            {
                Console.WriteLine(day);
            }
            if (int.TryParse(splitBdDate[1], out month))
            {
                Console.WriteLine(month);
            }
            if (int.TryParse(splitBdDate[2], out year))
            {
                Console.WriteLine(year);
            }

            //  'dateTime' kann der User ueber 'day-month-year' selbst waehlen.
            DateTime dateTime = new DateTime(year, month, day);

            //  Es wird ueberprueft, um welchen Wochentag es sich beim angegebenen Tag handelt.
            Console.WriteLine("Wochentag deiner Geburt: " + dateTime.ToString("dddd"));

            // Schaltjahr? -> Year has 366 days (not 365) and February has 29 days. (not 28)
            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("It's a leap-year!");
            }
            else
            {
                Console.WriteLine("It's NOT a leap- year!");
            }
        }
    }
}


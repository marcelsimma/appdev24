
using System.Globalization;

namespace ManuelHartmann.Week04
{
    public class DifferentTIMEoutputs
    {
        public static void Start()
        {
            CurrentDate();
            CurrentTime();
            CurrentDateAndTime();
            CurrentDateAndTimeAndTimeZone();
            SecondsAndMilliSeconds();
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

            //  't' kurzes Uhrzeitformat. (ohne MS)
            Console.WriteLine("'t': " + dateTime.ToString("t"));

            //  'T' langes Uhrzeitformat. (mit MS)
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
    }
}



using System.Globalization;

namespace ManuelHartmann.Week04
{
    public class Calendar
    {
        public static void Start()
        {
            Console.WriteLine("Insert a month and year you'd like to see the calender displayed. \nFor example 'yyyy.MM'.");
            string userInputDate = Console.ReadLine();
            UserInput(userInputDate);
        }
        static void UserInput(string userInputDate)
        {
            int year = 0;
            int month = 0;

            string[] splitDate = userInputDate.Split('.');         // Split UserInput ('.').

            if (int.TryParse(splitDate[0], out year))
            {
                // Console.WriteLine(year);                        // Wandle String in Int um.
            }
            if (int.TryParse(splitDate[1], out month))
            {
                // Console.WriteLine(month);                       // Wandle String in Int um.
            }
            BuildCalendar(year, month);
        }
        static void BuildCalendar(int year, int month)
        {
            DateTime start = new DateTime(year, month, 1);          // Bestimmt den Ersten des Monats.
            int daysInMonth = DateTime.DaysInMonth(year, month);    // Anzahl Tage im Monat.
            DayOfWeek dayOfWeek = start.DayOfWeek;                  // Mit welchem Wochentag startet der Monat.
            DateTime atm = DateTime.Today;                          // Bestimmt den heutigen Tag.

            int[,] calendarList = new int[5,32];    // Array fuer die erstellung des Kalenders.
            int weeks = 0;                          // Ist die jeweilige Zeile des Arrays.
            int startTmp = 0;                       // Gibt die start Spalte des Arrays an.
            int tmp = 0;                            // Ueberpruft wie viele Eintraege bereits geschrieben wurden. -> Zeilen switch.

            if ((int)dayOfWeek == 0)
            {
                startTmp = 7;   // Kann die (int)dayOfWeek leider nicht auf '7', setzten, weil die Woche nur (int)0-6 annehmen kann.
            }
            else
            {
                startTmp = (int)dayOfWeek;
            }

            Console.Clear();
            Console.Write(start.ToString("yyyy ")); // 'yyyy' -> Gibt das Jahr vierstellig an.
            string yearMonth = new DateTime(year, month, 1).ToString("MMMM", new CultureInfo("de-AT")); // Gibt Monat auf Deutsch aus.
            Console.WriteLine(yearMonth);
            Console.WriteLine("| MO | DI | MI | DO | FR | SA | SO |");
            Console.WriteLine("+----+----+----+----+----+----+----+");

            for (int j = 0; j < startTmp - 1; j++)  // Fuellt die leeren start Eintraege des Kalenders auf.
            {
                calendarList[weeks, j] = 0;
                Console.Write("|    ");
                tmp++;  //  Merkt sich wie viele leere Eintraege bereits beruecksichtig wurden.
            }

            // for (int i = startTmp; i <= (int)daysInMonth - (int)dayOfWeek + 1; i++)
            for (int i = 1; i <= (int)daysInMonth; i++)                 // Anzahl Tage im Monat
            {
                if (tmp == 6 || tmp == 13 || tmp == 20 || tmp == 27)    // Zeilenwechsel
                {
                    if (i > 9)  // Benoetigt es 1 oder 2 Leerzeichen.
                    {
                        calendarList[weeks,i] = i;
                        Console.Write($"| {calendarList[weeks,i]} ");
                        tmp++;  // Geschriebene Eintrage++.
                    }
                    else
                    {
                        calendarList[weeks,i] = i;
                        Console.Write($"|  {calendarList[weeks,i]} ");
                        tmp++;  // Geschriebene Eintrage++.
                    }
                    Console.WriteLine("|");
                    weeks++;    // Zeilenwechsel im Array. (wird eigentlich nicht benoetigt -> Zeilenwechsel ueber tmp).
                }
                else
                {
                    if (i > 9)  // Benoetigt es 1 oder 2 Leerzeichen.
                    {
                        calendarList[weeks,i] = i;
                        Console.Write($"| {calendarList[weeks,i]} ");
                        tmp++;  // Geschriebene Eintrage++.
                    }
                    else
                    {
                        calendarList[weeks,i] = i;
                        Console.Write($"|  {calendarList[weeks,i]} ");
                        tmp++;  // Geschriebene Eintrage++.
                    }
                }
            }
            tmp = 35 - tmp;                 // Fuellt die letzten leeren Eintraege des Kalenders auf.
            for (int i = 0; i < tmp; i++)
            {
                Console.Write("|    ");
            }
            Console.Write("|");
            Console.WriteLine("\n\n");
        }
    }
}


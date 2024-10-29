
namespace ManuelHartmann.Week04
{
    public class HowManyWorkdays
    {
        public static void Start()
        {
            for (int i = 1; i < 13; i++)
            {
            getWorkdays(2024, i);
            Zeitspanne(2024, i);
            Console.WriteLine(new string('-', 50));
            }
        }
        
        //  Berechnet die Anzahl Arbeitstage im Monat.
        public static void getWorkdays(int year, int month)
        {
            DateTime dt = new DateTime(year, month, 1); //  Bestimmt den Ersten des Monats.
            int count = 0;  //  Anzahl Arbeitstage/Monat.

            while (dt.Month == month)   //  Vom 1. des Monats -> solange wir uns im selben Monat befinden.
            {
                if ((int)dt.DayOfWeek >= 1 && (int)dt.DayOfWeek <= 5)   //  Ueberprueft, ob der aktuelle Wochentag Montag-Freitag ist.
                {
                    count++;    //  Wenn Montag-Freitag -> count++;
                }
                dt = dt.AddDays(1); //  Iteriert durch alle Tage des Monats.
            }

            Console.WriteLine($"Solution:    {year}.{month} hat {count} Arbeitstage.");
        }


        //  Rechnerische Loesung der Arbeitstage im Monat.
        public static void Zeitspanne(int year, int month)
        {
            DateTime start = new DateTime(year, month, 1); // 2024.10.01
            DateTime end = start.AddMonths(1); // 2024.11.01
            TimeSpan days = end - start;
            // int daysOfMonth = DateTime.DaysInMonth(year, month);

            int counter = 0;
            int tempWorkdays = 0;
            DayOfWeek dayOfWeek = start.DayOfWeek;  //  Mit welchem Wochentag startet der Monat?
            //Console.WriteLine("1. of the month is: " + dayOfWeek);

            for (int i = (int)dayOfWeek; i < 7; i++)    //  Zaehler zur ermittlung, wie viel Tage in der angefangenen Woche noch verbleibend sind.
            {
                counter++;
            }

            //  Wie viele Tage muessen ergaenzt werden, um die angefange Woche zu beenden.
            if (counter > 1 && counter < 7) //  Monatsstart ist Montag-Freitag
            {
                counter = counter + 1;
                int temper = counter - 2;
                tempWorkdays += temper;
            }
            else if (counter == 1)  //  Monatsstart ist ein Samstag
            {
                counter = 2;
            }
            else if (counter == 7)  //  Monatsstart ist ein Sonntag
            {
                counter = 1;
            }

            // grob
            double weeks = (days.Days - counter) / 7.0; //  Berechnung wie viel Tage der Monat hat abzueglich der ersten Woche.
            double workingDays = (int)weeks * 5 + tempWorkdays; //  Arbeitstage resultierend aus Wochen. +(ergaenzung der ersten Woche)

            //  Berechnung der verbleibenden Tage (Restwert der Division)
            int weeksInt = (int)weeks;  //  Wie viel ganze Wochen.
            double weekRest = weeks - weeksInt; //  Rest der Division durch / 7
            double weekRestMulti = weekRest * 7;    //  Wie viel verbleibende Tage sind im Rest enthalten?
            double result = Math.Round(weekRestMulti);  //  Rest mathematisch runden.

            if (result < 6) //  Rest kleiner 6 -> Gesamter Rest sind Arbeitstage.
            {
                workingDays += result;
            }
            else
            {
                workingDays += result - 1;  //  Ein Tag vom Rest ist kein Arbeitstag. (Samstag)
                // DaysOff++;
            }

            //// zerlegt
            //int firstWeek = 6 - (int)start.DayOfWeek;
            //if (firstWeek > 5)
            //    firstWeek = 5;

            //int lastWeek = (int)end.AddDays(-1).DayOfWeek;
            //if (lastWeek == 6 || lastWeek == 0)
            //    lastWeek = 5;

            //int workDays = firstWeek + 15 + lastWeek;

            Console.WriteLine($"Calc result: {year}.{month} hat {(int)workingDays} Arbeitstage. 1. of Month: {start.DayOfWeek}");
            //Console.WriteLine($"{year}.{month} hat {workDays} Arbeitstage.");
            Console.WriteLine($"Information: ({year}.{month} hat {days.Days} Tage und hat {weeks} Wochen).");

        }
    }
}


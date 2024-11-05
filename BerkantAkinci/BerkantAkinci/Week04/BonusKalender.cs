using System;
using System.Globalization;
using BerkantAkinci.Week02;

namespace BerkantAkinci.Week04
{

    class BonusKalender
    {

        public static void PrintKalender(int year, int month)
        {
            DateTime heute = DateTime.Now;                                      // heutiges Datum mit der Uhrzeit
            DayOfWeek heuteMonatsTag = heute.DayOfWeek;                         // heutiges Datum in den Tag umwandeln
            CultureInfo austrian = new CultureInfo("de-AT");                    // Übersetzen auf Deutsch
            string tag = austrian.DateTimeFormat.GetDayName(heuteMonatsTag);    // Zeile 13 und 14 verknüpfen
            string heuteTagString = heute.ToString("dd");                       //  deutige Datum abgekürt nur das es die Zahl vom heutigen Tag anzeigt
            int heuteTag = Convert.ToInt32(heuteTagString);                     // den string zu einem integer konvertieren dass es auch als Zahl wahrnimmt
            DateTime monat = new DateTime(year, month, 1);
            int kalenderwoche = 22;

            int montag = Convert.ToInt32(DayOfWeek.Monday);
            int dienstag = Convert.ToInt32(DayOfWeek.Tuesday);
            int mittwoch = Convert.ToInt32(DayOfWeek.Wednesday);
            int donnerstag = Convert.ToInt32(DayOfWeek.Thursday);
            int freitag = Convert.ToInt32(DayOfWeek.Friday);
            int samstag = Convert.ToInt32(DayOfWeek.Saturday);
            int sonntag = Convert.ToInt32(DayOfWeek.Sunday);
            sonntag = 7;

            string[] tage = { "Mo", "Di", "Mi", "Do", "Fr", "Sa", "So" };

            DateTime start = new DateTime(year, month, 1);
            DateTime ende = start.AddMonths(1);
            DayOfWeek startTagString = start.DayOfWeek;

            int startTag = Convert.ToInt32(startTagString);

            TimeSpan days = ende - start;

            int counter = 0;
            int zähler = 1;

            System.Console.Write($"{year} {monat.ToString("MMMM")}\n");
            System.Console.Write("     ");

            for (int i = 0; i < tage.Length; i++)
            {
                System.Console.Write($"|{tage[i],3} ");
            }
            System.Console.Write("|");
            System.Console.Write($"\n");
            System.Console.Write($"KW{kalenderwoche} ");

            while (zähler <= days.Days)
            {
                if (startTag == 0)
                {
                    startTag = sonntag;

                    System.Console.Write("|" + "   ");
                }

                else if (counter >= startTag - 1)
                {
                    System.Console.Write($"|{zähler,3}");
                }

                else
                {
                    System.Console.Write("|" + "   ");
                }

                if (zähler == heuteTag)                     //
                {
                    System.Console.Write("*");
                }
                else { System.Console.Write(" "); }

                if (counter == sonntag - 1)
                {
                    System.Console.Write("|");
                    System.Console.Write($"\n");
                    System.Console.Write($"KW{kalenderwoche} ");
                }

                if (counter == (sonntag * 2) - 1)
                {
                    System.Console.Write("|");
                    System.Console.Write($"\n");
                    System.Console.Write($"KW{kalenderwoche} ");
                }

                if (counter == (sonntag * 3) - 1)
                {
                    System.Console.Write("|");
                    System.Console.Write($"\n");
                    System.Console.Write($"KW{kalenderwoche} ");
                }

                if (counter == (sonntag * 4) - 1)
                {
                    System.Console.Write("|");
                    System.Console.Write($"\n");
                    System.Console.Write($"KW{kalenderwoche} ");
                }
                if (counter == (sonntag * 5) - 1)
                {
                    System.Console.Write("|");
                    System.Console.Write($"\n");
                    System.Console.Write($"KW{kalenderwoche} ");
                }

                if (counter == (sonntag * 6) - 1)
                {
                    System.Console.Write("|");
                    System.Console.Write($"\n");
                    System.Console.Write($"KW{kalenderwoche} "); ;

                }

                if (counter >= startTag - 1)
                {
                    zähler++;
                }

                counter++;

                if (zähler > days.Days)
                {
                    System.Console.Write("|");
                }
            }
        }
    }
}
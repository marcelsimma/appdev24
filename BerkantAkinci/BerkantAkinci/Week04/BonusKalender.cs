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
            string JahrMonat = heute.ToString("yyyy MMMM");                     // jetziges Jahr und jetziger Monat ausgeschrieben 
            string heuteTagString = heute.ToString("dd");                       //  deutige Datum abgekürt nur das es die Zahl vom heutigen Tag anzeigt
            int heuteTag = Convert.ToInt32(heuteTagString);                     // den string zu einem integer konvertieren dass es auch als Zahl wahrnimmt

            int montag = Convert.ToInt32(DayOfWeek.Monday);
            int dienstag = Convert.ToInt32(DayOfWeek.Tuesday);
            int mittwoch = Convert.ToInt32(DayOfWeek.Wednesday);
            int donnerstag = Convert.ToInt32(DayOfWeek.Thursday);
            int freitag = Convert.ToInt32(DayOfWeek.Friday);
            int samstag = Convert.ToInt32(DayOfWeek.Saturday);
            int sonntag = Convert.ToInt32(DayOfWeek.Sunday);
            sonntag = 7;

            string[] tage = { "Mo", "Di", "Mi", "Do", "Fr", "Sa", "So" };

            System.Console.WriteLine(JahrMonat);

            for (int i = 0; i < tage.Length; i++)
            {
                System.Console.Write($"|{tage[i],3} ");
            }
            System.Console.Write("|");
            System.Console.WriteLine();
            //System.Console.WriteLine($"|{montag,3} |{dienstag,3} |{mittwoch,3} |{donnerstag,3} |{freitag,3} |{samstag,3} |{sonntag,3} |");

            DateTime start = new DateTime(year, month, 1);
            DateTime ende = start.AddMonths(1);
            DayOfWeek startTagString = start.DayOfWeek;

            int startTag = Convert.ToInt32(startTagString);

            TimeSpan days = ende - start;

            for (int i = 0; i <= days.Days; i++)
            {

                if (startTag -1  > i )
                {
                    System.Console.Write("|" + "   ");
                }
                else
                {
                    System.Console.Write($"|{i,3}");
                }

                if (i == heuteTag)
                {
                    System.Console.Write("*");
                }
                else { System.Console.Write(" "); }

                if (i == 6)
                {
                    System.Console.Write("|");
                    System.Console.Write($"\n");
                }

                if (i == 13)
                {
                    System.Console.Write("|");
                    System.Console.Write($"\n");
                }

                if (i == 20)
                {
                    System.Console.Write("|");
                    System.Console.Write($"\n");
                }

                if (i == 27)
                {
                    System.Console.Write("|");
                    System.Console.Write($"\n");
                }

                if (i == 31)
                {
                    System.Console.Write("|");
                }
            }
        }
    }
}
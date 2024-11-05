using System;

namespace MarcelSimma.week05
{
    public class Calendar
    {
        public void Start()
        {

            // Offizielle DateTime Dokumentation: https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=netframework-4.8


            // Erstellt ein neues DateTime-Objekt, dass ein angegebenes Datum speichert:
            DateTime specificDate = new DateTime(2023, 11, 04);
            //               Konstruktor Werte: (Jahr, Monat, Tag)
            Console.WriteLine(specificDate.ToString());

            // Erstellt ein neues DateTime-Objekt, dass ein angegebens Datum und eine Uhrzeit speichert:
            DateTime specificDateAndTime = new DateTime(2023, 11, 04, 14, 30, 00);
            //                      Konstruktor Werte: (Jahr, Monat, Tag, Stunde, Minute, Sekunde)
            Console.WriteLine(specificDateAndTime.ToString());

            // Das heutige Datum zum Zeitpunkt der Programmausführung
            DateTime nowDateAndTime = DateTime.Now;
            Console.WriteLine(nowDateAndTime.ToString());


            // Nur das heutige Datum (Zeit auf Mitternacht 00:00:00 gesetzt) mit DateTime.Today:
            DateTime todayDateAndTime = DateTime.Today;
            Console.WriteLine(todayDateAndTime.ToString());

        }

    }
}
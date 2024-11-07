using System;
using System.IO;

namespace ConsoleApp1.Week05
{
    /*  Erstelle ein Programm, dass alle Ordner und Dateien in einem bestimmten Verzeichnis auf deiner Festplatte 
        auf der Konsole ausgibt. Ist in deinem Verzeichnis ein Ordner enthalten, so gib zusätzlich dessen Inhalt ebenfalls 
        auf der Console aus. Gib weiters die Anzahl der Dateien und die Anzahl der Ordner aus.

        Auslesen der Unterverzeichnisse wurde mithilfe rekrusive Suche gestalltet. 
        Anzahl Unterverzeichnisse = Anzahl Schleifendurchlaeufe.                                                             */
    public static class FolderContent
    {
        public static void Start()
        {
            // Pfad nach belieben anpassen.
            string verzeichnisPfad = @"C:\Users\harmanu\Downloads\DigitalCampus\Test";  // Mit dem '@' vor dem String werden die '\' genommen.

            DefinePath(verzeichnisPfad);
        }
        public static void DefinePath(string verzeichnisPfad)
        {
            if (Directory.Exists(verzeichnisPfad))  // Ueberpruefung, ob der Pfad exisiert.
            {
                int ordnerAnzahl = 0;   // Zaehler.
                int dateienAnzahl = 0;  // Zaehler.

                Console.WriteLine("Inhalt des Verzeichnisses:\n");

                // Methode zur Ausgabe der Verzeichnisstruktur
                DurchsucheVerzeichnis(verzeichnisPfad, ref ordnerAnzahl, ref dateienAnzahl);

                Console.WriteLine();
                Console.WriteLine($"Anzahl der Ordner: {ordnerAnzahl}");
                Console.WriteLine($"Anzahl der Dateien: {dateienAnzahl}");
            }
            else
            {
                Console.WriteLine("Das angegebene Verzeichnis existiert nicht.");
            }
        }
        // Das 'ref int' wird benoetigt um Aenderungen der Variabel beim rekursive Aufruf mitzunehmen.
        static void DurchsucheVerzeichnis(string pfad, ref int ordnerAnzahl, ref int dateienAnzahl)
        {
            try
            {
                // Ordner ausgeben
                string[] ordner = Directory.GetDirectories(pfad);   // Suche nach Ordner
                foreach (string ordnerPfad in ordner)
                {
                    ordnerAnzahl++;
                    Console.WriteLine($"Ordner: {ordnerPfad}"); // Hierbei wird der OrdnerName mit dem gesamten Pfad angegeben.

                    // String anpassung koennte auch mit 'ordnerPfad.Substring()' gemacht werden. (nicht dynamisch)
                    string[] tmp = ordnerPfad.Split('\\');      // Hierbei wird nur der OrdnerName, ohne Pfad angegeben.
                    Console.WriteLine($"Ordner: {tmp[tmp.Length-1]}");

                    // Rekursive Suche in Unterverzeichnissen (Methode wird erneut mit mitgegebenen Variablen aufgerufen)
                    // Schleifendurchgaegnge = Anzahl Unterverzeichnisse
                    DurchsucheVerzeichnis(ordnerPfad, ref ordnerAnzahl, ref dateienAnzahl);
                }

                // Dateien ausgeben
                string[] dateien = Directory.GetFiles(pfad);    // Suche nach Dateien
                foreach (string dateiPfad in dateien)
                {
                    dateienAnzahl++;
                    Console.WriteLine($"Datei: {dateiPfad}");   // Hierbei wird der DateiName mit dem gesamten Pfad angegeben.

                    // String anpassung koennte auch mit 'ordnerPfad.Substring()' gemacht werden. (nicht dynamisch)
                    string[] tmp1 = dateiPfad.Split('\\');      // Hierbei wird nur der DateiName, ohne Pfad angegeben.
                    Console.WriteLine($"Ordner: {tmp1[tmp1.Length - 1]}");
                }
            }
            // Fehlerhandling -> Kein Zugriff auf Pfad/Laufwerk oder noch unbekannter Fehler.
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine($"Zugriff verweigert auf: {pfad} ({e.Message})");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ein Fehler ist aufgetreten: {e.Message}");
            }
        }
    }
}

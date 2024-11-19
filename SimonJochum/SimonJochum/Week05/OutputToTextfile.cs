using System;
using System.IO;

namespace SimonJochum.Week05
{
    public class OutputToTextfile
{
    public static void Start()
    {
        // Öffnen der Eingabedatei 'input.txt' zum Lesen
        using (StreamReader reader = new StreamReader("C:/Users/SIJO/Documents/Testaufgaben/input.txt"))
        {
            // Öffnen der Ausgabedatei 'output.txt' zum Schreiben
            using (StreamWriter writer = new StreamWriter(@"C:\Users\SIJO\Documents\Testaufgaben\output.txt"))
            {
                // Liest die erste Zeile der Datei (Kopfzeile) und speichert sie in 'headline'
                string headline = reader.ReadLine();
                
                // Liest den gesamten restlichen Inhalt der Datei und speichert ihn in 'inputRaw'
                string inputRaw = reader.ReadToEnd();
                
                // Teilt den gesamten Inhalt in einzelne Zeilen basierend auf Zeilenumbrüchen '\n'
                string[] input = inputRaw.Split('\n', StringSplitOptions.None);
                
                // Zähler für die Anzahl der Teilnehmer
                int count = 0;

                // Schreibt die Kopfzeile in die Ausgabedatei
                writer.WriteLine(headline + "\n");

                // Iteriert durch jede Zeile im Array 'input' und schreibt sie mit einer Nummerierung in die Ausgabedatei
                foreach (string inp in input)
                {
                    count++; // Erhöht den Zähler für jede Zeile
                    writer.WriteLine($"Nr.{count} {inp}"); // Schreibt die Zeile mit der fortlaufenden Nummerierung
                }

                // Schreibt die Gesamtzahl der Teilnehmer in die Ausgabedatei
                writer.WriteLine($"Es sind {count} Teilnehmer auf der Liste.");
            }
        }
    }
}

}
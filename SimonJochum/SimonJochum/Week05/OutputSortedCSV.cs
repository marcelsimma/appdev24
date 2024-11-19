using System;
using System.IO;

namespace SimonJochum.Week05
{
   public class OutputSortedCSV
{
    public static void Start()
    {
        // Öffnen der ersten Eingabedatei (Menge, Preis, Bezeichnung) zum Lesen
        using StreamReader reader1 = new StreamReader("C:/Users/SIJO/Documents/Testaufgaben/input1.csv");
        // Öffnen der zweiten Eingabedatei (Preis, Bezeichnung, Menge) zum Lesen
        using StreamReader reader2 = new StreamReader("C:/Users/SIJO/Documents/Testaufgaben/input2.csv");
        // Öffnen der Ausgabedatei (output.csv) zum Schreiben
        using StreamWriter writer = new StreamWriter("C:/Users/SIJO/Documents/Testaufgaben/output.csv");

        // Liest die Header-Zeile der ersten Datei und zerlegt sie anhand des Trennzeichens ';'
        string inputHeader = reader1.ReadLine();
        string[] inputHeaderParts = inputHeader.Split(new[] { ';' }, StringSplitOptions.TrimEntries);

        // Liest die Header-Zeile der zweiten Datei (obwohl sie nicht genutzt wird) 
        string headlineToRemove = reader2.ReadLine();

        // Schreibt den neuen Header in die Ausgabedatei:
        // Der Header wird umgekehrt und formatiert
        writer.WriteLine(string.Format("{0, 1}; {1, 1}; {2,1}", inputHeaderParts[2], inputHeaderParts[1], inputHeaderParts[0]));

        // Liest die Zeilen der ersten Eingabedatei und verarbeitet sie
        string input1Raw;
        while ((input1Raw = reader1.ReadLine()) != null)
        {
            // Zerlegt jede Zeile der ersten Datei anhand des Trennzeichens ';'
            string[] parts1 = input1Raw.Split(new[] { ';' }, StringSplitOptions.TrimEntries);

            // Überprüft, ob die Zeile genau 3 Teile enthält (Menge, Preis, Bezeichnung)
            if (parts1.Length == 3)
            {
                // Schreibt die formatierten Daten (Menge, Preis, Bezeichnung) in die Ausgabedatei
                writer.WriteLine(string.Format("{0, 1}; {1, 1}; {2,1}", parts1[2], parts1[1], parts1[0]));
            }
        }

        // Liest die Zeilen der zweiten Eingabedatei und verarbeitet sie
        string input2Raw;
        while ((input2Raw = reader2.ReadLine()) != null)
        {
            // Zerlegt jede Zeile der zweiten Datei anhand des Trennzeichens ';'
            string[] parts2 = input2Raw.Split(new[] { ';' }, StringSplitOptions.TrimEntries);

            // Überprüft, ob die Zeile genau 3 Teile enthält (Preis, Bezeichnung, Menge)
            if (parts2.Length == 3)
            {
                // Schreibt die formatierten Daten (Menge, Preis, Bezeichnung) in die Ausgabedatei
                writer.WriteLine(string.Format("{0, 1}; {1, 1}; {2,1}", parts2[1], parts2[0], parts2[2]));
            }
        }
    }
}

}
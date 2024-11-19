using System;
using System.IO;

namespace SimonJochum.Week05
{
    public class OutputFormatedTextfile
{
    public static void Start()
    {
        // Öffnet die Eingabedatei zum Lesen
        using (StreamReader reader = new StreamReader("C:/Users/SIJO/Documents/Testaufgaben/inputnotformated.txt"))
        {
            // Öffnet die Ausgabedatei zum Schreiben
            using (StreamWriter writer = new StreamWriter(@"C:\Users\SIJO\Documents\Testaufgaben\outputformated.txt"))
            { 
                // Liest die erste Zeile (Header) der Eingabedatei
                string header = reader.ReadLine();

                // Zerlegt die Header-Zeile in ihre Teile (die durch Leerzeichen getrennt sind)
                string[] headerParts = header.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                // Schreibt den formatierten Header in die Ausgabedatei, mit breiten Spalten und einer Trennlinie
                writer.WriteLine(string.Format("{0, -9} | {1, -6} | {2, -1} ", 
                    headerParts[0], headerParts[1], headerParts[2]) + " |");

                // Fügt eine horizontale Trennlinie nach dem Header hinzu
                writer.WriteLine(new string('-', 30));

                // Liest jede Zeile der Eingabedatei
                string inputRaw;
                while ((inputRaw = reader.ReadLine()) != null)
                {
                    // Zerlegt die aktuelle Zeile in ihre Teile, die durch Leerzeichen getrennt sind
                    string[] parts = inputRaw.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    // Überprüft, ob die Zeile genau 3 Teile enthält (Name, Größe und Alter)
                    if (parts.Length == 3)
                    {
                        // Versucht, die Größe (double) und das Alter (int) in die entsprechenden Datentypen umzuwandeln
                        if (double.TryParse(parts[1], out double size) && int.TryParse(parts[2], out int age))
                        { 
                            // Schreibt die formatierten Werte in die Ausgabedatei:
                            // Name, Größe (mit 2 Dezimalstellen) und Alter (mit 5 Zeichen) werden ausgerichtet
                            writer.WriteLine(string.Format("{0, -10} | {1, -5:N2} | {2, 5} ", 
                                parts[0], size, age) + " |\n" + new string('-', 30));
                        }
                        else
                        {
                            // Wenn die Größe oder das Alter ungültig sind, wird eine Fehlermeldung geschrieben
                            writer.WriteLine("Fehlerhafte Daten: " + inputRaw);
                        }
                    }
                    else
                    {
                        // Wenn die Zeile nicht 3 Teile hat (Name, Größe, Alter), wird eine Fehlermeldung geschrieben
                        writer.WriteLine("Fehlerhafte Zeile: " + inputRaw);
                    }
                }
            }
        }
    }
}

}
using System;
using System.IO;

namespace SimonJochum.Week05
{
    public class OutputToTextfileCalculation
{
    // Methode zum Berechnen und Schreiben der Quadrate der Zahlen aus der Datei
    public static void Start()
    {
        // Öffnen der Eingabedatei 'inputcalc.txt' zum Lesen
        using (StreamReader reader = new StreamReader("C:/Users/SIJO/Documents/Testaufgaben/inputcalc.txt"))
        {
            // Öffnen der Ausgabedatei 'outputcalc.txt' zum Schreiben
            using (StreamWriter writer = new StreamWriter(@"C:\Users\SIJO\Documents\Testaufgaben\outputcalc.txt"))
            {
                // Liest den gesamten Inhalt der Datei und speichert ihn in 'inputRaw'
                string inputRaw = reader.ReadToEnd();
                
                // Teilt den gesamten Inhalt der Datei in einzelne Zeilen basierend auf Zeilenumbrüchen
                string[] input = inputRaw.Split('\n', StringSplitOptions.RemoveEmptyEntries);

                // Iteriert über jede Zeile in der Eingabedatei
                for (int i = 0; i < input.Length; i++)
                {
                    // Versucht, die Zahl in der aktuellen Zeile in einen Integer umzuwandeln
                    int inputDigit = Convert.ToInt32(input[i]);
                    
                    // Berechnet das Quadrat der Zahl
                    int outputDigit = inputDigit * inputDigit;
                    
                    // Schreibt das Ergebnis (Quadrat der Zahl) in die Ausgabedatei
                    writer.WriteLine("Das Quadrat von " + inputDigit + " = " + outputDigit);
                }
            }
        }
    }

    // Alternative Methode zum Berechnen und Schreiben der Quadrate der Zahlen mit Fehlerbehandlung
    public static void Start2()
    {
        // Öffnen der Eingabedatei 'inputcalc.txt' zum Lesen
        using (StreamReader reader = new StreamReader("C:/Users/SIJO/Documents/Testaufgaben/inputcalc.txt"))
        {
            // Öffnen der Ausgabedatei 'outputcalc.txt' zum Schreiben
            using (StreamWriter writer = new StreamWriter(@"C:\Users\SIJO\Documents\Testaufgaben\outputcalc.txt"))
            {
                // Liest die Datei Zeile für Zeile
                string inputRaw;
                while ((inputRaw = reader.ReadLine()) != null)
                {
                    // Versucht, die Zahl in der aktuellen Zeile in einen Integer umzuwandeln
                    if (int.TryParse(inputRaw, out int inputDigit))
                    {
                        // Berechnet das Quadrat der Zahl
                        int outputDigit = inputDigit * inputDigit;
                        
                        // Schreibt das Ergebnis (Quadrat der Zahl) in die Ausgabedatei
                        writer.WriteLine("Das Quadrat von " + inputDigit + " = " + outputDigit);
                    }
                    else
                    {
                        // Falls die Eingabe keine gültige Zahl war, wird eine Fehlermeldung in die Ausgabedatei geschrieben
                        writer.WriteLine("Ungültige Eingabe: " + inputRaw);
                    }
                }
            }
        }
    }
}

}

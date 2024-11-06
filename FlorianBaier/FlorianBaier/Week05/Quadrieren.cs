using System;
using System.IO;

namespace FlorianBaier.Week05
{

    public static class Quadrieren
    {

        public static void Start()
        {
            string inputFile = "/Users/flori/Desktop/DigitalCampus/inputNumbers.txt";
            string outputFile = "/Users/flori/Desktop/DigitalCampus/outputNumbers.txt";

            string[] lines = File.ReadAllLines(inputFile);

            using (StreamWriter writer = new StreamWriter(outputFile))
            {
                foreach (string line in lines)
                {
                    // Versuche, die Zeile in eine Zahl zu konvertieren
                    if (int.TryParse(line.Trim(), out int number))
                    {
                        // Berechnung
                        int square = number * number;
                        // Rechenweg und das Ergebnis in die Ausgabedatei
                        writer.WriteLine($"{number}^2 = {square}");
                    }
                    else
                    {
                        Console.WriteLine($"Ungültiger Wert in der Eingabedatei: {line}");
                    }
                }
            }

            Console.WriteLine("Die Berechnungen wurden in 'Output.txt' geschrieben.");
        }

    }
}
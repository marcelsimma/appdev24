using System;
using System.IO;

namespace FlorianBaier.Week05
{

    public static class Formatierung
    {

        public static void Start()
        {
            ReadFile();
        }
        public static void ReadFile()
        {

            string inputFilePath = "/Users/flori/Desktop/DigitalCampus/inputData.txt";
            string outputFilePath = "/Users/flori/Desktop/DigitalCampus/outputData.txt";

            // Verwende StreamReader, um die Eingabedatei zu lesen
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                // Liste, um die formatierten Zeilen zu speichern
                var formattedLines = new List<string>();

                // Lese die Kopfzeile
                string headerLine = reader.ReadLine();
                var headers = headerLine.Split(' ');

                // Formatierte Kopfzeile hinzufügen
                formattedLines.Add($"{headers[0],-12}| {headers[1],-8}| {headers[2],-5}|");
                formattedLines.Add(new string('-', 30)); // Trennlinie

                // Lese alle weiteren Datenzeilen
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split(' ');

                    string name = parts[0];
                    double size = double.Parse(parts[1]);
                    int age = int.Parse(parts[2]);

                    // Formatierte Datenzeile erstellen
                    formattedLines.Add($"{name, -12}| {size, -8:F2}| {age, 5}|");
                    formattedLines.Add(new string('-', 30));  // Trennlinie
                }

                // Schreibe die formatierten Zeilen in die Ausgabedatei mit StreamWriter
                using (StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    foreach (var formattedLine in formattedLines)
                    {
                        writer.WriteLine(formattedLine);
                    }
                }
            }
        }
    }
}
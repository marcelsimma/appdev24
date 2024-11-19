using System;
using System.IO;

namespace SimonJochum.Week05
{
    public class OutputTextfile
{
    public static void Start()
    {
        // Öffnen der Eingabedatei 'input.txt' zum Lesen
        using (StreamReader reader = new StreamReader("C:/Users/SIJO/Documents/Testaufgaben/input.txt"))
        {
            // Liest die erste Zeile der Datei, die als Header dient
            string headline = reader.ReadLine();
            
            // Liest den gesamten restlichen Inhalt der Datei als einen einzigen String
            string inputRaw = reader.ReadToEnd();
            
            // Teilt den gesamten Text in einzelne Zeilen, basierend auf dem Zeilenumbruch '\n'
            string[] input = inputRaw.Split('\n', StringSplitOptions.None);
            
            // Zähler für die Zeilen
            int count = 1;

            // Gibt die Header-Zeile in der Konsole aus
            Console.WriteLine(headline);

            // Iteriert durch jede Zeile im Array 'input' und gibt sie mit der Zeilennummer aus
            foreach (string inp in input)
            {
                // Ausgabe der Zeile mit der Zeilennummer
                Console.WriteLine($"Nr.{count} {inp}");
                
                // Erhöht den Zähler
                count++;
            }
        }
    }
}

}
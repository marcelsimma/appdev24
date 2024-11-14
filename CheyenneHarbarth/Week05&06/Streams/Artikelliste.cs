using System;

namespace CheyenneHarbarth.Week05.Streams
{
    class Artikelliste
    {
        public static void Start()
        {
            using (StreamReader str = new StreamReader("/Users/BAU28365/Documents/Artikelliste.txt"))
            {
                string[] Liste = new string[30];
                for (int i = 0; i < 30; i++)
                {
                    Liste[i] = str.ReadLine();
                    Console.WriteLine(Liste[i]);
                }

                /* string outputFile = "Listeformatiert.txt";

                // Lies die Eingabedatei
                string[] lines = File.ReadAllLines(inputFile);

                // Öffne die Ausgabedatei
                using (StreamWriter stro = new StreamWriter(outputFile))
                {
                    stro.WriteLine("Teilnehmer  |  Größe   | Alter");
                    stro.WriteLine("--------------------------------");

                    // Iteriere durch jede Zeile der Eingabedatei
                    foreach (var line in lines)
                    {
                        var parts = line.Split(' ');                //Teile die Zeile anhand von den gewünschten Markierungen, hier sind es ja Leerzeichen

                        string teilnehmer = parts[0];
                        string groesse = double.Parse(parts[1]).ToString("F2");
                        string alter = parts[2];

                        // Schreibe die formatierte Zeile in die Ausgabedatei
                        stro.WriteLine($"{teilnehmer,-11} | {groesse,7} | {int.Parse(alter),6}");
                        stro.WriteLine("--------------------------------");
                    }
                }
                Console.WriteLine("Die Daten wurden erfolgreich in die Output-Datei geschrieben.");*/
            } 
        }
    }
}
using System;
using System.Diagnostics.Metrics;
using System.IO;                //IO = Input Output
using System.Linq;

namespace CheyenneHarbarth.Week05.Streams
{

    public class Streams
    {

        public static void Aufgabe1()
        {
            using (StreamReader str = new StreamReader("/Users/BAU28365/Documents/input.txt"))                         //mit using () gibst du dem Programm eine Resource mit der dann nur aktiv er in diesem Moment arbeitet, niemand sonst kann diese Datei dann momentan verwenden
            {
                string FirstRow = str.ReadLine();
                int counter = 1;

                while (counter < 12)
                {
                    string Names = str.ReadLine();
                    Console.WriteLine($"{counter,3}. {Names}");
                    counter++;
                }
            }
        }

        public static void Aufgabe2()
        {
            using (StreamReader str = new StreamReader("/Users/BAU28365/Documents/input.txt"))                         //mit using () gibst du dem Programm eine Resource mit der dann nur aktiv er in diesem Moment arbeitet, niemand sonst kann diese Datei dann momentan verwenden
            {
                string FirstRow = str.ReadLine();
                int counter = 0;
                string[] Names = new string[12];

                for (int i = 0; i < 11; i++)
                {
                    Names[i] = str.ReadLine();
                    counter++;
                    Console.WriteLine($"{counter,3}. {Names[i]}");
                }

                using (StreamWriter stro = new StreamWriter("/Users/BAU28365/Documents/output.txt"))
                {
                    for (int j = 0; j < 11; j++)
                    {
                        stro.WriteLine($"{j + 1,3}. {Names[j]}");

                    }
                    stro.WriteLine($"{counter} Teilnehmer");
                }
            }
            Console.WriteLine("fertig");
        }

        public static void Aufgabe3()           //Quadrieren
        {
            using (StreamReader str = new StreamReader("/Users/BAU28365/Documents/numbers.txt"))
            {
                int a = Convert.ToInt32(str.ReadLine());
                int b = Convert.ToInt32(str.ReadLine());
                int c = Convert.ToInt32(str.ReadLine());
                int d = Convert.ToInt32(str.ReadLine());
                int e = Convert.ToInt32(str.ReadLine());



                using (StreamWriter stro = new StreamWriter("/Users/BAU28365/Documents/results.txt"))
                {
                    int f = a * a;
                    int g = b * b;
                    int h = c * c;
                    int i = d * d;
                    int j = e * e;

                    stro.WriteLine(f + " = " + a + " * " + a);
                    stro.WriteLine($"{g} = {b} * {b}");
                    stro.WriteLine($"{h} = {c} * {c}");
                    stro.WriteLine(i + " = " + d + " * " + d);
                    stro.WriteLine(j + " = " + e + " * " + e);
                }
            }
            Console.WriteLine("fertig");
        }

        public static void Aufgabe4()
        {
            string inputFile = "Liste.txt";
            string outputFile = "Listeformatiert.txt";

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
            Console.WriteLine("Die Daten wurden erfolgreich in die Output-Datei geschrieben.");
        }
    }
}
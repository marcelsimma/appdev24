using System;
using System.IO;

namespace FlorianBaier.Week05
{

    public static class Teilnehmerliste2
    {

        public static void Start()
        {

            // Den Inhalt der Datei "input.txt" einlesen
            string[] participants = File.ReadAllLines("/Users/flori/Desktop/DigitalCampus/input.txt");

            // Die Anzahl der Teilnehmer berechnen (alle Zeilen außer der ersten Zeile)
            int participantCount = participants.Length - 1;

            // Output-Datei vorbereiten
            using (StreamWriter writer = new StreamWriter("/Users/flori/Desktop/DigitalCampus/output.txt"))
            {
                // Die erste Zeile (Teilnehmer) wird direkt geschrieben
                writer.WriteLine(participants[0] + "\n");

                // Für alle Teilnehmer ab der zweiten Zeile
                for (int i = 1; i < participants.Length; i++)
                {
                    // Entferne übrige führende/abschließende Leerzeichen
                    string name = participants[i].Trim();

                    if (!string.IsNullOrEmpty(name)) // Sicherstellen, dass der Name nicht leer ist
                    {
                        // Schreibe die fortlaufende Nummerierung und den Namen in die Datei
                        writer.WriteLine($"{i}. {name}");
                    }
                }

                writer.WriteLine();

                // Schreibe die Anzahl der Teilnehmer in die letzte Zeile
                writer.WriteLine($"Es sind {participantCount} Teilnehmer");
            }

            Console.WriteLine("Die Teilnehmerliste wurde erfolgreich erstellt und gespeichert.");

        }
    }
}
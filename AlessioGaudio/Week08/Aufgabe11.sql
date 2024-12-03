[Abteilung/Prozess]
[Titel des Dokuments]
REV 000

	Verfasser:	[Nachname Vorname]
Datum:	[YYYY-MM-DD]

using System;
using System.Collections.Generic;

namespace Lernenn
{
    public class Bücherreii
    {
        public static void Start()
        {
            List<Buch> buecher = new List<Buch>();
            string name = "Benutzer";

            Console.WriteLine($"Willkommen in der Bibliothek, {name}!");
            Console.WriteLine("Dies ist Ihre Bibliothek. Sie können Bücher hinzufü-gen, anzeigen oder löschen.");

            while (true)
            {
                Console.WriteLine("Wählen Sie eine Funktion durch Eingabe des Buch-stabens:");
                Console.WriteLine("a. Buch hinzufügen");
                Console.WriteLine("b. Alle Bücher anzeigen");
                Console.WriteLine("c. Buch löschen");
                Console.WriteLine("d. Beenden");

                string eingabe = Console.ReadLine().ToLower();

                if (eingabe == "a")
                {
                    Console.Write("Titel des Buches: ");
                    string titel = Console.ReadLine();

                    Console.Write("Autor des Buches: ");
                    string autor = Console.ReadLine();

                    Console.Write("ISBN des Buches: ");
                    string isbn = Console.ReadLine();

                    Buch neuesBuch = new Buch { Titel = titel, Autor = autor, ISBN = isbn };
                    buecher.Add(neuesBuch);
                    Console.WriteLine($"Buch \"{titel}\" wurde hinzugefügt.");
                }
                else if (eingabe == "b")
                {
                    Console.WriteLine("Alle Bücher in der Bibliothek:");
                    foreach (var buch in buecher)
                    {
                        Console.WriteLine(buch);
                    }
                }
                else if (eingabe == "c")
                {
                    Console.Write("Geben Sie die ISBN des zu löschenden Buches ein: ");
                    string isbnToDelete = Console.ReadLine();

                    Buch buchToRemove = buecher.Find(b => b.ISBN == isbnToDelete);
                    if (buchToRemove != null)
                    {
                        buecher.Remove(buchToRemove);
                        Console.WriteLine($"Buch mit ISBN {isbnToDelete} wurde gelöscht.");
                    }
                    else
                    {
                        Console.WriteLine("Fehler! Kein Buch mit dieser ISBN gefun-den.");
                    }
                }
                else if (eingabe == "d")
                {
                    Console.WriteLine("Programm wird beendet...");
                    break;
                }
                else
                {
                    Console.WriteLine("Fehler! Ungültige Eingabe. Bitte wählen Sie eine der Optionen.");
                }
            }
        }
    }

    public class Buch
    {
        public string Titel;
        public string Autor;
        public string ISBN;

        public string ToString()
        {
            return $"Titel: {Titel}, Autor: {Autor}, ISBN: {ISBN}";
        }
    }
}


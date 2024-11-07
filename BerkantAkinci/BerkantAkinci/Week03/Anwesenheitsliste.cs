using System;
using System.Runtime.InteropServices;

namespace BerkantAkinci.Week03
{

    class Anwesenheitsliste
    {
        public static void PrintAnwesenheitsliste()
        {
            Name();
        }

        public static void Name()
        {
            string[][] teilnehmer = new string[14][];

            System.Console.WriteLine("Anwesenheitsliste:\n");


            // Schritt 1: Alle Namen erfassen
            for (int i = 0; i <= teilnehmer.Length - 1; i++)
            {
                Console.Write("Name: ");
                teilnehmer[i] = new string[] { Console.ReadLine() };
            }


            // Schritt 2: Abwesenheit erfassen
            while (true) {
                Console.WriteLine("Abwesenheit hinzufügen? y/n");

                string input = Console.ReadLine();

                if (input == "y") {
                    string person = Console.ReadLine();
                    for (int i = 0; i < teilnehmer.Length; i++) {
                        if (teilnehmer[i][0] == person) {
                            Console.WriteLine("Bitte gib den Fehlgrund ein.");
                            string reason = Console.ReadLine();

                            string[] teilnehmerRecord = teilnehmer[i];

                            Array.Resize(ref teilnehmerRecord, teilnehmer[i].Length + 1);

                            teilnehmerRecord[teilnehmerRecord.Length-1] = reason;

                            teilnehmer[i] = teilnehmerRecord;

                            Console.WriteLine("Fehlzeit erfasst.");

                        }
                    }

                } else {
                    break;
                }
            }

            foreach(string[] tn in teilnehmer) {
                foreach(string info in tn) {
                    Console.Write(info + " ");
                }
                Console.WriteLine();
            }
        }

    }
}


//Lösung vom Lehrer
/*public static void Start()
{
    // Grundlage: Teilnehmerliste
    string[] teilnehmer = new string[2];
    teilnehmer[0] = "Stefan";
    teilnehmer[1] = "Manuel";

    // 2-dimensional mit Teilnehmer+Abwesenheiten ----
    // Name in erster Spalte
    string[][] teilnehmerAbwesenheiten = new string[2][];
    teilnehmerAbwesenheiten[0] = new string[] { "Stefan", "15.10." };
    teilnehmerAbwesenheiten[1] = new string[] { "Manuel" };
    Print("Abwesenheiten", teilnehmerAbwesenheiten);
    Console.WriteLine("--------------------");

    // Ergänze Abwesenheit (Prinzip) ----
    teilnehmerAbwesenheiten[1] = new string[] { "Manuel", "17.10." };
    Print("Abwesenheiten", teilnehmerAbwesenheiten);
    Console.WriteLine("--------------------");

    // Ergänze Abwesenheit ----
    string[] abwesenheiten = teilnehmerAbwesenheiten[1];
    // Array verlängern
    Array.Resize(ref abwesenheiten, abwesenheiten.Length + 1);
    // Resultat: neue Länge 3
    // befülle Abwesenheit
    abwesenheiten[abwesenheiten.Length - 1] = "24.10.";
    // speichere erweitertes Array in Gesamtliste
    teilnehmerAbwesenheiten[1] = abwesenheiten;
    Print("Abwesenheiten", teilnehmerAbwesenheiten);
    Console.WriteLine("--------------------");
}

public static void Print(string title, string[][] array)
{
    Console.WriteLine($"{title}:");

    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array[i].Length; j++)
        {
            Console.Write(array[i][j] + " | ");
        }
        Console.WriteLine();
    }
}*/
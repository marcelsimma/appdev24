using System;

namespace OliverBedogg.Week02
{

    public class Abwesenheiten
    {
        public static void Start()
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
        }
    }
}
using System;

namespace AlessioGaudio.Week02
{
    class Einkaufszettell
    {
        public static void Start()
        {
            string einkaufsListe = "";
            int elementeAnzahl = 0;

            Console.WriteLine("Willkommen zur Einkaufsliste!");

            while (true)
            {
                Console.Write("Bitte gib ein Element für die Einkaufsliste ein (oder 'fertig', um zu beenden): ");
                string element =Console.ReadLine();

                if (element.ToLower() == "fertig")
                {
                    break;
                }

                Console.Write("Bitte gib die Menge für das Element ein: ");
                string mengeEingabe = Console.ReadLine();

                if (int.TryParse(mengeEingabe, out int menge))
                {
                   einkaufsListe += string.Format("{0,10} {1}\n", menge, element);

                    elementeAnzahl++;
                }
                else
                {
                    Console.WriteLine("Ungültige Menge. Bitte eine Zahl eingeben.");
                }
            }

            if (elementeAnzahl > 0)
            {
                Console.WriteLine("\nDeine Einkaufsliste:");
                Console.WriteLine(einkaufsListe);
                Console.WriteLine("-------------------");
                Console.WriteLine($"{elementeAnzahl} Elemente auf der Liste");
            }
            else
            {
                Console.WriteLine("Die Einkaufsliste ist leer.");
            }
        }
    }
}

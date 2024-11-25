using System.Runtime.Intrinsics.Arm;

namespace FatmanurKeles.Week06
{
    public class Bankomat
    {
        public static void Start()
        {


            while (true)
            {
                Console.WriteLine("Folgende Funktionen stehen zur Verfügung\n");
                Console.WriteLine("a. Geld einzahlen");
                Console.WriteLine("b. Geld abheben");
                Console.WriteLine("c. Kontostand anzeigen");
                Console.WriteLine("d. Beenden");

                string auswahl = Console.ReadLine();

                if (auswahl == "a" || auswahl == "A")
                {
                    geldEinzahlen();
                }

                else if (auswahl == "b" || auswahl == "B")
                {
                    geldAbheben();
                }

                else if (auswahl == "c" || auswahl == "C")
                {
                    kontostandAnzeigen();
                }

                else if (auswahl == "d" || auswahl == "D")
                {
                    Console.WriteLine("Programm wird beendet.");
                    break;
                }
            }
        }

        public static void geldEinzahlen()
        {
            decimal kontostand = 634.45m;
            Console.WriteLine("Wie hoch ist der Betrag, den Sie einzahlen wollen? (Eingabebeispiel: 35,90 €) \n ");
            decimal betrag = Convert.ToDecimal(Console.ReadLine());
            kontostand += betrag;
            Console.WriteLine(betrag + "€ wurden erfolgreich eingezahlt.\n");
            decimal aktuell = kontostand + betrag;
            Console.WriteLine($"Dein Aktueller Kontostand: {aktuell}\n");
        }

        public static void geldAbheben()
        {
            decimal kontostand = 634.45m;
            Console.WriteLine("Wie hoch ist der Betrag, den Sie abheben wollen? (Eingabebeispiel: 35,90 €) \n");
            decimal betrag = Convert.ToDecimal(Console.ReadLine());
            if (betrag > kontostand)
            {
                Console.WriteLine("Betrag zu hoch. Abhebung nicht möglich\n");
            }
            else
            {
                Console.WriteLine(betrag + "wurden erfolgreich abgehoben\n");
                decimal aktuell = kontostand - betrag;
                Console.WriteLine($"Dein Aktueller Kontostand: {aktuell}\n");
            }
        }

        public static void kontostandAnzeigen()
        {
            decimal kontostand = 634.45m;
            Console.WriteLine($"Dein Aktueller Kontostand: {kontostand}\n");
        }
    }
}
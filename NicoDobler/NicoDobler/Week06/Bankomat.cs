using System;
namespace NicoDobler.Week06{



class Bankomat
{
    static decimal kontostand = 0;

    public static void Start()
    {
        bool läuft = true;

        while (läuft)
        {
            Console.WriteLine("\nBankomat Optionen:");
            Console.WriteLine("a. Geld einzahlen");
            Console.WriteLine("b. Geld abheben");
            Console.WriteLine("c. Kontostand anzeigen");
            Console.WriteLine("d. Beenden");

            string eingabe = Console.ReadLine();

            switch (eingabe)
            {
                case "a":
                    GeldEinzahlen();
                    break;
                case "b":
                    GeldAbheben();
                    break;
                case "c":
                    KontostandAnzeigen();
                    break;
                case "d":
                    läuft = false;
                    Console.WriteLine("Programm beendet.");
                    break;
                default:
                    Console.WriteLine("Ungültige Auswahl. Bitte erneut versuchen.");
                    break;
            }
        }   
    }

    static void GeldEinzahlen()
    {
        Console.Write("Betrag einzahlen (in Euro): ");
        decimal betrag = Convert.ToDecimal(Console.ReadLine());
        kontostand = kontostand + betrag;
        Console.WriteLine($"{betrag:C} wurden eingezahlt.");
    }

    static void GeldAbheben()
    {
        Console.Write("Betrag abheben (in Euro): ");
        decimal betrag = Convert.ToDecimal(Console.ReadLine());
        kontostand = kontostand - betrag;
        Console.WriteLine($"{betrag:C} wurden abgehoben.");
    }

    static void KontostandAnzeigen()
    {
        Console.WriteLine($"Ihr aktueller Kontostand ist: {kontostand:C}");
    }
}
}

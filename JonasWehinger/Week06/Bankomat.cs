using System;

namespace JonasWehinger.Week06{

class Bankomat
{
    public static void Bank()
    {
        
        double kontostand = 0.0;

        
        Console.WriteLine("Willkommen beim Bankomat!");
        Console.WriteLine("1. Geld einzahlen");
        Console.WriteLine("2. Geld beheben");
        Console.WriteLine("3. Kontostand anzeigen");
        Console.WriteLine("4. Beenden");
        Console.Write("Ihre Wahl: ");
        
        
        string input = Console.ReadLine();

        
        if (input == "1")
        {
            
            Console.Write("Geben Sie den Betrag zum Einzahlen ein: ");
            double einzahlen = Convert.ToDouble(Console.ReadLine());
            if (einzahlen > 0)
            {
                kontostand += einzahlen;
                Console.WriteLine("Sie haben" + einzahlen + "Euro eingezahlt.");
            }
            else
            {
                Console.WriteLine("Betrag muss größer als null sein.");
            }
        }
        else if (input == "2")
        {
            
            Console.Write("Geben Sie den Betrag zum Abheben ein: ");
            double abheben = Convert.ToDouble(Console.ReadLine());
            if (abheben > 0 && abheben <= kontostand)
            {
                kontostand -= abheben;
                Console.WriteLine("Sie haben" + abheben + "Euro abgehoben.");
            }
            else if (abheben > kontostand)
            {
                Console.WriteLine("Nicht genug Guthaben.");
            }
            else
            {
                Console.WriteLine("Betrag muss größer als null sein.");

            }
        }
        else if (input == "3")
        {
            
            Console.WriteLine("Dein aktueller Kontostand:" + kontostand);
        }
        else if (input == "4")
        {
            
            Console.WriteLine("Auf Wiedersehen!");
        }
        else
        {
            Console.WriteLine("Fehler!  Bitte wählen Sie eine gültige Option.");
        }
    }
}

}
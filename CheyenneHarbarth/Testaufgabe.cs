using System;
using CheyenneHarbarth.Week02;

namespace CheyenneHarbarth
{
    class Testaufgabe
    {
        private static double Kontostand = 6809.37;
        public static void Start()
        {
            Console.WriteLine("Hallo!");


            while (true)
            {
                Console.WriteLine("\nWas möchtest Du tun?");
                Console.WriteLine(" Drücke a um Geld einzuzahlen");
                Console.WriteLine(" Drücke b um Geld abzuheben");
                Console.WriteLine(" Drücke c um deinen Kontostand anzeigen zu lassen");
                Console.WriteLine(" Drücke d um das Programm zu beenden");
                string character = Console.ReadLine();

                // Versuche, die Eingabe als Char zu konvertieren
                if (char.TryParse(character, out char Eingabe))
                {
                    if (Eingabe == 'a' || Eingabe == 'A')
                    {
                        Testaufgabe.GiveMoney();
                    }
                    if (Eingabe == 'b' || Eingabe == 'B')
                    {
                        Testaufgabe.GetMoney();
                    }
                    if (Eingabe == 'c' || Eingabe == 'C')
                    {
                        Testaufgabe.ShowMoney();
                    }
                    if (Eingabe == 'd' || Eingabe == 'D')
                    {
                        Console.WriteLine("Auf Wiedersehen");
                        break;
                    }
                }
                else
                {
                    // Wenn die Konvertierung fehlschlägt, gib eine Fehlermeldung aus
                    Console.WriteLine("Das war kein gültiges Zeichen. Bitte versuche es erneut.");
                }
            }

        }

        public static void GiveMoney()
        {
            while (true)
            {
                Console.WriteLine("Wieviel Geld möchtest du einzahlen?");
                string input = Console.ReadLine();

                // Versuche, die Eingabe als Integer zu konvertieren
                if (double.TryParse(input, out double input2))
                {
                    Console.WriteLine($"Einen Moment.\nDein Kontostand wurde um {input2} Euro erhöht");
                    Kontostand += input2;
                    break;
                }
                else
                {
                    // Wenn die Konvertierung fehlschlägt, gibt es eine Fehlermeldung aus
                    Console.WriteLine("Das war kein gültiger Betrag.");
                }
            }
        }

        public static void GetMoney()
        {
            //Schleife läuft solange, bis der Benutzer einen korrekten Betrag eingetippt hat
            while (true)
            {
                Console.WriteLine("Wieviel Geld möchtest du abheben?");
                string input = Console.ReadLine();

                // Versuche, die Eingabe als Integer zu konvertieren
                if (double.TryParse(input, out double input2))
                {
                    if (input2 <= Kontostand)
                    {
                        Console.WriteLine($"Einen Moment.\nDu erhälst in Kürze {input2} Euro");
                        Kontostand -= input2;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Dieser Betrag überzieht dein Konto, bitte wähle einen kleineren Betrag aus!");
                    }
                }
                else
                {
                    // Wenn die Konvertierung fehlschlägt, gibt es eine Fehlermeldung aus
                    Console.WriteLine("Das war kein gültiger Betrag.");
                }
            }
        }

        public static void ShowMoney()
        {
            Console.WriteLine($"Dein Kontostand beträgt:\n {Kontostand} Euro");
        }
    }
}
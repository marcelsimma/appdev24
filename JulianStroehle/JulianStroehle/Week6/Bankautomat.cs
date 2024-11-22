using System;
namespace JulianStroehle.Week6
{
    public class Bankautomat
    {
        private static double balance = 0;
        public static void Start()
        {
            char task;
            do
            {
                try
                {
                Console.WriteLine("Was möchten sie tun?\na. Geld einzahlen\nb. Geld Abheben\nc. Kontostand anzeigen\nd. Beenden");
                task = Convert.ToChar(Console.ReadLine().ToLower());
                switch (task)
                {
                    case 'd': break;
                    case 'a': Deposit(); break;
                    case 'b': Withdraw(); break;
                    case 'c': ShowBalance(); break;
                    default: Console.WriteLine("Fehler bei der Eingabe, versuchen sie es nochmal."); break;
                }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Fehler bei der Eingabe, versuchen sie es nochmal.");
                    task = ' ';
                }
            }
            while (task != 'd');
        }
        static void Deposit()
        {
            try
            {
                Console.WriteLine("Wieviel Geld möchten sie einzahlen? (Beachte: Kommazahlen mit , und nicht mit . anschreiben.)");
                double money = Convert.ToDouble(Console.ReadLine());
                balance += money;
            }
            catch (FormatException)
            {
                Console.WriteLine("Fehler bei der Eingabe, bitte eine Zahl eingeben");
            }
        }
        static void Withdraw()
        {
            try
            {
                Console.WriteLine("Wieviel geld möchten sie abheben? (Beachte: Kommazahlen mit , und nicht mit . anschreiben.)");
                double money = Convert.ToDouble(Console.ReadLine());
                if (money < balance)
                {
                    balance -= money;
                }
                else
                {
                    Console.WriteLine("Nicht genug Geld auf deinem Konto.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Fehler bei der Eingabe, bitte eine Zahl eingeben.");
            }
        }
        static void ShowBalance()
        {
            Console.WriteLine($"Dein Kontostand beträgt derzeit: {Math.Round(balance, 2)} EUR");
        }
    }
}
using System;

namespace MarcelSimma.Week07
{
    public class Bankaccount
    {
        public static void Start()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            char functionSelector;

            double balance = 0;

            Console.Clear();

            do
            {
                System.Console.WriteLine(@"
Folgende Funktionen stehen zur Verfügung:
a. Geld einzahlen
b. Geld abheben
c. Kontostand abfragen
d. beenden
                ");

                if (char.TryParse(Console.ReadLine().ToLower(), out functionSelector))
                {
                    Console.Clear();

                    if (functionSelector == 'a')
                    {
                        Console.Write("Bitte geben Sie den Einzahlungsbetrag ein: ");
                        balance += ReadDoubleFromConsole();
                        System.Console.Write($"Der Betrag wurde erfolgreich auf das Konto einbezahlt. ");
                        PrintBalance(balance);
                    }
                    else if (functionSelector == 'b')
                    {
                        Console.Write("Bitte geben Sie den Auzahlungsbetrag ein: ");
                        double tmp = ReadDoubleFromConsole();
                        if (tmp <= balance)
                        {
                            balance -= tmp;
                            System.Console.Write("Der Betrag wurde erfolgreich vom Konto abgehoben. ");
                        }
                        else
                        {
                            System.Console.Write("Das Überziehen des Kontos ist nicht möglich! ");
                        }
                        PrintBalance(balance);
                    }
                    else if (functionSelector == 'c')
                    {
                        PrintBalance(balance);
                    }
                    else
                    {
                        System.Console.WriteLine("Bitte gib' den Buchstaben vor der Funktion ein, die du ausführen möchtest!");
                    }
                }
                else
                {
                    System.Console.WriteLine("Bitte gib' den Buchstaben vor der Funktion ein, die du ausführen möchtest!");
                }
            } while (functionSelector != 'd');

            Console.Clear();
            System.Console.WriteLine(@"
Das Programm wurde beendet. 
Vielen Dank, dass Sie diesen Bankomat verwendet haben.
            ");
        }

        public static void PrintBalance(double balance) {
            Console.WriteLine(new string($"Aktueller Kontostand: {balance,0:F2} €").Replace(".", ","));
        }

        public static double ReadDoubleFromConsole()
        {
            double consoleInput;

            while (true)
            {
                if (double.TryParse(Console.ReadLine().Replace(",", "."), out consoleInput) && consoleInput >= 0)
                {
                    return Math.Floor(consoleInput * 100) / 100;
                }
                else
                {
                    Console.WriteLine("Bitte geben Sie eine gültige Kommazahl größer oder gleich 0 ein! Beispiel: 123,45");
                }
            }
        }
    }
}

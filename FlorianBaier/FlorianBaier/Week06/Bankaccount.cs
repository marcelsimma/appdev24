using System;

namespace FlorianBaier.Week06
{
    public static class Bankaccount
    {
        public static void Start()
        {
            while (true)
            {
                Console.WriteLine("Bitte drücke Sie Enter um fortzufahren!");
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Hallo, Sie sind bei der Bank, was möchten Sie tun?\n"
                    + "a) Einzahlen\n"
                    + "b) Auszahlen\n"
                    + "c) Guthaben anzeigen\n"
                    + "d) Beenden");

                string? input = Console.ReadLine();
                double newBalance = 0;
                if (input == "a" || input == "A")
                {
                    newBalance = BankAccount.Deposit();
                }
                else if (input == "b" || input == "B")
                {
                    newBalance = BankAccount.Withdraw();
                }
                else if (input == "c" || input == "C")
                {
                    newBalance = BankAccount.GetBalance();
                }
                else if (input == "d" || input == "D")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("404 - Aktion nicht gefunden!");
                    continue;
                }

                Console.WriteLine($"Neuer Kontostand: {newBalance} Euros");
            }
            Console.WriteLine("Danke! Auf Wiedersehen!");
        }
    }

    internal class BankAccount
    {
        private static double balance = 0;

        public static double Deposit()
        {
            double input = ReadInput("Wie viel Geld möchtest du einzahlen?");
            DepositAmount(input);
            return GetBalance();
        }

        public static double Withdraw()
        {
            double input = ReadInput("Wie viel Geld möchtest du auszahlen?");
            if (input > balance)
            {
                Console.WriteLine("Fehler: Dein Kontostand reicht nicht aus, um diesen Betrag abzuheben.");
                return balance;
            }
            WithdrawAmount(input);
            return GetBalance();
        }

        public static double GetBalance()
        {
            return balance;
        }

        private static void DepositAmount(double amount)
        {
            balance += amount;
        }

        private static void WithdrawAmount(double amount)
        {
            balance -= amount;
        }

        private static double ReadInput(string prompt)
        {
            Console.WriteLine(prompt);
            return Convert.ToDouble(Console.ReadLine());
        }
    }
}
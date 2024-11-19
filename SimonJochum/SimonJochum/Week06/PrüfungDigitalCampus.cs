using System;

namespace SimonJochum.Week06
{
    public class PruefungDigitalCampus
    {
        public static double accountBalance = 0;
        public static void Start()
        {
            Console.WriteLine("Hallo beim Bankomat.");
            Choice();
        }

        public static void Choice()
        {
            Console.WriteLine("Was möchten Sie tun?\nDrücken Sie die 'a' um Geld einzuzahlen.\nDrücken Sie die 'b' um Geld abzuheben.\n Drücken Sie 'c' um den Kontostand anzuzeigen.\n Drücken Sie 'd' um das Programm zu beenden.");
            char choice = Convert.ToChar(Console.ReadLine().ToLower());

            if (choice == 'a')
            {
                DepositMoney();
            }
            else if (choice == 'b')
            {
                WithdrawMoney();
            }
            else if (choice == 'c')
            {
                ShowBalance();
            }
            else if (choice == 'd')
            {

            }
            else
            {
                Console.WriteLine("Bitte geben Sie eine gültige Aktion ein!");
                Choice();
            }
        }

        public static void DepositMoney()
        {
            Console.WriteLine("Wieviel Geld möchten Sie auf Ihrem Konto einzahlen?");
            string input = Console.ReadLine();
            if (double.TryParse(input, out double amountToDeposit))
            {
                Console.WriteLine($"{amountToDeposit} EUR wurde auf Ihr Konto eingezahlt.");
                accountBalance += amountToDeposit;
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine gültige Zahl ein.");
            }
            Choice();
        }

        public static void WithdrawMoney()
        {
            Console.WriteLine("Wieviel Geld möchten Sie abheben?");
            string input = Console.ReadLine();
            if (double.TryParse(input, out double amountToWithdraw))
            {
                if(accountBalance >= amountToWithdraw)
                {
                    Console.WriteLine($"{amountToWithdraw} EUR wurde von Ihrem Konto abgebucht");
                    accountBalance = accountBalance - amountToWithdraw;
                }
                else if(accountBalance < amountToWithdraw)
                {
                    Console.WriteLine("Leider verfügen Sie nicht über genügend Guthaben");
                }
            }
            else 
            {
                Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine gültige Zahl ein.");
            }
            Choice();
        }

        public static void ShowBalance()
        {
            Console.WriteLine($"Ihr aktueller Kontostand beträgt:\n\t + {accountBalance} EUR");
            Choice();
        }
        
    }
}
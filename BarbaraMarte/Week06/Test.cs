using System;

namespace BarbaraMarte.Week06;

class Test
{
    public static List<double> transactions = new List<double>();

    /// <summary>
    /// Decide what you want to do
    /// </summary>
    public static void Print()
    {
        Console.WriteLine("Do you want to put in money (a), take out money (B), check your bank status (C) or do you want to leave the program? (e)");
        string decision = Console.ReadLine().ToLower();

        if (decision == "a" || decision == "b" || decision == "C")
        {
            if (decision == "a")
            {
                Input();
            }
            if (decision == "b")
            {
                Output();
            }
            if (decision == "C")
            {
                BankBalance();
            }
        }
        else if (decision == "e")
        {
            Console.WriteLine("You are leaving the program now. Have a lovely day!");
            return;
        }
        else
        {
            Print();
        }
    }

    public static void Input()
    {
        Console.WriteLine("Please enter the amount of money you want to put in your account. (10,00)");

        if (double.TryParse(Console.ReadLine(), out double amount) && amount > 0)
        {
            transactions.Add(amount);
            Console.WriteLine($"You deposited {amount} Euro.");
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
        Print();
    }
    public static void Output()
    {

        Console.WriteLine("How much money do you want to take out fom your account?");
        if (double.TryParse(Console.ReadLine(), out double amount) && amount > 0)
        {
            transactions.Add(-amount);  // Remove did not work so i add here a negative number to remove the amount from the account status. You can go in to minus numbers with this method.
            Console.WriteLine($"You took out {amount} Euro from your account.");
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
        Print();
    }
    public static void BankBalance()
    {
        double balance = transactions.Sum();        // You have to change it to a double that you can write it out. Lists don't like to be written out...
        Console.WriteLine($"You have {balance} Euros left on your account.");
        Print();
    }

}
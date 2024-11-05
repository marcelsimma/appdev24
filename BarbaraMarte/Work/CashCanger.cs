using System;
using BarbaraMarte.Week03;

namespace BarbaraMarte.Work;

class CashChange
{
    public static int InputAndConvertToCent()
    {
        Console.WriteLine("Please enter the Amount like in the example: 10,00");
        double input = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Should I print it out in Euro or Cent? (e/c)");
        char decision = Convert.ToChar(Console.ReadLine());

        double inputCent;           //convert the double inputCent to an int that you can use it below in your calculations.
        inputCent = input * 100;
        int everythingInCent = (int)inputCent;

        if (decision == 'e')
        {
            PrintEuro(everythingInCent);
        }
        else if (decision == 'c')
        {
            PrintCent(everythingInCent);
        }
        else
        {
            Console.WriteLine("Please enter a valid letter (e/c):");
        }
        return everythingInCent;
    }

    public static void PrintEuro(int everythingInCent)
    {
        int[] centList = { 50000, 20000, 10000, 5000, 2000, 1000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };
        int i = 0;

        while (i < centList.Length)
        {
            int currentCoin = centList[i];
            int numberOfCoins = everythingInCent / currentCoin;     // shows you how often everythingInCent accrues in currentCoin
            if (numberOfCoins != 0)                                 // is here that it doesn't print out each Line even if there is no money 
            {
                Console.WriteLine(string.Format("{1}x {0,8:F2}\t {2,6}", currentCoin / 100.0, numberOfCoins, "Euro"));
                everythingInCent -= currentCoin * numberOfCoins;
            }
            // while (everythingInCent >= currentCoin)
            // {
            //     Console.WriteLine(string.Format("{0,8:F2}\t {1,6}", currentCoin / 100.0, "Euro"));
            //     everythingInCent -= currentCoin;
            // }
            i++;
        }
    }

    public static void PrintCent(int everythingInCent)
    {
        int[] centList = new int[] { 50000, 20000, 10000, 5000, 2000, 1000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };
        int i = 0;

        while (i < centList.Length)
        {
            int currentCoin = centList[i];
            if (everythingInCent >= currentCoin)
            {
                Console.WriteLine("{0,8} {1,6}", currentCoin, "Cent");
                everythingInCent -= currentCoin;
            }
            i++;
        }
    }
}
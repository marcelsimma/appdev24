using System;

namespace BarbaraMarte.Week04;

class MoneyCounter
{
    public static void Print(int amountCent)
    {

        int[] list = new int[] { 5000, 2000, 1000, 500, 200, 100, 500, 200, 100, 50, 20, 10, 5, 2, 1 };

        for (int i = 0; i < list.Length; i++)
        {
            int currentCoin = list[i];
            if (amountCent >= currentCoin)
            {
                Console.WriteLine($"{currentCoin} cent");
                amountCent -= currentCoin;
            }
        }
    }

    public static void Decition()
    {
        Console.WriteLine("");
    }



    public static int Euro()
    {
        //Console.WriteLine("Amount Euro"); Recipe
        int amountEuro = 0; //Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Amount Cent");
        int amountCent = 0; // Convert.ToInt32(Console.ReadLine());

        int combined = amountCent + amountEuro * 100;
        //Print(combined);
        return combined;
    }
}
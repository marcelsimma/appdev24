using System.Globalization;

namespace BarbaraMarte.Week03;

class ArraySuche
{
    public static void Print()
    {
        string[] numbers = new string[11] { "1", "15", "16", "10", "5", "8", "7", "11", "16", "19", "4" };
        bool found;

        Console.WriteLine("Guess my seecret 11 numbers between 1 and 20");

        for (int j = 0; j < 16; j++)
        {
            Console.WriteLine($"{j + 1}. try");
            string? guess = Console.ReadLine();
            found = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (guess == numbers[i])
                {
                    found = true;
                    Console.WriteLine("You are right!");

                }
            }

            if (found == false)
            {
                Console.WriteLine("Close but not correct!");
            }

        }
    }
}
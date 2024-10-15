using System.Security.Cryptography;

namespace BarbaraMarte.Week02;

class HigherOrLower
{
    public static void PrintHigherOrLower()
    {
        Console.WriteLine("Welcome to a fun game!");

        Random random = new Random();
        int targetNumber = random.Next(1, 100);

        Console.WriteLine("Please enter a Number between 1 and 100");
        int guess = -1;

        while (guess != targetNumber)
        {
            guess = Convert.ToInt32(Console.ReadLine());

            if (guess < targetNumber)
            {
                Console.WriteLine("Higher");

            }
            else if (guess > targetNumber)
            {
                Console.WriteLine("Lower");
            }
        }
        Console.WriteLine("You did it. You won!!");
    }
}

/*   do
        {
            Console.WriteLine("Please enter a Number between 1 and 100");

            while (int.TryParse(Console.ReadLine(), out guess) || guess < 1 || guess > 99)
            {
                if (guess < targetNumber)
                {
                    Console.WriteLine("Higher");
                    break;
                }

                else if (guess > targetNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess == targetNumber)
                {
                    Console.WriteLine("You did it. You won!! If you want to continue press a new number");
                }
            }


        } while (true);    */
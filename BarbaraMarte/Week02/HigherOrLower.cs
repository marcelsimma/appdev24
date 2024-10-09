using System.Security.Cryptography;

namespace BarbaraMarte.Week02;

class HigherOrLower
{
    public static void PrintHigherOrLower()
    {
        Console.WriteLine("Welcome to a funn game!");

        Random random = new Random();
        int targetNumber = random.Next(1, 100);

        int guess;


        do
        {
            Console.WriteLine("Please enter a Number between 1 and 100");

            while (int.TryParse(Console.ReadLine(), out guess) || guess < 1 || guess > 100)
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


        } while (true);

    }
}

//Console.WriteLine("Sorry mate, you just killed the program...")

/* do                didn't work as planed...
 {
     Console.WriteLine("Please enter a number betwen 1 and 100");
     int number = Convert.ToInt32(Console.ReadLine());



     if (new Random().Next(100) == number)
     {
         Console.WriteLine("Congratulations, you won");
     }
     else
     {
         Console.WriteLine("We are almost there. Try again");
     }
 }
 while ();*/
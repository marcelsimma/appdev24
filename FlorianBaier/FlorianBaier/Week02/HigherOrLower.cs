using System;

namespace FlorianBaier.Week02
{

    class HigherOrLower
    {

        public static void HigherOrLowerGame()
        {
            Console.WriteLine("Welcome, to the HigherOrLower game.");
            Console.WriteLine("Guess the number between 0 and 100!");
            int userGuess = HigherOrLowerQuery();
            HigherOrLowerNumber(userGuess);


        }

        public static int HigherOrLowerQuery()
        {

            int input2;
            while (true)
            {
                Console.Write("Please enter your number: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out input2) && input2 >= 0 && input2 <= 100)
                {
                    return input2;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");

                }
            }
        }
        public static void HigherOrLowerNumber(int input2)
        {
            Random random = new Random();
            int luckyNumber = random.Next(0, 101);
            int userGuess= -1;

            while (userGuess != luckyNumber)
            {
                userGuess = HigherOrLowerQuery();

                if (userGuess == luckyNumber)
                {
                    Console.WriteLine("That's correct, congratulations you won.");
                }
                else if (userGuess < luckyNumber)
                {
                    Console.WriteLine("The Luckynumber is higher than your number.");
                }
                else
                {
                    Console.WriteLine("The Luckynumber is lower than your number.");
                }
            }

        }
    }
}
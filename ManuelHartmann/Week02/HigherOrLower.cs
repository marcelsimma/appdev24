
namespace ManuelHartmann.Week02
{

    public class HigherOrLower
    {
        static void Start(string[] args)
        {
            do
            {
                Console.WriteLine("Hello to the super cool number guessing game! \nPlease insert your number: ");
                string response = Console.ReadLine();
                if(int.TryParse(response, out int guess))
                {
                    if(guess == RandomGenerator())
                    {
                        Console.WriteLine("Congrats! You fucking got it!");
                        Thread.Sleep(2000);
                        break;
                    }
                    else if(guess < RandomGenerator())
                    {
                        Console.WriteLine("Unfortunately, your guess is a bit too low...");
                    }
                    else if (guess > RandomGenerator())
                    {
                        Console.WriteLine("Unfortunately, your guess is a bit too high...");
                    }
                }
                else
                {
                    Console.WriteLine("That's not a number! Please try again!");
                }
            }while (true);
        }
        public static int RandomGenerator()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 100);
            return randomNumber;
        }
    }
}





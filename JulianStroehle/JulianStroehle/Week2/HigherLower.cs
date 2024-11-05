using System;
namespace JulianStroehle.Week2
{
    public class HigherLower
    {
        public static void Start()
        {
            do
            {
                Random rdm = new Random();
                int RandomNumber = rdm.Next(0, 100);
                int guessed = 0;
                do
                {
                    try
                    {
                        Console.WriteLine("Guess number between 0 and 100:");
                        guessed = Convert.ToInt32(Console.ReadLine());
                        if (guessed < 0)
                        {
                            Console.WriteLine("\nNo negative numbers\n");
                        }
                        else if (guessed > 100)
                        {
                            Console.WriteLine("\nNo numbers over 100\n");
                        }
                        else if (guessed < RandomNumber)
                        {
                            Console.WriteLine("\nhigher\n");
                        }
                        else if (guessed > RandomNumber)
                        {
                            Console.WriteLine("\nlower\n");
                        }
                        else
                        {
                            Console.WriteLine("\nGuessed number\n");
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("\nOnly numbers please\n");
                    }
                }
                while (guessed != RandomNumber);
                Console.WriteLine("Again? (y/n)");
            }
            while (Console.ReadLine() == "y") ;
        }
    }
}
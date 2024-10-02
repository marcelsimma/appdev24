using System;

namespace StefanMarinovic
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("give me a height and I will make a square for you");
            string response = Console.ReadLine();
            if (int.TryParse(response, out int number))


                for (int i = 1; i <= number; i++)
                {
                    if (i == 1)
                    {
                        for (int j = 1; j <= number; j++)
                        {
                            Console.Write("X");
                        }
                        Console.WriteLine();
                    }
                    else if (i == number)
                    {
                        for (int j = 1; j <= number; j++)
                        {
                            Console.Write("X");
                        }
                    }
                    else
                    {
                        Console.Write("X");
                        for (int j = 3; j <= number; j++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write("X");
                        Console.WriteLine();
                    }
                }


        }
    }
}

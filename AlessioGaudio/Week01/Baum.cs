using System;

namespace AlessioGaudio.Week01
{
    class Baum
    {
        public static void Start()
        {
            PrintChristmasTree(14); 
        }
       
        public static void PrintChristmasTree(int height)
        {
            Random random = new Random(); // Für zufällige Positionen
            for (int i = 0; i < height; i++)
            {
                Console.Write(new string(' ', height - i - 1));
                
                // "O" werden zufällig in den Baum ein eingefügt
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    // Bei 15% Wahrscheinlichkeit ein "O" statt eines "*"
                    if (random.NextDouble() < 0.15 && j % 2 == 0) // Nur an geraden Positionen
                    {
                        Console.Write("O");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }

       
            Console.WriteLine(new string(' ', height - 3) + "+++++");
            Console.WriteLine(new string(' ', height - 3) + "+++++");
            Console.WriteLine(new string(' ', height - 3) + "+++++");
        }
    }
}

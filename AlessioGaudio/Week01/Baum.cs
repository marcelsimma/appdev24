using System;

namespace AlessioGaudio.Week01
{
    class Baum
    {
        public static void Start()
        {
            PrintChristmasTree(9); 
        }

        public static void PrintChristmasTree(int height)
        {
            for (int i = 0; i < height; i++)
            {
                Console.Write(new string(' ', height - i - 1));
                Console.WriteLine(new string('*', 2 * i + 1));
            }

            Console.WriteLine("O O O O O O O O O");

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(new string(' ', height - 3) + "+++++");
            }
        }
    }
}

using System;

namespace AlessioGaudio.Week01
{
    class Stamm
    {
        public static void Start()
        {
            PrintChristmasTree(14); 
        }

        public static void PrintChristmasTree(int height)
        {
            for (int i = 0; i < height; i++)
            {
                Console.Write(new string(' ', height - i - 1));
                Console.WriteLine(new string('*', 2 * i + 1));
            }

            string stump = new string(' ', height - 3) + "+++++";
            Console.WriteLine(stump);
            Console.WriteLine(stump);
            Console.WriteLine(stump);
        }
    }
}

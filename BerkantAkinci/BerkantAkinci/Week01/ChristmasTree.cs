using System;

namespace BerkantAkinci.Week01
{
    class ChristmasTree
    {
        public static void PrintChristmasTree(char c, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write(new string(' ', size/2) + c + new string(' ', size/2));










                Console.WriteLine();
            }
        }
    }
}
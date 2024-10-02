using System;
using System.ComponentModel;

namespace CheyenneHarbarth.Week01
{

    class ChristmasTree
    {

        public static void PrintTree(char c, int size)
        {
            for (int i = 0; i < size; i++)
            {
                int half = (size-1)/2;
                //erste Reihe
                if (i == 0)
                {
                    Console.Write(new string(' ', half) + c + new string(' ', half));
                }

                //restliche Baumreihen
                if (i > 0 && i < size - 3)
                {
                    Console.Write(new string(' ', half - i) + new string(c, size-(2*(half-i))) + new string(' ', half - i));
                }
                //Christbaumkugeln
                if (i == size-5) {
                    Console.Write(new string('0', size));
                }
                Console.WriteLine();
            }
        }
    }
}
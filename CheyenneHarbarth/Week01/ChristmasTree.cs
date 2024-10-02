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
                int half = (size - 1) / 2;
                //erste Reihe
                if (i == 0)
                {
                    Console.Write(new string(' ', half) + c + new string(' ', half));
                }

                //restliche Baumreihen
                if (i > 0 && i < size - 5)
                {
                    Console.Write(new string(' ', half - i) + new string(c, size - (2 * (half - i))) + new string(' ', half - i));
                }
                //Christbaumkugeln
                if (i == size - 5)
                {
                    for (int j = 0; j < size; j++)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write('0');
                        }
                        else
                        {
                            Console.Write(' ');
                        }
                    }
                }
                //Baumstamm
                if (i > size - 5 && i < size - 2)
                {
                    Console.Write(new string(' ', (size - 5) / 2) + new string('+', 5) + new string(' ', (size - 5) / 2));
                }
                Console.WriteLine();
            }
        }
    }
}
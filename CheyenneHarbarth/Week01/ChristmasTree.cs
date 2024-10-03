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
                else if (i > 0 && i < size - half)
                {
                    Console.Write(new string(' ', half - i) + new string(c, size - (2 * (half - i))) + new string(' ', half - i));
                }
                //Christbaumkugeln, nur jede zweite Kugel soll sichtbar sein
                else if (i == size - half)
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
                //Baumstamm, Breite soll 1/3 der size sein, Stammlänge soll sich proportional zur Größe verhalten
                else if (i > size - half && i < size -(size/4))
                {
                    Console.Write(new string(' ', (size-(size/3)) / 2) + new string('+', size/3) + new string(' ', (size-(size/3)) / 2));
                }
                Console.WriteLine();
            }
        }
    }
}
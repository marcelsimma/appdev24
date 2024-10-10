using System;
using System.ComponentModel;
using System.Globalization;

namespace CheyenneHarbarth.Week01
{

    class ChristmasTree
    {

        public static void PrintTree(char c, int size)
        {
            for (int i = 0; i < size; i++)
            {
                int numAsterisks = (i * 2) + 1;
                int half = (size - 1) / 2;
                var rand = new Random();
                int numOrnaments = rand.Next(numAsterisks - 1);

                //Baumkrone
                if (i == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(new string(' ', half - i) + new string(c, numAsterisks) + new string(' ', half - i));
                }
                if (i > 0 && i < size - half)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write(new string(' ', half - i) + new string(c, numAsterisks) + new string(' ', half - i));
                    /*ConsoleColor color = (ConsoleColor)rand.Next(1, 16);
                    Console.ForegroundColor = color;*/
                }
                //Christbaumkugeln, nur jede zweite Kugel soll sichtbar sein
                else if (i == size - half)
                {
                    for (int j = 0; j < size; j++)
                    {
                        if (j % 2 == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write('0');
                        }
                        else
                        {
                            Console.Write(' ');
                        }
                    }
                }
                //Baumstamm, Breite soll 1/3 der size sein, Stammlänge soll sich proportional zur Größe verhalten
                else if (i > size - half && i < size - (size / 4))
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write(new string(' ', (size - (size / 3)) / 2) + new string('+', size / 3) + new string(' ', (size - (size / 3)) / 2));
                }
                Console.WriteLine();
            }
        }
    }
}
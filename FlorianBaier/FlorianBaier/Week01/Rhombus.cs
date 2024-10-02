using System;

namespace FlorianBaier.Week01
{

    public class Rhombus
    {
        public static void PrintRhombus(char c, int size)
        {
            for (int i = 0; i < size; i++)
            {
                //Erste Zeile
                if (i == 0)
                {

                    Console.Write(new string('.', (size) / 2) + c + new string('.', (size) / 2));
                }

                //Linie von 9 bis 12 Uhr
                if (i > 0 && i < (size - 1) / 2)
                {
                    Console.Write(new string('.', (size - 1) / 2 - i) + c + new string('.', i * 2 - 1) + c + new string('.', (size - 1)/2-i));
                }

                //Mittlere Zeile
                if (i == (size - 1) / 2)
                {
                    Console.Write(c + new string('.', size - 2) + c);
                }
                //Linie von 6 bis 9Uhr
                else if (i >(size - 1 )/2 && i < size - 1)
                {
                    Console.Write(new string('.', i -(size-1)/2) + c + new string('.', size * 2 -3 -i*2) + c + new string('.',i -(size-1)/2 ));
                }

                //Letzte Zeile
                else if (i == size - 1)
                {

                    Console.WriteLine(new string('.', (size) / 2) + c + new string('.', (size) / 2));
                }

                Console.WriteLine();
            }
        }

        public static void PrintLine(char c, int length)
        {
            Console.Write(new string(c, length));
        }

    }
}
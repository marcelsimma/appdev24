using System;

namespace LucasSchiemann.Week01
{

    public class PrintSquare
    {

        public static void Print(char c, int size)
        {

            for (int i = 0; i < size; i++)
            {

                if (i == 0 || i == size - 1)
                {

                    PrintLine('*', size);

                }
                else
                {
                    Console.Write(c);

                    PrintLine(' ', size - 2);
                    Console.Write(c);
                }
                Console.WriteLine();

            }

        }

        public static void PrintLine(char c, int length)
        {
            /*
            for (int j = 0; j < length; j++)
            {
                Console.Write(c);
            }
            */
            Console.Write(new string(c, length));
        }
    }
}
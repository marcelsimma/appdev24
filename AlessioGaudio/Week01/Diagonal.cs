using System;

namespace AlessioGaudio.Week01
{
    class Diagonal
    {
        public static void Start()
        {
            PrintDiagonalLine('x', 5);
            Console.WriteLine();
            PrintDiagonalLineReverse('x', 5);
            Console.WriteLine();
            PrintFilledDiagonalLine('x', 5);
            Console.WriteLine();
            PrintFilledDiagonalLineReverse('x', 5);
        }

        public static void PrintDiagonalLine(char character, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size + 4; j++)
                {
                    if (j == size + i)
                    {
                        Console.Write(character);
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }
                Console.WriteLine();
            }
        }

        public static void PrintDiagonalLineReverse(char character, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size + 4; j++)
                {
                    if (j == size - i - 1)
                    {
                        Console.Write(character);
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }
                Console.WriteLine();
            }
        }

        public static void PrintFilledDiagonalLine(char character, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (j == i)
                    {
                        Console.Write(character);
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }
                Console.WriteLine();
            }
        }

        public static void PrintFilledDiagonalLineReverse(char character, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (j == size - i - 1)
                    {
                        Console.Write(character);
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

using System;
 
namespace NicoDobler.Week01
{
    class Rhombus
    {
        public static void Start()
        {
            PrintRhombus('x', 12);
        }
 
        public static void PrintRhombus(char character, int size)
        {
            while (size % 2 == 0)
            {
                size++;
            }
 
            int mid = size / 2;
 
            for (int i = 0; i <= mid; i++)
            {
                for (int j = 0; j < mid - i; j++)
                {
                    Console.Write(' ');
                }
 
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    if (j == 0 || j == 2 * i)
                    {
                        Console.Write(character);
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
 
            for (int i = mid - 1; i >= 0; i--)
            {
                for (int j = 0; j < mid - i; j++)
                {
                    Console.Write(' ');
                }
 
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    if (j == 0 || j == 2 * i)
                    {
                        Console.Write(character);
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
 
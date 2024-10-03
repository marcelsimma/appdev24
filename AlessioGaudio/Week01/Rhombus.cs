using System;

namespace AlessioGaudio.Week01
{
    class Rhombus
    {
        public static void Start()
        {
            PrintRhombus('x', 10);
        }

        public static void PrintRhombus(char character, int size)
        {
            if (size % 2 == 0)
            {
                size++;
            }

            int mid = size / 2;

            for (int i = 0; i < size; i++)
            {
                int outerSpaces = Math.Abs(mid - i);
                int innerSpaces = size - 2 * outerSpaces - 2;

                for (int j = 0; j < size; j++)
                {
                    if (j < outerSpaces)
                    {
                        Console.Write(' ');
                    }
                    else if (j == outerSpaces || j == size - outerSpaces - 1)
                    {
                        Console.Write(character);
                    }
                    else if (innerSpaces > 0)
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

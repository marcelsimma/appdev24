
using System;

namespace BarbaraMarte.Week01
{
    //Funtioniert
    public class EmptySquare
    {
        // char wird mit ' ' geschrieben. NICHT mit " " 
        public static void PrintEmptySquare(char c, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == 0 || i == size - 1 || j == 0 || j == size - 1)
                    {
                        Console.Write(c);
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
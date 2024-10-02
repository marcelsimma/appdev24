using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace FatmanurKeles.Week01
{
    public class PrintSquare
    {
        public static void Print(char c, int size)
        {
            for (int i = 0; i < size; i++)
            {

                // Schreibt die erste Zeile mit X
                if (i == 0)
                {
                    for (int j = 0; j < size; j++)
                    {
                        Console.Write(c);
                    }
                }


                // Schreibt die letzte Zeile mit X
                else if (i == 9)
                {
                    for (int j = 0; j < size; j++)
                    {
                        Console.Write(c);
                    }

                }
                else
                {
                    Console.Write(c);

                    for (int j = 0; j < size - 2; j++)
                    {
                        Console.Write(' ');
                    }
                    Console.Write(c);
                }
                Console.WriteLine();

            }
        }
    }
}



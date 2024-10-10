using System;
namespace JulianStroehle.Week2
{
    public class TwoDimentionalArray
    {
        public static void TwoDimArray(int l)
        {
            char[,] chars= new char[l,l];
            for (int i=0; i<l; i++)
            {
                for (int j=0; j<l; j++)
                {
                    chars[i,j] = ' ';
                    if (i == j)
                    {
                        chars[i,j] = 'X';
                    }
                    if (j == l-i-1)
                    {
                        chars[i,j] = 'X';
                    }
                    Console.Write(chars[i,j]);
                } 
                Console.WriteLine();
            }
        }
    }
}
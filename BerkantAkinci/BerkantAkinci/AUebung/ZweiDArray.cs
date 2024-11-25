using System;
using System.Dynamic;

namespace BerkantAkinci.Ubueng
{

    class ZweiDArray
    {

        public static void PrintZweiArray()
        {
            int[,] zahlen = {
                {0, 0, 1, 2, 3},
                {0, 0*0, 0*1, 0*2, 0*3},
                {1, 0*1, 1*1, 2*1, 3*1},
                {2, 0*2, 1*2, 2*2, 3*2},
                {3, 0*3, 1*3, 2*3, 3*3},
                {4, 0*4, 1*4, 2*4, 3*4},
                {5, 0*5, 1*5, 2*5, 3*5}
            };

            for (int i = 0; i < zahlen.GetLength(0); i++)
            {
                for (int j = 0; j < zahlen.GetLength(1); j++)
                {
                    System.Console.Write($"{zahlen[i,j],-3}");
                }
                System.Console.WriteLine();
            }
        }
    }
}
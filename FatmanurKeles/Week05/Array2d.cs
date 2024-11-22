using System;
using System.Diagnostics.Metrics;

namespace FatmanurKeles.Week05
{
    public class Array2d
    {
        public static void Start()
        {
            int[,] zahlen1 = new int[3,3];
            
            /*
            0,0 = 2     0,1 = 4     0,2 = 3
            1,0 = 3     1,1 = 2     1,2 = 1
            2,0 = 1     2,1 = 5     2,2 = 4
            */
            int[,] zahlen2 =
            {
                {2,4,3},
                {3,2,1},
                {1,5,4},
            };
          
            for (int i= 0; i < zahlen1.GetLength(0); i++)
            {
                for (int j = 0; j < zahlen1.GetLength(1); j++)
                {
                    Console.Write(zahlen1[i,j] + "     |");
                }
                Console.WriteLine();
            }
        }
    }
}

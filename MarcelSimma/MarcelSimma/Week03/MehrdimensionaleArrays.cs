using System;

namespace MarcelSimma.Week03
{
    public class MehrdimensionaleArrays
    {
        public static void Start()
        {


            // 2D Array, Matrix
            int[,] mehrdimArray = new int[3, 2]
            {
                { 1, 2 },
                { 3, 4 },
                { 5, 6 }
            };

            for (int i = 0; i < mehrdimArray.GetLength(0); i++)
            {
                for (int j = 0; j < mehrdimArray.GetLength(1); j++)
                {
                    Console.Write(mehrdimArray[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // Jagged Array
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 2 };
            jaggedArray[1] = new int[] { 3, 4, 5 };
            jaggedArray[2] = new int[] { 6 };

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
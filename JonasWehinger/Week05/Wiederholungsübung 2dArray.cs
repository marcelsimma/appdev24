using System;

namespace JonasWehinger.Week05{

    public class Array2d{

        public static void Start(){

            int[,] Array = new int[6, 4]
            {
                { 0, 0, 0, 0 },
                { 0, 1, 2, 3 },
                { 0, 2, 4, 6 },
                { 0, 3, 6, 9 },
                { 0, 4, 8, 12},
                { 0, 5, 10, 15}
            };

            
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    
                    Console.Write(Array[i, j] + " ");  
                }
                Console.WriteLine();  
            }
            
        }
    }
}


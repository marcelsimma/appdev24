using System;

namespace BarbaraMarte.Week05
{
    class Wiederholung2dArray
    {
        public static void Print()
        {

            string[,] multiply = new string[4, 5]{
                {"1", "2", "3", "4", "5"},
                {"1", " ", " ", " ", " ",  },
                {"2", " ", " ", " ", " ", },
                {"3", " ", " ", " ", " ", }
            };

            for (int i = 0; i < multiply.GetLength(0); i++)
            {
                for (int j = 0; j < multiply.GetLength(1); j++)
                {
                    Console.Write(i * j + " * ");
                }
                Console.WriteLine();
            }
        }
    }
}
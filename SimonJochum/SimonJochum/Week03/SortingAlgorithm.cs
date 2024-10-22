using System;

namespace SimonJochum.Week03
{
    public class SortingAlgorithm  // https://www.tutorialspoint.com/selection-sort-program-in-chash
    {
        public static void Start()

        { //Selection Sort
            int[] number = { 89, 76, 45, 92, 67, 12, 99 };
            int n = 7;
            Console.WriteLine("Selection sort");
            Console.Write("Initial Array is: ");

            for (int i = 0; i < n; i++)
            {
                Console.Write(number[i] + " ");
            }

            

        }
    }
}
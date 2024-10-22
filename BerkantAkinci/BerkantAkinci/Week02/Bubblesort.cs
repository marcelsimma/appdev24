using System;
using System.Diagnostics.Metrics;
using System.Globalization;
using Microsoft.VisualBasic;

namespace BerkantAkinci.Week02
{

    class Bubblesort
    {

        public static void PrintBubblesort()
        {
            int[] arr = { 78, 55, 45, 98, 13 };

            int temp;

           Console.WriteLine("Unsorted:");
            foreach (int p in arr)
                Console.Write(p + " ");

            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            Console.WriteLine("\nSorted:");
            foreach (int p in arr)
                Console.Write(p + " ");
        }
    }
}
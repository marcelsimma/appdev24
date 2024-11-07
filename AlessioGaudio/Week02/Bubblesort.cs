using System;

namespace AlessioGaudio.Week02
{
    class BubbleSortt 
    {
       public static void Start(string[] args)
        {
            int[] array = { 64, 34, 25, 12, 22, 11, 90 };
            Console.WriteLine("Unsortiertes Array:");
            PrintArray(array);

            Console.WriteLine("\nWähle die Sortierrichtung (1 für aufsteigend, 2 für absteigend): ");
            int wahl = Convert.ToInt32(Console.ReadLine());

            BubbleSortAlgorithm(array, wahl == 1);

            Console.WriteLine("\nSortiertes Array:");
            PrintArray(array);
        }

        internal static void Start()
        {
            throw new NotImplementedException();
        }

        static void BubbleSortAlgorithm(int[] array, bool aufsteigend)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (aufsteigend ? array[j] > array[j + 1] : array[j] < array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        static void PrintArray(int[] array)
        {
            foreach (int elem in array)
            {
                Console.Write(elem + " ");
            }
            Console.WriteLine();
        }
    }
}

using System;

namespace AlessioGaudio.Schule
{
    class BubbleSort
    {
        public static void Start()
        {
            int[] numbers = { 64, 34, 25, 12, 22, 11, 90 };

            Console.WriteLine("Unsortiertes Array:");
            PrintArray(numbers);

            // Bubble Sort ausführen
            BubbleSortAlgorithm(numbers);

            Console.WriteLine("\nSortiertes Array:");
            PrintArray(numbers);
        }

        // Methode für den Bubble Sort Algorithmus
        static void BubbleSortAlgorithm(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                // Die letzte i Elemente sind bereits sortiert
                for (int j = 0; j < n - i - 1; j++)
                {
                    // Wenn das aktuelle Element größer als das nächste ist, tauschen
                    if (array[j] > array[j + 1])
                    {
                        // Tausche array[j] und array[j+1]
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        // Hilfsmethode zur Ausgabe des Arrays
        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

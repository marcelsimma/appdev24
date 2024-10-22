using System;

using LucasSchiemann.Week02;

namespace LucasSchiemann.Week02;

public static class BubbleSorter
{
    static void BubbleSort(int[] array)
    {
        int arrayLength = array.Length;
        for (int counter = 0; counter < arrayLength - 1; counter++)
        {
            
            for (int j = 0; j < arrayLength - counter - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }
    public static void PrintArray(int[] array)
    {
        foreach (int numbers in array)
        {
            Console.Write(numbers + " ");
        }
        Console.WriteLine();
    }
    public static void Processor()
    {
        int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

        Console.WriteLine("Unsortiertes Array:");
        PrintArray(arr);

        BubbleSort(arr);

        Console.WriteLine("Sortiertes Array:");
        PrintArray(arr);
    }
}

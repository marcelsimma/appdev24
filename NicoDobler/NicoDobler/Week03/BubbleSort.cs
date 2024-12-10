using System;
 
namespace NicoDobler.Week03
{
    public class BubbleSort
    {
        public static void Sort(){
            int[] array = { 34, 12, 5, 47, 3 };
 
        Console.WriteLine("Ursprüngliches Array:");
        BubbleSorting(array, true);
        PrintArray(array);
 
    }
 
    public static void BubbleSorting(int[] array, bool ascending)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1; j++)
            {
                if ((ascending && array[j] > array[j + 1]) || (!ascending && array[j] < array[j + 1]))
                {
                    // Tauschen
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }
 
    public static void PrintArray(int[] array)
    {
        Console.WriteLine(string.Join(" ", array));
    }
 
 
        }
    }
 
 
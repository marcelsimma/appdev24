using System;

namespace JonasWehinger.Week03
{
    public class Bubblesort
    {
        public static void Sort(){
            int[] array = { 64, 34, 25, 12, 22, 11, 90 };

        Console.WriteLine("Ursprüngliches Array:");
        Print(array);
        BubbleSort(array,true);

    }

    public static void BubbleSort(int[] array, bool eingabe)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1; j++)
            {
                if ((eingabe && array[j] > array[j + 1]) || (!eingabe && array[j] < array[j + 1]))
                {
                    
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }

    public static void Print(int[] array)
    {
        Console.WriteLine(string.Join(" ", array));
    }


        }
    }

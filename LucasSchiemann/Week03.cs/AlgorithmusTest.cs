using System;
using LucasSchiemann.Week01;

namespace LucasSchiemann.Week03;

static class AlgorithmTester
{

    static void BubbleSort(int[] array)
    {
        int arrayLength = array.Length;
        for (int counter = 0; counter < arrayLength - 1; counter++)
        {

            for (int positionArray = 0; positionArray < arrayLength - counter - 1; positionArray++)
            {
                if (array[positionArray] > array[positionArray + 1])
                {
                    int temp = array[positionArray];
                    array[positionArray] = array[positionArray + 1];
                    array[positionArray + 1] = temp;
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
    public static int[] generateRandomIntegerArray()
    {
        Random Rand = new Random();
        Console.WriteLine("Gib ein wie viel Random Zahlen dein Array haben soll: ");
        int LengthArray = Convert.ToInt32(Console.ReadLine());
        int[] unsortedArray = new int[LengthArray];

        for (int i = 0; i < LengthArray; i++)
        {
            unsortedArray[i] = Rand.Next(0, LengthArray * 100);
        }
        Console.WriteLine("Unsortiertes Array");
        PrintArray(unsortedArray);
        return unsortedArray;
    }


    public static void ProcessorBubbleSort()
    {
        int[] NumberArray = { 64, 34, 25, 12, 22, 11, 90 };

        Console.WriteLine("Unsortiertes Array:");
        PrintArray(NumberArray);

        BubbleSort(NumberArray);

        Console.WriteLine("Sortiertes Array:");
        PrintArray(NumberArray);
    }
    public static void excecuteSelectionSort()
    {
        // NubmerArray weil wir abhängig vom Programmfortschritt ein sortiertes/unsortieres haben
        //int[] NumberArray = generateRandomIntegerArray();
        int[] NumberArray = { 12, 100, 90 };
        int arrayLength = NumberArray.Length;

        /* for loop:
            1.Startposition(currentPosition) auf 0 setzen.
            2.Bedingung wie lang der loop läuft.
            3.currentPosition wird auf die nächste Position gesetzt*/

        // loopen über das complette array    
        for (int currentPosition = 0; currentPosition < arrayLength - 1; currentPosition++)
        {
            // store the current position of the first loop in a variable
            int smallestValue = currentPosition;

            // loop über das verbleibende Array
            for (int comparePosition = currentPosition + 1; comparePosition < arrayLength; comparePosition++)
            {
                if (NumberArray[comparePosition] < NumberArray[smallestValue])
                {
                    smallestValue = comparePosition;
                }
            }
            //Stores the smallest value in a temp variable and switches the smallest Value with the current Position and writes the temp variable too current Position. 
            int temp = NumberArray[smallestValue];
            NumberArray[smallestValue] = NumberArray[currentPosition];
            NumberArray[currentPosition] = temp;
        }
        Console.WriteLine("\nSortiertes Array");
        PrintArray(NumberArray);

    }
    public static int[] insertionSortArray(int[] array, int length)
    {
        //Loops for the length of the Array
        for (int i = 1; i < length; i++)
        {
            var key = array[i];
            var flag = 0;
            //Loops until 
            for (int j = i - 1; j >= 0 && flag != 1;)
            {
                if (key < array[j])
                {
                    array[j + 1] = array[j];
                    j--;
                    array[j + 1] = key;
                }
                else flag = 1;
            }
        }
        return array;
    }
}

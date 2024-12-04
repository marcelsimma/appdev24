using System;
using System.Diagnostics.Contracts;

namespace LucasSchiemann.SortAlgorithmChooser;

public class AlgorythmChooser
{
    public static void ChoseSortAlgorythm()
    {
        Console.WriteLine("Gib ein itlche Arest von Sortalgorhytmus du veritnden möchtest.\n1.BubbleSort\n2.SelectionSort\n3.InsertionSort\n4.MergeSort\n5.QuickSort\n6.HeapSort");
        int UserInput = Convert.ToInt32(Console.ReadLine());
        int[] ArrayToUse = scenarioChooser();
        int[] sortedArray = [];
        int lengthArray = ArrayToUse.GetLength(0);
        int ArrayAccesses = 0;
        switch (UserInput)
        {
            case 1:
                sortedArray = BubbleSort.DoBubbleSort(ArrayToUse, lengthArray);
                break;
            case 2:
                sortedArray = SelectionSort.DoSelectionSort(ArrayToUse, lengthArray);
                break;
            case 3:
                sortedArray = InsertionSort.DoInsertionSort(ArrayToUse,lengthArray);
                break;
            case 4:
                sortedArray = MergeSort.DoMergeSort(ArrayToUse,0,lengthArray-1,lengthArray);
                break;
            case 5:
                sortedArray = QuickSort.DoQuickSort(ArrayToUse,0,lengthArray-1,ArrayAccesses,lengthArray);
                break;
            case 6:
                sortedArray = HeapSort.DoHeapSort(ArrayToUse,lengthArray);
                break;
        }
        
        PrintArray(sortedArray, true);

    }

    public static int[] scenarioChooser()
    {
        int ArrayLenght = getLenthToGenerate();
        Console.WriteLine("Gib an ob du mit einem : \n1. Random Array \n2. Best case sortierten Array \n3.Wost case sortierten Array \narbeiten möchtest.");
        int arraySortTypeInput = Convert.ToInt32(Console.ReadLine());
        
        int[] retArray = [];
        switch (arraySortTypeInput)
        {
            case 1:
                retArray = generateRandomIntegerArray(ArrayLenght);
                break;
            case 2:
                retArray = generateBestCaseArray(ArrayLenght);
                break;
            case 3:
                retArray = generateWorstCaseArray(ArrayLenght);
                break;
        }
        PrintArray(retArray, false);
        return retArray;
    }

    public static int getLenthToGenerate()
    {
        Console.WriteLine("Gib ein wie viel Random Zahlen dein Array haben soll: ");
        int LengthArray = Convert.ToInt32(Console.ReadLine());
        return LengthArray;
    }
    public static int[] generateRandomIntegerArray(int length)
    {
        Random Rand = new Random();
        /*Console.WriteLine("Gib ein wie viel Random Zahlen dein Array haben soll: ");
        int LengthArray = Convert.ToInt32(Console.ReadLine());*/
        int[] unsortedArray = new int[length];

        for (int dimension = 0; dimension < length; dimension++)
        {
            unsortedArray[dimension] = Rand.Next(0, length * 100);
        }
        return unsortedArray;
    }
    public static int[] generateBestCaseArray(int length) {
        int [] bestCaseArray = new int [length];
        for (int i = 0; i < length; i++)
        {
            bestCaseArray[i] = i;
        }
        return bestCaseArray;
    }

    public static int[] generateWorstCaseArray(int length) {
        int [] worstCaseArray = new int [length];
        int currentPos = 0;
        for (int i = length-1;i >= 0; i--)
        {
            worstCaseArray[currentPos] = i;
            currentPos++;
        }
        return worstCaseArray;
    }

    public static void PrintArray(int[] array, bool isArraySorted)
    {
        if (isArraySorted == false)
        {
            Console.WriteLine("Unsortiertes Array");
        }
        else
        {
            Console.WriteLine("\nSortiertes Array");
        }
        foreach (int numbers in array)
        {
            Console.Write(numbers + " ");
        }
        Console.WriteLine();

    }

    public static void PrintArrayAccesses (int Onotation, double best, double worst, string typeOfAlgorithm)
    {
        Console.WriteLine("Der "+ typeOfAlgorithm +" Algorithmus hat folgende Eigenschaften:");
        Console.WriteLine("best:              " + best);
        Console.WriteLine("worst:             " + worst);
        Console.WriteLine("your Arrayaccses:  " + Onotation);
    }
    
    public static float logNCalculator(int lengthOfArray)
    {
        int TempLength = lengthOfArray; 

            try {
                lengthOfArray = lengthOfArray /2;
                
            }
            catch{

            }
            return 0;

    }
}

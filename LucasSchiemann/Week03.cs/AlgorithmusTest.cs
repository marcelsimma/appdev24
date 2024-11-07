using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Xml;
using LucasSchiemann.Week01;

namespace LucasSchiemann.Week03;

public static class AlgorithmTester
{
    public static void ChoseSortAlgorythm()
    {
        Console.WriteLine("Gib ein itlche Arest von Sortalgorhytmus du veritnden möeschtest.\n1.BubbleSort\n2.SelectionSort\n3.InsertionSort\n4.MergeSort\n5.QuickSort\n6.HeapSort");
        int UserInput = Convert.ToInt32(Console.ReadLine());
        // NubmerArray itil wir esabhängig vom Programmfortschritt ein sortiertes/unsortieres haben
        int[] unsortedArray = generateRandomIntegerArray();
        int[] sortedArray = [];
        int[] bestCaseArray = [1, 2, 3, 4, 5, 6, 7, 8];
        int[] worstCaseArray = [8, 7, 6, 5, 4, 3, 2, 1];
        int length = unsortedArray.GetLength(0);
        int leftside = 0;
        int rightSide = unsortedArray.GetLength(0) - 1;
        int ONotation=0;
        switch (UserInput)
        {
            case 1:
                sortedArray = BubbleSort(unsortedArray, length);
                break;
            case 2:
                sortedArray = SelectionSort(worstCaseArray, length);
                break;
            case 3:
                Console.WriteLine("Gib an ob du \n1.Denn Sortierten Array haben möchtest\n2.Best case scenario\n3.Wost case scenario");
                int secondUserInput = Convert.ToInt32(Console.ReadLine());
                switch (secondUserInput)
                {
                    case 1:
                        sortedArray = insertionSortArray(unsortedArray, length);
                        break;
                    case 2:
                        sortedArray = insertionSortArray(bestCaseArray, length);
                        break;
                    case 3:
                        sortedArray = insertionSortArray(worstCaseArray, length);
                        break;
                }
                break;
            case 4: 
                sortedArray = MergeSortArray(unsortedArray, leftside, rightSide,ONotation);
                break;

            case 5:
                sortedArray = QuickSortArray(unsortedArray,leftside,rightSide,ONotation);
                break;

            case 6:
                sortedArray = HeapSortArray(unsortedArray,unsortedArray.GetLength(0));
                break;

            default:
                sortedArray = [];
                break;
        }
        bool isSorted = true;
        PrintArray(sortedArray,isSorted);

    }
    /*
    public static int[] getRightSideOfArray(int length,int[]unsortedArray)
    {
        int[] leftSideArray = [length/2];
        int[] rightSideArray = [length/2];
        int CountOfLength = 0;
        for(int i = 0; i < length/2; i++)
        {
            CountOfLength++;
            leftSideArray[i] = unsortedArray[i];
        }
        for (int j = 0; j < length/2;j++ )
        {
            rightSideArray[j+CountOfLength] = unsortedArray[j+CountOfLength]; 
        }

        return rightSideArray;
    }
    public static int[] getLeftSideOfArray(int length,int[]unsortedArray)
    {
        int[] leftSideArray = [length/2];
        int[] rightSideArray = [length/2];
        int CountOfLength = 0;
        for(int i = 0; i < length/2; i++)
        {
            CountOfLength++;
            leftSideArray[i] = unsortedArray[i];
        }
        for (int j = 0; j < length/2;j++ )
        {
            rightSideArray[j+CountOfLength] = unsortedArray[j+CountOfLength]; 
        }

        return leftSideArray;
    }
    */
    public static void PrintArray(int[] array,bool isArraySorted)
    {
        if (isArraySorted == false){
            Console.WriteLine("Unsortiertes Array");
        }
        else{
        Console.WriteLine("\nSortiertes Array");
        }
        foreach (int numbers in array)
        {
            Console.Write(numbers + " ");
        }
        Console.WriteLine();
    }

    public static void DebugPrintArray(int[] array, int iteration, int secondIteration, string exitFlag)
    {
        Console.Write(exitFlag + " [" + iteration + "." + secondIteration + "] ");
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

        for (int dimension = 0; dimension < LengthArray; dimension++)
        {
            unsortedArray[dimension] = Rand.Next(0, LengthArray * 100);
        }
        bool isSorted = false;
        PrintArray(unsortedArray,isSorted);
        return unsortedArray;
    }
    static int[] BubbleSort(int[] array, int arrayLength)
    {
        for (int ONotationer = 0; ONotationer < arrayLength - 1; ONotationer++)
        {

            for (int positionArray = 0; positionArray < arrayLength - ONotationer - 1; positionArray++)
            {
                if (array[positionArray] > array[positionArray + 1])
                {
                    int temp = array[positionArray];
                    array[positionArray] = array[positionArray + 1];
                    array[positionArray + 1] = temp;
                }
            }
        }
        return array;
    }


    public static int[] SelectionSort(int[] NumberArray, int arrayLength)
    {
        int ONotation = 0;
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
            ONotation++;
        }
        Console.WriteLine("O-Notation operations: " + ONotation);
        return NumberArray;
    }
    public static int[] insertionSortArray(int[] array, int length)
    {

        int ONotation = 0;
        /*for loop:
        1.Beginn The Comparison of the Array on the second position.
        2.Let the Loop Run for the Length of the Array.
        3.Set currentPosition to the next Position.
        */
        for (int currentPosition = 1; currentPosition < length; currentPosition++)
        {
            //DebugPrintArray(array,currentPosition,0,"pre: ");
            //Store the Value of the currentArrayPosition in a Variable
            var currentValue = array[currentPosition];
            //The exitFlag Variable is just a check Variable too see if it should continue the Loop or not.(if currenValue is smaller it continous else it doesnt)
            bool exitFlag = false;
            //int substep = 0;
            /*Second for Loop:
            1.Sets the Position to test if its swapable dimension behind the current Position.
            2.Loops until the exitFlag gets set too zero because it doesnt find anything to swap or when the Variable positionToCompare is smaler than 0.
            */
            for (int positionToCompare = currentPosition - 1; positionToCompare >= 0 && exitFlag == false;)
            {
                ONotation++;
                //Checks if the currentValue is smaller than the positionToCompare.
                if (currentValue < array[positionToCompare])
                {
                    //substep++;
                    //Switches the currentValue to the smallest spot for it / positionToCompare
                    array[positionToCompare + 1] = array[positionToCompare];
                    positionToCompare--;
                    array[positionToCompare + 1] = currentValue;
                    //DebugPrintArray(array,currentPosition,substep,"post:");
                }
                else
                {
                    exitFlag = true;
                }

            }
            ONotation++;
        }
        Console.WriteLine("O-Notation operations: " + ONotation);
        //Returns the Sorted Array
        return array;
    }
/*
    public static void InsertionSort()
    {
        int[] unsortedArray = generateRandomIntegerArray();
        int lengthArray = unsortedArray.GetLength(0);
        int[] sortedArray = insertionSortArray(unsortedArray, lengthArray);
        Console.WriteLine("Dein Unsortiertes Array war: ");
        Console.WriteLine("Dein Sortiertes Array ist: ");
        PrintArray(sortedArray);
    }
*/
    public static int[] MergeSortArray(int[] array, int left, int right,int ONotation)
    {
        
        /*If cause:
        1.Checks if the left side is smaller than the right
        2.Defines the index of the middle with the left and Right Values
        3.Then it recursively calls itself to divide each value in a subarray
        4.It then begins to merch when each array has one element
        */
        if (left < right)
        {
            int middle = left + (right - left) / 2;

            MergeSortArray(array, left, middle,ONotation);
            MergeSortArray(array, middle + 1, right,ONotation);

            int Notation =MergeArray(array, left, middle, right,ONotation);
            Console.WriteLine("O-Notation operations: " + Notation);
        }

        return array;
    }
    public static int MergeArray(int[] array, int left, int middle, int right,int ONotation)
    {
        /* Deffinitions:
        1.It calcilates the length of both the left.- and Right Side of the Array.
        2.Then it takes over those parameters in a Temp Array for each the left and right side.
        */
        
        var leftArrayLength = middle - left + 1;
        var rightArrayLength = right - middle;
        var leftTempArray = new int[leftArrayLength];
        var rightTempArray = new int[rightArrayLength];
        int i, j;

        /*The 2 For Loops:
        Fill those two temp Arrays with the Numbers from the Array  
        */
        for (i = 0; i < leftArrayLength; ++i){
            ONotation++;
            leftTempArray[i] = array[left + i];
            }
        for (j = 0; j < rightArrayLength; ++j){
            ONotation++;
            rightTempArray[j] = array[middle + 1 + j];
            }
        i = 0;
        j = 0;
        int k = left;
        /*The first while Loop:
        1.It compares the elements of the LeftTemparray and rightTempArray
        2.It then swaps their Position if the LeftTempArray is less than or equal to the rightTempArray
        3.Then it stores them in the array on the Position k
        */
        while (i < leftArrayLength && j < rightArrayLength)
        {
            ONotation++;
            if (leftTempArray[i] <= rightTempArray[j])
            {
                array[k++] = leftTempArray[i++];
            }
            else
            {
                array[k++] = rightTempArray[j++];
            }
        }
        /*The second group of While Loops
        Just copies the rest of the elements from the leftTempArray and RightTemparray in the array 
        */
        while (i < leftArrayLength)
        {
            ONotation++;
            array[k++] = leftTempArray[i++];
        }

        while (j < rightArrayLength)
        {
            ONotation++;
            array[k++] = rightTempArray[j++];
        }
        
        return ONotation;
    }
    public static int[] QuickSortArray(int[] array,int leftIndex,int rightIndex,int ONotation)
    {
        
        /*Definitions:
        1.First it makes some Index Variables of the left and right Index-Variables 
        2.Then it sets the pivot to the most left site of the Array
        */
        var leftIterationIndex = leftIndex;
        var rightIterationIndex = rightIndex;
        var pivot = array[leftIndex];
        /*The While Loops:
        1.The first Loop Loops until the LeftIterationIndex is bigger than the rightIterationIndex
        2.The other Two loops check if the element on leftIterationIndex is smaler or rightIterationIndex is bigger, than they skip that index if thats the case.

        /The If cause:
        1.If it find a element in the left side of the array that is bigger than the pivot and an element on the right side that is smaller than the pivot it switches their Positions
        2.Then it Updates teh counter accordingly.
        */
        while(leftIterationIndex <= rightIterationIndex)
        {
            ONotation++;
            while(array[leftIterationIndex] < pivot)
            {
                ONotation++;
                leftIterationIndex++;
            }
            while(array[rightIterationIndex] > pivot)
            {
                ONotation++;
                rightIterationIndex--;
            }
            if(leftIterationIndex <= rightIterationIndex)
            {
                int TempArray = array[leftIterationIndex];
                array[leftIterationIndex] = array[rightIterationIndex];
                array[rightIterationIndex] = TempArray;
                leftIterationIndex++;
                rightIterationIndex--;
            }
        }
        //Because The Quicksort Algorythm is recursiv it calls itself to First Sort the left and than the right side and gives a sorted Array back
        if (leftIndex < rightIterationIndex)
            QuickSortArray(array,leftIndex,rightIterationIndex,ONotation);

        if (leftIterationIndex < rightIndex)
            QuickSortArray(array,leftIterationIndex,rightIndex,ONotation);
        
        return array;
    }

    public static int[] HeapSortArray(int[] array, int size)
{
    //First it checks if the array is empty or not 
    if (size <= 1)
        return array;
    //The first for-Loop calls the Heapify function wich builds the max heap.
    for (int i = size / 2 - 1; i >= 0; i--)
    {
        Heapify(array, size, i);
    }
    //The second for-Loop switches the first element of the Max-Heap with the last element and Rebuilds the max-Heap
    for (int i = size - 1; i >= 0; i--)
    {
        var tempVar = array[0];
        array[0] = array[i];
        array[i] = tempVar;

        Heapify(array, i, 0);
    }
    
    return array;
}
    static void Heapify(int[] array, int size, int index)
{
    /*The Variables:
    1.It first sets the index of the maximum element
    2.Then it sets the left and right children elements   
    */

    var largestIndex = index;
    var leftChild = 2 * index + 1;
    var rightChild = 2 * index + 2;

    if (leftChild < size && array[leftChild] > array[largestIndex])
    {
        largestIndex = leftChild;
    }

    if (rightChild < size && array[rightChild] > array[largestIndex])
    {
        largestIndex = rightChild;
    }

    if (largestIndex != index)
    {
        var tempVariable = array[index];
        array[index] = array[largestIndex];
        array[largestIndex] = tempVariable;

        Heapify(array, size, largestIndex);
    }
}
}

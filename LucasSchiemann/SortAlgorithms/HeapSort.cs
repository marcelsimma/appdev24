using System;

namespace LucasSchiemann.SortAlgorithmChooser;


public class HeapSort
{
    private static double worstONotation;

    private static double bestONotation;

    private static int ArrayAccesses;
    public static int[] DoHeapSort(int[] array,int size)
    {
        ArrayAccesses = 0;
        
        bestONotation =Math.Log10(size) * size;

        worstONotation = bestONotation;                                                   
        
        HeapSortMethod(array,size);
        
        AlgorythmChooser.PrintArrayAccesses(ArrayAccesses, bestONotation, worstONotation, "Merge Sort");
        
        return array;

        
    }
    public static int[] HeapSortMethod(int[] array, int size)
{
    //First it checks if the array is empty or not 
    if (size <= 1)
        return array;   
    //The first for-Loop calls the Heapify function wich builds the max heap.
    for (int i = size / 2 - 1; i >= 0; i--)
    {
        ArrayAccesses++;
        Heapify(array, size, i);
    }
    //The second for-Loop switches the first element of the Max-Heap with the last element and Rebuilds the max-Heap
    for (int i = size - 1; i >= 0; i--)
    {
        ArrayAccesses++;
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
        ArrayAccesses++;
        largestIndex = leftChild;
    }

    if (rightChild < size && array[rightChild] > array[largestIndex])
    {
        ArrayAccesses++;
        largestIndex = rightChild;
    }

    if (largestIndex != index)
    {
        ArrayAccesses++;
        var tempVariable = array[index];
        array[index] = array[largestIndex];
        array[largestIndex] = tempVariable;

        Heapify(array, size, largestIndex);
    }
}
}

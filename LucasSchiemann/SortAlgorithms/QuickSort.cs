using System;

namespace LucasSchiemann.SortAlgorithmChooser;

public class QuickSort
{
    public static int[] DoQuickSort(int[] array, int leftIndex, int rightIndex, int ArrayAceesses)
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
        while (leftIterationIndex <= rightIterationIndex)
        {
            ArrayAceesses++;
            while (array[leftIterationIndex] < pivot)
            {
                ArrayAceesses++;
                leftIterationIndex++;
            }
            while (array[rightIterationIndex] > pivot)
            {
                ArrayAceesses++;
                rightIterationIndex--;
            }
            if (leftIterationIndex <= rightIterationIndex)
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
            DoQuickSort(array, leftIndex, rightIterationIndex, ArrayAceesses);

        if (leftIterationIndex < rightIndex)
            DoQuickSort(array, leftIterationIndex, rightIndex, ArrayAceesses);

        return array;
    }




}
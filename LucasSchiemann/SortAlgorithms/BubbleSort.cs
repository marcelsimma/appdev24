using System;

namespace LucasSchiemann.SortAlgorithmChooser;

public class BubbleSort
{
    public static int[] DoBubbleSort(int[] array, int arrayLength)
    {
        int ArrayAceesses = 0;
        double bestONotation = arrayLength;
        double worstONotation = Math.Pow(arrayLength,2);
        for (int CurrentPositionOfArray = 0; CurrentPositionOfArray < arrayLength - 1; CurrentPositionOfArray++)
        {
            ArrayAceesses++;
            for (int positionArray = 0; positionArray < arrayLength - CurrentPositionOfArray - 1; positionArray++)
            {
                ArrayAceesses++;
                if (array[positionArray] > array[positionArray + 1])
                {
                    int temp = array[positionArray];
                    array[positionArray] = array[positionArray + 1];
                    array[positionArray + 1] = temp;
                }
            }
        }
        AlgorythmChooser.PrintArrayAccesses(ArrayAceesses, bestONotation, worstONotation, "bubble Sort");
        return array;
    }


}
using System;

namespace LucasSchiemann.SortAlgorithmChooser;

public class SelectionSort
{
    public static int[] DoSelectionSort(int[] NumberArray,int arrayLength)
    {
        double bestONotation = arrayLength;
        double worstONotation = Math.Pow(arrayLength,2);
        int ArrayAcesses = 0;
        /* for loop:
            1.Startposition(currentPosition) auf 0 setzen.
            2.Bedingung wie lang der loop läuft.
            3.currentPosition wird auf die nächste Position gesetzt*/

        // loopen über das complette array    
        for (int currentPosition = 0; currentPosition < arrayLength - 1; currentPosition++)
        {
            ArrayAcesses++;
            // store the current position of the first loop in a variable
            int smallestValue = currentPosition;

            // loop über das verbleibende Array
            for (int comparePosition = currentPosition + 1; comparePosition < arrayLength; comparePosition++)
            {
                ArrayAcesses++;
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
        AlgorythmChooser.PrintArrayAccesses(ArrayAcesses,bestONotation,worstONotation,"Selection Sort");



        return NumberArray;
    }


}
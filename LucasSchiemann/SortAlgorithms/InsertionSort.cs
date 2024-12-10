using System;
using LucasSchiemann.Week03;

namespace LucasSchiemann.SortAlgorithmChooser;

public class InsertionSort
{
    public static int[] DoInsertionSort(int[] array, int length)
    {

        int ArrayAceesses = 0;
        double best = length;
        double worst = Math.Pow(length,2);
        /*for (int i = 1; i<length; i++) {
            worst += i;
        }*/
        
        /*for loop:
        1.Beginn The Comparison of the Array on the second position.
        2.Let the Loop Run for the Length of the Array.
        3.Set currentPosition to the next Position.
        */
        for (int currentPosition = 1; currentPosition < length; currentPosition++)
        {
            ArrayAceesses++;
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
                ArrayAceesses++;
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
            ArrayAceesses++;
        }
        AlgorythmChooser.PrintArrayAccesses(ArrayAceesses, best, worst, "Insetion Sort");
        //Returns the Sorted Array
        return array;
    }





}
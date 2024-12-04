using System;
using System.Security;
using System.Xml.Serialization;
using LucasSchiemann.Week02;

namespace LucasSchiemann.SortAlgorithmChooser;

public class MergeSort
{

    public  static int ArrayAccesses = 0 ;
    private static double bestONotation;
    private static double worstONotation;       
    
    public static int [] DoMergeSort (int[] array, int left, int right,int arraylength)
    {

        ArrayAccesses = 0;  

        bestONotation =Math.Log10(arraylength) * arraylength;

        worstONotation = bestONotation;
                                                    
        
        MergeSortMethod(array,left,right,arraylength);
        
        AlgorythmChooser.PrintArrayAccesses(ArrayAccesses, bestONotation, worstONotation, "Merge Sort");
        
        return array;
    
    }
    public static int[] MergeSortMethod( int[] array, int left, int right,int arraylength)
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

            MergeSortMethod(array, left, middle,arraylength);
            MergeSortMethod(array, middle + 1, right,arraylength);

            MergeArray(array, left, middle, right);
        }
        
        return array;
    }
    public static void MergeArray(int[] array, int left, int middle, int right)
    {
        /* Deffinitions:
        1.It calculates the length of both the left.- and Right Side of the Array.
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
            ArrayAccesses++;
            leftTempArray[i] = array[left + i];
            }
        for (j = 0; j < rightArrayLength; ++j){
            ArrayAccesses++;
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
            ArrayAccesses++;
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
            ArrayAccesses++;
            array[k++] = leftTempArray[i++];
        }

        while (j < rightArrayLength)
        {
            ArrayAccesses++;
            array[k++] = rightTempArray[j++];
        }

        
    }
    public static void countArrayaccesses(int ArrayAccesses)
    {

        ArrayAccesses++;
    
    }
    
}
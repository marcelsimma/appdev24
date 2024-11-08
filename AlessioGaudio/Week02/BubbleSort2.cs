using System;

namespace AlessioGaudio.Week02
{
    class BubbleSort2
    {
        public static void Start()
        {
            int[] array = { 64, 34, 25, 12, 22, 11, 90, 100, 88 };

            for (int j = 0; j < array.Length - 1; j++)
            {

                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int tmp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = tmp;
                    }
                }
            }






            PrintArray(array);
        }

        public static void PrintArray(int[] arrayToPrint)
        {
            for (int i = 0; i < arrayToPrint.Length; i++)
            {
                Console.WriteLine(arrayToPrint[i]);
            }
        }

    }
}

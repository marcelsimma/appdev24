using System;

namespace SimonJochum.Week02
{
    public class BubbleSort
    {
        public static void Start()
        {
            
            int[] number = { 89, 76, 45, 92, 67, 12, 99 };
            int temp;

            for (int i = 0; i < number.Length - 1; i++)
            {
                for (int j = 0; j < number.Length - 1; j++)
                {
                    if (number[j] > number[j+1])
                    {
                        temp = number[j+1];
                        number[j+1] = number[j];
                        number[j] = temp;
                    }
                }
            }
            Console.WriteLine("Sortiert: ");
            foreach (int sorted in number)
            {
                Console.Write($"{sorted} ");
            }
        }
    }
}
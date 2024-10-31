using System.Reflection.Metadata.Ecma335;

namespace BarbaraMarte.Week02;

class Bubbelsort
{
    public static void PrintBubblesort()
    {
        int[] numbers = new int[10];
        //Console.WriteLine("Enter 10 Numbers:");
        int temp;
        //numbers[i] = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < numbers.Length - 1; i++)
        {

        }
        for (int j = 0; j <= numbers.Length - 1; j++)
        {
            if (numbers[j] > numbers[j + 1])
            {
                temp = numbers[j + 1];
                numbers[j + 1] = numbers[j];
                numbers[j] = temp;
            }
        }
        Console.WriteLine("Sort: ");
        foreach (int sorted in numbers)
        {
            Console.Write(sorted);
        }
    }
}
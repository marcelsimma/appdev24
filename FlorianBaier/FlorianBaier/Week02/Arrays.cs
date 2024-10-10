using System;

namespace FlorianBaier.Week02
{

    public class Arrays
    {

        public static void Start()
        {
        int arraySize = 100;
        int[] randomNumbers = new int[arraySize];
        Random random = new Random();

        for (int i = 0; i < arraySize-1; i++)
        {
            randomNumbers[i] = random.Next(-50, 51);
            Console.WriteLine(randomNumbers[i]);
        }
        Console.WriteLine($"Die größte Zahl des Array ist {randomNumbers.Max()}");
        Console.WriteLine($"Die kleinste Zahl des Array ist {randomNumbers.Min()}");
        Console.WriteLine($"Der Mittelwert ist {randomNumbers.Average()}");
        Console.WriteLine();
        }
    }
}
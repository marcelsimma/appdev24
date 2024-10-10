using System;

namespace FlorianBaier.Week02
{

    public class Arrays
    {

        public static void Start()
        {
          
            int[] array = new int[100];
            Random rand = new Random();
            int maxValue = array[0];
            int minValue = array[0];
            double sum = 0;
            double sumOfAbsoluteValues = 0;

            foreach (int value in array)
            {
                if (value > maxValue)
                    maxValue = value;
                if (value < minValue)
                    minValue = value;

                sum += value;
                sumOfAbsoluteValues += Math.Abs(value);
            }
            double average = sum / array.Length;
            double averageOfAbsoluteValues = sumOfAbsoluteValues / array.Length;
            Console.WriteLine($"Größter Wert: {maxValue}");
            Console.WriteLine($"Kleinster Wert: {minValue}");
            Console.WriteLine($"Durchschnittswert: {average}");
            Console.WriteLine($"Durchschnittswert der Beträge: {averageOfAbsoluteValues}");
        }
    }
}
  /*int arraySize = 100;
            int[] randomNumbers = new int[arraySize];
            Random random = new Random();

            for (int i = 0; i < arraySize-1; i++)
            {
                randomNumbers[i] = random.Next(-50, 51);
                Console.WriteLine(randomNumbers[i]);
            }
            Console.WriteLine($"Die größte Zahl des Array ist {randomNumbers.Max()}");
            Console.WriteLine($"Die kleinste Zahl des Array ist {randomNumbers.Min()}");
            Console.WriteLine($"Der Mittelwert ist {randomNumbers.Average()}");*/
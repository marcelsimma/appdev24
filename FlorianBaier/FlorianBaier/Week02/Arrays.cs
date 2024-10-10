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

            for (int i = 0; i < arraySize; i++)
            {
                randomNumbers[i] = random.Next(-50, 51);
                Console.WriteLine(randomNumbers[i]);
            }
            
            int sum = 0;
            
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                if (randomNumbers[i] > 0)
                {
                    sum += randomNumbers[i];
                }
                else
                {
                    sum += randomNumbers[i] * (-1);
                }
            }
            
            double averageAbsValue = sum / randomNumbers.Length;

            Console.WriteLine($"Die größte Zahl des Array ist {randomNumbers.Max()}");
            Console.WriteLine($"Die kleinste Zahl des Array ist {randomNumbers.Min()}");
            Console.WriteLine($"Der Mittelwert ist {randomNumbers.Average()}");
            Console.WriteLine($"Der Betrag ist {averageAbsValue}");


        }
    }
}
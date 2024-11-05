using System;

namespace JonasWehinger.Week02
{
    public class Array
    {
        public static void StartStart()
        {
            int[] randomNumbers = new int[100];
            Random random = new Random();
for (int i = 0; i < randomNumbers.Length; i++)
        {
            randomNumbers[i] = random.Next(-50, 51); 
        }

       
        int max = randomNumbers[0];
        int min = randomNumbers[0];
        int sum = 0;

        for (int i = 0; i < randomNumbers.Length; i++)
        {
            if (randomNumbers[i] > max)
            {
                max = randomNumbers[i];
            }
            if (randomNumbers[i] < min)
            {
                min = randomNumbers[i];
            }
            sum += randomNumbers[i];
        }

        
        double average = (double)sum / randomNumbers.Length;

        
        Console.WriteLine("Größter Wert: " + max);
        Console.WriteLine("Kleinster Wert: " + min);
        Console.WriteLine("Durchschnitt: " + average);
    }
}
}
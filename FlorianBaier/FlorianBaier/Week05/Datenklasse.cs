using System;

namespace FlorianBaier.Week05
{
    //Klasse
    public class Datenklasse
    {
        int[] Numbers { get; }
        int SmallestValue { get; }
        int HighestValue { get; }
        double Average { get; }

        // Konstruktor
        public Datenklasse(int[] numbers)
        {
            Numbers = numbers;
            SmallestValue = FindSmallestValue();
            HighestValue = FindHighestValue();
            Average = CalculateAverage();
        }

        //Print Methode für Ausgabe
        public static void Print()
        {
            Random rand = new Random();
            int[] randomNumbers = GenerateRandomNumberArray(rand, 10);

            Datenklasse data = new Datenklasse(randomNumbers);

            Console.WriteLine(data.ToString());
        }

        public override string ToString()
        {
            return $"Numerical values:\nSmallestValue = {SmallestValue}\nHighestValue = {HighestValue}\nAverage = {Average:F2}";
        }

        public int FindSmallestValue()
        {
            int min = Numbers[0];
            foreach (int num in Numbers)
            {
                if (num < min)
                {
                    min = num;
                }
            }
            return min;
        }

        public int FindHighestValue()
        {
            int max = Numbers[0];
            foreach (int num in Numbers)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }

        public double CalculateAverage()
        {
            double summe = 0;
            foreach (int num in Numbers)
            {
                summe += num;
            }
            return summe / Numbers.Length;
        }

        public static int[] GenerateRandomNumberArray(Random rand, int size)
        {
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = rand.Next(-50, 51);
            }
            return array;
        }
    }
}
using System;
using System.Diagnostics;
namespace JulianStroehle.Week3
{
    public class Sort
    {
        public static void Start()
        {

            // Nutzereingabe
            Console.WriteLine("Wie viele Zahlen möchten Sie sortieren?");
            int count = Convert.ToInt32(Console.ReadLine());

            // Erstellung des Arrays
            int[] numbers = new int[count];
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i + 1}. Zahl");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Auswahl der Sortieralgorithmen
            Console.WriteLine("Welchen Sortieralgorithmus wollen Sie verwenden?");
            Console.WriteLine("1 = Selection Sort\n2 = Insertion Sort\n3 = Quick Sort\n15 = Bogo Sort");
            int alg = Convert.ToInt32(Console.ReadLine());
            switch (alg)
            {
                case 1: SelectionSort(numbers); break;
                case 2: InsertionSort(numbers); break;
                case 3: QuickSort(numbers); break;
                case 15: BogoSort(numbers); break;
            }
        }
        static void SelectionSort(int[] numbers)
        {

            // Wertselektierung und Verschiebung
            for (int i = 0; i < numbers.Length; i++)
            {
                int changes;
                do
                {
                    changes = 0;
                    for (int j = 0; j < numbers.Length; j++)
                    {
                        if (numbers[i] < numbers[j])
                        {
                            int ph = numbers[i];
                            numbers[i] = numbers[j];
                            numbers[j] = ph;
                            changes++;
                        }
                    }

                    // Ausgabe der Zahlen nach der Verschiebung
                    if (changes == 0)
                    {
                        for (int k = 0; k < numbers.Length; k++)
                        {
                            Console.Write(numbers[k] + " ");
                        }
                    }
                    Console.WriteLine();
                }
                while (changes != 0);
            }
        }
        static void InsertionSort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                int changes;
                do
                {
                    changes = 0;
                    for (int j = 0; j <= i; j++)
                    {
                        for (int k = j; k >= 0; k--)
                        {
                            if (numbers[j] < numbers[k])
                            {
                                (numbers[j], numbers[k]) = (numbers[k], numbers[j]);
                                changes++;
                            }
                        }
                    }
                    if (changes == 0)
                    {
                        Console.WriteLine();
                        foreach (int k in numbers)
                        {
                            Console.Write(k + " ");
                        }
                    }
                }
                while (changes != 0);
                Console.WriteLine();
            }
        }
        static void QuickSort(int[] numbers)
        {
            numbers = Pivot(numbers, 0, numbers.Length - 1);

            // Ausgabe des sortierten Arrays
            foreach (int i in numbers)
            {
                Console.Write(i + " ");
            }
        }
        static int[] Pivot(int[] numbers, int SmallerPiv, int BiggerPiv)
        {
            
            // Zuweisung Array Index und Dreh- und Angelpunkt
            int pivot = numbers[SmallerPiv];
            int i = SmallerPiv;
            int j = BiggerPiv;

            // Verschachtelte while-Schleifen für Arrayposition
            while (i <= j)
            {
                while (numbers[i] < pivot)
                {
                    i++;
                }
                while (numbers[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    (numbers[i], numbers[j]) = (numbers[j], numbers[i]);
                    i++;
                    j--;
                }
            }

            // Ausgabe Zwischenstand der Zahlen
            foreach (int k in numbers)
            {
                Console.Write(k + " ");
            }
            Console.WriteLine();

            // Neustart der Methode wenn sie noch nicht richtig sortiert ist
            if (SmallerPiv < j)
            {
                Pivot(numbers, SmallerPiv, j);
            }
            if (i < BiggerPiv)
            {
                Pivot(numbers, i, BiggerPiv);
            }

            // Rückgabe des sortierten Arrays
            return numbers;
        }
        public static void BogoSort(int[] numbers)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            bool right;
            int tries = 0;
            Random rdm = new Random();
            do
            {
                right = true;
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        right = false;
                    }
                }
                if (right != true)
                {
                    rdm.Shuffle(numbers);
                }
                foreach (int i in numbers)
                {
                    Console.Write(i + "\t");
                }
                Console.WriteLine();
                tries++;
                if (tries > 100000)
                {
                    break;
                }
            }
            while (right == false);
            if (tries < 100000)
            {
                stopwatch.Stop();
                TimeSpan ts = stopwatch.Elapsed;
                string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}.{3:00}{4:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds, ts.Microseconds);
                Console.WriteLine("\nRunTime: " + elapsedTime);
                Console.WriteLine("Anzahl der versuche: " + (tries - 1));
            }
            else
            {
                Console.WriteLine("\nFehler, zu viele Zahlen.\n");
            }
        }
    }
}
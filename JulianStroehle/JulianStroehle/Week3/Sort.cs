using System;
using System.Diagnostics;
namespace JulianStroehle.Week3
{
    public class Sort
    {
        public static void Start()
        {
            Console.WriteLine("Zufällige Zahlen (z) oder selbst Zahlen einfügen (e)?");
            string? choose = Console.ReadLine();
            Random rdm = new();
            int[] numbers = { 0 };
            if (choose == "z")
            {
                Console.WriteLine("Wie viele Zahlen ausgeben?");
                numbers = new int[Convert.ToInt32(Console.ReadLine())];
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = rdm.Next(0, 100);
                }
            }
            if (choose == "e")
            {

                // Nutzereingabe
                Console.WriteLine("Wie viele Zahlen möchten Sie sortieren?");
                int count = Convert.ToInt32(Console.ReadLine());

                // Erstellung des Arrays
                numbers = new int[count];
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine($"{i + 1}. Zahl");
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Auswahl der Sortieralgorithmen
            Console.WriteLine("Welchen Sortieralgorithmus wollen Sie verwenden?");
            Console.WriteLine("1 = Selection Sort\n2 = Insertion Sort\n3 = Quick Sort\n4 = Merge Sort\n5 = Heap Sort\n11 = Bubble Sort\n15 = Bogo Sort");
            int alg = Convert.ToInt32(Console.ReadLine());
            switch (alg)
            {
                case 1: SelectionSort(numbers); break;
                case 2: InsertionSort(numbers); break;
                case 3: QuickSort(numbers); break;
                case 4: MergeSort(numbers); break;
                case 5: HeapSort(numbers); break;
                case 11: BubbleSort(numbers); break;
                case 15: BogoSort(numbers, rdm); break;
            }
        }
        static void SelectionSort(int[] numbers)
        {
            int Insert = 0;
            do
            {
                int MinPos = Insert;
                for (int i = Insert + 1; i < numbers.Length; i++)
                {
                    if (numbers[i] < numbers[MinPos])
                    {
                        MinPos = i;
                    }
                }
                (numbers[MinPos], numbers[Insert]) = (numbers[Insert], numbers[MinPos]);
                Insert++;
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write(numbers[i] + " ");
                }
                Console.WriteLine("\n");
            }
            while (Insert < numbers.Length);
        }
        static void InsertionSort(int[] numbers)
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
        static void MergeSort(int[] numbers)
        {
            int left = 0;
            int right = numbers.Length - 1;
            SortArray(numbers, left, right);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
        static int[] SortArray(int[] numbers, int left, int right)
        {
            if (left < right)
            {
                int middle = left + (right - left) / 2;
                SortArray(numbers, left, middle);
                SortArray(numbers, middle + 1, right);
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write(numbers[i] + " ");
                }
                Console.WriteLine("\n");
                MergeArray(numbers, left, middle, right);
            }
            return numbers;
        }
        static void MergeArray(int[] numbers, int left, int middle, int right)
        {
            var LengthLeft = middle - left + 1;
            var LengthRight = right - middle;
            var TempArrayLeft = new int[LengthLeft];
            var TempArrayRight = new int[LengthRight];
            int i, j;
            for (i = 0; i < LengthLeft; i++)
            {
                TempArrayLeft[i] = numbers[left + i];
            }
            for (j = 0; j < LengthRight; j++)
            {
                TempArrayRight[j] = numbers[middle + 1 + j];
            }
            i = 0;
            j = 0;
            int k = left;
            while (i < LengthLeft && j < LengthRight)
            {
                if (TempArrayLeft[i] <= TempArrayRight[j])
                {
                    numbers[k++] = TempArrayLeft[i++];
                }
                else
                {
                    numbers[k++] = TempArrayRight[j++];
                }
            }
            while (i < LengthLeft)
            {
                numbers[k++] = TempArrayLeft[i++];
            }
            while (j < LengthRight)
            {
                numbers[k++] = TempArrayRight[j++];
            }
        }
        static void HeapSort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine("\n");
            Heap(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine("\n");
        }
        static void Heap(int[] numbers)
        {
            BuildHeap(numbers);
            for (int i = numbers.Length - 1; i > 0; i--)
            {
                (numbers[0], numbers[i]) = (numbers[i], numbers[0]);
                ShiftDown(numbers, i, 0);
                for (int j = 0; j < numbers.Length; j++)
                {
                    Console.Write(numbers[j] + " ");
                }
                Console.WriteLine("\n");
            }
        }
        static void BuildHeap(int[] numbers)
        {
            for (int i = numbers.Length / 2; i >= 0; i--)
            {
                ShiftDown(numbers, numbers.Length, i);
            }
        }
        static void ShiftDown(int[] numbers, int length, int i)
        {
            if (2 * i >= length)
            {
                return;
            }
            int j = i * 2;
            if ((i * 2 + 1 < length) && (numbers[i * 2] < numbers[i * 2 + 1]))
            {
                j++;
            }
            if (numbers[i] < numbers[j])
            {
                (numbers[i], numbers[j]) = (numbers[j], numbers[i]);
                ShiftDown(numbers, length, j);
            }
        }
        static void BubbleSort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j + 1];
                        numbers[j + 1] = numbers[j];
                        numbers[j] = temp;
                    }
                }
                foreach (int k in numbers)
                {
                    Console.Write($"{k} ");
                }
                Console.WriteLine();
            }
            foreach (int k in numbers)
            {
                Console.Write($"{k} ");
            }
        }
        static void BogoSort(int[] numbers, Random rdm)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            bool right;
            int tries = 0;
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
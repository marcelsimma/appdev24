using System;
using System.Diagnostics.Metrics;

namespace MagdalenaMueller.Week02
{
    public class Bubblesorter
    {
        public static void BubblesorterProgram()
        {
            Random r = new Random();
            int[] array = new int[8]; 

            // Fülle das Array mit Zufallszahlen
            for (int i = 0; i < array.Length; i++)
            {      
                array[i] = r.Next(0, 20);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            // Bubble Sort mit Zähler
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        // Vertauschen der Elemente
                        array[i] = array[i] + array[i + 1];
                        array[i + 1] = array[i] - array[i + 1];
                        array[i] = array[i] - array[i + 1];
                        swapped = true; 
                    }
                }
                
            } while (swapped); 

            // Ausgabe des sortierten Arrays
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}
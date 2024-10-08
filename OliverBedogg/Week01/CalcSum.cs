using System;

namespace OliverBedogg.Week01
{
    public class CalcSum
    {
        public static void Start(int minValue, int maxValue)
        {
            int sum = 0;
            Console.WriteLine($"Summe von {minValue} bis {maxValue} addiert");
            Console.WriteLine(new string('-', 10));

            for (int i = minValue; i <= maxValue; i++)
            {
                // TODO: Add(...) zur Summenberechnung verwenden
                // sum = ...
                // bsp-Ausgabe:
                // rechenweg 20 + 21 = 41
                // rechenweg 41 + 22 = 63

                Console.Write($"Rechenweg {sum} + {i} = ");
                sum = Add(sum, i);
                Console.WriteLine(sum);
            }
            Console.WriteLine(new string('-', 10));
            Console.WriteLine("Gesamt: " + sum + " | Kontrollsumme: " + Summ(minValue, maxValue));
        }

        public static int Add(int a, int b)
        {
            int result = a + b;

            return result;
        }

        public static int Summ(int minValue, int maxValue)
        {
            int result = 0;
            for (int i = minValue; i <= maxValue; i++)
            {
                result += i;
            }
            return result;
        }
    }
}
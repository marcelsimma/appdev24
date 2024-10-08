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
            Console.WriteLine("Gesamt: " + sum + " | Kontrollsumme: " + TestSum(minValue, maxValue));
        }

        public static int Add(int a, int b)
        {
            int result = a + b;

            return result;
        }

        public static int TestSum(int minValue, int maxValue)
        {
            int result = 0;
            for (int i = minValue; i <= maxValue; i++)
            {
                result += i;
            }
            return result;
        }

        public static void PrintSummeNico()
        {
            int start = 20;
            int end = 50;
            // TODO variablen als Funktionsparameter setzen
            int sum = calcSumNico(start, end);

            // TODO diese Zeile über den Funktionsaufruf setzen:
            Console.WriteLine($"Summe von {start} bis {end} addiert\n");

            Console.WriteLine($"Die Gesamt-Summe ist: {sum}");
        }

        static int calcSumNico(int start, int end)
        {
            int sum = 0;

            for (int i = start; i <= end; i++)
            {
                if (i == start)
                {
                    sum = i; // Setze die Summe mit dem ersten Wert
                    // TODO sum = 20. if-else kann durch den else-code ersetzt werden
                }
                else
                {
                    sum = addNico(sum, i);
                }
            }

            return sum;
        }

        static int addNico(int a, int b)
        {
            int result = a + b;
            Console.WriteLine($"rechenweg {a} + {b} = {result}");
            return result;
        }

    }
}
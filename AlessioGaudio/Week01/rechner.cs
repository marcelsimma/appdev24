using System;

namespace AlessioGaudio.Week01
{
    class Rechner
    {
        public static void Start()
        {
            int result = calcSum(20, 50);
            Console.WriteLine("--------------------");
            Console.WriteLine("Endergebnis: " + result);
        }

        public static int calcSum(int start, int end)
        {
            int sum = start;

            for (int i = start + 1; i <= end; i++) // Verwendung einer for-Schleife
            {
                sum = add(sum, i); // Addiere und zeige Rechenweg
            }

            return sum;
        }

        public static int add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine($"Rechenweg: {a} + {b} = {result}");
            return result;
        }
    }
}

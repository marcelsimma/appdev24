using System;

namespace BerkantAkinci.Week02
{

    class Factorial
    {
        public static void PrintFactorial(long a, long b)
        {
            long ergebnis = a;

            for (long i = 1; i <= b; i++)
            {
                ergebnis *= i;

                System.Console.WriteLine($"{i,2}! = {ergebnis,20}"); //die Zahlen neben "i" und "Ergebnis" geben die Anzahl an besetzten "Plätzen" wieder
            }
        }
    }
}
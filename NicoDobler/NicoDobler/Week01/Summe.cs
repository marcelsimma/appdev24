using System;
namespace NicoDobler.Week01{


class Summe
{
   public static void PrintSumme()
    {
        int start = 20;
        int end = 50;
        int sum = calcSum(start, end);
        
        Console.WriteLine($"Summe von {start} bis {end} addiert");
        Console.WriteLine();
        Console.WriteLine($"Die Gesamt-Summe ist: {sum}");
    }

    static int calcSum(int start, int end)
    {
        int sum = 0;
        
        for (int i = start; i <= end; i++)
        {
            if (i == start)
            {
                sum = i; // Setze die Summe mit dem ersten Wert
            }
            else
            {
                sum = add(sum, i);
            }
        }

        return sum;
    }

    static int add(int a, int b)
    {
        int result = a + b;
        Console.WriteLine($"rechenweg {a} + {b} = {result}");
        return result;
    }
}
}
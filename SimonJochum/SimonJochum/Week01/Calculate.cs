using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace SimonJochum.Week01
{
    public class Calculate
    {


        public static void Calc(int min, int max)
        {
            int sum = 0;

            Console.WriteLine("Summe von 20 bis 50 addiert:");


            for (int i = min; i <= max; i++)
            {
                // Wird ausgeführt wenn die Summe (sum) 0 beträgt, was in diesem Fall nur beim 1. mal zutrifft
                if (sum == 0)
                {
                    sum = i; // Die erste Zahl der Schleife wird als Startwert verwendet (hier ist es die 20)
                }
                else
                {
                    Console.WriteLine($"Rechenweg: {sum} + {i} = {sum + i}");
                    sum += i; // Aktuelle Zahl wird zur Summe hinzugefügt
                }

                // Ausgabe der Gesamtsumme nach jeder Rechnung
                Console.WriteLine($"Die Gesamtsumme ist: {sum}");
            }
        }
    }
}
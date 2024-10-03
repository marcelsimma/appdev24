using System;

namespace SimonJochum.Week01
{
    public class Calculate
    {


        public static void Calc()
        {
            int sum = 0;

            Console.WriteLine("Summe von 20 bis 50 addiert:");


            for (int i = 20; i <= 50; i++)
            {
                // Wird ausgeführt wenn die Summe (sum) 0 beträgt, was in diesem Fall nur beim 1. mal zutrifft
                if (sum == 0)
                {
                    sum = i; // Die erste Zahl der Schleife wird als Startwert verwendet (hier ist es die 20)
                }
                else
                {
                    Console.WriteLine($"Rechenweg: {sum} + {i} = {sum + i}");
                    sum += i; // Aktuelle Zahl wird zur Summe hinzugefügt (mit =+ wird der Wert der sum nicht überschrieben!)
                }

                // Ausgabe der Gesamtsumme nach jeder Rechnung
                Console.WriteLine($"Die Gesamtsumme ist: {sum}");
            }
        }

    }
}
using System;
using System.Linq; // Um LINQ für Max, Min, Average zu verwenden

namespace MarcelSimma.Week02
{

    class RandomNumberArray
    {
        public static void Start()
        {
            // Erstelle ein Array mit der Größe 100
            int[] array = new int[100];

            // Initialisiere den Zufallsgenerator
            Random random = new Random();

            // Befülle das Array mit zufälligen Werten zwischen -50 und +50
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-50, 51); // Random.Next() gibt Werte von -50 bis +50 zurück
            }

            // Den größten Wert ermitteln
            int maxValue = array.Max();

            // Den kleinsten Wert ermitteln
            int minValue = array.Min();

            // Den Durchschnittswert ermitteln
            double averageValue = array.Average();

            // Den Durchschnittswert der Beträge (absoluten Werte) ermitteln
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    sum += array[i];
                }
                else
                {
                    sum += (array[i] * (-1));
                }
            }
            
            double averageAbsValue = sum / array.Length;


            // Ausgabe der Ergebnisse
            Console.WriteLine("Größter Wert: " + maxValue);
            Console.WriteLine("Kleinster Wert: " + minValue);
            Console.WriteLine("Durchschnittswert: " + averageValue);
            Console.WriteLine("Durchschnittswert der Beträge: " + averageAbsValue);
        }
    }

}

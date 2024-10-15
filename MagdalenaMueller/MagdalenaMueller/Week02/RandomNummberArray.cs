using System;
using System.Diagnostics.Contracts;

namespace MagdalenaMueller.Week02
{
    public class RadndomNumbertsArray
    {
        public static void RadndomNumbersArrayProgramm()
        {
            // Random und Array erstellen
            Random random = new Random();
            int[] nummberArray = new int[100];

            // Max, Min und Mittelwert erstellen
            int max = -50;
            int min = 50;
            double average = 0;
            double bertragaverage = 0;

            // Array füllen
            for (int i = 0; i < nummberArray.Length; i++)
            {
                int randomNumber = random.Next(-50, 50);
                nummberArray[i] = randomNumber;

                // Min und Max überschreiben
                if (nummberArray[i] > max)
                {
                    max = nummberArray[i];
                }
                if (nummberArray[i] < min)
                {
                    min = nummberArray[i];
                }

                // Array addieren für Mittelwert
                average += nummberArray[i];
            }

            // Mittelwert berechnen
            average /= nummberArray.Length;

            // Array addieren für Betrag
            for(int i = 0; i <= nummberArray.Length - 1; i++)
            {
                if(nummberArray[i] < 0)
                {
                    bertragaverage += nummberArray[i] * -1;
                }
                else
                {
                    bertragaverage += nummberArray[i];
                }
                
            }
            //Betrag Mittelwert berechnen
            bertragaverage /= nummberArray.Length;

            // Ausgeben Min, Max und Mittelwert 
            Console.WriteLine($"Max: {max}");
            Console.WriteLine($"Min: {min}");
            Console.WriteLine($"Mittelwert: {average}");
            Console.WriteLine($"Betrag Mittelwert: {Math.Round(bertragaverage, 2)}");
        }
    }
}

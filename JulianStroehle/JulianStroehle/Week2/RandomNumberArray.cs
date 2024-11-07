using System;
namespace JulianStroehle.Week2
{
    public class RandomNumberArray
    {
        public static void Start()
        {

            // Array und Randomizer erstellen
            int[] Nums = new int[100];
            Random random = new Random();

            // Schleife zum Hochzählen für zufällige Zahlen
            for (int i = 0; i < 100; i++)
            {
                Nums[i] = random.Next(-50, 50);
            }

            // Integer für kleinste und größte Zahl
            int smol = Nums.Min();
            int larg = Nums.Max();

            // Berechnung des Durchschnitts ohne .Average Funktion
            double placeholder = Convert.ToDouble(Nums.Sum());
            double Avg = Math.Round(placeholder / Nums.Length, 2);

            // 2. Schleife um Negative in Positive Zahlen umzuwandeln
            for (int j = 0; j < Nums.Length; j++)
            {
                if (Nums[j] < 0)
                {
                    Nums[j] *= -1;
                }
            }

            // 2. Durchschnitt berechnen, diesmal nur mit positiven Zahlen
            double placeholder2 = Convert.ToDouble(Nums.Sum());
            double Avg2 = Math.Round(placeholder2 / Nums.Length, 2);

            // Ausgabe der Werte
            Console.WriteLine($"\nGrößte Zahl:{larg}\nDurchschnittszahl:{Avg}\nKleinste Zahl:{smol}\nDurchschnitt der Beträge:{Avg2}\n");
        }
    }
}
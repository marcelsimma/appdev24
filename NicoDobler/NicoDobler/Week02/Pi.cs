using System;
 
namespace NicoDobler.Week02
{
    class SummePi
    {
        public static void Start()
        {
            // Anzahl der Iterationen (je mehr Iterationen, desto genauer das Ergebnis)
            int iterations = 1000000; // Passe die Anzahl an, je nach gewünschter Genauigkeit
            double pi = 0.0;
 
            for (int i = 0; i < iterations; i++)
            {
                // Berechnung des aktuellen Terms der Leibniz-Reihe
                double term = Math.Pow(-1, i) / (2 * i + 1);
                pi += term;
            }
 
            // Multipliziere das Ergebnis mit 4, um Pi zu erhalten
            pi *= 4;
 
            // Ausgabe des Ergebnisses
            Console.WriteLine($"Berechneter Wert für Pi nach {iterations} Iterationen: {pi}");
            Console.WriteLine($"Genauigkeit: {Math.Abs(Math.PI - pi)}");
        }
    }
}


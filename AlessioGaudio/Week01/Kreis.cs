using System;

namespace AlessioGaudio.Week01
{
    class Kreis
    {
        public static void Start()
        {
            PrintCircle('o', 10); // Beispielaufruf mit Radius 10
        }

        public static void PrintCircle(char character, int radius)
        {
            double thickness = 0.4;  // Dicke des Kreises
            double r_in = radius - thickness;
            double r_out = radius + thickness;

            for (int y = -radius; y <= radius; y++)
            {
                for (int x = -radius; x <= radius; x++)
                {
                    double value = x * x + y * y;
                    if (value >= r_in * r_in && value <= r_out * r_out)
                    {
                        Console.Write(character);
                    }
                    else
                    {
                        Console.Write(' '); // Leerzeichen für leere Bereiche
                    }
                }
                Console.WriteLine(); // Neue Zeile
            }
        }
    }
}

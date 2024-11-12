using System;

namespace AlessioGaudio.Week02
{
    class Summe 
    {
        public static void Start()
        
        {
            Console.WriteLine("Variante 1: For-Schleife");
            for (double i = 0; i <= 100; i += 0.1)
            {
                Console.WriteLine(i.ToString("F1"));
            }
        }
    }
}




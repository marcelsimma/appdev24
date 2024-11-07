using System;

namespace AlessioGaudio.Week02
{
    class Schleifenn
    {
       public static void Start()
        {
            for (int x = 0; x <= 20; x++)
            {
                // Ganzzahldivision (Division durch 5)
                int intResult = x / 5;
                
                // Fließkommadivision (Division durch 5.0)
                double doubleResult = x / 5.0;

                // Ausgabe
                Console.WriteLine($"{x} / 5 = {intResult}");
                Console.WriteLine($"{x} / 5.0 = {doubleResult}");
                Console.WriteLine();
            }
        }
    }
}

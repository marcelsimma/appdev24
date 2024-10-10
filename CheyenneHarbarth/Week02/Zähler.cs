using System;

namespace CheyenneHarbarth.Week02
{

    class Zähler
    {

        public static void CountTo100()
        {
            for (double i = 0; i <= 100; i += 0.1)
            {
                Console.WriteLine($"{i:F1}");
            }
        }
    }
}
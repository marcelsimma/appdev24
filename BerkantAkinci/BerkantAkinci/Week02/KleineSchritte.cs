using System;

namespace BerkantAkinci.Week02
{

    class KleineSchritte
    {

        public static void PrintKleineSchritte(double a, double b)
        {
            for (double i = a; i <= b; i += 0.1)
            {
                Console.WriteLine($"{i:F1}"); // Das "F1" gibt an wie viel Nachkommastellen kommen sollen --> in dem Fall "1"
            }
        }
    }
}
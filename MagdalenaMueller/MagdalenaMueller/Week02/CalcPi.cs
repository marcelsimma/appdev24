using System;

namespace MagdalenaMueller.Week02
{
    public class CalcPi
    {
        public static void CalcPiProgram()
        {
            double result = 0;
            for (int i = 0; i < 100000; i++)
            {
                double calc = 4.0 / (2 * i + 1);
                if (i % 2 == 0)
                {
                    result += calc; // Addiere für gerade i
                }
                else
                {
                    result -= calc; // Subtrahiere für ungerade i
                }
            }

            Console.WriteLine($"Pi = {result}");
            
        }
    }
}
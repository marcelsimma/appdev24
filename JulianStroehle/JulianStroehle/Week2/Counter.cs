using System;
namespace JulianStroehle.Week2
{
    public class CounterA
    {
        public static void Counter1()
        {
            float Num = 0;
            while (Num <= 100)
            {
                Console.WriteLine(Math.Round(Num, 2));
                Num += 0.1F;
            }
        }
        public static void Counter2()
        {
            float Num = 0;
            do
            {
                Console.WriteLine(Math.Round(Num, 2));
                Num += 0.1F;
            }
            while (Num <= 100);
        }
    }
}
using System;
namespace JulianStroehle.Week2
{
    public class Factorial
    {
        public static void Start(int Factor)
        {
            long Num = 1;
            Console.WriteLine(0 + "!\t" + Num + "\n");
            for (int i = 0; i < Factor; i++)
            {
                Console.Write(i+1 + "!\t");
                Num *= i+1;
                Console.WriteLine(Num + "\n");
            }
        }
    }
}
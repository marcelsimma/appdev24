using System;

namespace FatmanurKeles.Week02
{
    public class Factorial
    {
        public static void start()
        {
            {
                long factorial = 1;
                for (int i = 1; i <= 20; i++)
                {
                    factorial = factorial * i;
                    // factorial *= i;
                    Console.Write($"{i}!= {factorial}\n");
                }
            }
        }
    }
}

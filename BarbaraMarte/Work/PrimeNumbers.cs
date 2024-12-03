using System;

namespace BarbaraMarte.Work
{
    class PrimeNumber
    {
        public static void Print()
        {
            Count();
        }

        public static string Count()
        {
            int max = 100;
            int count = 2;


            for (int min = 2; min < max; min++)
            {
                if (min > count)
                {
                    if (min % count != 0)
                    {
                        return $"It's a prime number! {min}";
                    }
                    else
                    {
                        return "It's not a prime number!";
                    }
                }
                count++;
            }
            return " da";
        }
    }
}
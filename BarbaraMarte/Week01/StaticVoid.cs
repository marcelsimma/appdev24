using System;

namespace BarbaraMarte.Week01

{
    class StaticVoid
    {
        public static void PrintStaticVoid()
        {
            for (int i = 2; i <= 6; i++)
            {
                Console.WriteLine(i);
            }

            int b = 2;
            while (b < 20)
            {
                Console.WriteLine(b);
                b++;
            }
            int k = 10;
            do
            {
                Console.WriteLine(k);
                k++;
            } while (k < 40);



        }


    }
}

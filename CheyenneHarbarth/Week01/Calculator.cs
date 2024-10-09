using System;

namespace CheyenneHarbarth.Week01
{

    class Calculator
    {
        public static void CalcSum(int a, int e)
        {
            int Zwischensumme = (a - 1);
            for (int i = a; i <= e; i++)
            {
                Zwischensumme = Zwischensumme + i;
                Console.WriteLine(Zwischensumme);
            }

        }
    }
}
using System;

namespace MagdalenaMueller.Week02
{
    public class CalcDividedBy5
    {
        public static void DivideBy5()
        {
            for(int i = 0; i <= 20; i++)
            {
                int Divide1 = i / 5;
                float Divide2 = i / 5.0f;

                Console.WriteLine($"{i}/5 = {Divide1}");
                Console.WriteLine($"{i}/5.0 = {Divide2}");
                Console.WriteLine();
            }
        }
    }
}
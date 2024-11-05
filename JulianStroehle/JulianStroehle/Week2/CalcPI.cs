using System;
namespace JulianStroehle.Week2
{
    public class CalculatePI
    {
        public static void Start()
        {
            char op = '+';
            double Num = 0;
            double i = 1;
            while (i < 500000)
            {
                double z = 4/i;
                if (op == '+')
                {
                    Num += z;
                    op = '-';
                }
                else if (op == '-')
                {
                    Num -= z;
                    op = '+';
                }
                i+=2;
            }
            Console.WriteLine(Math.Round(Num, 9));
        }
    }
}
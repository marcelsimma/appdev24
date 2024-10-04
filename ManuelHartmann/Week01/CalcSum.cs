using System;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text.Json.Serialization;


namespace ManuelHartmann
{

    public class CalcSum
    {
        static void CalcSum(string[] args)
        {
            int sum = 20;
            for (int i = 20; i <= 50; i++)
            {
                Console.Write($"Rechenweg: {sum} + {i} = ");
                sum = Add(sum, i);
                Console.WriteLine(sum);
            }
            Console.WriteLine();
            Console.WriteLine($"Gesamtwert = {sum}");
        }
        public static int Add(int x, int y)
        {
            int result = x + y;
            return result;
        }
    }
}





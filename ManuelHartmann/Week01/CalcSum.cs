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
            Console.WriteLine("Sum of 20 to 50 added together");
            Console.WriteLine(new string('-', 25));
            for (int i = 21; i <= 50; i++)
            {
                Console.Write($"Calculation path: {sum} + {i} = ");
                sum = Add(sum, i);
                Console.WriteLine(sum);
            }
            Console.WriteLine(new string('-', 25));
            Console.WriteLine($"Total value = {sum}");
        }
        public static int Add(int x, int y)
        {
            int result = x + y;
            return result;
        }
    }
}





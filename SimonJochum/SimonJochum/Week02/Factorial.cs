using System;

namespace SimonJochum.Week02
{
    public class Factorial
    {

        public static void CalcFactorial()
        {
            //Berechne die Fakultät von 20
            long sum = 1;

            for (int i = 1; i <= 20; i++)
            {
                Console.Write($"Fakultät {i}!\t=\t ");
                sum *= i;
                Console.WriteLine(sum);
            }

        }
    }
}

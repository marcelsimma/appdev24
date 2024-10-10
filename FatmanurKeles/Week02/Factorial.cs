using System;


namespace FatmanurKeles.Week02
{
    public class Factorial
    {
        public static void MainFactorial(string[] args)
        {
            {
            int factorial = 1;
            for (int i = 1; i <= 20; i++)
            {
                factorial = factorial * i;
            }
            Console.Write($"Factorial of 20  is: {factorial}");
            }
        }
    }
}


              /*  for (long i = 0; i <= 20; i++)
                {
                    i = 20!;
                }
                Console.WriteLine();
                */
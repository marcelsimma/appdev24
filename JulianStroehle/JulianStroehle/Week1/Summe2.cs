using System;
namespace JulianStroehle.Week1
{
    public class Summe2{
        public static void Start(int n1, int n2){
            int result = 0;
            for (int i = n1 + 1; i <= n2; i++)
            {
                
                if (i == n1+1){
                result = n1 + i;
                Console.WriteLine($"Rechenweg: {n1} + {i} = {result}");
                }
                else{
                    Console.Write($"Rechenweg: {result} + {i} = ");
                    result += i;
                    Console.WriteLine(result);
                }
            }
        }
    }
}
using System;
namespace JulianStroehle.Week1{
    public class Summe
    {
        public static void Start(int n1, int n2){
            for (int count = n1; count <= n2; count++)
            {
                for (int count2 = count; count2 <= n2; count2++)
                {
                    Console.WriteLine(count+count2);
                }
            }
        }
    }
}
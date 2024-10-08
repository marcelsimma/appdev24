using System;

namespace MagdalenaMueller.Week01
{
    public class CalcSum
    {
        

        public static int CalcSumof20(int from, int to)
        {   
            int zahl1 = from;
            int zahl2 = from+1;
            int ergebniss = zahl1 + zahl2;

            Console.WriteLine("Summe von 20 bis 50 addiert");
            Console.WriteLine("-------------------------");
            for(int i = from; i < to; i++)
            {
            Console.WriteLine($"rechenweg {zahl1}+{zahl2} = {ergebniss}");
            zahl2 ++;
            zahl1 = ergebniss;
            ergebniss = zahl1 + zahl2;
            }
            
            return from + to;

        }
    }
}
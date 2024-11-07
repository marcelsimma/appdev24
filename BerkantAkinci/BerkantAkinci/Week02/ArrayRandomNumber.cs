using System;
using System.Globalization;

namespace BerkantAkinci.Week02
{

    class ArrayRandomNumber
    {

        public static void PrintRandomArray()
        {
            Random random = new Random();

            int[] Number = new int [100];

            for( int i = 0; i < Number.Length; i++) {
            Number[i] = random.Next(-50, 50);
            System.Console.WriteLine(Number[i]);
            }
            System.Console.WriteLine("Die höchste Zahl ist: " + Number.Max());
            System.Console.WriteLine("Die niedrigste Zahl ist : " + Number.Min());
            System.Console.WriteLine("Der Durchschnittswert ist: " + Math.Round(Number.Average(),1)); //Math.Round =Kaufmännisch Runden
        }
    }
}
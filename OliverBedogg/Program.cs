using System;
using OliverBedogg.Week01;
using OliverBedogg.Week02;

namespace OliverBedogg
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Escapesequenz \n für Zeilenwechsel
            Console.WriteLine("\n");
            // weitere: https://learn.microsoft.com/de-de/cpp/c-language/escape-sequences

            // Woche 1 ------------------
            // PrintSquare.Print('+', 6);
            // ChristmasTree.Print(11);
            // FunctionWithReturn.Start();
            // CalcSum.Start(20, 50);
            // CalcSum.PrintSummeNico();

            // Woche 2 ------------------
            // PrimitiveDatatypes.Start();
            // Operatoren.Start();
            // Factorial.Start();
            Pi.Start();

            Console.WriteLine("\n");
        }
    }
}

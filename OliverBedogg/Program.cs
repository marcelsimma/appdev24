﻿using System;
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
            // Pi.Start();
            // Generation.Start();
            // StringMethoden.Start();
            // StringMethoden.Exercise();

            // Woche 3 ------------------
            // StringsVergleich.Start();
            // Abwesenheiten.Start();
            // StringsHesse.Start();
            StringMethoden2.Start();

            Console.WriteLine("\n");
        }
    }
}

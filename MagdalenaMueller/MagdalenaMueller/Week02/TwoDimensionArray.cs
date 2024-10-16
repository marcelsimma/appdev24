using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata.Ecma335;

namespace MagdalenaMueller.Week02
{
    public class TwoDimensionArray
    {
        public static void TwoDimensionArrayProgram()
        {
            // Größe fragen
            Console.WriteLine("Breite: ");
            int x = Math.Max(1, Convert.ToInt32(Console.ReadLine())); // Mindestens 1
            Console.WriteLine("Höhe: ");
            int y = Math.Max(1, Convert.ToInt32(Console.ReadLine())); // Mindestens 1

            // Array ausgeben
            for (int i = 0; i < y; i++) // Zeilen
            {
                for (int j = 0; j < x; j++) // Spalten
                {
                    
                    if (j == i || j == (x - 1 - i)) // Diagonalen
                    {
                        Console.Write("X ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine(); // Neue Zeile nach jeder Reihe
            }
        }
    }
}
using System;
using System.Diagnostics.Metrics;
using System.Globalization;
namespace FlorianBaier.Week01
{
    public class Christmastree
    {

        public static void PrintChristmastree(int size)
        {
            double sizeRounded = size / 3 * 2; // für Berechnung des Stamms erforderlich, Stamm ist 1/3 der Breite
            int rounded = Convert.ToInt32(Math.Round(sizeRounded));//Kommastellen runden => Ausgabe von Ganzzahl
            // Schleife für den gesamten Christbaum
            for (int i = 0; i <= size; i++)
            {
                //Leerzeichen printen
                for (int j = 0; j <= size - i - 1; j++) //Leerzeichen werden in jeder Zeile -1 auf der linken und rechten Seite
                {
                    Console.Write(' ');
                }
                //Sterne printen
                for (int j = 0; j < (2 * i + 1); j++) //Sterne werden 2 mehr pro Zeile
                {
                    Console.Write('*');
                }
                Console.WriteLine();
                

                // Nullen anschreiben
                if (i == size)
                {
                    ChristmastreeKugeln(size);
                    /*for (int k = 0; k <= size; k++)
                    {
                        Console.Write(zero + " "); // Printet char und Leerzeichen
                    }
                    Console.Write(new string(' ', size)); // Printet oberen Code auf size
                    Console.WriteLine();*/
                    
                    ChristmastreeStamm(size);
                    // Stamm berechnen in Relation zum Oberen Teil
                    /*while (j < size / 4)
                    {
                        Console.Write(new string(' ', rounded + 1) + new string(plus, (size + 1) / 2) + new string(' ', rounded + 2));
                        Console.WriteLine();
                        j++;*/
                    }

                }

            }
        

        public static void ChristmastreeKugeln(int size)
        {
            char zero = '0';
            for (int k = 0; k <= size; k++)
                    {
                        Console.Write(zero + " "); // Printet char und Leerzeichen
                    }
                    Console.Write(new string(' ', size)); // Printet oberen Code auf size
                    Console.WriteLine();
                    

        }
        public static void ChristmastreeStamm(int size)
        {
            double sizeRounded = size / 3 * 2; // für Berechnung des Stamms erforderlich, Stamm ist 1/3 der Breite
            int rounded = Convert.ToInt32(Math.Round(sizeRounded));//Kommastellen runden => Ausgabe von Ganzzahl
            char plus = '+';
            
              for (int j = 0 ;j < size; j++ )
                    {
                        Console.Write(new string(' ', rounded + 1) + new string(plus, (size + 1) / 2) + new string(' ', rounded + 2));
                        Console.WriteLine();
                        j++;
                    }

        }
    }
}


using System;

namespace FatmanurKeles.Week02
{
    public class Generationen
    {
        public static void GenerationenAusgabe()
        {
            Console.WriteLine("Bitte geben Sie Ihr Jahrgang ein: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year >= 1928 && year <= 1945)
            {
                Console.WriteLine("Generation Silent");
            }

            else if (year >= 1946 && year <= 1964)
            {
                Console.WriteLine("Generation Boomer");
            }

            else if (year >= 1965 && year <= 1980)
            {
                Console.WriteLine("Generation X");
            }

            else if (year >= 1981 && year <= 1996)
            {
                Console.WriteLine("Generation Y");
            }

            else if (year >= 1997 && year <= 2010)
            {
                Console.WriteLine("Generation Z");
            }

            else if (year >= 2011 && year <= 2025)
            {
                Console.WriteLine("Generation Alpha");
            }

            else 
            {
                Console.WriteLine("Dieser Jahrgang hat keinen Namen :( ");
            }
        }
    }
}

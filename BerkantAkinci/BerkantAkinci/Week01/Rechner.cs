using System;
using System.ComponentModel;

namespace BerkantAkinci.Week01
{

    class Rechner
    {

        public static void PrintRechner(int Start, int Ende)
        {
            int Zwischensumme = 0;
            int Summe = Start;

            System.Console.WriteLine($"Summe von {Start} bis {Ende} addiert \n-------------------------------");

            for (int i = Start + 1; i <= Ende; i++)
            {
                Zwischensumme = add(Summe, i);

                System.Console.WriteLine($"rechenweg {Summe} + {i} = {Zwischensumme}");

                Summe = Zwischensumme;
            }
        }

        public static int add(int nr1, int nr2)
        {
            int ergebnis = nr1 + nr2;
            return ergebnis;
        }
    }
}

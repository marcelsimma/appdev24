using System;

namespace BerkantAkinci.Week01
{

    class RechnerProbe
    {

        public static void PrintRechnerProbe(int Start, int Ende)
        {
            System.Console.WriteLine($"Summe von {Start} bis {Ende} addiert \n--------------------------");

            for (int i = Start + 1; i <= Ende; i++)
            {
                int Summe = Addieren(Start, i);

                System.Console.WriteLine($"Rechenweg {Start} + {i} = {Summe}");

                Start = Summe;
            }
        }

        public static int Addieren(int nr1, int nr2)
        {
            int ergebnis = nr1 + nr2;

            return ergebnis;
        }
    }
}




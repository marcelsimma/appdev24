using System;

namespace StefanMarinovic.Week01
{
    class Loops
    {
        static void PrintLoops()
        {
            //for-Schleife PRÜFT ZUERST ob die Bedingung true ist und FÜHRT DANN aus
            for (int i = 0; i < 0; i++)
            {
                Console.WriteLine(i);
            }

            //while-Schleife GENAU GLEICH wie for-Schleife
            int j = 0;
            while (j < 0)
            {
                Console.WriteLine(j);
                j++;
            }

            //do-Schleife FÜHRT ZUERST AUS und ÜBERPRÜFT DANACH ob die Bedingung true ist
            int k = 0;
            do
            {
                Console.WriteLine(k);
                k++;
            } while (k < 0);
        }
    }
}




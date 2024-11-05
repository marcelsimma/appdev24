using System;

namespace JonasWehinger.Week01
{

    public class PrintDeltoid
    {

        public static void Print(char c, int size)
        {

            int tmp = 7/2;
            Console.WriteLine(tmp);

            for (int i = 0; i < size; i++)
            {

                // Erste Zeile
                if (i == 0)
                {
                    // (size-1)/2 = size/2, da Int die Kommastelle nicht speichert
                    Console.Write(new string('.', (size-1)/2) + c + new string('.', (size)/2));
                    
                }

                // Linie von 9 zu 12 Uhr
                if (i > 0 && i < (size-1)/2) {
                    //Console.Write("..*.*..");

                    Console.Write(new string('.', (size-1)/2-i) + c);
                }


                // mittlere Zeile
                if (i == (size-1)/2) {
                    // -2 da zwei * in dieser Zeile
                    Console.Write(c + new string('.', size-2) + c);
                }

                // letzte Zeile
                else if (i == size-1)
                {

                    Console.Write(new string('.', (size)/2) + c + new string('.', (size)/2));
                    
                }

                Console.WriteLine();

            }

        }

        public static void PrintLine(char c, int length)
        {
            /*
            for (int j = 0; j < length; j++)
            {
                Console.Write(c);
            }
            */
            Console.Write(new string(c, length));
        }
    }
}
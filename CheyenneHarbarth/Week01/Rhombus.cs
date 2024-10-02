using System;

namespace CheyenneHarbarth.Week01
{

    public class Rhombus
    {
        public static void PrintEmptyRhombus(char c, int size)
        {
            for (int i = 0; i < size; i++)
            {
                int half = (size - 1) / 2;
                //Erste Zeile
                if (i == 0)
                {
                    Console.Write(new string(' ', half) + c + new string(' ', half));
                }
                //Zeilen zwischen Anfang und Mitte
                else if (i > 0 && i < half)
                {
                    int kmp = half - i;
                    Console.Write(new string(' ', kmp) + c + new string(' ', size - (kmp * 2) - 2) + c + new string(' ', kmp));  //warum i? eine Rechnung: size=7, also (7-1)/2 = 3 - i, i liegt zwischen 0 und der Mitte, also wenn i = 1 ist, dann rechnen wir 3-1, also wird die j-Koordinate 2
                }
                //mittlere Zeile
                else if (i == half)
                {
                    Console.Write(c + new string(' ', size - 2) + c);
                }
                //Zeilen zwischen Mitte und Ende
                else if (i > half && i < size - 1)
                {
                    int tmp = i - half;
                    Console.Write(new string(' ', tmp) + c + new string(' ', size - (tmp) * 2 - 2) + c + new string(' ', tmp));
                }
                //letzte Zeile
                else if (i == size - 1)
                {
                    Console.Write(new string(' ', half) + c + new string(' ', half));
                }
                Console.WriteLine();
            }
        }
        public static void PrintLine(char c, int length)
        {
            Console.WriteLine(new string(c, length));
        }
    }
}
using System;

namespace BerkantAkinci.Week01
{


    class Rhombus
    {


        public static void PrintRhombus(char b, int size)
        {
            for (int i = 0; i < size; i++)
            {

                int half = (size - 1) / 2;


                //Erste Zeile
                if (i == 0)
                {

                    Console.Write(new string(' ', half) + b + new string(' ', half));
                }

                //Obere Hälfte

                if (i > 0 && i < half)
                {

                    Console.Write(new string(' ', half - i) + b + new string(' ', size - 2 - (half - i) * 2) + b + new string(' ', half - i));
                }
                //Mittlere Zeile
                if (i == half)
                {
                    Console.Write(b + new string(' ', size - 2) + b);

                }

                //Untere Hälfte
                /* mit (i - half) macht man zuerst den ersten Leerzeichen, danach kommt mit "b" ein Sternechen
                der nächste String ist dann mit "size - 2" die 2 Sternchen die dann wegfallen, das "i - half" ist das eine Leerzeichen das
                wegfällt und da auf der anderen Seite auch eins ist wird "*2" gemacht
                */

                if (i > half && i < size - 1)
                {
                    Console.Write(new string(' ', i - half) + b + new string(' ', size - 2 - (i - half) * 2) + b + new string(' ', i - half));
                }


                //Letzte Zeile
                else if (i == size - 1)
                {
                    Console.Write(new string(' ', half) + b + new string(' ', half));
                }

                Console.WriteLine();

            }
        }
    }
}








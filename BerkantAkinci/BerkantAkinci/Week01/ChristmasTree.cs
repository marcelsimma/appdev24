using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace BerkantAkinci.Week01
{
    class ChristmasTree
    {
        /*public static void Print(int height)
       {
           int width = height / 2;
           char c = '*';
           int trunkHeight = 2;
           int globesHeight = 1;

           // Körper PrintBody(...)
           int bodyHeight = height - globesHeight - trunkHeight;

           for (int i = 0; i < bodyHeight; i++)
           {
               Console.WriteLine(c);
           }

           // Kugeln PrintGlobes(...)
           PrintGlobes(width);

           // Stamm PrintTrunk(...)
           int trunkWidth = 2;
           int trunkSpace = (width - trunkWidth) / 2;
           Console.WriteLine(
               new string(' ', trunkSpace) + new string('|', trunkWidth));

       }

       public static void PrintGlobes(int width)
       {
           PrintTimes("0 ", width);
           Console.WriteLine();
       }

       public static void PrintTimes(string text, int times)
       {
           for (int i = 0; i < times; i++)
           {
               Console.Write(text);
           }
       }
   }
}
*/

        // Die obere Methode ist die Lösung, die unter ist selber gemacht.
        //Die obere Mehtode ist mit mehr Verknüpfungen, dass nicht immer das gleiche geschrieben wird und verschiedenste Verknüpfungen mehrmals eingesetzt werden können
        //Die untere Methode klappt es sehr gut außer die Christbaumkugeln, da habe ich den Abstand nicht herbekommen.



        public static void PrintChristmasTree(char c, int size)
        {
            for (int i = 0; i < size; i++)
            {
                int half = (size - 1) / 2;


                //erste Zeile mit einem Stern
                if (i == 0)
                {
                    Console.Write(new string(' ', size) + c + new string(' ', size));
                }



                // restliche Zeilen mit den jeweiligen Sternchen
                else if (i > 0 && i <= half + 1)
                {
                    Console.Write(new string(' ', size - i) + new string(c, size - (half - i) * 2) + new string(' ', size - i));
                }


                //Christbaumkugeln, mit jeweils einem Abstand dazwischen
                else if (i == half + 2)
                {
                    Console.Write(new string(' ', half));

                    for (int j = 0; j <= size + 2; j++)
                    {
                        if (j % 2 == 0)
                        {

                            Console.Write('0');
                        }

                        else
                        {
                            Console.Write(' ');

                        }
                    }
                }


                //Baumstamm
                else if (i > half + 2 && i < size)
                {

                    Console.Write(new string(' ', size - 1) + new string('+', size - (half - 1) * 2) + new string(' ', size - 1));
                }

                Console.WriteLine();
            }
        }
    }
}




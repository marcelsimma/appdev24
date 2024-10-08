using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace FatmanurKeles.Week01
{
    public class PrintRhombus
    {

        public static void PrintRhombus1(char c, int size)
        {

            for (int i = 0; i < size; i++)
            {
                //erste Zeile
                if (i == 0)
                {
                    Console.WriteLine(new string('.', (size - 1) / 2) + c + new string('.', (size - 1) / 2));
                }

                //linie von 0 bis 3 Uhr
                if (i > 0 && i < (size - 1) / 2)
                {
                    Console.WriteLine(new string('.', (size - 1) / 2 - i) + c + new string('.', i * 2 - 1) + c + new string('.', (size - 1) / 2 - i));
                }


                //mittlere Zeile
                else if (i == (size - 1) / 2)
                {
                    Console.WriteLine(c + new string('.', size - 2) + c);
                }

                //linie von 6 bis 9 Uhr
                if (i > (size - 1) / 2 && i < size - 1)
                {
                    Console.WriteLine(new string('.', i - (size - 1) / 2) + c + new string('.', size * 2 - 3 - i * 2) + c + new string('.', i - (size - 1) / 2));
                }

                //letzte Zeile
                else if (i == size - 1)
                {
                    Console.WriteLine(new string('.', (size - 1) / 2) + c + new string('.', (size - 1) / 2));
                }


            }
        }
    }
}

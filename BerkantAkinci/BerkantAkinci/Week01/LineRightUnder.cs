using System;

namespace BerkantAkinci.Week01
{

    class LineRightUnder
    {

        public static void PrintLineRightUnder(char c, int size)
        {
            for (int i = 0; i < (size / 2) + 1; i++)
            {
                Console.WriteLine(new string('.', (size / 2) - i) + c + new string('.', (size / 2) + i));
            }
        }
    }
}
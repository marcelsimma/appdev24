using System;

namespace BerkantAkinci.Week01
{

    class LineRight
    {

        public static void PrintLineRight(char c, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(new string('.', size - i - 1 ) + c + new string('.', i));
            }
        }
    }
}
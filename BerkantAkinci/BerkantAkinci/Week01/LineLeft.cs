using System;

namespace BerkantAkinci.Week01
{

    class LineLeft
    {

        public static void PrintLineLef(char c, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(new string('.', i) + c + new string('.', size - i - 1));
            }
        }
    }
}

using System;

namespace SimonJochum.Week01
{
    class Rewind
    {
        static void RewindPrint()
        {
        for (int i = -10; i <= 10; i++)
            {
            if (i % 2 == 0)
                {
                Console.WriteLine(i);
                }
            }
        }
    }
}

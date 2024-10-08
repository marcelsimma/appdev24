using System;
namespace JulianStroehle.Week1
{
    public class PrintDeltoidA
    {
        public static void PrintDeltoid(int l, char c)
        {
            int a = 1;
            for (int i = 0; i < l; i++)
            {
                if (i == 0 || i == l-1)
                {
                    Console.Write(new string(' ', l-(a/2)+1) + c + new string(' ', l-(a/2)+1));
                }
                if (i > 0 && i < (l-1)/2)
                {
                    Console.Write(new string(' ', l-(a/2)) + c + new string(' ', a) + c + new string(' ', l-(a/2)));
                }
                if (i == l/2)
                {
                    Console.Write(new string(' ', l-(a/2)) + c + new string(' ', l-2) + c + new string(' ', l-(a/2)));
                }
                if (i > (l-1)/2 && i < l-1)
                {
                    Console.Write(new string(' ', l-(a/2)) + c + new string(' ', a) + c + new string(' ', l-(a/2)));
                }
                if (i != 0)
                {
                    if (i < l/2)
                    {
                        a++ ;
                        a++ ;
                    }
                    else if (a != 1)
                    {
                        a--;
                        a--;
                    }
                    else 
                    {
                        a--;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

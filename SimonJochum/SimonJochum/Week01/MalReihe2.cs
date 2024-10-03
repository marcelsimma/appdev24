using System;

namespace SimonJochum.Week01
{
    class MalReihe2
    {
        static void Malreihe()
        {
            for (int i = 0; i <= 10; i++)
            {
            int result = i * 2;
            Console.WriteLine($"{i} * 2 = {result}");
            }
        }
    }
}
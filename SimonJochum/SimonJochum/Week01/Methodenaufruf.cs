// See https://aka.ms/new-console-template for more information
using System;

namespace SimonJochum.Week01
{
    class Methodenaufruf
    {
        static void Methodenaufrufversuch()
        {

            for (int i = 0; i <= 10; i++)
            {
            int result = i * 2;
            DoSmth(result);
            }

        }
        public static void DoSmth(int value)
        {
            Console.WriteLine(value);
        }
    }
}

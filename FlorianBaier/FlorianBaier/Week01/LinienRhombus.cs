using System;

namespace FlorianBaier.Week01
{

    public class LinienRhombus
    {

        public static void PrintLinienRhombus1(char c, int size)
        {
            for (int i = 0; i < size; i++)
            {

                Console.WriteLine(new string('.', i) + c + new string('.', size - 1 - i));
            }

        }
        public static void PrintLinienRhombus2(char c, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(new string('.', size - 1 - i) + c + new string('.', i));
            }
        }
        public static void PrintLinienRhombus3(char c, int size)
        {
            for (int i = 0; i < size; i++)
            {

                Console.WriteLine(new string('.', i + size - 1) + c + new string('.', size - 1 - i));
            }

        }

        public static void PrintLinienRhombus4(char c, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(new string('.', size - i - 1 + size - 1) + c + new string('.', i));
            }
        }
    }
}
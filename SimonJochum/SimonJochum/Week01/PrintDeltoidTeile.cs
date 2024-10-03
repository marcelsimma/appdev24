using System;

namespace SimonJochum.Week01
{

    public class PrintDeltoidTeile
    {

        public static void EmptyDeltoidTeile(char c, int size)
        {
            for (int i = 0; i < size; i++) //Methode 1
            {
                Console.WriteLine(new string('.', i) + c + new string('.', size - i - 1));
            }
            Console.WriteLine();

            for (int i = 0; i < size; i++) //Methode 2
            {
                Console.WriteLine(new string('.', size - i - 1) + c + new string('.', i));
            }
            Console.WriteLine();

            for (int i = 0; i < size; i++) //Methode 3
            {
                Console.WriteLine(new string('.', i + size - 1) + c + new string('.', size - i - 1));
            }
            Console.WriteLine();

            for (int i = 0; i < size; i++) //Methode 4
            {
                Console.WriteLine(new string('.', size - i - 1 + size - 1) + c + new string('.', i));
            }
            
        }
    }
}
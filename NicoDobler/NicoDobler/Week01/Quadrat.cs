using System;
 
namespace NicoDobler.Week01
{
    class Quadrat
    {
        public static void Start()
        {
            PrintEmptySquare('x', 10);
        }
 
        public static void PrintEmptySquare(char character, int size)
        {
           
            for (int i = 0; i < size; i++)
            {
                Console.Write(character);
            }
            Console.WriteLine();
 
           
            for (int i = 0; i < size - 2; i++)
            {
                Console.Write(character);
                for (int j = 0; j < size - 2; j++)
                {
                    Console.Write(' ');
                }
                Console.Write(character);
                Console.WriteLine();
            }
 
       
            if (size > 1)
            {
                for (int i = 0; i < size; i++)
                {
                    Console.Write(character);
                }
                Console.WriteLine();
            }
        }
    }
}
 
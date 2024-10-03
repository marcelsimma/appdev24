using System;
 
 namespace SimonJochum.Week01
 {
class SelfSquare
{
    public static void EmptySquare()
    {
   
          PrintEmptySquare1('x', 10);
        }
 
        public static void PrintEmptySquare1(char character, int size)
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
             for (int i = 0; i < size; i++)
            {
                Console.Write(character);
            }
            Console.WriteLine();
         }
     }  
 }
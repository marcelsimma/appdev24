using System;


namespace StefanMarinovic.Week01
{

    class Multiplication 
    {

        static void PrintMultiplication()
        {
            Console.WriteLine("Multiplication by 1:");
            Console.WriteLine();
            //Every single for-loop works the same here. Each loop goes through the numbers 0 to 10.
            for (int i = 0; i <= 10; i++)
            {               
                //Here we want the console to print every number from the loop (0-10) and multiply it by the wanted number.  
                Console.WriteLine($"{i} * 1 = {i * 1}");
            }
            Console.WriteLine("\n \n \n");
            Console.WriteLine("Multiplication by 2:");
            Console.WriteLine();
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{i} * 2 = {i * 2}");
            }
            Console.WriteLine("\n \n \n");
            Console.WriteLine("Multiplication by 3:");
            Console.WriteLine();
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{i} * 3 = {i * 3}");
            }
        }
    }
}
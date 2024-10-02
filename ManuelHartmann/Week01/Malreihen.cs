using System;


namespace ManuelHartmann
{

    class Malreihen 
    {

        static void Malreihen(string[] args)
        {
            Console.WriteLine("We use the multiplicator: 1");
            for (int i = 0; i <= 10; i++) 
            {
                Console.WriteLine($"{i} * 1 = {i * 1}");
            }
            System.Console.WriteLine("\n \n");
            Console.WriteLine("We use the multiplicator: 2");
            for (int i = 0; i <= 10; i++) 
            {
                Console.WriteLine($"{i} * 1 = {i * 2}");
            }
            System.Console.WriteLine("\n \n");
            Console.WriteLine("We use the multiplicator: 3");
            for (int i = 0; i <= 10; i++) 
            {
                Console.WriteLine($"{i} * 1 = {i * 3}");
            }
        }
    }
}





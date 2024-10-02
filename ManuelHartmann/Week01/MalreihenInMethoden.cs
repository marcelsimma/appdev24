using System;
using System.Text.Json.Serialization;


namespace ManuelHartmann
{

    class MalreihenInMethoden 
    {
        static void MalreihenInMethoden(string[] args)
        {
            for (int i = 1; i <= 3; i++) 
            {
                Console.WriteLine($"We use the multiplicator: {i}");
                Multiplicator(i);
                System.Console.WriteLine("\n");
            }
        }

        public static void Multiplicator(int value) 
        {
            for (int ii = 0; ii <= 10; ii++) 
            {
                Console.WriteLine($"{ii} * {value} = {ii * value}");
            }
        }
    }
}





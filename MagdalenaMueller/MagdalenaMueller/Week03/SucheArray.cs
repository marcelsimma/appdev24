using System;
using System.Runtime.CompilerServices;

namespace MagdalenaMueller.Week03
{
    public class SucheArray
    {
        public static void SucheArrayProgramm()
        {
            string[] value = new string[10];
            int counter = 0;

            for(int i = 0; i<= value.Length-1; i++)
            {
                Console.WriteLine("Gib eine Wort ein: ");
                string word = Console.ReadLine();
                value[i] = word;
            }
            Console.WriteLine("\nGib das gesuchte word ein: ");
            string searchword = Console.ReadLine();

            for(int i = 0; i<= value.Length-1; i++)
            {
                if(value[i]== searchword)
                {
                    Console.WriteLine($"Wort wurde an der stelle {i} gefunden");
                    counter++;
                }     
            }
            if(counter <= 0)
            {
                Console.WriteLine("Wort nicht gefunden");
            }      
        }
    }
}
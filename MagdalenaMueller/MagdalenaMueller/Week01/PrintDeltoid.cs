using System;
using System.Net;


namespace MagdalenaMueller.Week01
{

    public class PrintDeltiod
    {
        public static void PrintEmthyDeltoid(char symbol, int length)
        {
            int value = length /2 +1;
            
            // Oberer Teil
            for (int i = 0; i < value; i++)
            {
                //Linke Seite
                Console.Write(new string(' ', value - i - 1)); 
                Console.Write(symbol); 

                // Rechte Seite
                if (i > 0)
                {
                    Console.Write(new string(' ', 2 * i - 1)); 
                    Console.Write(symbol); 
                }
                Console.WriteLine();
            }

            // Unterer Teil
            for (int i = value - 2; i >= 0; i--)
            {
                //Linke Seite
                Console.Write(new string(' ', value - i - 1)); 
                Console.Write(symbol); 

                //Rechte Seite
                if (i > 0)
                {
                    Console.Write(new string(' ', 2 * i - 1)); 
                    Console.Write(symbol); 
                }
                Console.WriteLine();
            }
            
        }
    }

}
    

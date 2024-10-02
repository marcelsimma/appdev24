using System;

namespace MagdalenaMueller.Week01 {


    public class PrintSqure {
        public static void PrintEmthySquare(char symbol, int lenght)
        {
            int spaces = lenght-2;
            
            for(int i=0; i<lenght-2;i++)
            {
                Console.Write(symbol);
                for(int j= 0; j< spaces;j++)
                {
                    Console.Write(" ");
                }
                Console.Write(symbol);
                Console.WriteLine();
            }
        }
        public static void FirstAndLastRow(char symbol, int lenght)
        {
            for(int i=0; i<lenght; i++)
            {
                Console.Write(symbol);  
                Console.WriteLine();
            }
        }
    }
}
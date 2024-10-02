using System;

namespace MagdalenaMueller.Week01
{
    public class Weihnachtsbaum
    {
        public static void DrawTree(char symbol, int size)
        {
            for (int i = 0; i< size;i++)
            {
                int spaces = size /2 -3;
                for(int j = 0; j<size / 2;j++)
                {
                    Console.Write(new string('0',1));
                    Console.Write(new string(' ',1));
                }
                for (int k = 0; k <2; k++)
                {
                    Console.Write(new string(' ', spaces));
                    Console.Write("++");
                    Console.WriteLine(); 
                }
            }
        }
    }
}
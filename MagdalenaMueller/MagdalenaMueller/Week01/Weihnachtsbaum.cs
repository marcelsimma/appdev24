using System;
using System.Net;
using System.Xml;
using System.Xml.Serialization;

namespace MagdalenaMueller.Week01
{
    public class Weihnachtsbaum
    {
        public static void DrawTreeNeedels(int size)
        {
            int spaces = size -2;
            int s = 1;
            Random r = new Random();
            // Nadeln
            if (spaces >= 0)
        {
            for (int i = 0; i < size - 1; i++)
            {
                if (spaces != -1 || spaces != 0)
                {
                    Console.Write(new string(' ', spaces));
                }

                // Zufällig entscheiden, ob "0" oder "*" ausgegeben wird
                char symbol = r.Next(2) == 0 ? '0' : '*';
                
                Console.Write(new string(symbol, s)); 
                Console.WriteLine();

                if (spaces > 0)
                {
                    spaces--;
                }
                s += 2;
                }
            }
            
        } 
        
        public static void DrawTreeDecoration(int size)
        {

            // Unterste Reihe 
            for(int j = 0; j<= size - 2;j++)
            {
                Console.Write(new string('0',1));
                Console.Write(new string(' ',1));
            }
            
        }

        public static void DrawTreeStamp(int size)
        {
            // Stamm
            for (int k = 0; k < 2; k++)
            {
                int spaces = size -2;
                Console.WriteLine();
                Console.Write(new string(' ', spaces - 1));
                Console.Write("+++");
            }
        }
        
    }
}
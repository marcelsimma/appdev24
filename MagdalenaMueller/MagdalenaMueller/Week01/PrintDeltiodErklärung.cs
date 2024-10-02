using System;
using System.Reflection.Metadata;

namespace MagdalenaMueller.Week01
{

    public class PrintDeltiodErklärung
    {
        
        public static void Methode1(char symbol, int hight)
        {
            for (int i = hight - 2; i >= 0; i--)
            {
                Console.Write(new string('.', hight - i - 1)); 
                Console.Write(symbol); 
                Console.WriteLine();
            } 
                
        }
        public static void Methode2(char symbol, int hight)
        {
            for (int i= 0; i < hight;i++)
            {
                Console.Write(new string('.', hight - i - 1)); 
                Console.Write(symbol);  
                
                
                Console.WriteLine();
            }
            
        }
        public static void Methode3(char symbol, int hight)
        {
            for (int i = hight - 2; i >= 0; i--)
            {
                Console.Write(new string('.', hight - i - 1)); 
                Console.Write(symbol); 
                Console.WriteLine();
            }
        }
        public static void Methode4(char symbol, int hight)
        {
            for (int i= 0; i < hight;i++)
            {
                Console.Write(new string('.', hight - i - 1)); 
                Console.Write(symbol);  
                
                
                Console.WriteLine();
            }
            
        }
    
    }
}

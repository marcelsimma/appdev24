using System;
using System.Data.SqlTypes;
using System.Drawing;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks.Dataflow;

namespace BarbaraMarte.Week01
{
    // Funktioniert nicht!
    public class LeeresQuadrat
    {
        public static void PrintLeeresQuadrat(char c, int size)
        {
        for (int i = 0; i < size; i++)
        {   // Erste Zeile
            if (i == 0)
            {                 
            Console.WriteLine(new string(' ',(size-1)/2) + c + new string(' ',(size-1)/2));           
            }  
            // Zweite Zeile, Linie von 9 bis 12 Uhr
            if (i > 0 && i < (size-1)/2)
            {
                Console.Write(new string(' ', (size-1)/2-i) + c);
            }
               // Mitlere Zeile
            if (i == (size-1)/2)
            {   //-2 da zwei * in dieser Zeile
                Console.Write(c + new string('.',size-2) + c);
            }       
            // Letzte Zeile
            if (i == size -1)
            {                 
            Console.WriteLine(new string(' ',(size-1)/2) + c + new string(' ',(size-1)/2));
           
            }
           
        }
        }
        
        public static void PrintLine(char c, int length){
            Console.Write(new string(c, length));
}
        }
    } 
    
   




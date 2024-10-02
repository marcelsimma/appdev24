using System;
using System.Runtime.ExceptionServices;
namespace JulianStroehle.Week1{
    public class TannenbaumA{
        public static void Tannenbaum()
        {
            Console.WriteLine("Größe: ");
            int l = Convert.ToInt32(Console.ReadLine());
            char c = '*';
            char d = '0';
            char e = '+';
            for (int i = 0; i <= l; i++)
            {
                if (i == 0)
                {
                    Console.Write(new string(' ', l*2) + c + new string(' ', l*2));
                }
                if (i < l && i > 0)
                {
                    Console.Write(new string(' ', l*2-i) + new string(c, i*2+1) + new string(' ', l*2-i));
                }
                if (i == l)
                {
                    Console.Write(new string(' ', l+1));
                    for (int k = 0; k < l; k++)
                    {
                        Console.Write(d + " ");
                    }
                    Console.Write(new string(' ', l));
                    Console.WriteLine();
                    int j = 0;
                    while (j < l/4){
                        Console.Write(new string(' ', (l*2-i)+l/3*2+1) + new string(e, (l+1)/2) + new string(' ', (l*2-i)+l/3*2+1));
                        Console.WriteLine();
                        j++;
                    }
                   
                }
                Console.WriteLine();
            }
        }
    }
}
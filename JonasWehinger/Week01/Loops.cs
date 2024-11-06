using System;
using System.Security.Cryptography.X509Certificates;

namespace JonasWehinger.Week01
{
    public class Loops
    {
        public static void Start()
        {
          
            for (int i = 0; i < 0; i++)
            {
                Console.WriteLine(i);
            }

            int j = 0;
            while (j < 0)
            {
                Console.WriteLine(j);
                j++;
            }

            int k = 0;
            do
            {
                Console.WriteLine(k);
                k++;
            } while (k < 0);
        

        }

    
    }
}

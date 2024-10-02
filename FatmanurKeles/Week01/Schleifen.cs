using System;

namespace FatmanurKeles.Week01
{
    class WhileForDoWhile
    {
        static void MainWhile (string[] args)
        {

           int j = -10; 
            while (j % 2 == 0)
            {
               Console.WriteLine(j);
               j++;
            }

            for (int i = -10; i <= 10; i++) 
            {
                if (i % 2 == 0) 
                {
                Console.WriteLine(i);
                }
            
            }

            int k = -10;
    	        do
            {
                Console.WriteLine(k);
            }
                while (k % 2 == 0);
        }
    }
}

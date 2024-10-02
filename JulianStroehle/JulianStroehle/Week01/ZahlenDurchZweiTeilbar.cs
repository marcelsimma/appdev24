using System;

namespace JulianStroehle.Week1
{
    public class DurchZweiB
    {
        public static void DurchZwei()
        {
            for (int i=-10;i<11; i++)
            {
                if (i%2==0)
                {
                    Console.WriteLine(i);
                }
            }
            int j = -10;
            while (j<11){
                if (j%2==0){
                    Console.WriteLine(j);
                }
                j++;
            }
            int k = -10;
            do
            {
                if (k%2==0){
                    Console.WriteLine(k);
                }
                k++;
            }while (k<11);
            
        }
    }
}
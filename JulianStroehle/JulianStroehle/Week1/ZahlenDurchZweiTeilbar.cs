using System;

namespace JulianStroehle.Week1
{
    public class DurchZwei
    {
        public static void Start()
        {
            Console.WriteLine("Zahl 1: ");
            int  n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zahl 2: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            for (int i=n1;i<n2; i++)
            {
                if (i%2==0)
                {
                    Console.WriteLine(i);
                }
            }
            int j = n1;
            while (j<n2){
                if (j%2==0){
                    Console.WriteLine(j);
                }
                j++;
            }
            int k = n1;
            do
            {
                if (k%2==0){
                    Console.WriteLine(k);
                }
                k++;
            }while (k<n2);
            
        }
    }
}
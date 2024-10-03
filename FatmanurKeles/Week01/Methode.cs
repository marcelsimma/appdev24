using System;

namespace FatmanurKeles
{
    class MethodeMalreihe
    {
        static void MainMethode (string[] args)
        {
        
        for ( int i = 0; i < 5; i++)
        {
            DoSmth();
        }

        }

        public void DoSmth(int value)
        {
            Console.WriteLine(value);
        }


         public static void DoSmth()
        {
             for (int i = 0; i  < 11; i++)
        {
        Console.WriteLine(i*2);;
        }
        }
    }

}

using System;

namespace AlessioGaudio.Week01
{
    class Schleifen
    {
        static void Start()
        {

            for (int i = -10; i < 11; i++)
            {

                Console.WriteLine(i);
                
            }

            int j = 0;
            while (j < 10)
            {
            
            Console.WriteLine(j);
            j++;

            }

            int k = 12;
            do
            {
                Console.WriteLine(k);
                k++;


            } while (k < 30);

        }

        public static void DoSmth(int j)
        {
            Console.WriteLine(j);
        }

    }

}
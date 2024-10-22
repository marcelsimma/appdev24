using System;

namespace LucasSchiemann.Week01
{
    public class Malreihe
    {
        public static void PrintMahlreihe(string[] args)
        {

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            int j = 0;
            while (j < 5)
            {
                Console.WriteLine(j);
                j++;
            }

            int k = 0;
            do
            {
                Console.WriteLine(k);
                k++;
            } while (k < 5);


        }
    }
}

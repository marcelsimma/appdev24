using System;

namespace BerkantAkinci.Week02
{

    class Teilen
    {

        public static void PrintTeilen()
        {
            for(int i = 0; i <= 20; i++)
            {
                Console.WriteLine($"{i} / 5 = {i / 5} ");           //die Stelle nach dem Komma wird abgeschnitten
                Console.WriteLine($"{i} / 5.0 = {i / 5.0} \n");     //die Stelle nach dem Komma bleibt erhalten
            }
        }
    }
}
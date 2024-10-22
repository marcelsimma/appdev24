using System;

namespace SimonJochum.Week02
{
    public class Divide
    {
        public static void DivideDifference()
        {
            for(int i = 0; i <= 20; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine($"{i} / 5 = {i / 5} ");           //die Stelle nach dem Komma wird abgeschnitten
                Console.WriteLine($"{i} / 5.0 = {i / 5.0} \n");     //die Stelle nach dem Komma bleibt erhalten
            }
        }
    }
}
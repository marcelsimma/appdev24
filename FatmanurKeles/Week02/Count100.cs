using System;

namespace FatmanurKeles.Week02
{    public class Count100
    {
        static void MainCount(string[] args)
        {
            {
                double counter = 0.0;
                for (double i = 0; i < 100; i++)
                {
                    counter += 0.10;
                    Console.WriteLine("sum: " + counter);
                }
            }
        }
    }
}
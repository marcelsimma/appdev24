using System;


namespace StefanMarinovic.Week01
{

    class Deltoid 
    {

        static void Deltoid(string[] args)
        {
            string response = Console.ReadLine();
            if (int.TryParse(response, out int height))

            for (int i = 0; i < height; i++)
            {
                if (i == 0 || i == height - 1)
                {
                    Console.WriteLine(new string(' ', height / 2) + "X");
                }
                else if (i == height / 2)
                {
                    Console.WriteLine("X" + new string(' ', height - 2) + "X");
                }
                else if (i > 0 && i < height / 2)
                {
                    Console.WriteLine(new string(' ', height / 2 - i) + "X" + new string(' ', i * 2 - 1) + "X");
                }
                else
                {
                    Console.WriteLine(new string(' ', i - height / 2) + "X" + new string(' ', 2 * height - 2 * i - 3) + "X");
                }
            }
        }
    }
}
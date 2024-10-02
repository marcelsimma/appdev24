using System;


namespace StefanMarinovic.Week01
{

    class EvenNumbers 
    {

        public static void EvenNumberGenerator()
        {
            Console.WriteLine("Hello little fella");
            Console.WriteLine("Where do you want to start?");
            string response1 = Console.ReadLine();
            if (int.TryParse(response1, out int start))

            Console.WriteLine("And where do you want to end?");
            string response2 = Console.ReadLine();
            if (int.TryParse(response2, out int end))

            for (int i = start;i <= end; i++ )
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
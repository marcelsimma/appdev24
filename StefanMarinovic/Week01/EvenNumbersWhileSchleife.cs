using System;


namespace StefanMarinovic.Week01
{

    class EvenNumbersWhileSchleife 
    {

        static void WhileSchleife()
        {
            Console.WriteLine("Hello little fella");
            Console.WriteLine("Where do you want to start?");
            string response1 = Console.ReadLine();
            if (int.TryParse(response1, out int start))

            Console.WriteLine("And where do you want to end?");
            string response2 = Console.ReadLine();
            if (int.TryParse(response2, out int end))

            while(start <= end)
            {
                if (start % 2 == 0)
                {
                    Console.WriteLine(start + " is dividable by 2");
                    start++;
                }
                else
                {
                    Console.WriteLine(start);
                    start++;
                }
            }
        }
    }
}
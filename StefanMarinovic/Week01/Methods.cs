using System;


namespace StefanMarinovic.Week01
{

    class Methods 
    {

        static void MethodMain()
        {
            Console.WriteLine("Do you want to multiply?");
            Console.WriteLine("1. yes");
            Console.WriteLine("2. no");
            string response = Console.ReadLine();
            switch (response)
            {
                case "1":
                    DoSmth();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Well then piss off!");
                    break;
                default:
                    Console.WriteLine("Please enter a valid answer");
                    break;
            }
        }
        public static void DoSmth()
        {
            Console.WriteLine("With which number do you want to multiply?");
            string response = Console.ReadLine();
            if (int.TryParse(response, out int userNumber))
            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i} * {userNumber} = {i * userNumber}");
                // DoSmth();
            }
            
        }
        // public static void DoSmth()
        // {
        //     Console.WriteLine("Hello");
        // }
    }
}
namespace BarbaraMarte.Week02;

class Generation
{

    public static void PrintGeneration()
    {
        for (int i = 0; i <= 4; i++)
        {

            Console.WriteLine($"Enter your Name");
            string yourName = Console.ReadLine();

            Console.WriteLine($"Enter your age");
            int yourAge = Convert.ToInt32(Console.ReadLine());
            int howOldAreYou = 2024 - yourAge;



            if (howOldAreYou >= 2011 && howOldAreYou <= 2025)
            {
                Console.WriteLine($"You {yourName}, are in the Generation Alpha");
            }

            else if (howOldAreYou >= 1997 && howOldAreYou <= 2010)
            {
                Console.WriteLine($"You {yourName}, are in the Generation Z");
            }
            else if (howOldAreYou >= 1981 && howOldAreYou <= 1996)
            {
                Console.WriteLine($"You {yourName}, are in the Generation Y/ Millenialas");
            }
            else if (howOldAreYou >= 1965 && howOldAreYou <= 1980)
            {
                Console.WriteLine($"You {yourName}, are in the Generation X");
            }
            else if (howOldAreYou >= 1946 && howOldAreYou <= 1964)
            {
                Console.WriteLine($"You {yourName}, are in the Generation Boomer");
            }
            else
            {
                Console.WriteLine($"You {yourName}, are in the Generation Silent");
            }

        }

    }

}
using System;
namespace BarbaraMarte.Hausaufgabe
{
    class Monate
    {
        public static void PrintMonate()
        {
            Console.WriteLine("Write in a month in numbers");

            int input = Convert.ToInt32(Console.ReadLine());

            // input >= 3 && input <= 5 
            if (input >= 3 && input <= 5)
            {
                Console.WriteLine("Spring");
            }

            // die "Striche / oder" || braucht es um mehrere inputs in einer aufschreiben zu können
            else if (input == 6 || input == 7 || input == 8)
            {
                Console.WriteLine("Summer");
            }

            else if (input == 9 || input == 10 || input == 11)
            {
                Console.WriteLine("Automn");
            }

            else
            {
                Console.WriteLine("Winter");
            }





            switch (input)
            {
                case 4:
                case 5:
                case 6:
                    Console.ReadLine();
                    break;
            }
        }


    }
}


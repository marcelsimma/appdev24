using System;

namespace SimonJochum.Week02
{
    public class Generations()
    {

        public static void CheckGenerations()
        {
            int age;
            
            Console.WriteLine("Hallo zum Generationenchecker. \nBitte gib dein Alter ein: ");
            age = Convert.ToInt32(Console.ReadLine());
            if (age <= 13)
            {
                Console.WriteLine("Du gehörst zur Generation Alpha");
            }
            else if (age <= 27)
            {
                Console.WriteLine("Du gehörst zu Generation Z");
            }
            else if (age <= 43)
            {
                Console.WriteLine("Du gehörst zu Generation Y");
            }
            else if (age <= 59)
            {
                Console.WriteLine("Du gehörst zu Generation X");
            }
            else if (age <= 78)
            {
                Console.WriteLine("Du gehörst zu Generation Boomer");
            }
            else
            {
                Console.WriteLine("Du gehörst zur Generation Silent");
            }
        }
    }
}
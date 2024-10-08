using System;
namespace JulianStroehle.Week2
{
    public class Generations
    {
        public static void Start()
        {
            do
            {
            Console.WriteLine("Name?");
            string? n = Console.ReadLine();
            Console.WriteLine("Age?");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("again? (y/n)");
            GetGenerationsByAge(n, a);
            }
            while (Console.ReadLine() == "y");
        }
        static void GetGenerationsByAge(string Name, int age)
        {
            int year = 2024-age;
            if (year >= 1928 && year <= 1945)
            {
                Console.WriteLine(Name + " " + age + ": Generation Silent");
            }
            else if (year >= 1946 && year <= 1964)
            {
                Console.WriteLine(Name + " " + age + ": Generation Boomer");
            }
            else if (year >= 1965 && year <= 1980)
            {
                Console.WriteLine(Name + " " + age + ": Generation X");
            }
            else if (year >= 1981 && year <= 1996)
            {
                Console.WriteLine(Name + " " + age + ": Generation Y");
            }
            else if(year >= 1997 && year <= 2010)
            {
                Console.WriteLine(Name + " " + age + ": Generation Z");
            }
            else if (year >= 2011)
            {
                Console.WriteLine(Name + " " + age + ": Generation Alpha");
            }
            else
            {
                Console.WriteLine(Name + " " + age + ": Generation too old");
            }
        }
    }
}
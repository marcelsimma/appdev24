using System;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text.Json.Serialization;


namespace ManuelHartmann
{

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey mate, what's your name?");
            string responseName = Console.ReadLine();
            Console.WriteLine(responseName + ", may you tell me your age?");
            string responseAge = Console.ReadLine();
            if(int.TryParse(responseAge, out int age) && age > 0)
            {
                getGenerationByAge(age, responseName, responseAge);
            }
            else
            {
                Console.WriteLine("That's not a number!");
            }
        }
        // Die Namensdeklarierungen in der Methode muessten nicht Ident den bereits bestehenden sein. (Haben nichts miteindander zu tun)
        public static void getGenerationByAge (int checkAge, string getName)
        {
            checkAge = 2024 - checkAge;

            if (checkAge >= 2011 && checkAge <= 2025)
            {
                Console.WriteLine($"{getName} {checkAge}: Alpha");
            }
            else if (checkAge >= 1997 && checkAge <= 2010)
            {
                Console.WriteLine($"{getName} {checkAge}: Gen Z");
            }
            else if (checkAge >= 1981 && checkAge <= 1996)
            {
                Console.WriteLine($"{getName} {checkAge}: Gen Y");
            }
            else if (checkAge >= 1965 && checkAge <= 1980)
            {
                Console.WriteLine($"{getName} {checkAge}: Gen X");
            }
            else if (checkAge >= 1946 && checkAge <= 1964)
            {
                Console.WriteLine($"{getName} {checkAge}: Boomer");
            }
            else if (checkAge >= 1928 && checkAge <= 1945)
            {
                Console.WriteLine($"{getName} {checkAge}: Gen Silent");
            }
            else
            {
                Console.WriteLine($"{getName} {checkAge}: You're kidding! You're never that old and able to use that program!");
            }
        }
    }
}





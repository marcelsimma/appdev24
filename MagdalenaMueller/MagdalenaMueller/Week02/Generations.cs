using System;
using System.Data.Common;
using System.Diagnostics;
using System.Security.Cryptography;

namespace MagdalenaMueller.Week02
{
    public class Generations
    {
        public static void CalcGenerations()
        {
            bool playagain = true;

            while (playagain == true)
            {
                //Abfregen Name und Alter
                Console.WriteLine("Gib dein Name ein:");
                string name = Console.ReadLine(); 
                Console.WriteLine("Gib dein Alter ein: ");
                int age = Convert.ToInt32(Console.ReadLine());

                //Schreiben von Name Alter und Generation
                Console.WriteLine($"{name} {age}");
                if((2025 - age) >= 2011)
                {
                    Console.WriteLine($"Generation: Alpha");
                }
                else if ((2025-age) < 2011 && (2025-age) >= 1997)
                {
                    Console.WriteLine($"Generation: Z");
                }
                else if ((2025-age) < 1997 && (2025-age) >=1981)
                {
                    Console.WriteLine($"Generation: Millennials");
                }
                else if ((2025-age) < 1981 && (2025-age) >= 1965)
                {
                    Console.WriteLine($"Generation: X");
                }
                else if((2025-age) < 1965 && (2025-age) >= 1946)
                {
                    Console.WriteLine($"Generation: Boomer");
                }
                else 
                {
                    Console.WriteLine($"Generation: Silent");
                }

                //Abfrage ob man weiter machen möchte
                Console.WriteLine("Möchtest du weiter machen?");
                string again = Console.ReadLine().ToUpper();

                if (again == "NEIN")
                {
                    playagain = false;
                }
            }
        }
    }
}
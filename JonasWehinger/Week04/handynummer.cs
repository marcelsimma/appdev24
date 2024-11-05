using System;
using System.Text.RegularExpressions;
namespace JonasWehinger.Week04{

    public class Nummer{

        public static void Handynummer(){

            Console.WriteLine("Gib deine gwünschte Handynummer ein:");

            string? input = Console.ReadLine();

            string pattern = @"^\+43\d{10,15}$";

            if (Regex.IsMatch(input, pattern))
            {
                Console.WriteLine("Die Handynummer ist korrekt formatiert.");
            }
            else
            {
                Console.WriteLine("Die Handynummer ist nicht korrekt formatiert.");
            }
        }
    }
}

            

  
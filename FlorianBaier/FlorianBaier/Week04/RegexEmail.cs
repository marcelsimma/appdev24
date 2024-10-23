using System;
using System.Text.RegularExpressions;

namespace FlorianBaier.Week04
{

    public class RegexEmail
    {

        public static void EmailStart()
        {
             Console.WriteLine("Bitte geben Sie eine E-Mail-Adresse ein:");
        string? email = Console.ReadLine();

        if (IsValidEmail(email))
        {
            Console.WriteLine("Die E-Mail-Adresse ist gültig.");
        }
        else
        {
            Console.WriteLine("Die E-Mail-Adresse ist ungültig.");
        }
    }

    public static bool IsValidEmail(string email)
    {

        string pattern = @"^(?!.*\.\.)([a-z0-9._]{1,64})@([a-z0-9.-]{1,255})\.([a-z]{2,6})$";
        
        return Regex.IsMatch(email, pattern);
        }
    }
}
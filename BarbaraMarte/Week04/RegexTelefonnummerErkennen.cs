using System;
using System.Text.RegularExpressions;
using BarbaraMarte.Week02;

namespace BarbaraMarte.Week04;

class RegexTelefonnummer
{
    public static void NewTry()
    {
        Console.WriteLine("Please enter your Phonenumber:");
        string? phonenumberInput = Console.ReadLine();

        // Fragezeichen im Text machen die Eingabe für den Computer Lesbar auch wenn man KEIN Lehrzeichen in der Eingabe angegeben hat.
        // Wenn man das Fragezeichen nicht drinnen hat MUSS man die Lehrzeichen setzen ansonsten erkennt der Compurer nicht als richtig!
        string mobilePattern = @"^(\+43|06|05) ?\d{2,3} ?\d{7,8}$";
        //string pattern = @"^\+\d{2,3} \d{3} \d{7,8}";

        bool isValid = Regex.IsMatch(phonenumberInput, mobilePattern);

        if (isValid)
        {
            Console.WriteLine($"{phonenumberInput}: is a valid Austrian number.");

        }
        else
        {
            Console.WriteLine($"{phonenumberInput}: is not an Austrian number.");
        }
    }
    public static void Print()
    {
        Console.WriteLine("Please enter your phone number and please enter it in the correct formation: (+43(x) 660 12345678)");
        string? phonenumberInput = Console.ReadLine();
        string pattern = @"^\+\d{2,3} ?\d{3} ?\d{7,8}"; // the @ tells the PC that the programm should read the code as it stands.

        /* You don't need this code if you put a questionmark after the string name.
        if (phonenumberInput == null)
         {
             Console.WriteLine("No input providet!");
             return;
         }
         */

        if (IsValidPhoneNumber(phonenumberInput))
        {
            Console.WriteLine("It's a valid phone number");
            if (Regex.IsMatch(phonenumberInput, pattern))
            {
                var match = Regex.Match(phonenumberInput, @"^\+(\d{2,3})");
                if (match.Success)
                {
                    string countryCode = match.Groups[1].Value;
                    string country = GetCountryFromCode(countryCode);
                    Console.WriteLine($"This is the country code: {countryCode} from: {country} ");
                }

            }
            else
            {
                Console.WriteLine("Please enter a valid number!");
            }
        }

    }
    public static bool IsValidPhoneNumber(string phonenumberInput)
    {
        string pattern = @"^\+\d{2} ?\d{3} ?\d{7,8}$";
        return Regex.IsMatch(phonenumberInput, pattern);
    }
    public static string GetCountryFromCode(string code)
    {
        var countryCode = new Dictionary<string, string>
        {
            {"43", "Austria"},
            {"49", "Germany"},
            {"41", "Swiss"},
            {"46", "Sweden"},
        };
        return countryCode.ContainsKey(code) ? countryCode[code] : "unknown country";


    }
}
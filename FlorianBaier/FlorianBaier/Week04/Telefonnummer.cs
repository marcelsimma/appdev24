using System;
using System.Text.RegularExpressions;

namespace FlorianBaier.Week04
{

    public class Telefonnummer
    {

        public static void TelefonnummerStart()
        {
            Console.WriteLine("Bitte geben Sie eine Telefonnummer ein und beachte das Format: (+43(X) 699 12345678)");
            string inputMobileNumber = Console.ReadLine();
            string pattern = @"^\+\d{2,3} \d{3} \d{7,8}$";

            if (IsValidPhoneNumber(inputMobileNumber))
            {
                Console.WriteLine("Die Telefonnummer ist gültig.");
                if (Regex.IsMatch(inputMobileNumber, pattern))
                {
                    var match = Regex.Match(inputMobileNumber, @"^\+(\d{2,3})");
                    if (match.Success)
                    {
                        string countryCode = match.Groups[1].Value;
                        string country = GetCountryFromCode(countryCode);
                        Console.WriteLine($"+{countryCode} ist die Vorwahl von {country}.");
                    }
                }
                else
                {
                    Console.WriteLine("Die Telefonnummer ist ungültig.");
                }

            }
        }

        public static bool IsValidPhoneNumber(string inputMobileNumber)
        {
            string pattern = @"^\+\d{2,3} \d{3} \d{7,8}$";
            return Regex.IsMatch(inputMobileNumber, pattern);
        }
        static string GetCountryFromCode(string code)
        {
            var countryCodes = new Dictionary<string, string>
        {
            { "43", "Österreich" },
            { "49", "Deutschland" },
            { "41", "Schweiz" },
            { "34", "Spanien"},
            { "33", "Frankreich"},
        };
            return countryCodes.ContainsKey(code) ? countryCodes[code] : "Unbekanntes Land";
        }
    }
}
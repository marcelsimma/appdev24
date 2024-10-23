using System;
using System.Text.RegularExpressions;

namespace MarcelSimma.Week01
{
    public class PhoneNumbers
    {

        public static void Start()
        {
            string input = "Telefon: +43 553 56453321";
            Regex regex = new Regex(@"\+?\d{1,3}\s?\d{3,}\s?[0-9]+$");
            bool result = regex.IsMatch(input);

            if (result)
            {
                Console.WriteLine("Gültige Telefonnummer");
            }
            else
            {
                Console.WriteLine("Ungültige Telefonnummer");
            }

        }
    }
}
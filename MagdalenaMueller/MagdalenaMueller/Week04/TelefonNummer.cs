using System;
using System.Text.RegularExpressions;

namespace MagdalenaMueller.Week04
{
    public class TelefonNummer
    {
        public static void TelefonNummerPrgramm()
        {
           bool again = true;

            string pattern = @"^\+(\d{2}|\d{3}) (\d{3}|\d{4}) (\d{5}|\d{6})$";
            Regex regexNumber = new Regex(pattern);

            while (again)
            {
                Console.WriteLine("Telefonnummer überprüfen(1)\nBeenden(2)");
                string? task = Console.ReadLine();
                
                switch (task)
                {
                    case "1":
                        Console.WriteLine("Telefonnummer: ");
                        string? phoneNumber = Console.ReadLine();

                        if (regexNumber.IsMatch(phoneNumber))
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("Gültige Telefonnummer\n");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Telefonnummer nicht gültig\n");
                            Console.ResetColor();
                        }
                        break;
                    case "2":
                        again = false;
                        break;

                    default:
                        break;
                }
            }
             
        }
    }
}
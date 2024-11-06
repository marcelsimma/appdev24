using System;
using System.Text.RegularExpressions;
namespace JulianStroehle.Week4
{
    public class TelefonnummerErkennen
    {
        public static void Start()
        {
            string[] mobileNumbers = ["+43 676 59253671", "0664 1378769", "06607183662", "0170 1234567", "+491475707710", "05573 85062", "030 12345678", "0711 12345678", "+423 2345678", "0043 676 59253671"];
            // string pattern = @"^(\+43|05|06|0043 ?\d{2,3})( ?\d{0,4}){1,4}$";
            string pattern = @"^(\+43|05|06|0043)( ?\d{1,3})( ?\d{4,8})";
            Regex rg = new(pattern);
            foreach (string number in mobileNumbers)
            {
                bool match = rg.IsMatch(number);
                if (match == true)
                {
                    Console.WriteLine(string.Format("{0,20}", number) + "\tist eine Österreichische Nummer");
                }
                else
                {
                    Console.WriteLine(string.Format("{0,20}", number) + "\tist keine Österreichische Nummer");
                }
            }
        }
    }
}
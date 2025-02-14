using System;
using System.Text.RegularExpressions;

namespace SimonJochum.Week04
{
    public class RecognizePhoneNumber
    {
        public static void Start()
        {
            // PhoneNumbers();
            PhoneNumbersTryToShorten();
        }

        public static void PhoneNumbers()
        {
            string[] mobileNumbers = ["+43 676 59253671", "0664 1378769", "06607183662", "0170 1234567", "+491475707710", "05573 85062", "030 12345678", "0711 12345678", "+423 2345678", "00436641378769", "+43 5512 12345", "0043 660 1378769"];
            string[] landlineNumbers = ["05573 85062", "030 12345678", "0711 12345678"];
            // string mobilePattern = @"^(\+43|0 ?\d{0,3})( ?\d{3,4}){1,4}$"; //nur für Handynummern aus Österreich, erster Versuch
            string mobilePattern = @"^(\+43|06|05|00 ?\d{2,3})( ?\d{0,4}){1,4}$"; //für Handy und Festnetznummern in Österreich
            //@"^(\+43|06|05|00 ?\d{2,3})( ?\d{0,4}){1,4}$" Erklärung
            // '@' damit C# die '\' nicht als Escapezeichen wertet, ohne @ müssten die '\' doppelt geschrieben werden
            // '^' beginnt den Ausruck, der Anfang muss übereinstimmen
            // '()' fassen einen Teil des Ausdrucks zusammen
            // '\+43|06|..' '\+' damit das '+' nur als solches verstanden wird, '|' ist ein oder um verschiedene Vorwahlen gültig zu machen
            // ' ?' ein '?' hinter dem Leerzeichen, um das Leerzeichen optional zu machen
            // '\d{2,3}' \d damit die Zahlen von 0-9 erlaubt sind, '{2,3}' damit 2-3 Stellen erlaubt sind
            string landlinePattern = @"\d{5}( \d{0,5})$"; //nur Festnetznummern in Österreich

            foreach (string number in mobileNumbers)
            {
                bool isValid = Regex.IsMatch(number, mobilePattern);

                if (isValid == true)
                {
                    Console.WriteLine($"{number}: ist eine gültige österreichische Telefonnummer +");
                }
                else
                {
                    Console.WriteLine($"{number}: Diese Nummer ist keine österreichische Telefonnummer -");

                }
            }
            Console.WriteLine("---------------------------------------------");

            foreach (string number in landlineNumbers)
            {
                bool isValid = Regex.IsMatch(number, landlinePattern);

                if (isValid == true)
                {
                    Console.WriteLine($"{number}: ist eine gültige österreichische Telefonnummer +");
                }
                else
                {
                    Console.WriteLine($"{number}: Diese Nummer ist keine österreichische Telefonnummer -");
                }
            }
        }

        public static void PhoneNumbersTryToShorten() //Regex Ausdruck zur besseren Lesbarkeit verfeinert
        {
            string[] mobileNumbers = ["+43 676 59253671", "0664 1378769", "06607183662", "0170 1234567", "+491475707710", "05573 85062", "030 12345678", "0711 12345678", "+423 2345678", "00436641378769", "+43 5512 12345", "0043 660 137 8769"];
            string pattern = @"^(\+43|06|05|0043)( ?\d{1,3})( ?\d{3,8})( ?\d{3,8})";

            foreach (string number in mobileNumbers)
            {
                bool isValid = Regex.IsMatch(number, pattern);

                if (isValid == true)
                {
                    Console.WriteLine($"{number}: ist eine gültige österreichische Telefonnummer +");
                }
                else
                {
                    Console.WriteLine($"{number}: Diese Nummer ist keine österreichische Telefonnummer -");

                }
            }
        }
    }
}
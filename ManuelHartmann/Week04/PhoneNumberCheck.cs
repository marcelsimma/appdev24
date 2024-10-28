
using System.Text.RegularExpressions;

namespace ManuelHartmann.Week04
{
        // Erklaerung Zeichenbedeutung.

    /*   ^\+: Der String muss mit einem Pluszeichen beginnen.
         \d{1,3}: Erwartet 1 bis 3 Ziffern für die Ländervorwahl (z. B. 43 für Österreich).
         \s: Ein Leerzeichen zwischen den Teilen der Nummer.
         \d{1,4}: 1 bis 4 Ziffern für den Netzbetreiber (z. B. 676).
         \d{6,12}: 6 bis 12 Ziffern für die Telefonnummer.
         $: Der String muss mit einer Zahl enden und darf keine zusätzlichen Zeichen enthalten.     */


    public class PhoneNumberCheck
    {
        public static void Start()
        {
            string phoneNumber = "+43 676 55653643";

            bool isValid = IsPhoneNumberValid(phoneNumber);

            if (isValid)
            {
                Console.WriteLine("The inserted phone number is valid!");
            }
            else
            {
                Console.WriteLine("The inserted phone number is NOT valid!");
            }
        }
        //  Ueberprueft, ob es sich beim 'string phoneNumber', um eine valide Nummber handelt.
        static bool IsPhoneNumberValid(string phoneNumber)
        {
            // Regex für das Telefonnummernformat: +43 676 55653643
            string pattern = @"^\+\d{1,3}\s\d{1,4}\s\d{6,12}$"; //  Aufbau der formatsueberpruefung.
            Regex regex = new Regex(pattern);   // new Regex mit dem Pattern.

            //  regex.IsMatch -> Wenn die Nummer, dem definiertem Pattern entspricht wird 'true' zurueckgegeben.
            return regex.IsMatch(phoneNumber);  
        }
    }
}




namespace ManuelHartmann.Week04
{
    public class ReplaceAll
    {
        public static void Start()
        {
            string userText = "Heute wird ein guter Tag! Heute wird ein noch guterer Tag! Heute wird ein spitzen guter Tag!";
            string userNumbers = "749813247132984712039487123049871204398712039487";

            ReplaceWird(userText);
            ConvertUserText(userText);
            ConverUserNumbers(userNumbers);
            DeleteNumberBetweenOneAndNine(userNumbers);
            DeleteNumberBetweenTwoAndFour(userNumbers);
            DeleteNumberOneToThreeAndSixToNine(userNumbers);
        }
        static void ReplaceWird(string userText)
        {
            Console.WriteLine("Replace all 'wird' with 'war und ist'.");
            Console.WriteLine(userText.Replace("wird", "war und ist"));   //  Ersetzt alle 'wird' mit 'war und ist'.
        }
        static void ConvertUserText(string userText)
        {
            string result = new string(userText.Where(c => !char.IsLower(c)).ToArray());    // Alle Grossbuchstaben werden etfernt.
            Console.WriteLine(result);  //  'string' ohne Grossbuchstaben.
            result = new string(userText.Where(c => !char.IsUpper(c)).ToArray());   // Alle Kleinbuchstaben werden etfernt.
            Console.WriteLine(result);  //  'string' ohne Kleinbuchstaben.
            Console.WriteLine(userText.Replace(" ", ""));   //  Alle Leerzeichen werden entfernt.
            Console.WriteLine(userText.Replace("!", ""));   //  Alle '!' werden entfernt.
        }

        /*  Fuegt alle einzelnen Zahlen zum 'char[]' hinzu und ueberpruft (ASCII), ob die Zahl zwischen 0-9 ist.
         *  Wenn zwischen 0-9, dann loesche die Zahl. */
        static void ConverUserNumbers(string userNumbers)
        {
            char[] chars = userNumbers.ToCharArray();

            /* Zur ueberpruefung koennte der 'char' Inhalt zu 'int' convertiert werden. 
            Dann wuerde der ASCII-Wert ausgegeben werden.-> int temp = Convert.ToInt32(chars[i]);        */
            Console.WriteLine("Numbers between 0-9: ");
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] >= 48 && chars[i] <= 57)   //  Ueberpruft (ASCII), ob die Zahl zwischen 0-9 ist.
                {
                    Console.Write(chars[i] - 48);   //  [i] - 48, gibt die Zahl 0-9 an.
                    chars[i] = ' ';
                }
            }
            foreach (char c in chars)
            {
                Console.Write(c);   //  Gibt den ueberarbeiteten 'string', ohne Zahlen von 0-9 zurueck.
            }
        }
        static void DeleteNumberBetweenOneAndNine(string userNumbers)
        {
            char[] chars = userNumbers.ToCharArray();

            Console.WriteLine("\nNumbers between 1-9: ");
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] >= 49 && chars[i] <= 57)   //  Ueberpruft (ASCII), ob die Zahl zwischen 0-9 ist.
                {
                    Console.Write(chars[i] - 48);   //  [i] - 48, gibt die Zahl 0-9 an.
                    chars[i] = ' ';
                }
            }
            Console.WriteLine();
            foreach (char c in chars)
            {
                Console.Write(c);   //  Gibt den ueberarbeiteten 'string', ohne Zahlen von 1-9 zurueck.
            }
        }
        static void DeleteNumberBetweenTwoAndFour(string userNumbers)
        {
            char[] chars = userNumbers.ToCharArray();

            Console.WriteLine("\nNumbers between 2-4: ");
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] >= 50 && chars[i] <= 52)   //  Ueberpruft (ASCII), ob die Zahl zwischen 0-9 ist.
                {
                    Console.Write(chars[i] - 48);   //  [i] - 48, gibt die Zahl 0-9 an.
                    chars[i] = ' ';
                }
            }
            Console.WriteLine();
            foreach (char c in chars)
            {
                Console.Write(c);   //  Gibt den ueberarbeiteten 'string', ohne Zahlen von 2-4 zurueck.
            }
        }
        static void DeleteNumberOneToThreeAndSixToNine(string userNumbers)
        {
            char[] chars = userNumbers.ToCharArray();

            Console.WriteLine("\nNumbers between 1 - 3 || 6 - 9: ");
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] >= 49 && chars[i] <= 51 || chars[i] >= 54 && chars[i] <= 57)   //  Ueberpruft (ASCII), ob die Zahl zwischen 0-9 ist.
                {
                    Console.Write(chars[i] - 48);   //  [i] - 48, gibt die Zahl 0-9 an.
                    chars[i] = ' ';
                }
            }
            Console.WriteLine();
            foreach (char c in chars)
            {
                Console.Write(c);   //  Gibt den ueberarbeiteten 'string', ohne Zahlen von 1-3 && 6-9 zurueck.
            }
        }
    }
}


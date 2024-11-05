
namespace ManuelHartmann.Week03
{
    public class UppercaseWords

    {   //  Test Text: 'Hesse' ist im string 5 mal enthalten.
        static string txt = "Hallo Hesse, wie geht es Hesse heute? Ich hoffe Hesse ist heute gut gelaunt. Hesse kommt anscheinend auch aus hesse.";
        static string userInput = "";   // Wort welches in Uppercase gestellt werden soll.
        public static void Start()
        {
            UserRespond();
            UpperWords(userInput);
        }
        public static string UserRespond()
        {
            Console.WriteLine("Please insert the word you'd like to 'UPPERCASE' in the sentence.");
            userInput = Console.ReadLine();
            return userInput;
        }
        public static void UpperWords(string userInput)
        {
            txt = txt.Replace(userInput, userInput.ToUpper());  // Stellt das Wort 'Hesse' zu uppercase.
            txt = txt.Replace(userInput.ToLower(), userInput.ToUpper());    // Stellt das Wort 'hesse' zu uppercase.
            Console.WriteLine(txt);
        }
    }
}


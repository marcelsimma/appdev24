
namespace ManuelHartmann.Week04
{
    //  Veranschaulicht den Zugriff auf einzelne Buchstaben in einem 'string'.
    public class LetterCounter
    {
        static string userInput = "";
        public static void Start()
        {
            UserInput();
            CountEachLetter(userInput);
        }
        // Methode gibt die Benutzereingabe zurueck.
        static string UserInput()   
        {
            //Console.WriteLine("Please insert your text!");
            //string userInput = Console.ReadLine();            // Mit diesen zwei Zeilen koennte ein UserInput hinzugefuegt werden.
            userInput = "Denke daran, die Ressources als Reference zu dem Projekt zu geben... Im Zweifelsfall frage Hassan ;-)";
            return userInput;
        }
        // Zahlt wie oft jeder einzelne Buchstabe im Satz vorkommt.
        static void CountEachLetter(string userText)    
        {
            // Ein Array, das genug Platz für alle Unicode-Zeichen bietet
            int[] charCount = new int[char.MaxValue];   // char.MaxValue ist 65535 für Unicode-Zeichen

            foreach (char c in UserInput()) //  Zaehlt wie haeufig jeder Buchstabe vorkommt.
            {
                charCount[c]++; //  Zaehlt wie haeufig jeder Buchstabe vorkommt.
            }

            for (int i = 0; i < charCount.Length; i++)
            {
                if (charCount[i] > 0)
                {
                    //  '(char)i' greift direkt auf den einzelnen Buchstaben an der Stelle 'i' zu und gibt deren Wert aus. (selbe Stelle)
                    Console.WriteLine($"'{(char)i}'  : {(charCount[i])}");  // Zeige den Charakter (mit Unicode-Index) und die Anzahl an
                }
            }
        }
    }
}


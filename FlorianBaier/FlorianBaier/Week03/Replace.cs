using System;

namespace FlorianBaier.Week03
{

    public class Replace
    {

        public static void Start()
        {
            string text = "Hesse war ein berühmter Dichter und Schriftsteller";
            string highlightedText = Highlighter(text, "Hesse");
            Console.WriteLine("Text mit Hesse hervorgehoben:\n" + highlightedText);
            Console.Write("Geben Sie ein Wort ein, um es hervorzuheben: ");
            string userInput = Console.ReadLine();
            string modifiedText = Highlighter(highlightedText, userInput);
            Console.WriteLine("Text mit hervorgehobenem Wort:\n" + modifiedText);
        }
        public static string Highlighter(string text, string word)
        {
            return text.Replace(word, word.ToUpper());
        }
    }
}
using System;

namespace AlessioGaudio.Week04
{
    public class Zahl
    {
        public static void Start()
        {
            string text = "749813247132984712039487123049871204398712039487";
            Console.WriteLine("Originaler String:");
            Console.WriteLine(text);

            // Entfernen aller Zahlen von 0 bis 9
            string alleweg = Remover(text, "0123456789");
            Console.WriteLine("\nString nach Entfernen aller Zahlen von 0 bis 9:");
            Console.WriteLine(alleweg);

            // Entfernen aller Zahlen von 1 bis 9
            string ohne1bis9 = Remover(text, "123456789");
            Console.WriteLine("\nString nach Entfernen aller Zahlen von 1 bis 9:");
            Console.WriteLine(ohne1bis9);

            // Entfernen aller Zahlen von 2 bis 4
            string ohne2bis4 = Remover(text, "234");
            Console.WriteLine("\nString nach Entfernen aller Zahlen von 2 bis 4:");
            Console.WriteLine(ohne2bis4);

            // Entfernen aller Zahlen von 1 bis 3 und 6 bis 9
            string ohne1bis3und6bis9 = Remover(text, "1236789");
            Console.WriteLine("\nString nach Entfernen aller Zahlen von 1 bis 3 und 6 bis 9:");
            Console.WriteLine(ohne1bis3und6bis9);
        }

        public static string Remover(string input, string numbersToRemove)
        {
            char[] textArray = input.ToCharArray();
            string result = "";

            foreach (char c in textArray)
            {
                if (numbersToRemove.Contains(c)) 
                {
                    result += c;  
                }
            }

            return result;
        }
    }
}

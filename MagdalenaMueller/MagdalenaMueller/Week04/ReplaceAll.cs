using System;

namespace MagdalenaMueller.Week04
{
    public class ReplaceAll
    {
        public static void ReplaceWar()
        {
            string text = Text();
            string[] words = text.Split(new char[] { ' ', ',', '.', ';', ':', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            string getreplaced = "wird";
            string replaced = "war und ist";

            for (int i = 0; i < words.Length; i++)
                    {
                        if (words[i].Equals(getreplaced, StringComparison.OrdinalIgnoreCase))
                        {
                            words[i] = replaced; 
                        }
                    }

            string updatedText = string.Join(" ", words);
            Console.WriteLine(updatedText);
        }
        public static void DeleteLetters()
        {
            char[] abc = new char[30] {'a', 'b' ,'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'ä', 'ö', 'ü', 'ß'};
            string textstring = Text(); 
            char[] text = textstring.ToCharArray();

            //o. Kleinbuchstaben
            for (int i = 0; i < abc.Length; i++) 
            {
                for (int j = 0; j < text.Length; j++) 
                {
                    if (abc[i] == text[j])
                    {
                        text[j] = ' ';
                    }
                }
            }

            Console.WriteLine($"Text ohne Kleinbuchstaben:");
            for(int i = 0; i < text.Length; i++)
            {
                if(text[i] == ' ')
                {

                }
                else
                {
                    Console.Write(text[i]);
                }
            }    
            
            //o. Großbuchstaben
            textstring = Text();
            text = textstring.ToCharArray();

            for (int i = 0; i < abc.Length; i++) 
            {
                for (int j = 0; j < text.Length; j++) 
                {
                    if (char.ToUpper(abc[i]) == text[j])
                    {
                        text[j] = ' ';
                    }
                }
            }
            Console.WriteLine("\n\nText ohne Großbuchstaben: ");
            for(int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i]);                
            }

            //o. Leerzeichen
            textstring = Text();
            text = textstring.ToCharArray();
            
            Console.WriteLine("\n\nText ohne Leerzeichen: ");
            for(int i = 0; i < text.Length; i++)
            {
                if(text[i] == ' ')
                {

                }
                else
                {
                    Console.Write(text[i]);
                }
            }

            //o. !
            textstring = Text();
            text = textstring.ToCharArray();
            
            Console.WriteLine("\n\nText ohne Ausrufezeichen: ");
            for(int i = 0; i < text.Length; i++)
            {
                if(text[i] == '!')
                {

                }
                else
                {
                    Console.Write(text[i]);
                }
            }
            Console.WriteLine();

        }
        public static void DeleteNumbers()
        {
            char[] numbers = Numbers().ToCharArray();
            char[] delete09 = new char[] {'0','1','2','3','4','5','6','7','8','9'};
            char[] delete19 = new char[] {'1','2','3','4','5','6','7','8','9'};
            char[] delete24 = new char[] {'2','3','4'};
            char[] delete1369 = new char[] {'1','2','3','6','7','8','9'};

            //0-9
            Console.WriteLine("Text ohne Zahlen von 0-9");
            for(int i = 0; i < delete09.Length;i++)
            {
                for(int j = 0; j < numbers.Length; j++)
                {
                    if(delete09[i] == numbers[j])
                    {
                        numbers[j] = ' ';
                    }
                    
                }
            }
            for(int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] == ' ')
                {

                }
                else
                {
                    Console.Write(numbers[i]);
                }
            }

            //1-9
            numbers = Numbers().ToCharArray();
            Console.WriteLine("\n\nText ohne Zahlen von 1-9");

            for(int i = 0; i < delete19.Length;i++)
            {
                for(int j = 0; j < numbers.Length; j++)
                {
                    if(delete19[i] == numbers[j])
                    {
                        numbers[j] = ' ';
                    }
                }
            }
            for(int i = 0; i< numbers.Length; i++)
            {
                if(numbers[i] == ' ')
                {

                }
                else
                {
                    Console.Write(numbers[i]);
                }
            }

            //2-4
            numbers = Numbers().ToCharArray();
            Console.WriteLine("\n\nText ohne Zahlen von 2-4");

            for(int i = 0; i < delete24.Length;i++)
            {
                for(int j = 0; j < numbers.Length; j++)
                {
                    if(delete24[i] == numbers[j])
                    {
                        numbers[j] = ' ';
                    }
                }
            }
            for(int i = 0; i< numbers.Length; i++)
            {
                if(numbers[i] == ' ')
                {

                }
                else
                {
                    Console.Write(numbers[i]);
                }
            }
            //1-3 u. 6-9
            numbers = Numbers().ToCharArray();
            Console.WriteLine("\n\nText ohne Zahlen von 1-3 und 6-9");

            for(int i = 0; i < delete1369.Length;i++)
            {
                for(int j = 0; j < numbers.Length; j++)
                {
                    if(delete1369[i] == numbers[j])
                    {
                        numbers[j] = ' ';
                    }
                }
            }
            for(int i = 0; i< numbers.Length; i++)
            {
                if(numbers[i] == ' ')
                {

                }
                else
                {
                    Console.Write(numbers[i]);
                }
            }

        }
        
        public static string Text()
        {
            return "Heute wird ein guter Tag! Heute wird ein noch guterer Tag! Heute wird ein spitzen guter Tag!";
        }
        public static string Numbers()
        {
            return "749813247132984712039487123049871204398712039487";
        }
    }
}
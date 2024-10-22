using System;

namespace FlorianBaier.Week04
{

    public class ReplaceAll
    {

        public static void ReplaceWords()
        {
            string text = "Heute wird ein guter Tag! Heute wird ein noch guterer Tag! Heute wird ein spitzen guter Tag!";
            string replacedText = text.Replace("wird", "war").Replace("wird", "ist");
            Console.WriteLine(replacedText);
        }

        

         public static string GetText()
        {
            return "Hallo, ich bin 26 Jahre alt, lebe in Wolfurt und lerne das Programmieren von C# im Digital Campus.";
        }

        }
    }
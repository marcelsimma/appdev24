using System;
using System.Xml.XPath;

namespace CheyenneHarbarth.Week04
{

    class ReplaceAll
    {

        public static void Start()
        {
            //Replace all
            string Text = "Heute wird ein guter Tag! Heute wird ein noch guterer Tag! Heute wird ein spitzen guter Tag!";

            Console.WriteLine($"Alter Text: {Text}");
            Console.WriteLine($"Überarbeiteter Text: {Text.Replace("wird", "war und ist")}");

            //Replace all 2, Löschen
            Console.WriteLine($"Alter Text: {Text}");
            char[] TextArray = Text.ToCharArray();

            string spaceresult = "", lowerCase = "", upperCase = "", markCase = "";

            foreach (char elem in TextArray)
            {
                if (char.IsLower(elem))
                {            //IsLower-Methode checkt ob das elem(=die Variable) klein geschrieben ist, dann gibt sie true zurück
                    lowerCase += elem;
                }
                if (char.IsUpper(elem))
                {
                    upperCase += elem;
                }
                if (char.IsWhiteSpace(elem))
                {
                    spaceresult += elem;                                        

                }
                if (elem == '!')
                {
                    markCase += elem;
                }
            }
            Console.WriteLine(lowerCase);
            Console.WriteLine(upperCase);
            Console.WriteLine(spaceresult);
            Console.WriteLine(markCase);
        }

        public static void Zahlenlöschen(int intervallStart, int intervallEnde)
        {
            string input = "749813247132984712039487123049871204398712039487";

            char[] inputArray = input.ToCharArray();

            foreach (char c in inputArray)
            {
                if ((int)c <= 50 || (int)c >= 52)
                {
                    Console.Write(c);
                }
            }
            string result = input;
            for (int i = intervallStart; i <= intervallEnde; i++)
            {
                char numberToReplace = (char)(i + 48);
                result = result.Replace(numberToReplace, ' ');
            }

            Console.WriteLine(result);
        }
    }
}

/* char[] ZahlenArray = input.ToCharArray();

int[] Counter = new int[65536];             //warum diese hohe zahl? das ist die größe einer tabelle in der alle Zeichen abgespeichert sind

foreach (char c in ZahlenArray)             
{
    Counter[c]++;
    if (Counter[c] < 49)
    {
        Console.WriteLine(c);
    }
} */
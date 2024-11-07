using System;

namespace AlessioGaudio.Week02
{
    public class ConsoleInputt
    {
        public static void DatenTest()
        {
            bool isParseble = false;
            string inteingabe;
            Console.WriteLine("Gib einen Integer ein:");
            inteingabe = Console.ReadLine();

            TryParsingInt(isParseble, inteingabe);
        }

        public static void TryParsingInt(bool isTrue, string eingabe)
        {
            int isInt;
            if (!int.TryParse(eingabe, out isInt))
            {
                Console.WriteLine("Das ist kein Integer, versuche es nochmal.");
                DatenTest();            
            }
            else
            {
                Console.WriteLine(eingabe + " ist ein Integer.");
                TryParsingDouble();
            }
        }

        public static void TryParsingDouble()
        {
            double isDouble;
            Console.WriteLine("Gib einen Double ein: ");
            string doublewert = Console.ReadLine();

            if (!double.TryParse(doublewert, out isDouble))
            {
                Console.WriteLine("Das eingegebene ist kein Double, versuche es nochmal.");
                TryParsingDouble();
            }
            else
            {
                Console.WriteLine(doublewert + " ist ein Double.");
                TryParsingChar();      
            }
        }

        public static void TryParsingChar()
        {
            char isChar;
            Console.WriteLine("Gib einen Char ein: ");
            string charwert = Console.ReadLine();

            if (!char.TryParse(charwert, out isChar))
            {
                Console.WriteLine("Das eingegebene ist kein Char, versuche es nochmal.");
                TryParsingChar();
            }
            else
            {
                Console.WriteLine(charwert + " ist ein Char.");
            }
        }
    }
}

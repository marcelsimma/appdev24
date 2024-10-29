using System;

namespace MagdalenaMueller.Week04
{
    public class CountSymbols
    {
        public static void CountSymbolsProgramm()
        {
            Console.WriteLine("Gib deinen Text ein:");
            string? text = Console.ReadLine();

            char[] abc = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'ä', 'ö', 'ü', 'ß'};
            char[] letterArray = text?.ToCharArray();

            for(int indexcounter = 0; indexcounter < abc.Length; indexcounter++)
            {
                int lettercounter = 0;
                
                for (int i = 0; i < letterArray.Length; i++)
                {
                    if (char.ToLower(letterArray[i]) == abc[indexcounter])
                    {
                        lettercounter++;
                    }
                }
                
                Console.WriteLine($"{abc[indexcounter]}: {lettercounter}");
                
                
                if (char.IsLetter(abc[indexcounter]))
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"{char.ToUpper(abc[indexcounter])}: {lettercounter}");
                    Console.ResetColor();
                }
                
            }
            
        }
    }
}
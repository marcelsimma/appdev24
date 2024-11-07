using System;

namespace JonasWehinger.Week02
{

    public class Shuffle
    {
        public static void Shuffle_t()
        {
            Console.WriteLine("Willkommen zum Zufallsshuffle Programm");
        Console.Write("Gib ein Wort ein>>>");
        
        
        string eingabe = Console.ReadLine();
        
        
        string gemischt = ShuffleString(eingabe);
        
        
        Console.WriteLine(gemischt);
    }

    static string ShuffleString(string input)
    {
        Random random = new Random();
        char[] zeichenArray = input.ToCharArray();

        
        for (int i = 0; i < zeichenArray.Length; i++)
        {
            int j = random.Next(zeichenArray.Length);
            
            char temp = zeichenArray[i];
            zeichenArray[i] = zeichenArray[j];
            zeichenArray[j] = temp;
        }

        return new string(zeichenArray);
    }
    }
}

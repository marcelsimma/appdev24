using System;

namespace LucasSchiemann.Week04;

public static class BuchstabenZähler
{
    public static void Start()
    {
    {
 
        string text = "Hallo wie geht es dir.";
        char[] textarray =  text.ToCharArray();
        int[] charCount = new int[66000];
 
        foreach (char c in text)
        {
            charCount[c]++;    
       }
        Console.WriteLine("Das wurde gezählt im Text:");
        for (int i = 0; i < charCount.Length; i++)
        {
            if (charCount[i] > 0)
            {
               
                //Console.WriteLine($ (char)i );
            }
        }
    }
    }
}    
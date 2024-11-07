using System;
namespace AlessioGaudior.Week04
{
 
    public class Zaehler
    
    {
        public static void Start()
    {
 
        string text = "Wir schreiben den 22.10.2024";
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
               
                Console.WriteLine($"'{(char)i}' : {charCount[i]}");
            }
        }
    }
    }
}
using System;
using System.Text.RegularExpressions;

namespace LucasSchiemann.Week04;

public static class NummerErkennen
{
    public static void Start()
    {
        string ModellNummber = "+43 178 6800756";
        NummberChecker(ModellNummber);
    }
    public static void NummberChecker(string NumberToCheck)
    {
        
        string pattern = @"\b\d{3}-\d{3}-\d{4}\b";
        if (Regex.IsMatch(NumberToCheck,pattern))
        {
            Console.WriteLine(NumberToCheck + "ist eine Richtig formatierte Telefonnummer");

        }
        else{
            Console.WriteLine("Deine eingegebene Telefonnummer ist nicht richtig Fornatiert.\nVersuch es nochmal");
        }
    }
}
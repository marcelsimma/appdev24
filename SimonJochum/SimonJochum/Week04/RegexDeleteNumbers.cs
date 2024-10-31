using System;
using System.Text.RegularExpressions;

public class RegexDeleteNumbers
{
    public static void Start()
    {
        ReplaceWord();
        DeleteLowercase();
        DeleteUppercase();
        DeleteWhiteSpaces();
        DeleteExclamationMark();
        DeleteAllNumbers();
        DeleteDigitsExclusive0();
        DeleteDigitsFrom2To4();
        KeepDigits0AndFrom4to5();
        
    }

    public static void ReplaceWord()
    {
        string wordToRemove = GetText();
        string pattern = "wird"; // Pattern für das Wort das ersetzt werden soll

        Console.WriteLine(GetText());

        // Ersetzt wird durch war
        string finalString = Regex.Replace(wordToRemove, pattern, "war");
        Console.WriteLine("Task 1a: " + finalString);

        // Ersetzt wird durch ist
        string finalString2 = Regex.Replace(wordToRemove, pattern, "ist");
        Console.WriteLine("Task 1b: " + finalString2);
    }

    public static void DeleteLowercase()
    {
        string textToDelete = GetText();
        string pattern = "[a-z]"; // Pattern für die Kleinbuchstaben

        // Entfernt alle Kleinbuchstaben aus dem String
        string finalString = Regex.Replace(textToDelete, pattern, "");
        Console.WriteLine("Task 2: " + finalString);
    }

    public static void DeleteUppercase()
    {
        string textToDelete = GetText();
        string pattern = "[A-Z]"; // Pattern für die Großbuchstaben

        // Entfernt alle Großbuchstaben aus dem String
        string finalString = Regex.Replace(textToDelete, pattern, "");
        Console.WriteLine("Task 3: " + finalString);
    }

    public static void DeleteWhiteSpaces()
    {
        string textToDelete = GetText();
        string pattern = @"\ "; // Pattern für das Leerzeichen

        // Entfernt alle Leerzeichen aus dem String
        string finalString = Regex.Replace(textToDelete, pattern, "");
        Console.WriteLine("Task 4: " + finalString);
    }

    public static void DeleteExclamationMark()
    {
        string textToDelete = GetText();
        string pattern = @"\!"; // Pattern für das !

        // Entfernt alle ! aus dem String
        string finalString = Regex.Replace(textToDelete, pattern, "");
        Console.WriteLine("Task 5: " + finalString);
    }

    public static string GetText()
        {
            return "Heute wird ein guter Tag! Heute wird ein noch guterer Tag! Heute wird ein spitzen guter Tag!";
        }

    public static void DeleteAllNumbers()
    {
        string numbersToDelete = GetString();
        string pattern = @"\d"; // Pattern für Ziffern (0-9)
        
        // Entfernt alle Ziffern aus dem String
        string finalNumbers = Regex.Replace(numbersToDelete, pattern, "");
        Console.WriteLine("1. Task: " + finalNumbers);
    }

     public static void DeleteDigitsExclusive0()
    {
        string numbersToDelete = GetString();
        string pattern = "[1-9]"; // Pattern für Ziffern (1-9)
        
        // Entfernt alle Ziffern außer 0 aus dem String
        string finalNumbers = Regex.Replace(numbersToDelete, pattern, "");
        Console.WriteLine("2. Task: " + finalNumbers);
    }

     public static void DeleteDigitsFrom2To4()
    {
        string numbersToDelete = GetString();
        string pattern = "[2-4]"; // Pattern für Ziffern (2-4)
        
        // Entfernt alle Ziffern zwischen 2 und 4 aus dem String
        string finalNumbers = Regex.Replace(numbersToDelete, pattern, "");
        Console.WriteLine("3. Task: " + finalNumbers);
    }

    public static void KeepDigits0AndFrom4to5()
    {
        string numbersToDelete = GetString();
        string pattern = "[1-36-9]"; // Pattern für Ziffern (1-3 & 6-9)
        
        // Entfernt alle Ziffern außer 0, 4 und 5 aus dem String
        string finalNumbers = Regex.Replace(numbersToDelete, pattern, "");
        Console.WriteLine("4. Task: " + finalNumbers);
    }

    public static string GetString()
    {
        return "749813247132984712039487123049871204398712039487";
    }
}

using System;
using System.Text.RegularExpressions;

namespace LucasSchiemann.Week04;

public static class EmailRecogniser
{
    public static void Start()
    {
        Console.WriteLine("Gib deine Email ein und Überprüfe ob sie Richtig ist");
        var emailToCheck = Console.ReadLine(); 
        string emailPattern = @"\b[A-Z0-12._%+-]+@[A-Z0-12.-]+\.[A-Z]{2,}\b";
        bool isEmailValid = Regex.IsMatch(emailToCheck,emailPattern);
        Console.WriteLine(isEmailValid);
        /*
        if (isEmailValid == true)
        {
            Console.WriteLine(emailToCheck+"ist eine Richtig formatierte e-mail");
        }
        else{
            Console.WriteLine("Die eingegebene E-mail ist Falsch Formatiert");
            Start();
        }
        */
    }
}
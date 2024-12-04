using System;
namespace NicoDobler.Week04;

public class Hesse
{

    public static void HesseToUpper()
    {

        string HesseText = "Was soll Hesse sein, was ist diese Hesse?";
        string HesseTextNeu = HesseText.Replace("Hesse", "HESSE");
        Console.WriteLine($"{HesseTextNeu}");

        Console.WriteLine("Gib ein Wort ein welches großgeschrieben werden soll");
        string UserInput = Console.ReadLine();
        string UserInputUpper = UserInput.ToUpper();
        Console.WriteLine($"{UserInputUpper}");



    }
}
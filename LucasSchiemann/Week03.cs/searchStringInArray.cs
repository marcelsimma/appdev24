
using System;
using System.Security.Cryptography.X509Certificates;
using LucasSchiemann.Week01;

namespace LucasSchiemann.Week03;

public static class SearchingInArray
{
    public static void Processor()
    {
        string[] shuffleString = new string[10];
        shuffleString = ["Null", "eins", "zwei", "drei", "vier", "fünf", "sechs", "sieben", "Acht", "Neun",];
        Printer(shuffleString);        
    }
    public static void Printer(string[] shuffelString)
    {
        Console.WriteLine("Gib eine zahl ein und lese damit denn Richtigen wert aus");
        Console.WriteLine("Die Eingabe möglichkeiten sind: ");
        bool TrueVariable = false;
        while (TrueVariable == false)
        {
            foreach (string value in shuffelString)
            {
                Console.WriteLine(value);
            }
            int UserInput = Convert.ToInt32(Console.ReadLine());
            if (UserInput > 10 && UserInput < 0)                                                                                                                        
            {
                Console.WriteLine("Die Zahl ist zu Groß oder zu klein versuch es nochmal");
                TrueVariable = false;
            }
            else
            {
                Console.WriteLine(shuffelString[UserInput]);
                TrueVariable = true;
            }
        }
    }
}
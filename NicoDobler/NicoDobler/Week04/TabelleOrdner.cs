using System;
namespace NicoDobler.Week04

{
 
    public class TabelleOrdner()
    {
        public static void Ordner()
    {
        string[] firstName = { "Alfonso", "Beatrix-Eleonor", "Cecil", "Daniel", "Elmar" };
        string[] lastName = { "Klein", "Kinderdorfer", "Al Elmenar", "Schmidt", "Simma" };
        int[] age = { 40, 78, 5, 18, 81 };
        string[] place = {"Wien", "Schwarzach", "Wiener Neudorf", "Sankt Pölten", "Sankt Pölten"};
        float[] distanceFromCapital = {0f, 654.4f, 12.457634366f, 120.0f, 119.9999f};
        PrintTable(firstName, lastName, age, place, distanceFromCapital);
    }
    public static void PrintTable(string[] firstNames, string[] lastNames, int[] ages, string[] places, float[] distances)
    {
 
        for (int i = 0; i < firstNames.Length; i++)
            {
                Console.WriteLine($"{ firstNames[i],-20} { lastNames[i],-25} { ages[i],-5} { places[i],-20} { distances[i],-15}");
            }
 
    }
 
    }
}
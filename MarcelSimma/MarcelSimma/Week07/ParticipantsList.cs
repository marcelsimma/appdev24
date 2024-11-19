using System;
using System.Collections.Generic;

namespace MarcelSimma.Week07 {


class ParticipantsList
{
    public static void Start()
    {
        // Ein Dictionary erstellen
        Dictionary<string, string> dictionary = new Dictionary<string, string>();

        // Elemente hinzufügen
        dictionary.Add("eins", "Apfel");
        dictionary.Add("zwei", "Banane");
        dictionary.Add("drei", "Orange");

        // Zugriff auf ein Element
        Console.WriteLine($"Schlüssel 2 hat den Wert: {dictionary["drei"]}");

        // Iterieren durch das Dictionary
        Console.WriteLine("Inhalt des Dictionary:");
        foreach (KeyValuePair<string, string> kvp in dictionary)
        {
            Console.WriteLine($"Schlüssel: {kvp.Key}, Wert: {kvp.Value}");
        }
    }
}
}
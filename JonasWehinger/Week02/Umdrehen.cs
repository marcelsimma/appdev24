using System;

namespace JonasWehinger.Week02
{

    public class Umdrehen
    {

        

        public static void Drehen()
        {
            Console.WriteLine("Wilkommen zum Reverseprogramm!");
            Console.Write("Wort eingeben>>>");

            string word = Console.ReadLine();

            string umgedreht = ShuffleString(word);
        
        // Ausgabe des umgedrehten Wortes
        Console.WriteLine(umgedreht);
    }

    static string ShuffleString(string eingabe)
    {
        string umgedreht = "";
        for (int i = eingabe.Length - 1; i >= 0; i--)
        {
            umgedreht += eingabe[i];
        }
        return umgedreht;
    }
}
}
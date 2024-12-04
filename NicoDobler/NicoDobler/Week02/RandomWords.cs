using System;
namespace NicoDobler.Week02{



class RandomWords
{
    public static void RandomCalc()
    {
        Console.Write("Bitte geben Sie ein Wort ein: ");
        string eingabe = Console.ReadLine();

        // Array
        char[] buchstaben = eingabe.ToCharArray();
        Random random = new Random();

        // Buchstaben vertauschen
        for (int i = 0; i < buchstaben.Length; i++)
        {
            int j = random.Next(i, buchstaben.Length); // Zufälligen Index wählen
            // Buchstaben vertauschen
            char temp = buchstaben[i];
            buchstaben[i] = buchstaben[j];
            buchstaben[j] = temp;
        }

        // neuer String mit neuer Anordnung
        string vertauschtesWort = new string(buchstaben);
        Console.WriteLine($"Das vertauschte Wort ist: {vertauschtesWort}");
    }
}
}